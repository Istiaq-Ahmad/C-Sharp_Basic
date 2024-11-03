using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      //strings can carry word/lines under double quote like "asdasdsdasda sadasasdasd sadasdasd".
      string name = "John";
      //int carry integer numbers  
      int age = 30;
      //float can carry decimal number with a F after the inputed value
      float height = 5.6F;
      //double can carry bigger values (15 digit)
      double salary = 4000.500;
      //bool is a flag carry true or false 
      bool trueorfalse = true;
      //char can carry single letter within single quote like 'a'
      char letter = 'J';
      
      Console.WriteLine($"{name} is a {age} years old person with {height} feet height and has a salary of {salary} USD per month. The char type data enclosed under single qoutetion like '{letter}'. The expresions can be checked if true or false with bool data type like: {trueorfalse}.");

      //Constants
      
      //with the keyword const before datatype we can make the variable constant and unchangable in future
      const int number = 15; 
      const string example_line = "Hello World";
      
      //Type Casting
      //  two types : Implicit Casting (auto) and Explicit Casting (manual)
      
      // 1. Implicit Casting (auto):     char -> int -> long -> float -> double\
      int example_1 = 10;
      double example_2 = example_1; //int automaticly converted to double
  
      // 2. Explicit Casting (manual):     double -> float -> long -> int -> char
      double example_3 = 10.10;
      int example_4 = (int) example_3; //manually casting 
      
    
    }
  }
}
