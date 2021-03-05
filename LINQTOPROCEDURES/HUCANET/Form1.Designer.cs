
namespace HUCANET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textInscripcion = new System.Windows.Forms.TextBox();
            this.textNomApe = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textNumSS = new System.Windows.Forms.TextBox();
            this.radioSexoM = new System.Windows.Forms.RadioButton();
            this.radioSexoF = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de la SS";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(437, 55);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(328, 297);
            this.dataGrid.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Altas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Log";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Modif";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Bajas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(466, 395);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textInscripcion
            // 
            this.textInscripcion.Location = new System.Drawing.Point(221, 55);
            this.textInscripcion.Name = "textInscripcion";
            this.textInscripcion.Size = new System.Drawing.Size(100, 22);
            this.textInscripcion.TabIndex = 13;
            // 
            // textNomApe
            // 
            this.textNomApe.Location = new System.Drawing.Point(221, 112);
            this.textNomApe.Name = "textNomApe";
            this.textNomApe.Size = new System.Drawing.Size(100, 22);
            this.textNomApe.TabIndex = 14;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(221, 221);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(100, 22);
            this.textFecha.TabIndex = 15;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(221, 281);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 22);
            this.textDireccion.TabIndex = 16;
            // 
            // textNumSS
            // 
            this.textNumSS.Location = new System.Drawing.Point(221, 332);
            this.textNumSS.Name = "textNumSS";
            this.textNumSS.Size = new System.Drawing.Size(100, 22);
            this.textNumSS.TabIndex = 17;
            // 
            // radioSexoM
            // 
            this.radioSexoM.AutoSize = true;
            this.radioSexoM.Location = new System.Drawing.Point(221, 171);
            this.radioSexoM.Name = "radioSexoM";
            this.radioSexoM.Size = new System.Drawing.Size(59, 21);
            this.radioSexoM.TabIndex = 18;
            this.radioSexoM.TabStop = true;
            this.radioSexoM.Text = "Male";
            this.radioSexoM.UseVisualStyleBackColor = true;
            this.radioSexoM.CheckedChanged += new System.EventHandler(this.radioSexoM_CheckedChanged);
            // 
            // radioSexoF
            // 
            this.radioSexoF.AutoSize = true;
            this.radioSexoF.Location = new System.Drawing.Point(301, 171);
            this.radioSexoF.Name = "radioSexoF";
            this.radioSexoF.Size = new System.Drawing.Size(75, 21);
            this.radioSexoF.TabIndex = 19;
            this.radioSexoF.TabStop = true;
            this.radioSexoF.Text = "Female";
            this.radioSexoF.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Proyecto de Gestión de ENFERMOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioSexoF);
            this.Controls.Add(this.radioSexoM);
            this.Controls.Add(this.textNumSS);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textNomApe);
            this.Controls.Add(this.textInscripcion);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textInscripcion;
        private System.Windows.Forms.TextBox textNomApe;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.TextBox textNumSS;
        private System.Windows.Forms.RadioButton radioSexoM;
        private System.Windows.Forms.RadioButton radioSexoF;
        private System.Windows.Forms.Label label8;
    }
}

