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

        private void cypherButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cypher cypher = new Cypher(cypherTextBox.Text, keyTextBox.Text);
                cypheredTextBox.Text = cypher.CypherMessage();
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
                Cypher cypher = new Cypher(cypheredTextBox.Text, keyTextBox.Text);
                decypherTextBox.Text = cypher.DecypherMessage();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
