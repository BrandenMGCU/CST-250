﻿namespace Actiity_4__Hero_Maker_
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_sortAZ = new System.Windows.Forms.Button();
            this.btn_sortZA = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 704);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(908, 647);
            this.textBox1.TabIndex = 1;
            // 
            // btn_sortAZ
            // 
            this.btn_sortAZ.Location = new System.Drawing.Point(364, 13);
            this.btn_sortAZ.Name = "btn_sortAZ";
            this.btn_sortAZ.Size = new System.Drawing.Size(187, 51);
            this.btn_sortAZ.TabIndex = 2;
            this.btn_sortAZ.Text = "A->Z";
            this.btn_sortAZ.UseVisualStyleBackColor = true;
            this.btn_sortAZ.Click += new System.EventHandler(this.btn_sortAZ_Click);
            // 
            // btn_sortZA
            // 
            this.btn_sortZA.Location = new System.Drawing.Point(590, 13);
            this.btn_sortZA.Name = "btn_sortZA";
            this.btn_sortZA.Size = new System.Drawing.Size(180, 51);
            this.btn_sortZA.TabIndex = 3;
            this.btn_sortZA.Text = "Z->A";
            this.btn_sortZA.UseVisualStyleBackColor = true;
            this.btn_sortZA.Click += new System.EventHandler(this.btn_sortZA_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(818, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(170, 51);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 741);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_sortZA);
            this.Controls.Add(this.btn_sortAZ);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_sortAZ;
        private System.Windows.Forms.Button btn_sortZA;
        private System.Windows.Forms.Button btn_delete;
    }
}