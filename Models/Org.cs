using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Org
    {
        [Key]
        public Guid sourcedId { get; set; }
        public string status { get; set; }
        public DateTime dateLastModified { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string identifier { get; set; }
        public string classification { get; set; }
        public string gender { get; set; }
        public bool boarding { get; set; }
        public Guid parentSourcedId { get; set; }
    }

}