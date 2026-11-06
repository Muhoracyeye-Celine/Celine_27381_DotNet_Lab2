namespace Lab2
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer? components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInfo = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(540, 360);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "LoginForm";
            Text = "Lab 2 - Login";
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Welcome - Lab 2";
            lblTitle.Location = new Point(40, 25);
            lblTitle.Size = new Size(460, 40);
            lblTitle.TabIndex = 0;
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInfo.Name = "lblInfo";
            lblInfo.Text = "Enter a username and password to continue.";
            lblInfo.Location = new Point(40, 75);
            lblInfo.Size = new Size(460, 28);
            lblInfo.TabIndex = 1;
            lblInfo.AutoSize = false;
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username";
            lblUsername.Location = new Point(40, 125);
            lblUsername.Size = new Size(140, 28);
            lblUsername.TabIndex = 2;
            lblUsername.AutoSize = false;
            txtUsername.Name = "txtUsername";
            txtUsername.Text = "";
            txtUsername.Location = new Point(190, 122);
            txtUsername.Size = new Size(300, 30);
            txtUsername.TabIndex = 3;
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password";
            lblPassword.Location = new Point(40, 180);
            lblPassword.Size = new Size(140, 28);
            lblPassword.TabIndex = 4;
            lblPassword.AutoSize = false;
            txtPassword.Name = "txtPassword";
            txtPassword.Text = "";
            txtPassword.Location = new Point(190, 177);
            txtPassword.Size = new Size(300, 30);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            btnLogin.Name = "btnLogin";
            btnLogin.Text = "Login";
            btnLogin.Location = new Point(190, 250);
            btnLogin.Size = new Size(140, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Click += btnLogin_Click;
            btnClose.Name = "btnClose";
            btnClose.Text = "Close";
            btnClose.Location = new Point(350, 250);
            btnClose.Size = new Size(130, 40);
            btnClose.TabIndex = 8;
            btnClose.Click += btnClose_Click;
            Controls.Add(lblTitle);
            Controls.Add(lblInfo);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnClose);
            AcceptButton = btnLogin;

            BackColor = Color.FromArgb(243, 246, 251);
            ForeColor = Color.FromArgb(35, 49, 70);
            lblTitle.ForeColor = Color.FromArgb(25, 47, 79);
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(74, 91, 114);
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.FromArgb(25, 47, 79);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.FromArgb(25, 47, 79);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.BackColor = Color.FromArgb(16, 112, 113);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 92, 94);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 75, 77);
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.Cursor = Cursors.Hand;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.BackColor = Color.FromArgb(169, 56, 68);
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 42, 53);
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 33, 44);
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Cursor = Cursors.Hand;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblTitle = null!;
        private Label lblInfo = null!;
        private Label lblUsername = null!;
        private TextBox txtUsername = null!;
        private Label lblPassword = null!;
        private TextBox txtPassword = null!;
        private Button btnLogin = null!;
        private Button btnClose = null!;
    }
}
