using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailoutMaker {
    public partial class MainWindow : Form {

        Mailout mailout;
        Dictionary<TreeNode, Object> nodeToComponent;
        TreeNode mailoutNode;

        public MainWindow() {
            // init all components, including the dictionary
            InitializeComponent();
            mailoutPreview.Navigate("about:blank");
            nodeToComponent = new Dictionary<TreeNode, object>();
            mailoutComponents.NodeMouseClick += (sender, args) => mailoutComponents.SelectedNode = args.Node;
        }

        public void addSection(String name) {
            // create the section
            Section temp = new Section(name);
            mailout.sections.Add(temp);

            // create corresponding node
            TreeNode tempSectionNode = new TreeNode(temp.name);
            tempSectionNode.ContextMenuStrip = sectionMenu;
            mailoutNode.Nodes.Add(tempSectionNode);

            // add node and section to the dictionary
            nodeToComponent.Add(tempSectionNode, temp);
        }

        public void addEvent(TreeNode parent, Dictionary<String, String> properties) {
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

            // add node and event to the dictionary
            nodeToComponent.Add(tempEventNode, temp);
        }

        private void mailoutComponents_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            // show dialog strip for node when right clicking
            if (e.Button == MouseButtons.Right) {
                mailoutComponents.SelectedNode.ContextMenuStrip.Show();
            }
        }

        private void newSectionStrip_Click(object sender, EventArgs e) {
            // create dialog and add section if user selects ok
            NewSection sectionDialog = new NewSection();
            sectionDialog.StartPosition = FormStartPosition.CenterParent;

            if (sectionDialog.ShowDialog(this) == DialogResult.OK) {
                addSection(sectionDialog.sectionName.Text);
                mailoutPreview.DocumentText = mailout.ToString();
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void newEventStrip_Click(object sender, EventArgs e) {
            // create dialog and add event if user selects ok
            NewEvent eventDialog = new NewEvent();
            eventDialog.StartPosition = FormStartPosition.CenterParent;

            if (eventDialog.ShowDialog(this) == DialogResult.OK) {
                Dictionary<String, String> properties = new Dictionary<String, String>();
                properties.Add("name", eventDialog.eventName.Text);
                properties.Add("date", eventDialog.eventDate.Text);
                properties.Add("location", eventDialog.eventLocation.Text);
                properties.Add("time", eventDialog.eventTime.Text);
                properties.Add("imgUrl", eventDialog.eventImageUrl.Text);
                properties.Add("description", eventDialog.eventDescription.Text);
                addEvent(mailoutComponents.SelectedNode, properties);
                mailoutPreview.DocumentText = mailout.ToString();
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void saveMailoutToolStripMenuItem_Click(object sender, EventArgs e) {
            // show save file dialog
            if (mailout != null) {
                saveMailoutDialog.Filter = "HTML File|*.html";
                saveMailoutDialog.FileName = "mailout.html";
                saveMailoutDialog.ShowDialog();
            }
        }

        private void saveMailoutDialog_FileOk(object sender, CancelEventArgs e) {
            // write mailout directly to text
            File.WriteAllText(saveMailoutDialog.FileName, mailout.ToString());
        }

        private void editSectionStrip_Click(object sender, EventArgs e) {
            // cast the component mapped to the node to a section, if it is not a section just quit
            Section correspondingSection = nodeToComponent[mailoutComponents.SelectedNode] as Section;
            if (correspondingSection == null)
                return;

            // create dialog, change the name of it, and set text fields to match section properties
            NewSection sectionDialog = new NewSection();
            sectionDialog.StartPosition = FormStartPosition.CenterParent;
            sectionDialog.Text = "Edit Section";
            sectionDialog.sectionName.Text = correspondingSection.name;

            // change the node string and section properties if user selects ok
            if (sectionDialog.ShowDialog(this) == DialogResult.OK) {
                correspondingSection.name = sectionDialog.sectionName.Text;
                mailoutComponents.SelectedNode.Text = sectionDialog.sectionName.Text;
                mailoutPreview.DocumentText = mailout.ToString();
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void editEventStrip_Click(object sender, EventArgs e) {
            // cast the component mapped to the node to an event, if it is not an event just quit
            Event correspondingEvent = nodeToComponent[mailoutComponents.SelectedNode] as Event;
            if (correspondingEvent == null)
                return;

            // create dialog, change the name of it, and set text fields to match event properties
            NewEvent eventDialog = new NewEvent();
            eventDialog.StartPosition = FormStartPosition.CenterParent;
            eventDialog.Text = "Edit Event";
            eventDialog.eventName.Text = correspondingEvent.name;
            eventDialog.eventDate.Text = correspondingEvent.date;
            eventDialog.eventLocation.Text = correspondingEvent.location;
            eventDialog.eventTime.Text = correspondingEvent.time;
            eventDialog.eventImageUrl.Text = correspondingEvent.eventImage.imagePath;
            eventDialog.eventDescription.Text = correspondingEvent.description;

            // change the node string and event properties if the user selects ok
            if (eventDialog.ShowDialog(this) == DialogResult.OK) {
                Dictionary<String, String> properties = new Dictionary<String, String>();
                correspondingEvent.name = eventDialog.eventName.Text;
                correspondingEvent.date = eventDialog.eventDate.Text;
                correspondingEvent.location = eventDialog.eventLocation.Text;
                correspondingEvent.time = eventDialog.eventTime.Text;
                correspondingEvent.eventImage.imagePath = eventDialog.eventImageUrl.Text;
                correspondingEvent.description = eventDialog.eventDescription.Text;
                mailoutComponents.SelectedNode.Text = eventDialog.eventName.Text;
                mailoutPreview.DocumentText = mailout.ToString();
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void editMailoutStrip_Click(object sender, EventArgs e) {
            // create dialog, change the name of it, and set text fields to match mailout properties
            NewMailout mailoutDialog = new NewMailout();
            mailoutDialog.StartPosition = FormStartPosition.CenterParent;
            mailoutDialog.Text = "Edit Mailout";
            mailoutDialog.mailoutGreeting.Text = mailout.greeting;
            mailoutDialog.mailoutIntroduction.Text = mailout.introduction;
            mailoutDialog.mailoutEnding.Text = mailout.ending;
            mailoutDialog.mailoutSignature.Text = mailout.signature;

            // change the mailout properties if the user selects ok
            if (mailoutDialog.ShowDialog(this) == DialogResult.OK) {
                mailout.greeting = mailoutDialog.mailoutGreeting.Text;
                mailout.introduction = mailoutDialog.mailoutIntroduction.Text;
                mailout.ending = mailoutDialog.mailoutEnding.Text;
                mailout.signature = mailoutDialog.mailoutSignature.Text;
                mailoutPreview.Document.OpenNew(true);
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void refreshPreviewWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            // refresh the preview window
            if (mailout != null) {
                mailoutPreview.Document.OpenNew(true);
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void deleteSectionStrip_Click(object sender, EventArgs e) {
            // cast the component mapped to the node to a section, if it is not a section just quit
            TreeNode selected = mailoutComponents.SelectedNode;
            Section thisSection = nodeToComponent[selected] as Section;
            if (thisSection != null) {
                // remove the selected node frm the tree view and the corresponding section from the mailout
                mailoutComponents.Nodes.Remove(selected);
                mailout.sections.Remove(thisSection);
                mailoutPreview.Document.OpenNew(true);
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void deleteEventStrip_Click(object sender, EventArgs e) {
            // cast the component mapped to the node to an event and its parent to a section, if neither are null just quit
            TreeNode selected = mailoutComponents.SelectedNode;
            Event thisEvent = nodeToComponent[selected] as Event;
            Section parentSection = nodeToComponent[selected.Parent] as Section;
            if (parentSection != null && thisEvent != null) {
                // remove the node frm the tree view and the corresponding event from the section it belongs to
                mailoutComponents.Nodes.Remove(selected);
                parentSection.events.Remove(thisEvent);
                mailoutPreview.Document.OpenNew(true);
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void blankMailoutToolStripMenuItem_Click(object sender, EventArgs e) {
            // create dialog
            NewMailout mailoutDialog = new NewMailout();
            mailoutDialog.StartPosition = FormStartPosition.CenterParent;

            // create mailout with given properties if user selects ok
            if (mailoutDialog.ShowDialog(this) == DialogResult.OK) {
                // clear out tree view and the dictionary
                mailoutComponents.Nodes.Clear();
                nodeToComponent.Clear();

                mailout = new Mailout(mailoutDialog.mailoutGreeting.Text,
                                        mailoutDialog.mailoutIntroduction.Text,
                                        mailoutDialog.mailoutEnding.Text,
                                        mailoutDialog.mailoutSignature.Text);
                mailoutNode = new TreeNode("Mailout");
                mailoutNode.ContextMenuStrip = mailoutMenu;
                mailoutComponents.Nodes.Add(mailoutNode);
                mailoutPreview.Document.OpenNew(true);
                mailoutPreview.Document.Write(mailout.ToString());
            }
        }

        private void standardTemplateToolStripMenuItem_Click(object sender, EventArgs e) {
            // clear out tree view and the dictionary
            mailoutComponents.Nodes.Clear();
            nodeToComponent.Clear();

            // create mailout
            mailout = new Mailout("Hey everyone,", "Here is this weeks's AMC mailout!!! with images!!! #fancy", "Thanks for reading!", "~Matthemily");
            mailoutNode = new TreeNode("Mailout");
            mailoutNode.ContextMenuStrip = mailoutMenu;
            nodeToComponent.Add(mailoutNode, mailout);
            mailoutComponents.Nodes.Add(mailoutNode);

            addSection("This Week");

            Dictionary<String, String> properties = new Dictionary<String, String>();
            properties.Add("name", "General Meeting Sponsored By _______________");
            properties.Add("date", "12/3/14");
            properties.Add("location", "GDC 4.302");
            properties.Add("time", "7:00PM-8:00PM");
            properties.Add("imgUrl", "http://nrn.com/site-files/nrn.com/files/imagecache/medium_img/uploads/2008/12/noodlescospaghettimeatballs.jpg");
            properties.Add("description", "Come and join us at the weekly meeting. Hear about what we did last week and more specifics about what's to come this week and in the near future. This weeks sponsor, _______________, will also be there to talk about who they are and of course take your resumes. There will also be free _______________!. ");
            addEvent(mailoutComponents.Nodes[0].Nodes[0], properties);

            properties["name"] = "Social Event Sponsored By _______________";
            properties["date"] = "12/3/14";
            properties["location"] = "GDC 6.302";
            properties["time"] = "6:00PM-10:00PM";
            properties["imgUrl"] = "http://www.pizzamarket.net/images/pizza2.jpg";
            properties["description"] = "SOCIAL EVENT DESCRIPTION";
            addEvent(mailoutComponents.Nodes[0].Nodes[0], properties);

            addSection("Next Week");

            properties["name"] = "General Meeting Sponsored By _______________";
            properties["date"] = "12/3/14";
            properties["location"] = "GDC 4.302";
            properties["time"] = "7:00PM-8:00PM";
            properties["imgUrl"] = "http://nrn.com/site-files/nrn.com/files/imagecache/medium_img/uploads/2008/12/noodlescospaghettimeatballs.jpg";
            properties["description"] = "Come and join us at the weekly meeting. Hear about what we did last week and more specifics about what's to come this week and in the near future. This weeks sponsor, _______________, will also be there to talk about who they are and of course take your resumes. There will also be free _______________!. ";
            addEvent(mailoutComponents.Nodes[0].Nodes[1], properties);

            properties["name"] = "Social Event Sponsored By _______________";
            properties["date"] = "12/3/14";
            properties["location"] = "GDC 6.302";
            properties["time"] = "6:00PM-10:00PM";
            properties["imgUrl"] = "http://www.pizzamarket.net/images/pizza2.jpg";
            properties["description"] = "SOCIAL EVENT DESCRIPTION";
            addEvent(mailoutComponents.Nodes[0].Nodes[1], properties);

            mailoutPreview.Document.OpenNew(true);
            mailoutPreview.Document.Write(mailout.ToString());
        }
    }
}
