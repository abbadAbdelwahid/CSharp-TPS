namespace Gestion_Ecole
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
private void InitializeComponent()
{
    // Form Settings
    this.Text = "Gestion des Élèves";
    this.Size = new System.Drawing.Size(1100, 650);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.BackColor = Color.FromArgb(245, 245, 245); // Soft Background

    // ==== GroupBox for Student Info ====
    GroupBox groupBox = new GroupBox
    {
        Text = "Informations de l'Élève",
        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
        ForeColor = Color.Black,
        Location = new Point(30, 20),
        Size = new Size(1000, 200),
        BackColor = Color.White
    };

    // ==== Labels ====
    label1 = new Label { Text = "Nom :", Location = new Point(20, 40), AutoSize = true, Font = new Font("Segoe UI", 11F) };
    label2 = new Label { Text = "Prénom :", Location = new Point(20, 80), AutoSize = true, Font = new Font("Segoe UI", 11F) };
    label3 = new Label { Text = "Ville :", Location = new Point(20, 120), AutoSize = true, Font = new Font("Segoe UI", 11F) };
    label4 = new Label { Text = "Spécialité :", Location = new Point(500, 40), AutoSize = true, Font = new Font("Segoe UI", 11F) };

    // ==== TextBoxes ====
    t_nom = new TextBox { Location = new Point(100, 40), Width = 300, Font = new Font("Segoe UI", 11F), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White };
    t_prenom = new TextBox { Location = new Point(100, 80), Width = 300, Font = new Font("Segoe UI", 11F), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White };
    t_ville = new TextBox { Location = new Point(100, 120), Width = 300, Font = new Font("Segoe UI", 11F), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White };
    t_specialite = new TextBox { Location = new Point(600, 40), Width = 300, Font = new Font("Segoe UI", 11F), BorderStyle = BorderStyle.FixedSingle, BackColor = Color.White };

    // ==== Buttons with Modern Flat UI Colors ====
    b_Ajouter = new Button { Text = "Ajouter", Location = new Point(30, 240), Size = new Size(150, 45), BackColor = ColorTranslator.FromHtml("#2ecc71"), FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.White };
    b_Modifier = new Button { Text = "Modifier", Location = new Point(200, 240), Size = new Size(150, 45), BackColor = ColorTranslator.FromHtml("#f39c12"), FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.White };
    b_Supprimer = new Button { Text = "Supprimer", Location = new Point(370, 240), Size = new Size(150, 45), BackColor = ColorTranslator.FromHtml("#e74c3c"), FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.White };
    b_Rechercher = new Button { Text = "Rechercher", Location = new Point(540, 240), Size = new Size(150, 45), BackColor = ColorTranslator.FromHtml("#3498db"), FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.White };
    b_Renitialiser = new Button { Text = "Réinitialiser", Location = new Point(710, 240), Size = new Size(150, 45), BackColor = ColorTranslator.FromHtml("#bdc3c7"), FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 11F, FontStyle.Bold), ForeColor = Color.White };

    // Hover Effects for Buttons
    b_Ajouter.FlatAppearance.BorderSize = 0; b_Ajouter.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(ColorTranslator.FromHtml("#2ecc71"), 0.2f);
    b_Modifier.FlatAppearance.BorderSize = 0; b_Modifier.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(ColorTranslator.FromHtml("#f39c12"), 0.2f);
    b_Supprimer.FlatAppearance.BorderSize = 0; b_Supprimer.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(ColorTranslator.FromHtml("#e74c3c"), 0.2f);
    b_Rechercher.FlatAppearance.BorderSize = 0; b_Rechercher.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(ColorTranslator.FromHtml("#3498db"), 0.2f);
    b_Renitialiser.FlatAppearance.BorderSize = 0; b_Renitialiser.FlatAppearance.MouseOverBackColor = ControlPaint.Dark(ColorTranslator.FromHtml("#bdc3c7"), 0.2f);

    // ==== DataGridView ====
    DataEleve = new DataGridView
    {
        Location = new Point(30, 310),
        Size = new Size(1000, 250),
        ReadOnly = true,
        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
        BackgroundColor = Color.White,
        BorderStyle = BorderStyle.Fixed3D,
        ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle 
        { 
            Font = new Font("Segoe UI", 11F, FontStyle.Bold), 
            BackColor = Color.LightSteelBlue 
        },
        DefaultCellStyle = new DataGridViewCellStyle { Font = new Font("Segoe UI", 10F) }
    };

    // === Hover Effect for DataGridView Rows ===
    DataEleve.CellMouseEnter += (s, e) =>
    {
        if (e.RowIndex >= 0) DataEleve.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
    };
    DataEleve.CellMouseLeave += (s, e) =>
    {
        if (e.RowIndex >= 0) DataEleve.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
    };

    // === Add Controls to GroupBox ===
    groupBox.Controls.Add(label1);
    groupBox.Controls.Add(label2);
    groupBox.Controls.Add(label3);
    groupBox.Controls.Add(label4);
    groupBox.Controls.Add(t_nom);
    groupBox.Controls.Add(t_prenom);
    groupBox.Controls.Add(t_ville);
    groupBox.Controls.Add(t_specialite);

    // === Add Controls to the Form ===
    this.Controls.Add(groupBox);
    this.Controls.Add(b_Ajouter);
    this.Controls.Add(b_Modifier);
    this.Controls.Add(b_Supprimer);
    this.Controls.Add(b_Rechercher);
    this.Controls.Add(b_Renitialiser);
    this.Controls.Add(DataEleve);

    // ==== Event Handlers ====
    b_Ajouter.Click += b_Ajouter_Click;
    b_Modifier.Click += b_Modifier_Click;
    b_Supprimer.Click += b_Supprimer_Click;
    b_Rechercher.Click += b_Rechercher_Click;
    b_Renitialiser.Click += b_Renitialiser_Click;
    DataEleve.CellClick += DataEleve_CellClick;
}



        private System.Windows.Forms.Button b_Supprimer;
        private System.Windows.Forms.Button b_Modifier;

        private System.Windows.Forms.Button b_Renitialiser;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_nom;
        private System.Windows.Forms.TextBox t_prenom;
        private System.Windows.Forms.TextBox t_ville;
        private System.Windows.Forms.TextBox t_specialite;
        private System.Windows.Forms.Button b_Ajouter;
        private System.Windows.Forms.DataGridView DataEleve;
        private System.Windows.Forms.Button b_Rechercher;
    }
}
