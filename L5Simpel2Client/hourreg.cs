using System;
using L5Simpel2Client.ServiceReference1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;

namespace L5Simpel2Client
{
    public partial class hourreg : Form
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();

        public hourreg()
        {
            InitializeComponent();
            listBox2.DataSource = listBox1.Items;
        }
        IServices services = new ServicesClient();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //todo: hardcoded er uit
            
            var now = DateTime.Now.ToString("MM/dd/yyyy");
            var uren = Int32.Parse(textBox2.Text);
            services.RegistreerWerkzaamheid(uren, 1, textBox1.Text, now, services.GetMedewerker(1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            services.DeleteWerkzaamheid(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uren = Int32.Parse(textBox2.Text);
            var now = DateTime.Now.ToString("MM/dd/yyyy");
            services.EditWerkzaamheid(1, uren, 0, textBox1.Text, now, "kees");
        }
    }
}
