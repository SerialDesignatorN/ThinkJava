﻿#region Copyright
/***************************************************************************************
 ******Copyright (C) 2016 Pritam Zope*****
 
  <copyright file="New_XMLFile_Form.Designer.cs" company="">
  
 {-  Program Name = Silver-J
      An Integrated Development Environment(IDE) for Java Programming
      Language written In C#   -}  
 
   This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
  
   Please credit me if you reuse, don't sell it under your own name, don't pretend you're me
  </copyright>
  * ****************************************************************************************/
#endregion

namespace Silver_J
{
    partial class New_XMLFile_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_XMLFile_Form));
            this.errorlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.XMLTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorlabel.Location = new System.Drawing.Point(12, 182);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 17);
            this.errorlabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create New XML File";
            // 
            // Helpbutton
            // 
            this.Helpbutton.Location = new System.Drawing.Point(506, 180);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(75, 23);
            this.Helpbutton.TabIndex = 64;
            this.Helpbutton.Text = "Help";
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(425, 180);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 63;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Finishbutton
            // 
            this.Finishbutton.Location = new System.Drawing.Point(344, 180);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(75, 23);
            this.Finishbutton.TabIndex = 62;
            this.Finishbutton.Text = "Finish";
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.Finishbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 1);
            this.panel2.TabIndex = 61;
            // 
            // XMLTextBox
            // 
            this.XMLTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XMLTextBox.Location = new System.Drawing.Point(128, 113);
            this.XMLTextBox.Name = "XMLTextBox";
            this.XMLTextBox.Size = new System.Drawing.Size(453, 23);
            this.XMLTextBox.TabIndex = 60;
            this.XMLTextBox.TextChanged += new System.EventHandler(this.XMLTextBox_TextChanged);
            this.XMLTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XMLTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "XML File Name : ";
            // 
            // New_XMLFile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.XMLTextBox);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_XMLFile_Form";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Finishbutton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox XMLTextBox;
        private System.Windows.Forms.Label label2;
    }
}