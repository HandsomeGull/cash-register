using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_register
{
    public partial class Form1 : Form
    {
        double pizzaprice = 15;
        double drinkprice = 2.50;
        double pieprice = 3;
        double eons = 0;
        double Cashback = 0;

        double pizza, drink, pie;

        double subtotal;
        double tax;
        double pricetotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //1
            //input 
            pizza = Convert.ToDouble(textBox1.Text);
            drink = Convert.ToDouble(textBox3.Text);
            pie = Convert.ToDouble(textBox4.Text);

            //math stuff
            subtotal = pizzaprice * pizza + drinkprice * drink + pieprice * pie;
            tax = subtotal * .13;
            pricetotal = tax + subtotal;

            suboutput.Text = $"{subtotal}";
            taxoutput.Text = $"{tax}";
            totaloutput.Text = $"{pricetotal.ToString("C")}";

            //amount of mons given
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            eons = Convert.ToDouble(Mons.Text);


            subtotal = pizzaprice * pizza + drinkprice * drink + pieprice * pie;
            tax = subtotal * .13;
            pricetotal = tax + subtotal;

            suboutput.Text = $"{subtotal}";
            taxoutput.Text = $"{tax}";
            totaloutput.Text = $"{pricetotal.ToString("C")}";
           
            Cashback = eons - pricetotal;

            cashback.Text = $"{Cashback.ToString("C")}";
        }

        private void getpaper_Click(object sender, EventArgs e)
        {
            paper.Text = "                      Its Pizza Time \n";
            paper.Text += "==============================\n\n";
            paper.Text += $"        pizza's         x{pizza}  @  ${pizzaprice} \n";
            paper.Text += $"        drink's         x{drink}  @  ${drinkprice} \n";
            paper.Text += $"        pie's            x{pie}  @  ${pieprice}\n\n";
            paper.Text += "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \n\n";
            paper.Text += $"        Subtotal                 ${subtotal} \n";
            paper.Text += $"        tax                          ${tax} \n";
            paper.Text += $"        total                        ${pricetotal}\n\n";
            paper.Text += "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - \n\n";
            paper.Text += $"        trendered                    ${eons}\n";
            paper.Text += $"        Change                       ${Cashback}\n\n";
            paper.Text += "==============================";


            // paper.Text +=
            /*
            paper.Text = $" " +
                $"                   Its Pizza Time" +
                $"      order number ?" +
                $"      date" +
                $"      " +


                $"      pizza's # @ #" +
                $"      drink's # @ #" +
                $"      pie's # @ #" +
                $"    " +


                $"      subtotal #" +
                $"      tax #" +
                $"      total #" +
                $"" +


                $"      tendered #" +
                $"      change #" +
                $"" +
                                                                                


                                                            

                $"                  Have a nice day :D";

            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
           
        }
    }
}
