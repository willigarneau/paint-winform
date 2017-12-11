namespace TP6_Programmation_III.Forms
{
    partial class Properties
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtNbrePoints = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(96, 23);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(96, 66);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Prix :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(96, 106);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(12, 146);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(129, 15);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "Nombre de points :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(147, 65);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(147, 105);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 6;
            // 
            // txtNbrePoints
            // 
            this.txtNbrePoints.Location = new System.Drawing.Point(147, 145);
            this.txtNbrePoints.Name = "txtNbrePoints";
            this.txtNbrePoints.Size = new System.Drawing.Size(100, 20);
            this.txtNbrePoints.TabIndex = 7;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(135, 186);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 8;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(216, 186);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 222);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtNbrePoints);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNom);
            this.Name = "Properties";
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtNbrePoints;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnQuitter;
    }
}