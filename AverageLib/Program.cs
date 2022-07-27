Console.WriteLine("Write first number");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write second number");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write third number");
double c = Convert.ToDouble(Console.ReadLine());

double result = Library.Lib.Add(a, b, c );
Console.WriteLine(result);
Console.ReadLine();
