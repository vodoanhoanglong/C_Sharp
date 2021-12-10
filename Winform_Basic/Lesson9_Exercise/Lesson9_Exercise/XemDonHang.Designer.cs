
namespace Lesson9_Exercise
{
    partial class XemDonHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dgvOrderView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.addOrder = new System.Windows.Forms.Button();
            this.viewOrder = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.deliveryDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.orderDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDate);
            this.groupBox1.Location = new System.Drawing.Point(62, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // deliveryDate
            // 
            this.deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDate.Location = new System.Drawing.Point(414, 78);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(214, 20);
            this.deliveryDate.TabIndex = 4;
            this.deliveryDate.ValueChanged += new System.EventHandler(this.deliveryDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // orderDate
            // 
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate.Location = new System.Drawing.Point(144, 78);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 20);
            this.orderDate.TabIndex = 2;
            this.orderDate.ValueChanged += new System.EventHandler(this.orderDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian giao hàng";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(16, 42);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(134, 17);
            this.cbDate.TabIndex = 0;
            this.cbDate.Text = "Xem tất cả trong tháng";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.cbDate_CheckedChanged);
            // 
            // dgvOrderView
            // 
            this.dgvOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderView.Location = new System.Drawing.Point(62, 230);
            this.dgvOrderView.Name = "dgvOrderView";
            this.dgvOrderView.Size = new System.Drawing.Size(955, 288);
            this.dgvOrderView.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(430, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "XEM ĐƠN HÀNG";
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(170, 553);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(104, 23);
            this.addOrder.TabIndex = 9;
            this.addOrder.Text = "Thêm Đơn Hàng";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // viewOrder
            // 
            this.viewOrder.Location = new System.Drawing.Point(62, 553);
            this.viewOrder.Name = "viewOrder";
            this.viewOrder.Size = new System.Drawing.Size(75, 23);
            this.viewOrder.TabIndex = 10;
            this.viewOrder.Text = "In / Xem";
            this.viewOrder.UseVisualStyleBackColor = true;
            this.viewOrder.Click += new System.EventHandler(this.viewOrder_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(813, 553);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(204, 20);
            this.totalPrice.TabIndex = 12;
            this.totalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tổng cộng:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(833, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // XemDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 620);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.viewOrder);
            this.Controls.Add(this.addOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvOrderView);
            this.Controls.Add(this.groupBox1);
            this.Name = "XemDonHang";
            this.Text = "XemDonHang";
            this.Load += new System.EventHandler(this.XemDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker deliveryDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DataGridView dgvOrderView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button viewOrder;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
    }
}