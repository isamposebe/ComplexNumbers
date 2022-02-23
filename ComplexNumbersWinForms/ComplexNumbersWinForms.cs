using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using static System.Math;
using ComplexNumbersLib;

namespace ComplexNumbersWinForms
{
	public partial class ComplexNumbersWinForms : Form
	{
		private readonly Complex NumberZ = new();
		private readonly Complex NumberW = new();

		private readonly ComplexTrig TrigNumberZ = new();
		private readonly ComplexTrig TrigNumberW = new();

		public ComplexNumbersWinForms()
		{
			InitializeComponent();
			UpdateNumberLabels();
			UpdateTrigNumberLabels();
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
			text = text.Replace(',', '.');
			return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out result);
		}

		/// <summary>
		/// Updates the labels containing complex numbers.
		/// </summary>
		private void UpdateNumberLabels()
		{
			//LabelZValue.Text = "z = " + NumberZ.ToString();
			//LabelWValue.Text = "w = " + NumberW.ToString();

			//LabelAdditionResult.Text =       $"z + w = {(NumberZ + NumberW).Round(4)}";
			//LabelSubtractionResult.Text =    $"z - w = {(NumberZ - NumberW).Round(4)}";
			//LabelMultiplicationResult.Text = $"z * w = {(NumberZ * NumberW).Round(4)}";
			//LabelDivisionResult.Text =       $"z / w = {(NumberZ / NumberW).Round(4)}";
			//LabelPowerResult.Text =          $"z ^ Re(w) = {NumberZ.Pow(NumberW.Real).Round(4)}";
			//LabelAbsResult.Text =            $"|z| = {Round(NumberZ.Abs(), 4)}";
			//LabelArgResult.Text =            $"Arg(z) = {Round(NumberZ.Arg(), 4)}";
			//LabelConjugateResult.Text =      $"z* = {NumberZ.Conjugate().Round(4)}";
			//LabelSqrtResult.Text =           $"Sqrt(z) = {NumberZ.Sqrt().Round(4)}";
			//LabelLogResult.Text =            $"Log(z) = {NumberZ.Log().Round(4)}";
			//LabelExpResult.Text =            $"Exp(z) = {NumberZ.Exp().Round(4)}";
		}

		/// <summary>
		/// Updates the labels containing complex numbers.
		/// </summary>
		private void UpdateTrigNumberLabels()
		{
			//LabelZTrigValue.Text = "z = " + TrigNumberZ.ToString();
			//LabelWTrigValue.Text = "w = " + TrigNumberW.ToString();

			//LabelAdditionTrigResult.Text = $"z + w = {(TrigNumberZ + TrigNumberW).Round(4)}";
			//LabelSubtractionTrigResult.Text = $"z - w = {(TrigNumberZ - TrigNumberW).Round(4)}";
			//LabelMultiplicationTrigResult.Text = $"z * w = {(TrigNumberZ * TrigNumberW).Round(4)}";
			//LabelDivisionTrigResult.Text = $"z / w = {(TrigNumberZ / TrigNumberW).Round(4)}";
			//LabelPowerTrigResult.Text = $"z ^ Re(w) = {TrigNumberZ.Pow(TrigNumberW.Real).Round(4)}";
			//LabelConjugateTrigResult.Text = $"z* = {TrigNumberZ.Conjugate().Round(4)}";
			//LabelSqrtTrigResult.Text = $"Sqrt(z) = {TrigNumberZ.Sqrt().Round(4)}";
			//LabelLogTrigResult.Text = $"Log(z) = {TrigNumberZ.Log().Round(4)}";
			//LabelExpTrigResult.Text = $"Exp(z) = {TrigNumberZ.Exp().Round(4)}";
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

		// Complex inputs

		//private void InputZRe_TextChanged(object sender, EventArgs e)
		//{
		//	HandleInputTextChange(InputZRe, ref NumberZ.Real);
		//	UpdateNumberLabels();
		//}

		//private void InputZIm_TextChanged(object sender, EventArgs e)
		//{
		//	HandleInputTextChange(InputZIm, ref NumberZ.Imaginary);
		//	UpdateNumberLabels();
		//}

		//private void InputWRe_TextChanged(object sender, EventArgs e)
		//{
		//	HandleInputTextChange(InputWRe, ref NumberW.Real);
		//	UpdateNumberLabels();
		//}

		//private void InputWIm_TextChanged(object sender, EventArgs e)
		//{
		//	HandleInputTextChange(InputWIm, ref NumberW.Imaginary);
		//	UpdateNumberLabels();
		//}

		//// ComplexTrig inputs

		//private void InputArgZ_TextChanged(object sender, EventArgs e)
		//{
		//	double arg = 0;
		//	HandleInputTextChange(InputArgZ, ref arg);
		//	TrigNumberZ.Argument = arg;

		//	UpdateTrigNumberLabels();
		//}

		//private void InputMagZ_TextChanged(object sender, EventArgs e)
		//{
		//	double mag = 0;
		//	HandleInputTextChange(InputMagZ, ref mag);
		//	TrigNumberZ.Magnitude = mag;

		//	UpdateTrigNumberLabels();
		//}

		//private void InputArgW_TextChanged(object sender, EventArgs e)
		//{
		//	double arg = 0;
		//	HandleInputTextChange(InputArgW, ref arg);
		//	TrigNumberW.Argument = arg;

		//	UpdateTrigNumberLabels();
		//}

		//private void InputMagW_TextChanged(object sender, EventArgs e)
		//{
		//	double mag = 0;
		//	HandleInputTextChange(InputMagW, ref mag);
		//	TrigNumberW.Magnitude = mag;

		//	UpdateTrigNumberLabels();
		//}
	}
}
