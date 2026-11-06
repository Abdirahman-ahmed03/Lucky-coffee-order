using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lucky_Cafe_Order_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            if (txtCustomName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter The customer name.");
                return;
            }

            for(int i = 0; i < txtCustomName.Text.Length; i++)
            {
                if (!char.IsLetter(txtCustomName.Text[i])
                    && txtCustomName.Text[i] != ' ')
                {
                    MessageBox.Show("Name must contain only letters:");
                    return;
                }
            }

            int quantity;
            if(!int.TryParse(textQuantity.Text, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter valid number.");
                return;
            }

            double drinkPrice = 0;
            String drinkName = "";

            if(radioTea.Checked)
            {
                drinkPrice = 1;
                drinkName = "Tea";
            }
            else if(radioCoffee.Checked)
            {
                drinkPrice = 2;
                drinkName = "Coffee";
            }
            else if(radioJuice.Checked)
            {  
                drinkPrice = 3;
                drinkName = "Juice";
            }
            else
            {
                MessageBox.Show("Please choos valid a drink");
                return;
            }

            Random random = new Random();
            bool gotPrice = false;

            lstOrderlist.Items.Clear();
            for (int i = 1; i <= quantity; i++)
            {
                int luckyNumber = random.Next(1, 51);


                if(luckyNumber == 7 || luckyNumber == 17)
                {
                    gotPrice = true;
                }

                lstOrderlist.Items.Add(i + " ) " + txtCustomName.Text +
                    " - " + drinkName + ":  Lucky = " + luckyNumber + " - $" + drinkPrice.ToString("f2"));
            }

            double totalPrice = drinkPrice * quantity;
            
            if(checkStudent.Checked)
            {
                totalPrice = totalPrice - (totalPrice * 0.10);
            }

            lblTotalPrice.Text = "$" + totalPrice.ToString("f2");

            if(gotPrice)
            {
                lblLuckyMessage.Text = "You got a free Cookie.";
            }
            else
            {
                lblLuckyMessage.Text = "No Price this time!";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(lstOrderlist.Items.Count == 0)
            {
                MessageBox.Show("No Order to save.");
                return;
            }

            StreamWriter writer = File.AppendText("Orders.text");

            for(int i = 0; i < lstOrderlist.Items.Count; i++)
            {
                writer.WriteLine(lstOrderlist.Items[i]);
            }
            writer.WriteLine(lblTotalPrice.Text);
            writer.WriteLine(lblLuckyMessage.Text);

            writer.Close();

            MessageBox.Show("Order Saved.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(!File.Exists("Orders.text"))
            {
                MessageBox.Show("No file found");
                return;
            }

            lstOrderlist.Items.Clear();

            StreamReader reader = File.OpenText("Orders.text");
            {
                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lstOrderlist.Items.Add(line);
                }
               
                reader.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomName.Clear();

            textQuantity.Clear();

            lstOrderlist.Items.Clear();

            lblTotalPrice.Text = "";

            lblLuckyMessage.Text = "";

            checkStudent.Checked = false;
        }
    }
}
