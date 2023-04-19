using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HW43
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (ApplicationContext context = new AppFactory().CreateDbContext(Array.Empty<string>()))
            {
                context.Database.EnsureCreated();
            }
        }
    }
}