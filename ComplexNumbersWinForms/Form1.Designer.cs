
namespace ComplexNumbersWinForms
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.InputZRe = new System.Windows.Forms.TextBox();
			this.InputZIm = new System.Windows.Forms.TextBox();
			this.InputWRe = new System.Windows.Forms.TextBox();
			this.InputWIm = new System.Windows.Forms.TextBox();
			this.LabelZRe = new System.Windows.Forms.Label();
			this.LabelZIm = new System.Windows.Forms.Label();
			this.LabelWRe = new System.Windows.Forms.Label();
			this.LabelWImg = new System.Windows.Forms.Label();
			this.LabelZValue = new System.Windows.Forms.Label();
			this.LabelWValue = new System.Windows.Forms.Label();
			this.LabelAdditionResult = new System.Windows.Forms.Label();
			this.LabelSubtractionResult = new System.Windows.Forms.Label();
			this.LabelMultiplicationResult = new System.Windows.Forms.Label();
			this.LabelDivisionResult = new System.Windows.Forms.Label();
			this.LabelPowerResult = new System.Windows.Forms.Label();
			this.LabelAbsResult = new System.Windows.Forms.Label();
			this.LabelArgResult = new System.Windows.Forms.Label();
			this.LabelConjugateResult = new System.Windows.Forms.Label();
			this.LabelSqrtResult = new System.Windows.Forms.Label();
			this.LabelLogResult = new System.Windows.Forms.Label();
			this.LabelExpResult = new System.Windows.Forms.Label();
			this.TabControl = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.LabelMultiplicationTrigResult = new System.Windows.Forms.Label();
			this.LabelExpTrigResult = new System.Windows.Forms.Label();
			this.InputArgZ = new System.Windows.Forms.TextBox();
			this.LabelLogTrigResult = new System.Windows.Forms.Label();
			this.InputMagZ = new System.Windows.Forms.TextBox();
			this.LabelSqrtTrigResult = new System.Windows.Forms.Label();
			this.InputArgW = new System.Windows.Forms.TextBox();
			this.LabelConjugateTrigResult = new System.Windows.Forms.Label();
			this.InputMagW = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.LabelPowerTrigResult = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.LabelDivisionTrigResult = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.LabelZTrigValue = new System.Windows.Forms.Label();
			this.LabelSubtractionTrigResult = new System.Windows.Forms.Label();
			this.LabelWTrigValue = new System.Windows.Forms.Label();
			this.LabelAdditionTrigResult = new System.Windows.Forms.Label();
			this.TabControl.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// InputZRe
			// 
			this.InputZRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputZRe.Location = new System.Drawing.Point(96, 308);
			this.InputZRe.Name = "InputZRe";
			this.InputZRe.Size = new System.Drawing.Size(60, 35);
			this.InputZRe.TabIndex = 0;
			this.InputZRe.TextChanged += new System.EventHandler(this.InputZRe_TextChanged);
			// 
			// InputZIm
			// 
			this.InputZIm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputZIm.Location = new System.Drawing.Point(267, 306);
			this.InputZIm.Name = "InputZIm";
			this.InputZIm.Size = new System.Drawing.Size(60, 35);
			this.InputZIm.TabIndex = 1;
			this.InputZIm.TextChanged += new System.EventHandler(this.InputZIm_TextChanged);
			// 
			// InputWRe
			// 
			this.InputWRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputWRe.Location = new System.Drawing.Point(96, 370);
			this.InputWRe.Name = "InputWRe";
			this.InputWRe.Size = new System.Drawing.Size(60, 35);
			this.InputWRe.TabIndex = 2;
			this.InputWRe.TextChanged += new System.EventHandler(this.InputWRe_TextChanged);
			// 
			// InputWIm
			// 
			this.InputWIm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputWIm.Location = new System.Drawing.Point(267, 368);
			this.InputWIm.Name = "InputWIm";
			this.InputWIm.Size = new System.Drawing.Size(60, 35);
			this.InputWIm.TabIndex = 3;
			this.InputWIm.TextChanged += new System.EventHandler(this.InputWIm_TextChanged);
			// 
			// LabelZRe
			// 
			this.LabelZRe.AutoSize = true;
			this.LabelZRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZRe.Location = new System.Drawing.Point(27, 314);
			this.LabelZRe.Name = "LabelZRe";
			this.LabelZRe.Size = new System.Drawing.Size(58, 30);
			this.LabelZRe.TabIndex = 4;
			this.LabelZRe.Text = "Re(z)";
			// 
			// LabelZIm
			// 
			this.LabelZIm.AutoSize = true;
			this.LabelZIm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZIm.Location = new System.Drawing.Point(200, 312);
			this.LabelZIm.Name = "LabelZIm";
			this.LabelZIm.Size = new System.Drawing.Size(59, 30);
			this.LabelZIm.TabIndex = 5;
			this.LabelZIm.Text = "Im(z)";
			// 
			// LabelWRe
			// 
			this.LabelWRe.AutoSize = true;
			this.LabelWRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWRe.Location = new System.Drawing.Point(27, 373);
			this.LabelWRe.Name = "LabelWRe";
			this.LabelWRe.Size = new System.Drawing.Size(63, 30);
			this.LabelWRe.TabIndex = 6;
			this.LabelWRe.Text = "Re(w)";
			// 
			// LabelWImg
			// 
			this.LabelWImg.AutoSize = true;
			this.LabelWImg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWImg.Location = new System.Drawing.Point(200, 371);
			this.LabelWImg.Name = "LabelWImg";
			this.LabelWImg.Size = new System.Drawing.Size(64, 30);
			this.LabelWImg.TabIndex = 7;
			this.LabelWImg.Text = "Im(w)";
			// 
			// LabelZValue
			// 
			this.LabelZValue.AutoSize = true;
			this.LabelZValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZValue.Location = new System.Drawing.Point(464, 306);
			this.LabelZValue.Name = "LabelZValue";
			this.LabelZValue.Size = new System.Drawing.Size(60, 30);
			this.LabelZValue.TabIndex = 8;
			this.LabelZValue.Text = "z = 0";
			// 
			// LabelWValue
			// 
			this.LabelWValue.AutoSize = true;
			this.LabelWValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWValue.Location = new System.Drawing.Point(464, 375);
			this.LabelWValue.Name = "LabelWValue";
			this.LabelWValue.Size = new System.Drawing.Size(65, 30);
			this.LabelWValue.TabIndex = 9;
			this.LabelWValue.Text = "w = 0";
			// 
			// LabelAdditionResult
			// 
			this.LabelAdditionResult.AutoSize = true;
			this.LabelAdditionResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAdditionResult.Location = new System.Drawing.Point(38, 22);
			this.LabelAdditionResult.Name = "LabelAdditionResult";
			this.LabelAdditionResult.Size = new System.Drawing.Size(58, 25);
			this.LabelAdditionResult.TabIndex = 10;
			this.LabelAdditionResult.Text = "z + w";
			// 
			// LabelSubtractionResult
			// 
			this.LabelSubtractionResult.AutoSize = true;
			this.LabelSubtractionResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSubtractionResult.Location = new System.Drawing.Point(38, 57);
			this.LabelSubtractionResult.Name = "LabelSubtractionResult";
			this.LabelSubtractionResult.Size = new System.Drawing.Size(53, 25);
			this.LabelSubtractionResult.TabIndex = 10;
			this.LabelSubtractionResult.Text = "z - w";
			// 
			// LabelMultiplicationResult
			// 
			this.LabelMultiplicationResult.AutoSize = true;
			this.LabelMultiplicationResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelMultiplicationResult.Location = new System.Drawing.Point(38, 92);
			this.LabelMultiplicationResult.Name = "LabelMultiplicationResult";
			this.LabelMultiplicationResult.Size = new System.Drawing.Size(53, 25);
			this.LabelMultiplicationResult.TabIndex = 10;
			this.LabelMultiplicationResult.Text = "z * w";
			// 
			// LabelDivisionResult
			// 
			this.LabelDivisionResult.AutoSize = true;
			this.LabelDivisionResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelDivisionResult.Location = new System.Drawing.Point(38, 127);
			this.LabelDivisionResult.Name = "LabelDivisionResult";
			this.LabelDivisionResult.Size = new System.Drawing.Size(52, 25);
			this.LabelDivisionResult.TabIndex = 10;
			this.LabelDivisionResult.Text = "z / w";
			// 
			// LabelPowerResult
			// 
			this.LabelPowerResult.AutoSize = true;
			this.LabelPowerResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelPowerResult.Location = new System.Drawing.Point(38, 162);
			this.LabelPowerResult.Name = "LabelPowerResult";
			this.LabelPowerResult.Size = new System.Drawing.Size(90, 25);
			this.LabelPowerResult.TabIndex = 10;
			this.LabelPowerResult.Text = "z ^ Re(w)";
			// 
			// LabelAbsResult
			// 
			this.LabelAbsResult.AutoSize = true;
			this.LabelAbsResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAbsResult.Location = new System.Drawing.Point(38, 197);
			this.LabelAbsResult.Name = "LabelAbsResult";
			this.LabelAbsResult.Size = new System.Drawing.Size(31, 25);
			this.LabelAbsResult.TabIndex = 10;
			this.LabelAbsResult.Text = "|z|";
			// 
			// LabelArgResult
			// 
			this.LabelArgResult.AutoSize = true;
			this.LabelArgResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelArgResult.Location = new System.Drawing.Point(400, 22);
			this.LabelArgResult.Name = "LabelArgResult";
			this.LabelArgResult.Size = new System.Drawing.Size(63, 25);
			this.LabelArgResult.TabIndex = 10;
			this.LabelArgResult.Text = "Arg(z)";
			// 
			// LabelConjugateResult
			// 
			this.LabelConjugateResult.AutoSize = true;
			this.LabelConjugateResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelConjugateResult.Location = new System.Drawing.Point(400, 57);
			this.LabelConjugateResult.Name = "LabelConjugateResult";
			this.LabelConjugateResult.Size = new System.Drawing.Size(29, 25);
			this.LabelConjugateResult.TabIndex = 10;
			this.LabelConjugateResult.Text = "z*";
			// 
			// LabelSqrtResult
			// 
			this.LabelSqrtResult.AutoSize = true;
			this.LabelSqrtResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSqrtResult.Location = new System.Drawing.Point(400, 92);
			this.LabelSqrtResult.Name = "LabelSqrtResult";
			this.LabelSqrtResult.Size = new System.Drawing.Size(67, 25);
			this.LabelSqrtResult.TabIndex = 10;
			this.LabelSqrtResult.Text = "Sqrt(z)";
			// 
			// LabelLogResult
			// 
			this.LabelLogResult.AutoSize = true;
			this.LabelLogResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelLogResult.Location = new System.Drawing.Point(400, 127);
			this.LabelLogResult.Name = "LabelLogResult";
			this.LabelLogResult.Size = new System.Drawing.Size(64, 25);
			this.LabelLogResult.TabIndex = 10;
			this.LabelLogResult.Text = "Log(z)";
			// 
			// LabelExpResult
			// 
			this.LabelExpResult.AutoSize = true;
			this.LabelExpResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelExpResult.Location = new System.Drawing.Point(400, 162);
			this.LabelExpResult.Name = "LabelExpResult";
			this.LabelExpResult.Size = new System.Drawing.Size(63, 25);
			this.LabelExpResult.TabIndex = 10;
			this.LabelExpResult.Text = "Exp(z)";
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.TabPage1);
			this.TabControl.Controls.Add(this.TabPage2);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(800, 450);
			this.TabControl.TabIndex = 11;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.LabelMultiplicationResult);
			this.TabPage1.Controls.Add(this.LabelExpResult);
			this.TabPage1.Controls.Add(this.InputZRe);
			this.TabPage1.Controls.Add(this.LabelLogResult);
			this.TabPage1.Controls.Add(this.InputZIm);
			this.TabPage1.Controls.Add(this.LabelSqrtResult);
			this.TabPage1.Controls.Add(this.InputWRe);
			this.TabPage1.Controls.Add(this.LabelConjugateResult);
			this.TabPage1.Controls.Add(this.InputWIm);
			this.TabPage1.Controls.Add(this.LabelArgResult);
			this.TabPage1.Controls.Add(this.LabelZRe);
			this.TabPage1.Controls.Add(this.LabelAbsResult);
			this.TabPage1.Controls.Add(this.LabelZIm);
			this.TabPage1.Controls.Add(this.LabelPowerResult);
			this.TabPage1.Controls.Add(this.LabelWRe);
			this.TabPage1.Controls.Add(this.LabelDivisionResult);
			this.TabPage1.Controls.Add(this.LabelWImg);
			this.TabPage1.Controls.Add(this.LabelZValue);
			this.TabPage1.Controls.Add(this.LabelSubtractionResult);
			this.TabPage1.Controls.Add(this.LabelWValue);
			this.TabPage1.Controls.Add(this.LabelAdditionResult);
			this.TabPage1.Location = new System.Drawing.Point(4, 24);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(792, 422);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Complex";
			this.TabPage1.UseVisualStyleBackColor = true;
			// 
			// TabPage2
			// 
			this.TabPage2.Controls.Add(this.LabelMultiplicationTrigResult);
			this.TabPage2.Controls.Add(this.LabelExpTrigResult);
			this.TabPage2.Controls.Add(this.InputArgZ);
			this.TabPage2.Controls.Add(this.LabelLogTrigResult);
			this.TabPage2.Controls.Add(this.InputMagZ);
			this.TabPage2.Controls.Add(this.LabelSqrtTrigResult);
			this.TabPage2.Controls.Add(this.InputArgW);
			this.TabPage2.Controls.Add(this.LabelConjugateTrigResult);
			this.TabPage2.Controls.Add(this.InputMagW);
			this.TabPage2.Controls.Add(this.label7);
			this.TabPage2.Controls.Add(this.label9);
			this.TabPage2.Controls.Add(this.LabelPowerTrigResult);
			this.TabPage2.Controls.Add(this.label11);
			this.TabPage2.Controls.Add(this.LabelDivisionTrigResult);
			this.TabPage2.Controls.Add(this.label13);
			this.TabPage2.Controls.Add(this.LabelZTrigValue);
			this.TabPage2.Controls.Add(this.LabelSubtractionTrigResult);
			this.TabPage2.Controls.Add(this.LabelWTrigValue);
			this.TabPage2.Controls.Add(this.LabelAdditionTrigResult);
			this.TabPage2.Location = new System.Drawing.Point(4, 24);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(792, 422);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "ComplexTrig";
			this.TabPage2.UseVisualStyleBackColor = true;
			// 
			// LabelMultiplicationTrigResult
			// 
			this.LabelMultiplicationTrigResult.AutoSize = true;
			this.LabelMultiplicationTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelMultiplicationTrigResult.Location = new System.Drawing.Point(38, 92);
			this.LabelMultiplicationTrigResult.Name = "LabelMultiplicationTrigResult";
			this.LabelMultiplicationTrigResult.Size = new System.Drawing.Size(53, 25);
			this.LabelMultiplicationTrigResult.TabIndex = 24;
			this.LabelMultiplicationTrigResult.Text = "z * w";
			// 
			// LabelExpTrigResult
			// 
			this.LabelExpTrigResult.AutoSize = true;
			this.LabelExpTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelExpTrigResult.Location = new System.Drawing.Point(400, 127);
			this.LabelExpTrigResult.Name = "LabelExpTrigResult";
			this.LabelExpTrigResult.Size = new System.Drawing.Size(63, 25);
			this.LabelExpTrigResult.TabIndex = 29;
			this.LabelExpTrigResult.Text = "Exp(z)";
			// 
			// InputArgZ
			// 
			this.InputArgZ.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputArgZ.Location = new System.Drawing.Point(96, 308);
			this.InputArgZ.Name = "InputArgZ";
			this.InputArgZ.Size = new System.Drawing.Size(60, 35);
			this.InputArgZ.TabIndex = 11;
			this.InputArgZ.TextChanged += new System.EventHandler(this.InputArgZ_TextChanged);
			// 
			// LabelLogTrigResult
			// 
			this.LabelLogTrigResult.AutoSize = true;
			this.LabelLogTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelLogTrigResult.Location = new System.Drawing.Point(400, 92);
			this.LabelLogTrigResult.Name = "LabelLogTrigResult";
			this.LabelLogTrigResult.Size = new System.Drawing.Size(64, 25);
			this.LabelLogTrigResult.TabIndex = 28;
			this.LabelLogTrigResult.Text = "Log(z)";
			// 
			// InputMagZ
			// 
			this.InputMagZ.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputMagZ.Location = new System.Drawing.Point(267, 306);
			this.InputMagZ.Name = "InputMagZ";
			this.InputMagZ.Size = new System.Drawing.Size(60, 35);
			this.InputMagZ.TabIndex = 12;
			this.InputMagZ.TextChanged += new System.EventHandler(this.InputMagZ_TextChanged);
			// 
			// LabelSqrtTrigResult
			// 
			this.LabelSqrtTrigResult.AutoSize = true;
			this.LabelSqrtTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSqrtTrigResult.Location = new System.Drawing.Point(400, 57);
			this.LabelSqrtTrigResult.Name = "LabelSqrtTrigResult";
			this.LabelSqrtTrigResult.Size = new System.Drawing.Size(67, 25);
			this.LabelSqrtTrigResult.TabIndex = 27;
			this.LabelSqrtTrigResult.Text = "Sqrt(z)";
			// 
			// InputArgW
			// 
			this.InputArgW.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputArgW.Location = new System.Drawing.Point(96, 370);
			this.InputArgW.Name = "InputArgW";
			this.InputArgW.Size = new System.Drawing.Size(60, 35);
			this.InputArgW.TabIndex = 13;
			this.InputArgW.TextChanged += new System.EventHandler(this.InputArgW_TextChanged);
			// 
			// LabelConjugateTrigResult
			// 
			this.LabelConjugateTrigResult.AutoSize = true;
			this.LabelConjugateTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelConjugateTrigResult.Location = new System.Drawing.Point(400, 22);
			this.LabelConjugateTrigResult.Name = "LabelConjugateTrigResult";
			this.LabelConjugateTrigResult.Size = new System.Drawing.Size(29, 25);
			this.LabelConjugateTrigResult.TabIndex = 26;
			this.LabelConjugateTrigResult.Text = "z*";
			// 
			// InputMagW
			// 
			this.InputMagW.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputMagW.Location = new System.Drawing.Point(267, 368);
			this.InputMagW.Name = "InputMagW";
			this.InputMagW.Size = new System.Drawing.Size(60, 35);
			this.InputMagW.TabIndex = 14;
			this.InputMagW.TextChanged += new System.EventHandler(this.InputMagW_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.Location = new System.Drawing.Point(27, 314);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 30);
			this.label7.TabIndex = 15;
			this.label7.Text = "Arg(z)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label9.Location = new System.Drawing.Point(215, 312);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 30);
			this.label9.TabIndex = 16;
			this.label9.Text = "|z|";
			// 
			// LabelPowerTrigResult
			// 
			this.LabelPowerTrigResult.AutoSize = true;
			this.LabelPowerTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelPowerTrigResult.Location = new System.Drawing.Point(38, 162);
			this.LabelPowerTrigResult.Name = "LabelPowerTrigResult";
			this.LabelPowerTrigResult.Size = new System.Drawing.Size(90, 25);
			this.LabelPowerTrigResult.TabIndex = 23;
			this.LabelPowerTrigResult.Text = "z ^ Re(w)";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(27, 373);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 30);
			this.label11.TabIndex = 17;
			this.label11.Text = "Arg(w)";
			// 
			// LabelDivisionTrigResult
			// 
			this.LabelDivisionTrigResult.AutoSize = true;
			this.LabelDivisionTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelDivisionTrigResult.Location = new System.Drawing.Point(38, 127);
			this.LabelDivisionTrigResult.Name = "LabelDivisionTrigResult";
			this.LabelDivisionTrigResult.Size = new System.Drawing.Size(52, 25);
			this.LabelDivisionTrigResult.TabIndex = 22;
			this.LabelDivisionTrigResult.Text = "z / w";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label13.Location = new System.Drawing.Point(215, 371);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 30);
			this.label13.TabIndex = 18;
			this.label13.Text = "|w|";
			// 
			// LabelZTrigValue
			// 
			this.LabelZTrigValue.AutoSize = true;
			this.LabelZTrigValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZTrigValue.Location = new System.Drawing.Point(464, 306);
			this.LabelZTrigValue.Name = "LabelZTrigValue";
			this.LabelZTrigValue.Size = new System.Drawing.Size(60, 30);
			this.LabelZTrigValue.TabIndex = 19;
			this.LabelZTrigValue.Text = "z = 0";
			// 
			// LabelSubtractionTrigResult
			// 
			this.LabelSubtractionTrigResult.AutoSize = true;
			this.LabelSubtractionTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSubtractionTrigResult.Location = new System.Drawing.Point(38, 57);
			this.LabelSubtractionTrigResult.Name = "LabelSubtractionTrigResult";
			this.LabelSubtractionTrigResult.Size = new System.Drawing.Size(53, 25);
			this.LabelSubtractionTrigResult.TabIndex = 21;
			this.LabelSubtractionTrigResult.Text = "z - w";
			// 
			// LabelWTrigValue
			// 
			this.LabelWTrigValue.AutoSize = true;
			this.LabelWTrigValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWTrigValue.Location = new System.Drawing.Point(464, 375);
			this.LabelWTrigValue.Name = "LabelWTrigValue";
			this.LabelWTrigValue.Size = new System.Drawing.Size(65, 30);
			this.LabelWTrigValue.TabIndex = 20;
			this.LabelWTrigValue.Text = "w = 0";
			// 
			// LabelAdditionTrigResult
			// 
			this.LabelAdditionTrigResult.AutoSize = true;
			this.LabelAdditionTrigResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAdditionTrigResult.Location = new System.Drawing.Point(38, 22);
			this.LabelAdditionTrigResult.Name = "LabelAdditionTrigResult";
			this.LabelAdditionTrigResult.Size = new System.Drawing.Size(58, 25);
			this.LabelAdditionTrigResult.TabIndex = 31;
			this.LabelAdditionTrigResult.Text = "z + w";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.TabControl.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox InputZRe;
		private System.Windows.Forms.TextBox InputZIm;
		private System.Windows.Forms.TextBox InputWRe;
		private System.Windows.Forms.TextBox InputWIm;
		private System.Windows.Forms.Label LabelZRe;
		private System.Windows.Forms.Label LabelZIm;
		private System.Windows.Forms.Label LabelWRe;
		private System.Windows.Forms.Label LabelWImg;
		private System.Windows.Forms.Label LabelZValue;
		private System.Windows.Forms.Label LabelWValue;
		private System.Windows.Forms.Label LabelAdditionResult;
		private System.Windows.Forms.Label LabelSubtractionResult;
		private System.Windows.Forms.Label LabelMultiplicationResult;
		private System.Windows.Forms.Label LabelDivisionResult;
		private System.Windows.Forms.Label LabelPowerResult;
		private System.Windows.Forms.Label LabelAbsResult;
		private System.Windows.Forms.Label LabelArgResult;
		private System.Windows.Forms.Label LabelConjugateResult;
		private System.Windows.Forms.Label LabelSqrtResult;
		private System.Windows.Forms.Label LabelLogResult;
		private System.Windows.Forms.Label LabelExpResult;
		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage TabPage1;
		private System.Windows.Forms.TabPage TabPage2;
		private System.Windows.Forms.Label LabelMultiplicationTrigResult;
		private System.Windows.Forms.Label LabelExpTrigResult;
		private System.Windows.Forms.TextBox InputArgZ;
		private System.Windows.Forms.Label LabelLogTrigResult;
		private System.Windows.Forms.TextBox InputMagZ;
		private System.Windows.Forms.Label LabelSqrtTrigResult;
		private System.Windows.Forms.TextBox InputArgW;
		private System.Windows.Forms.Label LabelConjugateTrigResult;
		private System.Windows.Forms.TextBox InputMagW;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label LabelPowerTrigResult;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label LabelDivisionTrigResult;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label LabelZTrigValue;
		private System.Windows.Forms.Label LabelSubtractionTrigResult;
		private System.Windows.Forms.Label LabelWTrigValue;
		private System.Windows.Forms.Label LabelAdditionTrigResult;
	}
}

