namespace Alex_Gheorghita___Software_Programming_Project
{
    partial class Form2
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
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteARecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spendingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeARecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteARecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listSavings = new System.Windows.Forms.ListBox();
            this.listSpendings = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceToolStripMenuItem,
            this.savingsToolStripMenuItem,
            this.spendingsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 38);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.balanceToolStripMenuItem.Text = "Balance";
            // 
            // savingsToolStripMenuItem
            // 
            this.savingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeARecordToolStripMenuItem,
            this.deleteARecordToolStripMenuItem});
            this.savingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.savingsToolStripMenuItem.Name = "savingsToolStripMenuItem";
            this.savingsToolStripMenuItem.Size = new System.Drawing.Size(102, 34);
            this.savingsToolStripMenuItem.Text = "Savings";
            this.savingsToolStripMenuItem.Click += new System.EventHandler(this.savingsToolStripMenuItem_Click);
            // 
            // changeARecordToolStripMenuItem
            // 
            this.changeARecordToolStripMenuItem.Name = "changeARecordToolStripMenuItem";
            this.changeARecordToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.changeARecordToolStripMenuItem.Text = "Change a Record";
            this.changeARecordToolStripMenuItem.Click += new System.EventHandler(this.changeARecordToolStripMenuItem_Click);
            // 
            // deleteARecordToolStripMenuItem
            // 
            this.deleteARecordToolStripMenuItem.Name = "deleteARecordToolStripMenuItem";
            this.deleteARecordToolStripMenuItem.Size = new System.Drawing.Size(281, 38);
            this.deleteARecordToolStripMenuItem.Text = "Delete a Record";
            this.deleteARecordToolStripMenuItem.Click += new System.EventHandler(this.deleteARecordToolStripMenuItem_Click);
            // 
            // spendingsToolStripMenuItem
            // 
            this.spendingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeARecordToolStripMenuItem1,
            this.deleteARecordToolStripMenuItem1});
            this.spendingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.spendingsToolStripMenuItem.Name = "spendingsToolStripMenuItem";
            this.spendingsToolStripMenuItem.Size = new System.Drawing.Size(130, 34);
            this.spendingsToolStripMenuItem.Text = "Spendings";
            this.spendingsToolStripMenuItem.Click += new System.EventHandler(this.spendingsToolStripMenuItem_Click);
            // 
            // changeARecordToolStripMenuItem1
            // 
            this.changeARecordToolStripMenuItem1.Name = "changeARecordToolStripMenuItem1";
            this.changeARecordToolStripMenuItem1.Size = new System.Drawing.Size(281, 38);
            this.changeARecordToolStripMenuItem1.Text = "Change a Record";
            this.changeARecordToolStripMenuItem1.Click += new System.EventHandler(this.changeARecordToolStripMenuItem1_Click);
            // 
            // deleteARecordToolStripMenuItem1
            // 
            this.deleteARecordToolStripMenuItem1.Name = "deleteARecordToolStripMenuItem1";
            this.deleteARecordToolStripMenuItem1.Size = new System.Drawing.Size(281, 38);
            this.deleteARecordToolStripMenuItem1.Text = "Delete a Record";
            this.deleteARecordToolStripMenuItem1.Click += new System.EventHandler(this.deleteARecordToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(106, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose the currency for which you want to see your balance:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(374, 30);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listSavings
            // 
            this.listSavings.FormattingEnabled = true;
            this.listSavings.ItemHeight = 20;
            this.listSavings.Location = new System.Drawing.Point(604, 112);
            this.listSavings.Name = "listSavings";
            this.listSavings.Size = new System.Drawing.Size(248, 424);
            this.listSavings.TabIndex = 7;
            // 
            // listSpendings
            // 
            this.listSpendings.FormattingEnabled = true;
            this.listSpendings.ItemHeight = 20;
            this.listSpendings.Location = new System.Drawing.Point(858, 112);
            this.listSpendings.Name = "listSpendings";
            this.listSpendings.Size = new System.Drawing.Size(248, 424);
            this.listSpendings.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Savings:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(854, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Spendings:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(599, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "BALANCE:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listSpendings);
            this.Controls.Add(this.listSavings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Balance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem balanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spendingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listSavings;
        private System.Windows.Forms.ListBox listSpendings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem changeARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteARecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeARecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteARecordToolStripMenuItem1;
    }
}