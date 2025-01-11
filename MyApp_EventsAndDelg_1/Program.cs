//Section 11
//Super Quick intro to Generics

namespace MyApp_EventsAndDelg_1;

class Program
{
    static void Main(string[] args)
    {
        int[] intArr = { 1, 2, 3, 4, 5 };
        string[] stringArr = {"one", "two", "three" , "four" };
       // PrintArray(intArr);
        //PrintArray(stringArr);
        
        string[] stringNames = { "Maria ", "Pedro ", "Liss ", "Mario " };
        
        PrintSome(stringNames);
        PrintSome(intArr);
    }
    
    
    
    // a generic Method, that accepts a generic datatype
    public static void PrintArray<T>(T[]array)
    {
        foreach (T item in array)
        {
            Console.WriteLine(item);
        }
    }
    
    
    public static void PrintSome<Tnames>(Tnames[]array)
    {
        foreach (Tnames names in array)
        {
            Console.Write(names);
        }
    }
}