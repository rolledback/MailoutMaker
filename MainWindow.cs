using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailoutMaker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Mailout test = new Mailout("Hey everyone,", "Here is this weeks's AMC mailout!!! with images!!! #fancy", "Thanks for reading!<br><br>~Matthemily");

            Section one = new Section("This Week");
            Section two = new Section("Next Week");

            Event meeting = new Event("General Meeting: Sponsored by Jobs2Careers", "12/9/14", "GDC 6.302", "7:00PM - 8:00PM");
            meeting.detailParagraphs.Add("Come and join us at the weekly meeting. Hear about what we did last week and more specifics about what's to come this week and in the near future. In addition, Jobs2Careers will be there to talk about their company and opportunities they have for both <b>full time</b> and <b>internship</b> positions! There will also be <b>Noodles and Co.</b> for all who come!!! Make sure to bring resumes if you are interested in working at Jobs2Careers, as I'm sure they will want to take them.");
            meeting.eventImage = new EventImage("http://nrn.com/site-files/nrn.com/files/imagecache/medium_img/uploads/2008/12/noodlescospaghettimeatballs.jpg", "noodles&co");

            one.events.Add(meeting);
            one.events.Add(meeting);

            two.events.Add(meeting);
            two.events.Add(meeting);

            test.sections.Add(one);
            test.sections.Add(two);

            mailoutPreview.DocumentText = test.ToString();

            TreeNode[] oneArray = new TreeNode[] { new TreeNode("General Meeting"), new TreeNode("General Meeting") };
            TreeNode[] twoArray = new TreeNode[] { new TreeNode("General Meeting"), new TreeNode("General Meeting") };

            TreeNode[] sections = new TreeNode[] { new TreeNode("This Week", oneArray), new TreeNode("Next Week", twoArray) };
            mailoutComponents.Nodes.Add(new TreeNode("Mailout", sections));
        }
    }
}
