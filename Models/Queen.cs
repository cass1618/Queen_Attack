using System;

namespace QueenAttack {
  public class Queen 
  {
    public int XPosition; 
    public int YPosition; 
      
    public Queen(int xPos, int yPos) 
    {
      XPosition = xPos; 
      YPosition = yPos;
    }
    
    public bool canAttack(int xPosOtherPiece, int yPosOtherPiece) //coordinates of other piece
    {
      if ( xPosOtherPiece > 8 || xPosOtherPiece < 0 || yPosOtherPiece > 8 || yPosOtherPiece < 0)
      {
        Console.WriteLine("This position is off the board.");
        return false;
      }
      else if (xPosOtherPiece == XPosition || yPosOtherPiece == YPosition)
      {
        return true;
      }
      else if (Math.Abs(xPosOtherPiece - XPosition) == Math.Abs(yPosOtherPiece - YPosition))
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

  }
}

// //QUEEN (1,1)

// (1+1, 1+1)
// (2,2)
// (1+6, 1+6)
// (7,7)

// //QUEEN (2,1) B1
// (3,2), (4,3), (5,4), (1,2)
// Add same number to both OR subtract same
// C2, D3, E4, A2

// // QUEEN (5,5)
// NE (6,6),(7,7),(8,8)
// SW (4,4),(3,3)
// NW (4,6), (3,7)
// SE (6,4), (7,3)

// Queen (5,5)
// Piece (3,7)

// Abs(3-5)
// Abs(7-5)
// (2,2)

// Abs(yPiece - yQueen) == Abs(xPiece - xQueen)
// TRUE