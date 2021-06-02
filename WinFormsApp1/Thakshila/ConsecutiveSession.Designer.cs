
namespace WinFormsApp1.Thakshila
{
    partial class ConsecutiveSession
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
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.LectureName = new System.Windows.Forms.TextBox();
            this.TagName = new System.Windows.Forms.TextBox();
            this.GroupId = new System.Windows.Forms.TextBox();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.NoStudents = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.RoomName = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.SkyBlue;
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.Location = new System.Drawing.Point(324, 586);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(160, 49);
            this.button17.TabIndex = 67;
            this.button17.Text = "ADD SESSION";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(344, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 23);
            this.label1.TabIndex = 65;
            this.label1.Text = "Consecutive Session";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(542, 86);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(159, 44);
            this.button12.TabIndex = 64;
            this.button12.Text = "Parallel session";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Honeydew;
            this.button11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(344, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(192, 41);
            this.button11.TabIndex = 63;
            this.button11.Text = "Consecutive";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(323, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Session and Avilability";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(973, 54);
            this.panel3.TabIndex = 58;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(173, 86);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(165, 41);
            this.button14.TabIndex = 60;
            this.button14.Text = "Add session time";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.Location = new System.Drawing.Point(707, 86);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(241, 44);
            this.button15.TabIndex = 61;
            this.button15.Text = "Non overlapping session";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.Location = new System.Drawing.Point(9, 86);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(149, 41);
            this.button13.TabIndex = 59;
            this.button13.Text = "Session";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // LectureName
            // 
            this.LectureName.Location = new System.Drawing.Point(12, 480);
            this.LectureName.Name = "LectureName";
            this.LectureName.Size = new System.Drawing.Size(99, 27);
            this.LectureName.TabIndex = 68;
            // 
            // TagName
            // 
            this.TagName.Location = new System.Drawing.Point(114, 480);
            this.TagName.Name = "TagName";
            this.TagName.Size = new System.Drawing.Size(98, 27);
            this.TagName.TabIndex = 69;
            // 
            // GroupId
            // 
            this.GroupId.Location = new System.Drawing.Point(218, 480);
            this.GroupId.Name = "GroupId";
            this.GroupId.Size = new System.Drawing.Size(88, 27);
            this.GroupId.TabIndex = 70;
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(312, 480);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(95, 27);
            this.SubjectName.TabIndex = 71;
            // 
            // NoStudents
            // 
            this.NoStudents.Location = new System.Drawing.Point(411, 480);
            this.NoStudents.Name = "NoStudents";
            this.NoStudents.Size = new System.Drawing.Size(90, 27);
            this.NoStudents.TabIndex = 72;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(507, 480);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(95, 27);
            this.Duration.TabIndex = 73;
            // 
            // RoomName
            // 
            this.RoomName.Location = new System.Drawing.Point(608, 480);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(93, 27);
            this.RoomName.TabIndex = 74;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(707, 480);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(86, 27);
            this.day.TabIndex = 75;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(799, 480);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(82, 27);
            this.Id.TabIndex = 76;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 6;
            this.chk.Name = "chk";
            this.chk.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 235);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(564, 586);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 77;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsecutiveSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1054, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.day);
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
            this.Name = "ConsecutiveSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsecutiveSession";
            this.Load += new System.EventHandler(this.ConsecutiveSession_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox LectureName;
        private System.Windows.Forms.TextBox TagName;
        private System.Windows.Forms.TextBox GroupId1;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.TextBox NoStudents;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox RoomName;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox GroupId;
        private System.Windows.Forms.TextBox No;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button button1;
    }
}