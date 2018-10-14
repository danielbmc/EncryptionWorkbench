using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EncryptionWorkbench
{
    public partial class Form1 : Form
    {
        /*
         * These are where global variables are being defined
         * These will be accessed from anywhere within the class from any function
         */
        string input; //This string variable will hold the user's input
        string encryptionOutput; //This string variable will hold the final encrypted text
        string decryptionOutput; //This string variable will hold the final decrypted text 
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //This string variable holds the alphabet which will be used for the substitution algorithim
        char[] unencrypted, encrypted, decrypted; //These character arrays will hold various data relating to algorithims
        char[] alphabetOrig; //This character array will be used to store each character in the alphabet as individual elements

        Dictionary<char, char> alphabetDict; //This dictionary will be used to associate characters with their inteneded substitute
        
        //When the application runs, combine the pre-defined alphabet with a lower case version and store it as a character array
        public Form1()
        {
            InitializeComponent();
            alphabetOrig = (alphabet + alphabet.ToLower()).ToCharArray();
        }
        
        //When the encrypt button is clicked... 
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            //This ensures there is an input or it will throw an error
            if (inputTxt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Invalid Input", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //This throws an error if there is no encryption type selected
            if (!reversalEncryptionBtn.Checked && !subEncryptionBtn.Checked && !compositeEncryptionBtn.Checked)
            {
                MessageBox.Show("Select Encryption Type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //This is the reversal encryption IF statement
            if (reversalEncryptionBtn.Checked)
            {
                reversal(true);
            }

            //This is the subsitution encryption IF statement
            if (subEncryptionBtn.Checked)
            {
                substitution(true);
            }

            //This is the composite encryption IF statement
            if (compositeEncryptionBtn.Checked)
            {
                composite(true);
            }
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            decryptionOutput = "";
            //This is the reversal decryption IF statement
            if (reversalEncryptionBtn.Checked)
            {
                reversal(false);
            }
            //This is the substitution decryption IF statement
            if (subEncryptionBtn.Checked)
            {
                substitution(false);
            }
            //This is the composite decryption IF statement
            if (compositeEncryptionBtn.Checked)
            {
                composite(false);
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //This will turn off current application running
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //This is the substitution encryption method
        private void substitution (bool encrypt)
        {
            /*
             * When the substitution cipher is selected and run...
             *      Initialize the new blank values to the variables
             *      Create a copy of the alphabetOrig char array, shift it 3 times and store it in the newly created char array 'shifted'
             *      Bring the first three letters of the alphabet to the end for a complete shift
             *      Add elements to the dictionary using the original alphabet and the shifted alphabet as 
             *                          keys and pairs (order varies depending on encryption or decryption)
             *      Retrieve the input text from the approriate field (depending on encryption or decryption)
             *      Replace each character from the input with its associate from the dictionary
             *      Display the final string in the appropriate field
             */

            alphabetDict = new Dictionary<char, char>();
            char[] shifted = new char[52];
            string text;
            Array.Copy(alphabetOrig, 3, shifted, 0, alphabetOrig.Length - 3);

            for (int i = 0; i < 3; i++)
            {
                shifted[51 - 2 + i] = alphabetOrig[i];
            }

            for (int i = 0; i < shifted.Length; i++)
            {
                if (encrypt)
                    alphabetDict.Add(alphabetOrig[i], shifted[i]);
                else
                    alphabetDict.Add(shifted[i], alphabetOrig[i]);
            }

            if (encrypt)
                text = inputTxt.Text;
            else
                text = encryptionTxt.Text;

            string newTxt = "";

            foreach (var ch in text)
            {
                if (ch == ' ')
                    newTxt += ' ';
                else
                    newTxt += alphabetDict[ch];
            }

            if (encrypt)
                encryptionTxt.Text = newTxt;
            else
                decryptionTxt.Text = newTxt;
        }

        //This clears the encryption and decryption fields
        private void clear(object sender, EventArgs e)
        {
            encryptionTxt.Text = "";
            decryptionTxt.Text = "";
        }

        /* 
         * This method utilises the reverse function from the array class
         * In order to take advantage of this, I must convert the input into an array with a character data type
         * The reversed character array is converted back into a string by using a foreach loop
         * The final text is output to the approriate field
         */
        private void reversal(bool encrypt)
        {
            encryptionOutput = "";

            if (encrypt)
                unencrypted = inputTxt.Text.ToCharArray();
            else
                unencrypted = encryptionTxt.Text.ToCharArray();

            Array.Reverse(unencrypted);
            foreach (Char let in unencrypted)
                encryptionOutput = encryptionOutput + let;

            if (encrypt)
                encryptionTxt.Text = encryptionOutput;
            else
                decryptionTxt.Text = encryptionOutput;
        }

        //This is a combination of the reversal method and the substitution method
        private void composite(bool encrypt)
        {
            alphabetDict = new Dictionary<char, char>();
            char[] shifted = new char[52];
            string text;
            Array.Copy(alphabetOrig, 3, shifted, 0, alphabetOrig.Length - 3);

            for (int i = 0; i < 3; i++)
            {
                shifted[51 - 2 + i] = alphabetOrig[i];
            }

            for (int i = 0; i < shifted.Length; i++)
            {
                if (encrypt)
                    alphabetDict.Add(alphabetOrig[i], shifted[i]);
                else
                    alphabetDict.Add(shifted[i], alphabetOrig[i]);
            }

            if (encrypt)
                text = inputTxt.Text;
            else
                text = encryptionTxt.Text;

            string newTxt = "";

            foreach (var ch in text)
            {
                if (ch == ' ')
                    newTxt += ' ';
                else
                    newTxt += alphabetDict[ch];
            }

            encryptionOutput = "";
            unencrypted = newTxt.ToCharArray();

            Array.Reverse(unencrypted);
            foreach (Char let in unencrypted)
                encryptionOutput = encryptionOutput + let;

            if (encrypt)
                encryptionTxt.Text = encryptionOutput;
            else
                decryptionTxt.Text = encryptionOutput;
        }
    }
}
