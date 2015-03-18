namespace FoodlyApp
{
    partial class rtbx_address
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
            this.lv_orders = new System.Windows.Forms.ListView();
            this.b_mainLoad = new System.Windows.Forms.Button();
            this.b_deleteProcessed = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.tbx_nameSurename = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.rtb_address = new System.Windows.Forms.RichTextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_switchPanels = new System.Windows.Forms.Button();
            this.lv_receipt = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_orders
            // 
            this.lv_orders.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lv_orders.Location = new System.Drawing.Point(12, 12);
            this.lv_orders.MultiSelect = false;
            this.lv_orders.Name = "lv_orders";
            this.lv_orders.Size = new System.Drawing.Size(325, 317);
            this.lv_orders.TabIndex = 0;
            this.lv_orders.UseCompatibleStateImageBehavior = false;
            this.lv_orders.View = System.Windows.Forms.View.List;
            this.lv_orders.SelectedIndexChanged += new System.EventHandler(this.lv_orders_SelectedIndexChanged);
            // 
            // b_mainLoad
            // 
            this.b_mainLoad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_mainLoad.Location = new System.Drawing.Point(12, 335);
            this.b_mainLoad.Name = "b_mainLoad";
            this.b_mainLoad.Size = new System.Drawing.Size(156, 43);
            this.b_mainLoad.TabIndex = 1;
            this.b_mainLoad.Text = "Load Orders From The Database";
            this.b_mainLoad.UseVisualStyleBackColor = true;
            this.b_mainLoad.Click += new System.EventHandler(this.b_mainLoad_Click);
            // 
            // b_deleteProcessed
            // 
            this.b_deleteProcessed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_deleteProcessed.Location = new System.Drawing.Point(174, 335);
            this.b_deleteProcessed.Name = "b_deleteProcessed";
            this.b_deleteProcessed.Size = new System.Drawing.Size(163, 43);
            this.b_deleteProcessed.TabIndex = 3;
            this.b_deleteProcessed.Text = "Delete Processed Orders";
            this.b_deleteProcessed.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(789, 517);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(83, 33);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbx_nameSurename
            // 
            this.tbx_nameSurename.Location = new System.Drawing.Point(100, 27);
            this.tbx_nameSurename.Name = "tbx_nameSurename";
            this.tbx_nameSurename.ReadOnly = true;
            this.tbx_nameSurename.Size = new System.Drawing.Size(208, 23);
            this.tbx_nameSurename.TabIndex = 5;
            // 
            // tbx_phone
            // 
            this.tbx_phone.Location = new System.Drawing.Point(100, 116);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.ReadOnly = true;
            this.tbx_phone.Size = new System.Drawing.Size(208, 23);
            this.tbx_phone.TabIndex = 6;
            // 
            // rtb_address
            // 
            this.rtb_address.Location = new System.Drawing.Point(100, 64);
            this.rtb_address.Name = "rtb_address";
            this.rtb_address.ReadOnly = true;
            this.rtb_address.Size = new System.Drawing.Size(208, 39);
            this.rtb_address.TabIndex = 7;
            this.rtb_address.Text = "";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(55, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Phone number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_phone);
            this.groupBox1.Controls.Add(this.rtb_address);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_nameSurename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer details";
            // 
            // b_switchPanels
            // 
            this.b_switchPanels.Location = new System.Drawing.Point(650, 517);
            this.b_switchPanels.Name = "b_switchPanels";
            this.b_switchPanels.Size = new System.Drawing.Size(133, 33);
            this.b_switchPanels.TabIndex = 13;
            this.b_switchPanels.Text = "Show order details";
            this.b_switchPanels.UseVisualStyleBackColor = true;
            // 
            // lv_receipt
            // 
            this.lv_receipt.Location = new System.Drawing.Point(6, 22);
            this.lv_receipt.Name = "lv_receipt";
            this.lv_receipt.Size = new System.Drawing.Size(476, 236);
            this.lv_receipt.TabIndex = 14;
            this.lv_receipt.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_totalPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lv_receipt);
            this.groupBox2.Location = new System.Drawing.Point(384, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 290);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receipt";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(392, 263);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(36, 20);
            this.lbl_totalPrice.TabIndex = 16;
            this.lbl_totalPrice.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(299, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total price:";
            // 
            // rtbx_address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b_switchPanels);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.b_deleteProcessed);
            this.Controls.Add(this.b_mainLoad);
            this.Controls.Add(this.lv_orders);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "rtbx_address";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Foodly - Main Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_orders;
        private System.Windows.Forms.Button b_mainLoad;
        private System.Windows.Forms.Button b_deleteProcessed;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox tbx_nameSurename;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.RichTextBox rtb_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_switchPanels;
        private System.Windows.Forms.ListView lv_receipt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label label3;
    }
}