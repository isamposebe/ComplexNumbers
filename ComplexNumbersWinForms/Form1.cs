using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Math;
using ComplexNumbersLib;

namespace ComplexNumbersWinForms
{
	public partial class Form1 : Form
	{
		private readonly Complex NumberZ = new();
		private readonly Complex NumberW = new();

		public Form1()
		{
			InitializeComponent();
			UpdateNumberLabels();
		}

		/// <summary>
		/// Culture independent decimal number parsing.
		/// Accepts both comma and point as a decimal separator.
		/// </summary>
		/// <param name="text">Text to parse</param>
		/// <param name="result">Parsed number</param>
		/// <returns>Success status</returns>
		private static bool ParseDouble(string text, out double result)
		{
			text = text.Replace(",", ".");
			return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
		}

		/// <summary>
		/// Updates the labels containing complex numbers.
		/// </summary>
		private void UpdateNumberLabels()
		{
			LabelZValue.Text = "z = " + NumberZ.ToString();
			LabelWValue.Text = "w = " + NumberW.ToString();

			LabelAdditionResult.Text =       $"z + w = {(NumberZ + NumberW).Round(4)}";
			LabelSubtractionResult.Text =    $"z - w = {(NumberZ - NumberW).Round(4)}";
			LabelMultiplicationResult.Text = $"z * w = {(NumberZ * NumberW).Round(4)}";
			LabelDivisionResult.Text =       $"z / w = {(NumberZ / NumberW).Round(4)}";
			LabelPowerResult.Text =          $"z ^ w = {NumberZ.Pow(NumberW.Real).Round(4)}";
			LabelAbsResult.Text =            $"|z| = {Round(NumberZ.Abs(), 4)}";
			LabelArgResult.Text =            $"Arg(z) = {Round(NumberZ.Arg()), 4}";
			LabelConjugateResult.Text =      $"z* = {NumberZ.Conjugate().Round(4)}";
			LabelSqrtResult.Text =           $"Sqrt(z) = {NumberZ.Sqrt().Round(4)}";
			LabelLogResult.Text =            $"Log(z) = {NumberZ.Log().Round(4)}";
			LabelExpResult.Text =            $"Exp(z) = {NumberZ.Exp().Round(4)}";
		}

		/// <summary>
		/// Reads and validates <paramref name="textBox"/> input
		/// and, if the input is valid, writes it to <paramref name="writeTo"/>.
		/// </summary>
		/// <param name="textBox">TextBox to validate</param>
		/// <param name="writeTo">Value output</param>
		private static void HandleInputTextChange(TextBox textBox, ref double writeTo)
		{
			var input = textBox.Text.Trim();
			double value = 0;

			if (input == "" || ParseDouble(input, out value))
			{
				textBox.BackColor = SystemColors.Window;
				writeTo = value;
			}
			else
			{
				textBox.BackColor = Color.LightPink;
			}
		}

		private void InputZRe_TextChanged(object sender, EventArgs e)
		{
			HandleInputTextChange(InputZRe, ref NumberZ.Real);
			UpdateNumberLabels();
		}

		private void InputZIm_TextChanged(object sender, EventArgs e)
		{
			HandleInputTextChange(InputZIm, ref NumberZ.Imaginary);
			UpdateNumberLabels();
		}

		private void InputWRe_TextChanged(object sender, EventArgs e)
		{
			HandleInputTextChange(InputWRe, ref NumberW.Real);
			UpdateNumberLabels();
		}

		private void InputWIm_TextChanged(object sender, EventArgs e)
		{
			HandleInputTextChange(InputWIm, ref NumberW.Imaginary);
			UpdateNumberLabels();
		}
	}
}
