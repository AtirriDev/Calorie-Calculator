
namespace Calcular_Calorias
{
    partial class FrmCalcularCalorias
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
            this.components = new System.ComponentModel.Container();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mrcMarco3 = new System.Windows.Forms.GroupBox();
            this.txtSuperavit = new System.Windows.Forms.TextBox();
            this.txtDeficit = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.txtMetBasal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mrcMarco1 = new System.Windows.Forms.GroupBox();
            this.rdbActividadAlta = new System.Windows.Forms.RadioButton();
            this.rdbActividadModerado = new System.Windows.Forms.RadioButton();
            this.rdbActividadSedentaria = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mrcMarco2 = new System.Windows.Forms.GroupBox();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.totAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.mrcMarco3.SuspendLayout();
            this.mrcMarco1.SuspendLayout();
            this.mrcMarco2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(61, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(187, 50);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.totAyuda.SetToolTip(this.btnCalcular, "Haga click para calcular");
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mrcMarco3
            // 
            this.mrcMarco3.Controls.Add(this.txtSuperavit);
            this.mrcMarco3.Controls.Add(this.txtDeficit);
            this.mrcMarco3.Controls.Add(this.txtMantenimiento);
            this.mrcMarco3.Controls.Add(this.txtMetBasal);
            this.mrcMarco3.Controls.Add(this.label9);
            this.mrcMarco3.Controls.Add(this.label8);
            this.mrcMarco3.Controls.Add(this.label7);
            this.mrcMarco3.Controls.Add(this.label6);
            this.mrcMarco3.Location = new System.Drawing.Point(16, 245);
            this.mrcMarco3.Name = "mrcMarco3";
            this.mrcMarco3.Size = new System.Drawing.Size(273, 145);
            this.mrcMarco3.TabIndex = 4;
            this.mrcMarco3.TabStop = false;
            this.mrcMarco3.Text = "Calorias";
            // 
            // txtSuperavit
            // 
            this.txtSuperavit.Location = new System.Drawing.Point(117, 118);
            this.txtSuperavit.Name = "txtSuperavit";
            this.txtSuperavit.Size = new System.Drawing.Size(144, 20);
            this.txtSuperavit.TabIndex = 7;
            this.totAyuda.SetToolTip(this.txtSuperavit, "Calorias necesarias para subir de peso corporal");
            // 
            // txtDeficit
            // 
            this.txtDeficit.Location = new System.Drawing.Point(117, 83);
            this.txtDeficit.Name = "txtDeficit";
            this.txtDeficit.Size = new System.Drawing.Size(144, 20);
            this.txtDeficit.TabIndex = 6;
            this.totAyuda.SetToolTip(this.txtDeficit, "Calorias necesarias para bajar el peso corporal");
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Location = new System.Drawing.Point(117, 51);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(144, 20);
            this.txtMantenimiento.TabIndex = 5;
            this.totAyuda.SetToolTip(this.txtMantenimiento, "Calorias necesarias para mantener el peso corporal");
            // 
            // txtMetBasal
            // 
            this.txtMetBasal.Location = new System.Drawing.Point(116, 22);
            this.txtMetBasal.Name = "txtMetBasal";
            this.txtMetBasal.Size = new System.Drawing.Size(144, 20);
            this.txtMetBasal.TabIndex = 4;
            this.totAyuda.SetToolTip(this.txtMetBasal, "Calorias necesarias para mantener las funciones vitales del organismo");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Deficit calorico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Superávit calorico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mantenimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Metabolismo Basal";
            // 
            // mrcMarco1
            // 
            this.mrcMarco1.Controls.Add(this.rdbActividadAlta);
            this.mrcMarco1.Controls.Add(this.rdbActividadModerado);
            this.mrcMarco1.Controls.Add(this.rdbActividadSedentaria);
            this.mrcMarco1.Controls.Add(this.label5);
            this.mrcMarco1.Controls.Add(this.mrcMarco2);
            this.mrcMarco1.Controls.Add(this.txtAltura);
            this.mrcMarco1.Controls.Add(this.txtEdad);
            this.mrcMarco1.Controls.Add(this.txtPeso);
            this.mrcMarco1.Controls.Add(this.label3);
            this.mrcMarco1.Controls.Add(this.label2);
            this.mrcMarco1.Controls.Add(this.label1);
            this.mrcMarco1.Location = new System.Drawing.Point(16, 9);
            this.mrcMarco1.Name = "mrcMarco1";
            this.mrcMarco1.Size = new System.Drawing.Size(274, 173);
            this.mrcMarco1.TabIndex = 3;
            this.mrcMarco1.TabStop = false;
            this.mrcMarco1.Text = "Datos";
            // 
            // rdbActividadAlta
            // 
            this.rdbActividadAlta.AutoSize = true;
            this.rdbActividadAlta.Location = new System.Drawing.Point(218, 140);
            this.rdbActividadAlta.Name = "rdbActividadAlta";
            this.rdbActividadAlta.Size = new System.Drawing.Size(43, 17);
            this.rdbActividadAlta.TabIndex = 11;
            this.rdbActividadAlta.Text = "Alto";
            this.totAyuda.SetToolTip(this.rdbActividadAlta, "Entrena mas de 4 veces semanales");
            this.rdbActividadAlta.UseVisualStyleBackColor = true;
            // 
            // rdbActividadModerado
            // 
            this.rdbActividadModerado.AutoSize = true;
            this.rdbActividadModerado.Location = new System.Drawing.Point(113, 140);
            this.rdbActividadModerado.Name = "rdbActividadModerado";
            this.rdbActividadModerado.Size = new System.Drawing.Size(73, 17);
            this.rdbActividadModerado.TabIndex = 10;
            this.rdbActividadModerado.Text = "Moderado";
            this.totAyuda.SetToolTip(this.rdbActividadModerado, "Entrena Ocasionalmente");
            this.rdbActividadModerado.UseVisualStyleBackColor = true;
            // 
            // rdbActividadSedentaria
            // 
            this.rdbActividadSedentaria.AutoSize = true;
            this.rdbActividadSedentaria.Checked = true;
            this.rdbActividadSedentaria.Location = new System.Drawing.Point(7, 140);
            this.rdbActividadSedentaria.Name = "rdbActividadSedentaria";
            this.rdbActividadSedentaria.Size = new System.Drawing.Size(76, 17);
            this.rdbActividadSedentaria.TabIndex = 8;
            this.rdbActividadSedentaria.TabStop = true;
            this.rdbActividadSedentaria.Text = "Sedentario";
            this.totAyuda.SetToolTip(this.rdbActividadSedentaria, "No realiza actividad fisica");
            this.rdbActividadSedentaria.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Indice de Actividad Fisica";
            // 
            // mrcMarco2
            // 
            this.mrcMarco2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mrcMarco2.Controls.Add(this.rdbHombre);
            this.mrcMarco2.Controls.Add(this.rdbMujer);
            this.mrcMarco2.Controls.Add(this.label4);
            this.mrcMarco2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mrcMarco2.Location = new System.Drawing.Point(104, 16);
            this.mrcMarco2.Name = "mrcMarco2";
            this.mrcMarco2.Size = new System.Drawing.Size(157, 80);
            this.mrcMarco2.TabIndex = 6;
            this.mrcMarco2.TabStop = false;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Checked = true;
            this.rdbHombre.Location = new System.Drawing.Point(58, 6);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(62, 17);
            this.rdbHombre.TabIndex = 2;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Location = new System.Drawing.Point(58, 29);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(51, 17);
            this.rdbMujer.TabIndex = 1;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sexo";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(55, 45);
            this.txtAltura.MaxLength = 3;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(30, 20);
            this.txtAltura.TabIndex = 5;
            this.totAyuda.SetToolTip(this.txtAltura, "Ingrese su altura en Cm");
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(55, 76);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(30, 20);
            this.txtEdad.TabIndex = 4;
            this.totAyuda.SetToolTip(this.txtEdad, "Ingrese su edad en Años");
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(55, 19);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(30, 20);
            this.txtPeso.TabIndex = 3;
            this.totAyuda.SetToolTip(this.txtPeso, "Ingrese su peso el Kg");
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(219, 396);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(70, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmCalcularCalorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 464);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mrcMarco3);
            this.Controls.Add(this.mrcMarco1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(313, 464);
            this.MinimumSize = new System.Drawing.Size(313, 464);
            this.Name = "FrmCalcularCalorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Calorias";
            this.Load += new System.EventHandler(this.FrmCalcularCalorias_Load);
            this.mrcMarco3.ResumeLayout(false);
            this.mrcMarco3.PerformLayout();
            this.mrcMarco1.ResumeLayout(false);
            this.mrcMarco1.PerformLayout();
            this.mrcMarco2.ResumeLayout(false);
            this.mrcMarco2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox mrcMarco3;
        private System.Windows.Forms.TextBox txtSuperavit;
        private System.Windows.Forms.TextBox txtDeficit;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.TextBox txtMetBasal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox mrcMarco1;
        private System.Windows.Forms.RadioButton rdbActividadAlta;
        private System.Windows.Forms.RadioButton rdbActividadModerado;
        private System.Windows.Forms.RadioButton rdbActividadSedentaria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox mrcMarco2;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolTip totAyuda;
    }
}

