using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

class Class1
{

    public void Method1()
    {
        //Copy the code below
        List<string> greetings = new List<string>()
            { "hi", "yo", "hello", "howdy" };
        string json = JsonConvert.SerializeObject("some json");
        StringBuilder sb = new StringBuilder("ABC", 50);
    }
    public void Method2(int a, int b, int c, int d, string e, string f, string g, string h, DateTime i, DateTime j, DateTime k)
    {
    }

    public void Method3()
    {
        string HelloWorld()
        {
            return "HelloWorld!";
        }
        Console.WriteLine(HelloWorld());

    }

    public int Method4()
    {
        int x = 1;
        x = 2;
        return x;
    }

    public void Method5()
    {
        var greetings = new List<string>()
            { "hi", "yo", "hello", "howdy" };

        IEnumerable<string> enumerable()
        {
            foreach(var greet in greetings)
            {
                if(greet.Length < 3)
                {
                    yield return greet;
                }
            }

            yield break;
        }

        var shortGreeting = enumerable();
    }

}

public interface IMyInterface
{
}
public class MyClass : IMyInterface
{
    public void MyMethod()
    {
        System.Console.WriteLine("Hello World");
    }

    public string MyString { get; set; }
    public int MyInt { get; set; }
    public DateTime MyDateTime { get; set; }
    public bool MyBool { get; set; }
}
