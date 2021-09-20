
namespace MiCalculadora
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.btnABinario = new System.Windows.Forms.Button();
            this.cboOperador = new System.Windows.Forms.ComboBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnADecimal = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNumeroUno
            // 
            resources.ApplyResources(this.txtNumeroUno, "txtNumeroUno");
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumericos);
            // 
            // btnABinario
            // 
            resources.ApplyResources(this.btnABinario, "btnABinario");
            this.btnABinario.Name = "btnABinario";
            this.btnABinario.UseVisualStyleBackColor = true;
            this.btnABinario.Click += new System.EventHandler(this.btnABinario_Click);
            // 
            // cboOperador
            // 
            this.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboOperador, "cboOperador");
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Items.AddRange(new object[] {
            resources.GetString("cboOperador.Items"),
            resources.GetString("cboOperador.Items1"),
            resources.GetString("cboOperador.Items2"),
            resources.GetString("cboOperador.Items3")});
            this.cboOperador.Name = "cboOperador";
            // 
            // txtNumeroDos
            // 
            resources.ApplyResources(this.txtNumeroDos, "txtNumeroDos");
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumericos);
            // 
            // btnOperar
            // 
            resources.ApplyResources(this.btnOperar, "btnOperar");
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(this.btnLimpiar, "btnLimpiar");
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnADecimal
            // 
            resources.ApplyResources(this.btnADecimal, "btnADecimal");
            this.btnADecimal.Name = "btnADecimal";
            this.btnADecimal.UseVisualStyleBackColor = true;
            this.btnADecimal.Click += new System.EventHandler(this.btnADecimal_Click);
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            // 
            // lstOperaciones
            // 
            resources.ApplyResources(this.lstOperaciones, "lstOperaciones");
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.Name = "lstOperaciones";
            // 
            // FormCalculadora
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnADecimal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.cboOperador);
            this.Controls.Add(this.btnABinario);
            this.Controls.Add(this.txtNumeroUno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.Button btnABinario;
        private System.Windows.Forms.ComboBox cboOperador;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnADecimal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox lstOperaciones;
    }
}

