using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pr7.DBCon;
using System.Text.Json;

namespace Pr7
{
    public partial class UserControlJuri : UserControl
    {
        public UserControlJuri()
        {
            InitializeComponent();
        }

        private void UserControlJuri_Load(object sender, EventArgs e)
        {

        }
        public void Fill(User user, int number)
        {

            label1.Text = "Jury" + number.ToString();

            userBindingSource.DataSource = user;
        }
    }
}
