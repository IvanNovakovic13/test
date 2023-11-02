namespace MainForm
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
            panelSlide = new Panel();
            button15 = new Button();
            panelScore = new Panel();
            btnPrintScore = new Button();
            btnMenageScore = new Button();
            btnNewScore = new Button();
            btnScore = new Button();
            panelCourse = new Panel();
            btnPrintCourse = new Button();
            btnMenageCourse = new Button();
            btnAddCourse = new Button();
            btnCourse = new Button();
            panelStudentSubMenu = new Panel();
            btnPrintStudent = new Button();
            btnStatus = new Button();
            btnMenageStudent = new Button();
            btnRegistration = new Button();
            btnStudent = new Button();
            panelLogo = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelMain = new Panel();
            panelCover = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            LabelRole = new Label();
            labelUser = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panelSlide.SuspendLayout();
            panelScore.SuspendLayout();
            panelCourse.SuspendLayout();
            panelStudentSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelMain.SuspendLayout();
            panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSlide
            // 
            panelSlide.AutoScroll = true;
            panelSlide.BackColor = Color.FromArgb(0, 71, 160);
            panelSlide.Controls.Add(button15);
            panelSlide.Controls.Add(panelScore);
            panelSlide.Controls.Add(btnScore);
            panelSlide.Controls.Add(panelCourse);
            panelSlide.Controls.Add(btnCourse);
            panelSlide.Controls.Add(panelStudentSubMenu);
            panelSlide.Controls.Add(btnStudent);
            panelSlide.Controls.Add(panelLogo);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(228, 603);
            panelSlide.TabIndex = 0;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Popup;
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Location = new Point(0, 781);
            button15.Name = "button15";
            button15.Padding = new Padding(10, 0, 0, 0);
            button15.Size = new Size(207, 50);
            button15.TabIndex = 8;
            button15.Text = "Exit";
            button15.TextAlign = ContentAlignment.MiddleLeft;
            button15.UseVisualStyleBackColor = true;
            // 
            // panelScore
            // 
            panelScore.BackColor = Color.FromArgb(0, 71, 200);
            panelScore.Controls.Add(btnPrintScore);
            panelScore.Controls.Add(btnMenageScore);
            panelScore.Controls.Add(btnNewScore);
            panelScore.Dock = DockStyle.Top;
            panelScore.Location = new Point(0, 628);
            panelScore.Name = "panelScore";
            panelScore.Size = new Size(207, 153);
            panelScore.TabIndex = 7;
            // 
            // btnPrintScore
            // 
            btnPrintScore.Dock = DockStyle.Top;
            btnPrintScore.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnPrintScore.FlatAppearance.BorderSize = 0;
            btnPrintScore.FlatStyle = FlatStyle.Popup;
            btnPrintScore.ForeColor = SystemColors.ButtonHighlight;
            btnPrintScore.Location = new Point(0, 100);
            btnPrintScore.Name = "btnPrintScore";
            btnPrintScore.Padding = new Padding(45, 0, 0, 0);
            btnPrintScore.Size = new Size(207, 50);
            btnPrintScore.TabIndex = 3;
            btnPrintScore.Text = "Print";
            btnPrintScore.TextAlign = ContentAlignment.MiddleLeft;
            btnPrintScore.UseVisualStyleBackColor = true;
            btnPrintScore.Click += btnPrintScore_Click;
            // 
            // btnMenageScore
            // 
            btnMenageScore.Dock = DockStyle.Top;
            btnMenageScore.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnMenageScore.FlatAppearance.BorderSize = 0;
            btnMenageScore.FlatStyle = FlatStyle.Popup;
            btnMenageScore.ForeColor = SystemColors.ButtonHighlight;
            btnMenageScore.Location = new Point(0, 50);
            btnMenageScore.Name = "btnMenageScore";
            btnMenageScore.Padding = new Padding(45, 0, 0, 0);
            btnMenageScore.Size = new Size(207, 50);
            btnMenageScore.TabIndex = 1;
            btnMenageScore.Text = "Manage Score";
            btnMenageScore.TextAlign = ContentAlignment.MiddleLeft;
            btnMenageScore.UseVisualStyleBackColor = true;
            btnMenageScore.Click += btnMenageScore_Click;
            // 
            // btnNewScore
            // 
            btnNewScore.Dock = DockStyle.Top;
            btnNewScore.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnNewScore.FlatAppearance.BorderSize = 0;
            btnNewScore.FlatStyle = FlatStyle.Popup;
            btnNewScore.ForeColor = SystemColors.ButtonHighlight;
            btnNewScore.Location = new Point(0, 0);
            btnNewScore.Name = "btnNewScore";
            btnNewScore.Padding = new Padding(45, 0, 0, 0);
            btnNewScore.Size = new Size(207, 50);
            btnNewScore.TabIndex = 0;
            btnNewScore.Text = "New Score";
            btnNewScore.TextAlign = ContentAlignment.MiddleLeft;
            btnNewScore.UseVisualStyleBackColor = true;
            btnNewScore.Click += btnNewScore_Click;
            // 
            // btnScore
            // 
            btnScore.Dock = DockStyle.Top;
            btnScore.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnScore.FlatAppearance.BorderSize = 0;
            btnScore.FlatStyle = FlatStyle.Popup;
            btnScore.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnScore.ForeColor = SystemColors.ButtonHighlight;
            btnScore.Location = new Point(0, 578);
            btnScore.Name = "btnScore";
            btnScore.Padding = new Padding(10, 0, 0, 0);
            btnScore.Size = new Size(207, 50);
            btnScore.TabIndex = 6;
            btnScore.Text = "Score";
            btnScore.TextAlign = ContentAlignment.MiddleLeft;
            btnScore.UseVisualStyleBackColor = true;
            btnScore.Click += btnScore_Click;
            // 
            // panelCourse
            // 
            panelCourse.BackColor = Color.FromArgb(0, 71, 200);
            panelCourse.Controls.Add(btnPrintCourse);
            panelCourse.Controls.Add(btnMenageCourse);
            panelCourse.Controls.Add(btnAddCourse);
            panelCourse.Dock = DockStyle.Top;
            panelCourse.Location = new Point(0, 426);
            panelCourse.Name = "panelCourse";
            panelCourse.Size = new Size(207, 152);
            panelCourse.TabIndex = 5;
            // 
            // btnPrintCourse
            // 
            btnPrintCourse.Dock = DockStyle.Top;
            btnPrintCourse.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnPrintCourse.FlatAppearance.BorderSize = 0;
            btnPrintCourse.FlatStyle = FlatStyle.Popup;
            btnPrintCourse.ForeColor = SystemColors.ButtonHighlight;
            btnPrintCourse.Location = new Point(0, 100);
            btnPrintCourse.Name = "btnPrintCourse";
            btnPrintCourse.Padding = new Padding(45, 0, 0, 0);
            btnPrintCourse.Size = new Size(207, 50);
            btnPrintCourse.TabIndex = 3;
            btnPrintCourse.Text = "Print";
            btnPrintCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnPrintCourse.UseVisualStyleBackColor = true;
            btnPrintCourse.Click += btnPrintCourse_Click;
            // 
            // btnMenageCourse
            // 
            btnMenageCourse.Dock = DockStyle.Top;
            btnMenageCourse.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnMenageCourse.FlatAppearance.BorderSize = 0;
            btnMenageCourse.FlatStyle = FlatStyle.Popup;
            btnMenageCourse.ForeColor = SystemColors.ButtonHighlight;
            btnMenageCourse.Location = new Point(0, 50);
            btnMenageCourse.Name = "btnMenageCourse";
            btnMenageCourse.Padding = new Padding(45, 0, 0, 0);
            btnMenageCourse.Size = new Size(207, 50);
            btnMenageCourse.TabIndex = 1;
            btnMenageCourse.Text = "Manage Course";
            btnMenageCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnMenageCourse.UseVisualStyleBackColor = true;
            btnMenageCourse.Click += btnMenageCourse_Click;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Dock = DockStyle.Top;
            btnAddCourse.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnAddCourse.FlatAppearance.BorderSize = 0;
            btnAddCourse.FlatStyle = FlatStyle.Popup;
            btnAddCourse.ForeColor = SystemColors.ButtonHighlight;
            btnAddCourse.Location = new Point(0, 0);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Padding = new Padding(45, 0, 0, 0);
            btnAddCourse.Size = new Size(207, 50);
            btnAddCourse.TabIndex = 0;
            btnAddCourse.Text = "Add course";
            btnAddCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCourse.UseVisualStyleBackColor = true;
            btnAddCourse.Click += btnAddCourse_Click;
            // 
            // btnCourse
            // 
            btnCourse.Dock = DockStyle.Top;
            btnCourse.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnCourse.FlatAppearance.BorderSize = 0;
            btnCourse.FlatStyle = FlatStyle.Popup;
            btnCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCourse.ForeColor = SystemColors.ButtonHighlight;
            btnCourse.Location = new Point(0, 376);
            btnCourse.Name = "btnCourse";
            btnCourse.Padding = new Padding(10, 0, 0, 0);
            btnCourse.Size = new Size(207, 50);
            btnCourse.TabIndex = 4;
            btnCourse.Text = "Course";
            btnCourse.TextAlign = ContentAlignment.MiddleLeft;
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // panelStudentSubMenu
            // 
            panelStudentSubMenu.BackColor = Color.FromArgb(0, 71, 200);
            panelStudentSubMenu.Controls.Add(btnPrintStudent);
            panelStudentSubMenu.Controls.Add(btnStatus);
            panelStudentSubMenu.Controls.Add(btnMenageStudent);
            panelStudentSubMenu.Controls.Add(btnRegistration);
            panelStudentSubMenu.Dock = DockStyle.Top;
            panelStudentSubMenu.Location = new Point(0, 173);
            panelStudentSubMenu.Name = "panelStudentSubMenu";
            panelStudentSubMenu.Size = new Size(207, 203);
            panelStudentSubMenu.TabIndex = 3;
            // 
            // btnPrintStudent
            // 
            btnPrintStudent.Dock = DockStyle.Top;
            btnPrintStudent.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnPrintStudent.FlatAppearance.BorderSize = 0;
            btnPrintStudent.FlatStyle = FlatStyle.Popup;
            btnPrintStudent.ForeColor = SystemColors.ButtonHighlight;
            btnPrintStudent.Location = new Point(0, 150);
            btnPrintStudent.Name = "btnPrintStudent";
            btnPrintStudent.Padding = new Padding(45, 0, 0, 0);
            btnPrintStudent.Size = new Size(207, 50);
            btnPrintStudent.TabIndex = 3;
            btnPrintStudent.Text = "Print";
            btnPrintStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnPrintStudent.UseVisualStyleBackColor = true;
            btnPrintStudent.Click += btnPrintStudent_Click;
            // 
            // btnStatus
            // 
            btnStatus.Dock = DockStyle.Top;
            btnStatus.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatStyle = FlatStyle.Popup;
            btnStatus.ForeColor = SystemColors.ButtonHighlight;
            btnStatus.Location = new Point(0, 100);
            btnStatus.Name = "btnStatus";
            btnStatus.Padding = new Padding(45, 0, 0, 0);
            btnStatus.Size = new Size(207, 50);
            btnStatus.TabIndex = 2;
            btnStatus.Text = "Status";
            btnStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnMenageStudent
            // 
            btnMenageStudent.Dock = DockStyle.Top;
            btnMenageStudent.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnMenageStudent.FlatAppearance.BorderSize = 0;
            btnMenageStudent.FlatStyle = FlatStyle.Popup;
            btnMenageStudent.ForeColor = SystemColors.ButtonHighlight;
            btnMenageStudent.Location = new Point(0, 50);
            btnMenageStudent.Name = "btnMenageStudent";
            btnMenageStudent.Padding = new Padding(45, 0, 0, 0);
            btnMenageStudent.Size = new Size(207, 50);
            btnMenageStudent.TabIndex = 1;
            btnMenageStudent.Text = "Manage Student";
            btnMenageStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnMenageStudent.UseVisualStyleBackColor = true;
            btnMenageStudent.Click += btnMenageStudent_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.Dock = DockStyle.Top;
            btnRegistration.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnRegistration.FlatAppearance.BorderSize = 0;
            btnRegistration.FlatStyle = FlatStyle.Popup;
            btnRegistration.ForeColor = SystemColors.ButtonHighlight;
            btnRegistration.Location = new Point(0, 0);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Padding = new Padding(45, 0, 0, 0);
            btnRegistration.Size = new Size(207, 50);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "Registration";
            btnRegistration.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // btnStudent
            // 
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatAppearance.BorderColor = Color.FromArgb(0, 71, 160);
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Popup;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudent.ForeColor = SystemColors.ButtonHighlight;
            btnStudent.Location = new Point(0, 123);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(10, 0, 0, 0);
            btnStudent.Size = new Size(207, 50);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.TextAlign = ContentAlignment.MiddleLeft;
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(label4);
            panelLogo.Controls.Add(label3);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(207, 123);
            panelLogo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 71, 160);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 82);
            label4.Name = "label4";
            label4.Size = new Size(121, 28);
            label4.TabIndex = 2;
            label4.Text = "Our Faculty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 71, 160);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 56);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 1;
            label3.Text = "Welcome From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 71, 160);
            label2.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(69, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 50);
            label2.TabIndex = 1;
            label2.Text = "M";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelCover);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(228, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(904, 603);
            panelMain.TabIndex = 1;
            // 
            // panelCover
            // 
            panelCover.Controls.Add(pictureBox2);
            panelCover.Controls.Add(panel3);
            panelCover.Controls.Add(panel2);
            panelCover.Controls.Add(panel1);
            panelCover.Dock = DockStyle.Fill;
            panelCover.Location = new Point(0, 0);
            panelCover.Name = "panelCover";
            panelCover.Size = new Size(904, 603);
            panelCover.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 123);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(901, 353);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 71, 160);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 476);
            panel3.Name = "panel3";
            panel3.Size = new Size(904, 127);
            panel3.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(576, 22);
            label11.Name = "label11";
            label11.Size = new Size(116, 28);
            label11.TabIndex = 10;
            label11.Text = "Select Class:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(814, 65);
            label9.Name = "label9";
            label9.Size = new Size(78, 28);
            label9.TabIndex = 9;
            label9.Text = "Female:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(718, 65);
            label10.Name = "label10";
            label10.Size = new Size(59, 28);
            label10.TabIndex = 8;
            label10.Text = "Male:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(698, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 28);
            comboBox1.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(135, 65);
            label8.Name = "label8";
            label8.Size = new Size(78, 28);
            label8.TabIndex = 6;
            label8.Text = "Female:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(29, 65);
            label7.Name = "label7";
            label7.Size = new Size(59, 28);
            label7.TabIndex = 5;
            label7.Text = "Male:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(29, 22);
            label6.Name = "label6";
            label6.Size = new Size(130, 28);
            label6.TabIndex = 4;
            label6.Text = "TotalStudents";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 71, 160);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(LabelRole);
            panel2.Controls.Add(labelUser);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(904, 63);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(776, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.ForeColor = SystemColors.ButtonHighlight;
            LabelRole.Location = new Point(118, 29);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(53, 20);
            LabelRole.TabIndex = 3;
            LabelRole.Text = "Admin";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.ForeColor = SystemColors.ButtonHighlight;
            labelUser.Location = new Point(118, 3);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(90, 20);
            labelUser.TabIndex = 2;
            labelUser.Text = "Someboddy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(61, 29);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 1;
            label5.Text = "Role:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(29, 3);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome:";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(904, 60);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 603);
            Controls.Add(panelMain);
            Controls.Add(panelSlide);
            MaximumSize = new Size(1150, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelSlide.ResumeLayout(false);
            panelScore.ResumeLayout(false);
            panelCourse.ResumeLayout(false);
            panelStudentSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelMain.ResumeLayout(false);
            panelCover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlide;
        private Button btnStudent;
        private Panel panelLogo;
        private Panel panelStudentSubMenu;
        private Button btnPrintStudent;
        private Button btnStatus;
        private Button btnMenageStudent;
        private Button btnRegistration;
        private Button button15;
        private Panel panelScore;
        private Button btnPrintScore;
        private Button btnMenageScore;
        private Button btnNewScore;
        private Button btnScore;
        private Panel panelCourse;
        private Button btnPrintCourse;
        private Button btnMenageCourse;
        private Button btnAddCourse;
        private Button btnCourse;
        private Label label3;
        private Label label2;
        private Label label4;
        private Panel panelMain;
        private Panel panelCover;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label LabelRole;
        private Label labelUser;
        private Label label5;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}