namespace Ejercicio1_RegistroEmpleados
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
            var lblTitulo        = new System.Windows.Forms.Label();
            var lblNombres       = new System.Windows.Forms.Label();
            var lblApellidos     = new System.Windows.Forms.Label();
            var lblEmail         = new System.Windows.Forms.Label();
            var lblId            = new System.Windows.Forms.Label();
            var lblSueldo        = new System.Windows.Forms.Label();
            var lblDepto         = new System.Windows.Forms.Label();

            this.txtNombres        = new System.Windows.Forms.TextBox();
            this.txtApellidos      = new System.Windows.Forms.TextBox();
            this.txtEmail          = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.numSueldoBase     = new System.Windows.Forms.NumericUpDown();
            this.cmbDepartamento   = new System.Windows.Forms.ComboBox();
            this.lblResultadoSueldo= new System.Windows.Forms.Label();
            this.btnRegistrar      = new System.Windows.Forms.Button();
            this.btnLimpiar        = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)this.numSueldoBase).BeginInit();
            this.SuspendLayout();

            // ── Helpers ──────────────────────────────────────────────────────
            System.Drawing.Font fntLabel = new("Segoe UI", 9.5f, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fntInput = new("Segoe UI", 10f);
            System.Drawing.Color accent  = System.Drawing.Color.FromArgb(98, 0, 238);

            System.Windows.Forms.Label MkLabel(string text, int x, int y)
            {
                return new System.Windows.Forms.Label
                {
                    Text      = text,
                    Font      = fntLabel,
                    ForeColor = System.Drawing.Color.FromArgb(60, 60, 60),
                    Location  = new System.Drawing.Point(x, y),
                    AutoSize  = true
                };
            }

            System.Windows.Forms.TextBox MkTxt(int x, int y, int w, string ph = "")
            {
                var t = new System.Windows.Forms.TextBox
                {
                    Font        = fntInput,
                    Location    = new System.Drawing.Point(x, y),
                    Size        = new System.Drawing.Size(w, 28),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    PlaceholderText = ph
                };
                return t;
            }

            int lx = 30, ix = 30, iw = 400, row1 = 80;
            int gap = 60;

            // ── Título ───────────────────────────────────────────────────────
            lblTitulo.Text      = "Registro de Empleados";
            lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 16f, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = accent;
            lblTitulo.Location  = new System.Drawing.Point(lx, 20);
            lblTitulo.AutoSize  = true;

            // ── Nombres ──────────────────────────────────────────────────────
            var lN = MkLabel("Nombres *", lx, row1);
            this.txtNombres = MkTxt(ix, row1 + 22, iw, "Ej. Juan Carlos");

            // ── Apellidos ────────────────────────────────────────────────────
            int r2 = row1 + gap;
            var lA = MkLabel("Apellidos *", lx, r2);
            this.txtApellidos = MkTxt(ix, r2 + 22, iw, "Ej. García López");

            // ── Email ────────────────────────────────────────────────────────
            int r3 = r2 + gap;
            var lE = MkLabel("Email *", lx, r3);
            this.txtEmail = MkTxt(ix, r3 + 22, iw, "ejemplo@correo.com");

            // ── Identificación ───────────────────────────────────────────────
            int r4 = r3 + gap;
            var lI = MkLabel("Identificación (10 dígitos) *", lx, r4);
            this.txtIdentificacion = MkTxt(ix, r4 + 22, iw, "0000000000");
            this.txtIdentificacion.MaxLength = 10;

            // ── Departamento ─────────────────────────────────────────────────
            int r5 = r4 + gap;
            var lD = MkLabel("Departamento *", lx, r5);
            this.cmbDepartamento.Font        = fntInput;
            this.cmbDepartamento.Location    = new System.Drawing.Point(ix, r5 + 22);
            this.cmbDepartamento.Size        = new System.Drawing.Size(iw, 28);
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.Items.AddRange(new object[] { "Ventas", "IT", "Recursos Humanos", "Contabilidad" });
            this.cmbDepartamento.SelectedIndex = 0;

            // ── Sueldo base ──────────────────────────────────────────────────
            int r6 = r5 + gap;
            var lS = MkLabel("Sueldo Base ($)", lx, r6);
            this.numSueldoBase.Font     = fntInput;
            this.numSueldoBase.Location = new System.Drawing.Point(ix, r6 + 22);
            this.numSueldoBase.Size     = new System.Drawing.Size(iw, 28);
            this.numSueldoBase.Minimum  = 1000;
            this.numSueldoBase.Maximum  = 10000;
            this.numSueldoBase.Value    = 1000;
            this.numSueldoBase.DecimalPlaces = 2;
            this.numSueldoBase.ThousandsSeparator = true;

            // ── Resultado ────────────────────────────────────────────────────
            int r7 = r6 + gap;
            this.lblResultadoSueldo.Font      = new System.Drawing.Font("Segoe UI", 10f);
            this.lblResultadoSueldo.ForeColor = System.Drawing.Color.FromArgb(0, 140, 60);
            this.lblResultadoSueldo.Location  = new System.Drawing.Point(ix, r7 + 10);
            this.lblResultadoSueldo.Size      = new System.Drawing.Size(iw, 46);
            this.lblResultadoSueldo.AutoSize  = false;

            // ── Botones ──────────────────────────────────────────────────────
            int r8 = r7 + 60;
            this.btnRegistrar.Text      = "Registrar";
            this.btnRegistrar.Font      = new System.Drawing.Font("Segoe UI", 11f, System.Drawing.FontStyle.Bold);
            this.btnRegistrar.BackColor = accent;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.Location  = new System.Drawing.Point(ix, r8);
            this.btnRegistrar.Size      = new System.Drawing.Size(190, 40);
            this.btnRegistrar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Click    += btnRegistrar_Click;

            this.btnLimpiar.Text      = "Limpiar";
            this.btnLimpiar.Font      = new System.Drawing.Font("Segoe UI", 11f);
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(240, 240, 245);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(180, 180, 200);
            this.btnLimpiar.Location  = new System.Drawing.Point(ix + 200, r8);
            this.btnLimpiar.Size      = new System.Drawing.Size(190, 40);
            this.btnLimpiar.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Click    += btnLimpiar_Click;

            // ── Formulario ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize    = new System.Drawing.Size(460, r8 + 80);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitulo, lN, this.txtNombres,
                lA, this.txtApellidos,
                lE, this.txtEmail,
                lI, this.txtIdentificacion,
                lD, this.cmbDepartamento,
                lS, this.numSueldoBase,
                this.lblResultadoSueldo,
                this.btnRegistrar, this.btnLimpiar
            });
            this.Text            = "Ejercicio 1 — Registro de Empleados";
            this.BackColor       = System.Drawing.Color.FromArgb(250, 250, 255);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)this.numSueldoBase).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox       txtNombres         = null!;
        private System.Windows.Forms.TextBox       txtApellidos       = null!;
        private System.Windows.Forms.TextBox       txtEmail           = null!;
        private System.Windows.Forms.TextBox       txtIdentificacion  = null!;
        private System.Windows.Forms.NumericUpDown numSueldoBase      = null!;
        private System.Windows.Forms.ComboBox      cmbDepartamento    = null!;
        private System.Windows.Forms.Label         lblResultadoSueldo = null!;
        private System.Windows.Forms.Button        btnRegistrar       = null!;
        private System.Windows.Forms.Button        btnLimpiar         = null!;
    }
}
