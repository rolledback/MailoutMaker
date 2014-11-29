using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailoutMaker
{
    class Mailout
    {
        public String greeting;
        public String introduction;
        public String ending;
        public String signature;
        public ArrayList sections;

        public Mailout(String greeting, String introduction, String ending, String signature)
        {
            this.greeting = greeting;
            this.introduction = introduction;
            this.ending = ending;
            this.signature = signature;
            sections = new ArrayList();
        }

        public override String ToString()
        {
            String mailout = "";
            mailout += greeting;
            mailout += "\n<br><br>\n";
            mailout += introduction;
            mailout += "\n<br>\n";

            foreach(Section s in sections) {
                mailout += "\n";
                mailout += s;
            }

            mailout += "\n<br>\n<br>\n" + ending + "\n<br>\n<br>\n" + signature;

            return mailout;
        }
    }
}
