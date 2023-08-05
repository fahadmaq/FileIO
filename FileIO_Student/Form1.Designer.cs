namespace FileIO_Student
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
            this.btWrite = new System.Windows.Forms.Button();
            this.btRead = new System.Windows.Forms.Button();
            this.lbRno = new System.Windows.Forms.Label();
            this.lbNAme = new System.Windows.Forms.Label();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.txRollNo = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txPercentage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btWrite
            // 
            this.btWrite.Location = new System.Drawing.Point(171, 302);
            this.btWrite.Name = "btWrite";
            this.btWrite.Size = new System.Drawing.Size(150, 72);
            this.btWrite.TabIndex = 0;
            this.btWrite.Text = "Write";
            this.btWrite.UseVisualStyleBackColor = true;
            this.btWrite.Click += new System.EventHandler(this.btWrite_Click);
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(348, 302);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(150, 72);
            this.btRead.TabIndex = 1;
            this.btRead.Text = "Read";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // lbRno
            // 
            this.lbRno.AutoSize = true;
            this.lbRno.Location = new System.Drawing.Point(105, 43);
            this.lbRno.Name = "lbRno";
            this.lbRno.Size = new System.Drawing.Size(84, 16);
            this.lbRno.TabIndex = 2;
            this.lbRno.Text = "ROll Number";
            // 
            // lbNAme
            // 
            this.lbNAme.AutoSize = true;
            this.lbNAme.Location = new System.Drawing.Point(105, 125);
            this.lbNAme.Name = "lbNAme";
            this.lbNAme.Size = new System.Drawing.Size(44, 16);
            this.lbNAme.TabIndex = 3;
            this.lbNAme.Text = "Name";
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Location = new System.Drawing.Point(105, 207);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(77, 16);
            this.lbPercentage.TabIndex = 4;
            this.lbPercentage.Text = "Percentage";
            // 
            // txRollNo
            // 
            this.txRollNo.Location = new System.Drawing.Point(287, 40);
            this.txRollNo.Multiline = true;
            this.txRollNo.Name = "txRollNo";
            this.txRollNo.Size = new System.Drawing.Size(163, 36);
            this.txRollNo.TabIndex = 5;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(287, 122);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(163, 36);
            this.txName.TabIndex = 6;
            // 
            // txPercentage
            // 
            this.txPercentage.Location = new System.Drawing.Point(287, 204);
            this.txPercentage.Multiline = true;
            this.txPercentage.Name = "txPercentage";
            this.txPercentage.Size = new System.Drawing.Size(163, 36);
            this.txPercentage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txPercentage);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txRollNo);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.lbNAme);
            this.Controls.Add(this.lbRno);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.btWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btWrite;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label lbRno;
        private System.Windows.Forms.Label lbNAme;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.TextBox txRollNo;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txPercentage;
    }
}

