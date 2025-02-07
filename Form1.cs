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

            label2.Text = "";
            label1.Text = "";
        }

        #region 1_9Buttony
        private void butt0_Click(object sender, EventArgs e)
        {
            string buttonValue = "0";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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
        private void butt1_Click(object sender, EventArgs e)
        {
            string buttonValue = "1";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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













        private void butt3_Click(object sender, EventArgs e)
        {

            string buttonValue = "3";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

        private void butt4_Click(object sender, EventArgs e)
        {
            string buttonValue = "4";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

        private void butt5_Click(object sender, EventArgs e)
        {
            string buttonValue = "5";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

        private void butt6_Click(object sender, EventArgs e)
        {
            string buttonValue = "6";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

        private void butt7_Click(object sender, EventArgs e)
        {
            string buttonValue = "7";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

        private void butt8_Click(object sender, EventArgs e)
        {
            string buttonValue = "8";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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

        private void butt9_Click(object sender, EventArgs e)
        {
            string buttonValue = "9";

            if (_wasFunctionKeyPressed == true)
            {
                listBox.Items.Clear();
                listBox.Items.Add(buttonValue);
                _wasFunctionKeyPressed = false;
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
        #endregion

        bool _wasFunctionKeyPressed = false;
        string _whatFunctionKey;

        

       
        private void buttPlus_Click(object sender, EventArgs e)
        {
            if (_wasFunctionKeyPressed == true) //
            {
                _whatFunctionKey = "+";//non sesne now....
                
            }
            else
            {
                _wasFunctionKeyPressed = true;
                _whatFunctionKey = "+";
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
            if (listBox.Items.Count > 0)
            {
                string currentText = listBox.Items[0].ToString();
                listBox.Items.Clear();
                calc.Rownasie(currentText);
                label2.Text = "";
                label1.Text = "";
                listBox.Items.Add(calc.displayResult());
                calc.Clean();
            }
        }
        private void buttMinus_Click(object sender, EventArgs e)
        {            
            if (_wasFunctionKeyPressed == true) //
            {
                _whatFunctionKey = "-";////non sesne now....
            }
            else
            {
                _wasFunctionKeyPressed = true;
                _whatFunctionKey = "-";
                string currentText = listBox.Items[0].ToString();

                listBox.Items.Clear();

                calc.Minus(currentText);
                label2.Text = calc.displayResult();
                label1.Text = calc.displayIndicator();
                listBox.Items.Add(calc.displayResult());
            }

        }
        private void buttRazy_Click(object sender, EventArgs e)
        {
            if (_wasFunctionKeyPressed == true) //
            {
                _whatFunctionKey = "*";////non sesne now....
            }
            else
            {
                if (label2.Text == "")
                {
                    _wasFunctionKeyPressed = true;
                    _whatFunctionKey = "*";
                    string currentText = listBox.Items[0].ToString();
                    int firstOpHandler = 1;
                    listBox.Items.Clear();

                    calc.Razy(currentText, firstOpHandler);
                    label2.Text = calc.displayResult();
                    label1.Text = calc.displayIndicator();
                    listBox.Items.Add(calc.displayResult());
                }
                else
                {
                    _wasFunctionKeyPressed = true;
                    _whatFunctionKey = "*";
                    string currentText = listBox.Items[0].ToString();
                    int firstOpHandler = 0;
                    listBox.Items.Clear();

                    calc.Razy(currentText, firstOpHandler);
                    label2.Text = calc.displayResult();
                    label1.Text = calc.displayIndicator();
                    listBox.Items.Add(calc.displayResult());
                }
                
            }
            
        }

        private void buttDzielenie_Click(object sender, EventArgs e)
        {
            if (_wasFunctionKeyPressed == true) //
            {
                _whatFunctionKey = "/";//non sesne now....
            }
            else
            {
                if (label2.Text == "")
                {
                    _wasFunctionKeyPressed = true;
                    _whatFunctionKey = "/";
                    string currentText = listBox.Items[0].ToString();
                    int firstOpHandler = 1;
                    listBox.Items.Clear();

                    calc.Dzielenie(currentText, firstOpHandler);
                    label2.Text = calc.displayResult();
                    label1.Text = calc.displayIndicator();
                    listBox.Items.Add(calc.displayResult());
                }
                else
                {
                    _wasFunctionKeyPressed = true;
                    _whatFunctionKey = "/";
                    string currentText = listBox.Items[0].ToString();
                    int firstOpHandler = 0;
                    listBox.Items.Clear();

                    calc.Dzielenie(currentText, firstOpHandler);
                    label2.Text = calc.displayResult();
                    label1.Text = calc.displayIndicator();
                    listBox.Items.Add(calc.displayResult());
                }

            }
        }
        

        private void buttDel_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "";
            listBox.Items.Clear();
            calc.Clean();
        }

        private void buttDot_Click(object sender, EventArgs e)
        {
            string buttonValue = ",";
            string currentText = listBox.Items[0].ToString();
            if (currentText.Contains(","))
            {
                currentText = currentText.Replace(",", "");
                listBox.Items[0] = currentText;
            }
            else
            {
                listBox.Items[0] = currentText + buttonValue;
            }
        }

        private void buttPM_Click(object sender, EventArgs e)
        {
            string buttonValue = "-";
            string currentText = listBox.Items[0].ToString();
            if (currentText.Contains("-"))
            {
                currentText = currentText.Replace("-", "");
                listBox.Items[0] =  currentText;
            }
            else
            {
                listBox.Items[0] = buttonValue + currentText;
            }
            
           
        }

       
    }
}
