using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExamples.Model
{
    internal class Employee
    {
        [Key]//primary Key
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }
        public int M3 { get; set; }
    }
}
