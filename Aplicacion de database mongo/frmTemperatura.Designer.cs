namespace Aplicacion_de_database_mongo
{
    partial class frmTemperatura
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
            label2 = new Label();
            txtNQR = new TextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            dateRegistro = new DateTimePicker();
            label4 = new Label();
            txtTemperatura = new TextBox();
            btnObtener = new Button();
            dgvDatosTemperatura = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDatosTemperatura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 15);
            label1.TabIndex = 0;
            label1.Text = "Formulario de temperatura registrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del que registro:";
            // 
            // txtNQR
            // 
            txtNQR.Location = new Point(157, 42);
            txtNQR.Name = "txtNQR";
            txtNQR.Size = new Size(343, 23);
            txtNQR.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(451, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(130, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Enlace al codigo fuente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha del registro:";
            // 
            // dateRegistro
            // 
            dateRegistro.Location = new Point(159, 71);
            dateRegistro.Name = "dateRegistro";
            dateRegistro.Size = new Size(341, 23);
            dateRegistro.TabIndex = 5;
            dateRegistro.Value = new DateTime(2023, 9, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 103);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 6;
            label4.Text = "Temperatura actual:";
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(158, 100);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(342, 23);
            txtTemperatura.TabIndex = 7;
            // 
            // btnObtener
            // 
            btnObtener.Location = new Point(506, 100);
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(75, 23);
            btnObtener.TabIndex = 8;
            btnObtener.Text = "Obtener";
            btnObtener.UseVisualStyleBackColor = true;
            // 
            // dgvDatosTemperatura
            // 
            dgvDatosTemperatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosTemperatura.Location = new Point(12, 146);
            dgvDatosTemperatura.Name = "dgvDatosTemperatura";
            dgvDatosTemperatura.RowTemplate.Height = 25;
            dgvDatosTemperatura.Size = new Size(569, 199);
            dgvDatosTemperatura.TabIndex = 9;
            // 
            // frmTemperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 369);
            Controls.Add(dgvDatosTemperatura);
            Controls.Add(btnObtener);
            Controls.Add(txtTemperatura);
            Controls.Add(label4);
            Controls.Add(dateRegistro);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(txtNQR);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTemperatura";
            Text = "Base de datos";
            ((System.ComponentModel.ISupportInitialize)dgvDatosTemperatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNQR;
        private LinkLabel linkLabel1;
        private Label label3;
        private DateTimePicker dateRegistro;
        private Label label4;
        private TextBox txtTemperatura;
        private Button btnObtener;
        private DataGridView dgvDatosTemperatura;
    }
}