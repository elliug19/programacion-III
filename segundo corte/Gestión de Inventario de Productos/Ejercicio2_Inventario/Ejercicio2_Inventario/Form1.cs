using System.Text.RegularExpressions;

namespace Ejercicio2_Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Lógica de interfaz: habilitar fecha solo si es perecedero
            chkEsPerecedero.CheckedChanged += (s, e) =>
                dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Código de producto: debe comenzar con "PROD-" + 4 dígitos
            if (!Regex.IsMatch(txtCodigo.Text.Trim(), @"^PROD-\d{4}$"))
            {
                Msg("El código debe seguir el patrón PROD-0000 (ej. PROD-1234).", true);
                return;
            }

            // 2. Nombre obligatorio
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                Msg("El nombre del producto es obligatorio.", true);
                return;
            }

            // 3. Validación cruzada de stock
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                Msg($"El stock inicial ({numStockInicial.Value}) no puede ser menor al stock mínimo ({numStockMinimo.Value}).", true);
                return;
            }

            // 4. Selección de IVA
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                Msg("Debe seleccionar un tipo de IVA.", true);
                return;
            }

            // Calcular IVA
            decimal iva = rbExento.Checked ? 0m : rbGeneral.Checked ? 0.19m : 0.05m;
            string  ivaLabel = rbExento.Checked ? "Exento (0%)" : rbGeneral.Checked ? "General (19%)" : "Reducido (5%)";
            string  venc = chkEsPerecedero.Checked
                ? $"Vence: {dtpFechaVencimiento.Value:dd/MM/yyyy}"
                : "No perecedero";

            Msg($"✔ Producto registrado: {txtCodigo.Text.Trim()}  |  {txtNombreProducto.Text.Trim()}\n" +
                $"Stock: {numStockInicial.Value} uds (mín. {numStockMinimo.Value})  |  IVA: {ivaLabel}  |  {venc}", false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            cmbCategoria.SelectedIndex = 0;
            numStockInicial.Value  = 0;
            numStockMinimo.Value   = 0;
            rbGeneral.Checked      = true;
            chkEsPerecedero.Checked = false;
            dtpFechaVencimiento.Value   = DateTime.Today;
            dtpFechaVencimiento.Enabled = false;
            lblResultado.Text = "";
        }

        private void Msg(string texto, bool error)
        {
            lblResultado.ForeColor = error
                ? System.Drawing.Color.Crimson
                : System.Drawing.Color.FromArgb(0, 130, 60);
            lblResultado.Text = (error ? "✖  " : "") + texto;
        }
    }
}
