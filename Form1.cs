namespace Calc.WinFormsApp
{
    public enum Operation
    {
        None,
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
    public partial class Form1 : Form
    {
        private Operation _currentOperation = Operation.None;
        private string _firstValue;

        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }
        
        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            if (tbScreen.Text == "0")
                tbScreen.Text = string.Empty;
            var clickedValue = (sender as Button).Text;
            tbScreen.Text += clickedValue;
            
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;
            var operation = (sender as Button).Text;

            tbScreen.Text += $" {Operation}";

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Subtraction,
                "*" => Operation.Multiplication,
                "/" => Operation.Division,
                _ => Operation.None,
            };
        }

        
        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {

        }
    }
}