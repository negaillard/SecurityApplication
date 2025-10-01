namespace SecurityApplication
{
	partial class AdminForm
	{
		private System.ComponentModel.IContainer components = null;
		private DataGridView dataGridViewUsers;
		private Button btnFirst, btnPrev, btnNext, btnLast, btnRefresh, btnChangeAdminPassword, btnAddUser, btnBlockUnblock, btnDeleteUser;
		private Label lblSelected;
		private TextBox txtAdminOld, txtAdminNew1, txtAdminNew2, txtNewUserLogin;
		private NumericUpDown numAdminPwdTimeoutDays, numDefaultMinLen, numDefaultPwdDays;
		private CheckBox chkPasswdDiff;


		private void InitializeComponent()
		{
			dataGridViewUsers = new DataGridView();
			btnFirst = new Button();
			btnPrev = new Button();
			btnNext = new Button();
			btnLast = new Button();
			btnRefresh = new Button();
			lblSelected = new Label();
			btnChangeAdminPassword = new Button();
			txtAdminOld = new TextBox();
			txtAdminNew1 = new TextBox();
			txtAdminNew2 = new TextBox();
			numAdminPwdTimeoutDays = new NumericUpDown();
			btnAddUser = new Button();
			txtNewUserLogin = new TextBox();
			chkPasswdDiff = new CheckBox();
			numDefaultMinLen = new NumericUpDown();
			numDefaultPwdDays = new NumericUpDown();
			btnBlockUnblock = new Button();
			btnDeleteUser = new Button();
			lblAdminPwd = new Label();
			lblAdd = new Label();
			lblPolicy = new Label();
			label1 = new Label();
			label2 = new Label();
			groupBox1 = new GroupBox();
			label = new Label();
			label8 = new Label();
			label7 = new Label();
			label6 = new Label();
			groupBox2 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			groupBox3 = new GroupBox();
			((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
			((System.ComponentModel.ISupportInitialize)numAdminPwdTimeoutDays).BeginInit();
			((System.ComponentModel.ISupportInitialize)numDefaultMinLen).BeginInit();
			((System.ComponentModel.ISupportInitialize)numDefaultPwdDays).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridViewUsers
			// 
			dataGridViewUsers.ColumnHeadersHeight = 29;
			dataGridViewUsers.Location = new Point(12, 12);
			dataGridViewUsers.MultiSelect = false;
			dataGridViewUsers.Name = "dataGridViewUsers";
			dataGridViewUsers.ReadOnly = true;
			dataGridViewUsers.RowHeadersWidth = 51;
			dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridViewUsers.Size = new Size(724, 300);
			dataGridViewUsers.TabIndex = 0;
			dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
			// 
			// btnFirst
			// 
			btnFirst.Location = new Point(24, 21);
			btnFirst.Name = "btnFirst";
			btnFirst.Size = new Size(51, 34);
			btnFirst.TabIndex = 1;
			btnFirst.Text = "<<";
			btnFirst.Click += btnFirst_Click;
			// 
			// btnPrev
			// 
			btnPrev.Location = new Point(81, 21);
			btnPrev.Name = "btnPrev";
			btnPrev.Size = new Size(52, 34);
			btnPrev.TabIndex = 2;
			btnPrev.Text = "<";
			btnPrev.Click += btnPrev_Click;
			// 
			// btnNext
			// 
			btnNext.Location = new Point(134, 21);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(54, 34);
			btnNext.TabIndex = 3;
			btnNext.Text = ">";
			btnNext.Click += btnNext_Click;
			// 
			// btnLast
			// 
			btnLast.Location = new Point(194, 21);
			btnLast.Name = "btnLast";
			btnLast.Size = new Size(54, 34);
			btnLast.TabIndex = 4;
			btnLast.Text = ">>";
			btnLast.Click += btnLast_Click;
			// 
			// btnRefresh
			// 
			btnRefresh.Location = new Point(270, 21);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(158, 34);
			btnRefresh.TabIndex = 5;
			btnRefresh.Text = "Обновить";
			btnRefresh.Click += btnRefresh_Click;
			// 
			// lblSelected
			// 
			lblSelected.AutoSize = true;
			lblSelected.Location = new Point(322, 12);
			lblSelected.Name = "lblSelected";
			lblSelected.Size = new Size(0, 20);
			lblSelected.TabIndex = 6;
			// 
			// btnChangeAdminPassword
			// 
			btnChangeAdminPassword.Location = new Point(168, 178);
			btnChangeAdminPassword.Name = "btnChangeAdminPassword";
			btnChangeAdminPassword.Size = new Size(194, 45);
			btnChangeAdminPassword.TabIndex = 12;
			btnChangeAdminPassword.Text = "Сменить пароль";
			btnChangeAdminPassword.Click += btnChangeAdminPassword_Click;
			// 
			// txtAdminOld
			// 
			txtAdminOld.Location = new Point(6, 46);
			txtAdminOld.Name = "txtAdminOld";
			txtAdminOld.Size = new Size(200, 27);
			txtAdminOld.TabIndex = 8;
			txtAdminOld.UseSystemPasswordChar = true;
			// 
			// txtAdminNew1
			// 
			txtAdminNew1.Location = new Point(6, 76);
			txtAdminNew1.Name = "txtAdminNew1";
			txtAdminNew1.Size = new Size(200, 27);
			txtAdminNew1.TabIndex = 9;
			txtAdminNew1.UseSystemPasswordChar = true;
			// 
			// txtAdminNew2
			// 
			txtAdminNew2.Location = new Point(6, 106);
			txtAdminNew2.Name = "txtAdminNew2";
			txtAdminNew2.Size = new Size(200, 27);
			txtAdminNew2.TabIndex = 10;
			txtAdminNew2.UseSystemPasswordChar = true;
			// 
			// numAdminPwdTimeoutDays
			// 
			numAdminPwdTimeoutDays.Location = new Point(6, 136);
			numAdminPwdTimeoutDays.Maximum = new decimal(new int[] { 3650, 0, 0, 0 });
			numAdminPwdTimeoutDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numAdminPwdTimeoutDays.Name = "numAdminPwdTimeoutDays";
			numAdminPwdTimeoutDays.Size = new Size(120, 27);
			numAdminPwdTimeoutDays.TabIndex = 11;
			numAdminPwdTimeoutDays.Value = new decimal(new int[] { 90, 0, 0, 0 });
			// 
			// btnAddUser
			// 
			btnAddUser.Location = new Point(168, 221);
			btnAddUser.Name = "btnAddUser";
			btnAddUser.Size = new Size(200, 51);
			btnAddUser.TabIndex = 18;
			btnAddUser.Text = "Добавить пользователя";
			btnAddUser.Click += btnAddUser_Click;
			// 
			// txtNewUserLogin
			// 
			txtNewUserLogin.Location = new Point(7, 55);
			txtNewUserLogin.Name = "txtNewUserLogin";
			txtNewUserLogin.Size = new Size(200, 27);
			txtNewUserLogin.TabIndex = 14;
			// 
			// chkPasswdDiff
			// 
			chkPasswdDiff.Location = new Point(7, 122);
			chkPasswdDiff.Name = "chkPasswdDiff";
			chkPasswdDiff.Size = new Size(120, 24);
			chkPasswdDiff.TabIndex = 15;
			chkPasswdDiff.Text = "Включить ограничения паролей по-умолч.";
			// 
			// numDefaultMinLen
			// 
			numDefaultMinLen.Location = new Point(212, 122);
			numDefaultMinLen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numDefaultMinLen.Name = "numDefaultMinLen";
			numDefaultMinLen.Size = new Size(120, 27);
			numDefaultMinLen.TabIndex = 16;
			numDefaultMinLen.Value = new decimal(new int[] { 6, 0, 0, 0 });
			// 
			// numDefaultPwdDays
			// 
			numDefaultPwdDays.Location = new Point(10, 186);
			numDefaultPwdDays.Maximum = new decimal(new int[] { 3650, 0, 0, 0 });
			numDefaultPwdDays.Name = "numDefaultPwdDays";
			numDefaultPwdDays.Size = new Size(120, 27);
			numDefaultPwdDays.TabIndex = 17;
			numDefaultPwdDays.Value = new decimal(new int[] { 3, 0, 0, 0 });
			// 
			// btnBlockUnblock
			// 
			btnBlockUnblock.Location = new Point(24, 61);
			btnBlockUnblock.Name = "btnBlockUnblock";
			btnBlockUnblock.Size = new Size(135, 34);
			btnBlockUnblock.TabIndex = 19;
			btnBlockUnblock.Text = "Блок/Разблок";
			btnBlockUnblock.Click += btnBlockUnblock_Click;
			// 
			// btnDeleteUser
			// 
			btnDeleteUser.Location = new Point(290, 61);
			btnDeleteUser.Name = "btnDeleteUser";
			btnDeleteUser.Size = new Size(138, 34);
			btnDeleteUser.TabIndex = 20;
			btnDeleteUser.Text = "Удалить";
			btnDeleteUser.Click += btnDeleteUser_Click;
			// 
			// lblAdminPwd
			// 
			lblAdminPwd.Location = new Point(0, 0);
			lblAdminPwd.Name = "lblAdminPwd";
			lblAdminPwd.Size = new Size(100, 23);
			lblAdminPwd.TabIndex = 7;
			// 
			// lblAdd
			// 
			lblAdd.Location = new Point(0, 0);
			lblAdd.Name = "lblAdd";
			lblAdd.Size = new Size(100, 23);
			lblAdd.TabIndex = 13;
			// 
			// lblPolicy
			// 
			lblPolicy.Location = new Point(0, 0);
			lblPolicy.Name = "lblPolicy";
			lblPolicy.Size = new Size(100, 23);
			lblPolicy.TabIndex = 21;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(5, 23);
			label1.Name = "label1";
			label1.Size = new Size(62, 20);
			label1.TabIndex = 26;
			label1.Text = "Пароль";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 31);
			label2.Name = "label2";
			label2.Size = new Size(56, 20);
			label2.TabIndex = 27;
			label2.Text = "Логин ";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label);
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(btnAddUser);
			groupBox1.Controls.Add(numDefaultPwdDays);
			groupBox1.Controls.Add(numDefaultMinLen);
			groupBox1.Controls.Add(chkPasswdDiff);
			groupBox1.Controls.Add(txtNewUserLogin);
			groupBox1.Location = new Point(749, 288);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(375, 278);
			groupBox1.TabIndex = 28;
			groupBox1.TabStop = false;
			groupBox1.Text = "Ввод нового пользователя";
			// 
			// label
			// 
			label.AutoSize = true;
			label.Location = new Point(10, 158);
			label.Name = "label";
			label.Size = new Size(112, 20);
			label.TabIndex = 31;
			label.Text = "Срок Действия";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(212, 99);
			label8.Name = "label8";
			label8.Size = new Size(108, 20);
			label8.TabIndex = 30;
			label8.Text = "Длина пароля";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(5, 99);
			label7.Name = "label7";
			label7.Size = new Size(103, 20);
			label7.TabIndex = 29;
			label7.Text = "Ограничения";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(10, 89);
			label6.Name = "label6";
			label6.Size = new Size(0, 20);
			label6.TabIndex = 28;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(txtAdminOld);
			groupBox2.Controls.Add(txtAdminNew1);
			groupBox2.Controls.Add(txtAdminNew2);
			groupBox2.Controls.Add(numAdminPwdTimeoutDays);
			groupBox2.Controls.Add(btnChangeAdminPassword);
			groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
			groupBox2.Location = new Point(749, 12);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(368, 229);
			groupBox2.TabIndex = 29;
			groupBox2.TabStop = false;
			groupBox2.Text = "Изменение пароля Админа";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(212, 106);
			label5.Name = "label5";
			label5.Size = new Size(57, 20);
			label5.TabIndex = 29;
			label5.Text = "Новый";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(212, 76);
			label4.Name = "label4";
			label4.Size = new Size(57, 20);
			label4.TabIndex = 28;
			label4.Text = "Новый";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(212, 46);
			label3.Name = "label3";
			label3.Size = new Size(61, 20);
			label3.TabIndex = 27;
			label3.Text = "Старый";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(btnFirst);
			groupBox3.Controls.Add(btnPrev);
			groupBox3.Controls.Add(btnNext);
			groupBox3.Controls.Add(btnLast);
			groupBox3.Controls.Add(btnRefresh);
			groupBox3.Controls.Add(lblSelected);
			groupBox3.Controls.Add(btnBlockUnblock);
			groupBox3.Controls.Add(btnDeleteUser);
			groupBox3.Location = new Point(12, 319);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(454, 103);
			groupBox3.TabIndex = 30;
			groupBox3.TabStop = false;
			groupBox3.Text = "Панель управления";
			// 
			// AdminForm
			// 
			ClientSize = new Size(1130, 580);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(dataGridViewUsers);
			Controls.Add(lblAdminPwd);
			Controls.Add(lblAdd);
			Controls.Add(lblPolicy);
			Name = "AdminForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Админ-панель";
			((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
			((System.ComponentModel.ISupportInitialize)numAdminPwdTimeoutDays).EndInit();
			((System.ComponentModel.ISupportInitialize)numDefaultMinLen).EndInit();
			((System.ComponentModel.ISupportInitialize)numDefaultPwdDays).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
		}
		private Label lblAdminPwd;
		private Label lblAdd;
		private Label lblPolicy;
		private Label label1;
		private Label label2;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label5;
		private Label label4;
		private Label label3;
		private GroupBox groupBox3;
		private Label label;
		private Label label8;
		private Label label7;
		private Label label6;
	}
}
