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
        if (Player == Player.White)
        {
            result = new List<Square>
            {
                new (currentSquare.Row - 1, currentSquare.Col)
            };            
        } 
        else 
        {
            result = new List<Square>
            {
                new Square(currentSquare.Row + 1, currentSquare.Col)
            }; 
        }        
        return result;
    }
}