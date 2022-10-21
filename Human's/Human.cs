using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_s
{
    abstract class Human
    {
        protected string _name;
        protected string _surName;

        public abstract void ChangeWork();

        public virtual void Work()
        {

        }
    }
}
