using Pr7.DBCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Pr7
{
    public partial class FormShowJuri : Form
    {
        public FormShowJuri()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormShowJuri_Load(object sender, EventArgs e)
        {
            int number = 1;

            foreach (int i in MainForm.JoriList)
            { 
                User user = DBConst.model.User.Find(i);
                UserControlJuri usercontr = new UserControlJuri();
                usercontr.Fill(user, number);
                flowLayoutPanel1.Controls.Add(usercontr); 
                number++;

            }
        }
    }
}
