using System;
using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces;

public class Pawn : Piece
{
    public Pawn(Player player)
        : base(player)
    {
    }

    public override IEnumerable<Square> GetAvailableMoves(Board board)
    {
        var currentSquare = board.FindPiece(this);
        List<Square> result = new List<Square>();
        int squaresToMove = 1;

        if(currentSquare.Col == 3 || currentSquare.Col == 5) squaresToMove = 2;  

        if(Player == Player.White)
        {
            result.Add(new Square(currentSquare.Row - squaresToMove, currentSquare.Col));                            
        } 
        else 
        {
            result.Add(new Square(currentSquare.Row + squaresToMove, currentSquare.Col));                
        }
        return result;
    }
}