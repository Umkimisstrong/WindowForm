namespace WindowsFormsApplication2
{
    partial class Form1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_header = new System.Windows.Forms.Panel();
            this.header_title = new System.Windows.Forms.Label();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.panel_detail_01 = new System.Windows.Forms.Panel();
            this.grid_sawon = new System.Windows.Forms.DataGridView();
            this.panel_detail_02 = new System.Windows.Forms.Panel();
            this.panel_middle = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_sw = new System.Windows.Forms.CheckBox();
            this.chk_jy = new System.Windows.Forms.CheckBox();
            this.chk_dr = new System.Windows.Forms.CheckBox();
            this.chk_gj = new System.Windows.Forms.CheckBox();
            this.chk_cj = new System.Windows.Forms.CheckBox();
            this.chk_bj = new System.Windows.Forms.CheckBox();
            this.label_sw = new System.Windows.Forms.Label();
            this.label_jy = new System.Windows.Forms.Label();
            this.label_dr = new System.Windows.Forms.Label();
            this.label_gj = new System.Windows.Forms.Label();
            this.label_cj = new System.Windows.Forms.Label();
            this.lable_bj = new System.Windows.Forms.Label();
            this.panel_header.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_detail_01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sawon)).BeginInit();
            this.panel_middle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_header.Controls.Add(this.header_title);
            this.panel_header.Location = new System.Drawing.Point(16, 17);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(889, 78);
            this.panel_header.TabIndex = 0;
            // 
            // header_title
            // 
            this.header_title.AutoSize = true;
            this.header_title.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.header_title.Location = new System.Drawing.Point(61, 26);
            this.header_title.Name = "header_title";
            this.header_title.Size = new System.Drawing.Size(144, 29);
            this.header_title.TabIndex = 0;
            this.header_title.Text = "사원 관리";
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_menu.Controls.Add(this.btn_delete);
            this.panel_menu.Controls.Add(this.btn_update);
            this.panel_menu.Controls.Add(this.btn_select);
            this.panel_menu.Location = new System.Drawing.Point(21, 134);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 301);
            this.panel_menu.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(27, 174);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "정보 삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(27, 118);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "정보 수정";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_select
            // 
            this.btn_select.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_select.Location = new System.Drawing.Point(27, 61);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "사원 조회";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_detail_01
            // 
            this.panel_detail_01.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_detail_01.Controls.Add(this.grid_sawon);
            this.panel_detail_01.Location = new System.Drawing.Point(471, 134);
            this.panel_detail_01.Name = "panel_detail_01";
            this.panel_detail_01.Size = new System.Drawing.Size(434, 171);
            this.panel_detail_01.TabIndex = 2;
            // 
            // grid_sawon
            // 
            this.grid_sawon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sawon.Location = new System.Drawing.Point(27, 10);
            this.grid_sawon.Name = "grid_sawon";
            this.grid_sawon.RowTemplate.Height = 23;
            this.grid_sawon.Size = new System.Drawing.Size(365, 150);
            this.grid_sawon.TabIndex = 0;
            // 
            // panel_detail_02
            // 
            this.panel_detail_02.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_detail_02.Location = new System.Drawing.Point(471, 335);
            this.panel_detail_02.Name = "panel_detail_02";
            this.panel_detail_02.Size = new System.Drawing.Size(434, 100);
            this.panel_detail_02.TabIndex = 3;
            // 
            // panel_middle
            // 
            this.panel_middle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_middle.Controls.Add(this.panel1);
            this.panel_middle.Location = new System.Drawing.Point(245, 136);
            this.panel_middle.Name = "panel_middle";
            this.panel_middle.Size = new System.Drawing.Size(200, 299);
            this.panel_middle.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.chk_sw);
            this.panel1.Controls.Add(this.chk_jy);
            this.panel1.Controls.Add(this.chk_dr);
            this.panel1.Controls.Add(this.chk_gj);
            this.panel1.Controls.Add(this.chk_cj);
            this.panel1.Controls.Add(this.chk_bj);
            this.panel1.Controls.Add(this.label_sw);
            this.panel1.Controls.Add(this.label_jy);
            this.panel1.Controls.Add(this.label_dr);
            this.panel1.Controls.Add(this.label_gj);
            this.panel1.Controls.Add(this.label_cj);
            this.panel1.Controls.Add(this.lable_bj);
            this.panel1.Location = new System.Drawing.Point(20, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 248);
            this.panel1.TabIndex = 0;
            // 
            // chk_sw
            // 
            this.chk_sw.AutoSize = true;
            this.chk_sw.Location = new System.Drawing.Point(73, 198);
            this.chk_sw.Name = "chk_sw";
            this.chk_sw.Size = new System.Drawing.Size(15, 14);
            this.chk_sw.TabIndex = 11;
            this.chk_sw.UseVisualStyleBackColor = true;
            this.chk_sw.CheckedChanged += new System.EventHandler(this.chk_sw_CheckedChanged);
            // 
            // chk_jy
            // 
            this.chk_jy.AutoSize = true;
            this.chk_jy.Location = new System.Drawing.Point(73, 164);
            this.chk_jy.Name = "chk_jy";
            this.chk_jy.Size = new System.Drawing.Size(15, 14);
            this.chk_jy.TabIndex = 10;
            this.chk_jy.UseVisualStyleBackColor = true;
            this.chk_jy.CheckedChanged += new System.EventHandler(this.chk_jy_CheckedChanged);
            // 
            // chk_dr
            // 
            this.chk_dr.AutoSize = true;
            this.chk_dr.Location = new System.Drawing.Point(73, 123);
            this.chk_dr.Name = "chk_dr";
            this.chk_dr.Size = new System.Drawing.Size(15, 14);
            this.chk_dr.TabIndex = 9;
            this.chk_dr.UseVisualStyleBackColor = true;
            this.chk_dr.CheckedChanged += new System.EventHandler(this.chk_dr_CheckedChanged);
            // 
            // chk_gj
            // 
            this.chk_gj.AutoSize = true;
            this.chk_gj.Location = new System.Drawing.Point(73, 88);
            this.chk_gj.Name = "chk_gj";
            this.chk_gj.Size = new System.Drawing.Size(15, 14);
            this.chk_gj.TabIndex = 8;
            this.chk_gj.UseVisualStyleBackColor = true;
            this.chk_gj.CheckedChanged += new System.EventHandler(this.chk_gj_CheckedChanged);
            // 
            // chk_cj
            // 
            this.chk_cj.AutoSize = true;
            this.chk_cj.Location = new System.Drawing.Point(73, 52);
            this.chk_cj.Name = "chk_cj";
            this.chk_cj.Size = new System.Drawing.Size(15, 14);
            this.chk_cj.TabIndex = 7;
            this.chk_cj.UseVisualStyleBackColor = true;
            this.chk_cj.CheckedChanged += new System.EventHandler(this.chk_cj_CheckedChanged);
            // 
            // chk_bj
            // 
            this.chk_bj.AutoSize = true;
            this.chk_bj.Location = new System.Drawing.Point(73, 18);
            this.chk_bj.Name = "chk_bj";
            this.chk_bj.Size = new System.Drawing.Size(15, 14);
            this.chk_bj.TabIndex = 6;
            this.chk_bj.UseVisualStyleBackColor = true;
            this.chk_bj.CheckedChanged += new System.EventHandler(this.chk_bj_CheckedChanged);
            // 
            // label_sw
            // 
            this.label_sw.AutoSize = true;
            this.label_sw.BackColor = System.Drawing.Color.Gainsboro;
            this.label_sw.Location = new System.Drawing.Point(14, 203);
            this.label_sw.Name = "label_sw";
            this.label_sw.Size = new System.Drawing.Size(29, 12);
            this.label_sw.TabIndex = 5;
            this.label_sw.Text = "사원";
            // 
            // label_jy
            // 
            this.label_jy.AutoSize = true;
            this.label_jy.BackColor = System.Drawing.Color.Gainsboro;
            this.label_jy.Location = new System.Drawing.Point(14, 165);
            this.label_jy.Name = "label_jy";
            this.label_jy.Size = new System.Drawing.Size(29, 12);
            this.label_jy.TabIndex = 4;
            this.label_jy.Text = "주임";
            // 
            // label_dr
            // 
            this.label_dr.AutoSize = true;
            this.label_dr.BackColor = System.Drawing.Color.Gainsboro;
            this.label_dr.Location = new System.Drawing.Point(14, 125);
            this.label_dr.Name = "label_dr";
            this.label_dr.Size = new System.Drawing.Size(29, 12);
            this.label_dr.TabIndex = 3;
            this.label_dr.Text = "대리";
            // 
            // label_gj
            // 
            this.label_gj.AutoSize = true;
            this.label_gj.BackColor = System.Drawing.Color.Gainsboro;
            this.label_gj.Location = new System.Drawing.Point(14, 88);
            this.label_gj.Name = "label_gj";
            this.label_gj.Size = new System.Drawing.Size(29, 12);
            this.label_gj.TabIndex = 2;
            this.label_gj.Text = "과장";
            // 
            // label_cj
            // 
            this.label_cj.AutoSize = true;
            this.label_cj.BackColor = System.Drawing.Color.Gainsboro;
            this.label_cj.Location = new System.Drawing.Point(14, 51);
            this.label_cj.Name = "label_cj";
            this.label_cj.Size = new System.Drawing.Size(29, 12);
            this.label_cj.TabIndex = 1;
            this.label_cj.Text = "차장";
            // 
            // lable_bj
            // 
            this.lable_bj.AutoSize = true;
            this.lable_bj.BackColor = System.Drawing.Color.Gainsboro;
            this.lable_bj.Location = new System.Drawing.Point(14, 19);
            this.lable_bj.Name = "lable_bj";
            this.lable_bj.Size = new System.Drawing.Size(29, 12);
            this.lable_bj.TabIndex = 0;
            this.lable_bj.Text = "부장";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(917, 504);
            this.Controls.Add(this.panel_middle);
            this.Controls.Add(this.panel_detail_02);
            this.Controls.Add(this.panel_detail_01);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_detail_01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_sawon)).EndInit();
            this.panel_middle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_detail_01;
        private System.Windows.Forms.Panel panel_detail_02;
        private System.Windows.Forms.Panel panel_middle;
        private System.Windows.Forms.Label header_title;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_sw;
        private System.Windows.Forms.Label label_jy;
        private System.Windows.Forms.Label label_dr;
        private System.Windows.Forms.Label label_gj;
        private System.Windows.Forms.Label label_cj;
        private System.Windows.Forms.Label lable_bj;
        private System.Windows.Forms.CheckBox chk_sw;
        private System.Windows.Forms.CheckBox chk_jy;
        private System.Windows.Forms.CheckBox chk_dr;
        private System.Windows.Forms.CheckBox chk_gj;
        private System.Windows.Forms.CheckBox chk_cj;
        private System.Windows.Forms.CheckBox chk_bj;
        private System.Windows.Forms.DataGridView grid_sawon;
    }
}

