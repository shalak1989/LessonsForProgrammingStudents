﻿using CalculateStuff;
using System;
using System.Collections.Generic;

namespace OverviewLesson
{
  class Program
  {
    static void Main(string[] args)
    {
      var program = new Program();
      var nameList = new List<string>() { "austin", "james" };
      var randomNumber = 0;
      program.ModifyList(nameList, randomNumber);
      //foreach (var item in nameList)
      //{
      //  Console.WriteLine(item);
      //}

      //Console.WriteLine(randomNumber);

      var number1 = 23;
      var number2 = 25;

      var calculator = new Calculator();
      var answer = calculator.Square(number1);
      Console.WriteLine(answer);

      Console.ReadLine();
    }

    public void ModifyList(List<string> listOfNames, int number)
    {
      number = 100;
      listOfNames.Add("bob");
      listOfNames = new List<string>() { "Taco" };
      listOfNames.Add("ali");
    }
  }
}
