using System;
using System.Collections.Generic;
using System.Text;

namespace Z1
{
    public class Zoo
    {
        private List<Animal> animals = new List<Animal>();

        public List<Animal> Animals
        {
            get => animals;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            OnAnimalAdded(new AnimalEventArgs(animal));
        }
        public void OnAnimalAdded(AnimalEventArgs e)
        {
            AnimalAdded?.Invoke(this, e);
        }
        public AnimalAddedEventHandler AnimalAdded;
    }
}
