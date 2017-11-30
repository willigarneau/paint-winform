namespace TP6_Programmation_III
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DdbMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSurface = new System.Windows.Forms.ToolStripMenuItem();
            this.btnErase = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNormalise = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEncadrer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgrandirX = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgrandirY = new System.Windows.Forms.ToolStripMenuItem();
            this.plDessin = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DdbMenu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(634, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DdbMenu
            // 
            this.DdbMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnSaveText,
            this.btnProperties,
            this.btnRefresh,
            this.btnSurface,
            this.btnErase,
            this.btnNormalise,
            this.btnEncadrer,
            this.btnAgrandirX,
            this.btnAgrandirY});
            this.DdbMenu.Image = ((System.Drawing.Image)(resources.GetObject("DdbMenu.Image")));
            this.DdbMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DdbMenu.Name = "DdbMenu";
            this.DdbMenu.Size = new System.Drawing.Size(67, 22);
            this.DdbMenu.Text = "Menu";
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(194, 22);
            this.btnNew.Text = "Nouveau";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(194, 22);
            this.btnOpen.Text = "Ouvrir";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 22);
            this.btnSave.Text = "Enregistrer";
            // 
            // btnSaveText
            // 
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(194, 22);
            this.btnSaveText.Text = "Enregistrer fichier texte";
            // 
            // btnProperties
            // 
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(194, 22);
            this.btnProperties.Text = "Propriétés";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 22);
            this.btnRefresh.Text = "Rafraîchir";
            // 
            // btnSurface
            // 
            this.btnSurface.Name = "btnSurface";
            this.btnSurface.Size = new System.Drawing.Size(194, 22);
            this.btnSurface.Text = "Surface";
            // 
            // btnErase
            // 
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(194, 22);
            this.btnErase.Text = "Effacer";
            // 
            // btnNormalise
            // 
            this.btnNormalise.Name = "btnNormalise";
            this.btnNormalise.Size = new System.Drawing.Size(194, 22);
            this.btnNormalise.Text = "Normaliser";
            // 
            // btnEncadrer
            // 
            this.btnEncadrer.Name = "btnEncadrer";
            this.btnEncadrer.Size = new System.Drawing.Size(194, 22);
            this.btnEncadrer.Text = "Encadrer";
            // 
            // btnAgrandirX
            // 
            this.btnAgrandirX.Name = "btnAgrandirX";
            this.btnAgrandirX.Size = new System.Drawing.Size(194, 22);
            this.btnAgrandirX.Text = "Agrandir X";
            // 
            // btnAgrandirY
            // 
            this.btnAgrandirY.Name = "btnAgrandirY";
            this.btnAgrandirY.Size = new System.Drawing.Size(194, 22);
            this.btnAgrandirY.Text = "Agrandir Y";
            // 
            // plDessin
            // 
            this.plDessin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plDessin.Location = new System.Drawing.Point(13, 29);
            this.plDessin.Name = "plDessin";
            this.plDessin.Size = new System.Drawing.Size(609, 402);
            this.plDessin.TabIndex = 1;
            this.plDessin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plDessin_MouseDown);
            this.plDessin.MouseLeave += new System.EventHandler(this.plDessin_MouseLeave);
            this.plDessin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plDessin_MouseMove);
            this.plDessin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plDessin_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 443);
            this.Controls.Add(this.plDessin);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "TP6 par William Garneau";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DdbMenu;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.ToolStripMenuItem btnSaveText;
        private System.Windows.Forms.ToolStripMenuItem btnProperties;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem btnSurface;
        private System.Windows.Forms.ToolStripMenuItem btnErase;
        private System.Windows.Forms.ToolStripMenuItem btnNormalise;
        private System.Windows.Forms.ToolStripMenuItem btnEncadrer;
        private System.Windows.Forms.ToolStripMenuItem btnAgrandirX;
        private System.Windows.Forms.ToolStripMenuItem btnAgrandirY;
        private System.Windows.Forms.Panel plDessin;
    }
}

