namespace HomeAffairsDigitalIdentityProcessor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtIDNumber = new TextBox();
            cmbCitizenship = new ComboBox();
            btnValidate = new Button();
            txtOutput = new TextBox();
            btnGenerate = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 100);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter Your Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 140);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter your ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 181);
            label3.Name = "label3";
            label3.Size = new Size(140, 20);
            label3.TabIndex = 2;
            label3.Text = "Choose your Citizen";
            // 
            // txtName
            // 
            txtName.Location = new Point(429, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtIDNumber
            // 
            txtIDNumber.Location = new Point(429, 140);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(125, 27);
            txtIDNumber.TabIndex = 4;
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Location = new Point(440, 181);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(151, 28);
            cmbCitizenship.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(389, 224);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 29);
            btnValidate.TabIndex = 6;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(294, 279);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(269, 131);
            txtOutput.TabIndex = 7;
            txtOutput.TextChanged += txtOutput_TextChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(340, 409);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(143, 29);
            btnGenerate.TabIndex = 8;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 256);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 9;
            label4.Text = "label4";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(293, 441);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(btnGenerate);
            Controls.Add(txtOutput);
            Controls.Add(btnValidate);
            Controls.Add(cmbCitizenship);
            Controls.Add(txtIDNumber);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtIDNumber;
        private ComboBox cmbCitizenship;
        private Button btnValidate;
        private TextBox txtOutput;
        private Button btnGenerate;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
