using Singleton;

Tools t1 = Tools.GetInstance();
Tools t2 = Tools.GetInstance();

if (t1 == t2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}