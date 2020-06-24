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
            this.LBLBalance = new System.Windows.Forms.Label();
            this.BtnSortContainers = new System.Windows.Forms.Button();
            this.NumericLength = new System.Windows.Forms.NumericUpDown();
            this.BtnCreateShip = new System.Windows.Forms.Button();
            this.NumericWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLContainerWeight = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.NumericContainerAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLValuableContainer = new System.Windows.Forms.Label();
            this.LBLCoolableContainers = new System.Windows.Forms.Label();
            this.LBLCoolableAndValuableContainers = new System.Windows.Forms.Label();
            this.LBLNormalContainers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericContainerAmount)).BeginInit();
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
            this.LBContainers.Size = new System.Drawing.Size(325, 324);
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
            this.LBLShipMaxWeight.Location = new System.Drawing.Point(472, 79);
            this.LBLShipMaxWeight.Name = "LBLShipMaxWeight";
            this.LBLShipMaxWeight.Size = new System.Drawing.Size(132, 17);
            this.LBLShipMaxWeight.TabIndex = 4;
            this.LBLShipMaxWeight.Text = "Ship Max gewicht: 0";
            // 
            // LBLShipMinWeight
            // 
            this.LBLShipMinWeight.AutoSize = true;
            this.LBLShipMinWeight.Location = new System.Drawing.Point(472, 97);
            this.LBLShipMinWeight.Name = "LBLShipMinWeight";
            this.LBLShipMinWeight.Size = new System.Drawing.Size(129, 17);
            this.LBLShipMinWeight.TabIndex = 5;
            this.LBLShipMinWeight.Text = "Ship Min gewicht: 0";
            // 
            // TBURL
            // 
            this.TBURL.Location = new System.Drawing.Point(137, 416);
            this.TBURL.Name = "TBURL";
            this.TBURL.Size = new System.Drawing.Size(651, 22);
            this.TBURL.TabIndex = 6;
            this.TBURL.Text = "Ship URL";
            // 
            // LBLBalance
            // 
            this.LBLBalance.AutoSize = true;
            this.LBLBalance.Location = new System.Drawing.Point(476, 418);
            this.LBLBalance.Name = "LBLBalance";
            this.LBLBalance.Size = new System.Drawing.Size(128, 17);
            this.LBLBalance.TabIndex = 7;
            this.LBLBalance.Text = "Ship Balance: 0 - 0";
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
            // NumericLength
            // 
            this.NumericLength.Location = new System.Drawing.Point(346, 74);
            this.NumericLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericLength.Name = "NumericLength";
            this.NumericLength.Size = new System.Drawing.Size(120, 22);
            this.NumericLength.TabIndex = 9;
            this.NumericLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BtnCreateShip
            // 
            this.BtnCreateShip.Location = new System.Drawing.Point(346, 102);
            this.BtnCreateShip.Name = "BtnCreateShip";
            this.BtnCreateShip.Size = new System.Drawing.Size(120, 30);
            this.BtnCreateShip.TabIndex = 10;
            this.BtnCreateShip.Text = "Create Ship";
            this.BtnCreateShip.UseVisualStyleBackColor = true;
            this.BtnCreateShip.Click += new System.EventHandler(this.BtnCreateShip_Click);
            // 
            // NumericWidth
            // 
            this.NumericWidth.Location = new System.Drawing.Point(346, 32);
            this.NumericWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericWidth.Name = "NumericWidth";
            this.NumericWidth.Size = new System.Drawing.Size(120, 22);
            this.NumericWidth.TabIndex = 11;
            this.NumericWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ship width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ship Length";
            // 
            // LBLContainerWeight
            // 
            this.LBLContainerWeight.AutoSize = true;
            this.LBLContainerWeight.Location = new System.Drawing.Point(216, 359);
            this.LBLContainerWeight.Name = "LBLContainerWeight";
            this.LBLContainerWeight.Size = new System.Drawing.Size(136, 17);
            this.LBLContainerWeight.TabIndex = 14;
            this.LBLContainerWeight.Text = "Container gewicht: 0";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(261, 385);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(125, 23);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "Clear containers";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // NumericContainerAmount
            // 
            this.NumericContainerAmount.Location = new System.Drawing.Point(138, 357);
            this.NumericContainerAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericContainerAmount.Name = "NumericContainerAmount";
            this.NumericContainerAmount.Size = new System.Drawing.Size(72, 22);
            this.NumericContainerAmount.TabIndex = 16;
            this.NumericContainerAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gewicht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "hoeveel containers";
            // 
            // LBLValuableContainer
            // 
            this.LBLValuableContainer.AutoSize = true;
            this.LBLValuableContainer.Location = new System.Drawing.Point(346, 318);
            this.LBLValuableContainer.Name = "LBLValuableContainer";
            this.LBLValuableContainer.Size = new System.Drawing.Size(79, 17);
            this.LBLValuableContainer.TabIndex = 19;
            this.LBLValuableContainer.Text = "Valuable: 0";
            // 
            // LBLCoolableContainers
            // 
            this.LBLCoolableContainers.AutoSize = true;
            this.LBLCoolableContainers.Location = new System.Drawing.Point(346, 301);
            this.LBLCoolableContainers.Name = "LBLCoolableContainers";
            this.LBLCoolableContainers.Size = new System.Drawing.Size(79, 17);
            this.LBLCoolableContainers.TabIndex = 20;
            this.LBLCoolableContainers.Text = "Coolable: 0";
            // 
            // LBLCoolableAndValuableContainers
            // 
            this.LBLCoolableAndValuableContainers.AutoSize = true;
            this.LBLCoolableAndValuableContainers.Location = new System.Drawing.Point(346, 284);
            this.LBLCoolableAndValuableContainers.Name = "LBLCoolableAndValuableContainers";
            this.LBLCoolableAndValuableContainers.Size = new System.Drawing.Size(164, 17);
            this.LBLCoolableAndValuableContainers.TabIndex = 21;
            this.LBLCoolableAndValuableContainers.Text = "Coolable and valuable: 0";
            // 
            // LBLNormalContainers
            // 
            this.LBLNormalContainers.AutoSize = true;
            this.LBLNormalContainers.Location = new System.Drawing.Point(346, 267);
            this.LBLNormalContainers.Name = "LBLNormalContainers";
            this.LBLNormalContainers.Size = new System.Drawing.Size(69, 17);
            this.LBLNormalContainers.TabIndex = 22;
            this.LBLNormalContainers.Text = "Normal: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLNormalContainers);
            this.Controls.Add(this.LBLCoolableAndValuableContainers);
            this.Controls.Add(this.LBLCoolableContainers);
            this.Controls.Add(this.LBLValuableContainer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericContainerAmount);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.LBLContainerWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericWidth);
            this.Controls.Add(this.BtnCreateShip);
            this.Controls.Add(this.NumericLength);
            this.Controls.Add(this.BtnSortContainers);
            this.Controls.Add(this.TBURL);
            this.Controls.Add(this.LBLShipMinWeight);
            this.Controls.Add(this.LBLShipMaxWeight);
            this.Controls.Add(this.NumericWeight);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.LBContainers);
            this.Controls.Add(this.BTNAddContainer);
            this.Controls.Add(this.LBLBalance);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericContainerAmount)).EndInit();
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
        private System.Windows.Forms.Label LBLBalance;
        private System.Windows.Forms.Button BtnSortContainers;
        private System.Windows.Forms.NumericUpDown NumericLength;
        private System.Windows.Forms.Button BtnCreateShip;
        private System.Windows.Forms.NumericUpDown NumericWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLContainerWeight;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.NumericUpDown NumericContainerAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLValuableContainer;
        private System.Windows.Forms.Label LBLCoolableContainers;
        private System.Windows.Forms.Label LBLCoolableAndValuableContainers;
        private System.Windows.Forms.Label LBLNormalContainers;
    }
}

