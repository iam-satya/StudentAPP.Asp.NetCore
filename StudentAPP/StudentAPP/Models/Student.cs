using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPP.Models
{
  
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

       
        public string Student_Name { get; set; }

  
        public int Student_Class { get; set; }

       
        public int Student_Number { get; set; }

 
        public string Student_School { get; set; }
        public string Student_Gender { get; set; }



    }
}