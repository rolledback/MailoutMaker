using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailoutMaker
{
    class Section
    {
        public String name;
        public ArrayList events;

        public Section(String name)
        {
            this.name = name;
            events = new ArrayList();
        }

        public override String ToString()
        {
            String sectionString = "<h2>" + name + ":</h2>\n";
            foreach (Event e in events)
            {
                sectionString += e;
            }
            return sectionString;
        }
    }
}
