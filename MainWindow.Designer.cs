﻿namespace MailoutMaker
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
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
            this.deleteSectionStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.eventMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editEventStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMailoutDialog = new System.Windows.Forms.SaveFileDialog();
            this.blankMailoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshPreviewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.mailoutMenu.SuspendLayout();
            this.sectionMenu.SuspendLayout();
            this.eventMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(853, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
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
            this.newMailoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blankMailoutToolStripMenuItem,
            this.standardTemplateToolStripMenuItem});
            this.newMailoutToolStripMenuItem.Name = "newMailoutToolStripMenuItem";
            this.newMailoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newMailoutToolStripMenuItem.Text = "New Mailout";
            // 
            // saveMailoutToolStripMenuItem
            // 
            this.saveMailoutToolStripMenuItem.Name = "saveMailoutToolStripMenuItem";
            this.saveMailoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMailoutToolStripMenuItem.Text = "Save Mailout";
            this.saveMailoutToolStripMenuItem.Click += new System.EventHandler(this.saveMailoutToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // mailoutPreview
            // 
            this.mailoutPreview.Location = new System.Drawing.Point(171, 27);
            this.mailoutPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.mailoutPreview.Name = "mailoutPreview";
            this.mailoutPreview.Size = new System.Drawing.Size(682, 654);
            this.mailoutPreview.TabIndex = 2;
            // 
            // mailoutComponents
            // 
            this.mailoutComponents.Location = new System.Drawing.Point(0, 27);
            this.mailoutComponents.Name = "mailoutComponents";
            this.mailoutComponents.Size = new System.Drawing.Size(165, 654);
            this.mailoutComponents.TabIndex = 3;
            this.mailoutComponents.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.mailoutComponents_NodeMouseClick);
            // 
            // mailoutMenu
            // 
            this.mailoutMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSectionStrip,
            this.editMailoutStrip});
            this.mailoutMenu.Name = "mailoutMenu";
            this.mailoutMenu.Size = new System.Drawing.Size(141, 48);
            // 
            // editMailoutStrip
            // 
            this.editMailoutStrip.Name = "editMailoutStrip";
            this.editMailoutStrip.Size = new System.Drawing.Size(152, 22);
            this.editMailoutStrip.Text = "Edit Mailout";
            this.editMailoutStrip.Click += new System.EventHandler(this.editMailoutStrip_Click);
            // 
            // newSectionStrip
            // 
            this.newSectionStrip.Name = "newSectionStrip";
            this.newSectionStrip.Size = new System.Drawing.Size(140, 22);
            this.newSectionStrip.Text = "New Section";
            this.newSectionStrip.Click += new System.EventHandler(this.newSectionStrip_Click);
            // 
            // sectionMenu
            // 
            this.sectionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEventStrip,
            this.editSectionStrip,
            this.deleteSectionStrip});
            this.sectionMenu.Name = "sectionMenu";
            this.sectionMenu.Size = new System.Drawing.Size(150, 70);
            // 
            // editSectionStrip
            // 
            this.editSectionStrip.Name = "editSectionStrip";
            this.editSectionStrip.Size = new System.Drawing.Size(152, 22);
            this.editSectionStrip.Text = "Edit Section";
            this.editSectionStrip.Click += new System.EventHandler(this.editSectionStrip_Click);
            // 
            // newEventStrip
            // 
            this.newEventStrip.Name = "newEventStrip";
            this.newEventStrip.Size = new System.Drawing.Size(149, 22);
            this.newEventStrip.Text = "New Event";
            this.newEventStrip.Click += new System.EventHandler(this.newEventStrip_Click);
            // 
            // deleteSectionStrip
            // 
            this.deleteSectionStrip.Name = "deleteSectionStrip";
            this.deleteSectionStrip.Size = new System.Drawing.Size(149, 22);
            this.deleteSectionStrip.Text = "Delete Section";
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
            this.editEventStrip.Size = new System.Drawing.Size(152, 22);
            this.editEventStrip.Text = "Edit Event";
            this.editEventStrip.Click += new System.EventHandler(this.editEventStrip_Click);
            // 
            // deleteEventStrip
            // 
            this.deleteEventStrip.Name = "deleteEventStrip";
            this.deleteEventStrip.Size = new System.Drawing.Size(159, 22);
            this.deleteEventStrip.Text = "Delete Event";
            // 
            // saveMailoutDialog
            // 
            this.saveMailoutDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveMailoutDialog_FileOk);
            // 
            // blankMailoutToolStripMenuItem
            // 
            this.blankMailoutToolStripMenuItem.Name = "blankMailoutToolStripMenuItem";
            this.blankMailoutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.blankMailoutToolStripMenuItem.Text = "Blank Mailout";
            // 
            // standardTemplateToolStripMenuItem
            // 
            this.standardTemplateToolStripMenuItem.Name = "standardTemplateToolStripMenuItem";
            this.standardTemplateToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.standardTemplateToolStripMenuItem.Text = "Standard Template";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPreviewWindowToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshPreviewWindowToolStripMenuItem
            // 
            this.refreshPreviewWindowToolStripMenuItem.Name = "refreshPreviewWindowToolStripMenuItem";
            this.refreshPreviewWindowToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.refreshPreviewWindowToolStripMenuItem.Text = "Refresh Preview Window";
            this.refreshPreviewWindowToolStripMenuItem.Click += new System.EventHandler(this.refreshPreviewWindowToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 684);
            this.Controls.Add(this.mailoutComponents);
            this.Controls.Add(this.mailoutPreview);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Mailout Maker";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mailoutMenu.ResumeLayout(false);
            this.sectionMenu.ResumeLayout(false);
            this.eventMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
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
        private System.Windows.Forms.SaveFileDialog saveMailoutDialog;
        private System.Windows.Forms.ToolStripMenuItem blankMailoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardTemplateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshPreviewWindowToolStripMenuItem;

    }
}

