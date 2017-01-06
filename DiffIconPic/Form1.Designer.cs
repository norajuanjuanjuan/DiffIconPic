namespace DiffIconPic
{
    partial class Form1
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.btnNav2Sel = new System.Windows.Forms.Button();
            this.btn_garminSel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nav2IconFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_garminIconFolder = new System.Windows.Forms.TextBox();
            this.btn_replace = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.tabControl_image = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_show_changedIcon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList_new = new System.Windows.Forms.ImageList(this.components);
            this.btn_showChange = new System.Windows.Forms.Button();
            this.lblTotalNew = new System.Windows.Forms.Label();
            this.lblNewCount = new System.Windows.Forms.Label();
            this.lblDiffCount = new System.Windows.Forms.Label();
            this.lblToltalDiff = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.tabControl_image.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_top.Controls.Add(this.btnNav2Sel);
            this.panel_top.Controls.Add(this.btn_garminSel);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Controls.Add(this.txt_nav2IconFolder);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.txt_garminIconFolder);
            this.panel_top.Location = new System.Drawing.Point(3, 4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(822, 82);
            this.panel_top.TabIndex = 0;
            // 
            // btnNav2Sel
            // 
            this.btnNav2Sel.Location = new System.Drawing.Point(699, 47);
            this.btnNav2Sel.Name = "btnNav2Sel";
            this.btnNav2Sel.Size = new System.Drawing.Size(75, 32);
            this.btnNav2Sel.TabIndex = 5;
            this.btnNav2Sel.Text = "浏览...";
            this.btnNav2Sel.UseVisualStyleBackColor = true;
            this.btnNav2Sel.Click += new System.EventHandler(this.btnNav2Sel_Click);
            // 
            // btn_garminSel
            // 
            this.btn_garminSel.Location = new System.Drawing.Point(699, 8);
            this.btn_garminSel.Name = "btn_garminSel";
            this.btn_garminSel.Size = new System.Drawing.Size(75, 33);
            this.btn_garminSel.TabIndex = 4;
            this.btn_garminSel.Text = "浏览...";
            this.btn_garminSel.UseVisualStyleBackColor = true;
            this.btn_garminSel.Click += new System.EventHandler(this.btn_garminSel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nav2   icon folder:";
            // 
            // txt_nav2IconFolder
            // 
            this.txt_nav2IconFolder.Location = new System.Drawing.Point(174, 49);
            this.txt_nav2IconFolder.Name = "txt_nav2IconFolder";
            this.txt_nav2IconFolder.Size = new System.Drawing.Size(508, 25);
            this.txt_nav2IconFolder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garmin icon folder:";
            // 
            // txt_garminIconFolder
            // 
            this.txt_garminIconFolder.Location = new System.Drawing.Point(174, 8);
            this.txt_garminIconFolder.Name = "txt_garminIconFolder";
            this.txt_garminIconFolder.Size = new System.Drawing.Size(508, 25);
            this.txt_garminIconFolder.TabIndex = 0;
            // 
            // btn_replace
            // 
            this.btn_replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_replace.Location = new System.Drawing.Point(656, 432);
            this.btn_replace.Name = "btn_replace";
            this.btn_replace.Size = new System.Drawing.Size(136, 31);
            this.btn_replace.TabIndex = 7;
            this.btn_replace.Text = "Replace";
            this.btn_replace.UseVisualStyleBackColor = true;
            this.btn_replace.Click += new System.EventHandler(this.btn_replace_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_bottom.Controls.Add(this.tabControl_image);
            this.panel_bottom.Location = new System.Drawing.Point(3, 106);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(822, 498);
            this.panel_bottom.TabIndex = 1;
            // 
            // tabControl_image
            // 
            this.tabControl_image.Controls.Add(this.tabPage1);
            this.tabControl_image.Controls.Add(this.tabPage2);
            this.tabControl_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_image.Location = new System.Drawing.Point(0, 0);
            this.tabControl_image.Name = "tabControl_image";
            this.tabControl_image.SelectedIndex = 0;
            this.tabControl_image.Size = new System.Drawing.Size(822, 498);
            this.tabControl_image.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblNewCount);
            this.tabPage1.Controls.Add(this.lblTotalNew);
            this.tabPage1.Controls.Add(this.btn_show_changedIcon);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(814, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NewIcon";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_show_changedIcon
            // 
            this.btn_show_changedIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show_changedIcon.Location = new System.Drawing.Point(621, 428);
            this.btn_show_changedIcon.Name = "btn_show_changedIcon";
            this.btn_show_changedIcon.Size = new System.Drawing.Size(149, 29);
            this.btn_show_changedIcon.TabIndex = 8;
            this.btn_show_changedIcon.Text = "Show NewIcon";
            this.btn_show_changedIcon.UseVisualStyleBackColor = true;
            this.btn_show_changedIcon.Click += new System.EventHandler(this.btn_show_newIcon_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(8, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 408);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDiffCount);
            this.tabPage2.Controls.Add(this.lblToltalDiff);
            this.tabPage2.Controls.Add(this.btn_showChange);
            this.tabPage2.Controls.Add(this.btn_replace);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(814, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ChangedIcon";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(805, 423);
            this.dataGridView1.TabIndex = 1;
            // 
            // imageList_new
            // 
            this.imageList_new.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_new.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_new.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_showChange
            // 
            this.btn_showChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_showChange.Location = new System.Drawing.Point(457, 432);
            this.btn_showChange.Name = "btn_showChange";
            this.btn_showChange.Size = new System.Drawing.Size(145, 31);
            this.btn_showChange.TabIndex = 8;
            this.btn_showChange.Text = "Show ChangedIcon";
            this.btn_showChange.UseVisualStyleBackColor = true;
            this.btn_showChange.Click += new System.EventHandler(this.btn_showChange_Click);
            // 
            // lblTotalNew
            // 
            this.lblTotalNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalNew.AutoSize = true;
            this.lblTotalNew.Location = new System.Drawing.Point(13, 434);
            this.lblTotalNew.Name = "lblTotalNew";
            this.lblTotalNew.Size = new System.Drawing.Size(103, 15);
            this.lblTotalNew.TabIndex = 9;
            this.lblTotalNew.Text = "Total Count:";
            // 
            // lblNewCount
            // 
            this.lblNewCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNewCount.AutoSize = true;
            this.lblNewCount.ForeColor = System.Drawing.Color.Red;
            this.lblNewCount.Location = new System.Drawing.Point(122, 435);
            this.lblNewCount.Name = "lblNewCount";
            this.lblNewCount.Size = new System.Drawing.Size(55, 15);
            this.lblNewCount.TabIndex = 10;
            this.lblNewCount.Text = "label4";
            // 
            // lblDiffCount
            // 
            this.lblDiffCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiffCount.AutoSize = true;
            this.lblDiffCount.ForeColor = System.Drawing.Color.Red;
            this.lblDiffCount.Location = new System.Drawing.Point(119, 441);
            this.lblDiffCount.Name = "lblDiffCount";
            this.lblDiffCount.Size = new System.Drawing.Size(55, 15);
            this.lblDiffCount.TabIndex = 12;
            this.lblDiffCount.Text = "label4";
            // 
            // lblToltalDiff
            // 
            this.lblToltalDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblToltalDiff.AutoSize = true;
            this.lblToltalDiff.Location = new System.Drawing.Point(10, 440);
            this.lblToltalDiff.Name = "lblToltalDiff";
            this.lblToltalDiff.Size = new System.Drawing.Size(103, 15);
            this.lblToltalDiff.TabIndex = 11;
            this.lblToltalDiff.Text = "Total Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 616);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Name = "Form1";
            this.Text = "DiffIcon";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_bottom.ResumeLayout(false);
            this.tabControl_image.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_replace;
        private System.Windows.Forms.Button btnNav2Sel;
        private System.Windows.Forms.Button btn_garminSel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nav2IconFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_garminIconFolder;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.TabControl tabControl_image;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList_new;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_show_changedIcon;
        private System.Windows.Forms.Button btn_showChange;
        private System.Windows.Forms.Label lblNewCount;
        private System.Windows.Forms.Label lblTotalNew;
        private System.Windows.Forms.Label lblDiffCount;
        private System.Windows.Forms.Label lblToltalDiff;
    }
}

