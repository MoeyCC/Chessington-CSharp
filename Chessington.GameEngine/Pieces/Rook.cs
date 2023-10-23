using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces;

public class Rook : Piece
{
    public Rook(Player player)
        : base(player)
    {
    }

    public override IEnumerable<Square> GetAvailableMoves(Board board)
    {
        List<Square> moves = new List<Square>();

        for (var i = 0; i < 8; i++)
            moves.Add(Square.At(4, i));

        for (var i = 0; i < 8; i++)
            moves.Add(Square.At(i, 4));
        
        moves.RemoveAll(s => s == Square.At(4, 4));

        return moves;
    }
}