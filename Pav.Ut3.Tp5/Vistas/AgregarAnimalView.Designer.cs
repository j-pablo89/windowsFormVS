namespace Pav.Ut3.Tp5.Vistas
{
    partial class AgregarAnimalView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblEspecie = new Label();
            cbEspecie = new ComboBox();
            especieBindingSource = new BindingSource(components);
            txtEdad = new TextBox();
            lblEdad = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            paisBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            lbSectores = new CheckedListBox();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)especieBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paisBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 9);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(txtNombre, 3);
            txtNombre.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(12, 32);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(520, 34);
            txtNombre.TabIndex = 1;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecie.Location = new Point(12, 60);
            lblEspecie.Margin = new Padding(2, 0, 2, 0);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(75, 21);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Especie";
            // 
            // cbEspecie
            // 
            cbEspecie.DataSource = especieBindingSource;
            cbEspecie.DisplayMember = "Nombre";
            cbEspecie.Dock = DockStyle.Fill;
            cbEspecie.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbEspecie.FormattingEnabled = true;
            cbEspecie.Location = new Point(12, 83);
            cbEspecie.Margin = new Padding(2);
            cbEspecie.Name = "cbEspecie";
            cbEspecie.Size = new Size(251, 36);
            cbEspecie.TabIndex = 3;
            cbEspecie.ValueMember = "Codigo";
            cbEspecie.SelectedIndexChanged += cbEspecie_SelectedIndexChanged;
            // 
            // txtEdad
            // 
            txtEdad.Dock = DockStyle.Fill;
            txtEdad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(281, 83);
            txtEdad.Margin = new Padding(2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(251, 34);
            txtEdad.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEdad.Location = new Point(478, 60);
            lblEdad.Margin = new Padding(2, 0, 2, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(54, 21);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 6);
            tableLayoutPanel1.Controls.Add(lblNombre, 1, 1);
            tableLayoutPanel1.Controls.Add(lblEdad, 3, 3);
            tableLayoutPanel1.Controls.Add(txtEdad, 3, 4);
            tableLayoutPanel1.Controls.Add(txtNombre, 1, 2);
            tableLayoutPanel1.Controls.Add(cbEspecie, 1, 4);
            tableLayoutPanel1.Controls.Add(lblEspecie, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 5);
            tableLayoutPanel1.Controls.Add(label2, 3, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 3, 6);
            tableLayoutPanel1.Controls.Add(label3, 1, 7);
            tableLayoutPanel1.Controls.Add(lbSectores, 1, 8);
            tableLayoutPanel1.Controls.Add(panel1, 3, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 9F));
            tableLayoutPanel1.Size = new Size(545, 326);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = paisBindingSource;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 134);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(251, 36);
            comboBox1.TabIndex = 8;
            comboBox1.ValueMember = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 111);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 21);
            label1.TabIndex = 6;
            label1.Text = "País de Origen";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(481, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 21);
            label2.TabIndex = 7;
            label2.Text = "Peso";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(281, 134);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 34);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 162);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 10;
            label3.Text = "Sectores";
            // 
            // lbSectores
            // 
            lbSectores.Dock = DockStyle.Fill;
            lbSectores.FormattingEnabled = true;
            lbSectores.Location = new Point(12, 185);
            lbSectores.Margin = new Padding(2);
            lbSectores.Name = "lbSectores";
            lbSectores.Size = new Size(251, 130);
            lbSectores.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(281, 185);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 130);
            panel1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(88, 86);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(78, 20);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(88, 23);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AgregarAnimalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(545, 326);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            Name = "AgregarAnimalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarAnimalView";
            Load += AgregarAnimalView_Load;
            ((System.ComponentModel.ISupportInitialize)especieBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)paisBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEspecie;
        private ComboBox cbEspecie;
        private TextBox txtEdad;
        private Label lblEdad;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private CheckedListBox lbSectores;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private BindingSource especieBindingSource;
        private BindingSource paisBindingSource;
    }
}