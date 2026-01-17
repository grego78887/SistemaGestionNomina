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
            cmb6 = new ComboBox();
            cmb5 = new ComboBox();
            cmb4 = new ComboBox();
            cmb2 = new ComboBox();
            cmb3 = new ComboBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            label23 = new Label();
            btnCalculadora = new Button();
            monthCalendar1 = new MonthCalendar();
            btnOk = new Button();
            label7 = new Label();
            label6 = new Label();
            cmb1 = new ComboBox();
            button1 = new Button();
            Reportes = new TabPage();
            label26 = new Label();
            label22 = new Label();
            lblSalario3 = new Label();
            lblSalario2 = new Label();
            lblSalario1 = new Label();
            lblTipoContrato3 = new Label();
            lblTipoContrato2 = new Label();
            lblTipoContrato1 = new Label();
            lblEmpleado2 = new Label();
            lblEmpleado3 = new Label();
            lblEmpleado1 = new Label();
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
            // 
            // Pago
            // 
            Pago.Controls.Add(cmb6);
            Pago.Controls.Add(cmb5);
            Pago.Controls.Add(cmb4);
            Pago.Controls.Add(cmb2);
            Pago.Controls.Add(cmb3);
            Pago.Controls.Add(textBox6);
            Pago.Controls.Add(textBox5);
            Pago.Controls.Add(textBox4);
            Pago.Controls.Add(textBox3);
            Pago.Controls.Add(textBox2);
            Pago.Controls.Add(textBox1);
            Pago.Controls.Add(button3);
            Pago.Controls.Add(label23);
            Pago.Controls.Add(btnCalculadora);
            Pago.Controls.Add(monthCalendar1);
            Pago.Controls.Add(btnOk);
            Pago.Controls.Add(label7);
            Pago.Controls.Add(label6);
            Pago.Controls.Add(cmb1);
            Pago.Controls.Add(button1);
            Pago.Location = new Point(4, 24);
            Pago.Name = "Pago";
            Pago.Size = new Size(1082, 422);
            Pago.TabIndex = 2;
            Pago.Text = "Pagos";
            Pago.UseVisualStyleBackColor = true;
            // 
            // cmb6
            // 
            cmb6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb6.FormattingEnabled = true;
            cmb6.Items.AddRange(new object[] { "\"Gregori Evangelista", "" });
            cmb6.Location = new Point(335, 357);
            cmb6.Name = "cmb6";
            cmb6.Size = new Size(309, 33);
            cmb6.TabIndex = 27;
            // 
            // cmb5
            // 
            cmb5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb5.FormattingEnabled = true;
            cmb5.Items.AddRange(new object[] { "\"Gregori Evangelista", "" });
            cmb5.Location = new Point(335, 301);
            cmb5.Name = "cmb5";
            cmb5.Size = new Size(309, 33);
            cmb5.TabIndex = 26;
            // 
            // cmb4
            // 
            cmb4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb4.FormattingEnabled = true;
            cmb4.Items.AddRange(new object[] { "\"Gregori Evangelista", "" });
            cmb4.Location = new Point(335, 257);
            cmb4.Name = "cmb4";
            cmb4.Size = new Size(309, 33);
            cmb4.TabIndex = 25;
            // 
            // cmb2
            // 
            cmb2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb2.FormattingEnabled = true;
            cmb2.Items.AddRange(new object[] { "\"Gregori Evangelista", "" });
            cmb2.Location = new Point(335, 165);
            cmb2.Name = "cmb2";
            cmb2.Size = new Size(309, 33);
            cmb2.TabIndex = 24;
            // 
            // cmb3
            // 
            cmb3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb3.FormattingEnabled = true;
            cmb3.Items.AddRange(new object[] { "\"Gregori Evangelista", "" });
            cmb3.Location = new Point(335, 214);
            cmb3.Name = "cmb3";
            cmb3.Size = new Size(309, 33);
            cmb3.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(656, 165);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(160, 33);
            textBox6.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(656, 357);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(160, 33);
            textBox5.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(656, 305);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(160, 33);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(661, 257);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(160, 33);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(656, 210);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 33);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(656, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 33);
            textBox1.TabIndex = 17;
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
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(661, 16);
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
            label6.Location = new Point(335, 16);
            label6.Name = "label6";
            label6.Size = new Size(309, 57);
            label6.TabIndex = 5;
            label6.Text = "Empleados";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmb1
            // 
            cmb1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb1.FormattingEnabled = true;
            cmb1.Items.AddRange(new object[] { "\"Gregori Evangelista", "" });
            cmb1.Location = new Point(335, 111);
            cmb1.Name = "cmb1";
            cmb1.Size = new Size(309, 33);
            cmb1.TabIndex = 4;
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
            Reportes.Controls.Add(lblSalario3);
            Reportes.Controls.Add(lblSalario2);
            Reportes.Controls.Add(lblSalario1);
            Reportes.Controls.Add(lblTipoContrato3);
            Reportes.Controls.Add(lblTipoContrato2);
            Reportes.Controls.Add(lblTipoContrato1);
            Reportes.Controls.Add(lblEmpleado2);
            Reportes.Controls.Add(lblEmpleado3);
            Reportes.Controls.Add(lblEmpleado1);
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
            // lblSalario3
            // 
            lblSalario3.BackColor = SystemColors.ActiveCaption;
            lblSalario3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario3.ForeColor = SystemColors.ControlLightLight;
            lblSalario3.Location = new Point(654, 278);
            lblSalario3.Name = "lblSalario3";
            lblSalario3.Size = new Size(224, 37);
            lblSalario3.TabIndex = 17;
            lblSalario3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSalario2
            // 
            lblSalario2.BackColor = SystemColors.ActiveCaption;
            lblSalario2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario2.ForeColor = SystemColors.ControlLightLight;
            lblSalario2.Location = new Point(652, 219);
            lblSalario2.Name = "lblSalario2";
            lblSalario2.Size = new Size(224, 37);
            lblSalario2.TabIndex = 16;
            lblSalario2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSalario1
            // 
            lblSalario1.BackColor = SystemColors.ActiveCaption;
            lblSalario1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalario1.ForeColor = SystemColors.ControlLightLight;
            lblSalario1.Location = new Point(654, 162);
            lblSalario1.Name = "lblSalario1";
            lblSalario1.Size = new Size(224, 37);
            lblSalario1.TabIndex = 15;
            lblSalario1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoContrato3
            // 
            lblTipoContrato3.BackColor = SystemColors.ActiveCaption;
            lblTipoContrato3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoContrato3.ForeColor = SystemColors.ControlLightLight;
            lblTipoContrato3.Location = new Point(330, 278);
            lblTipoContrato3.Name = "lblTipoContrato3";
            lblTipoContrato3.Size = new Size(318, 37);
            lblTipoContrato3.TabIndex = 14;
            lblTipoContrato3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoContrato2
            // 
            lblTipoContrato2.BackColor = SystemColors.ActiveCaption;
            lblTipoContrato2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoContrato2.ForeColor = SystemColors.ControlLightLight;
            lblTipoContrato2.Location = new Point(330, 219);
            lblTipoContrato2.Name = "lblTipoContrato2";
            lblTipoContrato2.Size = new Size(318, 37);
            lblTipoContrato2.TabIndex = 13;
            lblTipoContrato2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoContrato1
            // 
            lblTipoContrato1.BackColor = SystemColors.ActiveCaption;
            lblTipoContrato1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoContrato1.ForeColor = SystemColors.ControlLightLight;
            lblTipoContrato1.Location = new Point(330, 162);
            lblTipoContrato1.Name = "lblTipoContrato1";
            lblTipoContrato1.Size = new Size(318, 37);
            lblTipoContrato1.TabIndex = 12;
            lblTipoContrato1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpleado2
            // 
            lblEmpleado2.BackColor = SystemColors.ActiveCaption;
            lblEmpleado2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleado2.ForeColor = SystemColors.ControlLightLight;
            lblEmpleado2.Location = new Point(4, 219);
            lblEmpleado2.Name = "lblEmpleado2";
            lblEmpleado2.Size = new Size(320, 37);
            lblEmpleado2.TabIndex = 11;
            lblEmpleado2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpleado3
            // 
            lblEmpleado3.BackColor = SystemColors.ActiveCaption;
            lblEmpleado3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleado3.ForeColor = SystemColors.ControlLightLight;
            lblEmpleado3.Location = new Point(4, 278);
            lblEmpleado3.Name = "lblEmpleado3";
            lblEmpleado3.Size = new Size(320, 37);
            lblEmpleado3.TabIndex = 10;
            lblEmpleado3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmpleado1
            // 
            lblEmpleado1.BackColor = SystemColors.ActiveCaption;
            lblEmpleado1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleado1.ForeColor = SystemColors.ControlLightLight;
            lblEmpleado1.Location = new Point(4, 162);
            lblEmpleado1.Name = "lblEmpleado1";
            lblEmpleado1.Size = new Size(320, 37);
            lblEmpleado1.TabIndex = 9;
            lblEmpleado1.TextAlign = ContentAlignment.MiddleCenter;
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
            Pago.PerformLayout();
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
        private ComboBox cmb1;
        private Label label7;
        private Label label6;
        private Button btnOk;
        private Label label9;
        private Label label10;
        private Label lblEmpleado1;
        private Label label12;
        private Label label11;
        private Label lblSalario3;
        private Label lblSalario2;
        private Label lblSalario1;
        private Label lblTipoContrato3;
        private Label lblTipoContrato2;
        private Label lblTipoContrato1;
        private Label lblEmpleado2;
        private Label lblEmpleado3;
        private Label label22;
        private MonthCalendar monthCalendar1;
        private Button btnCalculadora;
        private Label label23;
        private Button button3;
        private Label label26;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cmb3;
        private ComboBox cmb6;
        private ComboBox cmb5;
        private ComboBox cmb4;
        private ComboBox cmb2;
    }
}
