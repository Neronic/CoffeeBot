using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeBot
{
    public partial class CoffeeBotStartScreen : Form
    {
        public CoffeeBotStartScreen()
        {
            InitializeComponent();
        }

        string label = "CoffeeBot: ";

        private void panelClosing(string panel1, string panel2)
        {
            Control one = this.Controls[panel1];
            Control two = this.Controls[panel2];
            one.Visible = false;
            one.IsAccessible = false;
            two.Visible = false;
            two.IsAccessible = false;
        }

        private void panelOpening(string panel)
        {
            Control p = this.Controls[panel];
            p.IsAccessible = true;
            p.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            lblSceneTitle.Text = label + "Bot Selection";
            panelOpening("panelBotSelection");
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            lblSceneTitle.Text = label + "Accounts";
            panelClosing("panelBotSelection", "panelBotSelection");

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            lblSceneTitle.Text = label + "Settings";
            panelBotSelection.Visible = false;
            panelBotSelection.IsAccessible = false;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
