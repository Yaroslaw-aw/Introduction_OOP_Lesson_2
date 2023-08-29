namespace Семинар_2
{
    internal class Cat
    {
        readonly string name;
        int appetite;
        bool satiety = false;
        string Name { get { return this.name; } }
        public int Appetite { get { return this.appetite; } }

        public Cat(string name, int appetite)
        {
            this.name = name;
            this.appetite = appetite;
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
