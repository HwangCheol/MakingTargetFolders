using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Settings : Form
    {
        private string strTargetProjectPath;
        private string strOriginProjectPath;
        private string strTargetFoldersRootPath;

        public Settings()
        {
            InitializeComponent();
            LoadSettings();
        }//Settings

        private void LoadSettings()
        {
            DataSet dsSettings = new DataSet("Settings");
            dsSettings.ReadXml(Com.SettingXmlFile);

            DataRow drSettings = dsSettings.Tables[0].Rows[0];
            string strTargetPath = drSettings["targetPath"].ToString();
            string strOriginPath = drSettings["originPath"].ToString();
            string strRootPath = drSettings["rootPath"].ToString();

            tbxTargetProjectPath.Text = strTargetPath;
            tbxOriginProjectPath.Text = strOriginPath;
            tbxTargetFoldersRootPath.Text = strRootPath;

        }//LoadSettings

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                strTargetProjectPath = tbxTargetProjectPath.Text;
                strOriginProjectPath = tbxOriginProjectPath.Text;
                strTargetFoldersRootPath = tbxTargetFoldersRootPath.Text;

                //Execute validation
                if (!SaveValidation()) return;

                DataSet dsSettings = new DataSet("Settings");
                dsSettings.ReadXml(".\\Settings.xml");

                DataRow drSettings = dsSettings.Tables[0].Rows[0];
                drSettings["serverPath"] = tbxTargetProjectPath.Text;
                drSettings["localPath"] = tbxOriginProjectPath.Text;
                drSettings["rootPath"] = tbxTargetFoldersRootPath.Text;

                dsSettings.AcceptChanges();
                dsSettings.WriteXml(Com.SettingXmlFile);

                MessageBox.Show("성공적으로 저장하였습니다.");
                this.DialogResult = DialogResult.OK;

            }//try
            catch (Exception err)
            {
                MessageBox.Show("저장에 실패하였습니다. " + err.Message);
            }//catch
            
        }//btnSave_Click

        private bool SaveValidation()
        {
            if (string.IsNullOrEmpty(strTargetProjectPath))
            {
              MessageBox.Show("서버 프로젝트 경로가 입력되지 않았습니다.");
              return false;
            }//if

            if (string.IsNullOrEmpty(strOriginProjectPath))
            {
              MessageBox.Show("로컬 프로젝트 경로가 입력되지 않았습니다.");
              return false;
            }//if

            if (string.IsNullOrEmpty(strTargetFoldersRootPath ))
            {
                MessageBox.Show("폴더루트 경로가 입력되지 않았습니다.");
              return false;
            }//if

            return true;
        }//SaveValidation

    }//Settings
}
