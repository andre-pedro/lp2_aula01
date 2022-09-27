using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CuteAnimal
{
    public class Cat
    {
        private string name;
        private Mood mood;
        private Feed feed;
        private int energy;
        private Random rng;
        
        public Cat(string name, Mood mood, Feed feed) : this()
        {
            this.name = name;
            this.mood = mood;
            this.feed = feed;
        }
        public Cat(string name) : this(name, Mood.Happy, Feed.AboutToExplode) 
        {

        }

        private Cat() 
        {
            rng = new Random();
            energy = rng.Next(101);
        }

        public string GetName() => name;


    }
}