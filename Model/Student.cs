using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace EntityFramework2.Model
{
    public class Student
    {
         
        //public Guid Id1 { get; set; }

        [Key]//primary Key
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }


     

    }
}
