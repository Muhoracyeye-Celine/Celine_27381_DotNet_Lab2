namespace Lab2
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            btnLogout = new Button();
            btnExit = new Button();
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 10F);
            ClientSize = new Size(560, 340);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "ChooseForm";
            Text = "Lab 2 - Choose a Program";
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "Choose a Program";
            lblTitle.Location = new Point(40, 30);
            lblTitle.Size = new Size(480, 40);
            lblTitle.TabIndex = 0;
            lblTitle.AutoSize = false;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblInfo.Name = "lblInfo";
            lblInfo.Text = "Select one of the two activities below.";
            lblInfo.Location = new Point(40, 85);
            lblInfo.Size = new Size(500, 28);
            lblInfo.TabIndex = 1;
            lblInfo.AutoSize = false;
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Text = "Bicycle Rental";
            btnBicycle.Location = new Point(40, 140);
            btnBicycle.Size = new Size(220, 40);
            btnBicycle.TabIndex = 2;
            btnBicycle.Click += btnBicycle_Click;
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Text = "Mushroom Identification";
            btnMushroom.Location = new Point(280, 140);
            btnMushroom.Size = new Size(240, 40);
            btnMushroom.TabIndex = 3;
            btnMushroom.Click += btnMushroom_Click;
            btnLogout.Name = "btnLogout";
            btnLogout.Text = "Logout";
            btnLogout.Location = new Point(140, 240);
            btnLogout.Size = new Size(130, 40);
            btnLogout.TabIndex = 4;
            btnLogout.Click += btnLogout_Click;
            btnExit.Name = "btnExit";
            btnExit.Text = "Exit";
            btnExit.Location = new Point(290, 240);
            btnExit.Size = new Size(130, 40);
            btnExit.TabIndex = 5;
            btnExit.Click += btnExit_Click;
            Controls.Add(lblTitle);
            Controls.Add(lblInfo);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            Controls.Add(btnLogout);
            Controls.Add(btnExit);

            BackColor = Color.FromArgb(243, 246, 251);
            ForeColor = Color.FromArgb(35, 49, 70);
            lblTitle.ForeColor = Color.FromArgb(25, 47, 79);
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInfo.ForeColor = Color.FromArgb(74, 91, 114);
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.BackColor = Color.FromArgb(16, 112, 113);
            btnBicycle.ForeColor = Color.White;
            btnBicycle.FlatStyle = FlatStyle.Flat;
            btnBicycle.FlatAppearance.BorderSize = 0;
            btnBicycle.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 92, 94);
            btnBicycle.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 75, 77);
            btnBicycle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBicycle.Cursor = Cursors.Hand;
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.BackColor = Color.FromArgb(16, 112, 113);
            btnMushroom.ForeColor = Color.White;
            btnMushroom.FlatStyle = FlatStyle.Flat;
            btnMushroom.FlatAppearance.BorderSize = 0;
            btnMushroom.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 92, 94);
            btnMushroom.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 75, 77);
            btnMushroom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMushroom.Cursor = Cursors.Hand;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.BackColor = Color.FromArgb(224, 232, 242);
            btnLogout.ForeColor = Color.FromArgb(25, 47, 79);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 219, 234);
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(189, 205, 225);
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.Cursor = Cursors.Hand;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.BackColor = Color.FromArgb(169, 56, 68);
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(141, 42, 53);
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(115, 33, 44);
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnExit.Cursor = Cursors.Hand;
            ResumeLayout(false);
            PerformLayout();
        }
        private Label lblTitle = null!;
        private Label lblInfo = null!;
        private Button btnBicycle = null!;
        private Button btnMushroom = null!;
        private Button btnLogout = null!;
        private Button btnExit = null!;
    }
}
