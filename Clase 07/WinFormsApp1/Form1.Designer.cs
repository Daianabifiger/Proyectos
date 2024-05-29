namespace WinFormsApp1
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
            label1 = new Label();
            lstRazasDePerros = new ListBox();
            label2 = new Label();
            lstCiudadesPais = new ListBox();
            Buscar = new Button();
            Modificar = new Button();
            Eliminar = new Button();
            Limpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Hola CoderMundo";
            label1.Click += label1_Click;
            // 
            // lstRazasDePerros
            // 
            lstRazasDePerros.BackColor = Color.RosyBrown;
            lstRazasDePerros.FormattingEnabled = true;
            lstRazasDePerros.ItemHeight = 15;
            lstRazasDePerros.Location = new Point(22, 105);
            lstRazasDePerros.Name = "lstRazasDePerros";
            lstRazasDePerros.Size = new Size(120, 94);
            lstRazasDePerros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 78);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Razas de Perros";
            // 
            // lstCiudadesPais
            // 
            lstCiudadesPais.FormattingEnabled = true;
            lstCiudadesPais.ItemHeight = 15;
            lstCiudadesPais.Location = new Point(178, 105);
            lstCiudadesPais.Name = "lstCiudadesPais";
            lstCiudadesPais.Size = new Size(318, 94);
            lstCiudadesPais.TabIndex = 3;
            // 
            // Buscar
            // 
            Buscar.BackColor = SystemColors.GradientInactiveCaption;
            Buscar.Location = new Point(178, 78);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(75, 23);
            Buscar.TabIndex = 4;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            // 
            // Modificar
            // 
            Modificar.BackColor = SystemColors.GradientInactiveCaption;
            Modificar.Location = new Point(259, 78);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(75, 23);
            Modificar.TabIndex = 5;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += Modificar_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = SystemColors.GradientInactiveCaption;
            Eliminar.Location = new Point(340, 78);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(75, 23);
            Eliminar.TabIndex = 6;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Limpiar
            // 
            Limpiar.BackColor = SystemColors.GradientInactiveCaption;
            Limpiar.Location = new Point(421, 78);
            Limpiar.Name = "Limpiar";
            Limpiar.Size = new Size(75, 23);
            Limpiar.TabIndex = 7;
            Limpiar.Text = "Limpiar";
            Limpiar.UseVisualStyleBackColor = false;
            Limpiar.Click += Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(Limpiar);
            Controls.Add(Eliminar);
            Controls.Add(Modificar);
            Controls.Add(Buscar);
            Controls.Add(lstCiudadesPais);
            Controls.Add(label2);
            Controls.Add(lstRazasDePerros);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstRazasDePerros;
        private Label label2;
        private ListBox lstCiudadesPais;
        private Button Buscar;
        private Button Modificar;
        private Button Eliminar;
        private Button Limpiar;
    }
}
