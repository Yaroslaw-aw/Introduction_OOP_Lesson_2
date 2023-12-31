﻿namespace Семинар_2
{
    internal class Plate
    {
        int food;
        public int Food { get { return food; } set { if (value > 0) food = value; } }

        public Plate() { }

        public Plate(int food)
        {
            this.Food = food;
        }

        public void FoodInfo()
        {
            Console.WriteLine($"{this.GetType().Name}: {this.Food}");
        }

        public void AddFood(int food)
        {
            if (food > 0)
                this.Food += food;
        }

        public int EatenFood(int appetite)
        {
            if (this.Food < appetite) return 0;
            else { this.Food -= appetite; }
            return this.Food + appetite;
        }
    }
}
