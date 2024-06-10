using Lab4.Ex1_1;
using Lab4.Ex1_2;
using Lab4.Ex1_3;


/*------EXERCISE 1_1------*/
Console.WriteLine("/*------EXERCISE 1_1------*/");
Console.WriteLine("Starting threads...");

Thread t1 = new Thread(new ThreadStart(Exercise1_1.IncrementValue));
Thread t2 = new Thread(new ThreadStart(Exercise1_1.DecrementValue));


t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine($"Final value of sharedValue: {Exercise1_1.sharedValue}");
Console.WriteLine("/*-------------------------*/");
/*-------------------------*/

/*------EXERCISE 1_2------*/
Console.WriteLine("/*------EXERCISE 1_2------*/");
Console.WriteLine("Starting threads...");

Thread t3 = new Thread(new ThreadStart(Exercise1_2.IncrementValue));
Thread t4 = new Thread(new ThreadStart(Exercise1_2.DecrementValue));

t3.Start();
t4.Start();

t3.Join();
t4.Join();

Console.WriteLine($"Final value of sharedValue: {Exercise1_2.sharedValue}");
Console.WriteLine("/*-------------------------*/");
/*-------------------------*/

/*------EXERCISE 1_3------*/
Console.WriteLine("/*------EXERCISE 1_3------*/");
Console.WriteLine("Starting threads...");

Thread t5 = new Thread(new ThreadStart(Exercise1_3.IncrementValue));
Thread t6 = new Thread(new ThreadStart(Exercise1_3.DecrementValue));

t5.Start();
t6.Start();

t5.Join();
t6.Join();

Console.WriteLine($"Final value of sharedValue: {Exercise1_3.sharedValue}");
Console.WriteLine("/*-------------------------*/");
/*-------------------------*/