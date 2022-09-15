Console.WriteLine("Imput 1 number");
string? line1 = Console.ReadLine();
Console.WriteLine("Imput 2 number");
string? line2 = Console.ReadLine();
Console.WriteLine("Imput 3 number");
string? line3 = Console.ReadLine();
Console.WriteLine("Imput 4 number");
string? line4 = Console.ReadLine();
Console.WriteLine("Imput 5 number");
string? line5 = Console.ReadLine();
Console.WriteLine("Imput 6 number");
string? line6 = Console.ReadLine();
Console.WriteLine("Imput 7 number");
string? line7 = Console.ReadLine();
Console.WriteLine("Imput 8 number");
string? line8 = Console.ReadLine();
Console.WriteLine("Imput 9 number");
string? line9 = Console.ReadLine();


if(line1 !=null&&line2 !=null&&line3 !=null&&line4 !=null&&line5 !=null&&line6 !=null&&line7 !=null&&line8 !=null&&line8 !=null)
{
    int num1 = Int32.Parse(line1);
    int num2 = Int32.Parse(line2);
    int num3 = Int32.Parse(line3);
    int num4 = Int32.Parse(line4);
    int num5 = Int32.Parse(line5);
    int num6 = Int32.Parse(line6);
    int num7 = Int32.Parse(line7);
    int num8 = Int32.Parse(line8);
    int num9 = Int32.Parse(line9);

    int max = num1;
    if(num2>max)  max = num2;
    if(num3>max)  max = num3;
    if(num4>max)  max = num4;
    if(num5>max)  max = num5;
    if(num6>max)  max = num6;
    if(num7>max)  max = num7;
    if(num8>max)  max = num8;
    if(num9>max)  max = num9;
    
    Console.WriteLine("max =");
    Console.WriteLine(max);
   

    

}
