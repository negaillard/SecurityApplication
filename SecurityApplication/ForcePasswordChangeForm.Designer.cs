namespace SecurityApplication
{
	partial class ForcePasswordChangeForm
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

		private void InitializeComponent()
		{
			lblTitle = new Label();
			lblNew1 = new Label();
			lblNew2 = new Label();
			txtNew1 = new TextBox();
			txtNew2 = new TextBox();
			btnChange = new Button();
			SuspendLayout();
			// 
			// lblTitle
			// 
			lblTitle.Dock = DockStyle.Top;
			lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			lblTitle.ForeColor = Color.Red;
			lblTitle.Location = new Point(0, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(439, 53);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "ПОМЕНЯЙТЕ ПАРОЛЬ";
			lblTitle.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNew1
			// 
			lblNew1.AutoSize = true;
			lblNew1.Location = new Point(12, 96);
			lblNew1.Name = "lblNew1";
			lblNew1.Size = new Size(173, 20);
			lblNew1.TabIndex = 1;
			lblNew1.Text = "Введите новый пароль:";
			// 
			// lblNew2
			// 
			lblNew2.AutoSize = true;
			lblNew2.Location = new Point(12, 159);
			lblNew2.Name = "lblNew2";
			lblNew2.Size = new Size(192, 20);
			lblNew2.TabIndex = 2;
			lblNew2.Text = "Повторите новый пароль:";
			// 
			// txtNew1
			// 
			txtNew1.Location = new Point(206, 89);
			txtNew1.Margin = new Padding(3, 4, 3, 4);
			txtNew1.Name = "txtNew1";
			txtNew1.PasswordChar = '*';
			txtNew1.Size = new Size(182, 27);
			txtNew1.TabIndex = 3;
			// 
			// txtNew2
			// 
			txtNew2.Location = new Point(206, 156);
			txtNew2.Margin = new Padding(3, 4, 3, 4);
			txtNew2.Name = "txtNew2";
			txtNew2.PasswordChar = '*';
			txtNew2.Size = new Size(182, 27);
			txtNew2.TabIndex = 4;
			// 
			// btnChange
			// 
			btnChange.Location = new Point(149, 227);
			btnChange.Margin = new Padding(3, 4, 3, 4);
			btnChange.Name = "btnChange";
			btnChange.Size = new Size(137, 47);
			btnChange.TabIndex = 5;
			btnChange.Text = "Сменить пароль";
			btnChange.UseVisualStyleBackColor = true;
			btnChange.Click += btnChange_Click;
			// 
			// ForcePasswordChangeForm
			// 
			AcceptButton = btnChange;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(439, 308);
			Controls.Add(btnChange);
			Controls.Add(txtNew2);
			Controls.Add(txtNew1);
			Controls.Add(lblNew2);
			Controls.Add(lblNew1);
			Controls.Add(lblTitle);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(3, 4, 3, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ForcePasswordChangeForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Смена пароля";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblNew1;
		private System.Windows.Forms.Label lblNew2;
		private System.Windows.Forms.TextBox txtNew1;
		private System.Windows.Forms.TextBox txtNew2;
		private System.Windows.Forms.Button btnChange;
	}
}