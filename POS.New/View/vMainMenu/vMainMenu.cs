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
            HidePage();
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
            HidePage();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            HidePage();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            HidePage();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HidePage();
        }

        void HidePage()
        {
            rpvMenu.SelectedPage = idDashboard;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            rpvMenu.SelectedPage = idOrder;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            rpvMenu.SelectedPage = idOrderHistory;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            rpvMenu.SelectedPage = idInventory;
            rpvMenu.Pages[0].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[1].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[2].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            rpvMenu.Pages[3].Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
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
    }
}
