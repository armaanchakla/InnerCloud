namespace InnerCloud
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("FileName", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.listView = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pn1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNwFolder = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnRnSave = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.listViewSide = new System.Windows.Forms.ListView();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.pn1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(14, 60);
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(832, 381);
            this.listView.SmallImageList = this.imageList;
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.TileSize = new System.Drawing.Size(2, 2);
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.btnSpeech);
            this.pn1.Controls.Add(this.groupBox1);
            this.pn1.Controls.Add(this.listView);
            this.pn1.Controls.Add(this.btnSelectFolder);
            this.pn1.Controls.Add(this.txtPath);
            this.pn1.Controls.Add(this.listViewSide);
            this.pn1.Location = new System.Drawing.Point(-2, 2);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(1183, 566);
            this.pn1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNwFolder);
            this.groupBox1.Controls.Add(this.txtFolderName);
            this.groupBox1.Controls.Add(this.btnCut);
            this.groupBox1.Controls.Add(this.btnRnSave);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.btnNewFolder);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCreateFile);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(859, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 293);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Actions";
            // 
            // btnNwFolder
            // 
            this.btnNwFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNwFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNwFolder.Location = new System.Drawing.Point(218, 15);
            this.btnNwFolder.Name = "btnNwFolder";
            this.btnNwFolder.Size = new System.Drawing.Size(89, 43);
            this.btnNwFolder.TabIndex = 13;
            this.btnNwFolder.Text = "Create";
            this.btnNwFolder.UseVisualStyleBackColor = true;
            this.btnNwFolder.Click += new System.EventHandler(this.btnNwFolder_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtFolderName.Location = new System.Drawing.Point(6, 15);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(206, 43);
            this.txtFolderName.TabIndex = 12;
            // 
            // btnCut
            // 
            this.btnCut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCut.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCut.Location = new System.Drawing.Point(7, 64);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(300, 34);
            this.btnCut.TabIndex = 3;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnRnSave
            // 
            this.btnRnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRnSave.Location = new System.Drawing.Point(218, 148);
            this.btnRnSave.Name = "btnRnSave";
            this.btnRnSave.Size = new System.Drawing.Size(87, 43);
            this.btnRnSave.TabIndex = 11;
            this.btnRnSave.Text = "Rename";
            this.btnRnSave.UseVisualStyleBackColor = true;
            this.btnRnSave.Click += new System.EventHandler(this.btnRnSave_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopy.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopy.Location = new System.Drawing.Point(7, 104);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(300, 35);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.SystemColors.Info;
            this.txtFileName.Location = new System.Drawing.Point(7, 149);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(206, 43);
            this.txtFileName.TabIndex = 10;
            // 
            // btnRename
            // 
            this.btnRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRename.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRename.Location = new System.Drawing.Point(6, 145);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(300, 50);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewFolder.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewFolder.Location = new System.Drawing.Point(157, 19);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(150, 39);
            this.btnNewFolder.TabIndex = 9;
            this.btnNewFolder.Text = "New Folder";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(6, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(299, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateFile.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateFile.Location = new System.Drawing.Point(6, 19);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(145, 39);
            this.btnCreateFile.TabIndex = 8;
            this.btnCreateFile.Text = "New File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(6, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(299, 41);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectFolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectFolder.Location = new System.Drawing.Point(591, 15);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(163, 29);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtPath.Location = new System.Drawing.Point(14, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(571, 29);
            this.txtPath.TabIndex = 1;
            this.txtPath.TabStop = false;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // listViewSide
            // 
            this.listViewSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listViewSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSide.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.listViewSide.GridLines = true;
            listViewGroup1.Header = "FileName";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listViewSide.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listViewSide.Location = new System.Drawing.Point(859, 314);
            this.listViewSide.Name = "listViewSide";
            this.listViewSide.Size = new System.Drawing.Size(312, 127);
            this.listViewSide.TabIndex = 0;
            this.listViewSide.UseCompatibleStateImageBehavior = false;
            this.listViewSide.View = System.Windows.Forms.View.List;
            // 
            // btnSpeech
            // 
            this.btnSpeech.Location = new System.Drawing.Point(761, 15);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(75, 29);
            this.btnSpeech.TabIndex = 13;
            this.btnSpeech.Text = "Listen";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1184, 457);
            this.Controls.Add(this.pn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InnerCloud Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListView listViewSide;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnRnSave;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNwFolder;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Button btnSpeech;
    }
}

