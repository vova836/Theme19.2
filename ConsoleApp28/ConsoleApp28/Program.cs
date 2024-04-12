using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание1. Реализовать один интерфейс с одним методом в производном классе. 
            //DerivedClass dClass = new DerivedClass();
            //dClass.Method();

            //Задание2. Объявить один интерфейс, в котором содержатся 4 метода:
            //MyClass myClass = new MyClass();
            //Console.WriteLine("PI: " + myClass.GetPI());
            //Console.WriteLine("Целое число: " + myClass.GetInt());
            //Console.WriteLine("Квадрат 5: " + myClass.Square(5));
            //Console.WriteLine("Квадратный корень из 16: " + myClass.Sqrt(16));

            //Задание3. Создание нескольких интерфейсов, множественное наследование интерфейсов и их реализация.
            //DerivedClass dClass = new DerivedClass();
            //dClass.Method1();
            //dClass.Method2();
            //dClass.Method3();

            //Задание4. Реализация в классе Человек двух не связанных между собой интерфейсов размышления и разговора.
            //Person person = new Person();
            //person.Think();
            //person.Talk();
            //person.LoudTalk();

            //Задание5. Создание интерфейса, в котором объявлены два метода. Создание двух классов, которые будут реализовывать один и тот же интерфейс.
            //List<ISwitchable> devices = new List<ISwitchable>();

            //TVSet tv = new TVSet();
            //devices.Add(tv);

            //PersonalComputer pc = new PersonalComputer();
            //devices.Add(pc);

            //foreach (var device in devices)
            //{
            //    device.TurnOn();
            //    device.TurnOff();
            //}

            //Задание6. Создание двух интерфейсов, описывающих методы четырех основных арифметических операций и операций возведения в квадрат, извлечения квадратного корня. Описание класса А, реализующего интерфейс основных арифметических операций. Кроме этого создание класса Аа, унаследованного от класса А, но при этом не нужно заново реализовывать интерфейс, нужно только переопределить некоторые его методы.  И создание класса Ab, унаследованного от класса А и при этом реализуется интерфейс с методами возведения в квадрат, извлечения квадратного корня.
            //Aa aa = new Aa();
            //Console.WriteLine("Вычесть(5, 3): " + aa.Subtract(5, 3));
            //Console.WriteLine("Разделять(10, 2): " + aa.Divide(10, 2));

            //Ab ab = new Ab();
            //Console.WriteLine("Квадрат(4): " + ab.Square(4));
            //Console.WriteLine("Квадратный корень(16): " + ab.SquareRoot(16));

            //Задание 7.Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. Написать программу, которая выполняет проигрывание и запись.
            //Player player = new Player();

            //Console.WriteLine("=== Playing ===");
            //player.Play();
            //player.Pause();
            //player.Stop();

            //Console.WriteLine("\n=== Recording ===");
            //player.Record();
            //player.Pause();
            //player.Stop();
            Console.ReadKey();
        }
    }
}
