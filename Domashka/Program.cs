// See https://aka.ms/new-console-template for more information
Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
Console.Write("c=");
int c = int.Parse(Console.ReadLine());
double d;
string itog;
d = a + 2*b + 3*c;
itog = a + " + 2*" + b + " + 3*" +  c + " = " + d;
Console.WriteLine(itog);