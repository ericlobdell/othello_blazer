using Othello.Domain;
using System.Collections.Generic;
using Xunit;

namespace Othello.Tests
{
    public class GameBoardTests
    {
        [Fact]
        public void RecordMove_updates_gameboard()
        {
            var positions = new List<GameBoardPosition>()
              {
                new GameBoardPosition(1, 1, 1),
                new GameBoardPosition(1, 2, 2),
              };

            var gb = new GameBoard( positions );
            var sut = gb.RecordMove( 1, 2, 1 );
            var updatedPosition = sut.Positions.Find( p => p.Row == 1 && p.Column == 2 );

            Assert.Equal( 1, updatedPosition.Player );
        }
    }
}
