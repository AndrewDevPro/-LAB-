using System;
using System.Collections.Generic;

namespace Independent_work_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Cars> carsList = getCarsInStock(); 
            bool findOrNot = false;
            
            Cars customCars = createCar();
            
            for(int i = 0; i < carsList.Count; i++)
            {
                if (customCars.Equals(carsList[i]))
                {
                    Console.WriteLine("Мы нашли для вас машину!");
                    Console.WriteLine("Бренд автомобиля:"+ carsList[i].getBrand());
                    Console.WriteLine("Цвет автомобиля:" + carsList[i].getColor());
                    Console.WriteLine("Год выпуска автомобиля:" + carsList[i].getYears());
                    Console.WriteLine("Стоимость автомобиля:" + carsList[i].getCost());
                    findOrNot = true;
                }
            }


            if (!findOrNot)
            {
                Console.WriteLine("Машины не найдено!");

            }
        }
        public static Cars createCar()
        {
            Console.Write("Введите бренд авто :");
            string brand = Console.ReadLine();
            Console.Write("Введите цвет авто :");
            string color = Console.ReadLine();
            Console.Write("Введите год производства авто :");
            int years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите желаемую цену авто :");
            double cost = Convert.ToDouble(Console.ReadLine());
            return new Cars(brand, color, years, cost);
        }
        public static List<Cars> getCarsInStock()
        {
            List<Cars> carsList = new List<Cars>();
            carsList.Add(new Cars("BMW", "red", 2016, 20_000));
            carsList.Add(new Cars("Audi", "yellow", 2019, 45_900));
            carsList.Add(new Cars("Volkswagen", "grey", 2012, 12_000));
            carsList.Add(new Cars("Mercedes-Benz", "black", 2017, 26_500));
            carsList.Add(new Cars("Porsche", "blue", 2006, 13_500));
            return carsList;
        }
    }

    class Cars
    {
        private string brand;
        private string color;
        private int years;
        private double cost;

        public Cars(string brand, string color, int years, double cost)
        {
            this.brand = brand;
            this.color = color;
            this.years = years;
            this.cost = cost;
        }


        public string getBrand() {
            return brand;
        }
        public string getColor()
        {
            return color;
        }
        public int getYears()
        {
            return years;
        }

        public double getCost()
        {
            return cost;
        }

        public override bool Equals(object obj)
        {
            return obj is Cars cars &&
                   brand == cars.brand &&
                   color == cars.color &&
                   years == cars.years &&
                   cost == cars.cost;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(brand, color, years, cost);
        }

        
    }
}
