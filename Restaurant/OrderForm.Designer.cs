namespace Restaurant
{
    partial class OrderForm
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
            this.cbMenus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnClearMenus = new System.Windows.Forms.Button();
            this.btnRemoveMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMenus
            // 
            this.cbMenus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbMenus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMenus.FormattingEnabled = true;
            this.cbMenus.Location = new System.Drawing.Point(55, 6);
            this.cbMenus.Name = "cbMenus";
            this.cbMenus.Size = new System.Drawing.Size(217, 21);
            this.cbMenus.TabIndex = 0;
            this.cbMenus.SelectedIndexChanged += new System.EventHandler(this.cbMenus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu:";
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Enabled = false;
            this.btnAddMenu.Location = new System.Drawing.Point(278, 5);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(83, 23);
            this.btnAddMenu.TabIndex = 2;
            this.btnAddMenu.Text = "Add";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(12, 37);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(260, 238);
            this.lstOrder.TabIndex = 3;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // btnClearMenus
            // 
            this.btnClearMenus.Location = new System.Drawing.Point(278, 252);
            this.btnClearMenus.Name = "btnClearMenus";
            this.btnClearMenus.Size = new System.Drawing.Size(83, 23);
            this.btnClearMenus.TabIndex = 4;
            this.btnClearMenus.Text = "Clear";
            this.btnClearMenus.UseVisualStyleBackColor = true;
            this.btnClearMenus.Click += new System.EventHandler(this.btnClearMenus_Click);
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.Enabled = false;
            this.btnRemoveMenu.Location = new System.Drawing.Point(279, 37);
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.Size = new System.Drawing.Size(82, 23);
            this.btnRemoveMenu.TabIndex = 5;
            this.btnRemoveMenu.Text = "Remove";
            this.btnRemoveMenu.UseVisualStyleBackColor = true;
            this.btnRemoveMenu.Click += new System.EventHandler(this.btnRemoveMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Totalprice:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(76, 277);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "0";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 302);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveMenu);
            this.Controls.Add(this.btnClearMenus);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.btnAddMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMenus);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMenus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnClearMenus;
        private System.Windows.Forms.Button btnRemoveMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

