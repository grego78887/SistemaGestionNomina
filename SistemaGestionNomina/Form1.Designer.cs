namespace SistemaGestionNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            Empleados = new TabPage();
            label3 = new Label();
            btnSeleccionarEmpleados = new Button();
            btnLimpiarEmpleados = new Button();
            btnBuscarEmpleados = new Button();
            DTG = new DataGridView();
            Pago = new TabPage();
            button3 = new Button();
            comboBox5 = new ComboBox();
            lblEmpleado6 = new Label();
            comboBox6 = new ComboBox();
            lblEmpleado5 = new Label();
            label23 = new Label();
            btnCalculadora = new Button();
            monthCalendar1 = new MonthCalendar();
            btnOk = new Button();
            comboBox4 = new ComboBox();
            lblEmpleado4 = new Label();
            label7 = new Label();
            label6 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblEmpleado = new Label();
            lblEmpleado3 = new Label();
            lblEmpleado1 = new Label();
            button1 = new Button();
            Reportes = new TabPage();
            label26 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            btbExitEmpleados = new Button();
            tabControl1.SuspendLayout();
            Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DTG).BeginInit();
            Pago.SuspendLayout();
            Reportes.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Empleados);
            tabControl1.Controls.Add(Pago);
            tabControl1.Controls.Add(Reportes);
            tabControl1.Location = new Point(4, 81);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1090, 450);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "ll";
            // 
            // Empleados
            // 
            Empleados.Controls.Add(label3);
            Empleados.Controls.Add(btnSeleccionarEmpleados);
            Empleados.Controls.Add(btnLimpiarEmpleados);
            Empleados.Controls.Add(btnBuscarEmpleados);
            Empleados.Controls.Add(DTG);
            Empleados.Location = new Point(4, 24);
            Empleados.Name = "Empleados";
            Empleados.Padding = new Padding(3);
            Empleados.Size = new Size(1082, 422);
            Empleados.TabIndex = 1;
            Empleados.Text = "Empleados";
            Empleados.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(821, 106);
            label3.TabIndex = 2;
            label3.Text = "Busqueda de empleados";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSeleccionarEmpleados
            // 
            btnSeleccionarEmpleados.BackgroundImage = (Image)resources.GetObject("btnSeleccionarEmpleados.BackgroundImage");
            btnSeleccionarEmpleados.BackgroundImageLayout = ImageLayout.Stretch;
            btnSeleccionarEmpleados.ForeColor = SystemColors.ActiveCaption;
            btnSeleccionarEmpleados.Location = new Point(914, 46);
            btnSeleccionarEmpleados.Name = "btnSeleccionarEmpleados";
            btnSeleccionarEmpleados.Size = new Size(78, 60);
            btnSeleccionarEmpleados.TabIndex = 3;
            btnSeleccionarEmpleados.Text = "Seleccionar";
            btnSeleccionarEmpleados.UseVisualStyleBackColor = true;
            btnSeleccionarEmpleados.Click += btnSeleccionarEmpleados_Click;
            // 
            // btnLimpiarEmpleados
            // 
            btnLimpiarEmpleados.BackgroundImage = Properties.Resources.cleaner;
            btnLimpiarEmpleados.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiarEmpleados.ForeColor = SystemColors.ControlDarkDark;
            btnLimpiarEmpleados.Location = new Point(998, 46);
            btnLimpiarEmpleados.Name = "btnLimpiarEmpleados";
            btnLimpiarEmpleados.Size = new Size(78, 60);
            btnLimpiarEmpleados.TabIndex = 2;
            btnLimpiarEmpleados.Text = "Limpiar";
            btnLimpiarEmpleados.UseVisualStyleBackColor = true;
            btnLimpiarEmpleados.Click += btnLimpiarEmpleados_Click;
            // 
            // btnBuscarEmpleados
            // 
            btnBuscarEmpleados.BackgroundImage = Properties.Resources.busqueda;
            btnBuscarEmpleados.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarEmpleados.ForeColor = SystemColors.Highlight;
            btnBuscarEmpleados.Location = new Point(830, 46);
            btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            btnBuscarEmpleados.Size = new Size(78, 60);
            btnBuscarEmpleados.TabIndex = 1;
            btnBuscarEmpleados.Text = "Buscar";
            btnBuscarEmpleados.UseVisualStyleBackColor = true;
            btnBuscarEmpleados.Click += btnBuscarEmpleados_Click;
            // 
            // DTG
            // 
            DTG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DTG.Location = new Point(4, 112);
            DTG.Name = "DTG";
            DTG.Size = new Size(1075, 311);
            DTG.TabIndex = 0;
            DTG.CellDoubleClick += DTG_CellDoubleClick;
            // 
            // Pago
            // 
            Pago.Controls.Add(button3);
            Pago.Controls.Add(comboBox5);
            Pago.Controls.Add(lblEmpleado6);
            Pago.Controls.Add(comboBox6);
            Pago.Controls.Add(lblEmpleado5);
            Pago.Controls.Add(label23);
            Pago.Controls.Add(btnCalculadora);
            Pago.Controls.Add(monthCalendar1);
            Pago.Controls.Add(btnOk);
            Pago.Controls.Add(comboBox4);
            Pago.Controls.Add(lblEmpleado4);
            Pago.Controls.Add(label7);
            Pago.Controls.Add(label6);
            Pago.Controls.Add(comboBox3);
            Pago.Controls.Add(comboBox2);
            Pago.Controls.Add(comboBox1);
            Pago.Controls.Add(lblEmpleado);
            Pago.Controls.Add(lblEmpleado3);
            Pago.Controls.Add(lblEmpleado1);
            Pago.Controls.Add(button1);
            Pago.Location = new Point(4, 24);
            Pago.Name = "Pago";
            Pago.Size = new Size(1082, 422);
            Pago.TabIndex = 2;
            Pago.Text = "Pagos";
            Pago.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Moneda;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(839, 265);
            button3.Name = "button3";
            button3.Size = new Size(227, 109);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(614, 341);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(213, 33);
            comboBox5.TabIndex = 15;
            // 
            // lblEmpleado6
            // 
            lblEmpleado6.BackColor = Color.LightGray;
            lblEmpleado6.Location = new Point(350, 341);
            lblEmpleado6.Name = "lblEmpleado6";
            lblEmpleado6.Size = new Size(258, 38);
            lblEmpleado6.TabIndex = 14;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(614, 294);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(213, 33);
            comboBox6.TabIndex = 13;
            // 
            // lblEmpleado5
            // 
            lblEmpleado5.BackColor = Color.LightGray;
            lblEmpleado5.Location = new Point(350, 294);
            lblEmpleado5.Name = "lblEmpleado5";
            lblEmpleado5.Size = new Size(258, 38);
            lblEmpleado5.TabIndex = 12;
            // 
            // label23
            // 
            label23.BackColor = SystemColors.ActiveCaption;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ControlLightLight;
            label23.Location = new Point(907, 199);
            label23.Name = "label23";
            label23.Size = new Size(87, 60);
            label23.TabIndex = 5;
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackgroundImage = Properties.Resources.estesi;
            btnCalculadora.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalculadora.Location = new Point(992, 199);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(74, 60);
            btnCalculadora.TabIndex = 11;
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(839, 25);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // btnOk
            // 
            btnOk.BackgroundImage = (Image)resources.GetObject("btnOk.BackgroundImage");
            btnOk.BackgroundImageLayout = ImageLayout.Stretch;
            btnOk.Location = new Point(839, 199);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(69, 60);
            btnOk.TabIndex = 5;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(614, 246);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(213, 33);
            comboBox4.TabIndex = 9;
            // 
            // lblEmpleado4
            // 
            lblEmpleado4.BackColor = Color.LightGray;
            lblEmpleado4.Location = new Point(350, 246);
            lblEmpleado4.Name = "lblEmpleado4";
            lblEmpleado4.Size = new Size(258, 38);
            lblEmpleado4.TabIndex = 8;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(650, 18);
            label7.Name = "label7";
            label7.Size = new Size(177, 57);
            label7.TabIndex = 7;
            label7.Text = "Cantidad a pagar";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(335, 18);
            label6.Name = "label6";
            label6.Size = new Size(309, 57);
            label6.TabIndex = 5;
            label6.Text = "Empleados";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(614, 199);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 33);
            comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(614, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(213, 33);
            comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(614, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 33);
            comboBox1.TabIndex = 4;
            // 
            // lblEmpleado
            // 
            lblEmpleado.BackColor = Color.LightGray;
            lblEmpleado.Location = new Point(350, 149);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(258, 38);
            lblEmpleado.TabIndex = 3;
            // 
            // lblEmpleado3
            // 
            lblEmpleado3.BackColor = Color.LightGray;
            lblEmpleado3.Location = new Point(350, 199);
            lblEmpleado3.Name = "lblEmpleado3";
            lblEmpleado3.Size = new Size(258, 38);
            lblEmpleado3.TabIndex = 2;
            // 
            // lblEmpleado1
            // 
            lblEmpleado1.BackColor = Color.LightGray;
            lblEmpleado1.Location = new Point(350, 95);
            lblEmpleado1.Name = "lblEmpleado1";
            lblEmpleado1.Size = new Size(258, 38);
            lblEmpleado1.TabIndex = 1;
            lblEmpleado1.Click += lblEmpleado1_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Moneda;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(7, 25);
            button1.Name = "button1";
            button1.Size = new Size(322, 354);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            Reportes.Controls.Add(label26);
            Reportes.Controls.Add(label22);
            Reportes.Controls.Add(label21);
            Reportes.Controls.Add(label20);
            Reportes.Controls.Add(label19);
            Reportes.Controls.Add(label18);
            Reportes.Controls.Add(label17);
            Reportes.Controls.Add(label16);
            Reportes.Controls.Add(label15);
            Reportes.Controls.Add(label14);
            Reportes.Controls.Add(label13);
            Reportes.Controls.Add(label12);
            Reportes.Controls.Add(label11);
            Reportes.Controls.Add(label10);
            Reportes.Controls.Add(label9);
            Reportes.Location = new Point(4, 24);
            Reportes.Name = "Reportes";
            Reportes.Size = new Size(1082, 422);
            Reportes.TabIndex = 3;
            Reportes.Text = "Reportes";
            Reportes.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            label26.BackColor = SystemColors.ActiveCaption;
            label26.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ControlLightLight;
            label26.Location = new Point(884, 0);
            label26.Name = "label26";
            label26.Size = new Size(205, 315);
            label26.TabIndex = 18;
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.BackColor = SystemColors.ActiveCaption;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ControlLightLight;
            label22.Location = new Point(-14, 345);
            label22.Name = "label22";
            label22.Size = new Size(1096, 77);
            label22.TabIndex = 5;
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            label21.BackColor = SystemColors.ActiveCaption;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ControlLightLight;
            label21.Location = new Point(654, 278);
            label21.Name = "label21";
            label21.Size = new Size(224, 37);
            label21.TabIndex = 17;
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.BackColor = SystemColors.ActiveCaption;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ControlLightLight;
            label20.Location = new Point(652, 219);
            label20.Name = "label20";
            label20.Size = new Size(224, 37);
            label20.TabIndex = 16;
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.BackColor = SystemColors.ActiveCaption;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ControlLightLight;
            label19.Location = new Point(654, 162);
            label19.Name = "label19";
            label19.Size = new Size(224, 37);
            label19.TabIndex = 15;
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.BackColor = SystemColors.ActiveCaption;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlLightLight;
            label18.Location = new Point(330, 278);
            label18.Name = "label18";
            label18.Size = new Size(318, 37);
            label18.TabIndex = 14;
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.BackColor = SystemColors.ActiveCaption;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlLightLight;
            label17.Location = new Point(330, 219);
            label17.Name = "label17";
            label17.Size = new Size(318, 37);
            label17.TabIndex = 13;
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BackColor = SystemColors.ActiveCaption;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(330, 162);
            label16.Name = "label16";
            label16.Size = new Size(318, 37);
            label16.TabIndex = 12;
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BackColor = SystemColors.ActiveCaption;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(4, 219);
            label15.Name = "label15";
            label15.Size = new Size(320, 37);
            label15.TabIndex = 11;
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(4, 278);
            label14.Name = "label14";
            label14.Size = new Size(320, 37);
            label14.TabIndex = 10;
            label14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(4, 162);
            label13.Name = "label13";
            label13.Size = new Size(320, 37);
            label13.TabIndex = 9;
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.AppWorkspace;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(328, 111);
            label12.Name = "label12";
            label12.Size = new Size(320, 37);
            label12.TabIndex = 8;
            label12.Text = "Tipo de contrato";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.AppWorkspace;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(654, 111);
            label11.Name = "label11";
            label11.Size = new Size(222, 37);
            label11.TabIndex = 7;
            label11.Text = "Salario Pagado";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.AppWorkspace;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(2, 111);
            label10.Name = "label10";
            label10.Size = new Size(320, 37);
            label10.TabIndex = 6;
            label10.Text = "Empleado";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.AppWorkspace;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(875, 77);
            label9.TabIndex = 5;
            label9.Text = "Reportes de pagos";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1, 3);
            label1.Name = "label1";
            label1.Size = new Size(1096, 77);
            label1.TabIndex = 1;
            label1.Text = "Gestion de pagos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btbExitEmpleados
            // 
            btbExitEmpleados.BackgroundImage = Properties.Resources.exit_close_error_15565;
            btbExitEmpleados.BackgroundImageLayout = ImageLayout.Stretch;
            btbExitEmpleados.Location = new Point(1019, 20);
            btbExitEmpleados.Name = "btbExitEmpleados";
            btbExitEmpleados.Size = new Size(78, 60);
            btbExitEmpleados.TabIndex = 4;
            btbExitEmpleados.UseVisualStyleBackColor = true;
            btbExitEmpleados.Click += btbExitEmpleados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 533);
            Controls.Add(btbExitEmpleados);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Empleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DTG).EndInit();
            Pago.ResumeLayout(false);
            Reportes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Pago;
        private TabPage Reportes;
        public TabPage Empleados;
        private Label label1;
        private Button btnSeleccionarEmpleados;
        private Button btnLimpiarEmpleados;
        private Button btnBuscarEmpleados;
        private DataGridView DTG;
        private Label label3;
        private TabPage tabPage3;
        private Button btbExitEmpleados;
        private Button button1;
        private Label lblEmpleado1;
        private Label lblEmpleado;
        private Label lblEmpleado3;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private ComboBox comboBox4;
        private Label lblEmpleado4;
        private Button btnOk;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label22;
        private MonthCalendar monthCalendar1;
        private Button btnCalculadora;
        private Label label23;
        private ComboBox comboBox5;
        private Label lblEmpleado6;
        private ComboBox comboBox6;
        private Label lblEmpleado5;
        private Button button3;
        private Label label26;
    }
}
