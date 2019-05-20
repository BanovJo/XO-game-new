using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form2 : Form
    {
        bool turn = true;
        int turn_count = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkForWiner();
           
        }

        private void newGame1(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void checkForWiner()
        {
            bool winner = false;
            if ((b11.Text == b12.Text) && (b12.Text == b13.Text) && (!b11.Enabled))
                winner = true;
            else if ((b21.Text == b22.Text) && (b22.Text == b23.Text) && (!b21.Enabled))
                winner = true;
            else if ((b31.Text == b32.Text) && (b32.Text == b33.Text) && (!b31.Enabled))
                winner = true;
            
           else if ((b11.Text == b21.Text) && (b21.Text == b31.Text) && (!b11.Enabled))
                winner = true;
            else if ((b12.Text == b22.Text) && (b22.Text == b32.Text) && (!b12.Enabled))
                winner = true;
            else if ((b13.Text == b23.Text) && (b23.Text == b33.Text) && (!b13.Enabled))
                winner = true;

            else if ((b11.Text == b22.Text) && (b22.Text == b33.Text) && (!b11.Enabled))
                winner = true;
            else if ((b13.Text == b22.Text) && (b22.Text == b31.Text) && (!b13.Enabled))
                winner = true;
                
            if (winner)
            {
              
                String w_inner = "";
                if (turn) w_inner = "O";
                else w_inner = "X";

                MessageBox.Show(w_inner + " WINS!");
                nwGm();
            }
            else
            {
                if (turn_count == 9) {
                    MessageBox.Show("Draw");
                    nwGm();
                }
               
            }
            
        }

        private void nwGm()
        {
            new Form2().Show();
            this.Hide();
        }
        }
}
