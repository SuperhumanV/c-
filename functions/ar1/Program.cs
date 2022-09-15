Console.WriteLine("Input numbers");
string? A= Console.ReadLine();
string? A1= Console.ReadLine();
string? A2= Console.ReadLine();
string? A3= Console.ReadLine();
string? A4= Console.ReadLine();
string? A5= Console.ReadLine();
string? A6= Console.ReadLine();
string? A7= Console.ReadLine();

if(A!=null&&A1!=null&&A2!=null&&A3!=null&&A4!=null&&A5!=null&&A6!=null&&A7!=null)
{
    int B = Int32.Parse(A);
    int B1 = Int32.Parse(A1);
    int B2 = Int32.Parse(A2);
    int B3 = Int32.Parse(A3);
    int B4 = Int32.Parse(A4);
    int B5 = Int32.Parse(A5);
    int B6 = Int32.Parse(A6);
    int B7 = Int32.Parse(A7);

    int[] array = new int[] { B, B1, B2, B3, B4, B5, B6, B7 };
    
    Console.WriteLine("Which number's place u wanna know?");
    
    string? find = Console.ReadLine();
    
    int n = array.Length;

    

    if(find!= null)
    {
      int index = 0;
      int find1 = Int32.Parse(find);
      
    while(index<n)
    {
        if(array[index]==find1)
        {
            Console.WriteLine(index);
        }
    index++;
    }  
    }

    
}
