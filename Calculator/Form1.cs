using System.Reflection;

namespace Calculator
{
    public partial class mainWinodw : Form
    {
        double number1;
        double number2;
        double results;
        string operators = "";
        bool deci = false;


        public mainWinodw()
        {
            InitializeComponent();
        }

        /*
         * Button state:
         * Prints error to screen
         * Used to turn on/off the buttons if their is an error or cleared screen
         */
        private void buttonStatus(bool states)
        {
            display.Text = "Error";
            divisionButton.Enabled = states;
            plusButton.Enabled = states;
            piButton.Enabled = states;
            minusButton.Enabled = states;
            timesButton.Enabled = states;
            equalsButtom.Enabled = states;
            exponentButton.Enabled = states;
            decimalButton.Enabled = states;
            clearLeftButton.Enabled = states;
            zeroButton.Enabled = states;
            oneButton.Enabled = states;
            twoButton.Enabled = states;
            threeButton.Enabled = states;
            fourButton.Enabled = states;
            fiveButton.Enabled = states;
            sixButton.Enabled = states;
            sevenButton.Enabled = states;
            eightButton.Enabled = states;
            nineButton.Enabled = states;
            wordsButton.Enabled = states;

        }

        /*
         * Display:
         * Checks if a decimal is used
         * Checks the number opressed
         */
        private void displayRefresh(double numberPressed)
        {
            int deciimalCounter = 0;
            if (deci == true)
            {
                foreach (char character in display.Text)
                {
                    if (character == '.')
                    {
                        deciimalCounter++;
                    }
                }
                if (deciimalCounter < 1)
                {
                    display.Text += ".";
                    displayHistory.Text += ".";
                }
                deci = false;
            }
            else
            {
                if ((display.Text.Equals("0") == true && display.Text != null))
                {
                    display.Text = numberPressed.ToString();
                }
                else
                {
                    display.Text += numberPressed.ToString();
                }

            }
        }

        private void displayHistory_TextChanged(object sender, EventArgs e)
        {
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            deci = true;
            displayRefresh(0);
        }

        /*
         * Equals Button:
         * Gets the second number
         * Does the math 
         * Displays the equation in the history 
         * Enables the operator button
         * Disables the equals button
         * Display the results to display
         */
        private void equalsButtom_Click(object sender, EventArgs e)
        {
            equalsButtom.Enabled = false; // Disables the equals button

            if (display.Text.Equals("0") == false)
            {
                switch (operators)
                {

                    case "+":
                        number2 = float.Parse(display.Text);
                        results = number1 + number2;
                        displayHistory.Text = $"{number1.ToString("0.##")}+{number2.ToString("0.##")}=";
                        plusButton.Enabled = true;
                        equalsButtom.Enabled = false;
                        break;
                    case "-":
                        number2 = float.Parse(display.Text);
                        results = number1 - number2;
                        displayHistory.Text = $"{number1.ToString("0.##")}-{number2.ToString("0.##")}=";
                        minusButton.Enabled = true;
                        equalsButtom.Enabled = false;
                        break;
                    case "*":
                        number2 = float.Parse(display.Text);
                        results = number1 * number2;
                        displayHistory.Text = $"{number1.ToString("0.##")}*{number2.ToString("0.##")}=";
                        timesButton.Enabled = true;
                        equalsButtom.Enabled = false;
                        break;
                    case "/":
                        number2 = float.Parse(display.Text);
                        results = number1 / number2;
                        displayHistory.Text = $"{number1.ToString("0.##")}÷{number2.ToString("0.##")}=";
                        divisionButton.Enabled = true;
                        equalsButtom.Enabled = false;
                        break;
                    case "^":
                        number2 = float.Parse(display.Text);
                        results = Math.Pow(number1, number2);
                        displayHistory.Text = $"{number1.ToString("0.##")}^{number2.ToString("0.##")}=";
                        exponentButton.Enabled = true;
                        equalsButtom.Enabled = false;
                        break;
                    case "words":
                        wordsList();
                        break;
                    default:
                        break;
                }
            }
            display.Text = results.ToString("0.##");

        }

