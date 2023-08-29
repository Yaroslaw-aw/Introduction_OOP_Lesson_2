namespace Семинар_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Барсик", 10);
            cat.CatInfo();

            Plate plate = new Plate(100);
            plate.FoodInfo();
            plate.AddFood(18);
            plate.FoodInfo();

            cat.Eat(plate.EatenFood(cat.Appetite));

            cat.CatInfo();
            plate.FoodInfo();

            Cats catShelter = new Cats();
            Console.WriteLine(new string('-', 50));

            catShelter.CatsInfo();
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < catShelter.cats.Length; i++)
            {
                catShelter.cats[i].Eat(plate.EatenFood(catShelter.cats[i].Appetite));
                catShelter.cats[i].CatInfo();
                plate.FoodInfo();
            }
            Console.WriteLine(new string('-', 50));

            catShelter.CatsInfo();
            plate.FoodInfo();
        }
    }
}
