// See https://aka.ms/new-console-template for more information
using Assessment;

Console.Write("Input the length of the plot: ");
decimal length = Convert.ToDecimal(Console.ReadLine());

Console.Write("Input the breadth of the plot: ");
decimal breadth = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the cost per unit area: ");
decimal costperunitare = Convert.ToDecimal(Console.ReadLine());

Cost plot = new Cost(length, breadth, costperunitare);
plot.CostOutput();
