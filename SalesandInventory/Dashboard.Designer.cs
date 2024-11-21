namespace SalesandInventory
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            reportBtn = new Button();
            supplierBtn = new Button();
            createBtn = new Button();
            logoutBtn = new Button();
            inventoryBtn = new Button();
            dbBtn = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            exitBtn = new Button();
            sessionType = new Label();
            pictureBox2 = new PictureBox();
            sessionName = new Label();
            label2 = new Label();
            dashPanel = new Panel();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(reportBtn);
            panel1.Controls.Add(supplierBtn);
            panel1.Controls.Add(createBtn);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(inventoryBtn);
            panel1.Controls.Add(dbBtn);
            panel1.Controls.Add(panelLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 3, 2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 902);
            panel1.TabIndex = 0;
            // 
            // reportBtn
            // 
            reportBtn.Dock = DockStyle.Top;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportBtn.Image = Properties.Resources.icons8_inventory_30;
            reportBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reportBtn.Location = new Point(0, 323);
            reportBtn.Margin = new Padding(2, 3, 2, 3);
            reportBtn.Name = "reportBtn";
            reportBtn.Padding = new Padding(16, 0, 0, 0);
            reportBtn.Size = new Size(247, 51);
            reportBtn.TabIndex = 7;
            reportBtn.Text = "Report";
            reportBtn.TextAlign = ContentAlignment.MiddleLeft;
            reportBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            reportBtn.UseVisualStyleBackColor = true;
            reportBtn.Click += reportBtn_Click;
            // 
            // supplierBtn
            // 
            supplierBtn.Dock = DockStyle.Top;
            supplierBtn.FlatAppearance.BorderSize = 0;
            supplierBtn.FlatStyle = FlatStyle.Flat;
            supplierBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            supplierBtn.Image = Properties.Resources.icons8_add_administrator_30;
            supplierBtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplierBtn.Location = new Point(0, 272);
            supplierBtn.Margin = new Padding(2, 3, 2, 3);
            supplierBtn.Name = "supplierBtn";
            supplierBtn.Padding = new Padding(16, 0, 0, 0);
            supplierBtn.Size = new Size(247, 51);
            supplierBtn.TabIndex = 6;
            supplierBtn.Text = "Supplier Management";
            supplierBtn.TextAlign = ContentAlignment.MiddleLeft;
            supplierBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            supplierBtn.UseVisualStyleBackColor = true;
            supplierBtn.Click += supplierBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Dock = DockStyle.Top;
            createBtn.FlatAppearance.BorderSize = 0;
            createBtn.FlatStyle = FlatStyle.Flat;
            createBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            createBtn.Image = Properties.Resources.icons8_add_administrator_30;
            createBtn.ImageAlign = ContentAlignment.MiddleLeft;
            createBtn.Location = new Point(0, 221);
            createBtn.Margin = new Padding(2, 3, 2, 3);
            createBtn.Name = "createBtn";
            createBtn.Padding = new Padding(16, 0, 0, 0);
            createBtn.Size = new Size(247, 51);
            createBtn.TabIndex = 5;
            createBtn.Text = "User Management";
            createBtn.TextAlign = ContentAlignment.MiddleLeft;
            createBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click_1;
            // 
            // logoutBtn
            // 
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            logoutBtn.Image = Properties.Resources.icons8_logout_30;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 851);
            logoutBtn.Margin = new Padding(2, 3, 2, 3);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(16, 0, 0, 0);
            logoutBtn.Size = new Size(247, 51);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // inventoryBtn
            // 
            inventoryBtn.Dock = DockStyle.Top;
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            inventoryBtn.Image = Properties.Resources.icons8_inventory_30;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(0, 170);
            inventoryBtn.Margin = new Padding(2, 3, 2, 3);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Padding = new Padding(16, 0, 0, 0);
            inventoryBtn.Size = new Size(247, 51);
            inventoryBtn.TabIndex = 2;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // dbBtn
            // 
            dbBtn.Dock = DockStyle.Top;
            dbBtn.FlatAppearance.BorderSize = 0;
            dbBtn.FlatStyle = FlatStyle.Flat;
            dbBtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dbBtn.Image = Properties.Resources.icons8_inventory_30;
            dbBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dbBtn.Location = new Point(0, 119);
            dbBtn.Margin = new Padding(2, 3, 2, 3);
            dbBtn.Name = "dbBtn";
            dbBtn.Padding = new Padding(16, 0, 0, 0);
            dbBtn.Size = new Size(247, 51);
            dbBtn.TabIndex = 1;
            dbBtn.Text = "Dashboard";
            dbBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dbBtn.UseVisualStyleBackColor = true;
            dbBtn.Click += dbBtn_Click;
            // 
            // panelLogo
            // 
            panelLogo.AutoSize = true;
            panelLogo.BackColor = SystemColors.ActiveCaption;
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2, 3, 2, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 119);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 3);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(exitBtn);
            panel3.Controls.Add(sessionType);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(sessionName);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(247, 0);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1106, 75);
            panel3.TabIndex = 1;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.ForeColor = SystemColors.Control;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(1040, 12);
            exitBtn.Margin = new Padding(2, 3, 2, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(49, 51);
            exitBtn.TabIndex = 3;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // sessionType
            // 
            sessionType.AutoSize = true;
            sessionType.Font = new Font("Arial", 10F);
            sessionType.Location = new Point(913, 41);
            sessionType.Margin = new Padding(2, 0, 2, 0);
            sessionType.Name = "sessionType";
            sessionType.Size = new Size(55, 19);
            sessionType.TabIndex = 2;
            sessionType.Text = "Admin";
            sessionType.Click += sessionType_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(982, 12);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // sessionName
            // 
            sessionName.AutoSize = true;
            sessionName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sessionName.Location = new Point(879, 12);
            sessionName.Margin = new Padding(2, 0, 2, 0);
            sessionName.Name = "sessionName";
            sessionName.Size = new Size(94, 23);
            sessionName.TabIndex = 2;
            sessionName.Text = "Jane Doe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(353, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // dashPanel
            // 
            dashPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashPanel.BackColor = Color.White;
            dashPanel.Dock = DockStyle.Fill;
            dashPanel.Location = new Point(247, 75);
            dashPanel.Margin = new Padding(2, 3, 2, 3);
            dashPanel.Name = "dashPanel";
            dashPanel.Size = new Size(1106, 827);
            dashPanel.TabIndex = 3;
            dashPanel.Paint += dashPanel_Paint;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1353, 902);
            Controls.Add(dashPanel);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button dbBtn;
        private Panel panelLogo;
        private Button logoutBtn;
        private Button inventoryBtn;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label2;
        private Panel dashPanel;
        private Label sessionName;
        private PictureBox pictureBox2;
        private Label sessionType;
        private Button exitBtn;
        private Button createBtn;
        private Button reportBtn;
        private Button supplierBtn;
    }
}