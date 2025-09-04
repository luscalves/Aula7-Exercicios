namespace Aula7
{
    partial class Exercicio1
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
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDepartamento = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtHoras = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSalario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCadastrar = new ReaLTaiizor.Controls.MaterialButton();
            btnCalcula = new ReaLTaiizor.Controls.MaterialButton();
            btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            btnSair = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome:";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(26, 85);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(449, 48);
            txtNome.TabIndex = 0;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtDepartamento
            // 
            txtDepartamento.AnimateReadOnly = false;
            txtDepartamento.AutoCompleteMode = AutoCompleteMode.None;
            txtDepartamento.AutoCompleteSource = AutoCompleteSource.None;
            txtDepartamento.BackgroundImageLayout = ImageLayout.None;
            txtDepartamento.CharacterCasing = CharacterCasing.Normal;
            txtDepartamento.Depth = 0;
            txtDepartamento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDepartamento.HideSelection = true;
            txtDepartamento.Hint = "Departamento:";
            txtDepartamento.LeadingIcon = null;
            txtDepartamento.Location = new Point(26, 139);
            txtDepartamento.MaxLength = 32767;
            txtDepartamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.PasswordChar = '\0';
            txtDepartamento.PrefixSuffixText = null;
            txtDepartamento.ReadOnly = false;
            txtDepartamento.RightToLeft = RightToLeft.No;
            txtDepartamento.SelectedText = "";
            txtDepartamento.SelectionLength = 0;
            txtDepartamento.SelectionStart = 0;
            txtDepartamento.ShortcutsEnabled = false;
            txtDepartamento.Size = new Size(449, 48);
            txtDepartamento.TabIndex = 1;
            txtDepartamento.TabStop = false;
            txtDepartamento.TextAlign = HorizontalAlignment.Left;
            txtDepartamento.TrailingIcon = null;
            txtDepartamento.UseSystemPasswordChar = false;
            // 
            // txtHoras
            // 
            txtHoras.AnimateReadOnly = false;
            txtHoras.AutoCompleteMode = AutoCompleteMode.None;
            txtHoras.AutoCompleteSource = AutoCompleteSource.None;
            txtHoras.BackgroundImageLayout = ImageLayout.None;
            txtHoras.CharacterCasing = CharacterCasing.Normal;
            txtHoras.Depth = 0;
            txtHoras.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtHoras.HideSelection = true;
            txtHoras.Hint = "Horas trabalhadas:";
            txtHoras.LeadingIcon = null;
            txtHoras.Location = new Point(26, 193);
            txtHoras.MaxLength = 32767;
            txtHoras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtHoras.Name = "txtHoras";
            txtHoras.PasswordChar = '\0';
            txtHoras.PrefixSuffixText = null;
            txtHoras.ReadOnly = false;
            txtHoras.RightToLeft = RightToLeft.No;
            txtHoras.SelectedText = "";
            txtHoras.SelectionLength = 0;
            txtHoras.SelectionStart = 0;
            txtHoras.ShortcutsEnabled = true;
            txtHoras.Size = new Size(449, 48);
            txtHoras.TabIndex = 2;
            txtHoras.TabStop = false;
            txtHoras.TextAlign = HorizontalAlignment.Left;
            txtHoras.TrailingIcon = null;
            txtHoras.UseSystemPasswordChar = false;
            // 
            // txtSalario
            // 
            txtSalario.AnimateReadOnly = false;
            txtSalario.AutoCompleteMode = AutoCompleteMode.None;
            txtSalario.AutoCompleteSource = AutoCompleteSource.None;
            txtSalario.BackgroundImageLayout = ImageLayout.None;
            txtSalario.CharacterCasing = CharacterCasing.Normal;
            txtSalario.Depth = 0;
            txtSalario.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSalario.HideSelection = true;
            txtSalario.Hint = "Salário por hora:";
            txtSalario.LeadingIcon = null;
            txtSalario.Location = new Point(26, 247);
            txtSalario.MaxLength = 32767;
            txtSalario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSalario.Name = "txtSalario";
            txtSalario.PasswordChar = '\0';
            txtSalario.PrefixSuffix = ReaLTaiizor.Controls.MaterialTextBoxEdit.PrefixSuffixTypes.Prefix;
            txtSalario.PrefixSuffixText = null;
            txtSalario.ReadOnly = false;
            txtSalario.RightToLeft = RightToLeft.No;
            txtSalario.SelectedText = "";
            txtSalario.SelectionLength = 0;
            txtSalario.SelectionStart = 0;
            txtSalario.ShortcutsEnabled = true;
            txtSalario.Size = new Size(449, 48);
            txtSalario.TabIndex = 3;
            txtSalario.TabStop = false;
            txtSalario.TextAlign = HorizontalAlignment.Left;
            txtSalario.TrailingIcon = null;
            txtSalario.UseSystemPasswordChar = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCadastrar.Location = new Point(39, 318);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(106, 36);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCalcula
            // 
            btnCalcula.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalcula.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCalcula.Depth = 0;
            btnCalcula.HighEmphasis = true;
            btnCalcula.Icon = null;
            btnCalcula.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCalcula.Location = new Point(153, 318);
            btnCalcula.Margin = new Padding(4, 6, 4, 6);
            btnCalcula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCalcula.Name = "btnCalcula";
            btnCalcula.NoAccentTextColor = Color.Empty;
            btnCalcula.Size = new Size(95, 36);
            btnCalcula.TabIndex = 5;
            btnCalcula.Text = "Calcular";
            btnCalcula.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCalcula.UseAccentColor = false;
            btnCalcula.UseVisualStyleBackColor = true;
            btnCalcula.Click += btnCalcula_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnImprimir.Location = new Point(256, 318);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(87, 36);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "Imprimir";
            btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnSair
            // 
            btnSair.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSair.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSair.Depth = 0;
            btnSair.HighEmphasis = true;
            btnSair.Icon = null;
            btnSair.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSair.Location = new Point(351, 318);
            btnSair.Margin = new Padding(4, 6, 4, 6);
            btnSair.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSair.Name = "btnSair";
            btnSair.NoAccentTextColor = Color.Empty;
            btnSair.Size = new Size(64, 36);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSair.UseAccentColor = false;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Exercicio1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 426);
            Controls.Add(btnSair);
            Controls.Add(btnImprimir);
            Controls.Add(btnCalcula);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSalario);
            Controls.Add(txtHoras);
            Controls.Add(txtDepartamento);
            Controls.Add(txtNome);
            Name = "Exercicio1";
            Text = "Página do Empregado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtHoras;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSalario;
        public ReaLTaiizor.Controls.MaterialTextBoxEdit txtDepartamento;
        private ReaLTaiizor.Controls.MaterialButton btnCadastrar;
        private ReaLTaiizor.Controls.MaterialButton btnCalcula;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnSair;
    }
}
