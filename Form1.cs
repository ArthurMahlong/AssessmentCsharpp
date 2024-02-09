using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssessmentCsharpp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string word = txtInput.Text.Trim();

            if (String.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("You have to enter a word it cannot be left blank");
                return;
            }

            if (listBox1.Items.Contains(word))
            {
                MessageBox.Show("The word entered " + word + " already exits enter a another word");
                txtInput.Clear();
                return;
            }



            listBox1.Items.Add(txtInput.Text);
            
            MessageBox.Show(txtInput.Text + " has been added");

            txtInput.Clear();







        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string word = listBox1.SelectedItem.ToString().Trim();


            if (listBox1.SelectedIndex == -1 )
            {
                MessageBox.Show("Please select a word to update.");
                return;
            }
            if (string.IsNullOrEmpty(txtInput.Text))
            {
                MessageBox.Show("Please enter a word");
                return;
            }
            listBox1.Items[listBox1.SelectedIndex] = txtInput.Text;
            string newWord = txtInput.Text;
            MessageBox.Show("The word " + word + " is changed to "+ newWord);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedWord = "";
            //listBox1.SelectedItem = selectedWord;
            //txtInput.Text = selectedWord;
           // txtInput.Text = listBox1.SelectedItem.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string removedWord = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(listBox1.SelectedItem);
            MessageBox.Show(removedWord + " has been removed from the list.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("All items have been cleared from the list");
        }
    }
    
}
