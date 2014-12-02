using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailoutMaker {
    public partial class NewSection : Form {
        public NewSection() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (sectionName.Text.Equals("")) {
                MessageBox.Show("Please fill in all of the fields.", "Missing Values");
            }
            else {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
