using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFit.Core.Entities
{
    public class Meal : BaseEntity
    {
        public Meal(string description, int calories, DateTime date, int userId) : base()
        {
            Description = description;
            Calories = calories;
            Date = date;
            UserId = userId;
        }

        public string  Description { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }

        public void Update(string description, int calories, DateTime date)
        {
            Description = description;
            Calories = calories;

        }
    }
}
