namespace Black_Lotus_CSharp
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button6 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bunifuMetroTextbox_id = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox_name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox_color = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox_price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox_qty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_addprod = new System.Windows.Forms.Button();
            this.button_updateprod = new System.Windows.Forms.Button();
            this.bunifuMetroTextbox_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 57);
            this.panel1.TabIndex = 9;
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            this.panel2.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(0, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(163, 50);
            this.button8.TabIndex = 8;
            this.button8.Text = "Project";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(-1, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 50);
            this.button7.TabIndex = 7;
            this.button7.Text = "Client";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(0, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Employees";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(464, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 42);
            this.label3.TabIndex = 13;
            this.label3.Text = "MANAGE EMPLOYEE";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.bunifuCustomDataGrid1.TabIndex = 14;
            this.bunifuCustomDataGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomDataGrid1_MouseClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(345, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 39);
            this.button6.TabIndex = 15;
            this.button6.Text = "Remove";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // bunifuMetroTextbox_id
            // 
            this.bunifuMetroTextbox_id.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_id.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_id.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_id.BorderThickness = 1;
            this.bunifuMetroTextbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_id.isPassword = false;
            this.bunifuMetroTextbox_id.Location = new System.Drawing.Point(277, 127);
            this.bunifuMetroTextbox_id.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_id.Name = "bunifuMetroTextbox_id";
            this.bunifuMetroTextbox_id.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_id.TabIndex = 17;
            this.bunifuMetroTextbox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox_id.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox_id_OnValueChanged);
            // 
            // bunifuMetroTextbox_name
            // 
            this.bunifuMetroTextbox_name.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_name.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_name.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_name.BorderThickness = 1;
            this.bunifuMetroTextbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_name.isPassword = false;
            this.bunifuMetroTextbox_name.Location = new System.Drawing.Point(277, 177);
            this.bunifuMetroTextbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_name.Name = "bunifuMetroTextbox_name";
            this.bunifuMetroTextbox_name.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_name.TabIndex = 18;
            this.bunifuMetroTextbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox_color
            // 
            this.bunifuMetroTextbox_color.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_color.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_color.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_color.BorderThickness = 1;
            this.bunifuMetroTextbox_color.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_color.isPassword = false;
            this.bunifuMetroTextbox_color.Location = new System.Drawing.Point(277, 228);
            this.bunifuMetroTextbox_color.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_color.Name = "bunifuMetroTextbox_color";
            this.bunifuMetroTextbox_color.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_color.TabIndex = 19;
            this.bunifuMetroTextbox_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = " Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "NIC : ";
            // 
            // bunifuMetroTextbox_price
            // 
            this.bunifuMetroTextbox_price.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_price.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_price.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_price.BorderThickness = 1;
            this.bunifuMetroTextbox_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_price.isPassword = false;
            this.bunifuMetroTextbox_price.Location = new System.Drawing.Point(277, 280);
            this.bunifuMetroTextbox_price.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_price.Name = "bunifuMetroTextbox_price";
            this.bunifuMetroTextbox_price.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_price.TabIndex = 23;
            this.bunifuMetroTextbox_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "TP. No : ";
            // 
            // bunifuMetroTextbox_qty
            // 
            this.bunifuMetroTextbox_qty.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_qty.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuMetroTextbox_qty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox_qty.BorderThickness = 1;
            this.bunifuMetroTextbox_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.bunifuMetroTextbox_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox_qty.isPassword = false;
            this.bunifuMetroTextbox_qty.Location = new System.Drawing.Point(277, 331);
            this.bunifuMetroTextbox_qty.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox_qty.Name = "bunifuMetroTextbox_qty";
            this.bunifuMetroTextbox_qty.Size = new System.Drawing.Size(252, 33);
            this.bunifuMetroTextbox_qty.TabIndex = 25;
            this.bunifuMetroTextbox_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Role :";
            // 
            // button_addprod
            // 
            this.button_addprod.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addprod.Image = ((System.Drawing.Image)(resources.GetObject("button_addprod.Image")));
            this.button_addprod.Location = new System.Drawing.Point(277, 389);
            this.button_addprod.Name = "button_addprod";
            this.button_addprod.Size = new System.Drawing.Size(90, 39);
            this.button_addprod.TabIndex = 27;
            this.button_addprod.TabStop = false;
            this.button_addprod.Text = "New";
            this.button_addprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_addprod.UseVisualStyleBackColor = false;
            this.button_addprod.Click += new System.EventHandler(this.button_addprod_Click);
            // 
            // button_updateprod
            // 
            this.button_updateprod.BackColor = System.Drawing.Color.Gold;
            this.button_updateprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updateprod.Image = ((System.Drawing.Image)(resources.GetObject("button_updateprod.Image")));
            this.button_updateprod.Location = new System.Drawing.Point(428, 389);
            this.button_updateprod.Name = "button_updateprod";
            this.button_updateprod.Size = new System.Drawing.Size(101, 39);
            this.button_updateprod.TabIndex = 28;
            this.button_updateprod.Text = "Update";
            this.button_updateprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_updateprod.UseVisualStyleBackColor = false;
            this.button_updateprod.Click += new System.EventHandler(this.button_updateprod_Click);
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
            this.bunifuMetroTextbox_search.TabIndex = 29;
            this.bunifuMetroTextbox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMetroTextbox_search.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox_search_OnValueChanged);
            this.bunifuMetroTextbox_search.Enter += new System.EventHandler(this.search);
            this.bunifuMetroTextbox_search.Leave += new System.EventHandler(this.searchleave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(664, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Search";
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 7;
            this.bunifuElipse3.TargetControl = this.bunifuCustomDataGrid1;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "Leave";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 556);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuMetroTextbox_search);
            this.Controls.Add(this.button_updateprod);
            this.Controls.Add(this.button_addprod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuMetroTextbox_qty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuMetroTextbox_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMetroTextbox_color);
            this.Controls.Add(this.bunifuMetroTextbox_name);
            this.Controls.Add(this.bunifuMetroTextbox_id);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_id;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_color;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_name;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_qty;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addprod;
        private System.Windows.Forms.Button button_updateprod;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox_search;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
    }
}