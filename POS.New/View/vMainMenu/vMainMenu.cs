using POS.New.View.vLogIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.New
{
    public partial class vMainMenu : Telerik.WinControls.UI.RadForm
    {
        #region Properties
        public bool isCollapsed;
        #endregion
        public vMainMenu()
        {
            InitializeComponent();
            isCollapsed = false;
            RemoveOutline();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            Collapse();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            Collapse();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            HidePageDashboard();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            HidePageOrder();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            HidePageOrderHistory();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HidePageInventory();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        void HidePageDashboard()
        {
            rpvMenu.SelectedPage = idDashboard;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        void HidePageOrder()
        {
            rpvMenu.SelectedPage = idOrder;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        void HidePageOrderHistory()
        {
            rpvMenu.SelectedPage = idOrderHistory;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        void HidePageInventory()
        {
            rpvMenu.SelectedPage = idInventory;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
        }

        void LogOut()
        {
            vLogin vLogin = new vLogin();
            this.Hide();
            vLogin.Show();
        }

        void Collapse()
        {
            if (isCollapsed == false)
            {
                isCollapsed = true;
                panNavigationBar.Size = new Size(35, 0);
                btnDashboard.Text = "";
                btnOrder.Text = "";
                btnOrderHistory.Text = "";
                btnInventory.Text = "";
                btnLogOut.Text = "";
                lblTitle.Text = "";
            }

            else if (isCollapsed == true)
            {
                isCollapsed = false;
                panNavigationBar.Size = new Size(170, 0);
                btnDashboard.Text = "Dashboard";
                btnOrder.Text = "Order";
                btnOrderHistory.Text = "Order History";
                btnInventory.Text = "Inventory";
                btnLogOut.Text = "Logout";
                lblTitle.Text = "Eats2Go";
            }
        }

        void RemoveOutline()
        {
            btnCollapse.ButtonElement.ShowBorder = false;
            btnDashboard.ButtonElement.ShowBorder = false;
            btnOrder.ButtonElement.ShowBorder = false;
            btnOrderHistory.ButtonElement.ShowBorder = false;
            btnInventory.ButtonElement.ShowBorder = false;
            btnLogOut.ButtonElement.ShowBorder = false;
        }

        #region BtnMouseColors
        private void btnCollapse_MouseEnter(object sender, EventArgs e)
        {
            btnCollapse.BackColor = Color.SlateBlue;
        }

        private void btnCollapse_MouseLeave(object sender, EventArgs e)
        {
            btnCollapse.BackColor = Color.DarkSlateBlue;
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.SlateBlue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.DarkSlateBlue;
        }

        private void btnOrder_MouseEnter(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.SlateBlue;
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            btnOrder.BackColor = Color.DarkSlateBlue;
        }

        private void btnOrderHistory_MouseEnter(object sender, EventArgs e)
        {
            btnOrderHistory.BackColor = Color.SlateBlue;
        }

        private void btnOrderHistory_MouseLeave(object sender, EventArgs e)
        {
            btnOrderHistory.BackColor = Color.DarkSlateBlue;
        }

        private void btnInventory_MouseEnter(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.SlateBlue;
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.DarkSlateBlue;
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.SlateBlue;
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.DarkSlateBlue;
        }


        #endregion

        #region OrderSettings
        private void btnChicken_MouseEnter(object sender, EventArgs e)
        {
            btnChicken.Size = new Size(106, 106);
        }

        private void btnSmoked_MouseEnter(object sender, EventArgs e)
        {
            btnSmoked.Size = new Size(106, 106);
        }

        private void btnRoast_MouseEnter(object sender, EventArgs e)
        {
            btnRoast.Size = new Size(106, 106);
        }

        private void btnChicken_MouseLeave(object sender, EventArgs e)
        {
            btnChicken.Size = new Size(100, 100);
        }

        private void btnSmoked_MouseLeave(object sender, EventArgs e)
        {
            btnSmoked.Size = new Size(100, 100);
        }

        private void btnRoast_MouseLeave(object sender, EventArgs e)
        {
            btnRoast.Size = new Size(100, 100);
        }

        private void btnMeat_MouseEnter(object sender, EventArgs e)
        {
            btnMeat.Size = new Size(169, 48);
            btnMeat.BackColor = Color.SlateBlue;
        }

        private void btnMeat_MouseLeave(object sender, EventArgs e)
        {
            btnMeat.Size = new Size(128, 48);
            btnMeat.BackColor = Color.DarkSlateBlue;
        }

        private void btnChips_MouseEnter(object sender, EventArgs e)
        {
            btnChips.Size = new Size(169, 48);
            btnChips.BackColor = Color.SlateBlue;
        }

        private void btnChips_MouseLeave(object sender, EventArgs e)
        {
            btnChips.Size = new Size(128, 48);
            btnChips.BackColor = Color.DarkSlateBlue;
        }
        #endregion

        private void btnChicken_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
