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
    public partial class NewEvent : Form {

        public NewEvent() {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (eventName.Text.Equals("") || eventDescription.Text.Equals("")) {
                MessageBox.Show("Please fill in name and/or description.", "Missing Values");
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
