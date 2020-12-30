/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class Band1Appointment : Appointment
    {
        private double cost = 22.70;
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
