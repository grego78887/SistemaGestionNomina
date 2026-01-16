
namespace SistemaGestionNomina
{
    internal class frmDetallesEmpleados
    {
        private string[] empleados;
        private string[] puestos;
        private int[] numeroSeguroSocial;
        private decimal[] salarioSemanal;

        public frmDetallesEmpleados(string[] empleados, string[] puestos, int[] numeroSeguroSocial, decimal[] salarioSemanal)
        {
            this.empleados = empleados;
            this.puestos = puestos;
            this.numeroSeguroSocial = numeroSeguroSocial;
            this.salarioSemanal = salarioSemanal;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}