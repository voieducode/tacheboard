using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TacheBoard.Web.Models;

namespace TacheBoard.Web.Controllers
{
    public class ServicesController : RavenApiController 
    {
//GET /admin/api/v1/services HTTP/1.1
//{
//    "services": [
//        {
//            "name": "Example Foo",
//            "id": "example-foo",
//            "description": "An explanation of this service"
//            "url": "/api/v1/services/example-foo",
//            "current-event": {
//                'message': 'What an event!',
//                'sid': 'ahJpc215d2Vic2VydmljZWRvd25yCwsSBUV2ZW50GA8M',
//                'status': {
//                    'description': 'Hey, dude',
//                    'id': 'up',
//                    'image': '/images/status/tick-circle.png',
//                    'level': 'NORMAL',
//                    'name': 'Up',
//                    'url': '/statuses/up'
//        },
//                'timestamp': 'Mon, 28 Jun 2010 22:17:06 GMT',
//                'url': '/services/twilio/events/ahJpc215d2Vic2VydmljZWRvd25yCwsSBUV2ZW50GA8M'},

//        },
//        {
//            "name": "Example Bar",
//            "id": "example-bar",
//            "description": "An explanation of this service"
//            "url": "/api/v1/services/example-bar",
//            "current-event": null,
//        }
//    ]
//}
        public IEnumerable<Service> GetAllServices()
        {
            return new Service[] {};
        }

    }
}
