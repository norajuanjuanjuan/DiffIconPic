using DiffIconPic.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiffIconPic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNewCount.Text = "";
            lblDiffCount.Text = "";
            lblToltalDiff.Visible = false;
            lblTotalNew.Visible = false;
            txt_garminIconFolder.Text = Constant.GarminIconFolder;
            txt_garminIconFolder.Select(0,0);
        }

        private void btn_garminSel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if(fbd.SelectedPath!="")
                txt_garminIconFolder.Text = fbd.SelectedPath;
                Constant.setConstantGarminPathValue(txt_garminIconFolder.Text);
            }
        }

        private void btnNav2Sel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                if (fbd.SelectedPath != "")
                    txt_nav2IconFolder.Text = fbd.SelectedPath;
                Constant.setConstantNav2PathValue(txt_nav2IconFolder.Text);
            }
        }


        private void btn_show_newIcon_Click(object sender, EventArgs e)
        {
            Constant.setConstantGarminPathValue(txt_garminIconFolder.Text);
            Constant.setConstantNav2PathValue(txt_nav2IconFolder.Text);
            if (Constant.GarminIconFolder!= "" && Constant.Nav2IconFolder != "")
            {
                imageList_new.Images.Clear();
                imageList_new.ImageSize = new System.Drawing.Size(32, 32);
                listView1.Items.Clear();
                this.listView1.LargeImageList = imageList_new;
                this.listView1.View = View.LargeIcon;

                Dictionary<string, string> dic_garmin_path = PictureHelper.GetAllPicPath(Constant.GarminIconFolder);
                Dictionary<string, string> dic_nav2_path = PictureHelper.GetAllPicPath(Constant.Nav2IconFolder);
                List<string> list_new_icon_path = PictureHelper.GetNewIconPath(dic_garmin_path, dic_nav2_path);

                this.listView1.BeginUpdate();
                for (int i = 0; i < list_new_icon_path.Count; i++)
                {
                    Image img = (Image)PictureHelper.GetBitmap(list_new_icon_path[i]);
                    imageList_new.Images.Add(img);
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    lvi.Text = Path.GetFileName(list_new_icon_path[i]);
                    this.listView1.Items.Add(lvi);
                }
                this.listView1.EndUpdate();
                lblTotalNew.Visible = true;
                lblNewCount.Text = list_new_icon_path.Count.ToString();
            }
        }

        private void btn_insertNew_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_showChange_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void btn_replace_Click(object sender, EventArgs e)
        {
            int nwCount=InsertNewIcon();
            int reCount = ReplaceOldIcon();

            MessageBox.Show("Done!\n新增Icon：" + nwCount + "笔!\n替换旧Icon:" + reCount + "笔！");
            
        }

        #region Methods
        void SetDataGridView()
        {
            dataGridView1.Columns["IsSelected"].HeaderText = "  ";
            WinformHelper.SetEditingForDataGridView(1,dataGridView1);
        }

        void RefreshDataGridView()
        {
            Constant.setConstantGarminPathValue(txt_garminIconFolder.Text);
            Constant.setConstantNav2PathValue(txt_nav2IconFolder.Text);
            if (Constant.GarminIconFolder != "" && Constant.Nav2IconFolder != "")
            {
                Constant.GarminIconFolder = txt_garminIconFolder.Text;
                dataGridView1.DataSource = null;
                Dictionary<string, string> dic_garmin_path = PictureHelper.GetAllPicPath(Constant.GarminIconFolder);
                Dictionary<string, string> dic_nav2_path = PictureHelper.GetAllPicPath(Constant.Nav2IconFolder);
                List<string> list_changed_icon_path = PictureHelper.GetDiffIconPath(dic_garmin_path, dic_nav2_path);

                DataTable dt = GetChangedIconInfo(list_changed_icon_path);
                dataGridView1.DataSource = dt;
                SetDataGridView();
                lblToltalDiff.Visible = true;
                lblDiffCount.Text = dt.Rows.Count.ToString();
            }
        }
        
       DataTable GetChangedIconInfo(List<string> list_path)
       {
           DataTable dt = new DataTable();
           dt.Columns.Add("BrandId",typeof(string));
           dt.Columns.Add("OldIcon", typeof(byte[]));
           dt.Columns.Add("NewIcon", typeof(byte[]));
           //add a new column for checkbox
           DataColumn dc = new DataColumn("IsSelected", System.Type.GetType("System.Boolean"));
           dc.DefaultValue = false;
           dt.Columns.Add(dc);
           dt.Columns["IsSelected"].SetOrdinal(0);
           foreach (string path in list_path)
           {
               string bmp_fileName = Path.GetFileNameWithoutExtension(path);
               string brandId = bmp_fileName.Split('_')[0];
               string oldIconPath = txt_garminIconFolder.Text + "\\" + brandId + "_day_2.png";
               DataRow dr = dt.NewRow();
               dr["BrandId"] = brandId;
               dr["OldIcon"] =PictureHelper.GetByteImage(PictureHelper.GetBitmap(oldIconPath));
               dr["NewIcon"] =PictureHelper.GetByteImage( PictureHelper.GetBitmap(path));
               dt.Rows.Add(dr);
           }
           return dt;
       }
       int InsertNewIcon()
       {
           //insert new icon
           Constant.setConstantGarminPathValue(txt_garminIconFolder.Text);
           Constant.setConstantNav2PathValue(txt_nav2IconFolder.Text);
           List<string> list_new_icon_path = new List<string>();

           if (Constant.GarminIconFolder != "" && Constant.Nav2IconFolder != "")
           {
               Dictionary<string, string> dic_garmin_path = PictureHelper.GetAllPicPath(Constant.GarminIconFolder);
               Dictionary<string, string> dic_nav2_path = PictureHelper.GetAllPicPath(Constant.Nav2IconFolder);
               list_new_icon_path = PictureHelper.GetNewIconPath(dic_garmin_path, dic_nav2_path);

               WinformHelper.CreateDirectory(Constant.GarminNouseIconFolder, "new");
               string newFolderPath = Constant.GarminNouseIconFolder + "\\new";
               foreach (string filePath in list_new_icon_path)
               {
                   WinformHelper.CopyFileToFolder(filePath, newFolderPath); //backup new icon
                   WinformHelper.CopyFileToFolder(filePath, Constant.GarminIconFolder);
                   PictureHelper.ResizeIcon32(filePath, 24, Constant.GarminIconFolder);
                   PictureHelper.ResizeIcon32(filePath, 64, Constant.GarminIconFolder);
               }
           }
           return list_new_icon_path.Count;
       }
       int ReplaceOldIcon()
       {
           int handle = 0;
           if (dataGridView1.Rows.Count != 0)
           {
               //back up old ones
               WinformHelper.CreateDirectory(Constant.GarminNouseIconFolder, "old");
               string oldFolderPath = Constant.GarminNouseIconFolder + "\\old";

               DataTable dt = (DataTable)dataGridView1.DataSource;

               foreach (DataRow dr in dt.Rows)
               {
                   if (Convert.ToBoolean(dr["IsSelected"]) == true)
                   {
                       string oldFile = Constant.GarminIconFolder + "\\" + dr["BrandId"] + "_day_";
                       string filePath = txt_nav2IconFolder.Text + "\\" + dr["BrandId"] + "_day_2.png";
                       if (File.Exists(oldFile + "1.png")) WinformHelper.CopyFileToFolder(oldFile + "1.png", oldFolderPath);
                       WinformHelper.CopyFileToFolder(oldFile + "2.png", oldFolderPath);
                       if (File.Exists(oldFile + "3.png")) WinformHelper.CopyFileToFolder(oldFile + "3.png", oldFolderPath);
                       WinformHelper.CopyFileToFolder(filePath, Constant.GarminIconFolder);
                       PictureHelper.ResizeIcon32(filePath, 24, Constant.GarminIconFolder);
                       PictureHelper.ResizeIcon32(filePath, 64, Constant.GarminIconFolder);
                       handle++;
                   }
               }
               RefreshDataGridView();
           }
           return handle;
       }
        #endregion
    }
}
