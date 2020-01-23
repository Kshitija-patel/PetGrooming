using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        public int GroomServiceID { get; set; }
        public string GroomServiceName { get; set; }
        public int GroomServiceDuration { get; set; }
        // Described in minutes (i.e 1hour=60 minutes)
        public decimal GroomSericeCost { get; set; }
        public string GroomServiceGrommer { get; set; }
        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
    }
}