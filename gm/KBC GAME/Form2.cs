using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KBC_GAME
{
    public partial class KBC : Form
    {
         Form3 F3 = new Form3();
        public KBC()
        {
            InitializeComponent();

            Form3 F3 = new Form3();
        }

        private void Form2_Load(object sender, EventArgs e)

           
        {
            
            Question_box.Text = "WHO WAS THE FOUNDER OF PAKISTAN?";
            OPT_1.Text = "QUAID -E- AZAM";
            OPT_2.Text="ALLAMA IQBAL";
            OPT_3.Text="LIAQUAT ALI KHAN";
            OPT_4.Text="ZUBAIR";
            Question_box.Enabled = false;
                
        }

        private void OPT_1_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHO WAS THE FOUNDER OF PAKISTAN?")
            {

                Question_box.Text = "WHEN DID SOVIENT UNION BREAK DOWN ?";
                OPT_1.Text = "A ) 1969";
                OPT_2.Text = "B) 1979";
                OPT_3.Text = "C) 1989";
                OPT_4.Text = "D) 1999";
               

       
                
                
                
        

            }
            else if (Question_box.Text == "WHICH IS THE COMMON EUROPIAN CURRENCY ?")
            {
                
                
                
                Question_box.Text = "WHAT IS THE SYMBOL OF VICTORY ?";
                OPT_1.Text = "A ) DOWNWARD THUMB";
                OPT_2.Text = "B) DOVE WITH OLIVE BRANCHES";
                OPT_3.Text = "C) HORES";
                OPT_4.Text = "D) TWO FINGER IN V SHAPE";
               

      
            }
            else if (Question_box.Text == "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?")
            {

                
             
                
                Question_box.Text = "WHO ADOPTED UNIVERSAL DECLARATION OF HUMAN RIGHTS ?";
                OPT_1.Text = "A ) AMNESTY INTERNATIONAL";
                OPT_2.Text = "B) U N";
                OPT_3.Text = "C) NATO";
                OPT_4.Text = "D) COMMON WEALTH";
               
               
               

            }
            else if (Question_box.Text == "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?")
            {
               
                Question_box.Text = "WHO WAS ALSO A BRITISH CITIZEN ?";
                OPT_1.Text = "A ) ADOLF HITLER";
                OPT_2.Text = "B) SARDAR PATEL";
                OPT_3.Text = "C) PANDIT NEHRU";
                OPT_4.Text = "D) BENITTO MUSSOLINI";
               
                
                



            }
            else if (Question_box.Text == "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?")
            {



               
               
                Question_box.Text = "WHICH PAKISTHANI LEADER SIGNED SIMLA AGREEMENT ?";
                OPT_1.Text = "A)ZIA HL HAQ";
                OPT_2.Text = "B) AGAB KHAN";
                OPT_3.Text = "C) ZULFIKAR ALI BHUTTO";
                OPT_4.Text = "D) YAHYA KHAN";

              
               





            }
            else
            {
                
                this.Hide();
                Form3 F3 = new Form3();
                F3.Show();
            }

        }

        private void OPT_2_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHO ADOPTED UNIVERSAL DECLARATION OF HUMAN RIGHTS ?")
            {


               
                Question_box.Text = "WHO PATRONISED KALIDAS ?";
                OPT_1.Text = "A) AKBAR";
                OPT_2.Text = "B) CHANDRAGUPTH";
                OPT_3.Text = "C) VIKRAMADHITHYA";
                OPT_4.Text = "D) KRISHNADEVARAYA";
           
               



            }
            
            else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
            {


               
                Question_box.Text = "WHICH IS THE COMMON EUROPIAN CURRENCY ?";
                OPT_1.Text = "A ) EURO";
                OPT_2.Text = "B) YEN";
                OPT_3.Text = "C) EUROPEAN CURRENCY";
                OPT_4.Text = "D) POUND";
               
                
            }
            else if (Question_box.Text == "HOW DO YOU SAY GOOD BYE IN JAPANESE ?")
            {

                
                
                Question_box.Text = "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?";
                OPT_1.Text = "A ) 2";
                OPT_2.Text = "B) 3";
                OPT_3.Text = "C) 1";
                OPT_4.Text = "D) 4";
                
                
                F3.Show();
                
                



            }
            else
            {
           
                this.Hide();
                Form3 F3 = new Form3();
                F3.Show();
                this.Hide();
                
            }
            


        }

        private void OPT_3_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHEN DID SOVIENT UNION BREAK DOWN ?")
            {
                Question_box.Text = "WHICH OF THESE IS A SYMBOL OF PEACE ?";
                OPT_1.Text = "A ) LOTUS";
                OPT_2.Text = "B) TWO LEAVES";
                OPT_3.Text = "C) HAND";
                OPT_4.Text = "D) DOVE WITH OILVE BRANCH";
               
               
               
               
            }
            else if (Question_box.Text == "WHO PATRONISED KALIDAS ?")
            {
               
                Question_box.Text = "WHO TOUCH TURNED ALL TO GOLD ?";
                OPT_1.Text = "A ) ARGUS";
                OPT_2.Text = "B) AURALIUS";
                OPT_3.Text = "C) AURUM";
                OPT_4.Text = "D) MIDAS";
                
             

            }
            else if (Question_box.Text == "WHO WAS ALSO A BRITISH CITIZEN ?")
            {
               
                Question_box.Text = "HOW DO YOU SAY GOOD BYE IN JAPANESE ?";
                OPT_1.Text = "A ) NA HONDO";
                OPT_2.Text = "C) SHO YU";
                OPT_3.Text = "B) SAYONARA";
                OPT_4.Text = "D) WAKA";
               
                


            }


            else
            {
                
                Form3 F3 = new Form3();
                F3.Show();
               
                this.Hide();
            }

        }

        private void OPT_4_Click(object sender, EventArgs e)
        {
            if (Question_box.Text == "WHICH OF THESE IS A SYMBOL OF PEACE ?")
            {
              
                Question_box.Text = "WHICH OF THESE ANIMALS LAUGHS ?";
                OPT_1.Text = "A ) TIGER";
                OPT_2.Text = "B) HYNA";
                OPT_3.Text = "C) RHINO";
                OPT_4.Text = "D) ZEEBRA";
         
               

            }

            else if (Question_box.Text == "WHAT IS THE SYMBOL OF VICTORY ?")
            {


        

                Question_box.Text = "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?";
                OPT_1.Text = "A ) GANESH";
                OPT_2.Text = "B) VEDA VYAS";
                OPT_3.Text = "C) VALMIKI";
                OPT_4.Text = "D) DUSHASAN";
                label6.Text = "6) 20,000";
                label6.BackColor = System.Drawing.Color.Indigo;
              
              
                


            }
            else if (Question_box.Text == "WHO TOUCH TURNED ALL TO GOLD ?")
            {


             
                Question_box.Text = "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?";
                OPT_1.Text = "A ) WALL";
                OPT_2.Text = "B) KINGS HORSE";
                OPT_3.Text = "C) TREE";
                OPT_4.Text = "D) THRONE";

               


            }
            else
            {
            
                Form3 F3 = new Form3(); 
                F3.Show();
          
                this.Hide();
                
            }
        }

        
        
        

        private void label17_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            if (Question_box.Text == "IN WHICH DIRECTION DOES A MUSLIM PRAY ?")
            {
            
              
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH IS THE COMMON EUROPIAN CURRENCY ?")
            {
               
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO LOST HIS TEETH WHILE WRITING MAHABHARAT ?")
            {
              
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "IN THE RHYME WHERE DID HUMPTY DUMPTY SIT ?")
            {
               
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "HOW MANY OF ENGLISH MUNARCHS ARE NAMED ELIZABETH ?")
            {
               
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH PAKISTHANI LEADER SIGNED SIMLA AGREEMENT ?")
            {
               
                F3.Show();
                this.Hide();
            }

            else if (Question_box.Text == "WHEN DID SOVIENT UNION BREAK DOWN ?")
            {
             
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH OF THESE ANIMALS LAUGHS ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "HOW DO YOU SAY GOOD BYE IN JAPANESE ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO PATRONISED KALIDAS ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO WAS ALSO A BRITISH CITIZEN ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHICH OF THESE IS A SYMBOL OF PEACE ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHAT IS THE SYMBOL OF VICTORY ?")
            {
                F3.Show();
                this.Hide();
            }
            else if (Question_box.Text == "WHO TOUCH TURNED ALL TO GOLD ?")
            {
                F3.Show();
                this.Hide();
            }
            else
            {
            }
        }

        private void Question_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
    }
}
