namespace SemaforoSimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SimularButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TiempoEsperaTb = new System.Windows.Forms.TextBox();
            this.R1R2Tb = new System.Windows.Forms.TextBox();
            this.R1R3Tb = new System.Windows.Forms.TextBox();
            this.R2R1Tb = new System.Windows.Forms.TextBox();
            this.R2R3Tb = new System.Windows.Forms.TextBox();
            this.R3R1Tb = new System.Windows.Forms.TextBox();
            this.R3R2Tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simulación Digital - Semáforo UCNE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Angel Rodríguez";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Newlin Duarte";
            // 
            // SimularButton
            // 
            this.SimularButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimularButton.Image = global::SemaforoSimulation.Properties.Resources.Start__1_;
            this.SimularButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SimularButton.Location = new System.Drawing.Point(188, 521);
            this.SimularButton.Name = "SimularButton";
            this.SimularButton.Size = new System.Drawing.Size(142, 55);
            this.SimularButton.TabIndex = 5;
            this.SimularButton.Text = "Simular";
            this.SimularButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SimularButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tiempo de Espera total de vehiculos (en minutos):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad de vehículos de Ruta 1 a Ruta 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cantidad de vehículos de Ruta 1 a Ruta 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Cantidad de vehículos de Ruta 2 a Ruta 1:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad de vehículos de Ruta 2 a Ruta 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad de vehículos de Ruta 3 a Ruta 1:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(78, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cantidad de vehículos de Ruta 3 a Ruta 2:";
            // 
            // TiempoEsperaTb
            // 
            this.TiempoEsperaTb.Location = new System.Drawing.Point(375, 188);
            this.TiempoEsperaTb.Name = "TiempoEsperaTb";
            this.TiempoEsperaTb.ReadOnly = true;
            this.TiempoEsperaTb.Size = new System.Drawing.Size(100, 20);
            this.TiempoEsperaTb.TabIndex = 14;
            // 
            // R1R2Tb
            // 
            this.R1R2Tb.Location = new System.Drawing.Point(375, 219);
            this.R1R2Tb.Name = "R1R2Tb";
            this.R1R2Tb.ReadOnly = true;
            this.R1R2Tb.Size = new System.Drawing.Size(100, 20);
            this.R1R2Tb.TabIndex = 15;
            // 
            // R1R3Tb
            // 
            this.R1R3Tb.Location = new System.Drawing.Point(375, 257);
            this.R1R3Tb.Name = "R1R3Tb";
            this.R1R3Tb.ReadOnly = true;
            this.R1R3Tb.Size = new System.Drawing.Size(100, 20);
            this.R1R3Tb.TabIndex = 16;
            // 
            // R2R1Tb
            // 
            this.R2R1Tb.Location = new System.Drawing.Point(375, 293);
            this.R2R1Tb.Name = "R2R1Tb";
            this.R2R1Tb.ReadOnly = true;
            this.R2R1Tb.Size = new System.Drawing.Size(100, 20);
            this.R2R1Tb.TabIndex = 17;
            // 
            // R2R3Tb
            // 
            this.R2R3Tb.Location = new System.Drawing.Point(375, 329);
            this.R2R3Tb.Name = "R2R3Tb";
            this.R2R3Tb.ReadOnly = true;
            this.R2R3Tb.Size = new System.Drawing.Size(100, 20);
            this.R2R3Tb.TabIndex = 18;
            // 
            // R3R1Tb
            // 
            this.R3R1Tb.Location = new System.Drawing.Point(375, 363);
            this.R3R1Tb.Name = "R3R1Tb";
            this.R3R1Tb.ReadOnly = true;
            this.R3R1Tb.Size = new System.Drawing.Size(100, 20);
            this.R3R1Tb.TabIndex = 19;
            // 
            // R3R2Tb
            // 
            this.R3R2Tb.Location = new System.Drawing.Point(375, 399);
            this.R3R2Tb.Name = "R3R2Tb";
            this.R3R2Tb.ReadOnly = true;
            this.R3R2Tb.Size = new System.Drawing.Size(100, 20);
            this.R3R2Tb.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 588);
            this.Controls.Add(this.R3R2Tb);
            this.Controls.Add(this.R3R1Tb);
            this.Controls.Add(this.R2R3Tb);
            this.Controls.Add(this.R2R1Tb);
            this.Controls.Add(this.R1R3Tb);
            this.Controls.Add(this.R1R2Tb);
            this.Controls.Add(this.TiempoEsperaTb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SimularButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Semaforo UCNE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SimularButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TiempoEsperaTb;
        private System.Windows.Forms.TextBox R1R2Tb;
        private System.Windows.Forms.TextBox R1R3Tb;
        private System.Windows.Forms.TextBox R2R1Tb;
        private System.Windows.Forms.TextBox R2R3Tb;
        private System.Windows.Forms.TextBox R3R1Tb;
        private System.Windows.Forms.TextBox R3R2Tb;
    }
}

