namespace WindowsFormsApp4
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.labelcount = new System.Windows.Forms.Label();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(62, 69);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(159, 20);
            this.labelcount.TabIndex = 0;
            this.labelcount.Text = "Person(s) In Room: 0";
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM5";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 9);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(256, 20);
            this.status.TabIndex = 2;
            this.status.Text = "Connection Status: Not Connected";
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(301, 161);
            this.Controls.Add(this.status);
            this.Controls.Add(this.labelcount);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label labelcount;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label status;
    }
}