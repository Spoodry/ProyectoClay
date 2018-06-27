namespace CPJava
{
    partial class PJava03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PJava03));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(97, 60);
            this.label1.Size = new System.Drawing.Size(264, 33);
            this.label1.Text = "Conceptos Basicos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 123);
            this.label2.Size = new System.Drawing.Size(309, 22);
            this.label2.Text = "JRE (Java Runtime Environment)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(99, 183);
            this.label3.Size = new System.Drawing.Size(749, 264);
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(35, 447);
            this.label4.Size = new System.Drawing.Size(855, 22);
            this.label4.Text = "http://www.oracle.com/technetwork/java/javase/downloads/jre8-downloads-2133155.ht" +
    "ml";
            // 
            // PJava03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 573);
            this.Name = "PJava03";
            this.Text = "PJava03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}