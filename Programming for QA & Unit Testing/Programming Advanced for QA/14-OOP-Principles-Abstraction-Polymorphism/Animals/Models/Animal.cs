namespace Animals.Models;

public abstract class Animal
{
    private string name;
    private string favouriteFood;

    public string Name
    {
        get => name;
        private set
        {
            name = value;
        }
    }

    public string FavouriteFood
    {
        get => favouriteFood;
        private set
        {
            favouriteFood = value;
        }
    }

    public Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }

    public abstract string ExplainSelf();
}
