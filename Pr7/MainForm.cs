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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<int> JoriList;
        private void MainForm_Load(object sender, EventArgs e)
        {
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void button2_Click(object sender, EventArgs e)//ДОБАВИТЬ АКТИВНОСТЬ
        {
            FormAddActivity activity = new FormAddActivity();
            activity.ShowDialog();
            activityBindingSource.DataSource = DBConst.model.Activity.ToList();
        }

        private void button1_Click(object sender, EventArgs e)//ПОСМОТРЕТЬ ЖЮРИ
        {
            JoriList = new List<int>();
            JoriList = JsonSerializer.Deserialize<List<int>>
                (activityDataGridView.CurrentRow.Cells[5].Value.ToString());
            FormShowJuri formShowJuri = new FormShowJuri();
            formShowJuri.ShowDialog();

        }
    }
}
