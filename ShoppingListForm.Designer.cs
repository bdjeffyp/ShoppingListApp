namespace ShoppingListApp
{
    partial class ShoppingListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMasterList = new System.Windows.Forms.TabPage();
            this.panelCategories = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddToTrip = new System.Windows.Forms.Button();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tabShoppingTrips = new System.Windows.Forms.TabPage();
            this.btnAddFromMaster = new System.Windows.Forms.Button();
            this.btnDeleteItemFromTrip = new System.Windows.Forms.Button();
            this.btnManualAdd = new System.Windows.Forms.Button();
            this.btnAddToMaster = new System.Windows.Forms.Button();
            this.btnDeleteTrip = new System.Windows.Forms.Button();
            this.btnCreateNewTrip = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabRecipies = new System.Windows.Forms.TabPage();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMasterList.SuspendLayout();
            this.panelCategories.SuspendLayout();
            this.tabShoppingTrips.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMasterList);
            this.tabControl1.Controls.Add(this.tabShoppingTrips);
            this.tabControl1.Controls.Add(this.tabRecipies);
            this.tabControl1.Controls.Add(this.tabHelp);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMasterList
            // 
            this.tabMasterList.Controls.Add(this.panelCategories);
            this.tabMasterList.Controls.Add(this.btnAddToTrip);
            this.tabMasterList.Controls.Add(this.btnDeleteItems);
            this.tabMasterList.Controls.Add(this.btnAddItem);
            this.tabMasterList.Controls.Add(this.labelStatus);
            this.tabMasterList.Location = new System.Drawing.Point(4, 22);
            this.tabMasterList.Name = "tabMasterList";
            this.tabMasterList.Padding = new System.Windows.Forms.Padding(3);
            this.tabMasterList.Size = new System.Drawing.Size(504, 522);
            this.tabMasterList.TabIndex = 0;
            this.tabMasterList.Text = "Master List";
            this.tabMasterList.ToolTipText = "This Master Shopping List contains all of the commonly purchased items to quickly" +
    " add to future shopping trips";
            this.tabMasterList.UseVisualStyleBackColor = true;
            // 
            // panelCategories
            // 
            this.panelCategories.AutoScroll = true;
            this.panelCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCategories.Controls.Add(this.listBox3);
            this.panelCategories.Controls.Add(this.label4);
            this.panelCategories.Controls.Add(this.listBox2);
            this.panelCategories.Controls.Add(this.label3);
            this.panelCategories.Controls.Add(this.listBox1);
            this.panelCategories.Controls.Add(this.label2);
            this.panelCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCategories.Location = new System.Drawing.Point(7, 34);
            this.panelCategories.Name = "panelCategories";
            this.panelCategories.Size = new System.Drawing.Size(491, 447);
            this.panelCategories.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 21;
            this.listBox3.Location = new System.Drawing.Point(4, 349);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(467, 130);
            this.listBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category 3: Fruit";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 21;
            this.listBox2.Location = new System.Drawing.Point(4, 187);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(467, 130);
            this.listBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category 2: Vegetables";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(4, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(467, 130);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category 1: Beverages";
            // 
            // btnAddToTrip
            // 
            this.btnAddToTrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToTrip.Location = new System.Drawing.Point(331, 487);
            this.btnAddToTrip.Name = "btnAddToTrip";
            this.btnAddToTrip.Size = new System.Drawing.Size(167, 29);
            this.btnAddToTrip.TabIndex = 0;
            this.btnAddToTrip.Text = "Add to Shopping Trip";
            this.btnAddToTrip.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItems.Location = new System.Drawing.Point(170, 487);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(143, 29);
            this.btnDeleteItems.TabIndex = 2;
            this.btnDeleteItems.Text = "Delete Items";
            this.btnDeleteItems.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(7, 487);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(143, 29);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(7, 7);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(491, 23);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status label: starts invisible and appears briefly with updates";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabShoppingTrips
            // 
            this.tabShoppingTrips.Controls.Add(this.btnAddFromMaster);
            this.tabShoppingTrips.Controls.Add(this.btnDeleteItemFromTrip);
            this.tabShoppingTrips.Controls.Add(this.btnManualAdd);
            this.tabShoppingTrips.Controls.Add(this.btnAddToMaster);
            this.tabShoppingTrips.Controls.Add(this.btnDeleteTrip);
            this.tabShoppingTrips.Controls.Add(this.btnCreateNewTrip);
            this.tabShoppingTrips.Controls.Add(this.panel1);
            this.tabShoppingTrips.Controls.Add(this.comboBox1);
            this.tabShoppingTrips.Controls.Add(this.label5);
            this.tabShoppingTrips.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabShoppingTrips.Location = new System.Drawing.Point(4, 22);
            this.tabShoppingTrips.Name = "tabShoppingTrips";
            this.tabShoppingTrips.Padding = new System.Windows.Forms.Padding(3);
            this.tabShoppingTrips.Size = new System.Drawing.Size(504, 522);
            this.tabShoppingTrips.TabIndex = 1;
            this.tabShoppingTrips.Text = " Shopping Trips";
            this.tabShoppingTrips.UseVisualStyleBackColor = true;
            // 
            // btnAddFromMaster
            // 
            this.btnAddFromMaster.Location = new System.Drawing.Point(286, 446);
            this.btnAddFromMaster.Name = "btnAddFromMaster";
            this.btnAddFromMaster.Size = new System.Drawing.Size(150, 32);
            this.btnAddFromMaster.TabIndex = 8;
            this.btnAddFromMaster.Text = "Add from Master";
            this.btnAddFromMaster.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItemFromTrip
            // 
            this.btnDeleteItemFromTrip.Location = new System.Drawing.Point(286, 408);
            this.btnDeleteItemFromTrip.Name = "btnDeleteItemFromTrip";
            this.btnDeleteItemFromTrip.Size = new System.Drawing.Size(150, 32);
            this.btnDeleteItemFromTrip.TabIndex = 7;
            this.btnDeleteItemFromTrip.Text = "Delete Item";
            this.btnDeleteItemFromTrip.UseVisualStyleBackColor = true;
            // 
            // btnManualAdd
            // 
            this.btnManualAdd.Location = new System.Drawing.Point(69, 408);
            this.btnManualAdd.Name = "btnManualAdd";
            this.btnManualAdd.Size = new System.Drawing.Size(150, 32);
            this.btnManualAdd.TabIndex = 6;
            this.btnManualAdd.Text = "Manually Add";
            this.btnManualAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddToMaster
            // 
            this.btnAddToMaster.Location = new System.Drawing.Point(69, 446);
            this.btnAddToMaster.Name = "btnAddToMaster";
            this.btnAddToMaster.Size = new System.Drawing.Size(150, 32);
            this.btnAddToMaster.TabIndex = 5;
            this.btnAddToMaster.Text = "Add to Master";
            this.btnAddToMaster.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTrip
            // 
            this.btnDeleteTrip.Location = new System.Drawing.Point(347, 484);
            this.btnDeleteTrip.Name = "btnDeleteTrip";
            this.btnDeleteTrip.Size = new System.Drawing.Size(151, 32);
            this.btnDeleteTrip.TabIndex = 4;
            this.btnDeleteTrip.Text = "Delete Trip";
            this.btnDeleteTrip.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewTrip
            // 
            this.btnCreateNewTrip.Location = new System.Drawing.Point(6, 484);
            this.btnCreateNewTrip.Name = "btnCreateNewTrip";
            this.btnCreateNewTrip.Size = new System.Drawing.Size(151, 32);
            this.btnCreateNewTrip.TabIndex = 3;
            this.btnCreateNewTrip.Text = "Create New Trip";
            this.btnCreateNewTrip.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.listBox5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.listBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(6, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 360);
            this.panel1.TabIndex = 2;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 21;
            this.listBox6.Location = new System.Drawing.Point(4, 352);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(466, 130);
            this.listBox6.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "Category 3: Fruit";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 21;
            this.listBox5.Location = new System.Drawing.Point(4, 191);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(466, 130);
            this.listBox5.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Category 2: Vegetables";
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 21;
            this.listBox4.Location = new System.Drawing.Point(4, 29);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(466, 130);
            this.listBox4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Category 1: Beverages";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(375, 29);
            this.comboBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Shopping Trip:";
            // 
            // tabRecipies
            // 
            this.tabRecipies.Location = new System.Drawing.Point(4, 22);
            this.tabRecipies.Name = "tabRecipies";
            this.tabRecipies.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecipies.Size = new System.Drawing.Size(504, 522);
            this.tabRecipies.TabIndex = 2;
            this.tabRecipies.Text = "Recipies";
            this.tabRecipies.UseVisualStyleBackColor = true;
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.btnAbout);
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabHelp.Size = new System.Drawing.Size(504, 522);
            this.tabHelp.TabIndex = 3;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // btnAbout
            // 
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(7, 486);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(83, 30);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // ShoppingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 573);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShoppingListForm";
            this.Text = "Shopping Trips";
            this.tabControl1.ResumeLayout(false);
            this.tabMasterList.ResumeLayout(false);
            this.panelCategories.ResumeLayout(false);
            this.panelCategories.PerformLayout();
            this.tabShoppingTrips.ResumeLayout(false);
            this.tabShoppingTrips.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMasterList;
        private System.Windows.Forms.TabPage tabShoppingTrips;
        private System.Windows.Forms.Button btnAddToTrip;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TabPage tabRecipies;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.Panel panelCategories;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFromMaster;
        private System.Windows.Forms.Button btnDeleteItemFromTrip;
        private System.Windows.Forms.Button btnManualAdd;
        private System.Windows.Forms.Button btnAddToMaster;
        private System.Windows.Forms.Button btnDeleteTrip;
        private System.Windows.Forms.Button btnCreateNewTrip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAbout;
    }
}

