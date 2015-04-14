namespace WindowsFormsApplication1
{
    partial class Settings
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
            this.lblTargetProjectPath = new System.Windows.Forms.Label();
            this.tbxTargetProjectPath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOriginProjectPath = new System.Windows.Forms.Label();
            this.tbxOriginProjectPath = new System.Windows.Forms.TextBox();
            this.lblTargetFoldersRootPath = new System.Windows.Forms.Label();
            this.tbxTargetFoldersRootPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblServerProjectPath
            // 
            this.lblTargetProjectPath.AutoSize = true;
            this.lblTargetProjectPath.Location = new System.Drawing.Point(10, 9);
            this.lblTargetProjectPath.Name = "lblServerProjectPath";
            this.lblTargetProjectPath.Size = new System.Drawing.Size(121, 12);
            this.lblTargetProjectPath.TabIndex = 0;
            this.lblTargetProjectPath.Text = "Server 프로젝트 경로";
            // 
            // tbxServerProjectPath
            // 
            this.tbxTargetProjectPath.Location = new System.Drawing.Point(139, 4);
            this.tbxTargetProjectPath.Name = "tbxServerProjectPath";
            this.tbxTargetProjectPath.Size = new System.Drawing.Size(346, 21);
            this.tbxTargetProjectPath.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(388, 96);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 23);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLocalProjectPath
            // 
            this.lblOriginProjectPath.AutoSize = true;
            this.lblOriginProjectPath.Location = new System.Drawing.Point(22, 40);
            this.lblOriginProjectPath.Name = "lblLocalProjectPath";
            this.lblOriginProjectPath.Size = new System.Drawing.Size(109, 12);
            this.lblOriginProjectPath.TabIndex = 7;
            this.lblOriginProjectPath.Text = "로컬 프로젝트 경로";
            // 
            // tbxLocalProjectPath
            // 
            this.tbxOriginProjectPath.Location = new System.Drawing.Point(139, 34);
            this.tbxOriginProjectPath.Name = "tbxLocalProjectPath";
            this.tbxOriginProjectPath.Size = new System.Drawing.Size(346, 21);
            this.tbxOriginProjectPath.TabIndex = 40;
            // 
            // lblTargetFoldersRootPath
            // 
            this.lblTargetFoldersRootPath.AutoSize = true;
            this.lblTargetFoldersRootPath.Location = new System.Drawing.Point(42, 66);
            this.lblTargetFoldersRootPath.Name = "lblTargetFoldersRootPath";
            this.lblTargetFoldersRootPath.Size = new System.Drawing.Size(89, 12);
            this.lblTargetFoldersRootPath.TabIndex = 9;
            this.lblTargetFoldersRootPath.Text = "생성될폴더위치";
            // 
            // tbxTargetFoldersRootPath
            // 
            this.tbxTargetFoldersRootPath.Location = new System.Drawing.Point(139, 62);
            this.tbxTargetFoldersRootPath.Name = "tbxTargetFoldersRootPath";
            this.tbxTargetFoldersRootPath.Size = new System.Drawing.Size(346, 21);
            this.tbxTargetFoldersRootPath.TabIndex = 60;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 131);
            this.Controls.Add(this.tbxTargetFoldersRootPath);
            this.Controls.Add(this.lblTargetFoldersRootPath);
            this.Controls.Add(this.tbxOriginProjectPath);
            this.Controls.Add(this.lblOriginProjectPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxTargetProjectPath);
            this.Controls.Add(this.lblTargetProjectPath);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTargetProjectPath;
        private System.Windows.Forms.TextBox tbxTargetProjectPath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOriginProjectPath;
        private System.Windows.Forms.TextBox tbxOriginProjectPath;
        private System.Windows.Forms.Label lblTargetFoldersRootPath;
        private System.Windows.Forms.TextBox tbxTargetFoldersRootPath;
    }
}

