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
        public int counter1 = 0;
        public int counter2 = 0;
        public int counter3 = 0;
        public int sum1 { get; set; }
        public int sum2 { get; set; }
        public int sum3 { get; set; }
        public int total { get; set; }
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

        private void btnMeat_Click(object sender, EventArgs e)
        {
            CheckMeat();
        }

        private void btnChips_Click(object sender, EventArgs e)
        {
            CheckChips();
        }

        private void vMainMenu_Load(object sender, EventArgs e)
        {
            HidePageDashboard();
        }

        #region Functions
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

        void CheckMeat()
        {
            if (chkbMeat.Checked)
            {
                chkbMeat.Checked = false;
                lblAdd1.Text = "";
                total = total - 20;
                txtTotal.Text = total.ToString();
            }
            else
            {
                chkbMeat.Checked = true;
                lblAdd1.Text = "20";
                total = total + 20;
                txtTotal.Text = total.ToString();
            }
        }

        void CheckChips()
        {
            if (chkbChips.Checked)
            {
                chkbChips.Checked = false;
                lblAdd2.Text = "";
                total = total - 20;
                txtTotal.Text = total.ToString();
            }
            else
            {
                chkbChips.Checked = true;
                lblAdd2.Text = "20";
                total = total + 20;
                txtTotal.Text = total.ToString();
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
        #endregion

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

        #region Add & Subtract
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            counter1++;
            txtQty1.Text = counter1.ToString();
            sum1 = sum1 + 89;
            lblTotal1.Text = sum1.ToString();
            total = total + 89;
            txtTotal.Text = total.ToString();
            lblQty1.Text = counter1.ToString();
            lblChicken.Text = "Chicken Pesto";
        }

        private void btnSub1_Click(object sender, EventArgs e)
        {
            counter1--;
            txtQty1.Text = counter1.ToString();
            sum1 = sum1 - 89;
            lblTotal1.Text = sum1.ToString();
            total = total - 89;
            txtTotal.Text = total.ToString();
            lblQty1.Text = counter1.ToString();
            lblChicken.Text = "Chicken Pesto";
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            counter2++;
            txtQty2.Text = counter2.ToString();
            sum2 = sum2 + 69;
            lblTotal2.Text = sum2.ToString();
            total = total + 69;
            txtTotal.Text = total.ToString();
            lblQty2.Text = counter2.ToString();
            lblSmoked.Text = "Smoked Turkey";
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
            counter2--;
            txtQty2.Text = counter2.ToString();
            sum2 = sum2 - 69;
            lblTotal2.Text = sum2.ToString();
            total = total - 69;
            txtTotal.Text = total.ToString();
            lblQty2.Text = counter2.ToString();
            lblSmoked.Text = "Smoked Turkey";
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            counter3++;
            txtQty3.Text = counter3.ToString();
            sum3 = sum3 + 69;
            lblTotal3.Text = sum3.ToString();
            total = total + 69;
            txtTotal.Text = total.ToString();
            lblQty3.Text = counter3.ToString();
            lblRoast.Text = "Roast Beef";
        }

        private void btnSub3_Click(object sender, EventArgs e)
        {
            counter3--;
            txtQty3.Text = counter3.ToString();
            sum3 = sum3 - 69;
            lblTotal3.Text = sum3.ToString();
            total = total - 69;
            txtTotal.Text = total.ToString();
            lblQty3.Text = counter3.ToString();
            lblRoast.Text = "Roast Beef";
        }

        private void btnAddToCart_MouseEnter(object sender, EventArgs e)
        {
            btnAddToCart.Size = new Size(110, 39);
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.BackColor = Color.SlateBlue;
        }

        private void btnAddToCart_MouseLeave(object sender, EventArgs e)
        {
            btnAddToCart.Size = new Size(36, 39);
            btnAddToCart.Text = "";
            btnAddToCart.BackColor = Color.DarkSlateBlue;
        }

        #endregion

        
    }
}
