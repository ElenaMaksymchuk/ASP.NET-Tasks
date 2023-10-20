using Microsoft.AspNetCore.Mvc;

namespace WebAppDemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController
    {
        [HttpGet("Addition")]
        public string Addition(string a, string b)
        {
            string result = string.Empty;
            double number1, number2;                          
            if (!double.TryParse(a, out number1) && !double.TryParse(b, out number2)) 
                result = "Error. Both a and b are not a numbers.";
            else if (!double.TryParse(a, out number1))
                result = "Error. a is not a number.";
            else if (!double.TryParse(b, out number2))
                result = "Error. b is not a number.";
            else
                result = $"{number1} + {number2} = {number1 + number2}";
            return result;                
        }
        [HttpGet("Subtraction")]
        public string Subtraction(string a, string b)
        {
            string result = string.Empty;
            double number1, number2;
            if (!double.TryParse(a, out number1) && !double.TryParse(b, out number2))
                result = "Error. Both a and b are not a numbers.";
            else if (!double.TryParse(a, out number1))
                result = "Error. a is not a number.";
            else if (!double.TryParse(b, out number2))
                result = "Error. b is not a number.";
            else
                result = $"{number1} - {number2} = {number1 - number2}";
            return result;
        }
        [HttpGet("Multiplication")]
        public string Multiplication(string a, string b)
        {
            string result = string.Empty;
            double number1, number2;
            if (!double.TryParse(a, out number1) && !double.TryParse(b, out number2))
                result = "Error. Both a and b are not a numbers.";
            else if (!double.TryParse(a, out number1))
                result = "Error. a is not a number.";
            else if (!double.TryParse(b, out number2))
                result = "Error. b is not a number.";
            else
                result = $"{number1} * {number2} = {number1 * number2}";
            return result;
        }
        [HttpGet("Division")]
        public string Division(string a, string b)
        {
            string result = string.Empty;
            double number1, number2;
            if (!double.TryParse(a, out number1) && !double.TryParse(b, out number2))
                result = "Error. Both a and b are not a numbers.";
            else if (!double.TryParse(a, out number1))
                result = "Error. a is not a number.";
            else if (!double.TryParse(b, out number2))
                result = "Error. b is not a number.";
            else if(number2 == 0)
                result = "Error. Can't be divided by 0.";
            else
                result = $"{number1} / {number2} = {number1 / number2}";
            return result;
        }
        [HttpGet("Calculation")]
        public string Division(string a, string operation, string b)
        {
            string result = string.Empty;
            double number1, number2;
            if (!double.TryParse(a, out number1) && !double.TryParse(b, out number2))
                result = "Error. Both a and b are not a numbers.";
            else if (!double.TryParse(a, out number1))
                result = "Error. a is not a number.";
            else if (!double.TryParse(b, out number2))
                result = "Error. b is not a number.";
            else if (number2 == 0)
                result = "Error. Can't be divided by 0.";
            else
            {
                if(operation == "addition")
                    result = $"{number1} + {number2} = {number1 + number2}";
                if (operation == "subtraction")
                    result = $"{number1} - {number2} = {number1 - number2}";
                if (operation == "multiplication")
                    result = $"{number1} * {number2} = {number1 * number2}";
                if (operation == "division")
                    result = $"{number1} / {number2} = {number1 / number2}";
            }
            return result;
        }
    }
}
