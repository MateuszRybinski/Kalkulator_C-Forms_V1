using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Kalkulator_V1
{

    public partial class Form1 : Form
    {
        private Calculator calc;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();            
        }


        #region Wygląd_Buttonów
        private void SetVisualButt1_9()
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
                buttRuwnasie, buttMinus, buttPlus, buttDzielenie, buttRazy,buttPM, buttMinus, buttDot, buttDel// Operatory
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

            SetVisualButt1_9();
            SetButtonFunction();

            listBox.Font = new Font("Tahoma", 50, FontStyle.Regular);
            listBox.ForeColor = Color.White;
        }

        #region 1_9Buttony
        private void butt0_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                // Jeśli lista jest pusta, dodaj pierwszy "1"
                listBox.Items.Add("0");
            }
            else
            {
                // Pobierz aktualny tekst z pierwszego elementu ListBox
                string currentText = listBox.Items[0].ToString();

                // Dopisz "1" do istniejącego tekstu
                currentText += "0";

                // Zaktualizuj element w ListBox
                listBox.Items[0] = currentText;
            }
        }



        


        







        private void butt3_Click(object sender, EventArgs e)
        {
            
            if (listBox.Items.Count == 0)
            {               
                listBox.Items.Add("3");
            }
            else
            {               
                string currentText = listBox.Items[0].ToString();
                currentText += "3";
                listBox.Items[0] = currentText;
            }
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
        #endregion

        bool _klawiszFunkcyjnyByl = false;
        string _jakiKlawiszFunkcyjny;
        private void butt1_Click(object sender, EventArgs e)
        {
            string buttonValue = "1";
            
            if (_klawiszFunkcyjnyByl == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _klawiszFunkcyjnyByl = false;
            }
            else
            {
                if (listBox.Items.Count == 0)//handlowanie pustego pola
                {
                    listBox.Items.Add(buttonValue);
                }
                else
                {
                    string currentText = listBox.Items[0].ToString();
                    listBox.Items[0] = currentText + buttonValue;
                }
            }
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            string buttonValue = "2";

            if (_klawiszFunkcyjnyByl == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _klawiszFunkcyjnyByl = false;
            }
            else
            {
                if (listBox.Items.Count == 0)//handlowanie pustego pola
                {
                    listBox.Items.Add(buttonValue);
                }
                else
                {
                    string currentText = listBox.Items[0].ToString();
                    listBox.Items[0] = currentText + buttonValue;
                }
            }
        }
        

       
        private void buttPlus_Click(object sender, EventArgs e)
        {
            if (_klawiszFunkcyjnyByl == true) //zapobiega wykonaniu akcji po spamowaniu funkcji
            {
                
            }
            else
            {
                _klawiszFunkcyjnyByl = true;
                _jakiKlawiszFunkcyjny = "+";
                string currentText = listBox.Items[0].ToString();

                listBox.Items.Clear();

                calc.Plus(currentText);
                label2.Text = calc.displayResult();
                label1.Text = calc.displayIndicator();
                listBox.Items.Add(calc.displayResult());
            }
            

        }
        private void buttRuwnasie_Click(object sender, EventArgs e)
        {
            string currentText = listBox.Items[0].ToString();
            listBox.Items.Clear();
            calc.Rownasie(currentText);
            label2.Text = calc.displayResult();
            label1.Text = calc.displayIndicator();
            listBox.Items.Add(calc.displayResult());
            calc.Clean();
        }
        private void buttMinus_Click(object sender, EventArgs e)
        {
            
            string currentText = listBox.Items[0].ToString();
            
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

        private void buttRazy_Click(object sender, EventArgs e)
        {

        }

        //public void DisplayItemsInListBox(string value)
        //{
        //    if (isFunctionClicked == false)
        //    {
        //        if (listBox.Items.Count == 0)
        //        {
        //            listBox.Items.Add(value);
        //        }
        //        else
        //        {
        //            string currentText = listBox.Items[0].ToString();
        //            listBox.Items[0] = currentText + value;
        //        }
        //    }
        //    else
        //    {
        //        listBox.Items.Clear();
        //        listBox.Items.Add(value);
        //        isFunctionClicked = false;
        //    }
        //}
    }
}
