

using VariablesAndConditions;

Console.WriteLine("Proccess: 1- Example For Number Is Zero, Positive or Negative Default");
Console.WriteLine("Proccess: 2- Example For Number Is Zero, Positive or Negative With TenraryOperator");
Console.WriteLine("Proccess: 3- Example For Determining a Day Name");
Console.WriteLine("Proccess: 4- Example For Basic Calculator");
Console.WriteLine("Proccess: 5- Example For Finding Biggest Number");
Console.WriteLine("Proccess: 6- Example For Password Controller");


Console.Write("Enter a proccess number: ");
var selectedProccess = Convert.ToInt32(Console.ReadLine());


switch (selectedProccess)
{
    case 1:
        NumberDetermining.NumberDetermine();
        break;

    case 2:
        NumberDetermining.NumberDetermine(useTenraryOperator: true);
        break;

    case 3:
        DayDetermining.DayDetermine();
        break;

    case 4:
        Calculator.Calculate();
        break;

    case 5:
        NumberDetermining.FindBiggestNumber();
        break;

    case 6:
        PasswordController.Control();
        break;

    default:
        Console.WriteLine("Invalid process!");
        break;
}
