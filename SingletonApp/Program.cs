// See https://aka.ms/new-console-template for more information
using SingletonExample;

Count c1 = Count.getInstance();
Count c2 = Count.getInstance();
c1.increment();
c2.increment();
Console.WriteLine("counter 1 : " + c1.count.ToString());
Console.WriteLine("Counter 2 : " + c2.count.ToString());
c1.increment();
Console.WriteLine("counter 1 : " + c1.count.ToString());
Console.WriteLine("Counter 2 : " + c2.count.ToString());
c2.increment();
Console.WriteLine("counter 1 : " + c1.count.ToString());
Console.WriteLine("Counter 2 : " + c2.count.ToString());
c1.increment();
c2.increment();
Console.WriteLine("counter 1 : " + c1.count.ToString());
Console.WriteLine("Counter 2 : " + c2.count.ToString());