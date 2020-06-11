namespace ContainerVervoer
{
    partial class Form1
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
            this.BTNAddContainer = new System.Windows.Forms.Button();
            this.LBContainers = new System.Windows.Forms.ListBox();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.NumericWeight = new System.Windows.Forms.NumericUpDown();
            this.LBLShipMaxWeight = new System.Windows.Forms.Label();
            this.LBLShipMinWeight = new System.Windows.Forms.Label();
            this.TBURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSortContainers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNAddContainer
            // 
            this.BTNAddContainer.Location = new System.Drawing.Point(12, 415);
            this.BTNAddContainer.Name = "BTNAddContainer";
            this.BTNAddContainer.Size = new System.Drawing.Size(119, 23);
            this.BTNAddContainer.TabIndex = 0;
            this.BTNAddContainer.Text = "Add Container";
            this.BTNAddContainer.UseVisualStyleBackColor = true;
            this.BTNAddContainer.Click += new System.EventHandler(this.button1_Click);
            // 
            // LBContainers
            // 
            this.LBContainers.FormattingEnabled = true;
            this.LBContainers.ItemHeight = 16;
            this.LBContainers.Location = new System.Drawing.Point(12, 12);
            this.LBContainers.Name = "LBContainers";
            this.LBContainers.Size = new System.Drawing.Size(325, 340);
            this.LBContainers.TabIndex = 1;
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Location = new System.Drawing.Point(11, 385);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(121, 24);
            this.CBType.TabIndex = 2;
            // 
            // NumericWeight
            // 
            this.NumericWeight.Location = new System.Drawing.Point(11, 357);
            this.NumericWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.NumericWeight.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.NumericWeight.Name = "NumericWeight";
            this.NumericWeight.Size = new System.Drawing.Size(120, 22);
            this.NumericWeight.TabIndex = 3;
            this.NumericWeight.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // LBLShipMaxWeight
            // 
            this.LBLShipMaxWeight.AutoSize = true;
            this.LBLShipMaxWeight.Location = new System.Drawing.Point(341, 12);
            this.LBLShipMaxWeight.Name = "LBLShipMaxWeight";
            this.LBLShipMaxWeight.Size = new System.Drawing.Size(129, 17);
            this.LBLShipMaxWeight.TabIndex = 4;
            this.LBLShipMaxWeight.Text = "Ship Max Weight: 0";
            // 
            // LBLShipMinWeight
            // 
            this.LBLShipMinWeight.AutoSize = true;
            this.LBLShipMinWeight.Location = new System.Drawing.Point(344, 30);
            this.LBLShipMinWeight.Name = "LBLShipMinWeight";
            this.LBLShipMinWeight.Size = new System.Drawing.Size(126, 17);
            this.LBLShipMinWeight.TabIndex = 5;
            this.LBLShipMinWeight.Text = "Ship Min Weight: 0";
            // 
            // TBURL
            // 
            this.TBURL.Location = new System.Drawing.Point(137, 416);
            this.TBURL.Name = "TBURL";
            this.TBURL.Size = new System.Drawing.Size(651, 22);
            this.TBURL.TabIndex = 6;
            this.TBURL.Text = "Ship URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ship Balance: 0 - 0";
            // 
            // BtnSortContainers
            // 
            this.BtnSortContainers.Location = new System.Drawing.Point(138, 385);
            this.BtnSortContainers.Name = "BtnSortContainers";
            this.BtnSortContainers.Size = new System.Drawing.Size(117, 23);
            this.BtnSortContainers.TabIndex = 8;
            this.BtnSortContainers.Text = "Sort Containers";
            this.BtnSortContainers.UseVisualStyleBackColor = true;
            this.BtnSortContainers.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSortContainers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBURL);
            this.Controls.Add(this.LBLShipMinWeight);
            this.Controls.Add(this.LBLShipMaxWeight);
            this.Controls.Add(this.NumericWeight);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.LBContainers);
            this.Controls.Add(this.BTNAddContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNAddContainer;
        private System.Windows.Forms.ListBox LBContainers;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.NumericUpDown NumericWeight;
        private System.Windows.Forms.Label LBLShipMaxWeight;
        private System.Windows.Forms.Label LBLShipMinWeight;
        private System.Windows.Forms.TextBox TBURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSortContainers;
    }
}

