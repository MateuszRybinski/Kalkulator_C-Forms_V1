using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Kalkulator_V1
{
    internal class Calculator
    {


        
        private double _currentValue = 0;
        private double _result = 0; // to co obliczyło
        private string _lastOperation = null; // która operacja ma sie wykonać

        public string displayResult()
        {
            string value = _result.ToString();
            return value;
        }
        public string displayIndicator()
        {
            string value = _lastOperation.ToString();
            return value;
        }


        public void Plus(string display)
        {
            string function = "+";
            _currentValue = double.Parse(display);
            Logic(display, function);
            Console.WriteLine("calculator"+_result);
        }
        
        private void Logic(string value, string function)
        {            
            switch (function)
            {
                case "+":
                    _result = _currentValue + _result;
                    break;
                case "-":
                    Console.WriteLine("Wybrałeś opcję B");
                    break;
                case "C":
                    Console.WriteLine("Wybrałeś opcję C");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa opcja");
                    break;
            }
        }

        //public void Minus(string display)
        //{
        //    string function = "-";
        //}
        //public void Ruwnasie(string display)
        //{
        //    string function = "=";
        //}
    }
}
