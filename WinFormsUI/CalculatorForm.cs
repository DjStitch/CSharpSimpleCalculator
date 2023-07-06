using System.Globalization;
using Calculator.Core;

namespace Calculator.WinForms.UI;

public partial class CalculatorForm : Form
{
    private Core.Calculator? _calculator;
    private bool _xActive = true;

    public CalculatorForm()
    {
        InitializeComponent();
        InitializeCalculatorLogic();
    }

    private void InitializeCalculatorLogic()
    {
        _calculator = new Addition();
        BtnEquals.Enabled = false;
    }

    //just change something
    //Here it is

    private void PerformCalculation()
    {
        if (double.TryParse(txtNumber1.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out var x) &&
            double.TryParse(txtNumber2.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out var y))
            try
            {
                if (_calculator == null) return;
                var result = _calculator.Calculate(x, y);
                lblResult.Text = result.ToString(CultureInfo.InvariantCulture);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        else
            MessageBox.Show(@"Invalid numbers!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void PerformAction(double value)
    {
        var numberTextBox = _xActive ? txtNumber1 : txtNumber2;
        numberTextBox.Text = numberTextBox.Text.Trim() + value.ToString(CultureInfo.CurrentCulture);
    }

    private void SetOperatorControls(bool disable = true)
    {
        BtnAddition.Enabled = disable;
        BtnDivision.Enabled = disable;
        BtnMultiplication.Enabled = disable;
        BtnSubtraction.Enabled = disable;
        BtnEquals.Enabled = disable;
    }

    private void btnAddition_Click(object sender, EventArgs e)
    {
        SetOperatorControls();
        txtIndicator.Text = @"+";
        _xActive = false;
        _calculator = new Addition();
    }

    private void btnSubtraction_Click(object sender, EventArgs e)
    {
        SetOperatorControls();
        txtIndicator.Text = @"-";
        _xActive = false;
        _calculator = new Subtraction();
    }

    private void btnEquals_Click(object sender, EventArgs e)
    {
        lblEquals.Visible = true;
        PerformCalculation();
    }

    private void Button_Click(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var buttonValue = int.Parse(button.Text);
        PerformAction(buttonValue);
    }

    private void BtnClear_Click(object sender, EventArgs e)
    {
        _xActive = true;
        txtNumber1.Text = "";
        txtNumber2.Text = "";
        txtIndicator.Text = "";
        lblResult.Text = "";
        BtnEquals.Enabled = false;
        lblEquals.Visible = false;
        SetOperatorControls();
    }

    private void btnMultiplication_Click(object sender, EventArgs e)
    {
        SetOperatorControls();
        txtIndicator.Text = @"*";
        _xActive = false;
        _calculator = new Multiplication();
    }

    private void btnDivision_Click(object sender, EventArgs e)
    {
        SetOperatorControls();
        txtIndicator.Text = @"/";
        _xActive = false;
        _calculator = new Division();
    }


}