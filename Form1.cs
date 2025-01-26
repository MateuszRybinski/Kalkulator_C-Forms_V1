using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kalkulator_V1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region Wygląd_Buttonów
        private void SetButton1_9()
        {
            // Tablica przycisków, dla których zmieniamy kolor i czcionkę
            Button[] buttons = new Button[]
            {
            butt1, butt2, butt3, butt4, butt5, butt6, butt7, butt8, butt9, butt0
            };

            Font buttonFont = new Font("Tahoma", 20);



            foreach (var button in buttons)
            {
                button.BackColor = Color.FromArgb(59, 59, 59);
                button.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.Font = buttonFont;

                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(47, 47, 49); 
                button.FlatAppearance.BorderColor = Color.FromArgb(50, 50, 50); 
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(59, 59, 59);
            }            
        }
        private void SetButtonFunction()
        {           
            Button[] buttons = new Button[]
            {
                //butt0, butt1, butt2, butt3, butt4, butt5, butt6, butt7, butt8, butt9, // Cyfry
                buttRuwnasie, buttMinus, buttRazy, buttDzielenie, buttPercent,buttPM, buttMinus, buttDot, buttDel// Operatory
            };
            
            Font buttonFont = new Font("Tahoma", 20);
            
            foreach (var button in buttons)
            {                
                button.BackColor = Color.FromArgb(47, 47, 49);//tło przycisków                
                button.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);//kolor obramowania przycisków                
                button.ForeColor = Color.White;//kolor tekstu przycisków na biały                
                button.FlatStyle = FlatStyle.Flat;//styl przycisków na "płaski" (bez standardowego 3D)
                button.Font = buttonFont;//czcionkę dla przycisków

                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 59, 59); // Tło po najechaniu
                button.FlatAppearance.BorderColor = Color.FromArgb(59, 59, 59); // Zmieniamy kolor obramowania po najechaniu                              
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(47, 47, 49);//Przycisniecie myszki
            }         
            
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.BackColor = Color.FromArgb(32, 32, 32);
            SetButton1_9();
            SetButtonFunction();

            listBox.Font = new Font("Tahoma", 30, FontStyle.Regular);           
            listBox.ForeColor = Color.White;
        }


        private void butt1_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy lista jest pusta
            if (listBox.Items.Count == 0)
            {
                // Jeśli lista jest pusta, dodaj pierwszy "1"
                listBox.Items.Add("1");
            }
            else
            {
                // Pobierz aktualny tekst z pierwszego elementu ListBox
                string currentText = listBox.Items[0].ToString();

                // Dopisz "1" do istniejącego tekstu
                currentText += "1";

                // Zaktualizuj element w ListBox
                listBox.Items[0] = currentText;
            }
        }

        private void butt2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void butt4_Click(object sender, EventArgs e)
        {

        }

        private void butt5_Click(object sender, EventArgs e)
        {

        }

        private void butt6_Click(object sender, EventArgs e)
        {

        }

        private void butt7_Click(object sender, EventArgs e)
        {

        }

        private void butt8_Click(object sender, EventArgs e)
        {

        }

        private void butt9_Click(object sender, EventArgs e)
        {

        }

        private void buttRuwnasie_Click(object sender, EventArgs e)
        {

        }

        private void buttMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttRazy_Click(object sender, EventArgs e)
        {

        }

        private void buttDzielenie_Click(object sender, EventArgs e)
        {

        }

        private void buttDel_Click(object sender, EventArgs e)
        {

        }

        private void buttDot_Click(object sender, EventArgs e)
        {

        }

        private void buttPM_Click(object sender, EventArgs e)
        {

        }

        private void buttPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
