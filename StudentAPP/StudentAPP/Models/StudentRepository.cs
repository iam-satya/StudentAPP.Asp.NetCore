using StudentAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StudentAPP.Models
{

    public class StudentRepository : IStudentRepository
        {
            private StudentContext context;

            public StudentRepository(StudentContext context)
            {
              
                this.context = context;
            }

           
            public bool Insert(Student s)
            {
                var query = from st in context.Students
                            where st.Student_Name == s.Student_Name
                            && st.Student_Number == s.Student_Number
                            select st;

             
                if (query.Count() >= 1)
                    return false;
                else
                {
                
                    context.Students.Add(s);
                    context.SaveChanges();
                    return true;
                }
            }
        }
    }