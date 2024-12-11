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
            RegButton = new Button();
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
            CloseRegisterForm.Font = new Font("Segoe UI", 15F);
            CloseRegisterForm.ForeColor = Color.Black;
            CloseRegisterForm.Location = new Point(559, 0);
            CloseRegisterForm.Name = "CloseRegisterForm";
            CloseRegisterForm.Size = new Size(24, 28);
            CloseRegisterForm.TabIndex = 0;
            CloseRegisterForm.Text = "X";
            CloseRegisterForm.Click += CloseRegisterForm_Click;
            // 
            // CloseAndMoveForm
            // 
            CloseAndMoveForm.BackColor = Color.FromArgb(164, 185, 255);
            CloseAndMoveForm.Controls.Add(CloseRegisterForm);
            CloseAndMoveForm.Location = new Point(0, -1);
            CloseAndMoveForm.Name = "CloseAndMoveForm";
            CloseAndMoveForm.Size = new Size(582, 31);
            CloseAndMoveForm.TabIndex = 1;
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
            MainPanelRegister.Controls.Add(RegButton);
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
            // RegButton
            // 
            RegButton.Font = new Font("Segoe UI Emoji", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegButton.Location = new Point(181, 324);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(232, 69);
            RegButton.TabIndex = 5;
            RegButton.Text = "Зарегестирироваться";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.MouseMove += RegButton_MouseMove;
            // 
            // CopyPassField
            // 
            CopyPassField.Location = new Point(317, 218);
            CopyPassField.Multiline = true;
            CopyPassField.Name = "CopyPassField";
            CopyPassField.Size = new Size(232, 51);
            CopyPassField.TabIndex = 4;
            // 
            // PassField
            // 
            PassField.Location = new Point(38, 218);
            PassField.Multiline = true;
            PassField.Name = "PassField";
            PassField.Size = new Size(232, 51);
            PassField.TabIndex = 4;
            // 
            // SurnameField
            // 
            SurnameField.Location = new Point(317, 42);
            SurnameField.Multiline = true;
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(232, 51);
            SurnameField.TabIndex = 3;
            // 
            // MailField
            // 
            MailField.Location = new Point(38, 140);
            MailField.Multiline = true;
            MailField.Name = "MailField";
            MailField.Size = new Size(232, 51);
            MailField.TabIndex = 2;
            // 
            // NickField
            // 
            NickField.Location = new Point(317, 140);
            NickField.Multiline = true;
            NickField.Name = "NickField";
            NickField.Size = new Size(232, 51);
            NickField.TabIndex = 1;
            // 
            // NameField
            // 
            NameField.Location = new Point(38, 42);
            NameField.Multiline = true;
            NameField.Name = "NameField";
            NameField.Size = new Size(232, 51);
            NameField.TabIndex = 0;
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
        private Button RegButton;
        private TextBox PassField;
        private TextBox SurnameField;
        private TextBox MailField;
        private TextBox NickField;
        private TextBox NameField;
        private TextBox CopyPassField;
    }
}