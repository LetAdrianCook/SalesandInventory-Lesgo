namespace SalesandInventory
{
    partial class InventoryDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryDashboard));
            dashPanel = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            exitBtn = new Button();
            sessionType = new Label();
            pictureBox2 = new PictureBox();
            sessionName = new Label();
            panel1 = new Panel();
            userBtn = new Button();
            logoutBtn = new Button();
            supplierBtn = new Button();
            inventoryBtn = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dashPanel
            // 
            dashPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashPanel.BackColor = Color.White;
            dashPanel.Dock = DockStyle.Fill;
            dashPanel.Location = new Point(216, 56);
            dashPanel.Margin = new Padding(2);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(968, 635);
            dashPanel.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(exitBtn);
            panel3.Controls.Add(sessionType);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(sessionName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(216, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 56);
            panel3.TabIndex = 9;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = SystemColors.Control;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(910, 9);
            exitBtn.Margin = new Padding(2);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(43, 38);
            exitBtn.TabIndex = 3;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // sessionType
            // 
            sessionType.AutoSize = true;
            sessionType.Font = new Font("Arial", 10F);
            sessionType.Location = new Point(720, 32);
            sessionType.Margin = new Padding(2, 0, 2, 0);
            sessionType.Name = "sessionType";
            sessionType.Size = new Size(131, 16);
            sessionType.TabIndex = 2;
            sessionType.Text = "Inventory Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(859, 9);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // sessionName
            // 
            sessionName.AutoSize = true;
            sessionName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sessionName.Location = new Point(769, 9);
            sessionName.Margin = new Padding(2, 0, 2, 0);
            sessionName.Name = "sessionName";
            sessionName.Size = new Size(76, 18);
            sessionName.TabIndex = 2;
            sessionName.Text = "Jane Doe";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(userBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(supplierBtn);
            panel1.Controls.Add(inventoryBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 691);
            panel1.TabIndex = 8;
            // 
            // userBtn
            // 
            userBtn.Dock = DockStyle.Top;
            userBtn.FlatAppearance.BorderSize = 0;
            userBtn.FlatStyle = FlatStyle.Flat;
            userBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            userBtn.Image = Properties.Resources.icons8_add_administrator_30;
            userBtn.ImageAlign = ContentAlignment.MiddleLeft;
            userBtn.Location = new Point(0, 166);
            userBtn.Margin = new Padding(2);
            userBtn.Name = "userBtn";
            userBtn.Padding = new Padding(14, 0, 0, 0);
            userBtn.Size = new Size(216, 38);
            userBtn.TabIndex = 5;
            userBtn.Text = "User Profile";
            userBtn.TextAlign = ContentAlignment.MiddleLeft;
            userBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userBtn.UseVisualStyleBackColor = true;
            userBtn.Click += userBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            logoutBtn.Image = Properties.Resources.icons8_logout_30;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 653);
            logoutBtn.Margin = new Padding(2);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(14, 0, 0, 0);
            logoutBtn.Size = new Size(216, 38);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // supplierBtn
            // 
            supplierBtn.Dock = DockStyle.Top;
            supplierBtn.FlatAppearance.BorderSize = 0;
            supplierBtn.FlatStyle = FlatStyle.Flat;
            supplierBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            supplierBtn.Image = Properties.Resources.icons8_sales_30;
            supplierBtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplierBtn.Location = new Point(0, 128);
            supplierBtn.Margin = new Padding(2);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Padding = new Padding(14, 0, 0, 0);
            supplierBtn.Size = new Size(216, 38);
            supplierBtn.TabIndex = 3;
            supplierBtn.Text = "Add Supplier";
            supplierBtn.TextAlign = ContentAlignment.MiddleLeft;
            supplierBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            supplierBtn.UseVisualStyleBackColor = true;
            supplierBtn.Click += supplierBtn_Click;
            // 
            // inventoryBtn
            // 
            inventoryBtn.Dock = DockStyle.Top;
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inventoryBtn.Image = Properties.Resources.icons8_inventory_30;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(0, 90);
            inventoryBtn.Margin = new Padding(2);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Padding = new Padding(14, 0, 0, 0);
            inventoryBtn.Size = new Size(216, 38);
            inventoryBtn.TabIndex = 1;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.AutoSize = true;
            panelLogo.BackColor = SystemColors.ActiveCaption;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(216, 90);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // InventoryDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 691);
            Controls.Add(dashPanel);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "InventoryDashboard";
            Text = "InventoryDashboard";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel dashPanel;
        private Label label2;
        private Panel panel3;
        private Button exitBtn;
        private Label sessionType;
        private PictureBox pictureBox2;
        private Label sessionName;
        private Panel panel1;
        private Button userBtn;
        private Button logoutBtn;
        private Button supplierBtn;
        private Button inventoryBtn;
        private Panel panelLogo;
        private PictureBox pictureBox1;
    }
}