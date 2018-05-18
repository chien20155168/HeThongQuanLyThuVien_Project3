namespace Lib_Manage
{
    partial class Form_borrowReturn_timSV
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
            this.form__Students1 = new Lib_Manage.Form__Students();
            this.SuspendLayout();
            // 
            // form__Students1
            // 
            this.form__Students1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.form__Students1.Location = new System.Drawing.Point(0, 0);
            this.form__Students1.Name = "form__Students1";
            this.form__Students1.Size = new System.Drawing.Size(996, 551);
            this.form__Students1.TabIndex = 0;
            this.form__Students1.Load += new System.EventHandler(this.form__Students1_Load);
            // 
            // Form_borrowReturn_timSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 556);
            this.Controls.Add(this.form__Students1);
            this.Name = "Form_borrowReturn_timSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_borrowReturn_timSV";
            this.ResumeLayout(false);

        }

        #endregion

        private Form__Students form__Students1;
    }
}