using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenMethods
{
    abstract class SuperHero
    {
        public string Name { get; set; }
        public string SuperPower { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"{Name} обладает супер силой - {SuperPower}.\n");
        }
    }
    class X_Men : SuperHero
    {
        public X_Men()
        {
            Name = "Росомаха";
            SuperPower = "регенирация";
        }
    }
    class Avenger : SuperHero
    {
        public Avenger()
        {
            Name = "Халк";
            SuperPower = "безграничная мощь и выносливость";
            Color = "зелёный";
        }
        public string Color { get; set; }
        public override void Print()
        {            
            Console.WriteLine($"Следующий герой - {Name}. Он имеет {Color} цвет.");
            base.Print();
        }
    }
    class JusticeLeague : SuperHero
    {

        public JusticeLeague()
        {
            Name = "Бэтмен";
            SuperPower = "пиковая физическая форма, ум, технологии и деньги";
        }
        public override void Print()
        {
            Console.WriteLine($"{Name} самый преземлённый супер герой, его супер сила - это {SuperPower}.\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tГерои комиксов.\n");
            X_Men x = new X_Men();
            Console.WriteLine("Наследование базового метода базового класса:");
            x.Print();
            Avenger avenger = new Avenger();
            Console.WriteLine("Переопределение базового метода базового класса + базовый метод:");
            avenger.Print();
            JusticeLeague jl = new JusticeLeague();
            Console.WriteLine("Переопределение базового метода базового класса:");
            jl.Print();
        }
    }
}
