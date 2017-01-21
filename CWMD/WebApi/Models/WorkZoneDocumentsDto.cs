using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Dtos
{
    public class WorkZoneDocumentsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Flow { get; set; }
    }
}
