using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiffIconPic.Lib
{
    class WinformHelper
    {
        //带checkbox字段的DataTable除第一列外不可编辑
        //colNmbr开始不可编辑列号
        public static void SetEditingForDataGridView(int colNmbr, DataGridView dataGridView)
        {
            DataTable dt = (DataTable)dataGridView.DataSource;
            for (int i = colNmbr; i < dt.Columns.Count; i++)
            {
                dataGridView.Columns[i].ReadOnly = true;
            }

            if (dataGridView.Rows.Count != 0)
            {
                dataGridView.Rows[0].Selected = false;
            }
            dataGridView.Refresh();
        }

        public static void CreateDirectory(string parentFolderPath,string folderName)
        {
            if (!Directory.Exists(parentFolderPath + "\\" + folderName))
                Directory.CreateDirectory(parentFolderPath + "\\" + folderName);
        }

        public static void CopyFileToFolder(string sourceFile,string targetFolder)
        {
            File.Copy(sourceFile,targetFolder+"\\"+Path.GetFileName(sourceFile),true);
        }
    }
}
