using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TacheBoard.Web;
using Xunit;
using TacheBoard;

namespace TacheBoard.Tests
{
    public class RouteTests
    {
        [Fact]
        public void TestIncomingRoutes()
        {
            var tester = new MvcRouteUnitTester.RouteTester<MvcApplication>();
        }
    }
}
