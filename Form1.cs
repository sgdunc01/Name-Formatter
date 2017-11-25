// Program 1
// CIS 199-01/-75
// Due: 2/14/2016
// By: Spencer G. Duncan

// This program displays the potential cost of painting
// a room after the user enters the number of coats, price of 
// the paint and the total surface area of the room.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declares variables
            const decimal ratio = 325m;// a constant variable that stores the sq. ft. that can be painted with 8hrs of labor or 1 can of paint
            const decimal hour = 8m;// a constant variable that stores the number of hours it takes to use one can of paint
            const decimal paint = 1m;// a constant variable that stores how many gallons of paint can be used in the ammount of time specified above
            const decimal wage = 10.50m;// a constant variable that stores the wage of workers
            decimal totalPainted;//variable that stores how much space to be painted
            decimal paintNeeded;//variable that tells how many gallons of paint are needed 
            decimal manHours;//variable that how long the job will take
            decimal paintPrice;//variable that stores the price of the total cost of paint
            decimal workerPrice;//Variable that stores the price of labor
            decimal total;//Varaible that stores the total cost of the job

            //Calculates all final values
            totalPainted = decimal.Parse(roomSqFtTxt.Text) * decimal.Parse(numberCoatsTxt.Text);
            paintNeeded = Math.Ceiling((totalPainted / ratio) * paint);
            manHours = (totalPainted / ratio) * hour;
            paintPrice = decimal.Parse(pricePaintTxt.Text) * paintNeeded;
            workerPrice = manHours * wage;
            total = workerPrice + paintPrice;

            //Assigns text to the labels on form
            sqFtPaintedLbl.Text = totalPainted.ToString("n1") + " Total sq.ft.";
            gallonsPaintLbl.Text = paintNeeded.ToString() + " gal.";
            hoursLaborLbl.Text = manHours.ToString("n1") + " hours";
            costPaintLbl.Text = paintPrice.ToString("c") + " paint";
            costLaborLbl.Text = workerPrice.ToString("c") + " labor";
            TotalLbl.Text = total.ToString("c");
        }
    }
}
