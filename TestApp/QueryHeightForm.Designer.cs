namespace MeshExplorer
{
    partial class QueryHeightForm
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
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.tbx_File = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_GhLc = new System.Windows.Forms.TextBox();
            this.tbx_Height = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(413, 12);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 0;
            this.btn_SelectFile.Text = "选择";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.Btn_SelectFile_Click);
            // 
            // tbx_File
            // 
            this.tbx_File.Location = new System.Drawing.Point(58, 14);
            this.tbx_File.Name = "tbx_File";
            this.tbx_File.Size = new System.Drawing.Size(349, 21);
            this.tbx_File.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库";
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(413, 70);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 3;
            this.btn_Calc.Text = "计算";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "里程";
            // 
            // tbx_GhLc
            // 
            this.tbx_GhLc.Location = new System.Drawing.Point(58, 72);
            this.tbx_GhLc.Name = "tbx_GhLc";
            this.tbx_GhLc.Size = new System.Drawing.Size(104, 21);
            this.tbx_GhLc.TabIndex = 4;
            // 
            // tbx_Height
            // 
            this.tbx_Height.Location = new System.Drawing.Point(303, 72);
            this.tbx_Height.Name = "tbx_Height";
            this.tbx_Height.Size = new System.Drawing.Size(104, 21);
            this.tbx_Height.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "高程";
            // 
            // QueryHeightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_Height);
            this.Controls.Add(this.tbx_GhLc);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_File);
            this.Controls.Add(this.btn_SelectFile);
            this.Name = "QueryHeightForm";
            this.Text = "QueryHeightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox tbx_File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_GhLc;
        private System.Windows.Forms.TextBox tbx_Height;
        private System.Windows.Forms.Label label3;
    }
}