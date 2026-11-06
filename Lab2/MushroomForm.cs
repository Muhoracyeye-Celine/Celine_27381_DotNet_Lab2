namespace Lab2
{
    public partial class MushroomForm : Form
    {

        private string stage = "convex";
        private string convex = "";
        private string forest = "";
        private string ring = "";
        private string gills = "";
        private int questionNumber = 1;

        public MushroomForm() { InitializeComponent(); AcceptButton = btnSubmit; }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            string answer = txtAnswer.Text.Trim().ToLower();
            if (answer != "yes" && answer != "no")
            {
                MessageBox.Show("Please enter yes or no.", "Invalid answer");
                txtAnswer.SelectAll();
                txtAnswer.Focus();
                return; 
            }

            string result = "";
            if (stage == "convex")
            {
                convex = answer;
                if (convex == "yes")
                {
                    stage = "forest";
                    lblQuestion.Text = "Does your mushroom grow in a forest?";
                }
                else
                {
                    stage = "gills";
                    lblQuestion.Text = "Does your mushroom have gills?";
                }
            }
            else if (stage == "forest")
            {
                forest = answer;
                if (convex == "yes")
                {
                    if (forest == "no")
                    {
                        result = "Agaric Jaunissant";
                    }
                    else
                    {
                        stage = "ring";
                        lblQuestion.Text = "Does your mushroom have a ring?";
                    }
                }
                else
                {
                    if (forest == "yes")
                    {
                        result = "Girolle";
                    }
                    else
                    {
                        result = "Coprin chevelu";
                    }
                }
            }
            else if (stage == "ring")
            {
                ring = answer;
                if (ring == "yes")
                {
                    result = "Amanite tue-mouche";
                }
                else
                {
                    result = "Pied bleu";
                }
            }
            else if (stage == "gills")
            {
                gills = answer;
                if (gills == "no")
                {
                    result = "Cepe de bordeau";
                }
                else
                {
                    stage = "forest";
                    lblQuestion.Text = "Does your mushroom grow in a forest?";
                }
            }

            txtAnswer.Clear();
            if (result != "")
            {
                txtResult.Text = result;
                lblQuestion.Text = "Mushroom identified! Click Restart to try again.";
                lblProgress.Text = "Completed in " + questionNumber + " questions";
                txtAnswer.Enabled = false;
                btnSubmit.Enabled = false;
                btnRestart.Focus();
            }
            else
            {
                questionNumber++;
                lblProgress.Text = "Question " + questionNumber + " of at most 3";
                txtAnswer.Focus();
            }
        }

        private void btnRestart_Click(object? sender, EventArgs e)
        {
            stage = "convex";
            convex = "";
            forest = "";
            ring = "";
            gills = "";
            questionNumber = 1;
            lblProgress.Text = "Question 1 of at most 3";
            lblQuestion.Text = "Does your mushroom have a convex cup?";
            txtResult.Clear();
            txtAnswer.Clear();
            txtAnswer.Enabled = true;
            btnSubmit.Enabled = true;
            txtAnswer.Focus();
        }

        private void btnBack_Click(object? sender, EventArgs e) { Close(); }
        private void btnLogout_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
        private void btnExit_Click(object? sender, EventArgs e) { Application.Exit(); }
    }
}
