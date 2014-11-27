import java.util.ArrayList;
import java.io.*;

public class MailoutMaker {

    public static void main(String[] args) {
        Mailout test = new Mailout("Hey everyone,", "Here is this weeks's AMC mailout!!! with images!!! #fancy");

        Section one = new Section("This Week");
        Section two = new Section("Next Week");

        Event meeting = new Event("General Meeting: Sponsored by Jobs2Careers", "12/9/14", "GDC 6.302", "7:00PM - 8:00PM");
        meeting.detailParagraphs.add("Come and join us at the weekly meeting. Hear about what we did last week and more specifics about what's to come this week and in the near future. In addition, Jobs2Careers will be there to talk about their company and opportunities they have for both <b>full time</b> and <b>internship</b> positions! There will also be <b>Noodles and Co.</b> for all who come!!! Make sure to bring resumes if you are interested in working at Jobs2Careers, as I'm sure they will want to take them.");
        meeting.eventImage = new EventImage("http://nrn.com/site-files/nrn.com/files/imagecache/medium_img/uploads/2008/12/noodlescospaghettimeatballs.jpg", "noodles&co");

        one.events.add(meeting);
        one.events.add(meeting);
        one.events.add(meeting);

        two.events.add(meeting);
        two.events.add(meeting);
        two.events.add(meeting);

        test.sections.add(one);
        test.sections.add(two);

        makeMailout(test);

    }

    public static void makeMailout(Mailout mailout) {
        System.out.println(mailout.toString());
    }
}


class Mailout {
    String greeting;
    String introduction;
    ArrayList<Section> sections;

    public Mailout(String greeting, String introduction) {
        this.greeting = greeting;
        this.introduction = introduction;
        sections = new ArrayList<Section>();
    }

    public String toString() {
        String mailout = "";
        mailout += greeting;
        mailout += "\n<br><br>\n";
        mailout += introduction;
        mailout += "\n<br>\n";

        for(Section s: sections) {
            mailout += "\n";
            mailout += s;
        }

        return mailout;
    }
}

class Section {
    String name;
    ArrayList<Event> events;

    public Section(String name) {
        this.name = name;
        events = new ArrayList<Event>();
    }

    public String toString() {
        String sectionString = "<h2>" + name + ":</h2>\n";
        for(Event e: events) {
            sectionString += e;
        }
        return sectionString;
    }

}

class Event {
    String name;
    String date;
    String location;
    String time;
    ArrayList<String> detailParagraphs;
    EventImage eventImage;

    public Event(String name, String date, String location, String time) {
        this.name = name;
        this.date = date;
        this.location = location;
        this.time = time;
        detailParagraphs = new ArrayList<String>();
    }

    public String toString() {
        String eventString = "<h3>" + name + "</h3>\n";
        for(String p: detailParagraphs) {
            eventString += "<p>" + p + "</p>\n";
        }
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

class EventImage {
    String imagePath;
    String altText;

    public EventImage(String imagePath, String altText) {
        this.imagePath = imagePath;
        this.altText = altText;
    }

    public String toString() {
        return "<img src=\"" + imagePath + "\" alt=\"" + altText + "\">\n\n";
    }
}
