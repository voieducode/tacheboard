using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TacheBoard.Web.Models
{
    /// <summary>
    /// A list to group services.
    /// </summary>
    public class ServiceList
    {
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }  
    }
}