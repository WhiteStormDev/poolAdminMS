﻿namespace poolAdminMS.UserControls
{
    partial class ClientsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.clientsDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonementGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteAbonButton = new System.Windows.Forms.Button();
            this.fioLable = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.addAbonementButton = new System.Windows.Forms.Button();
            this.dateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.trainingGroupLable = new System.Windows.Forms.Label();
            this.trainingGroupsComboBox = new System.Windows.Forms.ComboBox();
            this.dateLable = new System.Windows.Forms.Label();
            this.checkVisitButton = new System.Windows.Forms.Button();
            this.visitCountTextBox = new System.Windows.Forms.TextBox();
            this.visitCountLable = new System.Windows.Forms.Label();
            this.serviceTypeLable = new System.Windows.Forms.Label();
            this.visitTypeLable = new System.Windows.Forms.Label();
            this.serviceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.visitTypeСomboBox = new System.Windows.Forms.ComboBox();
            this.abonementNumLable = new System.Windows.Forms.Label();
            this.abonementsIdComboBox = new System.Windows.Forms.ComboBox();
            this.saveAbonButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editClientButton = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            this.addClientButton = new System.Windows.Forms.Button();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByAbonementIdButton = new System.Windows.Forms.Button();
            this.searchBySurnameButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).BeginInit();
            this.abonementGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientsDataGrid
            // 
            this.clientsDataGrid.AllowUserToAddRows = false;
            this.clientsDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.clientsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientsDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.clientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.surname,
            this.name,
            this.secondname,
            this.phone,
            this.gender});
            this.clientsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.clientsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.clientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGrid.Size = new System.Drawing.Size(622, 528);
            this.clientsDataGrid.TabIndex = 0;
            this.clientsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientsDataGrid_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // secondname
            // 
            this.secondname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secondname.HeaderText = "Отчество";
            this.secondname.Name = "secondname";
            this.secondname.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.HeaderText = "Пол";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // abonementGroupBox
            // 
            this.abonementGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abonementGroupBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.abonementGroupBox.Controls.Add(this.deleteAbonButton);
            this.abonementGroupBox.Controls.Add(this.fioLable);
            this.abonementGroupBox.Controls.Add(this.editButton);
            this.abonementGroupBox.Controls.Add(this.addAbonementButton);
            this.abonementGroupBox.Controls.Add(this.dateEndPicker);
            this.abonementGroupBox.Controls.Add(this.trainingGroupLable);
            this.abonementGroupBox.Controls.Add(this.trainingGroupsComboBox);
            this.abonementGroupBox.Controls.Add(this.dateLable);
            this.abonementGroupBox.Controls.Add(this.checkVisitButton);
            this.abonementGroupBox.Controls.Add(this.visitCountTextBox);
            this.abonementGroupBox.Controls.Add(this.visitCountLable);
            this.abonementGroupBox.Controls.Add(this.serviceTypeLable);
            this.abonementGroupBox.Controls.Add(this.visitTypeLable);
            this.abonementGroupBox.Controls.Add(this.serviceTypeComboBox);
            this.abonementGroupBox.Controls.Add(this.visitTypeСomboBox);
            this.abonementGroupBox.Controls.Add(this.abonementNumLable);
            this.abonementGroupBox.Controls.Add(this.abonementsIdComboBox);
            this.abonementGroupBox.Controls.Add(this.saveAbonButton);
            this.abonementGroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abonementGroupBox.Location = new System.Drawing.Point(628, 3);
            this.abonementGroupBox.Name = "abonementGroupBox";
            this.abonementGroupBox.Size = new System.Drawing.Size(321, 528);
            this.abonementGroupBox.TabIndex = 1;
            this.abonementGroupBox.TabStop = false;
            this.abonementGroupBox.Text = "Абонемент";
            // 
            // deleteAbonButton
            // 
            this.deleteAbonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAbonButton.Location = new System.Drawing.Point(3, 422);
            this.deleteAbonButton.Name = "deleteAbonButton";
            this.deleteAbonButton.Size = new System.Drawing.Size(316, 30);
            this.deleteAbonButton.TabIndex = 18;
            this.deleteAbonButton.Text = "Удалить";
            this.deleteAbonButton.UseVisualStyleBackColor = true;
            this.deleteAbonButton.Click += new System.EventHandler(this.deleteAbonButton_Click);
            // 
            // fioLable
            // 
            this.fioLable.AutoSize = true;
            this.fioLable.Location = new System.Drawing.Point(6, 28);
            this.fioLable.Name = "fioLable";
            this.fioLable.Size = new System.Drawing.Size(40, 17);
            this.fioLable.TabIndex = 17;
            this.fioLable.Text = "ФИО";
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(3, 385);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(316, 30);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addAbonementButton
            // 
            this.addAbonementButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAbonementButton.Location = new System.Drawing.Point(3, 458);
            this.addAbonementButton.Name = "addAbonementButton";
            this.addAbonementButton.Size = new System.Drawing.Size(316, 30);
            this.addAbonementButton.TabIndex = 1;
            this.addAbonementButton.Text = "Добавить";
            this.addAbonementButton.UseVisualStyleBackColor = true;
            this.addAbonementButton.Click += new System.EventHandler(this.addAbonementButton_Click);
            // 
            // dateEndPicker
            // 
            this.dateEndPicker.Enabled = false;
            this.dateEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEndPicker.Location = new System.Drawing.Point(113, 299);
            this.dateEndPicker.Name = "dateEndPicker";
            this.dateEndPicker.Size = new System.Drawing.Size(200, 23);
            this.dateEndPicker.TabIndex = 15;
            // 
            // trainingGroupLable
            // 
            this.trainingGroupLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingGroupLable.AutoSize = true;
            this.trainingGroupLable.Location = new System.Drawing.Point(6, 162);
            this.trainingGroupLable.Name = "trainingGroupLable";
            this.trainingGroupLable.Size = new System.Drawing.Size(157, 17);
            this.trainingGroupLable.TabIndex = 14;
            this.trainingGroupLable.Text = "Тренировочная группа";
            // 
            // trainingGroupsComboBox
            // 
            this.trainingGroupsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingGroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trainingGroupsComboBox.Location = new System.Drawing.Point(154, 159);
            this.trainingGroupsComboBox.Name = "trainingGroupsComboBox";
            this.trainingGroupsComboBox.Size = new System.Drawing.Size(159, 25);
            this.trainingGroupsComboBox.TabIndex = 13;
            // 
            // dateLable
            // 
            this.dateLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLable.AutoSize = true;
            this.dateLable.Location = new System.Drawing.Point(6, 273);
            this.dateLable.Name = "dateLable";
            this.dateLable.Size = new System.Drawing.Size(176, 17);
            this.dateLable.TabIndex = 11;
            this.dateLable.Text = "Дата окончания действия";
            // 
            // checkVisitButton
            // 
            this.checkVisitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkVisitButton.Location = new System.Drawing.Point(3, 349);
            this.checkVisitButton.Name = "checkVisitButton";
            this.checkVisitButton.Size = new System.Drawing.Size(316, 30);
            this.checkVisitButton.TabIndex = 10;
            this.checkVisitButton.Text = "Отметить посещение";
            this.checkVisitButton.UseVisualStyleBackColor = true;
            this.checkVisitButton.Click += new System.EventHandler(this.checkVisitButton_Click);
            // 
            // visitCountTextBox
            // 
            this.visitCountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitCountTextBox.Enabled = false;
            this.visitCountTextBox.Location = new System.Drawing.Point(247, 234);
            this.visitCountTextBox.Name = "visitCountTextBox";
            this.visitCountTextBox.Size = new System.Drawing.Size(66, 23);
            this.visitCountTextBox.TabIndex = 9;
            this.visitCountTextBox.TextChanged += new System.EventHandler(this.visitCountTextBox_TextChanged);
            // 
            // visitCountLable
            // 
            this.visitCountLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitCountLable.AutoSize = true;
            this.visitCountLable.Location = new System.Drawing.Point(6, 240);
            this.visitCountLable.Name = "visitCountLable";
            this.visitCountLable.Size = new System.Drawing.Size(245, 17);
            this.visitCountLable.TabIndex = 8;
            this.visitCountLable.Text = "Количество оставшихся посещений";
            // 
            // serviceTypeLable
            // 
            this.serviceTypeLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceTypeLable.AutoSize = true;
            this.serviceTypeLable.Location = new System.Drawing.Point(6, 131);
            this.serviceTypeLable.Name = "serviceTypeLable";
            this.serviceTypeLable.Size = new System.Drawing.Size(126, 17);
            this.serviceTypeLable.TabIndex = 7;
            this.serviceTypeLable.Text = "Тип обслуживания";
            // 
            // visitTypeLable
            // 
            this.visitTypeLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitTypeLable.AutoSize = true;
            this.visitTypeLable.Location = new System.Drawing.Point(6, 99);
            this.visitTypeLable.Name = "visitTypeLable";
            this.visitTypeLable.Size = new System.Drawing.Size(109, 17);
            this.visitTypeLable.TabIndex = 6;
            this.visitTypeLable.Text = "Тип посещения";
            // 
            // serviceTypeComboBox
            // 
            this.serviceTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceTypeComboBox.Location = new System.Drawing.Point(154, 128);
            this.serviceTypeComboBox.Name = "serviceTypeComboBox";
            this.serviceTypeComboBox.Size = new System.Drawing.Size(159, 25);
            this.serviceTypeComboBox.TabIndex = 5;
            // 
            // visitTypeСomboBox
            // 
            this.visitTypeСomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitTypeСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visitTypeСomboBox.Location = new System.Drawing.Point(154, 96);
            this.visitTypeСomboBox.Name = "visitTypeСomboBox";
            this.visitTypeСomboBox.Size = new System.Drawing.Size(159, 25);
            this.visitTypeСomboBox.TabIndex = 4;
            // 
            // abonementNumLable
            // 
            this.abonementNumLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abonementNumLable.AutoSize = true;
            this.abonementNumLable.Location = new System.Drawing.Point(6, 68);
            this.abonementNumLable.Name = "abonementNumLable";
            this.abonementNumLable.Size = new System.Drawing.Size(142, 17);
            this.abonementNumLable.TabIndex = 3;
            this.abonementNumLable.Text = "Номер Абонемента";
            // 
            // abonementsIdComboBox
            // 
            this.abonementsIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abonementsIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abonementsIdComboBox.Location = new System.Drawing.Point(154, 65);
            this.abonementsIdComboBox.Name = "abonementsIdComboBox";
            this.abonementsIdComboBox.Size = new System.Drawing.Size(159, 25);
            this.abonementsIdComboBox.TabIndex = 2;
            this.abonementsIdComboBox.SelectedIndexChanged += new System.EventHandler(this.abonementsIdComboBox_SelectedIndexChanged);
            // 
            // saveAbonButton
            // 
            this.saveAbonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveAbonButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAbonButton.Location = new System.Drawing.Point(3, 495);
            this.saveAbonButton.Name = "saveAbonButton";
            this.saveAbonButton.Size = new System.Drawing.Size(316, 30);
            this.saveAbonButton.TabIndex = 0;
            this.saveAbonButton.Text = "Сохранить";
            this.saveAbonButton.UseVisualStyleBackColor = true;
            this.saveAbonButton.Click += new System.EventHandler(this.saveAbonButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.editClientButton);
            this.panel1.Controls.Add(this.deleteClientButton);
            this.panel1.Controls.Add(this.addClientButton);
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.searchByAbonementIdButton);
            this.panel1.Controls.Add(this.searchBySurnameButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 41);
            this.panel1.TabIndex = 2;
            // 
            // editClientButton
            // 
            this.editClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editClientButton.FlatAppearance.BorderSize = 0;
            this.editClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClientButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientButton.ForeColor = System.Drawing.Color.MintCream;
            this.editClientButton.Location = new System.Drawing.Point(228, -1);
            this.editClientButton.Name = "editClientButton";
            this.editClientButton.Size = new System.Drawing.Size(115, 41);
            this.editClientButton.TabIndex = 22;
            this.editClientButton.Text = "Редактировать";
            this.editClientButton.UseVisualStyleBackColor = true;
            this.editClientButton.Click += new System.EventHandler(this.editClientButton_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteClientButton.FlatAppearance.BorderSize = 0;
            this.deleteClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteClientButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClientButton.ForeColor = System.Drawing.Color.MintCream;
            this.deleteClientButton.Location = new System.Drawing.Point(114, -2);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(108, 41);
            this.deleteClientButton.TabIndex = 21;
            this.deleteClientButton.Text = "Удалить";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // addClientButton
            // 
            this.addClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientButton.FlatAppearance.BorderSize = 0;
            this.addClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientButton.ForeColor = System.Drawing.Color.MintCream;
            this.addClientButton.Location = new System.Drawing.Point(0, -2);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(108, 41);
            this.addClientButton.TabIndex = 20;
            this.addClientButton.Text = "Добавить";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click_1);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFilterButton.FlatAppearance.BorderSize = 0;
            this.clearFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilterButton.ForeColor = System.Drawing.Color.MintCream;
            this.clearFilterButton.Location = new System.Drawing.Point(349, -1);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(108, 41);
            this.clearFilterButton.TabIndex = 19;
            this.clearFilterButton.Text = "Сбросить";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(463, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(162, 21);
            this.searchTextBox.TabIndex = 2;
            this.searchTextBox.Tag = "";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            // 
            // searchByAbonementIdButton
            // 
            this.searchByAbonementIdButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByAbonementIdButton.FlatAppearance.BorderSize = 0;
            this.searchByAbonementIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByAbonementIdButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByAbonementIdButton.ForeColor = System.Drawing.Color.MintCream;
            this.searchByAbonementIdButton.Location = new System.Drawing.Point(758, -1);
            this.searchByAbonementIdButton.Name = "searchByAbonementIdButton";
            this.searchByAbonementIdButton.Size = new System.Drawing.Size(196, 41);
            this.searchByAbonementIdButton.TabIndex = 18;
            this.searchByAbonementIdButton.Text = "Искать по номеру абонемента";
            this.searchByAbonementIdButton.UseVisualStyleBackColor = true;
            this.searchByAbonementIdButton.Click += new System.EventHandler(this.searchByAbonementIdButton_Click);
            // 
            // searchBySurnameButton
            // 
            this.searchBySurnameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBySurnameButton.FlatAppearance.BorderSize = 0;
            this.searchBySurnameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBySurnameButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBySurnameButton.ForeColor = System.Drawing.Color.MintCream;
            this.searchBySurnameButton.Location = new System.Drawing.Point(628, 0);
            this.searchBySurnameButton.Name = "searchBySurnameButton";
            this.searchBySurnameButton.Size = new System.Drawing.Size(135, 38);
            this.searchBySurnameButton.TabIndex = 17;
            this.searchBySurnameButton.Text = "Искать по фамилии";
            this.searchBySurnameButton.UseVisualStyleBackColor = true;
            this.searchBySurnameButton.Click += new System.EventHandler(this.searchBySurnameButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clientsDataGrid);
            this.panel2.Controls.Add(this.abonementGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 537);
            this.panel2.TabIndex = 3;
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(954, 574);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).EndInit();
            this.abonementGroupBox.ResumeLayout(false);
            this.abonementGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsDataGrid;
        private System.Windows.Forms.GroupBox abonementGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button saveAbonButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button addAbonementButton;
        private System.Windows.Forms.Label abonementNumLable;
        private System.Windows.Forms.ComboBox abonementsIdComboBox;
        private System.Windows.Forms.ComboBox serviceTypeComboBox;
        private System.Windows.Forms.ComboBox visitTypeСomboBox;
        private System.Windows.Forms.Label serviceTypeLable;
        private System.Windows.Forms.Label visitTypeLable;
        private System.Windows.Forms.Label visitCountLable;
        private System.Windows.Forms.TextBox visitCountTextBox;
        private System.Windows.Forms.Button checkVisitButton;
        private System.Windows.Forms.Label dateLable;
        private System.Windows.Forms.Label trainingGroupLable;
        private System.Windows.Forms.ComboBox trainingGroupsComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DateTimePicker dateEndPicker;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button searchByAbonementIdButton;
        private System.Windows.Forms.Button searchBySurnameButton;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Label fioLable;
        private System.Windows.Forms.Button editClientButton;
        private System.Windows.Forms.Button deleteClientButton;
        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.Button deleteAbonButton;
    }
}
