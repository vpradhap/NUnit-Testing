using NUnit_Testing;

Console.WriteLine("\n\tN-Unit Testing Programs\n");
Console.WriteLine("0 - Enter Zero to Exit ");
Console.WriteLine("1 - Day of Week Program");

int flag = 0;
while (flag == 0)
{
    Console.Write("\nPick A Program To Perform : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    switch (pick)
    {
        case 0:
            flag = 1;
            break;
        case 1:
            DayofWeek.DayWeek();
            break;
        default:
            Console.WriteLine("Invalid Pick");
            break;
    }
}