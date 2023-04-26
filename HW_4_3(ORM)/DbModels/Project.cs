using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW43
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartedData { get; set; }

        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
    }
}
