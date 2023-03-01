double tariff = 100.0; 
double weight = 0.0; 
bool hasElevator = false;
int floor = 0; 

Console.Write("Enter the weight of the cargo (in kg): ");
weight = double.Parse(Console.ReadLine());

Console.Write("Is there an elevator? (true/false): ");
hasElevator = bool.Parse(Console.ReadLine());

if (!hasElevator)
{
    Console.Write("Enter the lift floor: ");
    floor = int.Parse(Console.ReadLine());
}

double cost = 0.0;

if (hasElevator)
{
    cost = weight * tariff / 50.0;
}
else
{
    if (floor <= 5)
    {
        cost = weight * tariff * floor / 50.0;
    }
    else if (floor <= 10)
    {
        cost = weight * tariff * 1.5 * floor / 50.0;
    }
    else if (floor <= 15)
    {
        cost = weight * tariff * 2.0 * floor / 50.0;
    }
    else if (floor <= 20)
    {
        cost = weight * tariff * 3.0 * floor / 50.0;
    }
    else
    {
        cost = weight * tariff * 5.0 * floor / 50.0;
    }
}

Console.WriteLine("The cost of lifting the cargo is: " + cost.ToString("C"));