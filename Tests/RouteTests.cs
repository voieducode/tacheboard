using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TacheBoard.Web;
using TacheBoard.Web.Controllers;
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
            tester.WithIncomingRequest("/api/v1/services").ShouldMatchRoute("Services", "Index");
        }
    }
}
