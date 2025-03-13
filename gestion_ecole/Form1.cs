namespace Gestion_Ecole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataEleve.DataSource = new DAOEleve().findAll();
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            new DAOEleve().insert(new Eleve(0, t_nom.Text, t_prenom.Text, t_ville.Text, t_specialite.Text));
            DataEleve.DataSource = new DAOEleve().findAll();
        }

        private void b_Rechercher_Click(object sender, EventArgs e)
        {
            DataEleve.DataSource = new DAOEleve().find(new Eleve(0, t_nom.Text.Trim(), t_prenom.Text.Trim(), t_ville.Text.Trim(), t_specialite.Text.Trim()));
        }

        private void b_Renitialiser_Click(object sender, EventArgs e)
        {
            DataEleve.DataSource = new DAOEleve().findAll();
        }

        private void b_Supprimer_Click(object sender, EventArgs e)
        {
            if (DataEleve.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DataEleve.SelectedRows[0].Cells[0].Value);
                new DAOEleve().delete(id);
                DataEleve.DataSource = new DAOEleve().findAll();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élève à supprimer.");
            }
        }

        private void b_Modifier_Click(object sender, EventArgs e)
        {
            if (DataEleve.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(DataEleve.SelectedRows[0].Cells["Id"].Value);

                // Ensure no empty fields
                if (string.IsNullOrWhiteSpace(t_nom.Text) ||
                    string.IsNullOrWhiteSpace(t_prenom.Text) ||
                    string.IsNullOrWhiteSpace(t_ville.Text) ||
                    string.IsNullOrWhiteSpace(t_specialite.Text))
                {
                    MessageBox.Show("Tous les champs doivent être remplis avant de modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create an updated Eleve object
                Eleve eleve = new Eleve(id, t_nom.Text.Trim(), t_prenom.Text.Trim(), t_ville.Text.Trim(), t_specialite.Text.Trim());

                // Perform update
                int result = new DAOEleve().update(eleve);

                if (result > 0)
                {
                    MessageBox.Show("Modification réussie !");
                }
                else
                {
                    MessageBox.Show("Échec de la modification.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Refresh DataGridView
                DataEleve.DataSource = new DAOEleve().findAll();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élève à modifier.");
            }
        }

        private void DataEleve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is selected
            {
                DataGridViewRow row = DataEleve.Rows[e.RowIndex];

                // Fill the text fields with selected row data
                t_nom.Text = row.Cells["Nom"].Value.ToString();
                t_prenom.Text = row.Cells["Prenom"].Value.ToString();
                t_ville.Text = row.Cells["Ville"].Value.ToString();
                t_specialite.Text = row.Cells["Specialite"].Value.ToString();
            }
        }



    }
}
