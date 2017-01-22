using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class StartTaskDto
    {
        public int DocumentId { get; set; }
        public int FlowTypeId { get; set; }
    }
}