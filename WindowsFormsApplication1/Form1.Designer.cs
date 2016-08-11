namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.endsnake = new System.Windows.Forms.Label();
            this.beginsnake = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // endsnake
            // 
            this.endsnake.AutoSize = true;
            this.endsnake.BackColor = System.Drawing.SystemColors.Highlight;
            this.endsnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endsnake.Location = new System.Drawing.Point(169, 200);
            this.endsnake.Name = "endsnake";
            this.endsnake.Padding = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.endsnake.Size = new System.Drawing.Size(42, 40);
            this.endsnake.TabIndex = 131;
            // 
            // beginsnake
            // 
            this.beginsnake.BackColor = System.Drawing.SystemColors.Highlight;
            this.beginsnake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beginsnake.Location = new System.Drawing.Point(169, 160);
            this.beginsnake.Name = "beginsnake";
            this.beginsnake.Padding = new System.Windows.Forms.Padding(20, 20, 20, 5);
            this.beginsnake.Size = new System.Drawing.Size(42, 40);
            this.beginsnake.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(452, 380);
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 108);
            this.label1.TabIndex = 133;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.beginsnake);
            this.Controls.Add(this.endsnake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label endsnake;
        public System.Windows.Forms.Label beginsnake;
        private System.Windows.Forms.Timer timer1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

