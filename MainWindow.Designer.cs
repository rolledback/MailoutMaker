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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMailoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMailoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailoutPreview = new System.Windows.Forms.WebBrowser();
            this.mailoutComponents = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 576);
            this.Controls.Add(this.mailoutComponents);
            this.Controls.Add(this.mailoutPreview);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.Text = "Mailout Maker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMailoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMailoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.WebBrowser mailoutPreview;
        private System.Windows.Forms.TreeView mailoutComponents;

    }
}

