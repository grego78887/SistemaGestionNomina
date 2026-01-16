using System.Windows.Forms;

namespace SistemaGestionNomina
{
    public partial class Form1 : Form
    {

        private readonly string[] empleados = { "Gregori Evangelista", "Maria Gomez", "Carlos Sanchez", "Ana Martinez", "Luis Rodriguez", "Francis Ramirez" };
        private readonly string[] puestos = { "Gerente", "Asistente", "Contador", "Recursos Humanos", "Desarrollador", "Desarrollador Senior" };
        private readonly int[] numeroSeguroSocial = { 123456789, 987654321, 456789123, 789123456, 321654987, 654321789 };
        private readonly decimal[] salarioSemanal = { 50000m, 30000m, 40000m, 35000m, 45000m, 60000m };

        public Form1()
        {
            InitializeComponent();
            DTG.Columns.Add("Nombre", "Nombre");
            DTG.Columns.Add("Puesto", "Puesto");
            DTG.Columns.Add("Salario semanal", "Salario semanal");
        }







        private void DTG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //---------------------------------------------
        //BOTONES de empleados
        //---------------------------------------------

        private void btnLimpiarEmpleados_Click(object sender, EventArgs e)
        {
            DTG.Rows.Clear();
            DTG.Refresh();  // Refresca el DataGridView para mostrar los cambios


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
                DTG.Rows.Add(empleados[i], puestos[i], salarioSemanal[i]);
            }

            // Populate the Pagos tab combo boxes with employee data
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(empleados);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(puestos);
            comboBox4.Items.Clear();
            comboBox4.Items.AddRange(salarioSemanal.Select(s => s.ToString()).ToArray());
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Operación realizada con éxito!", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadoraEmpleados calculadoraForm = new frmCalculadoraEmpleados(salarioSemanal);
            calculadoraForm.Show();
        }

        private void btnSeleccionarEmpleados_Click(object sender, EventArgs e)
        {
            if (DTG.RowCount > 0) // verifica que el dataGridView tenga líneas
            {
                lblEmpleado1.Text = DTG.CurrentRow.Cells[0].Value.ToString();
                btnBuscarEmpleados.PerformClick();
                TabPage tabPage = tabControl1.SelectedTab = tabControl1.TabPages["tabPagos"];
                using var _ = Pago;
            }


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

    }

}