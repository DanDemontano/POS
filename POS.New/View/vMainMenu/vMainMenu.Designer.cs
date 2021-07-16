
namespace POS.New
{
    partial class vMainMenu
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
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.panMain = new Telerik.WinControls.UI.RadPanel();
            this.panContent = new Telerik.WinControls.UI.RadPanel();
            this.rpvMenu = new Telerik.WinControls.UI.RadPageView();
            this.idDashboard = new Telerik.WinControls.UI.RadPageViewPage();
            this.idOrder = new Telerik.WinControls.UI.RadPageViewPage();
            this.button1 = new System.Windows.Forms.Button();
            this.idOrderHistory = new Telerik.WinControls.UI.RadPageViewPage();
            this.idInventory = new Telerik.WinControls.UI.RadPageViewPage();
            this.panHeader = new Telerik.WinControls.UI.RadPanel();
            this.panFooter = new Telerik.WinControls.UI.RadPanel();
            this.panNavigationBar = new Telerik.WinControls.UI.RadPanel();
            this.btnLogOut = new Telerik.WinControls.UI.RadButton();
            this.btnInventory = new Telerik.WinControls.UI.RadButton();
            this.btnOrderHistory = new Telerik.WinControls.UI.RadButton();
            this.btnOrder = new Telerik.WinControls.UI.RadButton();
            this.btnDashboard = new Telerik.WinControls.UI.RadButton();
            this.btnCollapse = new Telerik.WinControls.UI.RadButton();
            this.lblTitle = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).BeginInit();
            this.panMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).BeginInit();
            this.panContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpvMenu)).BeginInit();
            this.rpvMenu.SuspendLayout();
            this.idOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panNavigationBar)).BeginInit();
            this.panNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollapse)).BeginInit();
            this.btnCollapse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panContent);
            this.panMain.Controls.Add(this.panHeader);
            this.panMain.Controls.Add(this.panFooter);
            this.panMain.Controls.Add(this.panNavigationBar);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1272, 635);
            this.panMain.TabIndex = 1;
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.rpvMenu);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(170, 35);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1102, 570);
            this.panContent.TabIndex = 2;
            // 
            // rpvMenu
            // 
            this.rpvMenu.Controls.Add(this.idDashboard);
            this.rpvMenu.Controls.Add(this.idOrder);
            this.rpvMenu.Controls.Add(this.idOrderHistory);
            this.rpvMenu.Controls.Add(this.idInventory);
            this.rpvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvMenu.ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth;
            this.rpvMenu.Location = new System.Drawing.Point(0, 0);
            this.rpvMenu.Name = "rpvMenu";
            this.rpvMenu.SelectedPage = this.idDashboard;
            this.rpvMenu.Size = new System.Drawing.Size(1102, 570);
            this.rpvMenu.TabIndex = 5;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ShowItemPinButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Center;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ItemFitMode = ((Telerik.WinControls.UI.StripViewItemFitMode)((Telerik.WinControls.UI.StripViewItemFitMode.Shrink | Telerik.WinControls.UI.StripViewItemFitMode.Fill)));
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).StripAlignment = Telerik.WinControls.UI.StripViewAlignment.Top;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ShowItemCloseButton = false;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ItemDragMode = Telerik.WinControls.UI.PageViewItemDragMode.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualWidth;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.rpvMenu.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Auto;
            // 
            // idDashboard
            // 
            this.idDashboard.ItemSize = new System.Drawing.SizeF(275F, 29F);
            this.idDashboard.Location = new System.Drawing.Point(6, 35);
            this.idDashboard.Name = "idDashboard";
            this.idDashboard.Size = new System.Drawing.Size(1090, 529);
            this.idDashboard.Text = "Dashboard";
            this.idDashboard.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idOrder
            // 
            this.idOrder.Controls.Add(this.button1);
            this.idOrder.ItemSize = new System.Drawing.SizeF(275F, 29F);
            this.idOrder.Location = new System.Drawing.Point(6, 35);
            this.idOrder.Name = "idOrder";
            this.idOrder.Size = new System.Drawing.Size(1090, 545);
            this.idOrder.Text = "Order";
            this.idOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idOrderHistory
            // 
            this.idOrderHistory.ItemSize = new System.Drawing.SizeF(275F, 29F);
            this.idOrderHistory.Location = new System.Drawing.Point(6, 35);
            this.idOrderHistory.Name = "idOrderHistory";
            this.idOrderHistory.Size = new System.Drawing.Size(1090, 545);
            this.idOrderHistory.Text = "Order History";
            this.idOrderHistory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idInventory
            // 
            this.idInventory.ItemSize = new System.Drawing.SizeF(275F, 29F);
            this.idInventory.Location = new System.Drawing.Point(6, 35);
            this.idInventory.Name = "idInventory";
            this.idInventory.Size = new System.Drawing.Size(1090, 545);
            this.idInventory.Text = "Inventory";
            this.idInventory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(170, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1102, 35);
            this.panHeader.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panHeader.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panHeader.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.Location = new System.Drawing.Point(170, 605);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(1102, 30);
            this.panFooter.TabIndex = 4;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panFooter.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panFooter.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // panNavigationBar
            // 
            this.panNavigationBar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panNavigationBar.Controls.Add(this.btnLogOut);
            this.panNavigationBar.Controls.Add(this.btnInventory);
            this.panNavigationBar.Controls.Add(this.btnOrderHistory);
            this.panNavigationBar.Controls.Add(this.btnOrder);
            this.panNavigationBar.Controls.Add(this.btnDashboard);
            this.panNavigationBar.Controls.Add(this.btnCollapse);
            this.panNavigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panNavigationBar.Location = new System.Drawing.Point(0, 0);
            this.panNavigationBar.Name = "panNavigationBar";
            this.panNavigationBar.Size = new System.Drawing.Size(170, 635);
            this.panNavigationBar.TabIndex = 2;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panNavigationBar.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panNavigationBar.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::POS.New.Properties.Resources.outline_logout_white_24dp;
            this.btnLogOut.Location = new System.Drawing.Point(0, 605);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(170, 30);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Logout";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogOut.GetChildAt(0))).Image = global::POS.New.Properties.Resources.outline_logout_white_24dp;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogOut.GetChildAt(0))).Text = "Logout";
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnLogOut.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.btnLogOut.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::POS.New.Properties.Resources.outline_inventory_2_white_24dp;
            this.btnInventory.Location = new System.Drawing.Point(0, 218);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(170, 55);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOrderHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderHistory.ForeColor = System.Drawing.Color.White;
            this.btnOrderHistory.Image = global::POS.New.Properties.Resources.outline_history_white_24dp;
            this.btnOrderHistory.Location = new System.Drawing.Point(0, 163);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOrderHistory.Size = new System.Drawing.Size(170, 55);
            this.btnOrderHistory.TabIndex = 0;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Image = global::POS.New.Properties.Resources.outline_point_of_sale_white_24dp;
            this.btnOrder.Location = new System.Drawing.Point(0, 108);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(170, 55);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::POS.New.Properties.Resources.outline_dashboard_white_24dp;
            this.btnDashboard.Location = new System.Drawing.Point(0, 53);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(170, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCollapse.Controls.Add(this.lblTitle);
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollapse.Font = new System.Drawing.Font("Harabara", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.Image = global::POS.New.Properties.Resources.outline_menu_open_white_24dp;
            this.btnCollapse.Location = new System.Drawing.Point(0, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCollapse.Size = new System.Drawing.Size(170, 53);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Harabara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(48, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(122, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Eats2Go";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // vMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 635);
            this.Controls.Add(this.panMain);
            this.Name = "vMainMenu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ThemeName = "VisualStudio2012Light";
            ((System.ComponentModel.ISupportInitialize)(this.panMain)).EndInit();
            this.panMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panContent)).EndInit();
            this.panContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpvMenu)).EndInit();
            this.rpvMenu.ResumeLayout(false);
            this.idOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panNavigationBar)).EndInit();
            this.panNavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrderHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCollapse)).EndInit();
            this.btnCollapse.ResumeLayout(false);
            this.btnCollapse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.UI.RadPanel panMain;
        private Telerik.WinControls.UI.RadPanel panNavigationBar;
        private Telerik.WinControls.UI.RadPageView rpvMenu;
        private Telerik.WinControls.UI.RadPanel panFooter;
        private Telerik.WinControls.UI.RadPageViewPage idDashboard;
        private Telerik.WinControls.UI.RadPageViewPage idOrder;
        private Telerik.WinControls.UI.RadPageViewPage idOrderHistory;
        private Telerik.WinControls.UI.RadPageViewPage idInventory;
        private Telerik.WinControls.UI.RadButton btnInventory;
        private Telerik.WinControls.UI.RadButton btnOrderHistory;
        private Telerik.WinControls.UI.RadButton btnOrder;
        private Telerik.WinControls.UI.RadButton btnDashboard;
        private Telerik.WinControls.UI.RadButton btnLogOut;
        private Telerik.WinControls.UI.RadButton btnCollapse;
        private Telerik.WinControls.UI.RadPanel panHeader;
        private Telerik.WinControls.UI.RadPanel panContent;
        private Telerik.WinControls.UI.RadLabel lblTitle;
        private System.Windows.Forms.Button button1;
    }
}

