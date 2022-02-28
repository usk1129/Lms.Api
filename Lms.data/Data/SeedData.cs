using Lms.core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data.Data
{
    public class SeedData
    {
        public static async Task InitAsync(LmsDataContext db)
        {
            if (await db.Course.AnyAsync()) return;

            var modules = GetModules();
            await db.AddRangeAsync(modules);
            var courses = GetCourses(modules);
            await db.AddRangeAsync(courses);

            await db.SaveChangesAsync();

        }

        private static List<Module> GetModules()
        {
            var list = new List<Module>();

            list.Add(new Module { Title = "sss", StartDate = DateTime.Now });
            list.Add(new Module { Title = "dddd", StartDate = DateTime.Now });
            list.Add(new Module { Title = "easdsad", StartDate = DateTime.Now });
            list.Add(new Module { Title = "hello", StartDate = DateTime.Now });
            list.Add(new Module { Title = "asdasd", StartDate = DateTime.Now });
            list.Add(new Module { Title = "aaaa", StartDate = DateTime.Now });
            list.Add(new Module { Title = "aaaa2", StartDate = DateTime.Now });
            list.Add(new Module { Title = "aaaa3", StartDate = DateTime.Now });
            return list;
        }

        private static IEnumerable<Course> GetCourses(List<Module> modules)
        {
            var list = new List<Course>();

            list.Add(new Course { Title = "Matte", StartDate = DateTime.Now, Modules = modules.GetRange(0,2) });
            list.Add(new Course { Title = "Engelska", StartDate = DateTime.Now, Modules = modules.GetRange(2, 2) });
            list.Add(new Course { Title = "Svenska", StartDate = DateTime.Now, Modules = modules.GetRange(4, 2) });
            list.Add(new Course { Title = "Fysik", StartDate = DateTime.Now, Modules = modules.GetRange(6, 2) });

            return list;
        }
    }
}