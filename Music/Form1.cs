//By: Cameron VanHouzen
//Date: 12/9/2013
//Main UI form of the program
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
    /// <summary>
    /// Form contains all UI for interacting with music program
    /// </summary>
    public partial class Form1 : Form
    {
        DataRepository repo;
        /// <summary>
        /// Initializes the form on start-up
        /// </summary>
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
        /// <summary>
        /// Causes listbox to refresh when a new item is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newCheck_CheckedChanged(object sender, EventArgs e)
        {
            string[] selectedNames = grpTypes.Controls.OfType<CheckBox>().Where(x => x.Checked).Select(x => x.Text).ToArray();
            {
                Section[] selectedSection = selectedNames.Select(x => (Section)Enum.Parse(typeof(Section), x)).ToArray();
                lstbxInstruments.Items.Clear();
                lstbxInstruments.Items.AddRange(repo.GetInstruments(selectedSection).Select(x => x.ToString()).ToArray());
            }
        }
        /// <summary>
        /// Causes all checkboxes in grpTypes to be checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSlctAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chk in grpTypes.Controls.OfType<CheckBox>())
            {
                chk.Checked = true;
            }
        }
    }
}
