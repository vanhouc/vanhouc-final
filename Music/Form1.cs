using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Form1 : Form
    {
        DataRepository repo;
        public Form1()
        {
            InitializeComponent();
            repo = new DataRepository();
            int locationY = 20;
            foreach(string s in Enum.GetNames(typeof(Section)))
            {
                CheckBox newCheck = new CheckBox();
                newCheck.Text = s;
                newCheck.Location = new Point(10, locationY);
                locationY += newCheck.Size.Height;
                newCheck.CheckedChanged += newCheck_CheckedChanged;
                grpTypes.Controls.Add(newCheck);
            }
        }

        private void newCheck_CheckedChanged(object sender, EventArgs e)
        {
            string[] selectedNames = grpTypes.Controls.OfType<CheckBox>().Where(x => x.Checked).Select(x => x.Text).ToArray();
            {
                Section[] selectedSection = selectedNames.Select(x => (Section)Enum.Parse(typeof(Section), x)).ToArray();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(repo.GetInstruments(selectedSection).Select(x => x.ToString()).ToArray());
            }
        }
    }
}