       /*
        * Operator Buttons:
        * Gets the number entered
        * Sets operator for that button
        * Adds the number and operator to the display history
        * Turns on the Equals button if its been disabled
        * If the  operators button pressed to many times disables all the buttons except AC
        */
        private void divisionButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(display.Text);
                operators = "/";
                display.Text = "";
                displayHistory.Text = $"{number1.ToString("0.##÷")}";
                equalsButtom.Enabled = true;
            }
            catch
            {
                buttonStatus(false);
            }
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(display.Text);
                operators = "*";
                displayHistory.Text = $"{number1.ToString("0.##*")}";
                display.Text = "";
                equalsButtom.Enabled = true;
            }
            catch
            {
                buttonStatus(false);
            }
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(display.Text);
                operators = "+";
                display.Text = "";
                displayHistory.Text = $"{number1.ToString("0.##+")}";
                equalsButtom.Enabled = true;

            }
            catch
            {
                buttonStatus(false);
            }
        }


        private void minusButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(display.Text);
                operators = "-";
                display.Text = "";
                displayHistory.Text = $"{number1.ToString("0.##-")}";
                equalsButtom.Enabled = true;
            }
            catch
            {
                buttonStatus(false);
            }
        }

  
        private void exponentButton_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = float.Parse(display.Text);
                operators = "^";
                display.Text = "";
                displayHistory.Text = $"{number1.ToString("0.##^")}";
                equalsButtom.Enabled = true;
            }
            catch
            {
                buttonStatus(false); 
            }

        }

        
        // Undo: Clears the number to the left
        private void clearLeftButton_Click(object sender, EventArgs e)
        {
            int numberLength = display.Text.Length; 
            if (numberLength > 1) 
            {
                display.Text = display.Text.Substring(0, numberLength - 1); 
                displayHistory.Text = display.Text.Substring(0, numberLength - 1); 
                equalsButtom.Enabled = true;  
            }
            else
            {
                display.Text = "0"; 
                displayHistory.Text = "0"; 
                equalsButtom.Enabled = true;
            }
        }

        
        // Clear screen: Resets the calculator
        private void allClearButton_Click(object sender, EventArgs e)
        {
            buttonStatus(true); // Turns all the button back on 
            display.Text = "0"; // Resets the screen to 0
            displayHistory.Text = "0"; // Resets the history to 0
            operators = ""; //Clears the operator
        }
        
        
        // Number buttons: displayRefresh(Number to display) 
        private void zeroButton_Click(object sender, EventArgs e)
        {
            displayRefresh(0); 
        }


        private void oneButton_Click(object sender, EventArgs e)
        {
            displayRefresh(1); 
        }


        private void twoButton_Click(object sender, EventArgs e)
        {
            displayRefresh(2); 
        }


        private void threeButton_Click(object sender, EventArgs e)
        {
            displayRefresh(3); 
        }


        private void fourButton_Click(object sender, EventArgs e)
        {
            displayRefresh(4); 
        }


        private void fiveButton_Click(object sender, EventArgs e)
        {
            displayRefresh(5);
        }


        private void sixButton_Click(object sender, EventArgs e)
        {
            displayRefresh(6); 
        }


        private void sevenButton_Click(object sender, EventArgs e)
        {
            displayRefresh(7); 
        }


        private void eightButton_Click(object sender, EventArgs e)
        {
            displayRefresh(8); 
        }


        private void nineButton_Click(object sender, EventArgs e)
        {
            displayRefresh(9);
        }
        
        private void piButton_Click(object sender, EventArgs e)
        {

            displayRefresh(3.14); //Adds the first three digits of pi to the diplay
        }
       
        // Methods below pick a random word from an array and calls the wordlist when word button is clicked
        private void wordsList()
        {
            Random randomWord = new Random();
            string[] words = { "58008", "55378008", "376606", "8078", "5508"};
            display.Text = words[randomWord.Next(0, words.Length)]; //Picks random word from the array
        }

        private void wordsButton_Click(object sender, EventArgs e)
        {
            wordsList(); 
        }
    }
}