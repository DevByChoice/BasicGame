using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGame
{
    public partial class Armoury : Form
    {
        public event Action<string> ValueGenerated;
        public string Class;
        public Armoury()
        {
            InitializeComponent();
            this.drp_Class.Items.Add("Barbarian");
            this.drp_Class.Items.Add("Mage");
            this.drp_Class.Items.Add("Ranger");
        }

        private void drp_Class_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Class = this.drp_Class.SelectedItem.ToString();
            if (Class == null)
            {
                MessageBox.Show("Select a Class to Continue");
            }
            else
            {
                ValueGenerated?.Invoke(Class);
            }
            this.Close();
        }
    }
}
