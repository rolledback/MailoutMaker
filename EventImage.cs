using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailoutMaker {
    class EventImage {
        public String imagePath;
        public String altText;

        public EventImage(String imagePath, String altText) {
            this.imagePath = imagePath;
            this.altText = altText;
        }
        public override String ToString() {
            if (imagePath != "")
                return "<img src=\"" + imagePath + "\" alt=\"" + altText + "\">\n\n";
            else
                return "";
        }
    }
}