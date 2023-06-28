using Taking_the_train;

Stations stations = new();

Console.WriteLine("queste sono le varie fermate del treno:");

LinkedList<string> ListOfStaion = new();
ListOfStaion.AddFirst("Milano");
ListOfStaion.AddLast("Napoli");
ListOfStaion.AddLast("Venezia");
ListOfStaion.AddLast("Firenze");
ListOfStaion.AddLast("Otranto");

foreach(string station in ListOfStaion)
{
    Console.WriteLine(station);
}

Console.WriteLine("\nscegli quale operazione vuoi effettuare \n1) aggiungi nuova nuona stazione/fermata;\n2) rimuovi una nuona stazione/fermata");
int Input = int.Parse(Console.ReadLine());

if (Input == 1)
{
    Console.Write("inserisci una nuova fermata: ");

    string StopStation = stations.Add();
    ListOfStaion.AddLast(StopStation);

    Console.WriteLine("le fermate previste sono:");

    foreach(string names in ListOfStaion)
    {
        Console.WriteLine(names);
    }
}
else if (Input == 2)
{
    Console.WriteLine("le fermate previste sono:");

    foreach (string names in ListOfStaion)
    {
        Console.WriteLine(names);
    }

    Console.WriteLine("scegli quale fermata eliminare dalla lista: ");

    string NameStation = stations.Remove();
    ListOfStaion.Remove(NameStation);

    Console.WriteLine("le fermate previste sono:");

    foreach (string names in ListOfStaion)
    {
        Console.WriteLine(names);
    }
}