using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Defibrillátor
{
    public partial class frmFo : Form
    {
        static List<Keszülek> lista = new List<Keszülek>();
        public frmFo()
        {
            InitializeComponent();
            Beolvas();
        }
        static void Beolvas()
        {
            StreamReader sr = new StreamReader("data.csv");
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(';');
                lista.Add(new Keszülek(Convert.ToInt32(a[0]),a[1],Convert.ToDouble(a[2]),Convert.ToDouble(a[3]),a[4],a[5]));
            }
            sr.Close();
        }
        private void btnKilep_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
