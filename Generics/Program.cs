namespace Generics
{
    public class Program
    {
    static void Main(string[] args)
      {
            int max= Generics_Max<int>.FindMaxNo(44, 22, 12);
            Console.WriteLine(max);
            float floatmax = Generics_Max<float>.FindMaxNo(4.4f, 2.2f, 1.1f);
            Console.WriteLine(floatmax);
            string stringmax = Generics_Max<string>.FindMaxNo("Pear", "Apple", "Banana");
            Console.WriteLine(stringmax);
        }
    }
}


