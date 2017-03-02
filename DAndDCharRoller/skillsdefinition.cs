using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAndDCharRoller
{
    public class skillsdefinition
    {
        public skillsdefinition() { }
        public skillsdefinition(string skill,
            int value)

        {
            this.skill = skill;
            this.value = value;

        }
        
        public string skill { get; set; }
        public int value { get; set; }
 

    }
}
