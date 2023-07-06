namespace Calculator.WinForms.UI
{
    partial class CalculatorForm
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
            BtnAddition = new Button();
            BtnSubtraction = new Button();
            BtnMultiplication = new Button();
            BtnDivision = new Button();
            groupBox1 = new GroupBox();
            txtNumber1 = new TextBox();
            lblEquals = new Label();
            lblResult = new Label();
            txtIndicator = new TextBox();
            txtNumber2 = new TextBox();
            BtnClear = new Button();
            BtnEquals = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b9 = new Button();
            b8 = new Button();
            B7 = new Button();
            b0 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAddition
            // 
            BtnAddition.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddition.Location = new Point(373, 165);
            BtnAddition.Name = "BtnAddition";
            BtnAddition.Size = new Size(110, 35);
            BtnAddition.TabIndex = 4;
            BtnAddition.Text = "+";
            BtnAddition.UseVisualStyleBackColor = true;
            BtnAddition.Click += btnAddition_Click;
            // 
            // BtnSubtraction
            // 
            BtnSubtraction.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSubtraction.Location = new Point(373, 206);
            BtnSubtraction.Name = "BtnSubtraction";
            BtnSubtraction.Size = new Size(110, 35);
            BtnSubtraction.TabIndex = 5;
            BtnSubtraction.Text = "-";
            BtnSubtraction.UseVisualStyleBackColor = true;
            BtnSubtraction.Click += btnSubtraction_Click;
            // 
            // BtnMultiplication
            // 
            BtnMultiplication.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMultiplication.Location = new Point(373, 247);
            BtnMultiplication.Name = "BtnMultiplication";
            BtnMultiplication.Size = new Size(110, 35);
            BtnMultiplication.TabIndex = 6;
            BtnMultiplication.Text = "*";
            BtnMultiplication.UseVisualStyleBackColor = true;
            BtnMultiplication.Click += btnMultiplication_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDivision.Location = new Point(373, 288);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(110, 35);
            BtnDivision.TabIndex = 7;
            BtnDivision.Text = "/";
            BtnDivision.UseVisualStyleBackColor = true;
            BtnDivision.Click += btnDivision_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtNumber1);
            groupBox1.Controls.Add(lblEquals);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(txtIndicator);
            groupBox1.Controls.Add(txtNumber2);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 106);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // txtNumber1
            // 
            txtNumber1.BackColor = Color.White;
            txtNumber1.BorderStyle = BorderStyle.None;
            txtNumber1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber1.ForeColor = Color.Black;
            txtNumber1.Location = new Point(14, 34);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(82, 26);
            txtNumber1.TabIndex = 3;
            // 
            // lblEquals
            // 
            lblEquals.AutoSize = true;
            lblEquals.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquals.Location = new Point(273, 19);
            lblEquals.Name = "lblEquals";
            lblEquals.Size = new Size(45, 47);
            lblEquals.TabIndex = 10;
            lblEquals.Text = "=";
            lblEquals.Visible = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblResult.Location = new Point(315, 21);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 45);
            lblResult.TabIndex = 9;
            // 
            // txtIndicator
            // 
            txtIndicator.BackColor = Color.White;
            txtIndicator.BorderStyle = BorderStyle.None;
            txtIndicator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtIndicator.ForeColor = Color.Black;
            txtIndicator.Location = new Point(102, 34);
            txtIndicator.Name = "txtIndicator";
            txtIndicator.Size = new Size(59, 26);
            txtIndicator.TabIndex = 5;
            // 
            // txtNumber2
            // 
            txtNumber2.BackColor = Color.White;
            txtNumber2.BorderStyle = BorderStyle.None;
            txtNumber2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumber2.ForeColor = Color.Black;
            txtNumber2.Location = new Point(179, 34);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(88, 26);
            txtNumber2.TabIndex = 4;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnClear.Location = new Point(373, 124);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(110, 35);
            BtnClear.TabIndex = 10;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEquals.ForeColor = Color.Red;
            BtnEquals.Location = new Point(373, 329);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(110, 61);
            BtnEquals.TabIndex = 11;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = true;
            BtnEquals.Click += btnEquals_Click;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(12, 262);
            b1.Name = "b1";
            b1.Size = new Size(110, 61);
            b1.TabIndex = 12;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += Button_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(128, 262);
            b2.Name = "b2";
            b2.Size = new Size(110, 61);
            b2.TabIndex = 13;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += Button_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(244, 260);
            b3.Name = "b3";
            b3.Size = new Size(110, 61);
            b3.TabIndex = 14;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += Button_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(244, 193);
            b6.Name = "b6";
            b6.Size = new Size(110, 61);
            b6.TabIndex = 17;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += Button_Click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(128, 193);
            b5.Name = "b5";
            b5.Size = new Size(110, 61);
            b5.TabIndex = 16;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += Button_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(12, 193);
            b4.Name = "b4";
            b4.Size = new Size(110, 61);
            b4.TabIndex = 15;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += Button_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(244, 124);
            b9.Name = "b9";
            b9.Size = new Size(110, 61);
            b9.TabIndex = 20;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += Button_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(128, 124);
            b8.Name = "b8";
            b8.Size = new Size(110, 61);
            b8.TabIndex = 19;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += Button_Click;
            // 
            // B7
            // 
            B7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            B7.Location = new Point(12, 124);
            B7.Name = "B7";
            B7.Size = new Size(110, 61);
            B7.TabIndex = 18;
            B7.Text = "7";
            B7.UseVisualStyleBackColor = true;
            B7.Click += Button_Click;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            b0.Location = new Point(244, 329);
            b0.Name = "b0";
            b0.Size = new Size(110, 61);
            b0.TabIndex = 21;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += Button_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 402);
            Controls.Add(b0);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(B7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(BtnEquals);
            Controls.Add(BtnClear);
            Controls.Add(groupBox1);
            Controls.Add(BtnDivision);
            Controls.Add(BtnMultiplication);
            Controls.Add(BtnSubtraction);
            Controls.Add(BtnAddition);
            MaximizeBox = false;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinForm - Calculator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAddition;
        private Button BtnSubtraction;
        private Button BtnMultiplication;
        private Button BtnDivision;
        private GroupBox groupBox1;
        private TextBox txtIndicator;
        private TextBox txtNumber2;
        private TextBox txtNumber1;
        private Button BtnClear;
        private Label lblEquals;
        private Label lblResult;
        private Button BtnEquals;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b9;
        private Button b8;
        private Button B7;
        private Button b0;
    }
}