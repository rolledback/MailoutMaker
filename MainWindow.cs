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
            mailout = new Mailout("greeting", "introduction", "signature");
            mailoutNode = new TreeNode("Mailout");
            mailoutNode.ContextMenuStrip = mailoutMenu;
            nodeToComponent.Add(mailoutNode, mailout);
            mailoutComponents.Nodes.Add(mailoutNode);

            addSection("General Meeting");

            Dictionary<String, String> properties = new Dictionary<String, String>();
            properties.Add("name", "LAN Party");
            properties.Add("date", "12/3/14");
            properties.Add("location", "GDC 6.302");
            properties.Add("time", "7:00PM-7:00AM");
            properties.Add("imgUrl", "http://nrn.com/site-files/nrn.com/files/imagecache/medium_img/uploads/2008/12/noodlescospaghettimeatballs.jpg");
            properties.Add("imgAlt", "oops");

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
                                    properties["imgAlt"]);
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
    }
}
