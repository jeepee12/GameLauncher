namespace GameLauncher
{
    partial class FormGameTimeCalculator
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameTimeCalculator));
            this.Minuterie = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListIcone = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.btnChangerNom = new System.Windows.Forms.Button();
            this.btnChangerUrl = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnJouer = new System.Windows.Forms.Button();
            this.btnArret = new System.Windows.Forms.Button();
            this.lblNbJours = new System.Windows.Forms.Label();
            this.lblNbHeures = new System.Windows.Forms.Label();
            this.lblNbMinutes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgJeuSelectionne = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.NbJours = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgJeuSelectionne)).BeginInit();
            this.SuspendLayout();
            // 
            // Minuterie
            // 
            this.Minuterie.Interval = 60000;
            this.Minuterie.Tick += new System.EventHandler(this.Minuterie_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficherToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(824, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ficherToolStripMenuItem
            // 
            this.ficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.ficherToolStripMenuItem.Name = "ficherToolStripMenuItem";
            this.ficherToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ficherToolStripMenuItem.Text = "Ficher";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // imageListIcone
            // 
            this.imageListIcone.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcone.ImageStream")));
            this.imageListIcone.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcone.Images.SetKeyName(0, "GeneralsZH.ico");
            this.imageListIcone.Images.SetKeyName(1, "trine2.png");
            this.imageListIcone.Images.SetKeyName(2, "trine1.jpeg");
            this.imageListIcone.Images.SetKeyName(3, "isaac_icon.png");
            this.imageListIcone.Images.SetKeyName(4, "lol.ico");
            this.imageListIcone.Images.SetKeyName(5, "Magicka.png");
            this.imageListIcone.Images.SetKeyName(6, "minecraft_icon.png");
            this.imageListIcone.Images.SetKeyName(7, "Terrraria.png");
            this.imageListIcone.Images.SetKeyName(8, "Saints-Row-The-Third.png");
            this.imageListIcone.Images.SetKeyName(9, "heroes.1bRsx.png");
            this.imageListIcone.Images.SetKeyName(10, "ElderScrollsskyrim_icon.png");
            this.imageListIcone.Images.SetKeyName(11, "smite.png");
            this.imageListIcone.Images.SetKeyName(12, "SC2.png");
            this.imageListIcone.Images.SetKeyName(13, "logo.17d0r.png");
            this.imageListIcone.Images.SetKeyName(14, "bfme2.png");
            this.imageListIcone.Images.SetKeyName(15, "Unreal.ico");
            this.imageListIcone.Images.SetKeyName(16, "Virtualplaytable.png");
            this.imageListIcone.Images.SetKeyName(17, "worms_revolution.png");
            this.imageListIcone.Images.SetKeyName(18, "TheCrew.ico");
            this.imageListIcone.Images.SetKeyName(19, "ikonka.ico");
            this.imageListIcone.Images.SetKeyName(20, "Crysis2.png");
            this.imageListIcone.Images.SetKeyName(21, "DeadSpace3.png");
            this.imageListIcone.Images.SetKeyName(22, "strife.png");
            this.imageListIcone.Images.SetKeyName(23, "MirrorsEdge.png");
            this.imageListIcone.Images.SetKeyName(24, "saintsRow4.jpg");
            this.imageListIcone.Images.SetKeyName(25, "HearthStone.jpeg");
            this.imageListIcone.Images.SetKeyName(26, "WD.ico");
            this.imageListIcone.Images.SetKeyName(27, "coh_icon.png");
            this.imageListIcone.Images.SetKeyName(28, "antichamber.png");
            this.imageListIcone.Images.SetKeyName(29, "Portal2.png");
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.btnChangerNom);
            this.groupBoxStats.Controls.Add(this.btnChangerUrl);
            this.groupBoxStats.Controls.Add(this.txtUrl);
            this.groupBoxStats.Controls.Add(this.label4);
            this.groupBoxStats.Controls.Add(this.txtNom);
            this.groupBoxStats.Controls.Add(this.btnJouer);
            this.groupBoxStats.Controls.Add(this.btnArret);
            this.groupBoxStats.Controls.Add(this.lblNbJours);
            this.groupBoxStats.Controls.Add(this.lblNbHeures);
            this.groupBoxStats.Controls.Add(this.lblNbMinutes);
            this.groupBoxStats.Controls.Add(this.label3);
            this.groupBoxStats.Controls.Add(this.imgJeuSelectionne);
            this.groupBoxStats.Controls.Add(this.label2);
            this.groupBoxStats.Controls.Add(this.label1);
            this.groupBoxStats.Controls.Add(this.btnSauvegarder);
            this.groupBoxStats.Controls.Add(this.btnRefresh);
            this.groupBoxStats.Controls.Add(this.btnQuitter);
            this.groupBoxStats.Controls.Add(this.NbJours);
            this.groupBoxStats.Location = new System.Drawing.Point(12, 273);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(800, 277);
            this.groupBoxStats.TabIndex = 11;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Statistique";
            // 
            // btnChangerNom
            // 
            this.btnChangerNom.Location = new System.Drawing.Point(569, 11);
            this.btnChangerNom.Name = "btnChangerNom";
            this.btnChangerNom.Size = new System.Drawing.Size(75, 23);
            this.btnChangerNom.TabIndex = 18;
            this.btnChangerNom.Text = "Changer";
            this.btnChangerNom.UseVisualStyleBackColor = true;
            this.btnChangerNom.Click += new System.EventHandler(this.btnChangerNom_Click);
            // 
            // btnChangerUrl
            // 
            this.btnChangerUrl.Location = new System.Drawing.Point(508, 248);
            this.btnChangerUrl.Name = "btnChangerUrl";
            this.btnChangerUrl.Size = new System.Drawing.Size(75, 23);
            this.btnChangerUrl.TabIndex = 17;
            this.btnChangerUrl.Text = "Changer";
            this.btnChangerUrl.UseVisualStyleBackColor = true;
            this.btnChangerUrl.Click += new System.EventHandler(this.btnChangerUrl_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(38, 251);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(464, 20);
            this.txtUrl.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Url :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(99, 13);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(464, 20);
            this.txtNom.TabIndex = 14;
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(207, 39);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(250, 203);
            this.btnJouer.TabIndex = 13;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // btnArret
            // 
            this.btnArret.Enabled = false;
            this.btnArret.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArret.Location = new System.Drawing.Point(463, 39);
            this.btnArret.Name = "btnArret";
            this.btnArret.Size = new System.Drawing.Size(250, 203);
            this.btnArret.TabIndex = 12;
            this.btnArret.Text = "Arrêt";
            this.btnArret.UseVisualStyleBackColor = true;
            this.btnArret.Click += new System.EventHandler(this.btnArret_Click);
            // 
            // lblNbJours
            // 
            this.lblNbJours.AutoSize = true;
            this.lblNbJours.Location = new System.Drawing.Point(96, 115);
            this.lblNbJours.Name = "lblNbJours";
            this.lblNbJours.Size = new System.Drawing.Size(13, 13);
            this.lblNbJours.TabIndex = 10;
            this.lblNbJours.Text = "0";
            // 
            // lblNbHeures
            // 
            this.lblNbHeures.AutoSize = true;
            this.lblNbHeures.Location = new System.Drawing.Point(96, 128);
            this.lblNbHeures.Name = "lblNbHeures";
            this.lblNbHeures.Size = new System.Drawing.Size(13, 13);
            this.lblNbHeures.TabIndex = 9;
            this.lblNbHeures.Text = "0";
            // 
            // lblNbMinutes
            // 
            this.lblNbMinutes.AutoSize = true;
            this.lblNbMinutes.Location = new System.Drawing.Point(96, 141);
            this.lblNbMinutes.Name = "lblNbMinutes";
            this.lblNbMinutes.Size = new System.Drawing.Size(13, 13);
            this.lblNbMinutes.TabIndex = 8;
            this.lblNbMinutes.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nb de minute(s):";
            // 
            // imgJeuSelectionne
            // 
            this.imgJeuSelectionne.Location = new System.Drawing.Point(9, 32);
            this.imgJeuSelectionne.Name = "imgJeuSelectionne";
            this.imgJeuSelectionne.Size = new System.Drawing.Size(80, 80);
            this.imgJeuSelectionne.TabIndex = 6;
            this.imgJeuSelectionne.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nb d\'heure(s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom :";
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.Location = new System.Drawing.Point(719, 219);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(75, 23);
            this.btnSauvegarder.TabIndex = 3;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = true;
            this.btnSauvegarder.Click += new System.EventHandler(this.btnSauvegarder_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(719, 190);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(719, 248);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // NbJours
            // 
            this.NbJours.AutoSize = true;
            this.NbJours.Location = new System.Drawing.Point(6, 115);
            this.NbJours.Name = "NbJours";
            this.NbJours.Size = new System.Drawing.Size(70, 13);
            this.NbJours.TabIndex = 0;
            this.NbJours.Text = "Nb de jour(s):";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 10;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 240);
            this.tableLayoutPanel.TabIndex = 12;
            // 
            // FormGameTimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 562);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormGameTimeCalculator";
            this.Text = "Game Time Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGameTimeCalculator_FormClosing);
            this.Load += new System.EventHandler(this.FormGameTimeCalculator_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgJeuSelectionne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Minuterie;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListIcone;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label NbJours;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSauvegarder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Button btnArret;
        private System.Windows.Forms.Label lblNbJours;
        private System.Windows.Forms.Label lblNbHeures;
        private System.Windows.Forms.Label lblNbMinutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgJeuSelectionne;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangerNom;
        private System.Windows.Forms.Button btnChangerUrl;
    }
}

