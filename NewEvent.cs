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
    public partial class NewEvent : Form
    {
        public bool result;

        public NewEvent()
        {
            InitializeComponent();
        }

        private void NewEvent_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            result = true;
            this.Close();
        }
    }
}
