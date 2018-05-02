using System.Collections.Generic;

namespace Othello.Domain
{
    public class GameBoard
    {
        public List<GameBoardPosition> Positions { get; }

        public GameBoard( List<GameBoardPosition> positions )
        {
            Positions = positions;
        }

        public GameBoard RecordMove( Move move )
        {
            var updatedPosition = new GameBoardPosition( move.Row, move.Column, move.Player );
            var positionIndex = Positions.FindIndex( p => p.Row == move.Row && p.Column == move.Column );

            Positions[ positionIndex ] = updatedPosition;

            return this;
        }
    }
}
