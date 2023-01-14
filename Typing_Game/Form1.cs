using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Game
{
    public partial class Form1 : Form
    {

        string[] words = { "internet", "programming", "moodle", "coding" };

        Random rnd = new Random();
        int incorrect = 0;
        int correct = 0;


        public Form1()
        {
            InitializeComponent();

            lblWord.Text = words[rnd.Next(0, words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text ==lblWord.Text)
                {
                    correct++;
                    lblWord.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                else
                {
                    incorrect++;
                    lblWord.Text = words[rnd.Next(0, words.Length)];
                    textBox1.Text = null;
                }

                lblRight.Text = "Correct" + correct;
                lblWrong.Text = "Wrong" + incorrect;
            }
        }
    }
}
