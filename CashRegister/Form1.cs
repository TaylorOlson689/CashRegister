using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double apples = 0;
        int numOfApples = 1.10;
        double bananas = 0;
        int numOfBananas = 1.25;
        double oranges = 0;
        int numOfOranges = 1.40;
        double pretax = 0;
        double tax = 0;
        double taxrate = 0.13;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                apples = Convert.ToInt16(bananasInput.Text);
                bananas = Convert.ToInt16(applesInput.Text);
                oranges = Convert.ToInt16(orangesInput.Text);

                pretax = apples * numOfApples + bananas * numOfBananas + oranges * numOfOranges;
                tax = pretax * taxrate;
                total = pretax + tax;

                pretaxOutput.Text = pretax.ToString("C");
                taxOutput.Text = total.ToString("C");
                totalOutput.Text = total.ToString("C");
            }
            catch
            {
                pretaxOutput.Text = "ERROR";
                taxOutput.Text = "YOU";
                totalOutput.Text = "FAILED!";

            }
        }

        private void printrecieptButton_Click(object sender, EventArgs);
        {   

       SoundPlayer recieptChaChingPlayer = new SoundPlayer(Properties.Resourses.RecieptChaChing);
            RecieptChaChing.Play():
            
            receiptOutput.Text = $"Thanks for choosing Taylor's groceries. Your final receipt:";
            $"Apples: {applesInput.Text}";
            $"Bananas: {bananasInput.Text}";
            $"Oranges: {orangesInput.Text}";
            $"Subtotal Pretax: {pretaxOutput.Text}";
            $"Tax: {taxOutput.Text}";
            $"Total: {totalOutput.text}";
            $"Have a great day!";
        }
    }
}