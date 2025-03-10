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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            txtApodo = new TextBox();
            txtRaza = new TextBox();
            txtDueño = new TextBox();
            txtPersonalidad = new TextBox();
            txtImagenURL = new TextBox();
            dtpPrimeraAparicion = new DateTimePicker();
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
            picturePersonaje.Location = new Point(574, 323);
            picturePersonaje.Name = "picturePersonaje";
            picturePersonaje.Size = new Size(192, 225);
            picturePersonaje.TabIndex = 1;
            picturePersonaje.TabStop = false;
            picturePersonaje.Click += picturePersonaje_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(586, 290);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecciona Personaje:";
            // 
            // cmbPersonajes
            // 
            cmbPersonajes.FormattingEnabled = true;
            cmbPersonajes.Location = new Point(756, 287);
            cmbPersonajes.Name = "cmbPersonajes";
            cmbPersonajes.Size = new Size(151, 28);
            cmbPersonajes.TabIndex = 3;
            cmbPersonajes.SelectedIndexChanged += cmbPersonajes_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 284);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 323);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 5;
            label3.Text = "Apodo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 365);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 6;
            label4.Text = "Raza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 406);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 7;
            label5.Text = "Dueño:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 449);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 8;
            label6.Text = "Personalidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 498);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 9;
            label7.Text = "PrimeraAparicion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 541);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 10;
            label8.Text = "Imagen URL:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(303, 536);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 284);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 12;
            // 
            // txtApodo
            // 
            txtApodo.Location = new Point(92, 323);
            txtApodo.Name = "txtApodo";
            txtApodo.Size = new Size(146, 27);
            txtApodo.TabIndex = 13;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(92, 362);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(146, 27);
            txtRaza.TabIndex = 14;
            // 
            // txtDueño
            // 
            txtDueño.Location = new Point(92, 403);
            txtDueño.Name = "txtDueño";
            txtDueño.Size = new Size(146, 27);
            txtDueño.TabIndex = 15;
            // 
            // txtPersonalidad
            // 
            txtPersonalidad.Location = new Point(131, 446);
            txtPersonalidad.Name = "txtPersonalidad";
            txtPersonalidad.Size = new Size(146, 27);
            txtPersonalidad.TabIndex = 16;
            // 
            // txtImagenURL
            // 
            txtImagenURL.Location = new Point(126, 534);
            txtImagenURL.Name = "txtImagenURL";
            txtImagenURL.Size = new Size(146, 27);
            txtImagenURL.TabIndex = 18;
            // 
            // dtpPrimeraAparicion
            // 
            dtpPrimeraAparicion.Location = new Point(161, 498);
            dtpPrimeraAparicion.Name = "dtpPrimeraAparicion";
            dtpPrimeraAparicion.Size = new Size(250, 27);
            dtpPrimeraAparicion.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 587);
            Controls.Add(dtpPrimeraAparicion);
            Controls.Add(txtImagenURL);
            Controls.Add(txtPersonalidad);
            Controls.Add(txtDueño);
            Controls.Add(txtRaza);
            Controls.Add(txtApodo);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAgregar;
        private TextBox txtNombre;
        private TextBox txtApodo;
        private TextBox txtRaza;
        private TextBox txtDueño;
        private TextBox txtPersonalidad;
        private TextBox textBox6;
        private TextBox txtImagenURL;
        private DateTimePicker dtpPrimeraAparicion;
    }
}
