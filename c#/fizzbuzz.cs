/*
Problem: Given an integer n, return a string array answer (1-indexed) where:
- answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
- answer[i] == "Fizz" if i is divisble by 3.
- answer[i] == "Buzz" if i is divisible by 5.
- anwser[i] == i (as a string) if none of the above conditions are true.

Run:
dotnet run //Runs the project
or
dotnet run --file fizzbuzz.cs
or
dotnet run fizzbuzz.cs //if no project file
*/

//using System.Collections.Generic; //Implicility added by modern .net
//using System; //Includes helpful things like Console and WriteLine //Implicility added by modern .net

class FizzBuzz //We can name this whatever we want unlike Java
{
  static void Main(string[] args) //string[] args enables accepting command line arguments
  {
    const int n = 100; //Where n is the number to check until
    const string fizz = "Fizz";
    const string buzz = "Buzz";
    List<string> answer = new List<string>();
    //string[] answer = [];

    for (int i = 1; i <= n; i++)
    {
      Console.Write(i.ToString() + ": ");
      if (i % 3 == 0 && i % 5 == 0)
      {
        answer.Add(fizz+buzz);
        Console.WriteLine(fizz+buzz);
      }
      else if(i % 3 == 0)
      {
        answer.Add(fizz);
        Console.WriteLine(fizz);
      }
      else if (i % 5 == 0)
      {
        answer.Add(buzz);
        Console.WriteLine(buzz);
      }
      else
      {
        answer.Add(i.ToString());
        Console.WriteLine(i);
      }
    }

    //Console.WriteLine(answer[2].ToString());
    
  }
}