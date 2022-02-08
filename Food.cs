namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;
        public bool IsSavory;
        public Food(string name, int calories, bool sweet, bool spicy, bool savory)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
            IsSavory = savory;
        }
    }
}