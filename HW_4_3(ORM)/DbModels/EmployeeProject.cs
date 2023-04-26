using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW43
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }

        public decimal Rate { get; set; }

        public DateTime StartedData { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
