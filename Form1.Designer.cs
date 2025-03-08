namespace DP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPersonajes = new DataGridView();
            picturePersonaje = new PictureBox();
            label1 = new Label();
            cmbPersonajes = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPersonajes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePersonaje).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonajes
            // 
            dgvPersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonajes.Location = new Point(21, 23);
            dgvPersonajes.Name = "dgvPersonajes";
            dgvPersonajes.RowHeadersWidth = 51;
            dgvPersonajes.Size = new Size(886, 242);
            dgvPersonajes.TabIndex = 0;
            // 
            // picturePersonaje
            // 
            picturePersonaje.Location = new Point(21, 282);
            picturePersonaje.Name = "picturePersonaje";
            picturePersonaje.Size = new Size(785, 243);
            picturePersonaje.TabIndex = 1;
            picturePersonaje.TabStop = false;
            picturePersonaje.Click += picturePersonaje_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(829, 282);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecciona Personaje:";
            // 
            // cmbPersonajes
            // 
            cmbPersonajes.FormattingEnabled = true;
            cmbPersonajes.Location = new Point(829, 305);
            cmbPersonajes.Name = "cmbPersonajes";
            cmbPersonajes.Size = new Size(151, 28);
            cmbPersonajes.TabIndex = 3;
            cmbPersonajes.SelectedIndexChanged += cmbPersonajes_SelectedIndexChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 537);
            Controls.Add(cmbPersonajes);
            Controls.Add(label1);
            Controls.Add(picturePersonaje);
            Controls.Add(dgvPersonajes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPersonajes).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePersonaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonajes;
        private PictureBox picturePersonaje;
        private Label label1;
        private ComboBox cmbPersonajes;
    }
}
