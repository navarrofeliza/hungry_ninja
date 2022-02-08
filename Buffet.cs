namespace HungryNinja
{
    public List<Food> Menu;
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Pizza", 900, false, false, true),
            new Food("Burrito", 600, false, false, true),
            new Food("Ice Cream", 950, true, false, false),
            new Food("Caprese Salad", 400, false, true, true),
            new Food("Miso Soup", 200, false, false, true),
            new Food("Milk Tea", 150, false, true, false),
            new Food("Hamburger", 800, false, false, true),
        };
    }
    public Food Serve()
    {
        Random r = new Random();
        return Menu[r.Next(Menu.Count)];
    }
}