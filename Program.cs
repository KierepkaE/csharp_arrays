using System;

namespace BuiltInMethods {
  class Program {
    static void Main (string[] args) {
      string[] summerStrut;

      summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

      int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

      int index = Array.IndexOf (ratings, 3);
      Console.WriteLine ($"Song number {index + 1} is rated three stars");

      string t = Array.Find (summerStrut, title => title.Length > 10);
      Console.WriteLine ($"The first song that has more than 10 characters in the title is {t}");

      var number = new int[3] { 1, 2, 3 };
      string list = string.Join (",", numbers);
      string name = "John";
      char firstChar = name[0];
    }

    Array.Sort (summerStrut);
    Console.WriteLine (summerStrut[0]);
    Console.WriteLine (summerStrut[7]);
  }
}