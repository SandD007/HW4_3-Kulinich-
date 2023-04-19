using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HW43
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HiredData { get; set; }

        public DateTime? DateOfBirht { get; set; }

        public int OfficeId { get; set; }

        public Office Office { get; set; }

        public int TitledId { get; set; }

        public Title Title { get; set; }
    }
}
