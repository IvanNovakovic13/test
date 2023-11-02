namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        }
        private void customizeDesign()
        {
            panelStudentSubMenu.Visible = false;
            panelCourse.Visible = false;
            panelScore.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelStudentSubMenu.Visible == true)
            {
                panelStudentSubMenu.Visible = false;
            }
            if (panelCourse.Visible == true)
            {
                panelCourse.Visible = false;
            }
            if (panelScore.Visible == true)
            {
                panelScore.Visible = false;
            }
        }
        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStudentSubMenu);
        }


        #region StudentSubMenu
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnMenageStudent_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnPrintStudent_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }
        #endregion StudentSubMenu
        private void btnCourse_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCourse);
        }

        #region CourseSubmenu
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnMenageCourse_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnPrintCourse_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }
        #endregion CourseSubMenu
        private void btnScore_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelScore);
        }
        #region ScoreSubMenu
        private void btnNewScore_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnMenageScore_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }

        private void btnPrintScore_Click(object sender, EventArgs e)
        {
            //.....
            //neki kod
            //....
            HideSubMenu();
        }
    }
    #endregion ScoreSubMenu
}