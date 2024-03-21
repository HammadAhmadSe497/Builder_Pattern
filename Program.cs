// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
       Director nonveg=new Director();
     MealBuilder nonvegMeal = new NonVegeterianMeal();
    nonveg.makeMeal(nonvegMeal);
    Meal nonvegmeal = nonvegMeal.GetProduct();
    Console.WriteLine("Non-Vegeterian Meal");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine(nonvegmeal);
    Console.WriteLine("----------------------------------------------");
     Director veg=new Director();
     MealBuilder vegMeal = new NonVegeterianMeal();
    nonveg.makeMeal(nonvegMeal);
    Meal vegmeal = nonvegMeal.GetProduct();
    Console.WriteLine("Vegeterian Meal");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine(vegmeal);
    }
}
