﻿namespace WindowsFormsApp1
{
    partial class EditDepartmentForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblNeededPeople = new System.Windows.Forms.Label();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(23, 53);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(296, 40);
            this.tbxName.TabIndex = 1;
            this.tbxName.Text = "Name";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Montserrat", 16.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.Location = new System.Drawing.Point(23, 124);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(296, 175);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "Description";
            // 
            // lblNeededPeople
            // 
            this.lblNeededPeople.AutoSize = true;
            this.lblNeededPeople.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeededPeople.Location = new System.Drawing.Point(18, 324);
            this.lblNeededPeople.Name = "lblNeededPeople";
            this.lblNeededPeople.Size = new System.Drawing.Size(209, 29);
            this.lblNeededPeople.TabIndex = 3;
            this.lblNeededPeople.Text = "Needed people:";
            // 
            // numPeople
            // 
            this.numPeople.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPeople.Location = new System.Drawing.Point(218, 325);
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(101, 32);
            this.numPeople.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(23, 374);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(296, 50);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit department";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // EditDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 436);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.numPeople);
            this.Controls.Add(this.lblNeededPeople);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.tbxName);
            this.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditDepartmentForm";
            this.Text = "EditDepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label lblNeededPeople;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.Button btnEdit;
    }
}