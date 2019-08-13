namespace SimpleChessObliOppg2
{
    public abstract class Piece
    {
        public string Symbol { get; set; }

        public abstract bool Move(string fromPosition, string toPosition);
    }
}