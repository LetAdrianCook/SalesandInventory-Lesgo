using Sales_Inv;
using SalesandInventory.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesandInventory
{
    public partial class PosDashboard : Form
    {

        NavigationControl navigationControl;
        NavigationButtons navigationButtons;

        Color btndDefaultColor = Color.FromKnownColor(KnownColor.LightSteelBlue);
        Color btndSelectedColor = Color.FromKnownColor(KnownColor.White);
        public PosDashboard()
        {
            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButton();
        }

        private void InitializeNavigationControl()
        {
            List<UserControl> userControls = new List<UserControl>()
            { new UserControl2(), new UserProfile() };

            navigationControl = new NavigationControl(userControls, dashPanel);
            navigationControl.Display(0);

        }
        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            { posBtn, userBtn};

            navigationButtons = new NavigationButtons(buttons, btndDefaultColor, btndSelectedColor);
            navigationButtons.Highlight(posBtn);
        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(posBtn);
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(userBtn);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Exited");
            Application.Exit();
        }

        private void PosDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
