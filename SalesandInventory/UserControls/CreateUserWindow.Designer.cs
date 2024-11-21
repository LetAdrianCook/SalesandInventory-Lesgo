namespace SalesandInventory.UserControls
{
    partial class CreateUserWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox4 = new GroupBox();
            groupBox8 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            crePassword = new TextBox();
            creUsername = new TextBox();
            groupBox3 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            creFirstname = new TextBox();
            groupBox1 = new GroupBox();
            invType = new RadioButton();
            salesType = new RadioButton();
            pictureBox2 = new PictureBox();
            userGridView = new DataGridView();
            groupBox5 = new GroupBox();
            rjButton1 = new RJControls.RJButton();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            pictureBox7 = new PictureBox();
            textBox4 = new TextBox();
            groupBox6 = new GroupBox();
            rjButton2 = new RJControls.RJButton();
            pictureBox3 = new PictureBox();
            textBox5 = new TextBox();
            groupBox7 = new GroupBox();
            textBox9 = new TextBox();
            label4 = new Label();
            button4 = new Button();
            rjButton3 = new RJControls.RJButton();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userGridView).BeginInit();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.InactiveCaption;
            groupBox4.Controls.Add(rjButton3);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox3);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Location = new Point(12, 13);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(502, 394);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = SystemColors.InactiveCaption;
            groupBox8.Controls.Add(pictureBox1);
            groupBox8.Controls.Add(pictureBox4);
            groupBox8.Controls.Add(crePassword);
            groupBox8.Controls.Add(creUsername);
            groupBox8.Font = new Font("Arial", 14F, FontStyle.Bold);
            groupBox8.Location = new Point(22, 14);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(287, 135);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Account Information";
            groupBox8.Enter += groupBox8_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_user_30;
            pictureBox1.Location = new Point(20, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_password_24;
            pictureBox4.Location = new Point(20, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 35);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // crePassword
            // 
            crePassword.BorderStyle = BorderStyle.FixedSingle;
            crePassword.Font = new Font("Arial", 15F);
            crePassword.Location = new Point(70, 77);
            crePassword.Multiline = true;
            crePassword.Name = "crePassword";
            crePassword.PlaceholderText = "Enter Password";
            crePassword.Size = new Size(193, 33);
            crePassword.TabIndex = 1;
            // 
            // creUsername
            // 
            creUsername.BorderStyle = BorderStyle.FixedSingle;
            creUsername.Font = new Font("Arial", 15F);
            creUsername.Location = new Point(70, 36);
            creUsername.Multiline = true;
            creUsername.Name = "creUsername";
            creUsername.PlaceholderText = "Enter Username";
            creUsername.Size = new Size(193, 31);
            creUsername.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox7);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(creFirstname);
            groupBox3.Font = new Font("Arial", 14F, FontStyle.Bold);
            groupBox3.Location = new Point(22, 170);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 162);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Personal Information";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Arial", 13F);
            textBox7.Location = new Point(149, 110);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(274, 29);
            textBox7.TabIndex = 36;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Arial", 13F);
            textBox6.Location = new Point(149, 69);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 29);
            textBox6.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13F);
            label3.Location = new Point(20, 118);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13F);
            label2.Location = new Point(20, 77);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 2;
            label2.Text = "Middle Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13F);
            label1.Location = new Point(20, 36);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // creFirstname
            // 
            creFirstname.BorderStyle = BorderStyle.FixedSingle;
            creFirstname.Font = new Font("Arial", 13F);
            creFirstname.Location = new Point(149, 28);
            creFirstname.Multiline = true;
            creFirstname.Name = "creFirstname";
            creFirstname.Size = new Size(274, 29);
            creFirstname.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveCaption;
            groupBox1.Controls.Add(invType);
            groupBox1.Controls.Add(salesType);
            groupBox1.Font = new Font("Arial", 14F, FontStyle.Bold);
            groupBox1.Location = new Point(324, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 3);
            groupBox1.Size = new Size(159, 135);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Type";
            // 
            // invType
            // 
            invType.AutoSize = true;
            invType.Font = new Font("Arial", 13F);
            invType.Location = new Point(20, 77);
            invType.Name = "invType";
            invType.Size = new Size(101, 25);
            invType.TabIndex = 5;
            invType.TabStop = true;
            invType.Text = "Inventory";
            invType.UseVisualStyleBackColor = true;
            invType.CheckedChanged += invType_CheckedChanged;
            // 
            // salesType
            // 
            salesType.AutoSize = true;
            salesType.Font = new Font("Arial", 13F);
            salesType.Location = new Point(20, 37);
            salesType.Name = "salesType";
            salesType.Size = new Size(73, 25);
            salesType.TabIndex = 5;
            salesType.TabStop = true;
            salesType.Text = "Sales";
            salesType.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_24;
            pictureBox2.Location = new Point(20, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // userGridView
            // 
            userGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            userGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            userGridView.BackgroundColor = SystemColors.Control;
            userGridView.BorderStyle = BorderStyle.None;
            userGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userGridView.Location = new Point(531, 13);
            userGridView.Name = "userGridView";
            userGridView.RowHeadersWidth = 62;
            userGridView.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userGridView.Size = new Size(422, 442);
            userGridView.TabIndex = 14;
            userGridView.CellContentClick += userGridView_CellContentClick;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.ControlDark;
            groupBox5.Controls.Add(rjButton1);
            groupBox5.Controls.Add(groupBox2);
            groupBox5.Controls.Add(pictureBox7);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Location = new Point(12, 413);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(502, 213);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = SystemColors.ControlText;
            rjButton1.BackgroundColor = SystemColors.ControlText;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Arial", 10F);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(22, 171);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(461, 30);
            rjButton1.TabIndex = 35;
            rjButton1.Text = "Update";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Font = new Font("Arial", 14F, FontStyle.Bold);
            groupBox2.Location = new Point(22, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(461, 147);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Update Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 13F);
            label7.Location = new Point(20, 118);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 3;
            label7.Text = "Last Name:";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 13F);
            label5.Location = new Point(20, 77);
            label5.Name = "label5";
            label5.Size = new Size(120, 21);
            label5.TabIndex = 2;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13F);
            label6.Location = new Point(20, 36);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 2;
            label6.Text = "First Name:";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Arial", 13F);
            textBox8.Location = new Point(149, 110);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(274, 29);
            textBox8.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Arial", 13F);
            textBox3.Location = new Point(149, 69);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 29);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 13F);
            textBox2.Location = new Point(149, 28);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 29);
            textBox2.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.icons8_user_30;
            pictureBox7.Location = new Point(38, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(42, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 11F);
            textBox4.Location = new Point(80, 311);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "ID Number";
            textBox4.Size = new Size(179, 17);
            textBox4.TabIndex = 15;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = SystemColors.ControlDark;
            groupBox6.Controls.Add(rjButton2);
            groupBox6.Controls.Add(pictureBox3);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Controls.Add(button4);
            groupBox6.Font = new Font("Arial", 12F);
            groupBox6.Location = new Point(531, 461);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(422, 165);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Crimson;
            rjButton2.BackgroundColor = Color.Crimson;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Arial", 10F);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(21, 123);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(380, 31);
            rjButton2.TabIndex = 36;
            rjButton2.Text = "Delete";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_30;
            pictureBox3.Location = new Point(38, 316);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial", 11F);
            textBox5.Location = new Point(80, 311);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "ID Number";
            textBox5.Size = new Size(179, 17);
            textBox5.TabIndex = 15;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(textBox9);
            groupBox7.Controls.Add(label4);
            groupBox7.Controls.Add(pictureBox2);
            groupBox7.Font = new Font("Arial", 14F, FontStyle.Bold);
            groupBox7.Location = new Point(21, 19);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(380, 93);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Delete";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Font = new Font("Arial", 13F);
            textBox9.Location = new Point(151, 38);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(205, 29);
            textBox9.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13F);
            label4.Location = new Point(70, 36);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 2;
            label4.Text = "User ID:";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(324, 285);
            button4.Name = "button4";
            button4.Size = new Size(348, 66);
            button4.TabIndex = 11;
            button4.Text = "DELETE";
            button4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.MediumSpringGreen;
            rjButton3.BackgroundColor = Color.MediumSpringGreen;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Arial", 10F);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(22, 345);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(461, 30);
            rjButton3.TabIndex = 37;
            rjButton3.Text = "Add";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click_1;
            // 
            // CreateUserWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(userGridView);
            Controls.Add(groupBox4);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CreateUserWindow";
            Size = new Size(968, 635);
            Load += CreateUserWindow_Load;
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)userGridView).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Button createUserbtn;
        private GroupBox groupBox3;
        private TextBox creFirstname;
        private GroupBox groupBox1;
        private RadioButton invType;
        private RadioButton salesType;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox crePassword;
        private DataGridView userGridView;
        private GroupBox groupBox5;
        private GroupBox groupBox8;
        private PictureBox pictureBox7;
        private TextBox textBox4;
        private GroupBox groupBox6;
        private PictureBox pictureBox3;
        private TextBox textBox5;
        private GroupBox groupBox7;
        private Button button4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox4;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox creUsername;
       // private RJControls.RJButton createUserbtn;
        private RJControls.RJButton rjButton1;
        private RJControls.RJButton rjButton2;
        private TextBox textBox8;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox9;
        private RJControls.RJButton rjButton3;
    }
}
