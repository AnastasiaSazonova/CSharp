using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        public string description = "Unknown ";

        public string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
