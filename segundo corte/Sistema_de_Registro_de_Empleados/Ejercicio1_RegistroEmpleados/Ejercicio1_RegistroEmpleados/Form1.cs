using System.Text.RegularExpressions;

namespace Ejercicio1_RegistroEmpleados
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                Msg("Todos los campos son obligatorios.", true);
                return;
            }

            // 2. Formato email
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Msg("El email no tiene un formato válido.", true);
                return;
            }

            // 3. Identificación: exactamente 10 dígitos
            if (!Regex.IsMatch(txtIdentificacion.Text.Trim(), @"^\d{10}$"))
            {
                Msg("La identificación debe contener exactamente 10 dígitos numéricos.", true);
                return;
            }

            // 4. Cálculo sueldo neto
            decimal sueldoBase = numSueldoBase.Value;
            decimal retencion  = sueldoBase * 0.10m;
            decimal sueldoNeto = sueldoBase - retencion;

            lblResultadoSueldo.ForeColor = System.Drawing.Color.FromArgb(0, 140, 60);
            lblResultadoSueldo.Text =
                $"✔  Empleado registrado correctamente.\n" +
                $"Sueldo base: {sueldoBase:C}  |  Retención 10%: {retencion:C}  |  Sueldo neto: {sueldoNeto:C}";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();
            numSueldoBase.Value = numSueldoBase.Minimum;
            cmbDepartamento.SelectedIndex = 0;
            lblResultadoSueldo.Text = "";
        }

        private void Msg(string texto, bool error)
        {
            lblResultadoSueldo.ForeColor = error
                ? System.Drawing.Color.Crimson
                : System.Drawing.Color.FromArgb(0, 140, 60);
            lblResultadoSueldo.Text = (error ? "✖  " : "✔  ") + texto;
        }
    }
}
