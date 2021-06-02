
namespace WinFormsApp1.Thakshila
{
    partial class ParallelSessioncs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParallelSessioncs));
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LectureName = new System.Windows.Forms.TextBox();
            this.TagName = new System.Windows.Forms.TextBox();
            this.GroupId = new System.Windows.Forms.TextBox();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.NoStudents = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.SessionID = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.SkyBlue;
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(316, 608);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(160, 29);
            this.button17.TabIndex = 57;
            this.button17.Text = "ADD SESSION";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(445, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Parallel Session";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Honeydew;
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(545, 78);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(159, 41);
            this.button12.TabIndex = 54;
            this.button12.Text = "Parallel session";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(347, 78);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 41);
            this.button11.TabIndex = 53;
            this.button11.Text = "Consecutive";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 54);
            this.panel3.TabIndex = 48;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(176, 78);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 42);
            this.button14.TabIndex = 50;
            this.button14.Text = "Add session time";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(710, 78);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(241, 41);
            this.button15.TabIndex = 51;
            this.button15.Text = "Non overlapping session";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(12, 78);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(149, 41);
            this.button13.TabIndex = 49;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 257);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 6;
            this.chk.Name = "chk";
            this.chk.ReadOnly = true;
            this.chk.Width = 125;
            // 
            // LectureName
            // 
            this.LectureName.Location = new System.Drawing.Point(12, 501);
            this.LectureName.Name = "LectureName";
            this.LectureName.Size = new System.Drawing.Size(88, 27);
            this.LectureName.TabIndex = 58;
            // 
            // TagName
            // 
            this.TagName.Location = new System.Drawing.Point(106, 501);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(91, 27);
            this.TagName.TabIndex = 59;
            // 
            // GroupId
            // 
            this.GroupId.Location = new System.Drawing.Point(203, 501);
            this.GroupId.Name = "GroupId";
            this.GroupId.Size = new System.Drawing.Size(88, 27);
            this.GroupId.TabIndex = 60;
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(298, 501);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(84, 27);
            this.SubjectName.TabIndex = 61;
            // 
            // NoStudents
            // 
            this.NoStudents.Location = new System.Drawing.Point(388, 501);
            this.NoStudents.Name = "NoStudents";
            this.NoStudents.Size = new System.Drawing.Size(76, 27);
            this.NoStudents.TabIndex = 62;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(470, 501);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(86, 27);
            this.Duration.TabIndex = 63;
            // 
            // RoomName
            // 
            this.RoomName.Location = new System.Drawing.Point(562, 500);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(78, 27);
            this.RoomName.TabIndex = 64;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(738, 500);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(92, 27);
            this.Time.TabIndex = 65;
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(646, 500);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(86, 27);
            this.Days.TabIndex = 66;
            // 
            // SessionID
            // 
            this.SessionID.Location = new System.Drawing.Point(836, 500);
            this.SessionID.Name = "SessionID";
            this.SessionID.Size = new System.Drawing.Size(89, 27);
            this.SessionID.TabIndex = 67;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.SteelBlue;
            this.view.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.view.Location = new System.Drawing.Point(545, 608);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(160, 29);
            this.view.TabIndex = 68;
            this.view.Text = "VIEW";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 40);
            this.panel1.TabIndex = 69;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 11);
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
            this.label2.Size = new System.Drawing.Size(626, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parallel session criteria should fulfill the same day,same starting time and same" +
    " ending time!!!";
            // 
            // ParallelSessioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1054, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.SessionID);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.RoomName);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.NoStudents);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.GroupId);
            this.Controls.Add(this.TagName);
            this.Controls.Add(this.LectureName);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ParallelSessioncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParallelSessioncs";
            this.Load += new System.EventHandler(this.ParallelSessioncs_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.TextBox LectureName;
        private System.Windows.Forms.TextBox TagName;
        private System.Windows.Forms.TextBox GroupId;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.TextBox NoStudents;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.TextBox SessionID;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}