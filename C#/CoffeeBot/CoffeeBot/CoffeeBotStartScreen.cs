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
        bool accPan;
        string label = "CoffeeBot: ";


        /* **********METHODS********** */
  

        private void panelClosing(string panel1, string panel2)/*panel switching*/
        {
            Control one = this.Controls[panel1];
            Control two = this.Controls[panel2];
            one.Visible = false;
            one.IsAccessible = false;
            two.Visible = false;
            two.IsAccessible = false;
        }

        private void panelOpening(string panel)/*panel switching*/
        {
            Control p = this.Controls[panel];
            p.IsAccessible = true;
            p.Visible = true;
        }

        private void clearOptions(bool decision)/*Clear accounts page*/
        {
            //ddlaccGameSelect.SelectedIndex = 0;
            if(decision == false)
            {
                txtAccountName.Clear();
                txtaccPassword.Clear();
            }
            else if(decision == true)
            {
                lblaccAccountName.Visible = false;
                ddlaccAccountSelect.Visible = false;
                //ddlaccAccountSelect.SelectedIndex = 0;
                lblaccNewPass.Visible = false;
                txtaccNewPass.Clear();
                txtaccNewPass.Visible = false;
                lblaccConfirmPass.Visible = false;
                txtaccConfirmPass.Clear();
            }
        }

        private void accountPanelSwitch(bool decision)/*switching within the Accounts Panel*/
        {
            btnSubmit.Visible = true;
            btnClear.Visible = true;
            btnAddAccount.Visible = false;
            btnManage.Visible = false;
            lblaccGameSelect.Visible = true;
            ddlaccGameSelect.Visible = true;
            if (decision == false)
            {
                btnAccountsBack.Visible = true;
                lblaccPassword.Visible = true;
                txtaccPassword.Visible = true;
                lblaccNewAccount.Visible = true;
                txtAccountName.Visible = true;
                btnSubmit.Text = "Add";
            }
            else if (decision == true)
            {
                btnAccountsBack.Visible = true;
                btnSubmit.Text = "Update";
            }
        }

        private void GameListPopulate(string boxName)
        {
            Control box = this.Controls[boxName];
            
        }

        private void backButton(bool decision)/*proper function for backbutton*/
        {
            btnAddAccount.Visible = true;
            btnManage.Visible = true;
            btnAccountsBack.Visible = false;
            btnClear.Visible = false;
            btnSubmit.Visible = false;
            clearOptions(decision);
            if (decision == false)
            {
                lblaccGameSelect.Visible = false;
                ddlaccGameSelect.Visible = false;
                lblaccNewAccount.Visible = false;
                txtAccountName.Visible = false;
                txtaccPassword.Visible = false;
                lblaccPassword.Visible = false;

            }
            else if (decision == true)
            {
                lblaccGameSelect.Visible = false;
                ddlaccGameSelect.Visible = false;
            }
        }

        /* **********BUTTONS********** */

        private void btnClose_Click(object sender, EventArgs e)/*Exit Button*/
        {
            Application.Exit();
        }

        private void btnBot_Click(object sender, EventArgs e)/*Bot Selection Button*/
        {
            lblSceneTitle.Text = label + "Bot Selection";
            panelOpening("panelBotSelection");
            panelClosing("panelAccount", "panelAccount");
            backButton(accPan);
        }

        private void btnAccounts_Click(object sender, EventArgs e)/*Accounts Button*/
        {
            lblSceneTitle.Text = label + "Accounts";
            backButton(accPan);
            panelClosing("panelBotSelection", "panelBotSelection");
            panelOpening("panelAccount");

        }

        private void btnSettings_Click(object sender, EventArgs e)/*Settings Button*/
        {
            lblSceneTitle.Text = label + "Settings";
            panelClosing("panelBotSelection", "panelAccount");
            backButton(accPan);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)/*Add Account*/
        {
            accPan = false;
            accountPanelSwitch(accPan);
            
        }

        private void btnManage_Click(object sender, EventArgs e) /*Manage Account*/
        {
            accPan = true;
            accountPanelSwitch(accPan);
            
        }

        private void btnAccountsBack_Click(object sender, EventArgs e)/*Account page back button*/
        {
            backButton(accPan);
        }
    }
}
