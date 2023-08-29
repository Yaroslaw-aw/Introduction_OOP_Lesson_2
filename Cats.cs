namespace Семинар_2
{
    internal class Cats
    {
        public Cat[] cats;
        public int size = 0;

        public Cats()
        {
            int random = new Random().Next(5, 15);

            cats = new Cat[random];

            for (int i = 0; i < random; i++)
            {
                int appetite = new Random().Next(10, 20);
                cats[i] = new Cat(string.Format($"Cat{i + 1}"), appetite);
                this.size++;
            }
        }

        public void CatsInfo()
        {
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i].CatInfo();
            }
        }
    }
}
