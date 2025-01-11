//Section 11
//Combining Generic with Delegates to make a sorting algorith

namespace MyApp_EventsAndDelg_2;

class Program
{

    public delegate int CompareValues<T>(T a, T b);

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    public class PersonSorter
    {
        public void Sort(Person[] people, CompareValues<Person> compare)
        {
            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (compare(people[i], people[j]) > 0)
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }

            }
        }
    }



    static void Main(string[] args)
    {
        Person[] people =
        {
            new Person { Age = 18, Name = "Alice" },
            new Person { Age = 23, Name = "Bob" },
            new Person { Age = 31, Name = "Car" },
            new Person { Age = 42, Name = "Denis" }
            
        };
      
        PersonSorter sorter = new PersonSorter();
        sorter.Sort(people, CompareByAge);
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} is {person.Age} years old.");
            
        }
        
        sorter.Sort(people, CompareByName);
        foreach (Person person in people)
        {
            Console.WriteLine($"{person.Name} is {person.Age} years old.");
            
            
        }
        Console.ReadKey();

    }

    static int CompareByAge(Person a, Person b)
    {
        return a.Age.CompareTo(b.Age);
    }

    static int CompareByName(Person a, Person b)
    {
        return a.Name.CompareTo(b.Name);
    }
    
   
}