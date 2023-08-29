namespace Семинар_2
{
    internal class Cat
    {
        readonly string name;
        int appetite;
        bool satiety = false;
        string Name { get { return this.name; } }
        public int Appetite { get { return this.appetite; } set { if (value > 0) this.appetite = value; } }

        public Cat(string name, int appetite)
        {
            this.name = name;
            this.Appetite = appetite;
        }

        public void Eat(int food)
        {
            if (food < this.appetite)
            {
                return;
            }
            else
            {
                this.satiety = true;
            }
        }

        public void CatInfo()
        {
            Console.WriteLine($"{this.GetType().Name} {this.Name}; Appetite {this.Appetite}; Satiety {this.satiety}");
        }
    }
}
