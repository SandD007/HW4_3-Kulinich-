using System;
using Microsoft.EntityFrameworkCore;

namespace HW43
{
    public class Office
    {
        public int OfficeID { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }
    }
}
