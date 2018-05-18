namespace Lib_Manage
{
    partial class Form_Statistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Statistics));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.form_thongke_SachDaMuon1 = new Lib_Manage.Form_thongke_SachDaMuon();
            this.form_thongke_SVQuaHan1 = new Lib_Manage.Form_thongke_SVQuaHan();
            this.form_thongke_LichSu1 = new Lib_Manage.Form_thongke_LichSu();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sinh viên quá hạn";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(21, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lịch sử trả sách";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(21, 115);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(210, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sách Còn Lại";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // form_thongke_SachDaMuon1
            // 
            this.form_thongke_SachDaMuon1.Location = new System.Drawing.Point(251, 3);
            this.form_thongke_SachDaMuon1.Name = "form_thongke_SachDaMuon1";
            this.form_thongke_SachDaMuon1.Size = new System.Drawing.Size(745, 548);
            this.form_thongke_SachDaMuon1.TabIndex = 5;
            this.form_thongke_SachDaMuon1.Load += new System.EventHandler(this.form_thongke_SachDaMuon1_Load);
            // 
            // form_thongke_SVQuaHan1
            // 
            this.form_thongke_SVQuaHan1.Location = new System.Drawing.Point(251, 0);
            this.form_thongke_SVQuaHan1.Name = "form_thongke_SVQuaHan1";
            this.form_thongke_SVQuaHan1.Size = new System.Drawing.Size(745, 551);
            this.form_thongke_SVQuaHan1.TabIndex = 4;
            // 
            // form_thongke_LichSu1
            // 
            this.form_thongke_LichSu1.Location = new System.Drawing.Point(251, 0);
            this.form_thongke_LichSu1.Name = "form_thongke_LichSu1";
            this.form_thongke_LichSu1.Size = new System.Drawing.Size(745, 551);
            this.form_thongke_LichSu1.TabIndex = 3;
            // 
            // Form_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.form_thongke_SachDaMuon1);
            this.Controls.Add(this.form_thongke_SVQuaHan1);
            this.Controls.Add(this.form_thongke_LichSu1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form_Statistics";
            this.Size = new System.Drawing.Size(996, 551);
            this.Load += new System.EventHandler(this.Form_Statistics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Form_thongke_LichSu form_thongke_LichSu1;
        private Form_thongke_SVQuaHan form_thongke_SVQuaHan1;
        private Form_thongke_SachDaMuon form_thongke_SachDaMuon1;
    }
}
