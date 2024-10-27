using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = "John";
      int age = 30;
      float height = 5.6F;
      double salary = 4000.500;
      bool trueorfalse = true;
      char letter = 'J';
      
      Console.WriteLine($"{name} is a {age} years old person with {height} feet height and has a salary of {salary} USD per month. The char type data enclosed under single qoutetion like '{letter}'. The expresions can be checked if true or false with bool data type like: {trueorfalse}.");
     }
  }
}
