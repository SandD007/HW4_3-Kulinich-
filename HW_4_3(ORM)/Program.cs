using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HW43
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using (ApplicationContext context = new AppFactory().CreateDbContext(Array.Empty<string>()))
            {
                // Запрос, который объединяет 3 таблицы и обязательно включает Include 
                var employeesWithTitlesAndOffices = context.Employees
                    .Include(a => a.Office)
                    .Include(a => a.Title)
                    .ToList();

                // Запрос, который возвращает разницу между CreatedDate/HiredDate и сегодня. Фильтрация должна быть выполнена на сервере.
                var today = DateTime.Today;
                var employees = context.Employees
                    .Select(e => (today - e.HiredData))
                    .ToList();

                // Запрос, который обновляет 2 сущности. Сделать в одной  транзакции
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var employee = context.Employees
                            .FirstOrDefault(e => e.EmployeeId == 1);
                        employee.FirstName = "Kozel";

                        var office = context.Offices
                            .FirstOrDefault(o => o.OfficeID == 1);
                        office.Location = "New location";
                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }

                // Запрос, который добавляет сущность Employee с Title и Project
                var title = context.Titles.FirstOrDefault(t => t.Name == "Title2");
                var project = context.Projects.FirstOrDefault(p => p.Name == "CSGO");
                var employe = new Employee
                {
                    FirstName = "Valentin",
                    LastName = "Pupkin",
                    HiredData = today,
                    DateOfBirht = new DateTime(195, 01, 01),
                    OfficeId = 1,
                    TitleId = title.TitleId,
                };
                context.Employees.Add(employe);
                context.SaveChanges();
                var newEmployeeProject = context.EmployeeProjects
                    .FirstOrDefault(p => p.ProjectId == project.ProjectId);
                newEmployeeProject.EmployeeId = employe.EmployeeId;
                context.SaveChanges();

                // Запрос, который удаляет сущность Employee 
                var deletedEmployee = context.Employees
                    .Include(a => a.Office)
                    .Include(a => a.Title)
                    .ToList()
                    .FirstOrDefault(e => e.FirstName == "Nina");
                if (deletedEmployee != null)
                {
                    context.Employees.Remove(deletedEmployee);
                    context.SaveChanges();
                }

                // Запрос, который группирует сотрудников по ролям и возвращает название роли (Title) если оно не содержит ‘a’
                var employeeByTitle = context.Employees
                    .GroupBy(e => e.Title)
                    .ToList()
                    .Where(e => !e.Key.Name.ToLower().Contains('a'))
                    .ToList();
            }
        }
    }
}