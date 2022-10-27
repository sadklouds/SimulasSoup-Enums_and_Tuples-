// shows possible options for creating soup
ChoiceMenu(); 

// Converts the intergers from call methods to enum types 
Food foodOption = (Food)ValidFoodOption();
MainIngrediant ingrediantOption = (MainIngrediant)ValidIngrediantOption();
Seasoning seasonOption = (Seasoning)ValidSeasonOption();

var soup = (foodOption, ingrediantOption, seasonOption);

Console.WriteLine($"\n{soup.foodOption} {soup.ingrediantOption} {soup.seasonOption}");

//shows possible options for creating soup
void ChoiceMenu()
{
    Console.WriteLine("Options for Simulas Soup");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Food Types: \n1: Soup \n2: Stew \n3: Gumbo");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Main Ingrediants: \n1: Mushrooms \n2: Chicken \n3: Carrots \n4: Potatoes");
    Console.WriteLine("---------------------------");
    Console.WriteLine("Seasonings: \n1: Spicy  \n2: Salty \n3: Sweet");
    Console.WriteLine("---------------------------");
}

int ValidFoodOption()
{
    while (true)
    {
        Console.Write("Choose a food type(number): ");
        string strFood = Console.ReadLine();
        //int foodOption = int.Parse(Console.ReadLine());
        if(int.TryParse(strFood, out int foodOption))
        {
            if (foodOption > 0 && foodOption <= 3) return foodOption;
            else Console.WriteLine("Unknown food type");
        }
        else Console.WriteLine("User input was not Valid");
    }
}
int ValidIngrediantOption()
{
    while (true)
    {
        Console.Write("Choose an ingrediant(number): ");
        string strIngrediant = Console.ReadLine();
        if (int.TryParse(strIngrediant, out int ingrediantOption))
        {
            if (ingrediantOption > 0 && ingrediantOption <= 4) return ingrediantOption;
            else Console.WriteLine("Unknown ingrediant");
        }
        else Console.WriteLine("User input was not Valid");
       
    }
}
int ValidSeasonOption()
{
    while (true)
    {
        Console.Write("Choose a seasoning(number): ");
        string strSeason = Console.ReadLine();
        //int seasonOption = int.Parse(Console.ReadLine());
        if(int.TryParse(strSeason, out int seasonOption))
        {
            if (seasonOption > 0 && seasonOption <= 3) return seasonOption;
            else Console.WriteLine("Unkown seasoning");
        }
        Console.WriteLine("User input was not Valid");
    }
}

enum Food {Soup = 1, Stew, Gumbo}
enum MainIngrediant {Mushrooms = 1, Chicken, Carrots, Potatoes}
enum Seasoning {Spicy = 1 , Salty, Sweet}