namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCsrId = new System.Windows.Forms.Label();
            this.tbxCsrId = new System.Windows.Forms.TextBox();
            this.lstOriginSources = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMakeFolders = new System.Windows.Forms.Button();
            this.lstTargetSources = new System.Windows.Forms.ListView();
            this.btnSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCsrId
            // 
            this.lblCsrId.AutoSize = true;
            this.lblCsrId.Location = new System.Drawing.Point(17, 31);
            this.lblCsrId.Name = "lblCsrId";
            this.lblCsrId.Size = new System.Drawing.Size(45, 12);
            this.lblCsrId.TabIndex = 0;
            this.lblCsrId.Text = "CSR ID";
            // 
            // tbxCsrId
            // 
            this.tbxCsrId.Location = new System.Drawing.Point(81, 24);
            this.tbxCsrId.Name = "tbxCsrId";
            this.tbxCsrId.Size = new System.Drawing.Size(143, 21);
            this.tbxCsrId.TabIndex = 1;
            // 
            // lstDevelopeSources
            // 
            this.lstOriginSources.Location = new System.Drawing.Point(12, 56);
            this.lstOriginSources.Name = "lstDevelopeSources";
            this.lstOriginSources.Size = new System.Drawing.Size(681, 438);
            this.lstOriginSources.TabIndex = 2;
            this.lstOriginSources.UseCompatibleStateImageBehavior = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMakeFolders
            // 
            this.btnMakeFolders.Location = new System.Drawing.Point(250, 500);
            this.btnMakeFolders.Name = "btnMakeFolders";
            this.btnMakeFolders.Size = new System.Drawing.Size(97, 23);
            this.btnMakeFolders.TabIndex = 4;
            this.btnMakeFolders.Text = "반영폴더생성";
            this.btnMakeFolders.UseVisualStyleBackColor = true;
            this.btnMakeFolders.Click += new System.EventHandler(this.btnMakeFolders_Click);
            // 
            // lstServerSources
            // 
            this.lstTargetSources.Location = new System.Drawing.Point(714, 56);
            this.lstTargetSources.Name = "lstServerSources";
            this.lstTargetSources.Size = new System.Drawing.Size(677, 438);
            this.lstTargetSources.TabIndex = 5;
            this.lstTargetSources.UseCompatibleStateImageBehavior = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Location = new System.Drawing.Point(1318, 20);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(75, 23);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "환경설정";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 581);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.lstTargetSources);
            this.Controls.Add(this.btnMakeFolders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstOriginSources);
            this.Controls.Add(this.tbxCsrId);
            this.Controls.Add(this.lblCsrId);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCsrId;
        private System.Windows.Forms.TextBox tbxCsrId;
        private System.Windows.Forms.ListView lstOriginSources;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMakeFolders;
        private System.Windows.Forms.ListView lstTargetSources;
        private System.Windows.Forms.Button btnSetting;
    }
}

