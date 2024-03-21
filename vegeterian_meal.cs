// See https://aka.ms/new-console-template for more information
class VegeterianMeal : MealBuilder
{
    private Meal meal = new Meal();
    public override void AddSandwich()
    {
        meal.Sandwich = "Veggie Burger";
    }

    public override void AddFries()
    {
        meal.Fries = "Regular Fries";
    }

    public override void AddDrinks()
    {
        meal.Drink = "Small Coke";
    }

    public override Meal GetProduct()
    {
        return meal;
    }
}