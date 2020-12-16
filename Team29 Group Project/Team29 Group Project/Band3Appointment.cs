using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class Band3Appointment : Appointment
    {
        private double cost = 222.70;
        public override double appointmmentCost
        {
            get
            {
                return cost;
            }
            set
            {
                cost = value;
            }
        }
    }
}
