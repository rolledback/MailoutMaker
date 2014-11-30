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
        public String description;
        public EventImage eventImage;

        public Event(String name, String date, String location, String time, String imgUrl, String description)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.time = time;
            this.eventImage = new EventImage(imgUrl, "oops");
            this.description = description;
        }

        public override String ToString()
        {
            String eventString = "<h3>" + name + "</h3>\n";
            eventString += "<p>" + description + "</p>\n";
            eventString += "\n";
            if (date != null || location != null || time != null)
            {
                eventString += "<ul>\n";
                if(date != null)
                    eventString += "\t<li>Date: " + date + "</li>\n";
                if(location != null)
                    eventString += "\t<li>Location: " + location + "</li>\n";
                if(time != null)
                    eventString += "\t<li>Time: " + time + "</li>\n";
                eventString += "</ul>\n\n";
            }
            if(eventImage != null)
                eventString += eventImage;
            return eventString;
        }
    }
}
