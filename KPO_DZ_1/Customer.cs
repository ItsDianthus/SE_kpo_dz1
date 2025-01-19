using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace KPO_DZ_1
{
    public class Customer
    {
        public required string Name { get; set; }

        public Car? Car { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Номер машины: {Car?.Number ?? -1}";
        }
    }
}
