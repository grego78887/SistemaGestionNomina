using System.Windows.Forms;

namespace SistemaGestionNomina
{
    public partial class Form1 : Form
    {
        // Datos para empleados asalariados-------------------------------------------------------------------------------------------------------------------
        private readonly string[] empleados = { "Gregori Evangelista", "Maria Gomez", "Carlos Sanchez", "Ana Martinez", "Luis Rodriguez", "Francis Ramirez" };
        private readonly string[] puestos = { "Gerente", "Asistente", "Contador", "Recursos Humanos", "Desarrollador", "Desarrollador Senior" };
        private readonly int[] numeroSeguroSocial = { 123456789, 987654321, 456789123, 789123456, 321654987, 654321789 };
        private readonly decimal[] salarioSemanal = { 50000m, 30000m, 40000m, 35000m, 45000m, 60000m };

        // Datos para empleados por horas-------------------------------------------------------------------------------------------------------------------
        private readonly string[] empleadOs = { "Jose Perez", "Laura Diaz", "Miguel Torres", "Sofia Lopez", "Javier Morales", "Elena Cruz" };
        private readonly string[] puestOs = { "Operario", "Asistente", "Técnico", "Auxiliar", "Supervisor", "Coordinador" };
        private readonly int[] numeroSeguroSociAl = { 112233445, 554433221, 667788990, 998877665, 443322110, 110022334 };
        private readonly decimal[] tarifaPorHora = { 150m, 120m, 130m, 110m, 140m, 160m };
        private readonly decimal[] horasTrabajadas = { 40m, 35m, 45m, 30m, 50m, 38m };

        // Datos para empleados por comisión-------------------------------------------------------------------------------------------------------------------
        private readonly string[] empleaDOs = { "Jose Perez", "Laura Diaz", "Miguel Torres", "Sofia Lopez", "Javier Morales", "Elena Cruz" };
        private readonly int[] numeroSeguroSociaL = { 112233445, 554433221, 667788990, 998877665, 443322110, 110022334 };
        private readonly decimal[] ventasBrutas = { 200000m, 150000m, 250000m, 180000m, 220000m, 300000m };
        private readonly decimal[] tarifaComision = { 0.10m, 0.12m, 0.11m, 0.09m, 0.13m, 0.15m };


        // Datos para empleados asalariados por comisión-------------------------------------------------------------------------------------------------------------------
        public readonly string[] empleadosSalarioComision = { "Ana Ruiz", "Carlos Vega", "Diana Flores", "Eduardo Ramos", "Fernanda Soto" };
        private readonly int[] numeroSeguroSocialSalarioComision = { 223344556, 667788991, 889900112, 334455667, 556677889 };
        private readonly decimal[] salarioBaseSemanal = { 40000m, 35000m, 45000m, 38000m, 42000m };
        private readonly decimal[] ventasBrutasSalarioComision = { 180000m, 220000m, 250000m, 200000m, 240000m };
        private readonly decimal[] tarifaComisionSalarioComision = { 0.08m, 0.10m, 0.12m, 0.09m, 0.11m };

        //Datos para empleados asalariados por comisión-------------------------------------------------------------------------------------------------------------------




        public Form1()
        {
            InitializeComponent();

            // Columnas para Empleado Asalariado-------------------------------
            DTG.Columns.Add("Nombre", "Nombre");
            DTG.Columns.Add("Puesto", "Puesto");
            DTG.Columns.Add("Numero de seguro social", "Numero de seguro social");
            DTG.Columns.Add("Salario semanal", "Salario semanal");

            // Columnas para Empleado por Horas-------------------------------
            DTG.Columns.Add("Nombre", "Nombre");
            DTG.Columns.Add("Puesto", "Puesto");
            DTG.Columns.Add("Numero de seguro social", "Numero de seguro social");
            DTG.Columns.Add("Tarifa por hora", "Tarifa por hora");
            DTG.Columns.Add("Horas trabajadas", "Horas trabajadas");

            // Columnas para Empleado por Comisión-------------------------------
            DTG.Columns.Add("Nombre", "Nombre");
            DTG.Columns.Add("Numero de seguro social", "Numero de seguro social");
            DTG.Columns.Add("Ventas brutas", "Ventas brutas");
            DTG.Columns.Add("Tarifa de comisión", "Tarifa de comisión");

            // Columnas para Empleado Asalariado por Comisión-------------------------------
            DTG.Columns.Add("Nombre", "Nombre");
            DTG.Columns.Add("Numero de seguro social", "Numero de seguro social");
            DTG.Columns.Add("Ventas brutas", "Ventas brutas");
            DTG.Columns.Add("Tarifa de comisión", "Tarifa de comisión");
        }


        //---------------------------------------------
        //BOTONES de empleados
        //---------------------------------------------

        private void btnLimpiarEmpleados_Click(object sender, EventArgs e)
        {
            DTG.Rows.Clear();
            DTG.Refresh();

        }

        private void btbExitEmpleados_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            DTG.Rows.Clear();
            for (int i = 0; i < empleados.Length; i++)
            {
                DTG.Rows.Add(empleados[i], puestos[i], salarioSemanal[i], empleadOs[i], tarifaPorHora[i], horasTrabajadas[i], empleaDOs[i], numeroSeguroSociaL[i], ventasBrutas[i], tarifaComision[i]);
            }


            cmb1.Items.Clear();
            cmb1.Items.AddRange(empleados);
            cmb2.Items.Clear();
            cmb2.Items.AddRange(puestos);

        }

        private void btnSeleccionarEmpleados_Click(object sender, EventArgs e)
        {
            if (DTG.SelectedRows.Count > 0 && !DTG.SelectedRows[0].IsNewRow)
            {
                DataGridViewRow selectedRow = DTG.SelectedRows[0];
                int index = selectedRow.Index;

                cmb1.Text = empleados[index];
                cmb2.Text = puestos[index];

                tabControl1.SelectedTab = Pago;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado válido.", "Selección de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Operación realizada con éxito!", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);


            lblEmpleado1.Text = cmb1.Text;
            lblTipoContrato1.Text = cmb2.Text;
            lblSalario1.Text = textBox1.Text;
            lblSalario2.Text = textBox1.Text;


            tabControl1.SelectedTab = Reportes;
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadoraEmpleados calculadoraForm = new frmCalculadoraEmpleados(salarioSemanal);
            calculadoraForm.Show();
        }

        private void lblEmpleado1_Click(object sender, EventArgs e)
        {
            if (DTG.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DTG.SelectedRows[0];
                int index = selectedRow.Index;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado.", "Selección de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }

}