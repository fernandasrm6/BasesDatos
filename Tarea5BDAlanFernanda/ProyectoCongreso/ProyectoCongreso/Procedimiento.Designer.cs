namespace ProyectoCongreso {
    partial class Procedimiento {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.procfun = new System.Windows.Forms.Button();
            this.dsGeneral = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(369, 260);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // procfun
            // 
            this.procfun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procfun.Location = new System.Drawing.Point(223, 317);
            this.procfun.Name = "procfun";
            this.procfun.Size = new System.Drawing.Size(158, 51);
            this.procfun.TabIndex = 2;
            this.procfun.Text = "Ejecutar Procedimiento ";
            this.procfun.UseVisualStyleBackColor = true;
            this.procfun.Click += new System.EventHandler(this.procfun_Click);
            // 
            // dsGeneral
            // 
            this.dsGeneral.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dsGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsGeneral.Location = new System.Drawing.Point(106, 94);
            this.dsGeneral.Name = "dsGeneral";
            this.dsGeneral.Size = new System.Drawing.Size(408, 148);
            this.dsGeneral.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecciona dos instituciones para saber cuál patrocinó más congresos";
            // 
            // Procedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCongreso.Properties.Resources._30_Free_Beautiful_Watercolor_Wallpapers_That_Should_Be_on_Your_Desktop_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(657, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dsGeneral);
            this.Controls.Add(this.procfun);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Procedimiento";
            this.Text = "Procedimiento";
            this.Load += new System.EventHandler(this.Procedimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button procfun;
        private System.Windows.Forms.DataGridView dsGeneral;
        private System.Windows.Forms.Label label2;
    }
}