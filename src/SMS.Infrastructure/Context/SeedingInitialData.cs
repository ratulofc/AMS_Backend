using SMS.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Context
{
    internal class SeedingInitialData
    {
        internal static List<Class> GetClasses()
        {
            return new List<Class>
            {
                new Class
                {
                    Id = 1,
                    Name = "Class_1",
                    Year = new DateTime(2025,1,1),
                    TeacherId = null
                },
                new Class
                {
                    Id= 2,
                    Name = "Class_2",
                    Year = new DateTime(2025,1,1),
                    TeacherId = null
                },
                new Class
                {
                    Id= 3,
                    Name = "Class_3",
                    Year = new DateTime(2025,1,1),
                    TeacherId = null
                }
            };
        }

        internal static List<Subject> GetSubjects()
        {
            return new List<Subject>
            {
                new Subject
                {
                    Id = 1,
                    SubjectName = "English",
                    Description = "This is a english subject",
                    Grade = 100
                },
                new Subject
                {
                    Id = 2,
                    SubjectName = "Physics",
                    Description = "This is a Physics subject",
                    Grade = 100
                },
                new Subject
                {
                    Id = 3,
                    SubjectName = "Hindi",
                    Description = "This is a Hindi subject",
                    Grade = 100
                },
                new Subject
                {
                    Id = 4,
                    SubjectName = "Geography",
                    Description = "This is a Geography subject",
                    Grade = 100
                }
            };
        }
    }
}
