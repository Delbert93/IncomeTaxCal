namespace IncomeTaxCal.WinForms
{
    partial class Income_Calculator
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
            this.tabSystem = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIncomeBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNewIncome = new System.Windows.Forms.TextBox();
            this.combState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.historyTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IncomeHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewIncomeHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSystem.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncomeBox)).BeginInit();
            this.historyTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSystem
            // 
            this.tabSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSystem.Controls.Add(this.tabPage1);
            this.tabSystem.Controls.Add(this.historyTab);
            this.tabSystem.Location = new System.Drawing.Point(0, 0);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.SelectedIndex = 0;
            this.tabSystem.Size = new System.Drawing.Size(355, 317);
            this.tabSystem.TabIndex = 6;
            this.tabSystem.SelectedIndexChanged += new System.EventHandler(this.tabSwitching_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.txtIncomeBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtNewIncome);
            this.tabPage1.Controls.Add(this.combState);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(347, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Income Calculator";
            // 
            // txtIncomeBox
            // 
            this.txtIncomeBox.Location = new System.Drawing.Point(73, 10);
            this.txtIncomeBox.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.txtIncomeBox.Name = "txtIncomeBox";
            this.txtIncomeBox.Size = new System.Drawing.Size(120, 23);
            this.txtIncomeBox.TabIndex = 1;
            this.txtIncomeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncomeBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get New Income";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.getNewIncome_Click);
            // 
            // txtNewIncome
            // 
            this.txtNewIncome.Location = new System.Drawing.Point(8, 226);
            this.txtNewIncome.Name = "txtNewIncome";
            this.txtNewIncome.ReadOnly = true;
            this.txtNewIncome.Size = new System.Drawing.Size(185, 23);
            this.txtNewIncome.TabIndex = 6;
            // 
            // combState
            // 
            this.combState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combState.FormattingEnabled = true;
            this.combState.Items.AddRange(new object[] {
            "You should never see this"});
            this.combState.Location = new System.Drawing.Point(72, 73);
            this.combState.Name = "combState";
            this.combState.Size = new System.Drawing.Size(121, 23);
            this.combState.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Income";
            // 
            // historyTab
            // 
            this.historyTab.Controls.Add(this.dataGridView1);
            this.historyTab.Location = new System.Drawing.Point(4, 24);
            this.historyTab.Name = "historyTab";
            this.historyTab.Padding = new System.Windows.Forms.Padding(3);
            this.historyTab.Size = new System.Drawing.Size(347, 289);
            this.historyTab.TabIndex = 1;
            this.historyTab.Text = "Calculation History";
            this.historyTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeHistory,
            this.StateHistory,
            this.NewIncomeHistory});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // IncomeHistory
            // 
            this.IncomeHistory.HeaderText = "Income";
            this.IncomeHistory.Name = "IncomeHistory";
            this.IncomeHistory.ReadOnly = true;
            // 
            // StateHistory
            // 
            this.StateHistory.HeaderText = "State";
            this.StateHistory.Name = "StateHistory";
            this.StateHistory.ReadOnly = true;
            // 
            // NewIncomeHistory
            // 
            this.NewIncomeHistory.HeaderText = "NewIncome";
            this.NewIncomeHistory.Name = "NewIncomeHistory";
            this.NewIncomeHistory.ReadOnly = true;
            // 
            // Income_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(356, 315);
            this.Controls.Add(this.tabSystem);
            this.Name = "Income_Calculator";
            this.Text = "Income Calculator";
            this.Load += new System.EventHandler(this.Income_Calculator_Load);
            this.tabSystem.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIncomeBox)).EndInit();
            this.historyTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSystem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNewIncome;
        private System.Windows.Forms.ComboBox combState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage historyTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewIncomeHistory;
        private System.Windows.Forms.NumericUpDown txtIncomeBox;
    }
}

