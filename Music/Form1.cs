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
            combxSections.DataSource = Enum.GetNames(typeof(Section));
        }

        private void combxSections_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Enum.GetNames(typeof(Section)).Contains(combxSections.SelectedValue.ToString()))
            {
                Section selectedSection;
                Enum.TryParse<Section>(combxSections.SelectedValue.ToString(), out selectedSection);
                if (selectedSection != null)
                {
                    listBox1.Items.Clear();
                    foreach (Instrument i in repo.GetInstruments(selectedSection))
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
            }
        }
    }
}
