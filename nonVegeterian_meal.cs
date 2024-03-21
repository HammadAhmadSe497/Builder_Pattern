class NonVegeterianMeal: MealBuilder{
    private Meal meal= new Meal();
 public override void AddSandwich()
 {
        meal.Sandwich = "Chicken Burger";
    }
    public override void AddDrinks()
    {
        meal.Drink = "Medium Coke";
    }

    public override void AddFries()
    {
        meal.Fries = "Large Fries";
    }

    public override Meal GetProduct()
    {
        return meal;
    }
}