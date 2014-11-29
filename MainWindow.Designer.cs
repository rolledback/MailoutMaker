namespace MailoutMaker
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMailoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMailoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailoutPreview = new System.Windows.Forms.WebBrowser();
            this.mailoutComponents = new System.Windows.Forms.TreeView();
            this.mailoutMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMailoutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newSectionStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSectionStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.eventMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editEventStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSectionStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.previewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshPrviewStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.mailoutMenu.SuspendLayout();
            this.sectionMenu.SuspendLayout();
            this.eventMenu.SuspendLayout();
            this.previewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMailoutToolStripMenuItem,
            this.saveMailoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMailoutToolStripMenuItem
            // 
            this.newMailoutToolStripMenuItem.Name = "newMailoutToolStripMenuItem";
            this.newMailoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newMailoutToolStripMenuItem.Text = "New Mailout";
            // 
            // saveMailoutToolStripMenuItem
            // 
            this.saveMailoutToolStripMenuItem.Name = "saveMailoutToolStripMenuItem";
            this.saveMailoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMailoutToolStripMenuItem.Text = "Save Mailout";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mailoutPreview
            // 
            this.mailoutPreview.ContextMenuStrip = this.previewMenu;
            this.mailoutPreview.Location = new System.Drawing.Point(171, 27);
            this.mailoutPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.mailoutPreview.Name = "mailoutPreview";
            this.mailoutPreview.Size = new System.Drawing.Size(541, 537);
            this.mailoutPreview.TabIndex = 2;
            // 
            // mailoutComponents
            // 
            this.mailoutComponents.Location = new System.Drawing.Point(0, 27);
            this.mailoutComponents.Name = "mailoutComponents";
            this.mailoutComponents.Size = new System.Drawing.Size(165, 537);
            this.mailoutComponents.TabIndex = 3;
            this.mailoutComponents.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mailoutComponents_NodeMouseClick);
            // 
            // mailoutMenu
            // 
            this.mailoutMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMailoutStrip,
            this.newSectionStrip});
            this.mailoutMenu.Name = "mailoutMenu";
            this.mailoutMenu.Size = new System.Drawing.Size(141, 48);
            // 
            // editMailoutStrip
            // 
            this.editMailoutStrip.Name = "editMailoutStrip";
            this.editMailoutStrip.Size = new System.Drawing.Size(140, 22);
            this.editMailoutStrip.Text = "Edit Mailout";
            // 
            // newSectionStrip
            // 
            this.newSectionStrip.Name = "newSectionStrip";
            this.newSectionStrip.Size = new System.Drawing.Size(140, 22);
            this.newSectionStrip.Text = "New Section";
            // 
            // sectionMenu
            // 
            this.sectionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSectionStrip,
            this.newEventStrip,
            this.deleteSectionStrip});
            this.sectionMenu.Name = "sectionMenu";
            this.sectionMenu.Size = new System.Drawing.Size(150, 70);
            // 
            // editSectionStrip
            // 
            this.editSectionStrip.Name = "editSectionStrip";
            this.editSectionStrip.Size = new System.Drawing.Size(149, 22);
            this.editSectionStrip.Text = "Edit Section";
            // 
            // newEventStrip
            // 
            this.newEventStrip.Name = "newEventStrip";
            this.newEventStrip.Size = new System.Drawing.Size(149, 22);
            this.newEventStrip.Text = "New Event";
            // 
            // eventMenu
            // 
            this.eventMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editEventStrip,
            this.deleteEventStrip});
            this.eventMenu.Name = "eventMenu";
            this.eventMenu.Size = new System.Drawing.Size(140, 48);
            // 
            // editEventStrip
            // 
            this.editEventStrip.Name = "editEventStrip";
            this.editEventStrip.Size = new System.Drawing.Size(139, 22);
            this.editEventStrip.Text = "Edit Event";
            // 
            // deleteEventStrip
            // 
            this.deleteEventStrip.Name = "deleteEventStrip";
            this.deleteEventStrip.Size = new System.Drawing.Size(139, 22);
            this.deleteEventStrip.Text = "Delete Event";
            // 
            // deleteSectionStrip
            // 
            this.deleteSectionStrip.Name = "deleteSectionStrip";
            this.deleteSectionStrip.Size = new System.Drawing.Size(149, 22);
            this.deleteSectionStrip.Text = "Delete Section";
            // 
            // previewMenu
            // 
            this.previewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPrviewStrip});
            this.previewMenu.Name = "previewMenu";
            this.previewMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // refreshPrviewStrip
            // 
            this.refreshPrviewStrip.Name = "refreshPrviewStrip";
            this.refreshPrviewStrip.Size = new System.Drawing.Size(152, 22);
            this.refreshPrviewStrip.Text = "Refresh";
            this.refreshPrviewStrip.Click += new System.EventHandler(this.refreshPrviewStrip_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 576);
            this.Controls.Add(this.mailoutComponents);
            this.Controls.Add(this.mailoutPreview);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Mailout Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mailoutMenu.ResumeLayout(false);
            this.sectionMenu.ResumeLayout(false);
            this.eventMenu.ResumeLayout(false);
            this.previewMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMailoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMailoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.WebBrowser mailoutPreview;
        private System.Windows.Forms.TreeView mailoutComponents;
        private System.Windows.Forms.ContextMenuStrip mailoutMenu;
        private System.Windows.Forms.ToolStripMenuItem editMailoutStrip;
        private System.Windows.Forms.ToolStripMenuItem newSectionStrip;
        private System.Windows.Forms.ContextMenuStrip sectionMenu;
        private System.Windows.Forms.ToolStripMenuItem editSectionStrip;
        private System.Windows.Forms.ToolStripMenuItem newEventStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteSectionStrip;
        private System.Windows.Forms.ContextMenuStrip eventMenu;
        private System.Windows.Forms.ToolStripMenuItem editEventStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteEventStrip;
        private System.Windows.Forms.ContextMenuStrip previewMenu;
        private System.Windows.Forms.ToolStripMenuItem refreshPrviewStrip;

    }
}

