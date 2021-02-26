
namespace Saugumas_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.cypherButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cypherTextBox = new System.Windows.Forms.TextBox();
            this.decypherButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cypheredTextBox = new System.Windows.Forms.TextBox();
            this.decypherTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ecbRadioButton = new System.Windows.Forms.RadioButton();
            this.cbcRadioButton = new System.Windows.Forms.RadioButton();
            this.keySizeGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.writeOutputButton = new System.Windows.Forms.Button();
            this.selectOutputButton = new System.Windows.Forms.Button();
            this.readInputButton = new System.Windows.Forms.Button();
            this.selectInputButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.keySizeGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cypher key:";
            // 
            // cypherButton
            // 
            this.cypherButton.Location = new System.Drawing.Point(18, 234);
            this.cypherButton.Name = "cypherButton";
            this.cypherButton.Size = new System.Drawing.Size(908, 33);
            this.cypherButton.TabIndex = 1;
            this.cypherButton.Text = "Cypher the message";
            this.cypherButton.UseVisualStyleBackColor = true;
            this.cypherButton.Click += new System.EventHandler(this.cypherButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(122, 146);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(329, 29);
            this.keyTextBox.TabIndex = 2;
            this.keyTextBox.Text = "Thats my Kung Fu";
            this.keyTextBox.TextChanged += new System.EventHandler(this.KeyTextBoxChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message:";
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Location = new System.Drawing.Point(215, 199);
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.Size = new System.Drawing.Size(711, 29);
            this.cypherTextBox.TabIndex = 9;
            this.cypherTextBox.Text = "Two One Nine Two";
            // 
            // decypherButton
            // 
            this.decypherButton.Location = new System.Drawing.Point(18, 308);
            this.decypherButton.Name = "decypherButton";
            this.decypherButton.Size = new System.Drawing.Size(908, 33);
            this.decypherButton.TabIndex = 10;
            this.decypherButton.Text = "Decypher the message";
            this.decypherButton.UseVisualStyleBackColor = true;
            this.decypherButton.Click += new System.EventHandler(this.decypherButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Decyphered message:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cyphered message:";
            // 
            // cypheredTextBox
            // 
            this.cypheredTextBox.Location = new System.Drawing.Point(215, 273);
            this.cypheredTextBox.Name = "cypheredTextBox";
            this.cypheredTextBox.Size = new System.Drawing.Size(711, 29);
            this.cypheredTextBox.TabIndex = 20;
            // 
            // decypherTextBox
            // 
            this.decypherTextBox.Location = new System.Drawing.Point(215, 347);
            this.decypherTextBox.Name = "decypherTextBox";
            this.decypherTextBox.Size = new System.Drawing.Size(711, 29);
            this.decypherTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.currentLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.keySizeGroupBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.keyTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 181);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cypher settings";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(238, 105);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(30, 24);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "16";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "/";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(181, 105);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(30, 24);
            this.currentLabel.TabIndex = 29;
            this.currentLabel.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Cypher key length:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ecbRadioButton);
            this.groupBox4.Controls.Add(this.cbcRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(235, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 68);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select mode";
            // 
            // ecbRadioButton
            // 
            this.ecbRadioButton.AutoSize = true;
            this.ecbRadioButton.Checked = true;
            this.ecbRadioButton.Location = new System.Drawing.Point(6, 28);
            this.ecbRadioButton.Name = "ecbRadioButton";
            this.ecbRadioButton.Size = new System.Drawing.Size(66, 28);
            this.ecbRadioButton.TabIndex = 0;
            this.ecbRadioButton.TabStop = true;
            this.ecbRadioButton.Text = "ECB";
            this.ecbRadioButton.UseVisualStyleBackColor = true;
            // 
            // cbcRadioButton
            // 
            this.cbcRadioButton.AutoSize = true;
            this.cbcRadioButton.Location = new System.Drawing.Point(78, 28);
            this.cbcRadioButton.Name = "cbcRadioButton";
            this.cbcRadioButton.Size = new System.Drawing.Size(66, 28);
            this.cbcRadioButton.TabIndex = 1;
            this.cbcRadioButton.Text = "CBC";
            this.cbcRadioButton.UseVisualStyleBackColor = true;
            // 
            // keySizeGroupBox
            // 
            this.keySizeGroupBox.Controls.Add(this.radioButton3);
            this.keySizeGroupBox.Controls.Add(this.radioButton2);
            this.keySizeGroupBox.Controls.Add(this.radioButton1);
            this.keySizeGroupBox.Location = new System.Drawing.Point(6, 28);
            this.keySizeGroupBox.Name = "keySizeGroupBox";
            this.keySizeGroupBox.Size = new System.Drawing.Size(223, 68);
            this.keySizeGroupBox.TabIndex = 26;
            this.keySizeGroupBox.TabStop = false;
            this.keySizeGroupBox.Text = "Key size";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(134, 28);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 28);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "256";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.KeySizeRadioButtonChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "192";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.KeySizeRadioButtonChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "128";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.KeySizeRadioButtonChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.writeOutputButton);
            this.groupBox2.Controls.Add(this.selectOutputButton);
            this.groupBox2.Controls.Add(this.readInputButton);
            this.groupBox2.Controls.Add(this.selectInputButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.outputTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.inputTextBox);
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 181);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External input/output";
            // 
            // writeOutputButton
            // 
            this.writeOutputButton.Location = new System.Drawing.Point(258, 137);
            this.writeOutputButton.Name = "writeOutputButton";
            this.writeOutputButton.Size = new System.Drawing.Size(193, 33);
            this.writeOutputButton.TabIndex = 33;
            this.writeOutputButton.Text = "Write";
            this.writeOutputButton.UseVisualStyleBackColor = true;
            this.writeOutputButton.Click += new System.EventHandler(this.writeOutputButton_Click);
            // 
            // selectOutputButton
            // 
            this.selectOutputButton.Location = new System.Drawing.Point(18, 137);
            this.selectOutputButton.Name = "selectOutputButton";
            this.selectOutputButton.Size = new System.Drawing.Size(193, 33);
            this.selectOutputButton.TabIndex = 32;
            this.selectOutputButton.Text = "Select path";
            this.selectOutputButton.UseVisualStyleBackColor = true;
            this.selectOutputButton.Click += new System.EventHandler(this.selectOutputButton_Click);
            // 
            // readInputButton
            // 
            this.readInputButton.Location = new System.Drawing.Point(258, 63);
            this.readInputButton.Name = "readInputButton";
            this.readInputButton.Size = new System.Drawing.Size(193, 33);
            this.readInputButton.TabIndex = 31;
            this.readInputButton.Text = "Read";
            this.readInputButton.UseVisualStyleBackColor = true;
            this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
            // 
            // selectInputButton
            // 
            this.selectInputButton.Location = new System.Drawing.Point(18, 63);
            this.selectInputButton.Name = "selectInputButton";
            this.selectInputButton.Size = new System.Drawing.Size(193, 33);
            this.selectInputButton.TabIndex = 30;
            this.selectInputButton.Text = "Select path";
            this.selectInputButton.UseVisualStyleBackColor = true;
            this.selectInputButton.Click += new System.EventHandler(this.selectInputButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Output:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(91, 102);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(360, 29);
            this.outputTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Input:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(91, 28);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(360, 29);
            this.inputTextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 383);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cypherTextBox);
            this.Controls.Add(this.decypherTextBox);
            this.Controls.Add(this.decypherButton);
            this.Controls.Add(this.cypherButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cypheredTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "AES algorithm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.keySizeGroupBox.ResumeLayout(false);
            this.keySizeGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cypherButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cypherTextBox;
        private System.Windows.Forms.Button decypherButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cypheredTextBox;
        private System.Windows.Forms.TextBox decypherTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cbcRadioButton;
        private System.Windows.Forms.RadioButton ecbRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button writeOutputButton;
        private System.Windows.Forms.Button selectOutputButton;
        private System.Windows.Forms.Button readInputButton;
        private System.Windows.Forms.Button selectInputButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox keySizeGroupBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label label2;
    }
}

