namespace ToothCare_Hub
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CloseRegisterForm = new Label();
            CloseAndMoveForm = new Panel();
            TextRegister = new Panel();
            RegisterText = new Label();
            MainPanelRegister = new Panel();
            CreateAccountButton = new Button();
            HideLoginLabel = new Label();
            CopyPassField = new TextBox();
            PassField = new TextBox();
            SurnameField = new TextBox();
            MailField = new TextBox();
            NickField = new TextBox();
            NameField = new TextBox();
            CloseAndMoveForm.SuspendLayout();
            TextRegister.SuspendLayout();
            MainPanelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // CloseRegisterForm
            // 
            CloseRegisterForm.AutoSize = true;
            CloseRegisterForm.BackColor = Color.FromArgb(164, 185, 255);
            CloseRegisterForm.Cursor = Cursors.Hand;
            CloseRegisterForm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseRegisterForm.ForeColor = Color.Black;
            CloseRegisterForm.Location = new Point(555, -1);
            CloseRegisterForm.Name = "CloseRegisterForm";
            CloseRegisterForm.Size = new Size(28, 32);
            CloseRegisterForm.TabIndex = 0;
            CloseRegisterForm.Text = "X";
            CloseRegisterForm.Click += CloseRegisterForm_Click;
            CloseRegisterForm.MouseLeave += CloseRegisterForm_MouseLeave;
            CloseRegisterForm.MouseMove += CloseRegisterForm_MouseMove;
            // 
            // CloseAndMoveForm
            // 
            CloseAndMoveForm.BackColor = Color.FromArgb(164, 185, 255);
            CloseAndMoveForm.Controls.Add(CloseRegisterForm);
            CloseAndMoveForm.Location = new Point(0, -1);
            CloseAndMoveForm.Name = "CloseAndMoveForm";
            CloseAndMoveForm.Size = new Size(582, 31);
            CloseAndMoveForm.TabIndex = 1;
            CloseAndMoveForm.MouseDown += CloseAndMoveForm_MouseDown;
            CloseAndMoveForm.MouseMove += CloseAndMoveForm_MouseMove;
            // 
            // TextRegister
            // 
            TextRegister.Controls.Add(RegisterText);
            TextRegister.Location = new Point(0, 30);
            TextRegister.Name = "TextRegister";
            TextRegister.Size = new Size(582, 140);
            TextRegister.TabIndex = 2;
            // 
            // RegisterText
            // 
            RegisterText.Dock = DockStyle.Fill;
            RegisterText.Font = new Font("Segoe UI Historic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterText.Location = new Point(0, 0);
            RegisterText.Name = "RegisterText";
            RegisterText.Size = new Size(582, 140);
            RegisterText.TabIndex = 0;
            RegisterText.Text = "Регестрация";
            RegisterText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanelRegister
            // 
            MainPanelRegister.BackColor = Color.FromArgb(163, 255, 241);
            MainPanelRegister.Controls.Add(CreateAccountButton);
            MainPanelRegister.Controls.Add(HideLoginLabel);
            MainPanelRegister.Controls.Add(CopyPassField);
            MainPanelRegister.Controls.Add(PassField);
            MainPanelRegister.Controls.Add(SurnameField);
            MainPanelRegister.Controls.Add(MailField);
            MainPanelRegister.Controls.Add(NickField);
            MainPanelRegister.Controls.Add(NameField);
            MainPanelRegister.Location = new Point(0, 166);
            MainPanelRegister.Name = "MainPanelRegister";
            MainPanelRegister.Size = new Size(583, 444);
            MainPanelRegister.TabIndex = 3;
            // 
            // CreateAccountButton
            // 
            CreateAccountButton.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccountButton.Location = new Point(183, 314);
            CreateAccountButton.Name = "CreateAccountButton";
            CreateAccountButton.Size = new Size(228, 67);
            CreateAccountButton.TabIndex = 7;
            CreateAccountButton.Text = "Зарегистрироваться";
            CreateAccountButton.UseVisualStyleBackColor = true;
            CreateAccountButton.Click += this.CreateAccountButton_Click;
            // 
            // HideLoginLabel
            // 
            HideLoginLabel.AutoSize = true;
            HideLoginLabel.Cursor = Cursors.Hand;
            HideLoginLabel.Font = new Font("Segoe UI", 10F);
            HideLoginLabel.Location = new Point(233, 414);
            HideLoginLabel.Name = "HideLoginLabel";
            HideLoginLabel.Size = new Size(96, 19);
            HideLoginLabel.TabIndex = 6;
            HideLoginLabel.Text = "Есть Аккаунт?";
            HideLoginLabel.Click += HideLoginLabel_Click;
            HideLoginLabel.MouseLeave += HideLoginLabel_MouseLeave;
            HideLoginLabel.MouseMove += HideLoginLabel_MouseMove;
            // 
            // CopyPassField
            // 
            CopyPassField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CopyPassField.Location = new Point(317, 218);
            CopyPassField.Multiline = true;
            CopyPassField.Name = "CopyPassField";
            CopyPassField.Size = new Size(232, 51);
            CopyPassField.TabIndex = 4;
            CopyPassField.Enter += CopyPassField_Enter;
            CopyPassField.Leave += CopyPassField_Leave;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassField.Location = new Point(38, 218);
            PassField.Multiline = true;
            PassField.Name = "PassField";
            PassField.Size = new Size(232, 51);
            PassField.TabIndex = 4;
            PassField.WordWrap = false;
            PassField.Enter += PassField_Enter;
            PassField.Leave += PassField_Leave;
            // 
            // SurnameField
            // 
            SurnameField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SurnameField.Location = new Point(317, 42);
            SurnameField.Multiline = true;
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(232, 51);
            SurnameField.TabIndex = 3;
            SurnameField.Enter += SurnameField_Enter;
            SurnameField.Leave += SurnameField_Leave;
            // 
            // MailField
            // 
            MailField.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MailField.Location = new Point(38, 140);
            MailField.Multiline = true;
            MailField.Name = "MailField";
            MailField.Size = new Size(232, 51);
            MailField.TabIndex = 2;
            MailField.Enter += MailField_Enter;
            MailField.Leave += MailField_Leave;
            // 
            // NickField
            // 
            NickField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NickField.Location = new Point(317, 140);
            NickField.Multiline = true;
            NickField.Name = "NickField";
            NickField.Size = new Size(232, 51);
            NickField.TabIndex = 1;
            NickField.Enter += NickField_Enter;
            NickField.Leave += NickField_Leave;
            // 
            // NameField
            // 
            NameField.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameField.Location = new Point(38, 42);
            NameField.Multiline = true;
            NameField.Name = "NameField";
            NameField.Size = new Size(232, 51);
            NameField.TabIndex = 0;
            NameField.Enter += NameField_Enter;
            NameField.Leave += NameField_Leave;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 608);
            Controls.Add(MainPanelRegister);
            Controls.Add(TextRegister);
            Controls.Add(CloseAndMoveForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            CloseAndMoveForm.ResumeLayout(false);
            CloseAndMoveForm.PerformLayout();
            TextRegister.ResumeLayout(false);
            MainPanelRegister.ResumeLayout(false);
            MainPanelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label CloseRegisterForm;
        private Panel CloseAndMoveForm;
        private Panel TextRegister;
        private Label RegisterText;
        private Panel MainPanelRegister;
        private TextBox PassField;
        private TextBox SurnameField;
        private TextBox MailField;
        private TextBox NickField;
        private TextBox NameField;
        private TextBox CopyPassField;
        private Label HideLoginLabel;
        private Button CreateAccountButton;
    }
}