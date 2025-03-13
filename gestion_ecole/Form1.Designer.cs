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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            t_nom = new System.Windows.Forms.TextBox();
            t_prenom = new System.Windows.Forms.TextBox();
            t_ville = new System.Windows.Forms.TextBox();
            t_specialite = new System.Windows.Forms.TextBox();
            b_Ajouter = new System.Windows.Forms.Button();
            DataEleve = new System.Windows.Forms.DataGridView();
            b_Rechercher = new System.Windows.Forms.Button();
            b_Renitialiser = new System.Windows.Forms.Button();
            b_Supprimer = new System.Windows.Forms.Button();
            b_Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DataEleve).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(215, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(215, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 28);
            label2.TabIndex = 0;
            label2.Text = "Prénom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(215, 132);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 28);
            label3.TabIndex = 0;
            label3.Text = "Ville";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(215, 177);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(104, 28);
            label4.TabIndex = 0;
            label4.Text = "Spécialité";
            // 
            // t_nom
            // 
            t_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            t_nom.Location = new System.Drawing.Point(410, 36);
            t_nom.Name = "t_nom";
            t_nom.Size = new System.Drawing.Size(615, 34);
            t_nom.TabIndex = 1;
            // 
            // t_prenom
            // 
            t_prenom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            t_prenom.Location = new System.Drawing.Point(410, 81);
            t_prenom.Name = "t_prenom";
            t_prenom.Size = new System.Drawing.Size(615, 34);
            t_prenom.TabIndex = 2;
            // 
            // t_ville
            // 
            t_ville.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            t_ville.Location = new System.Drawing.Point(410, 126);
            t_ville.Name = "t_ville";
            t_ville.Size = new System.Drawing.Size(615, 34);
            t_ville.TabIndex = 3;
            // 
            // t_specialite
            // 
            t_specialite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            t_specialite.Location = new System.Drawing.Point(410, 171);
            t_specialite.Name = "t_specialite";
            t_specialite.Size = new System.Drawing.Size(615, 34);
            t_specialite.TabIndex = 4;
            // 
            // b_Ajouter
            // 
            b_Ajouter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            b_Ajouter.Location = new System.Drawing.Point(271, 232);
            b_Ajouter.Name = "b_Ajouter";
            b_Ajouter.Size = new System.Drawing.Size(135, 44);
            b_Ajouter.TabIndex = 5;
            b_Ajouter.Text = "Ajouter";
            b_Ajouter.UseVisualStyleBackColor = true;
            b_Ajouter.Click += b_Ajouter_Click;
            // 
            // DataEleve
            // 
            DataEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataEleve.Location = new System.Drawing.Point(311, 282);
            DataEleve.Name = "DataEleve";
            DataEleve.RowHeadersWidth = 102;
            DataEleve.Size = new System.Drawing.Size(714, 400);
            DataEleve.TabIndex = 6;
            DataEleve.CellClick += DataEleve_CellClick;
            // 
            // b_Rechercher
            // 
            b_Rechercher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            b_Rechercher.Location = new System.Drawing.Point(616, 232);
            b_Rechercher.Name = "b_Rechercher";
            b_Rechercher.Size = new System.Drawing.Size(142, 44);
            b_Rechercher.TabIndex = 7;
            b_Rechercher.Text = "Rechercher";
            b_Rechercher.UseVisualStyleBackColor = true;
            b_Rechercher.Click += b_Rechercher_Click;
            // 
            // b_Renitialiser
            // 
            b_Renitialiser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            b_Renitialiser.Location = new System.Drawing.Point(773, 232);
            b_Renitialiser.Name = "b_Renitialiser";
            b_Renitialiser.Size = new System.Drawing.Size(174, 44);
            b_Renitialiser.TabIndex = 8;
            b_Renitialiser.Text = "Réinitialiser";
            b_Renitialiser.UseVisualStyleBackColor = true;
            b_Renitialiser.Click += b_Renitialiser_Click;
            // 
            // b_Supprimer
            // 
            b_Supprimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            b_Supprimer.Location = new System.Drawing.Point(964, 232);
            b_Supprimer.Name = "b_Supprimer";
            b_Supprimer.Size = new System.Drawing.Size(174, 44);
            b_Supprimer.TabIndex = 9;
            b_Supprimer.Text = "Supprimer";
            b_Supprimer.UseVisualStyleBackColor = true;
            b_Supprimer.Click += b_Supprimer_Click;
            // 
            // b_Modifier
            // 
            b_Modifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            b_Modifier.Location = new System.Drawing.Point(425, 232);
            b_Modifier.Name = "b_Modifier";
            b_Modifier.Size = new System.Drawing.Size(174, 44);
            b_Modifier.TabIndex = 10;
            b_Modifier.Text = "Modifier";
            b_Modifier.UseVisualStyleBackColor = true;
            b_Modifier.Click += b_Modifier_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1308, 734);
            Controls.Add(b_Modifier);
            Controls.Add(b_Supprimer);
            Controls.Add(b_Renitialiser);
            Controls.Add(b_Rechercher);
            Controls.Add(DataEleve);
            Controls.Add(b_Ajouter);
            Controls.Add(t_specialite);
            Controls.Add(t_ville);
            Controls.Add(t_prenom);
            Controls.Add(t_nom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(1);
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataEleve).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
