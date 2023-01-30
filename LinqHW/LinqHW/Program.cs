using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

//1
List<int> a = new List<int> { 1, 2, 3, 4, 4, 4 };

var h = a.Distinct().OrderBy(x => x);
foreach (var item in h)
{
    Console.WriteLine(item);
}

//2
string s = "damn look at that ass";

var n = s.Split(" ").Average(x => x.Length);
Console.WriteLine(n);

int Average(string x)
{
    return x.Length;
}

//3
List<string> list = new List<string>() { "apple", "banana", "baloon", "car", "ab", "abbbb" };
var newList = list.Where(x => x.StartsWith('a'))
            .Where(x => x.EndsWith('b'));

foreach (var item in newList)
{
    Console.WriteLine(item);
}

//4
List<Stu> students = new List<Stu>
{
    new Stu{Name="Doron", ID=1},
    new Stu{Name="Shtuz", ID=2},

};
List<Grade> grade = new List<Grade>
{
    new Grade{Points=10, ID=1},
    new Grade{Points=50, ID=2},

};

var combineList = students.Join(grade,
    (n) => n.ID,
    (g) => g.ID,
    (n, g) => new { Name = n.Name, Points = g.Points });

foreach (var item in combineList)
{
    Console.WriteLine(item);
}



//5


public static class ExtensionMethod
{
    public static void PrintAll<T>(this IEnumerable<T> list)
    {
        foreach (T item in list)
        {
            Console.WriteLine(item);
        }
    }

    public static T ReturnType<T>(this IEnumerable<T> collection, Func<T, int> predecate)
    {
        T item=default;
        int heightest = 0;

        foreach(var i in collection)
        {
            if(predecate.Invoke(i)>heightest)
            {
                heightest = predecate.Invoke(i);
                item= i;
            }
        }
        return item;
    }

    public static T ReturnType<T>(this IEnumerable<T> collection) where: is IComparable<T>
    {
        T i = default;
        int heightest = 0;

        foreach(var item in collection)
        {
            
        }
        return i;
    }
}






public class IDK
{
    public int Index { get; set; }
    //public T GetByValue<T>(IEnumerable<T> enumerable, Func<T, int> valueSelector)
    //{
    //    return true;
    //}
    public override string ToString()
    {
        return "" + Index;
    }
}

class Stu
{
    public string Name { get; set; }
    public int ID { get; set; }

}
class Grade
{
    public int Points { get; set; }
    public int ID { get; set; }
}

