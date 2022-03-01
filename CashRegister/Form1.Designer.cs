namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.applesLabel = new System.Windows.Forms.Label();
            this.bananasLabel = new System.Windows.Forms.Label();
            this.orangesLabel = new System.Windows.Forms.Label();
            this.pretaxLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.applesInput = new System.Windows.Forms.TextBox();
            this.bananasInput = new System.Windows.Forms.TextBox();
            this.orangesInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.pretaxOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.printrecieptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(73, 37);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(170, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Taylor\'s grocery store!";
            // 
            // applesLabel
            // 
            this.applesLabel.AutoSize = true;
            this.applesLabel.Location = new System.Drawing.Point(71, 72);
            this.applesLabel.Name = "applesLabel";
            this.applesLabel.Size = new System.Drawing.Size(39, 13);
            this.applesLabel.TabIndex = 1;
            this.applesLabel.Text = "Apples";
            // 
            // bananasLabel
            // 
            this.bananasLabel.AutoSize = true;
            this.bananasLabel.Location = new System.Drawing.Point(69, 101);
            this.bananasLabel.Name = "bananasLabel";
            this.bananasLabel.Size = new System.Drawing.Size(49, 13);
            this.bananasLabel.TabIndex = 2;
            this.bananasLabel.Text = "Bananas";
            // 
            // orangesLabel
            // 
            this.orangesLabel.AutoSize = true;
            this.orangesLabel.Location = new System.Drawing.Point(71, 132);
            this.orangesLabel.Name = "orangesLabel";
            this.orangesLabel.Size = new System.Drawing.Size(47, 13);
            this.orangesLabel.TabIndex = 3;
            this.orangesLabel.Text = "Oranges";
            // 
            // pretaxLabel
            // 
            this.pretaxLabel.AutoSize = true;
            this.pretaxLabel.Location = new System.Drawing.Point(73, 201);
            this.pretaxLabel.Name = "pretaxLabel";
            this.pretaxLabel.Size = new System.Drawing.Size(37, 13);
            this.pretaxLabel.TabIndex = 4;
            this.pretaxLabel.Text = "Pretax";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(73, 236);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(25, 13);
            this.taxLabel.TabIndex = 5;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(73, 272);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total";
            // 
            // applesInput
            // 
            this.applesInput.Location = new System.Drawing.Point(124, 72);
            this.applesInput.Name = "applesInput";
            this.applesInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.applesInput.Size = new System.Drawing.Size(100, 20);
            this.applesInput.TabIndex = 7;
            // 
            // bananasInput
            // 
            this.bananasInput.Location = new System.Drawing.Point(124, 101);
            this.bananasInput.Name = "bananasInput";
            this.bananasInput.Size = new System.Drawing.Size(100, 20);
            this.bananasInput.TabIndex = 8;
            // 
            // orangesInput
            // 
            this.orangesInput.Location = new System.Drawing.Point(124, 132);
            this.orangesInput.Name = "orangesInput";
            this.orangesInput.Size = new System.Drawing.Size(100, 20);
            this.orangesInput.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(76, 158);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(91, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // pretaxOutput
            // 
            this.pretaxOutput.Location = new System.Drawing.Point(143, 198);
            this.pretaxOutput.Name = "pretaxOutput";
            this.pretaxOutput.Size = new System.Drawing.Size(100, 20);
            this.pretaxOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.Location = new System.Drawing.Point(143, 236);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(100, 20);
            this.taxOutput.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.Location = new System.Drawing.Point(143, 272);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 20);
            this.totalOutput.TabIndex = 13;
            // 
            // printrecieptButton
            // 
            this.printrecieptButton.Location = new System.Drawing.Point(76, 306);
            this.printrecieptButton.Name = "printrecieptButton";
            this.printrecieptButton.Size = new System.Drawing.Size(91, 35);
            this.printrecieptButton.TabIndex = 15;
            this.printrecieptButton.Text = "Print Receipt";
            this.printrecieptButton.UseVisualStyleBackColor = true;
            this.printrecieptButton.Click += new System.EventHandler(this.printrecieptButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.Lime;
            this.receiptOutput.Location = new System.Drawing.Point(394, 69);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(335, 235);
            this.receiptOutput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.printrecieptButton);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.pretaxOutput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.orangesInput);
            this.Controls.Add(this.bananasInput);
            this.Controls.Add(this.applesInput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.pretaxLabel);
            this.Controls.Add(this.orangesLabel);
            this.Controls.Add(this.bananasLabel);
            this.Controls.Add(this.applesLabel);
            this.Controls.Add(this.welcomeLabel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label applesLabel;
        private System.Windows.Forms.Label bananasLabel;
        private System.Windows.Forms.Label orangesLabel;
        private System.Windows.Forms.Label pretaxLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox applesInput;
        private System.Windows.Forms.TextBox bananasInput;
        private System.Windows.Forms.TextBox orangesInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox pretaxOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Button printrecieptButton;
        private System.Windows.Forms.Label receiptOutput;
    }
}

