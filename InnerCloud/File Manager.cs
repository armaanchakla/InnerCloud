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

namespace InnerCloud
{
    public partial class File_Manager : Form
    {
        string fileName, path;
        public File_Manager(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Visible = true;
            this.Visible = false;
        }

        private void File_Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void File_Manager_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            //btnUpdate.Visible = false;
            MessageBox.Show(path);
            if (File.Exists(path))
            {
                //btnUpdate.Visible = true;
            }
            else if(!File.Exists(path))
            {
                btnSave.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
            {
                MessageBox.Show("File Name Field is Blank");
            }
            else if (txtFileName.Text != "")
            {
                fileName = txtFileName.Text + ".txt";
            }

            string str = @path + "\\" + fileName;

            try
            {
                if (File.Exists(str))
                {
                    File.Delete(str);
                }

                using (StreamWriter sw = File.CreateText(str))
                {
                    sw.WriteLine(txtData.Text);
                    MessageBox.Show("File Has Been Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Homepage hm = new Homepage();
            MessageBox.Show(path);
            hm.Visible = true;
            hm.LoadFileList(path);
            this.Visible = false;
        }
    }
}
