namespace Calculator.Models
{
    public class CalculatorModel
    {
        public string Display { get; set; } = "0";
        public string Previous { get; set; } = "";
        public string? Operation { get; set; } = null;
        public string Current { get; set; } = "0";
    }
}