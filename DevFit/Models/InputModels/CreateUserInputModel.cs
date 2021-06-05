using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFit.Models.InputModels
{
    public class CreateUserInputModel
    {
        public string FullName { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
