using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        string strTargetPath;
        string strOriginPath;
        string strRootPath;

        public Main()
        {
            InitializeComponent();
            
        }//Main

        private void Main_Load(object sender, EventArgs e)
        {
            LoadXml();
            SetColumns();
        }//Main_Load

        /*Initialize the columns of the listViews*/
        private void SetColumns()
        {
            lstOriginSources.BeginUpdate();
            lstOriginSources.View = View.Details;
            lstOriginSources.Columns.Add("Name", 150,HorizontalAlignment.Left);
            lstOriginSources.Columns.Add("Last Update", 150, HorizontalAlignment.Left);
            lstOriginSources.Columns.Add("Size", 100, HorizontalAlignment.Left);
            lstOriginSources.Columns.Add("Path", 300, HorizontalAlignment.Left);
            lstOriginSources.EndUpdate();

            lstTargetSources.BeginUpdate();
            lstTargetSources.View = View.Details;
            lstTargetSources.Columns.Add("Name", 150, HorizontalAlignment.Left);
            lstTargetSources.Columns.Add("Last Update", 150, HorizontalAlignment.Left);
            lstTargetSources.Columns.Add("Size", 100, HorizontalAlignment.Left);
            lstTargetSources.Columns.Add("Path", 300, HorizontalAlignment.Left);
            lstTargetSources.EndUpdate();
        }//SetCollumns

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Settings nextForm = new Settings();
            nextForm.ShowDialog();
        }//btnSetting_Click

        /*
         * It loads the xml file for setting.
         */
        private void LoadXml()
        {
            DataSet dsSettings = new DataSet("Settings");
            dsSettings.ReadXml(Com.SettingXmlFile);

            DataRow drSettings = dsSettings.Tables[0].Rows[0];
            strTargetPath = drSettings["serverPath"].ToString();
            strOriginPath = drSettings["localPath"].ToString();
            strRootPath = drSettings["rootPath"].ToString();
        }//LoadXml

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstOriginSources.Items.Clear();
            lstTargetSources.Items.Clear();
            string csrId = tbxCsrId.Text;

            string[] fileList = Directory.GetFiles(strOriginPath,"*.*",SearchOption.AllDirectories);
            foreach(string file in fileList)
            {
                string strFileContents = File.ReadAllText(file);
                bool result = strFileContents.Contains(csrId);
                if (result)
                {
                    FileInfo fi = new FileInfo(file);
                    string[] row = {fi.Name , fi.LastWriteTime.ToString() ,fi.Length.ToString() ,   fi.DirectoryName};
                    ListViewItem rowData = new ListViewItem(row);
                    lstOriginSources.Items.Add(rowData);


                    FileInfo destFi = new FileInfo(file.Replace(strOriginPath, strTargetPath));
                    string[] destRow = { destFi.Name, destFi.LastWriteTime.ToString(), destFi.Length.ToString(), destFi.DirectoryName };
                    ListViewItem destRowData = new ListViewItem(destRow);
                    lstTargetSources.Items.Add(destRowData);

                }//if
            }//for

             


        }//btnSearch_Click

        private void btnMakeFolders_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lstOriginSources.Items.Count; i++ )
            {
                ListViewItem lvItem = lstOriginSources.Items[i];
                Directory.CreateDirectory(lvItem.SubItems[3].Text.Replace(strOriginPath,strRootPath +"\\"));
            }//for

        }//btnMakeFolders_Click



    }//Main
}
