namespace Generics
{
    public class Program
    {
    static void Main(string[] args)
      {
            int max= GenericsMax.FindMaxNumber<int>(44, 22, 12);
            Console.WriteLine(max);
            float floatmax = GenericsMax.FindMaxNumber<float>(4.4f, 2.2f, 1.1f);
            Console.WriteLine(floatmax);
            string stringmax = GenericsMax.FindMaxNumber<string>("Pear", "Apple", "Banana");
            Console.WriteLine(stringmax);
        }
    }
}


