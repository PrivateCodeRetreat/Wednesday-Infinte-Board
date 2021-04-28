using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;

namespace UnitTestProject1
{
    [UseReporter(typeof(DiffReporter))]
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BlankBoardRenderedAt0_0()
        {
            var board = new Board();
            var result = board.RenderAt(0, 0);
            Approvals.Verify(result);
        }

        [TestMethod]
        public void ABoardPopulatedAtTwoVisibleLocationsRenderedAt0_0()
        {
            var board = new Board();
            board.SetCellAlive(new Point {x = 2, y = 3});
            board.SetCellAlive(new Point {x = 4, y = 5});
            var result = board.RenderAt(0, 0);
            Approvals.Verify(result);
        }

        [TestMethod]
        public void ABoardPopulatedAtOneVisibleLocationAndOneInvisibleLocationRenderedAt0_0()
        {
            var board = new Board();
            board.SetCellAlive(new Point {x = -2, y = -3});
            board.SetCellAlive(new Point {x = 4, y = 5});
            var result = board.RenderAt(0, 0);
            Approvals.Verify(result);
        }

        [TestMethod]
        public void ABoardPopulatedAt_n2_n3_and_4_5_RenderedAt0_0()
        {
            var board = new Board();
            board.SetCellAlive(new Point {x = -2, y = -3});
            board.SetCellAlive(new Point {x = 4, y = 5});
            var result = board.RenderAt(-4, -4);
            Approvals.Verify(result);
        }

        [TestMethod]
        public void PointTests()
        {
            var points = new Point[]
            {
                new Point {x = 0, y = 0},
                new Point {x = 2, y = 3},
                new Point {x = -5, y = 0},
                new Point {x = -12, y = 0},
                new Point {x = 25, y = 30},
                new Point {x = -45, y = 50},
                new Point {x = 60, y = -75},
                new Point {x = -83, y = -97},
            };
            Approvals.VerifyAll(
                points,
                p => $"{p} -> {p.GetGridHash()}"
            );
        }
    }
}