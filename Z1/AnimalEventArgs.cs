using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    public class AnimalEventArgs : EventArgs
    {
        private Animal animal;
        public Animal Animal { get => animal; }

        public AnimalEventArgs(Animal animal)
        {
            this.animal = animal;
        }
    }
}
