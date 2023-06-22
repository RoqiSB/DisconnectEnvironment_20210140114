using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnect_Environment
{
    public partial class DataMaster : Form
    {
        public DataMaster()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProdi fm = new DataProdi();
            fm.Show();
            this.Hide();
        }

        private void Data_Master_Load(object sender, EventArgs e)
        {

        }

        private void dataMahasiswaMenuItem_Click(object sender, EventArgs e)
        {
            DataMahasiswa fo = new DataMahasiswa();
            fo.Show(); 
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusMahasiswa fr = new StatusMahasiswa();
            fr.Show();
            this.Hide();
        }
    }
}
