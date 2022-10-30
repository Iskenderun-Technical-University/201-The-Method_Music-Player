using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            foreach (Control A in this.Controls)
                lbl_TheMethod.Font = new Font(Program.mainform.BadSignal.Families[0], 54, FontStyle.Regular);
        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
