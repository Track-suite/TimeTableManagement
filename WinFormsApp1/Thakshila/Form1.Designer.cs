
namespace WinFormsApp1.Thakshila
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboacademic = new System.Windows.Forms.ComboBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtSubId = new System.Windows.Forms.TextBox();
            this.txtGroupId = new System.Windows.Forms.TextBox();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.btnGenerateID = new System.Windows.Forms.Button();
            this.btnStudentClear = new System.Windows.Forms.Button();
            this.btnStudentSave = new System.Windows.Forms.Button();
            this.numericsub = new System.Windows.Forms.NumericUpDown();
            this.numericgroup = new System.Windows.Forms.NumericUpDown();
            this.comboProgramme = new System.Windows.Forms.ComboBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.lblGroupNum = new System.Windows.Forms.Label();
            this.lblProgramme = new System.Windows.Forms.Label();
            this.lblAcademic = new System.Windows.Forms.Label();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericgroup)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboacademic);
            this.panel1.Controls.Add(this.btnFinish);
            this.panel1.Controls.Add(this.txtSubId);
            this.panel1.Controls.Add(this.txtGroupId);
            this.panel1.Controls.Add(this.lblSub);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.btnGenerateID);
            this.panel1.Controls.Add(this.btnStudentClear);
            this.panel1.Controls.Add(this.btnStudentSave);
            this.panel1.Controls.Add(this.numericsub);
            this.panel1.Controls.Add(this.numericgroup);
            this.panel1.Controls.Add(this.comboProgramme);
            this.panel1.Controls.Add(this.lblSubGroup);
            this.panel1.Controls.Add(this.lblGroupNum);
            this.panel1.Controls.Add(this.lblProgramme);
            this.panel1.Controls.Add(this.lblAcademic);
            this.panel1.Controls.Add(this.btnManageStudent);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(295, 26);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.panel1.Size = new System.Drawing.Size(971, 725);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboacademic
            // 
            this.comboacademic.FormattingEnabled = true;
            this.comboacademic.Items.AddRange(new object[] {
            "Y1.S1",
            "Y1.S2",
            "Y2.S1",
            "Y2.S2",
            "Y3.S1",
            "Y3.S2",
            "Y4.S1",
            "Y4.S2"});
            this.comboacademic.Location = new System.Drawing.Point(408, 155);
            this.comboacademic.Name = "comboacademic";
            this.comboacademic.Size = new System.Drawing.Size(181, 28);
            this.comboacademic.TabIndex = 19;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnFinish.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinish.Location = new System.Drawing.Point(789, 642);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(132, 38);
            this.btnFinish.TabIndex = 18;
            this.btnFinish.Text = "FINISH";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtSubId
            // 
            this.txtSubId.Location = new System.Drawing.Point(408, 619);
            this.txtSubId.Name = "txtSubId";
            this.txtSubId.Size = new System.Drawing.Size(181, 27);
            this.txtSubId.TabIndex = 17;
            this.txtSubId.TextChanged += new System.EventHandler(this.txtSubId_TextChanged);
            // 
            // txtGroupId
            // 
            this.txtGroupId.Location = new System.Drawing.Point(408, 548);
            this.txtGroupId.Name = "txtGroupId";
            this.txtGroupId.Size = new System.Drawing.Size(181, 27);
            this.txtGroupId.TabIndex = 16;
            this.txtGroupId.TextChanged += new System.EventHandler(this.txtGroupId_TextChanged);
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSub.Location = new System.Drawing.Point(83, 618);
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
            this.lblGroup.Location = new System.Drawing.Point(83, 550);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(89, 21);
            this.lblGroup.TabIndex = 14;
            this.lblGroup.Text = "Group ID";
            this.lblGroup.Click += new System.EventHandler(this.lblGroup_Click);
            // 
            // btnGenerateID
            // 
            this.btnGenerateID.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGenerateID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateID.Location = new System.Drawing.Point(83, 467);
            this.btnGenerateID.Name = "btnGenerateID";
            this.btnGenerateID.Size = new System.Drawing.Size(506, 42);
            this.btnGenerateID.TabIndex = 13;
            this.btnGenerateID.Text = "Generate ID\'s";
            this.btnGenerateID.UseVisualStyleBackColor = false;
            this.btnGenerateID.Click += new System.EventHandler(this.btnGenerateID_Click);
            // 
            // btnStudentClear
            // 
            this.btnStudentClear.BackColor = System.Drawing.Color.MintCream;
            this.btnStudentClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudentClear.Location = new System.Drawing.Point(431, 408);
            this.btnStudentClear.Name = "btnStudentClear";
            this.btnStudentClear.Size = new System.Drawing.Size(158, 38);
            this.btnStudentClear.TabIndex = 12;
            this.btnStudentClear.Text = "CLEAR";
            this.btnStudentClear.UseVisualStyleBackColor = false;
            this.btnStudentClear.Click += new System.EventHandler(this.btnStudentClear_Click);
            // 
            // btnStudentSave
            // 
            this.btnStudentSave.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnStudentSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStudentSave.Location = new System.Drawing.Point(244, 408);
            this.btnStudentSave.Name = "btnStudentSave";
            this.btnStudentSave.Size = new System.Drawing.Size(154, 38);
            this.btnStudentSave.TabIndex = 11;
            this.btnStudentSave.Text = "SAVE";
            this.btnStudentSave.UseVisualStyleBackColor = false;
            this.btnStudentSave.Click += new System.EventHandler(this.btnStudentSave_Click);
            // 
            // numericsub
            // 
            this.numericsub.Location = new System.Drawing.Point(408, 324);
            this.numericsub.Name = "numericsub";
            this.numericsub.Size = new System.Drawing.Size(181, 27);
            this.numericsub.TabIndex = 10;
            this.numericsub.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericgroup
            // 
            this.numericgroup.Location = new System.Drawing.Point(408, 269);
            this.numericgroup.Name = "numericgroup";
            this.numericgroup.Size = new System.Drawing.Size(181, 27);
            this.numericgroup.TabIndex = 9;
            this.numericgroup.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboProgramme
            // 
            this.comboProgramme.FormattingEnabled = true;
            this.comboProgramme.Items.AddRange(new object[] {
            "IT",
            "SE",
            "CSSE",
            "IM",
            "CSE",
            "DS"});
            this.comboProgramme.Location = new System.Drawing.Point(408, 213);
            this.comboProgramme.Name = "comboProgramme";
            this.comboProgramme.Size = new System.Drawing.Size(181, 28);
            this.comboProgramme.TabIndex = 8;
            this.comboProgramme.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSubGroup
            // 
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubGroup.Location = new System.Drawing.Point(83, 322);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(180, 21);
            this.lblSubGroup.TabIndex = 6;
            this.lblSubGroup.Text = "Sub Group Number";
            this.lblSubGroup.Click += new System.EventHandler(this.lblSubGroup_Click);
            // 
            // lblGroupNum
            // 
            this.lblGroupNum.AutoSize = true;
            this.lblGroupNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroupNum.Location = new System.Drawing.Point(83, 271);
            this.lblGroupNum.Name = "lblGroupNum";
            this.lblGroupNum.Size = new System.Drawing.Size(141, 21);
            this.lblGroupNum.TabIndex = 5;
            this.lblGroupNum.Text = "Group Number";
            this.lblGroupNum.Click += new System.EventHandler(this.lblGroupNum_Click);
            // 
            // lblProgramme
            // 
            this.lblProgramme.AutoSize = true;
            this.lblProgramme.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgramme.Location = new System.Drawing.Point(83, 216);
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
            this.lblAcademic.Location = new System.Drawing.Point(83, 155);
            this.lblAcademic.Name = "lblAcademic";
            this.lblAcademic.Size = new System.Drawing.Size(235, 21);
            this.lblAcademic.TabIndex = 3;
            this.lblAcademic.Text = "Academic Year Semester";
            this.lblAcademic.Click += new System.EventHandler(this.lblAcademic_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnManageStudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageStudent.Location = new System.Drawing.Point(497, 54);
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
            this.btnAddStudent.Location = new System.Drawing.Point(83, 54);
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
            this.label2.Location = new System.Drawing.Point(431, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "STUDENT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Table Maker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Working Days and Hours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lectures";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(16, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(16, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "Subjects";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(16, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 46);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tags";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 396);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "Location";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(14, 471);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(170, 46);
            this.button7.TabIndex = 6;
            this.button7.Text = "Rooms";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(16, 610);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(176, 46);
            this.button9.TabIndex = 8;
            this.button9.Text = "Statistics";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(16, 689);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(253, 46);
            this.button10.TabIndex = 9;
            this.button10.Text = "Generate Time Table";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sidePanel.Location = new System.Drawing.Point(-1, 265);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(13, 46);
            this.sidePanel.TabIndex = 0;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.button8.Location = new System.Drawing.Point(10, 536);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(284, 46);
            this.button8.TabIndex = 7;
            this.button8.Text = "Sessions and Avialbility";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1295, 778);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button10);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericsub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericgroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtSubId;
        private System.Windows.Forms.TextBox txtGroupId;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button btnGenerateID;
        private System.Windows.Forms.Button btnStudentClear;
        private System.Windows.Forms.Button btnStudentSave;
        private System.Windows.Forms.NumericUpDown numericsub;
        private System.Windows.Forms.NumericUpDown numericgroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.Label lblGroupNum;
        private System.Windows.Forms.Label lblProgramme;
        private System.Windows.Forms.Label lblAcademic;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboacademic;
        private System.Windows.Forms.ComboBox comboProgramme;
        private System.Windows.Forms.Button button8;
    }
}

