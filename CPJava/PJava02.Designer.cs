﻿namespace CPJava
{
    partial class PJava02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PJava02));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.Text = "Historia";
            // 
            // label2
            // 
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Size = new System.Drawing.Size(881, 242);
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(118, 447);
            this.label4.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.SeaGreen;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(303, 493);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(161, 41);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsiguiente.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnsiguiente.FlatAppearance.BorderSize = 0;
            this.btnsiguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiguiente.Location = new System.Drawing.Point(600, 493);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(161, 41);
            this.btnsiguiente.TabIndex = 14;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = false;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // PJava02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 609);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btncancelar);
            this.Name = "PJava02";
            this.Text = "PJava02";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btncancelar, 0);
            this.Controls.SetChildIndex(this.btnsiguiente, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsiguiente;
    }
}