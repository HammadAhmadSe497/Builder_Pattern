public class Meal{
    public string Sandwich { get; set; }
    public string Fries { get; set; }
    public string Drink { get; set; }
    public override string ToString(){
        return string.Format("Sandwich: {0},\n Fries: {1},\n Drink: {2}", Sandwich, Fries, Drink);
    }

} 