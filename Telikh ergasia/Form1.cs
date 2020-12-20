using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telikh_ergasia
{
    public partial class Form1 : Form
    {
        public static SlotMachine st = new SlotMachine();     //δημιουργια ατικειμενων για στηλες και φρουτα
        public static SlotMachine st2 = new SlotMachine();
        public static int kerdp, kerdm;                  //μεταβλητες για τα συνολικα εσοδα εξοδα του κουλοχερι
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Form2 play1 = new Form2();     //ανοιγμα κλασικου κουλοχερι
            play1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΟΔΗΓΙΕΣ ΠΑΙΧΝΙΔΙΟΥ:" + Environment.NewLine + "Ο κλασικός κουλοχέρι παίζεται με τρεις στήλες αποτελούμενος από 4 φρουτάκια.Κερδίζεις μόνο αν φέρεις τρία ίδια φρουτάκια.Πετυχαίνοντας τρία ίδια βατόμουρα ή λεμόνια τότε κερδίζεις το τετραπλάσιο ποσό, πετυχαίνοντας τρία ίδια μήλα ή φράουλες κερδίζεις το οκταπλάσιο ποσό.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();     //εξοδος εφαρμογης
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && Convert.ToInt16(textBox1.Text) >= 3 && Convert.ToInt16(textBox1.Text) <= 8)   //ελεγχος συγκεκριμενων στηλων
            {
                if (textBox2.Text != "" && Convert.ToInt16(textBox2.Text) >= 4 && Convert.ToInt16(textBox2.Text) <= 7)   //ελεγχος συγκεκριμενων φρουτων
                {
                   st.SetSlot(Int16.Parse(textBox1.Text));
                    st2.SetSlot(Int16.Parse(textBox2.Text));
                  

                    Form3 play2 = new Form3(st.GetSlot(), st2.GetSlot());      //αν ισχυει ανοιγμα προχωρημενου κουλοχερη με τα ορισματα αριθμων στηλης φρουτο
                    play2.Show();
                }
                else
                    MessageBox.Show("Μπορείς να παίξεις μόνο με 4 εως 7 διαφορετικά φρουτάκια.");
            }
            else
                MessageBox.Show("Μπορείς να παίξεις μόνο απο 3 εως 8 στήλες.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;                   //να δεχεται μονο αριθμους
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;          //να δεχεται μονο αριθμους
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Επιλέξτε πόσες στήλες και πόσα φρουτακια να διαθετει η κάθε στήλη. Μπορειτε να παιξετε απο 3 μεχρι 8 στηλες και με 4 εως 7 διαφορετικα φρουτάκια.Στην επιλογη 3 ή 4 στηλων κερδιζεις αν ερθουν και οι 3 ή 4 στηλες ιδιες αντιστοιχα. Στην επιλογη των 5, 6, 7 ή 8 στηλων θα κερδιζει με δυνατη αποκληση δυο φρουτων!!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Οι παίχτες έχουν δώσει στο μηχάνημα " + kerdm + " ευρω, ενώ οι παίχτες έχουν κερδίσει " + kerdp + " ευρώ.");
        }
    }
}
