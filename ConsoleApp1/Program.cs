 
var arr = new ConsoleApp1
    .Array
    .Array<int>();
for (int i = 0; i < 1288; i++)
{

    arr.Add(i + 1);
    Console.WriteLine($"{i} has been added to array.");
    Console.WriteLine($"{arr.Count}/{arr.Capacity}");
}

 

/// <summary>
///ilgili kolkesiyonun başından sonunda yapılabilinir. ekleme işlemi de aynısı yapılabilirnir. aradan bir yerden de yapılabilinr. 
///iş fazla detaylandırmamak adına tek bir seçimi yapmak ve yürütmektir. Remove şeklide b
/// </summary>
/// 


Console.WriteLine($"{arr.Count}/{arr.Capacity}"); //eleman eklenmediğni gösteriyoz. 
Console.ReadLine();
// dizinin boyutu nasıl artılrılır.? 2 elemanlı 3 eleman ekleyince dizi taşmıştır. 

 