
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
			this.SuspendLayout();
			// 
			// InputZRe
			// 
			this.InputZRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputZRe.Location = new System.Drawing.Point(91, 329);
			this.InputZRe.Name = "InputZRe";
			this.InputZRe.Size = new System.Drawing.Size(60, 35);
			this.InputZRe.TabIndex = 0;
			this.InputZRe.TextChanged += new System.EventHandler(this.InputZRe_TextChanged);
			// 
			// InputZIm
			// 
			this.InputZIm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputZIm.Location = new System.Drawing.Point(262, 327);
			this.InputZIm.Name = "InputZIm";
			this.InputZIm.Size = new System.Drawing.Size(60, 35);
			this.InputZIm.TabIndex = 1;
			this.InputZIm.TextChanged += new System.EventHandler(this.InputZIm_TextChanged);
			// 
			// InputWRe
			// 
			this.InputWRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputWRe.Location = new System.Drawing.Point(91, 391);
			this.InputWRe.Name = "InputWRe";
			this.InputWRe.Size = new System.Drawing.Size(60, 35);
			this.InputWRe.TabIndex = 2;
			this.InputWRe.TextChanged += new System.EventHandler(this.InputWRe_TextChanged);
			// 
			// InputWIm
			// 
			this.InputWIm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.InputWIm.Location = new System.Drawing.Point(262, 389);
			this.InputWIm.Name = "InputWIm";
			this.InputWIm.Size = new System.Drawing.Size(60, 35);
			this.InputWIm.TabIndex = 3;
			this.InputWIm.TextChanged += new System.EventHandler(this.InputWIm_TextChanged);
			// 
			// LabelZRe
			// 
			this.LabelZRe.AutoSize = true;
			this.LabelZRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZRe.Location = new System.Drawing.Point(22, 335);
			this.LabelZRe.Name = "LabelZRe";
			this.LabelZRe.Size = new System.Drawing.Size(58, 30);
			this.LabelZRe.TabIndex = 4;
			this.LabelZRe.Text = "Re(z)";
			// 
			// LabelZIm
			// 
			this.LabelZIm.AutoSize = true;
			this.LabelZIm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZIm.Location = new System.Drawing.Point(195, 333);
			this.LabelZIm.Name = "LabelZIm";
			this.LabelZIm.Size = new System.Drawing.Size(59, 30);
			this.LabelZIm.TabIndex = 5;
			this.LabelZIm.Text = "Im(z)";
			// 
			// LabelWRe
			// 
			this.LabelWRe.AutoSize = true;
			this.LabelWRe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWRe.Location = new System.Drawing.Point(22, 394);
			this.LabelWRe.Name = "LabelWRe";
			this.LabelWRe.Size = new System.Drawing.Size(63, 30);
			this.LabelWRe.TabIndex = 6;
			this.LabelWRe.Text = "Re(w)";
			// 
			// LabelWImg
			// 
			this.LabelWImg.AutoSize = true;
			this.LabelWImg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWImg.Location = new System.Drawing.Point(195, 392);
			this.LabelWImg.Name = "LabelWImg";
			this.LabelWImg.Size = new System.Drawing.Size(64, 30);
			this.LabelWImg.TabIndex = 7;
			this.LabelWImg.Text = "Im(w)";
			// 
			// LabelZValue
			// 
			this.LabelZValue.AutoSize = true;
			this.LabelZValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelZValue.Location = new System.Drawing.Point(459, 327);
			this.LabelZValue.Name = "LabelZValue";
			this.LabelZValue.Size = new System.Drawing.Size(60, 30);
			this.LabelZValue.TabIndex = 8;
			this.LabelZValue.Text = "z = 0";
			// 
			// LabelWValue
			// 
			this.LabelWValue.AutoSize = true;
			this.LabelWValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelWValue.Location = new System.Drawing.Point(459, 396);
			this.LabelWValue.Name = "LabelWValue";
			this.LabelWValue.Size = new System.Drawing.Size(65, 30);
			this.LabelWValue.TabIndex = 9;
			this.LabelWValue.Text = "w = 0";
			// 
			// LabelAdditionResult
			// 
			this.LabelAdditionResult.AutoSize = true;
			this.LabelAdditionResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAdditionResult.Location = new System.Drawing.Point(33, 43);
			this.LabelAdditionResult.Name = "LabelAdditionResult";
			this.LabelAdditionResult.Size = new System.Drawing.Size(58, 25);
			this.LabelAdditionResult.TabIndex = 10;
			this.LabelAdditionResult.Text = "z + w";
			// 
			// LabelSubtractionResult
			// 
			this.LabelSubtractionResult.AutoSize = true;
			this.LabelSubtractionResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSubtractionResult.Location = new System.Drawing.Point(33, 78);
			this.LabelSubtractionResult.Name = "LabelSubtractionResult";
			this.LabelSubtractionResult.Size = new System.Drawing.Size(53, 25);
			this.LabelSubtractionResult.TabIndex = 10;
			this.LabelSubtractionResult.Text = "z - w";
			// 
			// LabelMultiplicationResult
			// 
			this.LabelMultiplicationResult.AutoSize = true;
			this.LabelMultiplicationResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelMultiplicationResult.Location = new System.Drawing.Point(33, 113);
			this.LabelMultiplicationResult.Name = "LabelMultiplicationResult";
			this.LabelMultiplicationResult.Size = new System.Drawing.Size(53, 25);
			this.LabelMultiplicationResult.TabIndex = 10;
			this.LabelMultiplicationResult.Text = "z * w";
			// 
			// LabelDivisionResult
			// 
			this.LabelDivisionResult.AutoSize = true;
			this.LabelDivisionResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelDivisionResult.Location = new System.Drawing.Point(33, 148);
			this.LabelDivisionResult.Name = "LabelDivisionResult";
			this.LabelDivisionResult.Size = new System.Drawing.Size(52, 25);
			this.LabelDivisionResult.TabIndex = 10;
			this.LabelDivisionResult.Text = "z / w";
			// 
			// LabelPowerResult
			// 
			this.LabelPowerResult.AutoSize = true;
			this.LabelPowerResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelPowerResult.Location = new System.Drawing.Point(33, 183);
			this.LabelPowerResult.Name = "LabelPowerResult";
			this.LabelPowerResult.Size = new System.Drawing.Size(90, 25);
			this.LabelPowerResult.TabIndex = 10;
			this.LabelPowerResult.Text = "z ^ Re(w)";
			// 
			// LabelAbsResult
			// 
			this.LabelAbsResult.AutoSize = true;
			this.LabelAbsResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelAbsResult.Location = new System.Drawing.Point(33, 218);
			this.LabelAbsResult.Name = "LabelAbsResult";
			this.LabelAbsResult.Size = new System.Drawing.Size(31, 25);
			this.LabelAbsResult.TabIndex = 10;
			this.LabelAbsResult.Text = "|z|";
			// 
			// LabelArgResult
			// 
			this.LabelArgResult.AutoSize = true;
			this.LabelArgResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelArgResult.Location = new System.Drawing.Point(395, 43);
			this.LabelArgResult.Name = "LabelArgResult";
			this.LabelArgResult.Size = new System.Drawing.Size(63, 25);
			this.LabelArgResult.TabIndex = 10;
			this.LabelArgResult.Text = "Arg(z)";
			// 
			// LabelConjugateResult
			// 
			this.LabelConjugateResult.AutoSize = true;
			this.LabelConjugateResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelConjugateResult.Location = new System.Drawing.Point(395, 78);
			this.LabelConjugateResult.Name = "LabelConjugateResult";
			this.LabelConjugateResult.Size = new System.Drawing.Size(29, 25);
			this.LabelConjugateResult.TabIndex = 10;
			this.LabelConjugateResult.Text = "z*";
			// 
			// LabelSqrtResult
			// 
			this.LabelSqrtResult.AutoSize = true;
			this.LabelSqrtResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelSqrtResult.Location = new System.Drawing.Point(395, 113);
			this.LabelSqrtResult.Name = "LabelSqrtResult";
			this.LabelSqrtResult.Size = new System.Drawing.Size(67, 25);
			this.LabelSqrtResult.TabIndex = 10;
			this.LabelSqrtResult.Text = "Sqrt(z)";
			// 
			// LabelLogResult
			// 
			this.LabelLogResult.AutoSize = true;
			this.LabelLogResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelLogResult.Location = new System.Drawing.Point(395, 148);
			this.LabelLogResult.Name = "LabelLogResult";
			this.LabelLogResult.Size = new System.Drawing.Size(64, 25);
			this.LabelLogResult.TabIndex = 10;
			this.LabelLogResult.Text = "Log(z)";
			// 
			// LabelExpResult
			// 
			this.LabelExpResult.AutoSize = true;
			this.LabelExpResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LabelExpResult.Location = new System.Drawing.Point(395, 183);
			this.LabelExpResult.Name = "LabelExpResult";
			this.LabelExpResult.Size = new System.Drawing.Size(63, 25);
			this.LabelExpResult.TabIndex = 10;
			this.LabelExpResult.Text = "Exp(z)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LabelExpResult);
			this.Controls.Add(this.LabelLogResult);
			this.Controls.Add(this.LabelSqrtResult);
			this.Controls.Add(this.LabelConjugateResult);
			this.Controls.Add(this.LabelArgResult);
			this.Controls.Add(this.LabelAbsResult);
			this.Controls.Add(this.LabelPowerResult);
			this.Controls.Add(this.LabelDivisionResult);
			this.Controls.Add(this.LabelMultiplicationResult);
			this.Controls.Add(this.LabelSubtractionResult);
			this.Controls.Add(this.LabelAdditionResult);
			this.Controls.Add(this.LabelWValue);
			this.Controls.Add(this.LabelZValue);
			this.Controls.Add(this.LabelWImg);
			this.Controls.Add(this.LabelWRe);
			this.Controls.Add(this.LabelZIm);
			this.Controls.Add(this.LabelZRe);
			this.Controls.Add(this.InputWIm);
			this.Controls.Add(this.InputWRe);
			this.Controls.Add(this.InputZIm);
			this.Controls.Add(this.InputZRe);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}

