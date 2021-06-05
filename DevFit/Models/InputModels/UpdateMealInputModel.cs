using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFit.Models.InputModels
{
    public class UpdateMealInPutModel
    {
        public string Description { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
    }
}
