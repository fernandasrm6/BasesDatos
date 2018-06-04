namespace ProyectoCongreso
{
    partial class Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            this.dsGeneral = new System.Windows.Forms.DataGridView();
            this.dateT = new System.Windows.Forms.DateTimePicker();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // dsGeneral
            // 
            this.dsGeneral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dsGeneral.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dsGeneral.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dsGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsGeneral.Location = new System.Drawing.Point(85, 109);
            this.dsGeneral.Name = "dsGeneral";
            this.dsGeneral.Size = new System.Drawing.Size(403, 165);
            this.dsGeneral.TabIndex = 0;
            this.dsGeneral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsGeneral_CellContentClick);
            // 
            // dateT
            // 
            this.dateT.CustomFormat = "yyyy-MM-dd";
            this.dateT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateT.Location = new System.Drawing.Point(290, 306);
            this.dateT.Name = "dateT";
            this.dateT.Size = new System.Drawing.Size(198, 20);
            this.dateT.TabIndex = 1;
            this.dateT.Value = new System.DateTime(2017, 3, 24, 0, 0, 0, 0);
            this.dateT.ValueChanged += new System.EventHandler(this.dateT_ValueChanged);
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(85, 305);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(165, 21);
            this.cBox.TabIndex = 2;
            this.cBox.SelectedIndexChanged += new System.EventHandler(this.cBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingresa el nombre de un autor y una fecha para buscar los artículos que ha ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "escrito desde ese periodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.dateT);
            this.Controls.Add(this.dsGeneral);
            this.Name = "Articulos";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dsGeneral;
        private System.Windows.Forms.DateTimePicker dateT;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}