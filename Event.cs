using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailoutMaker
{
    class Event
    {
        public String name;
        public String date;
        public String location;
        public String time;
        public String detailParagraph;
        public EventImage eventImage;

        public Event(String name, String date, String location, String time, String imgUrl, String description)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.time = time;
            this.eventImage = new EventImage(imgUrl, "oops");
            detailParagraph = description;
        }

        public override String ToString()
        {
            String eventString = "<h3>" + name + "</h3>\n";
            eventString += "<p>" + detailParagraph + "</p>\n";
            eventString += "\n";
            eventString += "<ul>\n";
            eventString += "\t<li>Date: " + date + "</li>\n";
            eventString += "\t<li>Location: " + location + "</li>\n";
            eventString += "\t<li>Time: " + time + "</li>\n";
            eventString += "</ul>\n\n";
            if(eventImage != null)
                eventString += eventImage;
            return eventString;
        }
    }
}
