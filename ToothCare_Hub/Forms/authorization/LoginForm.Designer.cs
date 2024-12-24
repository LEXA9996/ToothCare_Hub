namespace ToothCare_Hub
{
    partial class LoginForm
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
            LoginCloseAndMovePanel = new Panel();
            CloseAuthorization = new Label();
            LoginText = new Panel();
            TextAuthorization = new Label();
            AuthorizationText = new TextBox();
            PanelInput = new Panel();
            RegisterAcc = new Label();
            ForgotPassword = new Label();
            EnterAccount = new Button();
            PasswordInput = new TextBox();
            LoginInput = new TextBox();
            LoginCloseAndMovePanel.SuspendLayout();
            LoginText.SuspendLayout();
            PanelInput.SuspendLayout();
            SuspendLayout();
            // 
            // LoginCloseAndMovePanel
            // 
            LoginCloseAndMovePanel.BackColor = Color.FromArgb(164, 185, 255);
            LoginCloseAndMovePanel.Controls.Add(CloseAuthorization);
            LoginCloseAndMovePanel.Location = new Point(-2, 0);
            LoginCloseAndMovePanel.Name = "LoginCloseAndMovePanel";
            LoginCloseAndMovePanel.Size = new Size(539, 25);
            LoginCloseAndMovePanel.TabIndex = 0;
            LoginCloseAndMovePanel.MouseDown += LoginCloseAndMovePanel_MouseDown;
            LoginCloseAndMovePanel.MouseMove += LoginCloseAndMovePanel_MouseMove;
            // 
            // CloseAuthorization
            // 
            CloseAuthorization.AutoSize = true;
            CloseAuthorization.Cursor = Cursors.Hand;
            CloseAuthorization.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CloseAuthorization.Location = new Point(511, -4);
            CloseAuthorization.Name = "CloseAuthorization";
            CloseAuthorization.Size = new Size(28, 32);
            CloseAuthorization.TabIndex = 1;
            CloseAuthorization.Text = "X";
            CloseAuthorization.Click += CloseAuthorization_Click;
            CloseAuthorization.MouseLeave += CloseAuthorization_MouseLeave;
            CloseAuthorization.MouseMove += CloseAuthorization_MouseMove;
            // 
            // LoginText
            // 
            LoginText.Controls.Add(TextAuthorization);
            LoginText.Controls.Add(AuthorizationText);
            LoginText.Location = new Point(-2, 28);
            LoginText.Name = "LoginText";
            LoginText.Size = new Size(539, 184);
            LoginText.TabIndex = 1;
            // 
            // TextAuthorization
            // 
            TextAuthorization.Dock = DockStyle.Fill;
            TextAuthorization.Font = new Font("Segoe UI Historic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextAuthorization.Location = new Point(0, 0);
            TextAuthorization.Name = "TextAuthorization";
            TextAuthorization.Size = new Size(539, 184);
            TextAuthorization.TabIndex = 1;
            TextAuthorization.Text = "Авторизация";
            TextAuthorization.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthorizationText
            // 
            AuthorizationText.AccessibleRole = AccessibleRole.Animation;
            AuthorizationText.AllowDrop = true;
            AuthorizationText.Dock = DockStyle.Fill;
            AuthorizationText.Font = new Font("Segoe UI Historic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AuthorizationText.Location = new Point(0, 0);
            AuthorizationText.Multiline = true;
            AuthorizationText.Name = "AuthorizationText";
            AuthorizationText.Size = new Size(539, 184);
            AuthorizationText.TabIndex = 0;
            AuthorizationText.Text = "Авторизация";
            AuthorizationText.TextAlign = HorizontalAlignment.Center;
            // 
            // PanelInput
            // 
            PanelInput.BackColor = Color.FromArgb(14, 225, 230);
            PanelInput.Controls.Add(RegisterAcc);
            PanelInput.Controls.Add(ForgotPassword);
            PanelInput.Controls.Add(EnterAccount);
            PanelInput.Controls.Add(PasswordInput);
            PanelInput.Controls.Add(LoginInput);
            PanelInput.Location = new Point(-2, 218);
            PanelInput.Name = "PanelInput";
            PanelInput.Size = new Size(539, 378);
            PanelInput.TabIndex = 2;
            // 
            // RegisterAcc
            // 
            RegisterAcc.AutoSize = true;
            RegisterAcc.Cursor = Cursors.Hand;
            RegisterAcc.Location = new Point(212, 340);
            RegisterAcc.Name = "RegisterAcc";
            RegisterAcc.Size = new Size(89, 15);
            RegisterAcc.TabIndex = 3;
            RegisterAcc.Text = "Нету аккаунта?";
            RegisterAcc.Click += RegisterAcc_Click;
            RegisterAcc.MouseLeave += RegisterAcc_MouseLeave;
            RegisterAcc.MouseMove += RegisterAcc_MouseMove;
            // 
            // ForgotPassword
            // 
            ForgotPassword.AutoSize = true;
            ForgotPassword.Cursor = Cursors.No;
            ForgotPassword.Location = new Point(212, 315);
            ForgotPassword.Name = "ForgotPassword";
            ForgotPassword.Size = new Size(98, 15);
            ForgotPassword.TabIndex = 2;
            ForgotPassword.Text = "Забыли пароль?";
            ForgotPassword.MouseLeave += ForgotPassword_MouseLeave;
            ForgotPassword.MouseMove += ForgotPassword_MouseMove;
            // 
            // EnterAccount
            // 
            EnterAccount.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EnterAccount.Location = new Point(146, 227);
            EnterAccount.Name = "EnterAccount";
            EnterAccount.Size = new Size(262, 66);
            EnterAccount.TabIndex = 1;
            EnterAccount.Text = "Войти";
            EnterAccount.UseVisualStyleBackColor = true;
            EnterAccount.Click += EnterAccount_Click;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordInput.Location = new Point(146, 139);
            PasswordInput.Multiline = true;
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(262, 60);
            PasswordInput.TabIndex = 0;
            PasswordInput.Enter += PasswordInput_Enter;
            PasswordInput.Leave += PasswordInput_Leave;
            // 
            // LoginInput
            // 
            LoginInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginInput.Location = new Point(146, 34);
            LoginInput.Multiline = true;
            LoginInput.Name = "LoginInput";
            LoginInput.Size = new Size(262, 60);
            LoginInput.TabIndex = 0;
            LoginInput.Enter += LoginInput_Enter;
            LoginInput.Leave += LoginInput_Leave;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 591);
            Controls.Add(PanelInput);
            Controls.Add(LoginText);
            Controls.Add(LoginCloseAndMovePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            LoginCloseAndMovePanel.ResumeLayout(false);
            LoginCloseAndMovePanel.PerformLayout();
            LoginText.ResumeLayout(false);
            LoginText.PerformLayout();
            PanelInput.ResumeLayout(false);
            PanelInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginCloseAndMovePanel;
        private Label CloseAuthorization;
        private Panel LoginText;
        private TextBox AuthorizationText;
        private Label TextAuthorization;
        private Panel PanelInput;
        private TextBox PasswordInput;
        private TextBox LoginInput;
        private Button EnterAccount;
        private Label RegisterAcc;
        private Label ForgotPassword;
    }
}