using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPP.Models
{
 public interface IStudentRepository
    {
        public bool Insert(Student s);
    }
}
