using Othello.Domain;
using System;
using Xunit;

namespace Othello.Tests
{
    public class GameBoardPositionTests
    {
        [Fact]
        public void Throws_when_row_negative()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new GameBoardPosition( -1, 1, 1 ) );

            Assert.Contains( "Row", ex.Message );
        }

        [Fact]
        public void Throws_when_row_greater_than_7()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new GameBoardPosition( 8, 1, 1 ) );

            Assert.Contains( "Row", ex.Message );
        }

        [Fact]
        public void Does_not_throw_when_row_valid()
        {
            var sut = new GameBoardPosition( 1, 1, 1 );
        }

        [Fact]
        public void Throws_when_column_negative()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new GameBoardPosition( 1, -1, 1 ) );

            Assert.Contains( "Column", ex.Message );
        }

        [Fact]
        public void Throws_when_column_greater_than_7()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new GameBoardPosition( 1, 8, 1 ) );

            Assert.Contains( "Column", ex.Message );
        }

        [Fact]
        public void Does_not_throw_when_column_valid()
        {
            var sut = new GameBoardPosition( 1, 1, 1 );
        }

        [Fact]
        public void Throws_when_player_number_invalid()
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new GameBoardPosition( 1, 1, 3 ) );

            Assert.Contains( "player", ex.Message );
        }

        [Fact]
        public void Does_not_throw_when_player_number_valid()
        {
            var sut = new GameBoardPosition( 1, 1, 1 );
        }
    }
}
