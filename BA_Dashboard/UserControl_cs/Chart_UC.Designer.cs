namespace BA_Dashboard
{
    partial class Chart_UC
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart_UC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.chart61 = new BA_Dashboard.Chart6();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.chart51 = new BA_Dashboard.Chart5();
            this.elementHost3 = new System.Windows.Forms.Integration.ElementHost();
            this.chart71 = new BA_Dashboard.Chart7();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondTopPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SecondTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1644, 839);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.elementHost3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1644, 839);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(3, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(542, 833);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.chart61;
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(551, 3);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(542, 833);
            this.elementHost2.TabIndex = 1;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.chart51;
            // 
            // elementHost3
            // 
            this.elementHost3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost3.Location = new System.Drawing.Point(1099, 3);
            this.elementHost3.Name = "elementHost3";
            this.elementHost3.Size = new System.Drawing.Size(542, 833);
            this.elementHost3.TabIndex = 2;
            this.elementHost3.Text = "elementHost3";
            this.elementHost3.Child = this.chart71;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(68, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "차트통계";
            // 
            // SecondTopPanel
            // 
            this.SecondTopPanel.BackColor = System.Drawing.Color.White;
            this.SecondTopPanel.Controls.Add(this.label2);
            this.SecondTopPanel.Controls.Add(this.pictureBox2);
            this.SecondTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondTopPanel.Location = new System.Drawing.Point(0, 0);
            this.SecondTopPanel.Name = "SecondTopPanel";
            this.SecondTopPanel.Size = new System.Drawing.Size(1644, 62);
            this.SecondTopPanel.TabIndex = 7;
            // 
            // Chart_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SecondTopPanel);
            this.Enabled = false;
            this.Name = "Chart_UC";
            this.Size = new System.Drawing.Size(1644, 901);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SecondTopPanel.ResumeLayout(false);
            this.SecondTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Chart6 chart61;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private Chart5 chart51;
        private System.Windows.Forms.Integration.ElementHost elementHost3;
        private Chart7 chart71;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel SecondTopPanel;
    }
}
