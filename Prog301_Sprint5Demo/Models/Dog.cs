using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prog301_Sprint5Demo.Models
{
    public interface IBarkable
    {
        string BarkSound { get; set; }
        string Bark();
    }
    public interface IEatable
    {
        int Weight { get; set; }
        void Eat();
        void Poop();
    }

    public interface IIAboutable
    {
        string Name { get; set; }
        string About();
    }
    public interface IDog : IBarkable,IEatable,IIAboutable { }


    // INotifyPropertyChanged
    // Allows the dog to notify the WPF Interface that the property has changed.
    public class Dog : IDog
    {
        

        //Private Instance Data Members
        protected string name;
        protected int age;
        protected int weight;

        //Two ways to set up properties
        public string Name { get { return this.name; } 
            set 
            { 
                this.name = value; 
            } 
        } // Longer expression/way
        
        
        public int Age { get => age; set => age = value; } // Shorter expression/way



        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                weight = value;
            }
        }
        public string BarkSound { get; set; }

        public Dog()
        {
            this.Name = "fido";
            this.Age = 1;
            this.Weight = 1;
            this.BarkSound = "woof!";
        }

        public string About()
        {
            return $"Hello, my name is {this.Name}";
        }

        public string Bark()
        {
            return this.BarkSound;
        }

        /*public void Eat(int HowMuch = 1)
        {
            this.Weight += HowMuch;
        }*/
        public void Eat()
        {
            this.Weight++;
        }
        public void Eat(int HowMuch)
        {
            this.Weight += HowMuch;
        }
        public void Poop()
        {
            this.Weight--;
        }
    }
}
