namespace WinFormsApp1._2
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
            buttonModificar = new Button();
            buttonBorrar = new Button();
            buttonOrdenar = new Button();
            buttonLimpiar = new Button();
            dgMayores = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgMayores).BeginInit();
            SuspendLayout();
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(83, 61);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.Location = new Point(209, 61);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(75, 23);
            buttonBorrar.TabIndex = 2;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // buttonOrdenar
            // 
            buttonOrdenar.Location = new Point(341, 61);
            buttonOrdenar.Name = "buttonOrdenar";
            buttonOrdenar.Size = new Size(75, 23);
            buttonOrdenar.TabIndex = 3;
            buttonOrdenar.Text = "Ordenar";
            buttonOrdenar.UseVisualStyleBackColor = true;
            buttonOrdenar.Click += buttonOrdenar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(465, 61);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(75, 23);
            buttonLimpiar.TabIndex = 4;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // dgMayores
            // 
            dgMayores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMayores.Location = new Point(41, 99);
            dgMayores.Name = "dgMayores";
            dgMayores.RowTemplate.Height = 25;
            dgMayores.Size = new Size(573, 300);
            dgMayores.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgMayores);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonOrdenar);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgMayores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonModificar;
        private Button buttonBorrar;
        private Button buttonOrdenar;
        private Button buttonLimpiar;
        private DataGridView dgMayores;
    }
}
