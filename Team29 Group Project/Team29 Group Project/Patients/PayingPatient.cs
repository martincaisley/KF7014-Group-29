/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PayingPatient : Patient
    {
        private bool free = false;
        public override bool isFree
        {
            get
            {
                return free;
            }
            set
            {
                //isFree = value;
            }
        }

    }
}
