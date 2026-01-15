namespace SistemaGestionNomina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DTG.Columns.Add("Nombre", "Nombre");  //  Para agregar columna de Nombre del arreglo empleados
            DTG.Columns.Add("Puesto", "Puesto");  //  Para agregar columna de Puesto del arreglo puestos
            DTG.Columns.Add("Salario", "Salario");  //  Para agregar columna de Salario del arreglo salarios--
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
            DTG.Rows.Clear(); // Limpiar filas existentes antes de cargar nuevas
            foreach (string empleado in empleados)
            {
                DTG.Rows.Add(empleado);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Operación realizada con éxito!", "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Empleados_Click(object sender, EventArgs e)
        {

        }
        //-----  Arreglos -----

        String[] empleados = { "Juan Perez", "Maria Gomez", "Carlos Sanchez", "Ana Martinez", "Luis Rodriguez" };

        string[] puestos = { "Gerente", "Asistente", "Contador", "Recursos Humanos", "Desarrollador" };

        decimal[] salarios = { 50000m, 30000m, 40000m, 35000m, 45000m };

    }

}