using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiCORSDotNet1.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime DateofJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}
