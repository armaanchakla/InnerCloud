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
using System.Diagnostics;
using System.Speech.Recognition;

namespace InnerCloud
{
    public partial class Homepage : Form
    {
        
        public int count = 1;
        public string cloudPath = @"D:\InnerCloudDB\";
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        internal string filePath = "";
        List<string> listFiles = new List<string>();
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            LoadFileList(@"C:\Users\estiak\Videos\DemoProject");
            btnCut.Enabled = false;
            btnCopy.Enabled = false;
            btnRename.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnRnSave.Visible = false;
            txtFileName.Visible = false;
            txtFolderName.Visible = false;
            btnNwFolder.Visible = false;


            Choices commands = new Choices();
            commands.Add(new string[] { "hello", "print my name", " open" });
            commands.Add("red");
            commands.Add("blue");
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(commands);
            Grammar g = new Grammar(gb);

            sre.LoadGrammarAsync(g);
            sre.SetInputToDefaultAudioDevice();
            //sre.RecognizeAsync(RecognizeMode.Multiple);

            sre.SpeechRecognized += Sre_SpeechRecognized;
        }

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "hello":
                    MessageBox.Show("hello estiak how are you");
                    break;
                case "print my name":
                    //rtbShowSpeach.Text += "\nestiak";
                    break;
                case "red":
                    this.BackColor = Color.Red;
                    break;
                case "blue":
                    this.BackColor = Color.Blue;
                    break;
                case "open":
                    //open();
                    Process.Start(listFiles[listView.FocusedItem.Index]);
                    break;
            }
        }

        public void LoadFileList(string path)
        {
            listFiles.Clear();
            listView.Items.Clear();
            foreach (string item in Directory.GetFiles(path))
            {
                FileInfo iArray = new FileInfo(item);
                listFiles.Add(iArray.FullName);
                imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                listView.Items.Add(iArray.Name, imageList.Images.Count-1);
                txtPath.Text = path;
            }
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                //ListViewItem item = new ListViewItem();
                //MessageBox.Show("Selected : "+listView.FocusedItem.Name.ToString());
                //string[] items= listView.FocusedItem.Name;
                //listViewSide.Items.Add(items);
                filePath = txtPath.Text + "\\" + listView.FocusedItem.Text;
                txtFileName.Text = listView.FocusedItem.Text;
            }
            
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Select A Folder";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath;
                LoadFileList(path);
                txtPath.Text = path;
            }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
            btnCut.Enabled = true;
            btnCopy.Enabled = true;
            btnRename.Enabled = true;
            btnDelete.Enabled = true;
            //btnEdit.Enabled = true;
            listViewSide.Items.Clear();
            //MessageBox.Show("selected : "+ listView.SelectedItems[0].Text);
            //MessageBox.Show(txtPath.Text);
            foreach (string item in Directory.GetFiles(txtPath.Text))
            {
                FileInfo iArray = new FileInfo(item);
                if (iArray.Name == listView.SelectedItems[0].Text)
                {
                    //string[] row = { "Name : "+ iArray.Name , "Size : " + iArray.Length };
                    //ListViewItem items = new ListViewItem(row);
                    //listViewSide.Items.Add(items);
                    listViewSide.Items.Add("Name        : " + iArray.Name);
                    listViewSide.Items.Add("Size           : " + iArray.Length + "KB");
                    listViewSide.Items.Add("Created At : " + iArray.CreationTime);
                    listViewSide.Items.Add("File Type   : " + iArray.Extension);
                    listViewSide.Items.Add("Seen At     : " + iArray.LastAccessTime);
                    listViewSide.Items.Add("Modified At: " + iArray.LastWriteTime);
                    listViewSide.Items.Add("File Path    : " + iArray.Directory);
                    if (iArray.Extension == ".txt")
                    {
                        btnEdit.Enabled = true;
                    }
                    else if(iArray.Extension == ".docx")
                    {
                        btnEdit.Enabled = true;
                    }
                    else
                    {
                        btnEdit.Enabled = false;
                    }
                    //MessageBox.Show(iArray.Directory.ToString());
                }
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPath.Text))
            {
                LoadFileList(txtPath.Text);
            }
            else
            {
                listView.Items.Add("Directory Doesn't Exists");
            }
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                Process.Start(listFiles[listView.FocusedItem.Index]);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(filePath.Substring(33));
            string cldPath = cloudPath + filePath.Substring(33);
            string temp = @"D:\InnerCloudDB\trash\" + listView.FocusedItem.Text;

            if (File.Exists(filePath))
            {
                if (MessageBox.Show("Do You Want to Delete This File ?", "Delete FIle !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    File.Copy(filePath,temp);
                    File.Delete(cldPath);
                    File.Delete(filePath);
                    MessageBox.Show("File Deleted !");
                    LoadFileList(txtPath.Text);
                }
                else
                {
                    MessageBox.Show("File Couldn't Deleted");
                }
            }
            else
            {
                MessageBox.Show("File Doesn't Exists Here !");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            btnRename.Visible = false;
            txtFileName.Visible = true;
            btnRnSave.Visible = true;
            txtFileName.Text = listView.FocusedItem.Text;
        }

        private void btnRnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(filePath);
            txtFileName.Visible = false;
            btnRnSave.Visible = false;
            btnRename.Visible = true;

            if (File.Exists(filePath))
            {
                string temp1 = cloudPath + filePath.Substring(33);
                string temp2 = filePath;


                string cldPath = cloudPath + txtPath.Text.Substring(33) + "\\" + txtFileName.Text;
                string movePath = txtPath.Text + "\\" + txtFileName.Text;
                //string tempFilepath = cloudPath + txtPath.Text.Substring(33) + "\\" + txtFileName.Text;
                //File.Copy(filePath, movePath);
                //File.Copy(filePath, cldPath);
                //File.Delete(filePath);
                //File.Delete(cldPath);
                File.Move(temp1, cldPath);
                File.Move(temp2, movePath);
                LoadFileList(txtPath.Text);
               
                MessageBox.Show("File Renamed");
            }
            else
            {
                MessageBox.Show("File Couldn't be Deleted","File Not Found",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdd = new FolderBrowserDialog();
            fdd.Description = "Select a Folder to Move the File";
            fdd.RootFolder = Environment.SpecialFolder.Desktop;
            fdd.ShowNewFolderButton = false;
            if (fdd.ShowDialog() == DialogResult.OK)
            {
                string temp1 = cloudPath + filePath.Substring(33) ;
                string cldpath = cloudPath + fdd.SelectedPath.Substring(33) + "\\" + listView.FocusedItem.Text;

                string movePath = fdd.SelectedPath + "\\" + listView.FocusedItem.Text;
                
                //MessageBox.Show(temp1);
                //MessageBox.Show(cldpath);
                File.Move(filePath, movePath);
                File.Move(temp1,cldpath);
                LoadFileList(txtPath.Text);
                MessageBox.Show("File MOVED","Success !!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("File destination Folder not selected !!","Error !!");
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdd = new FolderBrowserDialog();
            fdd.Description = "Select a Folder to PASTE";
            fdd.RootFolder = Environment.SpecialFolder.Desktop;
            fdd.ShowNewFolderButton = false;
            if (fdd.ShowDialog() == DialogResult.OK)
            {
                string copyPath = fdd.SelectedPath + "\\" + listView.FocusedItem.Text;

                if (copyPath == filePath)
                {
                    copyPath = fdd.SelectedPath + "\\" + listView.FocusedItem.Text + "- new";
                    File.Copy(filePath, copyPath);
                    LoadFileList(txtPath.Text);
                    MessageBox.Show("File COPIED", " Success !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string cloudSource = cloudPath + filePath.Substring(33);
                    string cloudDestination = cloudPath + copyPath.Substring(33);
                    File.Copy(filePath, copyPath);
                    File.Copy(cloudSource, cloudDestination);
                    LoadFileList(txtPath.Text);
                    MessageBox.Show("File COPIED", " Success !!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Folder copy destination not selected !!", "Error !!");
            }
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            btnCreateFile.Visible = false;
            btnNewFolder.Visible = false;
            btnCut.Enabled = false;
            btnCopy.Enabled = false;
            btnRename.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnRnSave.Visible = false;
            txtFileName.Visible = false;
            txtFolderName.Visible = true;
            btnNwFolder.Visible = true;
        }

        private void btnNwFolder_Click(object sender, EventArgs e)
        {
            btnCreateFile.Visible = true;
            btnNewFolder.Visible = true;
            txtFolderName.Visible = false;
            btnNwFolder.Visible = false;
            if (txtFolderName.Text != "")
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + txtFolderName.Text);
                Directory.CreateDirectory(cloudPath + txtPath.Text.Substring(33) + "\\" + txtFolderName.Text);
                LoadFileList(txtPath.Text + "\\" + txtFolderName.Text);
                MessageBox.Show("A New Folder Created");
            }
            else
            {
                LoadFileList(txtPath.Text);
                MessageBox.Show("No Folder Created Folder");
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            File_Manager fm = new File_Manager(txtPath.Text);
            fm.Visible = true;
            this.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string filePath = txtPath + "\\" + listView.FocusedItem.Text;
            MessageBox.Show(filePath);
            File_Manager fm = new File_Manager(filePath);
            fm.Visible = true;
            fm.BtnUpdate.Visible = true;
            this.Visible = false;
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSpeech_Click(object sender, EventArgs e)
        {
            if(count==1)
            {
                sre.RecognizeAsync(RecognizeMode.Multiple);
                this.btnSpeech.BackColor = Color.Green;
                count = 0;
            }
            else if(count==0)
            {
                sre.RecognizeAsyncStop();
                this.btnSpeech.BackColor = Color.Red;
                count = 1;
            }
        }
    }
}
