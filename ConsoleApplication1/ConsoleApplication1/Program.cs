using System;
using myfunc;//this is the function that we used
using MathWorks.MATLAB.NET.Arrays;//在MWArray.dll中，最常用的
using MathWorks.MATLAB.NET.Utility;//在MWArray.dll中，最常用的
namespace ConsoleApplication1
{
    class Program
    {
        


public Program()
{
    // Create the MATLAB instance 
    myfunc.Class1 mt = new myfunc.Class1();
    MWArray a = 3.14;
    MWArray b = 42.0;
    MWArray c = "world";
    var res = mt.myfunc(2, a, b, c);


    Console.WriteLine(res[0]);
    Console.WriteLine(res[1]);
    // Get user input to terminate program
    Console.ReadLine();
}


        static void Main(string[] args)
        {
            Program p = new Program();
            
        }
    }
}
