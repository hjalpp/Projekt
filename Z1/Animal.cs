using System;
using System.Runtime.CompilerServices;

namespace Z1
{
    public abstract class Animal : IComparable<Animal>, IAnimal
    {
        private string name;
        public string Name 
        {
            get => name; 
            set => name = value;
        }

       public Animal(string name)
        {
            this.name = name;
        }

        public int CompareTo(Animal other)
        {
            return name.CompareTo(other.name);
        }
        public bool Equals(Animal other)
        {
            return name == other.name;
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public void MakeSound()
        {

        }
    } 
}
