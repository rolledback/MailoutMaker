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
    public partial class MainWindow : Form {
    
        Mailout mailout;
        Dictionary<TreeNode, Object> nodeToComponent;
        TreeNode mailoutNode;

        public MainWindow()
        {
            InitializeComponent();
            nodeToComponent = new Dictionary<TreeNode, Object>();
            mailout = new Mailout("Hey everyone,", "Here is this weeks's AMC mailout!!! with images!!! #fancy", "Thanks for reading!", "~Matthemily");
            mailoutNode = new TreeNode("Mailout");
            mailoutNode.ContextMenuStrip = mailoutMenu;
            nodeToComponent.Add(mailoutNode, mailout);
            mailoutComponents.Nodes.Add(mailoutNode);

            addSection("This Week");

            Dictionary<String, String> properties = new Dictionary<String, String>();
            properties.Add("name", "LAN Party");
            properties.Add("date", "12/3/14");
            properties.Add("location", "GDC 6.302");
            properties.Add("time", "7:00PM-7:00AM");
            properties.Add("imgUrl", "http://nrn.com/site-files/nrn.com/files/imagecache/medium_img/uploads/2008/12/noodlescospaghettimeatballs.jpg");
            properties.Add("description", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            addEvent(mailoutComponents.Nodes[0].Nodes[0], properties);

        }

        public void addSection(String name)
        {
            // create the section
            Section temp = new Section(name);
            mailout.sections.Add(temp);

            // create corresponding node
            TreeNode tempSectionNode = new TreeNode(temp.name);
            tempSectionNode.ContextMenuStrip = sectionMenu;
            mailoutNode.Nodes.Add(tempSectionNode);

            nodeToComponent.Add(tempSectionNode, temp);
        }

        public void addEvent(TreeNode parent, Dictionary<String, String> properties)
        {
            // create the event
            Event temp = new Event(properties["name"],
                                    properties["date"],
                                    properties["location"],
                                    properties["time"],
                                    properties["imgUrl"],
                                    properties["description"]);
            (nodeToComponent[parent] as Section).events.Add(temp);

            // creat corresponding node
            TreeNode tempEventNode = new TreeNode(temp.name);
            tempEventNode.ContextMenuStrip = eventMenu;
            parent.Nodes.Add(tempEventNode);

            nodeToComponent.Add(tempEventNode, temp);
        }

        private void mailoutComponents_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mailoutComponents.SelectedNode.ContextMenuStrip.Show();
            }
        }

        private void refreshPrviewStrip_Click(object sender, EventArgs e)
        {
            mailoutPreview.DocumentText = mailout.ToString();
        }

        private void newSectionStrip_Click(object sender, EventArgs e)
        {
            String newName ="";
            NewSection newSectionDialog = new NewSection();
            newSectionDialog.ShowDialog();
            if (newSectionDialog.result)
            {
                newName = newSectionDialog.sectionName.Text;
                addSection(newName);
                mailoutPreview.DocumentText = mailout.ToString();
            }
        }

        private void newEventStrip_Click(object sender, EventArgs e)
        {
            NewEvent newEventDialog = new NewEvent();
            newEventDialog.ShowDialog();
            if (newEventDialog.result)
            {
                Dictionary<String, String> properties = new Dictionary<String, String>();
                properties.Add("name", newEventDialog.eventName.Text);
                properties.Add("date", newEventDialog.eventDate.Text);
                properties.Add("location", newEventDialog.eventLocation.Text);
                properties.Add("time", newEventDialog.eventTime.Text);
                properties.Add("imgUrl", newEventDialog.eventImageUrl.Text);
                properties.Add("description", newEventDialog.description.Text);
                addEvent(mailoutComponents.SelectedNode, properties);
                mailoutPreview.DocumentText = mailout.ToString();
            }
        }
    }
}
