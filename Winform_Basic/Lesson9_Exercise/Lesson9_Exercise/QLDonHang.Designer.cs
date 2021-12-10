
namespace Lesson9_Exercise
{
    partial class QLDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.order = new System.Windows.Forms.Button();
            this.printOrder = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrderInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(483, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày đặt hàng";
            // 
            // orderDate
            // 
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate.Location = new System.Drawing.Point(382, 135);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 20);
            this.orderDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày giao hàng";
            // 
            // deliveryDate
            // 
            this.deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deliveryDate.Location = new System.Drawing.Point(732, 142);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(200, 20);
            this.deliveryDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(368, 186);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(564, 68);
            this.txtNote.TabIndex = 8;
            this.txtNote.Text = "";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(160, 583);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(104, 23);
            this.order.TabIndex = 14;
            this.order.Text = "Đặt hàng";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // printOrder
            // 
            this.printOrder.Location = new System.Drawing.Point(57, 583);
            this.printOrder.Name = "printOrder";
            this.printOrder.Size = new System.Drawing.Size(75, 23);
            this.printOrder.TabIndex = 13;
            this.printOrder.Text = "In";
            this.printOrder.UseVisualStyleBackColor = true;
            this.printOrder.Click += new System.EventHandler(this.printOrder_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(875, 583);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(204, 20);
            this.txtTotalPrice.TabIndex = 16;
            this.txtTotalPrice.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng cộng:";
            // 
            // dgvOrderInfo
            // 
            this.dgvOrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderInfo.Location = new System.Drawing.Point(57, 303);
            this.dgvOrderInfo.Name = "dgvOrderInfo";
            this.dgvOrderInfo.Size = new System.Drawing.Size(1022, 229);
            this.dgvOrderInfo.TabIndex = 17;
            this.dgvOrderInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderInfo_CellEndEdit);
            this.dgvOrderInfo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvOrderInfo_EditingControlShowing);
            // 
            // QLDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 649);
            this.Controls.Add(this.dgvOrderInfo);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.order);
            this.Controls.Add(this.printOrder);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "QLDonHang";
            this.Text = "QLDonHang";
            this.Load += new System.EventHandler(this.QLDonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deliveryDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button printOrder;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrderInfo;
    }
}