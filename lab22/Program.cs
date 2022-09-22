using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab22
{

    class Program
    {

        static void Main(string[] args)
        {
            Converter converter = new Converter(39.8, 40, 0.61, 0.027, 0.028, 1.61);
            converter.Print();
            Console.ReadKey();
        }
    }
    //Створити клас Converter.
    class Converter
    {
        private double usd { get; set; }
        private double eur { get; set; }
        private double rub { get; set; }
        private double uand { get; set; }
        private double uane { get; set; }
        private double uanr { get; set; }


        public Converter(double usd, double eur, double rub, double uand, double uane, double uanr)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
            this.uand = uand;
            this.uane = uane;
            this.uanr = uanr;
        }
        public void Print()
        {
            Console.WriteLine("Вас вітає конвертер валют Макс");
            Console.WriteLine("Оберіть операцію:");
            Console.WriteLine("\n1.Конвертація гривні в іноземну валюту \n2.Конвертація іноземної валюти у гривні");
            int vol = Convert.ToInt32(Console.ReadLine());
            switch (vol)
            { //У тілі класу створити користувальницький конструктор, який приймає три аргументи, і ініціалізує поля,
              //що відповідають курсу 3-х основних валют, по відношенню до гривні – public Converter (double usd, double eur,
              //double rub)
              //Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют,
                case 1:
                    Console.WriteLine("Виберіть валюту: \n1.Доллар \n2.Евро \n3.Рубль");
                    int vol1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введіть вашу суму у гривнях: ");
                    double uan = Convert.ToInt32(Console.ReadLine());

                    switch (vol1)
                    {
                        case 1:
                            double resd = uan / usd;
                            Console.WriteLine("Ваша сума у доларах складає: " + resd);
                            break;

                        case 2:
                            double rese = uan / eur;
                            Console.WriteLine("Ваша сума в євро складає: " + rese);
                            break;
                        case 3:
                            double resr = uan / rub;
                            Console.WriteLine("Ваша сума в євро складає: " + resr);
                            break;
                    }
                    break;
                //також програма повинна проводити конвертацію із зазначених валют у гривню.
                case 2:
                    Console.WriteLine("Виберіть валюту: \n1.Доллар \n2.Евро \n3.Рубль");
                    int vol2 = Convert.ToInt32(Console.ReadLine());

                    switch (vol2)
                    {
                        case 1:
                            Console.WriteLine("Введіть вашу суму у долларах: ");
                            double usd = Convert.ToInt32(Console.ReadLine());
                            double resud = usd / uand;
                            Console.WriteLine("Ваша сума у гривнях складає: " + resud);
                            break;

                        case 2:
                            Console.WriteLine("Введіть вашу суму у євро: ");
                            double eur = Convert.ToInt32(Console.ReadLine());
                            double resue = eur / uane;
                            Console.WriteLine("Ваша сума у гривнях складає: " + resue);
                            break;
                        case 3:
                            Console.WriteLine("Введіть вашу суму у рублях: ");
                            double rub = Convert.ToInt32(Console.ReadLine());
                            double resur = rub / uanr;
                            Console.WriteLine("Ваша сума у гривнях складає: " + resur);
                            break;

                    }
                    break;
            }

        }
    }
}