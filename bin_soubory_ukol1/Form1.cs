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

namespace bin_soubory_ukol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\znaky.dat", FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            br.BaseStream.Position = 0;

            while (br.BaseStream.Position < br.BaseStream.Length)
            {
                if (br.ReadChar() == '?')
                {
                    MessageBox.Show("První ? je na pozici " + br.BaseStream.Position);
                    br.BaseStream.Position--;
                    br.BaseStream.Position--;
                    MessageBox.Show("Znak před ním je " + br.ReadChar());
                    break;
                }
            }

            fs.Close();
            br.Close();
        }
    }
}
