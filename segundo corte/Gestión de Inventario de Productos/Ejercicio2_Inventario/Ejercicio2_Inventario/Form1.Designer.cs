namespace Ejercicio2_Inventario
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCodigo           = new System.Windows.Forms.TextBox();
            this.txtNombreProducto   = new System.Windows.Forms.TextBox();
            this.cmbCategoria        = new System.Windows.Forms.ComboBox();
            this.numStockInicial     = new System.Windows.Forms.NumericUpDown();
            this.numStockMinimo      = new System.Windows.Forms.NumericUpDown();
            this.grpIva              = new System.Windows.Forms.GroupBox();
            this.rbExento            = new System.Windows.Forms.RadioButton();
            this.rbGeneral           = new System.Windows.Forms.RadioButton();
            this.rbReducido          = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero     = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblResultado        = new System.Windows.Forms.Label();
            this.btnGuardar          = new System.Windows.Forms.Button();
            this.btnLimpiar          = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)this.numStockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.numStockMinimo).BeginInit();
            this.grpIva.SuspendLayout();
            this.SuspendLayout();

            // ── Colores / fuentes ────────────────────────────────────────────
            System.Drawing.Color accent = System.Drawing.Color.FromArgb(98, 0, 238);
            System.Drawing.Font fntLbl  = new("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntInp  = new("Segoe UI", 10f);
            System.Drawing.Color fgLbl  = System.Drawing.Color.FromArgb(55, 55, 55);

            System.Windows.Forms.Label MkLbl(string t, int x, int y)
                => new() { Text = t, Font = fntLbl, ForeColor = fgLbl,
                            Location = new(x, y), AutoSize = true };

            // ── Layout constants ─────────────────────────────────────────────
            int lx = 30, iw = 400, gap = 58;
            int y = 20;

            // ── Título ───────────────────────────────────────────────────────
            var lblTitulo = new System.Windows.Forms.Label
            {
                Text      = "Gestión de Inventario",
                Font      = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold),
                ForeColor = accent,
                Location  = new(lx, y),
                AutoSize  = true
            };
            y += 50;

            // ── Código ───────────────────────────────────────────────────────
            var lCod = MkLbl("Código de Producto *  (PROD-0000)", lx, y);
            y += 22;
            this.txtCodigo.Font            = fntInp;
            this.txtCodigo.Location        = new(lx, y);
            this.txtCodigo.Size            = new(iw, 28);
            this.txtCodigo.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.PlaceholderText = "PROD-0001";
            this.txtCodigo.MaxLength       = 9;
            y += gap;

            // ── Nombre ───────────────────────────────────────────────────────
            var lNom = MkLbl("Nombre del Producto *", lx, y);
            y += 22;
            this.txtNombreProducto.Font            = fntInp;
            this.txtNombreProducto.Location        = new(lx, y);
            this.txtNombreProducto.Size            = new(iw, 28);
            this.txtNombreProducto.BorderStyle     = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.PlaceholderText = "Ej. Laptop Lenovo IdeaPad";
            y += gap;

            // ── Categoría ────────────────────────────────────────────────────
            var lCat = MkLbl("Categoría", lx, y);
            y += 22;
            this.cmbCategoria.Font          = fntInp;
            this.cmbCategoria.Location      = new(lx, y);
            this.cmbCategoria.Size          = new(iw, 28);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Items.AddRange(new object[] { "Electrónica", "Alimentos", "Ropa" });
            this.cmbCategoria.SelectedIndex = 0;
            y += gap;

            // ── Stock inicial ─────────────────────────────────────────────────
            var lSI = MkLbl("Stock Inicial", lx, y);
            var lSM = MkLbl("Stock Mínimo", lx + 210, y);
            y += 22;
            this.numStockInicial.Font     = fntInp;
            this.numStockInicial.Location = new(lx, y);
            this.numStockInicial.Size     = new(190, 28);
            this.numStockInicial.Minimum  = 0;
            this.numStockInicial.Maximum  = 99999;

            this.numStockMinimo.Font     = fntInp;
            this.numStockMinimo.Location = new(lx + 210, y);
            this.numStockMinimo.Size     = new(190, 28);
            this.numStockMinimo.Minimum  = 0;
            this.numStockMinimo.Maximum  = 99999;
            y += gap;

            // ── GroupBox IVA ──────────────────────────────────────────────────
            this.grpIva.Text      = "Tipo de IVA *";
            this.grpIva.Font      = fntLbl;
            this.grpIva.ForeColor = fgLbl;
            this.grpIva.Location  = new(lx, y);
            this.grpIva.Size      = new(iw, 55);

            System.Drawing.Font fntRb = new("Segoe UI", 10f);
            this.rbExento.Text     = "Exento (0%)";
            this.rbExento.Font     = fntRb;
            this.rbExento.Location = new(10, 22);
            this.rbExento.AutoSize = true;

            this.rbGeneral.Text     = "General (19%)";
            this.rbGeneral.Font     = fntRb;
            this.rbGeneral.Location = new(130, 22);
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Checked  = true;

            this.rbReducido.Text     = "Reducido (5%)";
            this.rbReducido.Font     = fntRb;
            this.rbReducido.Location = new(265, 22);
            this.rbReducido.AutoSize = true;

            this.grpIva.Controls.AddRange(new System.Windows.Forms.Control[]
                { this.rbExento, this.rbGeneral, this.rbReducido });
            y += 70;

            // ── Perecedero ────────────────────────────────────────────────────
            this.chkEsPerecedero.Text     = "Es Perecedero";
            this.chkEsPerecedero.Font     = fntInp;
            this.chkEsPerecedero.Location = new(lx, y);
            this.chkEsPerecedero.AutoSize = true;
            this.chkEsPerecedero.Cursor   = System.Windows.Forms.Cursors.Hand;
            y += 30;

            // ── Fecha vencimiento ─────────────────────────────────────────────
            var lFv = MkLbl("Fecha de Vencimiento", lx, y);
            y += 22;
            this.dtpFechaVencimiento.Font     = fntInp;
            this.dtpFechaVencimiento.Location = new(lx, y);
            this.dtpFechaVencimiento.Size     = new(iw, 28);
            this.dtpFechaVencimiento.Enabled  = false;
            this.dtpFechaVencimiento.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            y += gap;

            // ── Resultado ─────────────────────────────────────────────────────
            this.lblResultado.Font     = new System.Drawing.Font("Segoe UI", 9.5f);
            this.lblResultado.Location = new(lx, y);
            this.lblResultado.Size     = new(iw, 46);
            this.lblResultado.AutoSize = false;
            y += 50;

            // ── Botones ───────────────────────────────────────────────────────
            this.btnGuardar.Text      = "Guardar Producto";
            this.btnGuardar.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.btnGuardar.BackColor = accent;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.Location  = new(lx, y);
            this.btnGuardar.Size      = new(190, 40);
            this.btnGuardar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Click    += btnGuardar_Click;

            this.btnLimpiar.Text      = "Limpiar";
            this.btnLimpiar.Font      = new System.Drawing.Font("Segoe UI", 11f);
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(240, 240, 245);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 200);
            this.btnLimpiar.Location  = new(lx + 200, y);
            this.btnLimpiar.Size      = new(190, 40);
            this.btnLimpiar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click    += btnLimpiar_Click;
            y += 60;

            // ── Formulario ────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize    = new System.Drawing.Size(460, y);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitulo,
                lCod,  this.txtCodigo,
                lNom,  this.txtNombreProducto,
                lCat,  this.cmbCategoria,
                lSI, lSM, this.numStockInicial, this.numStockMinimo,
                this.grpIva,
                this.chkEsPerecedero,
                lFv, this.dtpFechaVencimiento,
                this.lblResultado,
                this.btnGuardar, this.btnLimpiar
            });
            this.Text            = "Ejercicio 2 — Gestión de Inventario";
            this.BackColor       = System.Drawing.Color.FromArgb(250, 250, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)this.numStockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.numStockMinimo).EndInit();
            this.grpIva.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox          txtCodigo           = null!;
        private System.Windows.Forms.TextBox          txtNombreProducto   = null!;
        private System.Windows.Forms.ComboBox         cmbCategoria        = null!;
        private System.Windows.Forms.NumericUpDown    numStockInicial     = null!;
        private System.Windows.Forms.NumericUpDown    numStockMinimo      = null!;
        private System.Windows.Forms.GroupBox         grpIva              = null!;
        private System.Windows.Forms.RadioButton      rbExento            = null!;
        private System.Windows.Forms.RadioButton      rbGeneral           = null!;
        private System.Windows.Forms.RadioButton      rbReducido          = null!;
        private System.Windows.Forms.CheckBox         chkEsPerecedero     = null!;
        private System.Windows.Forms.DateTimePicker   dtpFechaVencimiento = null!;
        private System.Windows.Forms.Label            lblResultado        = null!;
        private System.Windows.Forms.Button           btnGuardar          = null!;
        private System.Windows.Forms.Button           btnLimpiar          = null!;
    }
}
