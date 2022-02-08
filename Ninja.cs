namespace HungryNinja
{
    class Ninja{
        private int caloriesEaten;
        public List<Food> History;
        public Ninja()
        {
            caloriesEaten = 0;
            History = new List<Food>();
        }
        public bool IsFull
        {
            get
            {
                return caloriesEaten > 1200;
            }
        }
        public bool Eat(Food meal)
        {
            if(!IsFull)
            {
                caloriesEaten += meal.Calories;
                History.Add(meal);
                Console.WriteLine($"Time to eat some delicious {meal.Name}");
            }
            else
            {
                Console.WriteLine("Too full to wat anymore!");
            }
            return IsFull;
        }
    }
}