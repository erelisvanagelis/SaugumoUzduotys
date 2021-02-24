
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.selectInputButton = new System.Windows.Forms.Button();
            this.confirmInputButton = new System.Windows.Forms.Button();
            this.confirmOutputButton = new System.Windows.Forms.Button();
            this.selectOutputButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cypher key:";
            // 
            // cypherButton
            // 
            this.cypherButton.Location = new System.Drawing.Point(18, 132);
            this.cypherButton.Name = "cypherButton";
            this.cypherButton.Size = new System.Drawing.Size(433, 33);
            this.cypherButton.TabIndex = 1;
            this.cypherButton.Text = "Cypher the message";
            this.cypherButton.UseVisualStyleBackColor = true;
            this.cypherButton.Click += new System.EventHandler(this.cypherButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(130, 28);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(321, 29);
            this.keyTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message:";
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Location = new System.Drawing.Point(130, 63);
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.Size = new System.Drawing.Size(321, 29);
            this.cypherTextBox.TabIndex = 9;
            // 
            // decypherButton
            // 
            this.decypherButton.Location = new System.Drawing.Point(18, 206);
            this.decypherButton.Name = "decypherButton";
            this.decypherButton.Size = new System.Drawing.Size(433, 33);
            this.decypherButton.TabIndex = 10;
            this.decypherButton.Text = "Decypher the message";
            this.decypherButton.UseVisualStyleBackColor = true;
            this.decypherButton.Click += new System.EventHandler(this.decypherButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Message:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Message:";
            // 
            // cypheredTextBox
            // 
            this.cypheredTextBox.Location = new System.Drawing.Point(130, 171);
            this.cypheredTextBox.Name = "cypheredTextBox";
            this.cypheredTextBox.Size = new System.Drawing.Size(321, 29);
            this.cypheredTextBox.TabIndex = 20;
            // 
            // decypherTextBox
            // 
            this.decypherTextBox.Location = new System.Drawing.Point(130, 245);
            this.decypherTextBox.Name = "decypherTextBox";
            this.decypherTextBox.Size = new System.Drawing.Size(321, 29);
            this.decypherTextBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.decypherTextBox);
            this.groupBox1.Controls.Add(this.cypherButton);
            this.groupBox1.Controls.Add(this.cypheredTextBox);
            this.groupBox1.Controls.Add(this.keyTextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cypherTextBox);
            this.groupBox1.Controls.Add(this.decypherButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 276);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cypher settings";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(182, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(66, 28);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ECB";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(269, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 28);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CBC";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Moda:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.confirmOutputButton);
            this.groupBox2.Controls.Add(this.selectOutputButton);
            this.groupBox2.Controls.Add(this.confirmInputButton);
            this.groupBox2.Controls.Add(this.selectInputButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(475, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 269);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "External input/output";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 29);
            this.textBox1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Output:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(360, 29);
            this.textBox2.TabIndex = 29;
            // 
            // selectInputButton
            // 
            this.selectInputButton.Location = new System.Drawing.Point(18, 63);
            this.selectInputButton.Name = "selectInputButton";
            this.selectInputButton.Size = new System.Drawing.Size(193, 33);
            this.selectInputButton.TabIndex = 30;
            this.selectInputButton.Text = "Select path";
            this.selectInputButton.UseVisualStyleBackColor = true;
            // 
            // confirmInputButton
            // 
            this.confirmInputButton.Location = new System.Drawing.Point(258, 63);
            this.confirmInputButton.Name = "confirmInputButton";
            this.confirmInputButton.Size = new System.Drawing.Size(193, 33);
            this.confirmInputButton.TabIndex = 31;
            this.confirmInputButton.Text = "Read";
            this.confirmInputButton.UseVisualStyleBackColor = true;
            // 
            // confirmOutputButton
            // 
            this.confirmOutputButton.Location = new System.Drawing.Point(258, 200);
            this.confirmOutputButton.Name = "confirmOutputButton";
            this.confirmOutputButton.Size = new System.Drawing.Size(193, 33);
            this.confirmOutputButton.TabIndex = 33;
            this.confirmOutputButton.Text = "Write";
            this.confirmOutputButton.UseVisualStyleBackColor = true;
            // 
            // selectOutputButton
            // 
            this.selectOutputButton.Location = new System.Drawing.Point(18, 200);
            this.selectOutputButton.Name = "selectOutputButton";
            this.selectOutputButton.Size = new System.Drawing.Size(193, 33);
            this.selectOutputButton.TabIndex = 32;
            this.selectOutputButton.Text = "Select path";
            this.selectOutputButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 288);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "AES algorithm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button confirmOutputButton;
        private System.Windows.Forms.Button selectOutputButton;
        private System.Windows.Forms.Button confirmInputButton;
        private System.Windows.Forms.Button selectInputButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

