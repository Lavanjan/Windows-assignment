﻿namespace Black_Lotus_CSharp
{
    partial class Leave
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Leave));
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuMetroTextbox_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button_addpoject = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox_ProjectName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox_ClientName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox_clientId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7_SearchClient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox3_OrgName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button_updateproject = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuMetroTextbox2_Budjet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.bunifuCustomDataGrid1;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EmployeeName,
            this.Date,
            this.Days,
            this.Reason});
            this.bunifuCustomDataGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(547, 157);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(549, 339);
            this.bunifuCustomDataGrid1.TabIndex = 34;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // bunifuMetroTextbox_search
            // 
            this.bunifuMetroTextbox_search.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_search.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_search.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_search.BorderThickness = 1;
            this.bunifuMetroTextbox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_search.isPassword = false;
            this.bunifuMetroTextbox_search.Location = new System.Drawing.Point(750, 116);
            this.bunifuMetroTextbox_search.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_search.Name = "bunifuMetroTextbox_search";
            this.bunifuMetroTextbox_search.Size = new System.Drawing.Size(233, 28);
            this.bunifuMetroTextbox_search.TabIndex = 48;
            this.bunifuMetroTextbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox_search.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox_search_OnValueChanged);
            // 
            // button_addpoject
            // 
            this.button_addpoject.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addpoject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addpoject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addpoject.Image = ((System.Drawing.Image)(resources.GetObject("button_addpoject.Image")));
            this.button_addpoject.Location = new System.Drawing.Point(445, 400);
            this.button_addpoject.Name = "button_addpoject";
            this.button_addpoject.Size = new System.Drawing.Size(84, 33);
            this.button_addpoject.TabIndex = 46;
            this.button_addpoject.TabStop = false;
            this.button_addpoject.Text = "Save";
            this.button_addpoject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addpoject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_addpoject.UseVisualStyleBackColor = false;
            this.button_addpoject.Click += new System.EventHandler(this.button_addprod_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Employee Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Employee ID ";
            // 
            // bunifuMetroTextbox_ProjectName
            // 
            this.bunifuMetroTextbox_ProjectName.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_ProjectName.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_ProjectName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_ProjectName.BorderThickness = 1;
            this.bunifuMetroTextbox_ProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_ProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_ProjectName.isPassword = false;
            this.bunifuMetroTextbox_ProjectName.Location = new System.Drawing.Point(311, 263);
            this.bunifuMetroTextbox_ProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_ProjectName.Name = "bunifuMetroTextbox_ProjectName";
            this.bunifuMetroTextbox_ProjectName.Size = new System.Drawing.Size(218, 33);
            this.bunifuMetroTextbox_ProjectName.TabIndex = 38;
            this.bunifuMetroTextbox_ProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox_ClientName
            // 
            this.bunifuMetroTextbox_ClientName.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_ClientName.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_ClientName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_ClientName.BorderThickness = 1;
            this.bunifuMetroTextbox_ClientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_ClientName.Enabled = false;
            this.bunifuMetroTextbox_ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_ClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_ClientName.isPassword = false;
            this.bunifuMetroTextbox_ClientName.Location = new System.Drawing.Point(311, 220);
            this.bunifuMetroTextbox_ClientName.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_ClientName.Name = "bunifuMetroTextbox_ClientName";
            this.bunifuMetroTextbox_ClientName.Size = new System.Drawing.Size(218, 33);
            this.bunifuMetroTextbox_ClientName.TabIndex = 37;
            this.bunifuMetroTextbox_ClientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox_clientId
            // 
            this.bunifuMetroTextbox_clientId.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_clientId.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_clientId.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_clientId.BorderThickness = 1;
            this.bunifuMetroTextbox_clientId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_clientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_clientId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_clientId.isPassword = false;
            this.bunifuMetroTextbox_clientId.Location = new System.Drawing.Point(311, 176);
            this.bunifuMetroTextbox_clientId.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_clientId.Name = "bunifuMetroTextbox_clientId";
            this.bunifuMetroTextbox_clientId.Size = new System.Drawing.Size(124, 33);
            this.bunifuMetroTextbox_clientId.TabIndex = 36;
            this.bunifuMetroTextbox_clientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox_clientId.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox_scusid_OnValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(490, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(390, 42);
            this.label3.TabIndex = 33;
            this.label3.Text = "MANAGE PROJECTS";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 500);
            this.panel2.TabIndex = 32;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(0, 192);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(163, 50);
            this.button8.TabIndex = 11;
            this.button8.Text = "Project";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(0, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 50);
            this.button7.TabIndex = 10;
            this.button7.Text = "Client";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Employees";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(977, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = " Sign Out";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(664, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Search";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 57);
            this.panel1.TabIndex = 31;
            // 
            // button7_SearchClient
            // 
            this.button7_SearchClient.BackColor = System.Drawing.Color.Gold;
            this.button7_SearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7_SearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7_SearchClient.Location = new System.Drawing.Point(451, 176);
            this.button7_SearchClient.Name = "button7_SearchClient";
            this.button7_SearchClient.Size = new System.Drawing.Size(78, 34);
            this.button7_SearchClient.TabIndex = 50;
            this.button7_SearchClient.TabStop = false;
            this.button7_SearchClient.Text = "Search";
            this.button7_SearchClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7_SearchClient.UseVisualStyleBackColor = false;
            this.button7_SearchClient.Click += new System.EventHandler(this.button7_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Days";
            // 
            // bunifuMetroTextbox3_OrgName
            // 
            this.bunifuMetroTextbox3_OrgName.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3_OrgName.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox3_OrgName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox3_OrgName.BorderThickness = 1;
            this.bunifuMetroTextbox3_OrgName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3_OrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox3_OrgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox3_OrgName.isPassword = false;
            this.bunifuMetroTextbox3_OrgName.Location = new System.Drawing.Point(311, 306);
            this.bunifuMetroTextbox3_OrgName.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox3_OrgName.Name = "bunifuMetroTextbox3_OrgName";
            this.bunifuMetroTextbox3_OrgName.Size = new System.Drawing.Size(218, 33);
            this.bunifuMetroTextbox3_OrgName.TabIndex = 54;
            this.bunifuMetroTextbox3_OrgName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button_updateproject
            // 
            this.button_updateproject.BackColor = System.Drawing.Color.Gold;
            this.button_updateproject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateproject.Image = ((System.Drawing.Image)(resources.GetObject("button_updateproject.Image")));
            this.button_updateproject.Location = new System.Drawing.Point(311, 400);
            this.button_updateproject.Name = "button_updateproject";
            this.button_updateproject.Size = new System.Drawing.Size(107, 33);
            this.button_updateproject.TabIndex = 58;
            this.button_updateproject.Text = "Update";
            this.button_updateproject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_updateproject.UseVisualStyleBackColor = false;
            this.button_updateproject.Click += new System.EventHandler(this.button_updateprod_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(216, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = " Leave ID";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 1;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Enabled = false;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(311, 132);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(218, 33);
            this.bunifuMetroTextbox1.TabIndex = 59;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(-1, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Leave";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // bunifuMetroTextbox2_Budjet
            // 
            this.bunifuMetroTextbox2_Budjet.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2_Budjet.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox2_Budjet.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2_Budjet.BorderThickness = 1;
            this.bunifuMetroTextbox2_Budjet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2_Budjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox2_Budjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox2_Budjet.isPassword = false;
            this.bunifuMetroTextbox2_Budjet.Location = new System.Drawing.Point(311, 349);
            this.bunifuMetroTextbox2_Budjet.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox2_Budjet.Name = "bunifuMetroTextbox2_Budjet";
            this.bunifuMetroTextbox2_Budjet.Size = new System.Drawing.Size(218, 33);
            this.bunifuMetroTextbox2_Budjet.TabIndex = 56;
            this.bunifuMetroTextbox2_Budjet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "Reason";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Days
            // 
            this.Days.DataPropertyName = "Days";
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 556);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.button_updateproject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bunifuMetroTextbox2_Budjet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuMetroTextbox3_OrgName);
            this.Controls.Add(this.button7_SearchClient);
            this.Controls.Add(this.bunifuMetroTextbox_search);
            this.Controls.Add(this.button_addpoject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMetroTextbox_ProjectName);
            this.Controls.Add(this.bunifuMetroTextbox_ClientName);
            this.Controls.Add(this.bunifuMetroTextbox_clientId);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_search;
        private System.Windows.Forms.Button button_addpoject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_ProjectName;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_ClientName;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_clientId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button7_SearchClient;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox3_OrgName;
        private System.Windows.Forms.Button button_updateproject;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2_Budjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}