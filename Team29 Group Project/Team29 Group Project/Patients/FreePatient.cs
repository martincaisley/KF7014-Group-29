using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team29_Group_Project
{
    class FreePatient : Patient
    {
        private bool free = true;
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
