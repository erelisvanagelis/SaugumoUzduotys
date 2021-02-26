using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saugumas_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyTextBoxChanged(object sender, EventArgs e)
        {
            currentLabel.Text = keyTextBox.Text.Length.ToString();
        }

        private void KeySizeRadioButtonChanged(object sender, EventArgs e)
        {
            foreach(RadioButton r in keySizeGroupBox.Controls)
            {
                if (r.Checked == true)
                {
                    maxLabel.Text = (Convert.ToInt32(r.Text) / 8).ToString();
                }

            }
        }

        private void cypherButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mode;
                if(ecbRadioButton.Checked == true)
                {
                    mode = "ECB";
                }
                else
                {
                    mode = "CBC";
                }
                Cypher cypher = new Cypher(cypherTextBox.Text, keyTextBox.Text, maxLabel.Text, mode);
                //richTextBox1.Text = cypher.CypherMessage();
                cypheredTextBox.Text = cypher.CypherMessage();
                //cypher.Main();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void decypherButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mode;
                if (ecbRadioButton.Checked == true)
                {
                    mode = "ECB";
                }
                else
                {
                    mode = "CBC";
                }
                Cypher cypher = new Cypher(cypheredTextBox.Text, keyTextBox.Text, maxLabel.Text, mode);
                decypherTextBox.Text = cypher.DecypherMessage();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void selectInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.ShowDialog();
                inputTextBox.Text = openFileDialog.FileName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void selectOutputButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.ShowDialog();
                outputTextBox.Text = openFileDialog.FileName;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void readInputButton_Click(object sender, EventArgs e)
        {
            try
            {
                cypherTextBox.Text = System.IO.File.ReadAllText(inputTextBox.Text);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void writeOutputButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(outputTextBox.Text, cypheredTextBox.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
