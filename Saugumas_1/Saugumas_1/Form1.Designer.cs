
namespace Saugumas_1
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cypher key:";
            // 
            // cypherButton
            // 
            this.cypherButton.Location = new System.Drawing.Point(17, 80);
            this.cypherButton.Name = "cypherButton";
            this.cypherButton.Size = new System.Drawing.Size(433, 33);
            this.cypherButton.TabIndex = 1;
            this.cypherButton.Text = "Cypher the message";
            this.cypherButton.UseVisualStyleBackColor = true;
            this.cypherButton.Click += new System.EventHandler(this.cypherButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(129, 10);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(321, 29);
            this.keyTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message:";
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Location = new System.Drawing.Point(129, 45);
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.Size = new System.Drawing.Size(321, 29);
            this.cypherTextBox.TabIndex = 9;
            // 
            // decypherButton
            // 
            this.decypherButton.Location = new System.Drawing.Point(17, 154);
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
            this.label6.Location = new System.Drawing.Point(31, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Message:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 19;
            this.label10.Text = "Message:";
            // 
            // cypheredTextBox
            // 
            this.cypheredTextBox.Location = new System.Drawing.Point(129, 119);
            this.cypheredTextBox.Name = "cypheredTextBox";
            this.cypheredTextBox.Size = new System.Drawing.Size(321, 29);
            this.cypheredTextBox.TabIndex = 20;
            // 
            // decypherTextBox
            // 
            this.decypherTextBox.Location = new System.Drawing.Point(129, 193);
            this.decypherTextBox.Name = "decypherTextBox";
            this.decypherTextBox.Size = new System.Drawing.Size(321, 29);
            this.decypherTextBox.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 231);
            this.Controls.Add(this.decypherTextBox);
            this.Controls.Add(this.cypheredTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decypherButton);
            this.Controls.Add(this.cypherTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.cypherButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Vigenere algorithm";
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
    }
}

