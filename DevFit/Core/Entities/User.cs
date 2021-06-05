using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFit.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, decimal height, decimal weight, DateTime birthDate) : base()
        {
            FullName = fullName;
            Height = height;
            Weight = weight;
            BirthDate = birthDate;

            
        }

        public string FullName { get; private set; }
        public decimal Height { get; private set; }
        public decimal  Weight { get; private set; }
        public DateTime BirthDate { get; private set; }

        public IEnumerable<Meal> Meals { get; set; }

        public void Update (decimal height, decimal weight)
        {
            Height = height;
            Weight = weight;
        }
    }
}
