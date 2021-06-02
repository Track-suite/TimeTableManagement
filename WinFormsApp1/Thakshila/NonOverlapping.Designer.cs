
namespace WinFormsApp1.Thakshila
{
    partial class NonOverlapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonOverlapping));
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NLectureName = new System.Windows.Forms.TextBox();
            this.NTagName = new System.Windows.Forms.TextBox();
            this.GroupId1 = new System.Windows.Forms.TextBox();
            this.NSubjectName = new System.Windows.Forms.TextBox();
            this.NNoStudents = new System.Windows.Forms.TextBox();
            this.NDuration = new System.Windows.Forms.TextBox();
            this.NRoomName = new System.Windows.Forms.TextBox();
            this.NSessionID = new System.Windows.Forms.TextBox();
            this.NDays = new System.Windows.Forms.TextBox();
            this.NTime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(186, 93);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(157, 36);
            this.button14.TabIndex = 61;
            this.button14.Text = "Add session time";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Honeydew;
            this.button15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(722, 93);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(233, 32);
            this.button15.TabIndex = 62;
            this.button15.Text = "Non overlapping session";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(12, 87);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(141, 41);
            this.button13.TabIndex = 60;
            this.button13.Text = "Session";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 235);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 6;
            this.chk.Name = "chk";
            this.chk.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1062, 60);
            this.panel3.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(284, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Session and Avilability";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(542, 95);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(151, 33);
            this.button12.TabIndex = 65;
            this.button12.Text = "Parallel session";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(352, 96);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(184, 33);
            this.button11.TabIndex = 64;
            this.button11.Text = "Consecutive";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.SkyBlue;
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(218, 636);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(326, 29);
            this.button17.TabIndex = 68;
            this.button17.Text = "ADD NON OVERLAPPING SESSION";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(367, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 66;
            this.label1.Text = "Non  overlapping Session";
            // 
            // NLectureName
            // 
            this.NLectureName.Location = new System.Drawing.Point(12, 533);
            this.NLectureName.Name = "NLectureName";
            this.NLectureName.Size = new System.Drawing.Size(82, 27);
            this.NLectureName.TabIndex = 69;
            // 
            // NTagName
            // 
            this.NTagName.Location = new System.Drawing.Point(100, 533);
            this.NTagName.Name = "NTagName";
            this.NTagName.Size = new System.Drawing.Size(82, 27);
            this.NTagName.TabIndex = 70;
            // 
            // GroupId1
            // 
            this.GroupId1.Location = new System.Drawing.Point(186, 533);
            this.GroupId1.Name = "GroupId1";
            this.GroupId1.Size = new System.Drawing.Size(88, 27);
            this.GroupId1.TabIndex = 71;
            // 
            // NSubjectName
            // 
            this.NSubjectName.Location = new System.Drawing.Point(280, 533);
            this.NSubjectName.Name = "NSubjectName";
            this.NSubjectName.Size = new System.Drawing.Size(87, 27);
            this.NSubjectName.TabIndex = 72;
            // 
            // NNoStudents
            // 
            this.NNoStudents.Location = new System.Drawing.Point(373, 533);
            this.NNoStudents.Name = "NNoStudents";
            this.NNoStudents.Size = new System.Drawing.Size(83, 27);
            this.NNoStudents.TabIndex = 73;
            // 
            // NDuration
            // 
            this.NDuration.Location = new System.Drawing.Point(462, 533);
            this.NDuration.Name = "NDuration";
            this.NDuration.Size = new System.Drawing.Size(82, 27);
            this.NDuration.TabIndex = 74;
            this.NDuration.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NRoomName
            // 
            this.NRoomName.Location = new System.Drawing.Point(550, 533);
            this.NRoomName.Name = "NRoomName";
            this.NRoomName.Size = new System.Drawing.Size(85, 27);
            this.NRoomName.TabIndex = 75;
            // 
            // NSessionID
            // 
            this.NSessionID.Location = new System.Drawing.Point(641, 533);
            this.NSessionID.Name = "NSessionID";
            this.NSessionID.Size = new System.Drawing.Size(76, 27);
            this.NSessionID.TabIndex = 76;
            // 
            // NDays
            // 
            this.NDays.Location = new System.Drawing.Point(722, 533);
            this.NDays.Name = "NDays";
            this.NDays.Size = new System.Drawing.Size(87, 27);
            this.NDays.TabIndex = 77;
            // 
            // NTime
            // 
            this.NTime.Location = new System.Drawing.Point(815, 533);
            this.NTime.Name = "NTime";
            this.NTime.Size = new System.Drawing.Size(96, 27);
            this.NTime.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(579, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 79;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 38);
            this.panel1.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modules from different categories should not be overlapped!!!";
            // 
            // NonOverlapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1054, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NTime);
            this.Controls.Add(this.NDays);
            this.Controls.Add(this.NSessionID);
            this.Controls.Add(this.NRoomName);
            this.Controls.Add(this.NDuration);
            this.Controls.Add(this.NNoStudents);
            this.Controls.Add(this.NSubjectName);
            this.Controls.Add(this.GroupId1);
            this.Controls.Add(this.NTagName);
            this.Controls.Add(this.NLectureName);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.label1);
            this.Name = "NonOverlapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NonOverlapping";
            this.Load += new System.EventHandler(this.NonOverlapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.TextBox NLectureName;
        private System.Windows.Forms.TextBox NTagName;
        private System.Windows.Forms.TextBox GroupId;
        private System.Windows.Forms.TextBox GroupId1;
        private System.Windows.Forms.TextBox NSubjectName;
        private System.Windows.Forms.TextBox NNoStudents;
        private System.Windows.Forms.TextBox NDuration;
        private System.Windows.Forms.TextBox NRoomName;
        private System.Windows.Forms.TextBox NSessionID;
        private System.Windows.Forms.TextBox NDays;
        private System.Windows.Forms.TextBox NTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}