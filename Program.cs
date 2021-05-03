using System;
using System.Collections.Generic;
using QueenAttack;

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("Enter x-coordinate of Queen (letter):" );
    string xCoordinate = Console.ReadLine();
    char xChar = char.Parse(xCoordinate);
    int xCoordInt = Convert.ToInt32(xChar) - 96;

    Console.WriteLine("Enter y-coordinate of Queen (number):" );
    string yCoordinate = Console.ReadLine();
    int yCoordInt = int.Parse(yCoordinate);

    Queen yourQueen = new Queen(xCoordInt, yCoordInt);

    Console.WriteLine("Enter x-coordinate of Other piece (letter):" );
    string xCoordinateOP = Console.ReadLine();
    char xCharOP = char.Parse(xCoordinateOP);
    int xCoordIntOP = Convert.ToInt32(xCharOP) - 96;

    Console.WriteLine("Enter y-coordinate of Other piece (number):" );
    string yCoordinateOP = Console.ReadLine();
    int yCoordIntOP = int.Parse(yCoordinateOP);

    bool canAttack = yourQueen.canAttack(xCoordIntOP, yCoordIntOP);
    if (canAttack == true)
    {
      Console.WriteLine("Yes the Queen can attack!");
    }
    else 
    {
      Console.WriteLine("Queen cannot attack");
    }
  }
}


