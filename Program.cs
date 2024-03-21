// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
       Director nonveg=new Director();
     MealBuilder nonvegMeal = new NonVegeterianMeal();
    nonveg.makeMeal(nonvegMeal);
    Meal meal = nonvegMeal.GetProduct();
    Console.WriteLine("Non-Vegeterian Meal");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine(meal);
    }
}
