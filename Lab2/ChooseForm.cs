namespace Lab2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm() { InitializeComponent(); }

        private void btnBicycle_Click(object? sender, EventArgs e)
        {
            Hide();
            using (BicycleForm bicycle = new BicycleForm())
            {
                DialogResult result = bicycle.ShowDialog(this);
                if (IsDisposed || Disposing) return;
                if (result == DialogResult.Abort) { Close(); return; }
            }
            Show();
        }

        private void btnMushroom_Click(object? sender, EventArgs e)
        {
            Hide();
            using (MushroomForm mushroom = new MushroomForm())
            {
                DialogResult result = mushroom.ShowDialog(this);
                if (IsDisposed || Disposing) return;
                if (result == DialogResult.Abort) { Close(); return; }
            }
            Show();
        }

        private void btnLogout_Click(object? sender, EventArgs e) { Close(); }
        private void btnExit_Click(object? sender, EventArgs e) { Application.Exit(); }
    }
}
