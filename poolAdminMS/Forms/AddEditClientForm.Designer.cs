﻿namespace poolAdminMS.Forms
{
    partial class AddEditClientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.secondNameLable = new System.Windows.Forms.Label();
            this.phoneLable = new System.Windows.Forms.Label();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.womanRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 43);
            this.panel1.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.MintCream;
            this.okButton.Location = new System.Drawing.Point(3, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(165, 37);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Сохранить";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.MintCream;
            this.cancelButton.Location = new System.Drawing.Point(173, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(165, 37);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.Location = new System.Drawing.Point(124, 7);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(214, 21);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(124, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(214, 21);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameLable
            // 
            this.surnameLable.AutoSize = true;
            this.surnameLable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLable.ForeColor = System.Drawing.Color.MintCream;
            this.surnameLable.Location = new System.Drawing.Point(12, 9);
            this.surnameLable.Name = "surnameLable";
            this.surnameLable.Size = new System.Drawing.Size(68, 17);
            this.surnameLable.TabIndex = 5;
            this.surnameLable.Text = "Фамилия";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.ForeColor = System.Drawing.Color.MintCream;
            this.nameLable.Location = new System.Drawing.Point(12, 36);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(35, 17);
            this.nameLable.TabIndex = 6;
            this.nameLable.Text = "Имя";
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondNameTextBox.Location = new System.Drawing.Point(124, 61);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(214, 21);
            this.secondNameTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(124, 88);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(214, 21);
            this.phoneTextBox.TabIndex = 8;
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNameLable.ForeColor = System.Drawing.Color.MintCream;
            this.secondNameLable.Location = new System.Drawing.Point(12, 63);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(66, 17);
            this.secondNameLable.TabIndex = 9;
            this.secondNameLable.Text = "Отчество";
            // 
            // phoneLable
            // 
            this.phoneLable.AutoSize = true;
            this.phoneLable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLable.ForeColor = System.Drawing.Color.MintCream;
            this.phoneLable.Location = new System.Drawing.Point(12, 90);
            this.phoneLable.Name = "phoneLable";
            this.phoneLable.Size = new System.Drawing.Size(67, 17);
            this.phoneLable.TabIndex = 10;
            this.phoneLable.Text = "Телефон";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.womanRadioButton);
            this.genderGroupBox.Controls.Add(this.manRadioButton);
            this.genderGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupBox.ForeColor = System.Drawing.Color.MintCream;
            this.genderGroupBox.Location = new System.Drawing.Point(124, 118);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(214, 74);
            this.genderGroupBox.TabIndex = 11;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Пол";
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Checked = true;
            this.manRadioButton.Location = new System.Drawing.Point(20, 22);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(37, 21);
            this.manRadioButton.TabIndex = 0;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "М";
            this.manRadioButton.UseVisualStyleBackColor = true;
            // 
            // womanRadioButton
            // 
            this.womanRadioButton.AutoSize = true;
            this.womanRadioButton.Location = new System.Drawing.Point(20, 47);
            this.womanRadioButton.Name = "womanRadioButton";
            this.womanRadioButton.Size = new System.Drawing.Size(38, 21);
            this.womanRadioButton.TabIndex = 1;
            this.womanRadioButton.TabStop = true;
            this.womanRadioButton.Text = "Ж";
            this.womanRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddEditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.phoneLable);
            this.Controls.Add(this.secondNameLable);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.secondNameTextBox);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.surnameLable);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEditClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label surnameLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.Label phoneLable;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton womanRadioButton;
        private System.Windows.Forms.RadioButton manRadioButton;
    }
}