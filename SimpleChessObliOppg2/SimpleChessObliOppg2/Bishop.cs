using System;

namespace SimpleChessObliOppg2
{
    internal class Bishop : Piece
    {
        public Bishop()
        {
            Symbol = "Bishop";
        }
        public override bool Move(string fromPosition, string toPosition)
        {
            if (Symbol == "Bishop")
            {
                var diffCol = fromPosition[0] - toPosition[0];
                var diffRow = fromPosition[1] - toPosition[1];
                return Math.Abs(diffRow) == Math.Abs(diffCol);
            }
            return true;
        }
    }
}