
namespace Lesson9_Exercise
{
    partial class ContainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoGiáSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.đơnHàngToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpĐơnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đơnHàngToolStripMenuItem.Text = "Đơn Hàng";
            // 
            // nhậpĐơnToolStripMenuItem
            // 
            this.nhậpĐơnToolStripMenuItem.Name = "nhậpĐơnToolStripMenuItem";
            this.nhậpĐơnToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nhậpĐơnToolStripMenuItem.Text = "Nhập Đơn Hàng";
            this.nhậpĐơnToolStripMenuItem.Click += new System.EventHandler(this.nhậpĐơnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnToolStripMenuItem,
            this.xuấtBáoGiáSảnPhẩmToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // quảnLýSảnToolStripMenuItem
            // 
            this.quảnLýSảnToolStripMenuItem.Name = "quảnLýSảnToolStripMenuItem";
            this.quảnLýSảnToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.quảnLýSảnToolStripMenuItem.Text = "Quản Lý Sản Phẩm";
            this.quảnLýSảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnToolStripMenuItem_Click);
            // 
            // xuấtBáoGiáSảnPhẩmToolStripMenuItem
            // 
            this.xuấtBáoGiáSảnPhẩmToolStripMenuItem.Name = "xuấtBáoGiáSảnPhẩmToolStripMenuItem";
            this.xuấtBáoGiáSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.xuấtBáoGiáSảnPhẩmToolStripMenuItem.Text = "Xuất Báo Giá Sản Phẩm";
            this.xuấtBáoGiáSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoGiáSảnPhẩmToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(43, 78);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1170, 703);
            this.pnlMenu.TabIndex = 1;
            // 
            // ContainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 894);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContainMenu";
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoGiáSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
    }
}