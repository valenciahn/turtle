﻿namespace turtle
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.invoicingButton = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.Configuration_button = new System.Windows.Forms.Button();
=======
            this.viewButton = new System.Windows.Forms.Button();
>>>>>>> ba6c4e870f533cf3cae563291c02216d9915a5af
            this.SuspendLayout();
            // 
            // invoicingButton
            // 
            this.invoicingButton.Location = new System.Drawing.Point(3, 3);
            this.invoicingButton.Name = "invoicingButton";
            this.invoicingButton.Size = new System.Drawing.Size(234, 27);
            this.invoicingButton.TabIndex = 0;
            this.invoicingButton.Text = "Generar Factura";
            this.invoicingButton.Click += new System.EventHandler(this.invoicingButton_Click);
            // 
<<<<<<< HEAD
            // Configuration_button
            // 
            this.Configuration_button.Location = new System.Drawing.Point(4, 37);
            this.Configuration_button.Name = "Configuration_button";
            this.Configuration_button.Size = new System.Drawing.Size(233, 27);
            this.Configuration_button.TabIndex = 1;
            this.Configuration_button.Text = "Configuración";
            this.Configuration_button.Click += new System.EventHandler(this.configButton_Click);
=======
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(3, 36);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(247, 27);
            this.viewButton.TabIndex = 1;
            this.viewButton.Text = "Ver facturas guardadas";
>>>>>>> ba6c4e870f533cf3cae563291c02216d9915a5af
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(237, 175);
            this.Controls.Add(this.Configuration_button);
=======
            this.ClientSize = new System.Drawing.Size(253, 175);
            this.Controls.Add(this.viewButton);
>>>>>>> ba6c4e870f533cf3cae563291c02216d9915a5af
            this.Controls.Add(this.invoicingButton);
            this.Menu = this.mainMenu1;
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button invoicingButton;
<<<<<<< HEAD
        private System.Windows.Forms.Button Configuration_button;
=======
        private System.Windows.Forms.Button viewButton;
>>>>>>> ba6c4e870f533cf3cae563291c02216d9915a5af
    }
}