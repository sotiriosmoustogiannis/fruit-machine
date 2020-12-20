using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Telikh_ergasia
{
    public partial class Form2 : Form
    {
        Random r = new Random();
        public int a;
        public int b;
        public int c;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text) != 0)    //ελεγχος αν εχει καποιος στοιχηματισει
            {                
                             
                for (int i = 1; i <= 3; i++)
                {
                     a = r.Next(1, 5);   //επιλογη τυχαιων εικονων

                    if (a == 1)
                        pictureBox1.Image = Image.FromFile("1.png");
                    else if (a == 2)
                        pictureBox1.Image = Image.FromFile("2.png");
                    else if (a == 3)
                        pictureBox1.Image = Image.FromFile("3.png");
                    else if (a == 4)
                        pictureBox1.Image = Image.FromFile("4.png");

                     b = r.Next(1, 5);

                    if (b == 1)
                        pictureBox2.Image = Image.FromFile("1.png");
                    else if (b == 2)
                        pictureBox2.Image = Image.FromFile("2.png");
                    else if (b == 3)
                        pictureBox2.Image = Image.FromFile("3.png");
                    else if (b == 4)
                        pictureBox2.Image = Image.FromFile("4.png");

                     c = r.Next(1, 5);

                    if (c == 1)
                        pictureBox3.Image = Image.FromFile("1.png");
                    else if (c == 2)
                        pictureBox3.Image = Image.FromFile("2.png");
                    else if (c == 3)
                        pictureBox3.Image = Image.FromFile("3.png");
                    else if (c == 4)
                        pictureBox3.Image = Image.FromFile("4.png");

                    Thread.Sleep(500);  // μικρη παυση μεχρι το αποτελεσμα

                }
                int d;    //ορισμος μεταβλητης κερδους

                if (a==b && a==c && (a==2 || a==3))   // αν οι εικονες ειναι ιδιες με φρουτα που κερδιζουν τετραπλασιο ποσο
                {
                    d = 4 * Int32.Parse(textBox1.Text);
                    MessageBox.Show("You win " + d + " coins");
                }
                else if (a == b && a == c && (a == 1 || a == 4))   // αν οι εικονες ειναι ιδιες με φρουτα που κερδιζουν οκταπλασιο ποσο
                {
                    d = 8 * Int32.Parse(textBox1.Text);
                   MessageBox.Show("You win " + d + " coins");
                }
                else
                   MessageBox.Show("Έχασες τα χρηματά σου");                   
            }
            else
                MessageBox.Show("Πρέπει να στοιχηματίσεις πρώτα");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;                       //αποδοχη μονο αριθμων
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();    //εξοδος συγκεκριμενης φορμας
        }
    }
    
}
