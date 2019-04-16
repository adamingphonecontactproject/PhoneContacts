namespace AppGestContact
{
    partial class Home
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
            this.BT_Ajout = new System.Windows.Forms.Button();
            this.BT_Modifier = new System.Windows.Forms.Button();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Ajout
            // 
            this.BT_Ajout.Location = new System.Drawing.Point(590, 49);
            this.BT_Ajout.Name = "BT_Ajout";
            this.BT_Ajout.Size = new System.Drawing.Size(126, 93);
            this.BT_Ajout.TabIndex = 0;
            this.BT_Ajout.Text = "Ajouter";
            this.BT_Ajout.UseVisualStyleBackColor = true;
            this.BT_Ajout.Click += new System.EventHandler(this.BT_Ajout_Click);
            // 
            // BT_Modifier
            // 
            this.BT_Modifier.Location = new System.Drawing.Point(590, 176);
            this.BT_Modifier.Name = "BT_Modifier";
            this.BT_Modifier.Size = new System.Drawing.Size(126, 93);
            this.BT_Modifier.TabIndex = 1;
            this.BT_Modifier.Text = "Modifier";
            this.BT_Modifier.UseVisualStyleBackColor = true;
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.Location = new System.Drawing.Point(590, 299);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(126, 93);
            this.BT_Supprimer.TabIndex = 2;
            this.BT_Supprimer.Text = "Supprimer";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Supprimer);
            this.Controls.Add(this.BT_Modifier);
            this.Controls.Add(this.BT_Ajout);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Ajout;
        private System.Windows.Forms.Button BT_Modifier;
        private System.Windows.Forms.Button BT_Supprimer;
    }
}