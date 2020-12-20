using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Telikh_ergasia
{
    public partial class Form3 : Form
    {
        public static int txt1;
        int krd;
       
       
       
        public static int txt2;
        public Money m = new Money();
        Random r = new Random();


        PictureBox[] pictureBoxs = new PictureBox[8];
        List<PictureBox> pictureBoxes = new List<PictureBox>();


    public Form3(int txt1, int txt2)
        {
            InitializeComponent();
            Form3.txt1 = txt1; //αποδοχη αριθμου στηλων και φρουτων
            Form3.txt2 = txt2;
            pictureBoxs[0] = pictureBox1;
            pictureBoxs[1] = pictureBox2;
            pictureBoxs[2] = pictureBox3;
            pictureBoxs[3] = pictureBox4;
            pictureBoxs[4] = pictureBox5;
            pictureBoxs[5] = pictureBox6;
            pictureBoxs[6] = pictureBox7;
            pictureBoxs[7] = pictureBox8;


        }
        public void kerdos(List<int> rnd)
        {
                                                          //συναρτηση αν κερδισε ο παιχτης αναλογα τις στηλες και τα φρουτα που διαλεξε
            krd = 0;
           
           if(Form1.st.GetSlot()==3)
            {               
                    if (rnd[0] == rnd[1] && rnd[0]==rnd[2])
                    {
                       m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), 1);
                       krd = m.GetKerdos();  
                    }                          
            }
           if(Form1.st.GetSlot()==4)
            {
                if(rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3])
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), 1);

                    krd = m.GetKerdos();
                }
            }
            if (Form1.st.GetSlot() == 5)
            {

                if ((rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3]) || (rnd[1]==rnd[2] && rnd[1]==rnd[3] && rnd[1] == rnd[4]) || (rnd[0]==rnd[2] && rnd[0]==rnd[3] && rnd[0] == rnd[4]) || (rnd[0] == rnd[1] && rnd[0] == rnd[3] && rnd[0] == rnd[4]) ||(rnd[0] == rnd[1] && rnd[0]==rnd[2] && rnd[0]==rnd[4] ))
                 {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), 1);
                    krd = m.GetKerdos();
                }
                else if((rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4]))
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), Form1.st2.GetSlot());
                    krd = m.GetKerdos();
                } 
                
            }
            if (Form1.st.GetSlot() == 6)
            {
                if ((rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0]==rnd[4]) || (rnd[1]==rnd[2] && rnd[1]==rnd[3] && rnd[1]==rnd[4] && rnd[1]==rnd[5]) || (rnd[0]==rnd[2] && rnd[0]==rnd[3] && rnd[0]==rnd[4] && rnd[0]==rnd[5]) || (rnd[0] == rnd[1] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[4] && rnd[0] == rnd[5]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[5]))
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), 1);
                    krd = 50 * m.GetKerdos();
                }
                else if(rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5])
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), Form1.st2.GetSlot());
                    krd = 100 * m.GetKerdos();
                }
                
            }
            if (Form1.st.GetSlot() == 7)
            {
                if ((rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5]) || (rnd[1] == rnd[2] && rnd[1] == rnd[3] && rnd[1] == rnd[4] && rnd[1] == rnd[5] && rnd[1] == rnd[6]) || (rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6]) || (rnd[0] == rnd[1] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[5] && rnd[0] == rnd[6]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[6]))
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), 1);
                    krd = 50 * m.GetKerdos();
                }
                else if (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6])
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), Form1.st2.GetSlot());
                    krd = 100 * m.GetKerdos();
                }
                
                
            }
            if (Form1.st.GetSlot() == 8)
            {
                if ((rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6]) || (rnd[1] == rnd[2] && rnd[1] == rnd[3] && rnd[1] == rnd[4] && rnd[1] == rnd[5] && rnd[1] == rnd[6] && rnd[1] == rnd[7]) || (rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6] && rnd[0] == rnd[7]) || (rnd[0] == rnd[1] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6] && rnd[0] == rnd[7]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6] && rnd[0] == rnd[7]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[5] && rnd[0] == rnd[6] && rnd[0] == rnd[7]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[6] && rnd[0] == rnd[7]) || (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[7]))
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), 1);
                    krd = 50 * m.GetKerdos();
                    
                }
                else if (rnd[0] == rnd[1] && rnd[0] == rnd[2] && rnd[0] == rnd[3] && rnd[0] == rnd[4] && rnd[0] == rnd[5] && rnd[0] == rnd[6] && rnd[0]==rnd[7])
                {
                    m.SetKerdos(Int16.Parse(textBox1.Text), Form1.st.GetSlot(), Form1.st2.GetSlot());
                    krd =100 * m.GetKerdos();
                }

            }


            Form1.kerdp += krd;                                         //οι μεταβλητες συνολικων εισοδων εξοδων
            Form1.kerdm += Int16.Parse(textBox1.Text);

            MessageBox.Show("Κερδισες " +krd.ToString() + " ευρώ.");
        }


       

        private void Form3_Load(object sender, EventArgs e)
        {
            


            pictureBox1.Image = Image.FromFile("1.png");          //εδω γινεται η αρχικοποιηση απο εικονες αναλογα ποσες στηλες 
            pictureBox2.Image = Image.FromFile("3.png");          //θα επιλεξει ο χρηστης 
            pictureBox3.Image = Image.FromFile("2.png");
            if (txt1 == 4)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("3.png");
                pictureBox3.Image = Image.FromFile("2.png");
                pictureBox4.Image = Image.FromFile("3.png");
            }
            else if (txt1 == 5)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("3.png");
                pictureBox3.Image = Image.FromFile("2.png");
                pictureBox4.Image = Image.FromFile("3.png");
                pictureBox5.Image = Image.FromFile("4.png");
            }
            else if (txt1 == 6)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("3.png");
                pictureBox3.Image = Image.FromFile("2.png");
                pictureBox4.Image = Image.FromFile("3.png");
                pictureBox5.Image = Image.FromFile("4.png");
                pictureBox6.Image = Image.FromFile("1.png");
            }
            else if (txt1 == 7)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("3.png");
                pictureBox3.Image = Image.FromFile("2.png");
                pictureBox4.Image = Image.FromFile("3.png");
                pictureBox5.Image = Image.FromFile("4.png");
                pictureBox6.Image = Image.FromFile("1.png");
                pictureBox7.Image = Image.FromFile("2.png");
            }
            else if (txt1 == 8)
            {
                pictureBox1.Image = Image.FromFile("1.png");
                pictureBox2.Image = Image.FromFile("3.png");
                pictureBox3.Image = Image.FromFile("2.png");
                pictureBox4.Image = Image.FromFile("3.png");
                pictureBox5.Image = Image.FromFile("4.png");
                pictureBox6.Image = Image.FromFile("1.png");
                pictureBox7.Image = Image.FromFile("2.png");
                pictureBox8.Image = Image.FromFile("4.png");
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            this.Close();            //κουμπι εξοδου
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(400);
            if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text) != 0)               //κουμπι play με ελεγχο αν στοιχηματισε
            {
              List<int> rnd = new List<int>();
                
                for (int j = 0; j <= txt1 - 1; j++)                   //επιλογή random αναλογα ποσα φρουτα ειναι για καθε στηλη
                {                    
                    int a = r.Next(1, txt2 + 1);
                    rnd.Add(a);
                    pictureBoxs[j].Image = Image.FromFile(a + ".png");                 
                }
                kerdos(rnd);         //συναρτηση με ορισμα τη λιστα rnd 

                Thread.Sleep(400);
            }

            else
                MessageBox.Show("Πρέπει πρώτα να στοιχηματίσεις");
            
            }
        }
    }









