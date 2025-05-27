namespace Grayscale_Display
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nav1 = new Button();
            nav2 = new Button();
            nav3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            navbar = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            navbar.SuspendLayout();
            SuspendLayout();
            // 
            // nav1
            // 
            nav1.BackColor = Color.DimGray;
            nav1.Dock = DockStyle.Left;
            nav1.FlatStyle = FlatStyle.Flat;
            nav1.ForeColor = Color.White;
            nav1.Location = new Point(3, 3);
            nav1.Margin = new Padding(5);
            nav1.Name = "nav1";
            nav1.Size = new Size(264, 34);
            nav1.TabIndex = 0;
            nav1.Text = "Grayscale";
            nav1.UseVisualStyleBackColor = false;
            // 
            // nav2
            // 
            nav2.BackColor = Color.DimGray;
            nav2.Dock = DockStyle.Left;
            nav2.FlatStyle = FlatStyle.Flat;
            nav2.ForeColor = Color.White;
            nav2.Location = new Point(267, 3);
            nav2.Margin = new Padding(5);
            nav2.Name = "nav2";
            nav2.Size = new Size(264, 34);
            nav2.TabIndex = 1;
            nav2.Text = "Downscale";
            nav2.UseVisualStyleBackColor = false;
            // 
            // nav3
            // 
            nav3.BackColor = Color.DimGray;
            nav3.Dock = DockStyle.Left;
            nav3.FlatStyle = FlatStyle.Flat;
            nav3.ForeColor = Color.White;
            nav3.Location = new Point(531, 3);
            nav3.Margin = new Padding(5);
            nav3.Name = "nav3";
            nav3.Size = new Size(264, 34);
            nav3.TabIndex = 2;
            nav3.Text = "ASCII";
            nav3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(navbar, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.444445F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.55556F));
            tableLayoutPanel1.Size = new Size(806, 477);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(224, 224, 224);
            navbar.Controls.Add(nav3);
            navbar.Controls.Add(nav2);
            navbar.Controls.Add(nav1);
            navbar.Dock = DockStyle.Fill;
            navbar.Location = new Point(0, 0);
            navbar.Margin = new Padding(0);
            navbar.Name = "navbar";
            navbar.Padding = new Padding(3);
            navbar.Size = new Size(806, 40);
            navbar.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 431);
            panel1.TabIndex = 4;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 477);
            Controls.Add(tableLayoutPanel1);
            Name = "mainForm";
            Text = "Grayscaler-App";
            tableLayoutPanel1.ResumeLayout(false);
            navbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button nav1;
        private Button nav2;
        private Button nav3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel navbar;
        private Panel panel1;
    }
}
