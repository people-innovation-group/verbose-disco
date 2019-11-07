using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    /// <summary>
    /// Top Level Org Container
    /// </summary>
    public class Org
    {
        [Key]
        public int Id { get; set; }
        public string SourcedId { get; set; }
        public string Status { get; set; }
        public DateTime DateLastModified { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Identifier { get; set; }
        public string ParentSourcedId { get; set; }
    }

}