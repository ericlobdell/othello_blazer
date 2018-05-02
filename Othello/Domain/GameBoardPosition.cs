namespace Othello.Domain
{
    public class GameBoardPosition
    {
        public int Row { get; }
        public int Column { get; }
        public int Player { get; }

        public GameBoardPosition( int row, int column, int playerNumber )
        {
            Guards.ThrowIf(
                (row < 0 || row > 7, "Row number must be between 0 and 7"),
                (column < 0 || column > 7, "Column must be a number between 0 and 7"),
                (playerNumber < 1 || playerNumber > 2, $"Invalid player number {playerNumber}") );

            Row = row;
            Column = column;
            Player = playerNumber;
        }
    }
}
