using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class calculatorDemo : Form
    {
        // variables
        string input = string.Empty; // stores user input
        string operand1 = string.Empty; // stores first operand
        string operand2 = string.Empty; // stores second operand
        char operation;
        double result = 0.0; // calculated result
        string equalsSign = "=";

        public calculatorDemo()
        {
            InitializeComponent();
        }
 
        // methods
        private void CheckForCompleteEquation()
        {
            string searchFor = "="; // search for =
            
            if (displayLabel.Text.Contains(searchFor))
            {
                // if displayLabel contains an = 
                // clear displayLabel.Text
                //displayLabel.ResetText(); // clears displayLabel.Text
                // add txtEntry.Text to displayLabel.Text
                displayLabel.Text += txtEntry.Text; // adds txtEntry to DisplayLabel
            }

        }

        private void AddInput(string input)
        {
            txtEntry.AppendText(input);
        }
        private void DisplayEquation()
        {
            displayLabel.Text = displayLabel.Text + txtEntry.Text;
        }
        private void ClearZero()
        {
            // if the first value is zero then it sets text to null
            if (txtEntry.Text == "0")
            {
                txtEntry.Text = null;
                return;
            }
        }

        // Numbers and decimal

        private void btn0_Click(object sender, EventArgs e)
        {
            input = "0";
            if(txtEntry.Text == input) 
            {
                // if txtEntry only contains only a zero nothing changes
                return;
            }
            else
            {
                txtEntry.AppendText(input);
                return;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "1";
            AddInput(input); // adds input to the txtBox
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "2";
            AddInput(input); // adds input to the txtBox
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "3";
            AddInput(input); // adds input to the txtBox
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "4";
            AddInput(input); // adds input to the txtBox
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "5";
            AddInput(input); // adds input to the txtBox
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "6";
            AddInput(input); // adds input to the txtBox
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "7";
            AddInput(input); // adds input to the txtBox
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "8";
            AddInput(input); // adds input to the txtBox
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ClearZero();
            input = "9";
            AddInput(input); // adds input to the txtBox
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // if the txtEntry has a decimal it will not add another
            if (!txtEntry.Text.Contains("."))
            {
                input = ".";
                AddInput(input); // adds input to the txtBox
            }
        }
        
        // Operands
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // if the equation has already been completed
            // clear display and pass value from txtEntry to display
            if (displayLabel.Text.Contains(equalsSign))
            {
                displayLabel.Text = ""; // clears display

                operand1 = txtEntry.Text; // value becomes previous result
                operation = '+';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
            else
            {
                operand1 = input;
                operation = '+';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            // if the equation has already been completed
            // clear display and pass value from txtEntry to display
            if (displayLabel.Text.Contains(equalsSign))
            {
                displayLabel.Text = ""; // clears display

                operand1 = txtEntry.Text; // value becomes previous result
                operation = '-';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
            else
            {
                operand1 = input;
                operation = '-';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }        
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            // if the equation has already been completed
            // clear display and pass value from txtEntry to display
            if (displayLabel.Text.Contains(equalsSign))
            {
                displayLabel.Text = ""; // clears display

                operand1 = txtEntry.Text; // value becomes previous result
                operation = '*';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
            else
            {
                operand1 = input;
                operation = '*';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            // if the equation has already been completed
            // clear display and pass value from txtEntry to display
            if (displayLabel.Text.Contains(equalsSign))
            {
                displayLabel.Text = ""; // clears display

                operand1 = txtEntry.Text; // value becomes previous result
                operation = '/';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
            else
            {
                operand1 = input;
                operation = '/';
                input = string.Empty;
                AddInput(operation.ToString()); // adds the + to the displayLabel
                DisplayEquation(); // displays equation above text box
                txtEntry.Clear();  // Clears txtEntry box
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            //string equalsSign = "=";
            AddInput(equalsSign); // adds the = to the displayLabel
            DisplayEquation(); // displays equation above text box
            // Clears txtBox

            operand2 = input;
            double num1;
            double num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            // array that holds values ?? loop through array, loop ends when value equals =
            // array tha holds operand ??

            switch (operation.ToString())
            {
                case "+":
                    {
                        result = num1 + num2;
                        txtEntry.Text = result.ToString();
                        displayLabel.Text = displayLabel.Text + txtEntry.Text; // adds the result to the current displayLabel.Text 
                        break;                  
                    }

                case "-":
                    {
                        result = num1 - num2;
                        txtEntry.Text = result.ToString();
                        displayLabel.Text = displayLabel.Text + txtEntry.Text; // adds the result to the current displayLabel.Text
                        break;
                    }

                case "*":
                    {
                        result = num1 * num2;
                        txtEntry.Text = result.ToString();
                        displayLabel.Text = displayLabel.Text + txtEntry.Text; // adds the result to the current displayLabel.Text
                        break;
                    }

                case "/":
                    {
                        if(num2 != 0)
                        {
                            result = num1 / num2;
                            txtEntry.Text = result.ToString();
                            displayLabel.Text = displayLabel.Text + txtEntry.Text; // adds the result to the current displayLabel.Text
                        }
                        else
                        {
                            MessageBox.Show("You can not divide by zero!");
                        }
                        
                        break;
                    }

                default: { break; }
            }
        }// end equals

        private void btnClear_Click(object sender, EventArgs e)
        {
            displayLabel.Text = ""; // clears the label 
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtEntry.Clear(); // clears the txtEntry box  
        }
    }
}
