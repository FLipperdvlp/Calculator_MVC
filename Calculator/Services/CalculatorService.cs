using Calculator.Models;

namespace Calculator.Services
{
    public class CalculatorService
    {
        private CalculatorModel model = new CalculatorModel();

        public CalculatorModel GetModel() => model;

        public void Press(string value, string action)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (model.Current == "0" && value != ".")
                    model.Current = value;
                else if (!(value == "." && model.Current.Contains(".")))
                    model.Current += value;
            }
            else if (!string.IsNullOrEmpty(action))
            {
                switch (action)
                {
                    case "clear":
                        model = new CalculatorModel();
                        break;

                    case "toggle":
                        if (double.TryParse(model.Current, out double t))
                            model.Current = (t * -1).ToString();
                        break;

                    case "percent":
                        if (double.TryParse(model.Current, out double p))
                            model.Current = (p / 100).ToString();
                        break;

                    case "add":
                    case "subtract":
                    case "multiply":
                    case "divide":
                        model.Previous = model.Current;
                        model.Current = "0";
                        model.Operation = action;
                        break;

                    case "equals":
                        if (!string.IsNullOrEmpty(model.Operation) &&
                            double.TryParse(model.Previous, out double a) &&
                            double.TryParse(model.Current, out double b))
                        {
                            double result = model.Operation switch
                            {
                                "add" => a + b,
                                "subtract" => a - b,
                                "multiply" => a * b,
                                "divide" => b != 0 ? a / b : double.NaN,
                                _ => 0
                            };

                            model.Current = result.ToString();
                            model.Previous = "";
                            model.Operation = null;
                        }
                        break;
                }
            }

            model.Display = model.Current;
        }
    }
}