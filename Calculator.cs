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

        private double _currentValue = 0;
        private double _result = 0; // to co obliczyło
        private string _lastOperation = null; // która operacja ma sie wykonać
        public void Plus(string display)
        {
            string function = "+";
            _lastOperation = function;
            _currentValue = double.Parse(display);
            Logic(display, function);
        }
        public void Minus(string display)
        {
            string function = "-";
            _lastOperation = function;
            _currentValue = double.Parse(display);
            Logic(display, function);            
        }
        public void Rownasie(string display)
        {
            string function = "=";
            Logic(display, function);
        }
        public void Razy(string display, int firstOpHandler)
        {
            string function = "*";
            _lastOperation = function;
            _result = _result + firstOpHandler;
            _currentValue = double.Parse(display);
            Logic(display, function);
        }
        public void Dzielenie(string display, int firstOpHandler)
        {
            string function = "/";
            _lastOperation = function;
            _result = _result + firstOpHandler;
            _currentValue = double.Parse(display);
            Logic(display, function);
        }
        
        private void Logic(string value, string function)
        {            
            switch (function)
            {
                case "+":
                    _result = _currentValue + _result;
                    break;
                case "-":
                    _result = _currentValue - _result;
                    break;
                case "*":
                    _result = _currentValue * _result;
                    break;
                case "/":
                    if (_result != 0)
                    {
                        _result = _currentValue / _result;
                    }
                    else
                    {
                        Console.WriteLine("Błąd: Dzielenie przez zero!");
                        _result = 0; // lub inna wartość obsługująca błąd
                    }
                    break;
                case "=":
                    double value2 = double.Parse(value);
                    switch (_lastOperation)
                    {
                        case "+":
                            _result = _result + value2;                            
                            break;
                        case "-":
                            _result = _result - value2;
                            break;
                        case "*":
                            _result = _result * value2;
                            break;
                        case "/":
                            if (_result != 0)
                            {
                                _result = _result  / value2 ;
                            }
                            else
                            {
                                Console.WriteLine("Błąd: Dzielenie przez zero!");
                                _result = 0; // lub inna wartość obsługująca błąd
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:                    
                    break;
            }
        }
        public void Clean()
        {
            _currentValue = 0;
            _result = 0; // to co obliczyło
            _lastOperation = null; // która operacja ma sie wykonać
        }
        public void CleanEquals()
        {
            _currentValue = 0;
            //_result = 0; // to co obliczyło
            _lastOperation = null; // która operacja ma sie wykonać
        }


    }
}
