using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string CalToTal;
		double num1, num2;
		string option;
		double result;

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "4";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "5";
		}

		private void button8_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "6";
		}

		private void button9_Click(object sender, EventArgs e)
		{
			option = "*";
			num1 = double.Parse(txtTotal.Text);
			txtTotal.Clear();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			txtTotal.Clear();
			result = 0;
			num1 = 0; num2 = 0;
		}

		private void txtTotal_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn1_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "2";
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "3";
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "7";
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "8";
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + "9";
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			option = "+";
			num1 = double.Parse(txtTotal.Text);
			txtTotal.Clear();
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			option = "-";
			num1 = double.Parse(txtTotal.Text);
			txtTotal.Clear();
		}

		private void btnDiv_Click(object sender, EventArgs e)
		{
			option = "/";
			num1 = double.Parse(txtTotal.Text);
			txtTotal.Clear();
		}

		private void btnEqual_Click(object sender, EventArgs e)
		{
			num2 = double.Parse(txtTotal.Text);

			if (option == "+") result = num1 + num2;
			if (option.Equals("-")) result = num1 - num2;
			if (option.Equals("*")) result = num1 * num2;
			if (option.Equals("/"))
			{
				if (num2 != 0) result = num1 / num2;
				else MessageBox.Show("Cannot divide by zero!");
			}

			txtTotal.Text = result.ToString();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			// Xóa ký tự cuối cùng
			if (txtTotal.Text.Length > 0)
			{
				txtTotal.Text = txtTotal.Text.Remove(txtTotal.Text.Length - 1, 1);
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			// Kiểm tra nếu textbox không có dấu chấm thập phân
			if (!txtTotal.Text.Contains("."))
			{
				txtTotal.Text += ".";
			}
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			txtTotal.Text = txtTotal.Text + btn0.Text;
		}
	}
}
