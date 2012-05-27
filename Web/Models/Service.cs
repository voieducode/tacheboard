using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacheBoard.Web.Models
{
    /// <summary>
    /// A service to track
    /// </summary>
    public class Service
    {
        public string Id { get; set; }  
        public string Name { get; set; }  
        public string Description { get; set; }
        public Event CurrentEvent { get; set; }
    }
}