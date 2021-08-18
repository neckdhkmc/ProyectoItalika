
namespace Capa_Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(622, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(75, 27);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(163, 22);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "0";
            this.txt1.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(75, 67);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(163, 22);
            this.txt2.TabIndex = 2;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(75, 112);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(163, 22);
            this.txt3.TabIndex = 3;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(75, 160);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(163, 22);
            this.txt4.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(26, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 71);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.button1);
            this.gb1.Controls.Add(this.txt3);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.txt1);
            this.gb1.Controls.Add(this.btnEditar);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.txt2);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.txt4);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.btnGuardar);
            this.gb1.Location = new System.Drawing.Point(22, 45);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(622, 351);
            this.gb1.TabIndex = 11;
            this.gb1.TabStop = false;
            this.gb1.Text = "Insertar datos al procedimiento almacenado";
            this.gb1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarDatosToolStripMenuItem,
            this.actualizarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem,
            this.consultarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarDatosToolStripMenuItem
            // 
            this.insertarDatosToolStripMenuItem.Name = "insertarDatosToolStripMenuItem";
            this.insertarDatosToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.insertarDatosToolStripMenuItem.Text = "Insertar Datos";
            this.insertarDatosToolStripMenuItem.Click += new System.EventHandler(this.insertarDatosToolStripMenuItem_Click);
            // 
            // actualizarDatosToolStripMenuItem
            // 
            this.actualizarDatosToolStripMenuItem.Name = "actualizarDatosToolStripMenuItem";
            this.actualizarDatosToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.actualizarDatosToolStripMenuItem.Text = "Actualizar Datos";
            this.actualizarDatosToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosToolStripMenuItem_Click);
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar Datos";
            this.eliminarDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDatosToolStripMenuItem_Click);
            // 
            // consultarDatosToolStripMenuItem
            // 
            this.consultarDatosToolStripMenuItem.Name = "consultarDatosToolStripMenuItem";
            this.consultarDatosToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.consultarDatosToolStripMenuItem.Text = "Consultar Datos";
            this.consultarDatosToolStripMenuItem.Click += new System.EventHandler(this.consultarDatosToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 71);
            this.button1.TabIndex = 20;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(226, 219);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 71);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 685);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditar;
    }
}

