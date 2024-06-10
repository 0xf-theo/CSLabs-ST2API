using Lab2.Ex1;
using Lab2.Ex3;

/*-------EXERCISE 1-------*/
Console.WriteLine("/*-------EXERCISE 1-------*/");
Exercise1.PrimeSender sender = new Exercise1.PrimeSender();
Exercise1.PrimeReceiver receiver = new Exercise1.PrimeReceiver();

// Subscribe the Action method of PrimeReceiver to the PrimeEvent of PrimeSender
sender.PrimeEvent += receiver.Action;

// Calculate prime numbers up to a given limit
long limit = 100;
sender.CalculatePrimes(limit);
Console.WriteLine("/*-------------------------*/");
/*-------------------------*/

/*-------EXERCISE 3-------*/
Console.WriteLine("/*-------EXERCISE 3-------*/");
var printer = new Exercise3.SystemResource("Printer");
var ram = new Exercise3.SystemResource("RAM");
var disk = new Exercise3.SystemResource("Disk");

var resources = new List<Exercise3.SystemResource> { printer, ram, disk };

var askResource1 = new Exercise3.AskResource();
askResource1.AddResourceRequest(printer, 5);
askResource1.AddResourceRequest(ram, 10);
askResource1.AddResourceRequest(disk, 3);

var askResource2 = new Exercise3.AskResource();
askResource2.AddResourceRequest(ram, 2);
askResource2.AddResourceRequest(printer, 7);
askResource2.AddResourceRequest(disk, 5);

var askResource3 = new Exercise3.AskResource();
askResource3.AddResourceRequest(disk, 10);
askResource3.AddResourceRequest(ram, 4);
askResource3.AddResourceRequest(printer, 6);

var askResources = new List<Exercise3.AskResource> { askResource1, askResource2, askResource3 };

var threads = new List<Thread>();
foreach (var askResource in askResources)
{
    var thread = new Thread(new ThreadStart(askResource.AcquireResource));
    threads.Add(thread);
    thread.Start();
}

foreach (var thread in threads)
{
    thread.Join();
}

Console.WriteLine("All resource requests have been processed.");
Console.WriteLine("/*-------------------------*/");
/*-------------------------*/
