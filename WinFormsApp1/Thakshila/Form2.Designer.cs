
namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageClear = new System.Windows.Forms.Button();
            this.lblGroupNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubIdDelete = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnManageUpdate = new System.Windows.Forms.Button();
            this.btnManageDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSubId = new System.Windows.Forms.TextBox();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.numericsub = new System.Windows.Forms.NumericUpDown();
            this.numericgroup = new System.Windows.Forms.NumericUpDown();
            this.comboProgramme = new System.Windows.Forms.ComboBox();
            this.txtacademic = new System.Windows.Forms.TextBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.lblAcademic = new System.Windows.Forms.Label();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericgroup)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidePanel.Location = new System.Drawing.Point(-32, 68);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(13, 46);
            this.sidePanel.TabIndex = 10;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidePanel_Paint);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 446);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 46);
            this.button7.TabIndex = 20;
            this.button7.Text = "Rooms";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 368);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 46);
            this.button6.TabIndex = 19;
            this.button6.Text = "Location";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 46);
            this.button5.TabIndex = 18;
            this.button5.Text = "Tags";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 46);
            this.button4.TabIndex = 17;
            this.button4.Text = "Subjects";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(6, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 46);
            this.button3.TabIndex = 16;
            this.button3.Text = "Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 46);
            this.button2.TabIndex = 15;
            this.button2.Text = "Lectures";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Working Days and Hours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(-3, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time Table Maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-3, 576);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(176, 46);
            this.button9.TabIndex = 21;
            this.button9.Text = "Statistics";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(19, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(284, 46);
            this.button8.TabIndex = 7;
            this.button8.Text = "Sessions and Avialbility";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Honeydew;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(0, 94);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(279, 46);
            this.button12.TabIndex = 9;
            this.button12.Text = "Availability";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Honeydew;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(0, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(279, 46);
            this.button11.TabIndex = 8;
            this.button11.Text = "Sessions ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(5, 651);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(253, 46);
            this.button10.TabIndex = 22;
            this.button10.Text = "Generate Time Table";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Location = new System.Drawing.Point(-19, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 46);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnManageClear
            // 
            this.btnManageClear.BackColor = System.Drawing.Color.MintCream;
            this.btnManageClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageClear.Location = new System.Drawing.Point(789, 642);
            this.btnManageClear.Name = "btnManageClear";
            this.btnManageClear.Size = new System.Drawing.Size(132, 38);
            this.btnManageClear.TabIndex = 18;
            this.btnManageClear.Text = "CLEAR";
            this.btnManageClear.UseVisualStyleBackColor = false;
            this.btnManageClear.Click += new System.EventHandler(this.btnManageClear_Click);
            // 
            // lblGroupNum
            // 
            this.lblGroupNum.AutoSize = true;
            this.lblGroupNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroupNum.Location = new System.Drawing.Point(49, 514);
            this.lblGroupNum.Name = "lblGroupNum";
            this.lblGroupNum.Size = new System.Drawing.Size(141, 21);
            this.lblGroupNum.TabIndex = 5;
            this.lblGroupNum.Text = "Group Number";
            this.lblGroupNum.Click += new System.EventHandler(this.lblGroupNum_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSubIdDelete);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btnManageUpdate);
            this.panel1.Controls.Add(this.btnManageDelete);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnManageClear);
            this.panel1.Controls.Add(this.txtSubId);
            this.panel1.Controls.Add(this.txtGroupId);
            this.panel1.Controls.Add(this.lblSub);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.numericsub);
            this.panel1.Controls.Add(this.numericgroup);
            this.panel1.Controls.Add(this.comboProgramme);
            this.panel1.Controls.Add(this.txtacademic);
            this.panel1.Controls.Add(this.lblSubGroup);
            this.panel1.Controls.Add(this.lblGroupNum);
            this.panel1.Controls.Add(this.lblProgramme);
            this.panel1.Controls.Add(this.lblAcademic);
            this.panel1.Controls.Add(this.btnManageStudent);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(280, 12);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.panel1.Size = new System.Drawing.Size(948, 695);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSubIdDelete
            // 
            this.btnSubIdDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSubIdDelete.Image")));
            this.btnSubIdDelete.Location = new System.Drawing.Point(877, 516);
            this.btnSubIdDelete.Name = "btnSubIdDelete";
            this.btnSubIdDelete.Size = new System.Drawing.Size(44, 27);
            this.btnSubIdDelete.TabIndex = 23;
            this.btnSubIdDelete.UseVisualStyleBackColor = true;
            this.btnSubIdDelete.Click += new System.EventHandler(this.btnSubIdDelete_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(591, 129);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(310, 218);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnManageUpdate
            // 
            this.btnManageUpdate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnManageUpdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageUpdate.Location = new System.Drawing.Point(383, 642);
            this.btnManageUpdate.Name = "btnManageUpdate";
            this.btnManageUpdate.Size = new System.Drawing.Size(132, 38);
            this.btnManageUpdate.TabIndex = 21;
            this.btnManageUpdate.Text = "UPDATE";
            this.btnManageUpdate.UseVisualStyleBackColor = false;
            this.btnManageUpdate.Click += new System.EventHandler(this.btnManageUpdate_Click);
            // 
            // btnManageDelete
            // 
            this.btnManageDelete.BackColor = System.Drawing.Color.Red;
            this.btnManageDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageDelete.Location = new System.Drawing.Point(591, 642);
            this.btnManageDelete.Name = "btnManageDelete";
            this.btnManageDelete.Size = new System.Drawing.Size(132, 38);
            this.btnManageDelete.TabIndex = 20;
            this.btnManageDelete.Text = "DELETE";
            this.btnManageDelete.UseVisualStyleBackColor = false;
            this.btnManageDelete.Click += new System.EventHandler(this.btnManageDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(547, 218);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSubId
            // 
            this.txtSubId.Location = new System.Drawing.Point(743, 465);
            this.txtSubId.Name = "txtSubId";
            this.txtSubId.Size = new System.Drawing.Size(181, 27);
            this.txtSubId.TabIndex = 17;
            this.txtSubId.TextChanged += new System.EventHandler(this.txtSubId_TextChanged);
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(743, 407);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(181, 27);
            this.txtGroupId.TabIndex = 16;
            this.txtGroupId.TextChanged += new System.EventHandler(this.txtGroupId_TextChanged);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(582, 464);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(128, 21);
            this.lblSub.TabIndex = 15;
            this.lblSub.Text = "Sub Group ID";
            this.lblSub.Click += new System.EventHandler(this.lblSub_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroup.Location = new System.Drawing.Point(582, 409);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(89, 21);
            this.lblGroup.TabIndex = 14;
            this.lblGroup.Text = "Group ID";
            this.lblGroup.Click += new System.EventHandler(this.lblGroup_Click);
            // 
            // numericsub
            // 
            this.numericsub.Location = new System.Drawing.Point(324, 573);
            this.numericsub.Name = "numericsub";
            this.numericsub.Size = new System.Drawing.Size(181, 27);
            this.numericsub.TabIndex = 10;
            this.numericsub.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericgroup
            // 
            this.numericgroup.Location = new System.Drawing.Point(324, 516);
            this.numericgroup.Name = "numericgroup";
            this.numericgroup.Size = new System.Drawing.Size(181, 27);
            this.numericgroup.TabIndex = 9;
            this.numericgroup.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboProgramme
            // 
            this.comboProgramme.FormattingEnabled = true;
            this.comboProgramme.Items.AddRange(new object[] {
            "Information Technology",
            "Software Engineering",
            "Data Science",
            "Interactive Media",
            "Information System Engineering",
            "Curtin ( SE )"});
            this.comboProgramme.Location = new System.Drawing.Point(324, 461);
            this.comboProgramme.Name = "comboProgramme";
            this.comboProgramme.Size = new System.Drawing.Size(181, 28);
            this.comboProgramme.TabIndex = 8;
            this.comboProgramme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtacademic
            // 
            this.txtacademic.Location = new System.Drawing.Point(324, 410);
            this.txtacademic.Name = "txtacademic";
            this.txtacademic.Size = new System.Drawing.Size(181, 27);
            this.txtacademic.TabIndex = 7;
            this.txtacademic.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubGroup.Location = new System.Drawing.Point(49, 572);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(180, 21);
            this.lblSubGroup.TabIndex = 6;
            this.lblSubGroup.Text = "Sub Group Number";
            this.lblSubGroup.Click += new System.EventHandler(this.lblSubGroup_Click);
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgramme.Location = new System.Drawing.Point(49, 464);
            this.lblProgramme.Name = "lblProgramme";
            this.lblProgramme.Size = new System.Drawing.Size(114, 21);
            this.lblProgramme.TabIndex = 4;
            this.lblProgramme.Text = "Programme";
            this.lblProgramme.Click += new System.EventHandler(this.lblProgramme_Click);
            // 
            // lblAcademic
            // 
            this.lblAcademic.AutoSize = true;
            this.lblAcademic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcademic.Location = new System.Drawing.Point(49, 409);
            this.lblAcademic.Name = "lblAcademic";
            this.lblAcademic.Size = new System.Drawing.Size(235, 21);
            this.lblAcademic.TabIndex = 3;
            this.lblAcademic.Text = "Academic Year Semester";
            this.lblAcademic.Click += new System.EventHandler(this.lblAcademic_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnManageStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageStudent.Location = new System.Drawing.Point(528, 54);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(291, 43);
            this.btnManageStudent.TabIndex = 2;
            this.btnManageStudent.Text = "MANAGE STUDENT GROUPS";
            this.btnManageStudent.UseVisualStyleBackColor = false;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.Location = new System.Drawing.Point(152, 54);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(291, 43);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "ADD STUDENT GROUPS";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(423, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "STUDENT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1251, 737);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericsub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericgroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageClear;
        private System.Windows.Forms.Label lblGroupNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubId;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericgroup;
        private System.Windows.Forms.ComboBox comboProgramme;
        private System.Windows.Forms.TextBox txtacademic;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.Label lblAcademic;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManageUpdate;
        private System.Windows.Forms.Button btnManageDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericsub;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSubIdDelete;
    }
}