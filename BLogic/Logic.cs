using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Domain;
using GalaSoft.MvvmLight.Command;

namespace BLogic
{
    public class Logic
    {
        //Поля для биндинга
        public string SushiName { get; set; }
        public string SelectedSushiType { get; set; }
        public string SelectedSupplement { get; set; }
        public Dish SelectedDish { get; set; }
        //Списки
        public ObservableCollection<Dish> Sushi { get; set; }
        public List<string> SushiTypes { get; set; }
        public List<string> SushiSupplements { get; set; }
        //Конструктор
        public Logic()
        {
            Sushi = new ObservableCollection<Dish>()
            {
                new Fugu(), new Hotate(), new Rainbow(), new Unagi(),
            };
            SushiTypes = new List<string>() {"Унаги", "Радуга", "С Фугу", "Хотатэ"};
            SushiSupplements = new List<string>() {"Обернуть лососем","Обернуть тунцом","Посыпать кунжутом","Глазировать"};
        }
        //Метод добавления блюда
        public void AddDish()
        {
            if (!string.IsNullOrEmpty(SelectedSushiType))
            {
                if (SelectedSushiType.Equals("Унаги"))
                {
                    if (!string.IsNullOrEmpty(SushiName)) 
                    {
                        Sushi.Add(new Unagi(SushiName));
                    }
                    else Sushi.Add(new Unagi());
                }
                else if (SelectedSushiType.Equals("Радуга"))
                {
                    if (!string.IsNullOrEmpty(SushiName))
                    {
                        Sushi.Add(new Rainbow(SushiName));
                    }
                    else Sushi.Add(new Rainbow());
                }
                else if (SelectedSushiType.Equals("С Фугу"))
                {
                    if (!string.IsNullOrEmpty(SushiName))
                    {
                        Sushi.Add(new Fugu(SushiName));
                    }
                    else Sushi.Add(new Fugu());
                }
                else if (SelectedSushiType.Equals("Хотатэ"))
                {
                    if (!string.IsNullOrEmpty(SushiName))
                    {
                        Sushi.Add(new Hotate(SushiName));
                    }
                    else Sushi.Add(new Hotate());
                }
            }
        }
        //Метод удаления блюдв
        public void DeleteDish()
        {
            if (SelectedDish != null)
            {
                Sushi.Remove(SelectedDish);
                SelectedDish = null;
            }
        }
        //Метод добавления допингов (приминение паттерна "Декоратор")
        public void AddSupplement()
        {
            if (SelectedDish != null)
            {
                if (!string.IsNullOrEmpty(SelectedSupplement))
                {
                    if(SelectedSupplement.Equals("Обернуть лососем"))
                    {
                        ExtraSalmon salmon = new ExtraSalmon(SelectedDish);
                        Sushi.Remove(SelectedDish);
                        Sushi.Add(salmon);
                        SelectedDish = salmon;
                    }
                    else if(SelectedSupplement.Equals("Обернуть тунцом"))
                    {
                        ExtraTuna tuna = new ExtraTuna(SelectedDish);
                        Sushi.Remove(SelectedDish);
                        Sushi.Add(tuna);
                        SelectedDish = tuna;
                    }
                    else if(SelectedSupplement.Equals("Посыпать кунжутом"))
                    {
                        SprinkleSesame sesame = new SprinkleSesame(SelectedDish);
                        Sushi.Remove(SelectedDish);
                        Sushi.Add(sesame);
                        SelectedDish = sesame;
                    }
                    else if (SelectedSupplement.Equals("Глазировать"))
                    {
                        Glazing glazing = new Glazing(SelectedDish);
                        Sushi.Remove(SelectedDish);
                        Sushi.Add(glazing);
                        SelectedDish = glazing;
                    }
                }
            }
        }
        //Команды
        private ICommand _addDish;
        private ICommand _deleteDish;
        private ICommand _addSupplement;
        public ICommand AddDishCommand
        {
            get
            {
                return _addDish ?? (_addDish = new RelayCommand(AddDish));
            }
        }
        public ICommand DeleteDishCommand
        {
            get
            {
                return _deleteDish ?? (_deleteDish = new RelayCommand(DeleteDish));
            }
        }
        public ICommand AddSupplementCommand
        {
            get
            {
                return _addSupplement ?? (_addSupplement = new RelayCommand(AddSupplement));
            }
        }
    }
}
