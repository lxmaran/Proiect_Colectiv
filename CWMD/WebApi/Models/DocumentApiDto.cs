using Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DocumentApiDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int PrincipalDocumentId { get; set; }
        public virtual Document Document { get; set; }
        public string Version { get; set; }
        public string Flow { get; set; }
    }
}