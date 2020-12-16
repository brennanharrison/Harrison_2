// Programmer: Brennan Harrison
// Project: Harrison_2
// Date: 09/28/2018
// Description: Individual Assignment #2
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harrison_2
{
    public partial class languageOrderEntryForm : Form
    {
        // Declare constant fields.
        private const decimal IN_STATE_PRICE = 49.00m;     // Price for in-state students.
        private const decimal OUT_OF_STATE_PRICE = 99.00m; // Price for out-of-state students.

        // Declare fields.
        private int courseNumber;    // Number of purchased courses.
        private decimal coursePrice; // Price per course.
        private decimal totalPrice;  // Total price for purchased courses.
        private string term;         // Registered term.
        private string year;         // Registered year.
        private string residency;    // Residency status.
        private string creditCard;   // Credit card type.
        private string course;       // Purchased course(s).
       
        public languageOrderEntryForm()
        {
            InitializeComponent();
        }

        // Load the form with the appropriate courseNumber, coursePrice, and totalPrice fields.
        private void languageOrderEntryForm_Load(object sender, EventArgs e)
        {
            /* Initialize the courseNumber field with 0.
             * Display the courseNumber field in the courseNumberOutPutLabel control. */
            courseNumber = 0;
            courseNumberOutPutLabel.Text = courseNumber.ToString();

            /* Initialize coursePrice field with IN_STATE_PRICE.
             * Display the coursePrice field in the coursePriceOutPutLabel control. */
            coursePrice = IN_STATE_PRICE;
            coursePriceOutPutLabel.Text = coursePrice.ToString("c");

            /* Initialize the totalPrice field with 0.00.
             * Display the totalPrice field in the totalPriceOutPutLabel control. */
            totalPrice = 0.00m;
            totalPriceOutPutLabel.Text = totalPrice.ToString("c");
        }

        // Increment the courseNumber field, concatenate the course field, and calculate the totalPrice field.
        private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Reset the courseNumber and course fields each time event handler executes.
            courseNumber = 0;
            course = "";

            // If the beginning French checkbox is checked then:
            if (frenchCheckBox.Checked)  
            {
                /* Increment the courseNumber field with 1.
                 * Concatenate the course field. */
                courseNumber += 1;
                course = " Beginning French \n";
            }
            // If the beginning German checkbox is checked then:
            if (germanCheckBox.Checked)
            {
                /* Increment the courseNumber field with 1.
                 * Concatenate the course field. */
                courseNumber += 1;
                course = course + " Beginning German \n";
            }
            // If the beginning Russian checkbox is checked then: 
            if (russianCheckBox.Checked)
            {
                /* Increment the courseNumber field with 1.
                 * Concatenate the course field. */
                courseNumber += 1;       
                course = course + " Beginning Russian \n";
            }
            // If the beginning Spanish checkbox is checked then:
            if (spanishCheckBox.Checked)
            {
                /* Increment the courseNumber field with 1.
                 * Concatenate the course field. */
                courseNumber += 1;     
                course = course + " Beginning Spanish \n";
            }
            // If the beginning Italian checkbox is checked then: 
            if (italianCheckBox.Checked)
            {
                /* Increment the courseNumber field with 1.
                 * Concatenate the course field. */
                courseNumber += 1;     
                course = course + " Beginning Italian \n";
            }

            // Display the incremental courseNumber field in the courseNumberOutPutLabel control.
            courseNumberOutPutLabel.Text = courseNumber.ToString();

            /* Calculate the totalPrice field.
             * Display the totalPrice field in the totalPriceOutPutLabel control. */
            totalPrice = courseNumber * coursePrice;
            totalPriceOutPutLabel.Text = totalPrice.ToString("c");
        }

        // Convert the totalPrice field if the user checks the In-State radio button after checking checkboxes.
        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /* Assign the coursePrice field the IN_STATE_PRICE constant field.
             * Display the coursePrice field in the coursePriceOutPutLabel control. */
            coursePrice = IN_STATE_PRICE;
            coursePriceOutPutLabel.Text = coursePrice.ToString("c");

            /* Calculate the totalPrice field.
             * Display the totalPrice field in the totalPriceOutPutLabel control. */
            totalPrice = courseNumber * coursePrice;
            totalPriceOutPutLabel.Text = totalPrice.ToString("c");
        }

        // Convert the totalPrice field if the user checks the Out-Of-State radio button after checking checkboxes.
        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            /* Assign the coursePrice field the OUT_OF_STATE_PRICE constant field.
             * Display the coursePrice field in the coursePriceOutPutLabel control. */
            coursePrice = OUT_OF_STATE_PRICE;
            coursePriceOutPutLabel.Text = coursePrice.ToString("c");

            /* Calculate the totalPrice field.
             * Display the totalPrice field in the totalPriceOutPutLabel control. */
            totalPrice = courseNumber * coursePrice;
            totalPriceOutPutLabel.Text = totalPrice.ToString("c");
        }

        // Display the user's order summary.
        private void saveButton_Click(object sender, EventArgs e)
        {
            //If the Spring radio button is checked then:
            if (springRadioButton.Checked)                    
            {
                // Assign the string term field with "Spring".
                term = "Spring";                             
            }
            // If not then:
            else                        
            {
                // Assign the string term field with "Fall".
                term = "Fall";                               
            }

            // If an item is selected in the yearComboBox control then:
            if (yearComboBox.SelectedIndex != -1)      
            {
                // Get the selected item.
                year = yearComboBox.SelectedItem.ToString(); 
            }

            // If the outOfStateRadioButton control is selected then:
            if (outOfStateRadioButton.Checked)           
            {
                // Assign the string residnecy field with "Out-Of-State".
                residency = "Out-Of-State";                  
            }
            // If not then:
            else                                             
            {
                // Assign the string residnecy field with "In-State".
                residency = "In-State";                    
            }

            // If the visaRadioButton control is selected then: 
            if (visaRadioButton.Checked)                     
            {
                // Assign the string creditCard field with "Visa".
                creditCard = "Visa";                         
            }
            // If not then:
            else                                             
            {
                // Assign the string creditCard field with "MasterCard".
                creditCard = "MasterCard";                   
            }

            // If the number of purchased courses is less than 1 or greater than three then:
            if (courseNumber < 1 || courseNumber > 3)
            {
                // Display a message box specifying how many courses can be purchased, with a title, button, and an icon.
                MessageBox.Show("An order must contain one course but no more than three courses.", "Order Rejected",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // If not then:
            else
            {
                // Display a message box summarizing the user's order summary with a title, button, and an icon.
                MessageBox.Show("Registration Term: " + term + " " + year + " \n"
                                + "ID: " + studentIDMaskedTextBox.Text + " \n"
                                + "Name: " + firstNameTextBox.Text + " " + lastNameTextBox.Text + " \n"
                                + "Email Address: " + emailTextBox.Text + " \n"
                                + "Residency: " + residency + " \n"
                                + "Purchased Courses: " + courseNumber.ToString() + " \n"
                                + "Course Price: " + coursePrice.ToString("c") + " \n"
                                + "Total Order Price: " + totalPrice.ToString("c") + " \n"
                                + "Credit Card Type: " + creditCard + " \n"
                                + "Card Number: " + cardNumberMaskedTextBox.Text + " \n"
                                + "Card Expiration: " + cardExpirationMaskedTextBox.Text + " \n"
                                + "Courses: " + course, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Reset the form to its original appearance.
        private void clearButton_Click(object sender, EventArgs e)
        {
            fallRadioButton.Checked = true;        // Select the fallRadioButton control.
            yearComboBox.SelectedIndex = -1;       // Clear the yearComboBox control.
            studentIDMaskedTextBox.Text = "";      // Empty the studentIDMaskedTextBox control.
            firstNameTextBox.Text = "";            // Empty the firstNameTextBox control.
            lastNameTextBox.Text = "";             // Empty the lastNameTextBox control.
            emailTextBox.Text = "";                // Empty the emailTextBox control.
            inStateRadioButton.Checked = true;     // Select the inStateRadioButton control.
            frenchCheckBox.Checked = false;        // Deselect the frenchCheckBox control.
            germanCheckBox.Checked = false;        // Deselect the germanCheckBox control.
            russianCheckBox.Checked = false;       // Deselect the russianCheckBox control. 
            spanishCheckBox.Checked = false;       // Deselect the spanishCheckBox control.
            italianCheckBox.Checked = false;       // Deselect the italianCheckBox control.
            masterCardRadioButton.Checked = true;  // Select the masterCardRadioButton control.
            cardNumberMaskedTextBox.Text = "";     // Empty the cardNumberMaskedTextBox control.
            cardExpirationMaskedTextBox.Text = ""; // Empty the cardExpirationMaskedTextBox control.

            /* Reset the courseNumber field to 0.
             * Display the courseNumber field in the courseNumberOutPutLabel control. */
            courseNumber = 0;
            courseNumberOutPutLabel.Text = courseNumber.ToString();

            /* Reset the coursePrice field with the IN_STATE_PRICE field.
             * Display the coursePrice field in the coursePriceOutPutLabel control. */
            coursePrice = IN_STATE_PRICE;
            coursePriceOutPutLabel.Text = coursePrice.ToString("c");

            /* Reset the totalPrice field to 0.00.
             * Display the totalPrice field in the totalPriceOutPutLabel control. */
            totalPrice = 0.00m;
            totalPriceOutPutLabel.Text = totalPrice.ToString("c");

            // Give the focus to the first data-entry control.
            fallRadioButton.Focus();
        }

        // Close the application.
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Declare a variable to hold user selection in dialog box.
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to exit the order-entry?",
                                       "Exit Order-Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Take appropriate action based on user selection in dialog box.
            if (selection == DialogResult.Yes)
            {
                // Close the form (ending the program).
                this.Close();
            }
        }
    }
}
