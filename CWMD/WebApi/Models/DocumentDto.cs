using Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class DocumentDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime UpdatedDate { get; set; }

        [ForeignKey("Persons")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }

        [ForeignKey("Documents")]
        public int PrincipalDocumentId { get; set; }
        public virtual Document Document { get; set; }

        public string Version { get; set; }
    }
}