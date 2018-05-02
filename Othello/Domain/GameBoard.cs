using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Othello.Domain
{
    public class GameBoard
    {
        public List<GameBoardPosition> Positions { get; private set; }

        public GameBoard( List<GameBoardPosition> positions )
        {
            Positions = positions;
        }

        public GameBoard RecordMove( int row, int column, int playerNumber )
        {
            var updatedPosition = new GameBoardPosition( row, column, playerNumber );
            var positionIndex = Positions.FindIndex( p => p.Row == row && p.Column == column );

            Positions[ positionIndex ] = updatedPosition;

            return this;
        }
    }
}
