namespace SistemaGestionNomina
{
    partial class frmCalculadoraEmpleados
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
            txtPantalla = new TextBox();
            label1 = new Label();
            btnEmpleadoHora = new Button();
            btnBorrar = new Button();
            btnDeshacer = new Button();
            btnEmpleadoAsalariado = new Button();
            btnEmpleadoComision = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btnSuma = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btnMultiplicacion = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDivision = new Button();
            button1 = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(2, 62);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(460, 71);
            txtPantalla.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(2, 2);
            label1.Name = "label1";
            label1.Size = new Size(460, 57);
            label1.TabIndex = 1;
            label1.Text = "Calculadora de pagos";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnEmpleadoHora
            // 
            btnEmpleadoHora.BackColor = SystemColors.Highlight;
            btnEmpleadoHora.ForeColor = SystemColors.ControlLightLight;
            btnEmpleadoHora.Location = new Point(25, 155);
            btnEmpleadoHora.Name = "btnEmpleadoHora";
            btnEmpleadoHora.Size = new Size(78, 71);
            btnEmpleadoHora.TabIndex = 2;
            btnEmpleadoHora.Text = "Empleados por horas";
            btnEmpleadoHora.UseVisualStyleBackColor = false;
            btnEmpleadoHora.Click += btnEmpleadoHora_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = SystemColors.ActiveCaption;
            btnBorrar.Font = new Font("Segoe UI", 12F);
            btnBorrar.Location = new Point(361, 164);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(78, 62);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "🗑️";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnDeshacer
            // 
            btnDeshacer.BackColor = SystemColors.ActiveCaption;
            btnDeshacer.Font = new Font("Segoe UI", 12F);
            btnDeshacer.Location = new Point(277, 164);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(78, 62);
            btnDeshacer.TabIndex = 4;
            btnDeshacer.Text = "↩";
            btnDeshacer.UseVisualStyleBackColor = false;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnEmpleadoAsalariado
            // 
            btnEmpleadoAsalariado.AccessibleDescription = "";
            btnEmpleadoAsalariado.BackColor = SystemColors.Highlight;
            btnEmpleadoAsalariado.ForeColor = SystemColors.ControlLightLight;
            btnEmpleadoAsalariado.Location = new Point(193, 155);
            btnEmpleadoAsalariado.Name = "btnEmpleadoAsalariado";
            btnEmpleadoAsalariado.Size = new Size(78, 71);
            btnEmpleadoAsalariado.TabIndex = 5;
            btnEmpleadoAsalariado.Text = "Empleado Asalariado por Comisión";
            btnEmpleadoAsalariado.TextAlign = ContentAlignment.TopLeft;
            btnEmpleadoAsalariado.UseVisualStyleBackColor = false;
            // 
            // btnEmpleadoComision
            // 
            btnEmpleadoComision.BackColor = SystemColors.Highlight;
            btnEmpleadoComision.ForeColor = SystemColors.ControlLightLight;
            btnEmpleadoComision.Location = new Point(109, 155);
            btnEmpleadoComision.Name = "btnEmpleadoComision";
            btnEmpleadoComision.Size = new Size(78, 71);
            btnEmpleadoComision.TabIndex = 6;
            btnEmpleadoComision.Text = " Empleado por Comisión";
            btnEmpleadoComision.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.Font = new Font("Segoe UI", 12F);
            btn1.Location = new Point(109, 232);
            btn1.Name = "btn1";
            btn1.Size = new Size(78, 62);
            btn1.TabIndex = 11;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaption;
            btn2.Font = new Font("Segoe UI", 12F);
            btn2.Location = new Point(193, 232);
            btn2.Name = "btn2";
            btn2.Size = new Size(78, 62);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaption;
            btn3.Font = new Font("Segoe UI", 12F);
            btn3.Location = new Point(277, 232);
            btn3.Name = "btn3";
            btn3.Size = new Size(78, 62);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaption;
            btn4.Font = new Font("Segoe UI", 12F);
            btn4.Location = new Point(361, 232);
            btn4.Name = "btn4";
            btn4.Size = new Size(78, 62);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = SystemColors.ActiveCaption;
            btnSuma.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(25, 232);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(78, 62);
            btnSuma.TabIndex = 7;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ActiveCaption;
            btn5.Font = new Font("Segoe UI", 12F);
            btn5.Location = new Point(101, 300);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 62);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ActiveCaption;
            btn6.Font = new Font("Segoe UI", 12F);
            btn6.Location = new Point(193, 300);
            btn6.Name = "btn6";
            btn6.Size = new Size(78, 62);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaption;
            btn7.Font = new Font("Segoe UI", 12F);
            btn7.Location = new Point(277, 300);
            btn7.Name = "btn7";
            btn7.Size = new Size(78, 62);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaption;
            btn8.Font = new Font("Segoe UI", 12F);
            btn8.Location = new Point(361, 300);
            btn8.Name = "btn8";
            btn8.Size = new Size(78, 62);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.BackColor = SystemColors.ActiveCaption;
            btnMultiplicacion.Font = new Font("Segoe UI", 20.25F);
            btnMultiplicacion.Location = new Point(25, 300);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(78, 62);
            btnMultiplicacion.TabIndex = 12;
            btnMultiplicacion.Text = "X";
            btnMultiplicacion.UseVisualStyleBackColor = false;
            btnMultiplicacion.Click += btnMultiplicacion_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaption;
            btn9.Font = new Font("Segoe UI", 12F);
            btn9.Location = new Point(109, 368);
            btn9.Name = "btn9";
            btn9.Size = new Size(78, 62);
            btn9.TabIndex = 21;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaption;
            btn0.Font = new Font("Segoe UI", 12F);
            btn0.Location = new Point(193, 368);
            btn0.Name = "btn0";
            btn0.Size = new Size(78, 62);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = SystemColors.ActiveCaption;
            btnDivision.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivision.Location = new Point(25, 368);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(78, 62);
            btnDivision.TabIndex = 17;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += btnDivision_Click;
            // 
            // button1
            // 
            button1.AccessibleDescription = "btnPunto";
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(277, 373);
            button1.Name = "button1";
            button1.Size = new Size(78, 57);
            button1.TabIndex = 23;
            button1.Text = "●";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Font = new Font("Segoe UI", 12F);
            btnConfirmar.ForeColor = Color.Green;
            btnConfirmar.Location = new Point(361, 373);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(78, 59);
            btnConfirmar.TabIndex = 24;
            btnConfirmar.Text = "✔";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // frmCalculadoraEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 481);
            Controls.Add(btnConfirmar);
            Controls.Add(button1);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btnDivision);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btnMultiplicacion);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btnSuma);
            Controls.Add(btnEmpleadoComision);
            Controls.Add(btnEmpleadoAsalariado);
            Controls.Add(btnDeshacer);
            Controls.Add(btnBorrar);
            Controls.Add(btnEmpleadoHora);
            Controls.Add(label1);
            Controls.Add(txtPantalla);
            Name = "frmCalculadoraEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCalculadoraEmpleados";
            Load += frmCalculadoraEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Label label1;
        private Button btnEmpleadoHora;
        private Button btnBorrar;
        private Button btnDeshacer;
        private Button btnEmpleadoAsalariado;
        private Button btnEmpleadoComision;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btnSuma;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btnMultiplicacion;
        private Button btn9;
        private Button btn0;
        private Button btnDivision;
        private Button button1;
        private Button btnConfirmar;
    }
}