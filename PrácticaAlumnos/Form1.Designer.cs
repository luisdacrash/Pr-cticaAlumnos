namespace PrácticaAlumnos
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlumnosAlta = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GuardarAlta = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AlumnosListar = new System.Windows.Forms.Panel();
            this.ListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSet = new PrácticaAlumnos.practicaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.AlumnosModificar = new System.Windows.Forms.Panel();
            this.GuardarModificar = new System.Windows.Forms.Button();
            this.ListadoModificar = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.AlumnosEliminar = new System.Windows.Forms.Panel();
            this.GuardarEliminar = new System.Windows.Forms.Button();
            this.ListadoEliminar = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.alumnosTableAdapter = new PrácticaAlumnos.practicaDataSetTableAdapters.AlumnosTableAdapter();
            this.EvaluacionesAlta = new System.Windows.Forms.Panel();
            this.GuardarAltaEvaluacion = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.EvaluacionesListar = new System.Windows.Forms.Panel();
            this.ListadoEvaluaciones = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionesTableAdapter = new PrácticaAlumnos.practicaDataSetTableAdapters.EvaluacionesTableAdapter();
            this.evaluacionesNotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasTableAdapter = new PrácticaAlumnos.practicaDataSetTableAdapters.NotasTableAdapter();
            this.EvaluacionModificar = new System.Windows.Forms.Panel();
            this.GuardarEvaluacionModificar = new System.Windows.Forms.Button();
            this.DescripcionEvaluacion = new System.Windows.Forms.TextBox();
            this.SeleccionEvaluacion = new System.Windows.Forms.ComboBox();
            this.EvaluacionEliminar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SeleccionEliminar = new System.Windows.Forms.ComboBox();
            this.NotasConsultar = new System.Windows.Forms.Panel();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.ListadoNotas = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SeleccionEvaluacionNotas = new System.Windows.Forms.ComboBox();
            this.TodosCheckBox = new System.Windows.Forms.CheckBox();
            this.AlumnosNotas = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.AlumnosAlta.SuspendLayout();
            this.AlumnosListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).BeginInit();
            this.AlumnosModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoModificar)).BeginInit();
            this.AlumnosEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEliminar)).BeginInit();
            this.EvaluacionesAlta.SuspendLayout();
            this.EvaluacionesListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEvaluaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesNotasBindingSource)).BeginInit();
            this.EvaluacionModificar.SuspendLayout();
            this.EvaluacionEliminar.SuspendLayout();
            this.NotasConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaAlumnosToolStripMenuItem,
            this.listarAlumnosToolStripMenuItem,
            this.modificarAlumnosToolStripMenuItem,
            this.eliminarAlumnosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // altaAlumnosToolStripMenuItem
            // 
            this.altaAlumnosToolStripMenuItem.Name = "altaAlumnosToolStripMenuItem";
            this.altaAlumnosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.altaAlumnosToolStripMenuItem.Text = "Alta";
            this.altaAlumnosToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnosToolStripMenuItem_Click);
            // 
            // listarAlumnosToolStripMenuItem
            // 
            this.listarAlumnosToolStripMenuItem.Name = "listarAlumnosToolStripMenuItem";
            this.listarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.listarAlumnosToolStripMenuItem.Text = "Listar";
            this.listarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.listarAlumnosToolStripMenuItem_Click);
            // 
            // modificarAlumnosToolStripMenuItem
            // 
            this.modificarAlumnosToolStripMenuItem.Name = "modificarAlumnosToolStripMenuItem";
            this.modificarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarAlumnosToolStripMenuItem.Text = "Modificar";
            this.modificarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.modificarAlumnosToolStripMenuItem_Click);
            // 
            // eliminarAlumnosToolStripMenuItem
            // 
            this.eliminarAlumnosToolStripMenuItem.Name = "eliminarAlumnosToolStripMenuItem";
            this.eliminarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarAlumnosToolStripMenuItem.Text = "Eliminar";
            this.eliminarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlumnosToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaEvaluacionToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarEvaluacionToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarEvaluacionToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarEvaluacionToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // AlumnosAlta
            // 
            this.AlumnosAlta.Controls.Add(this.label7);
            this.AlumnosAlta.Controls.Add(this.label6);
            this.AlumnosAlta.Controls.Add(this.label5);
            this.AlumnosAlta.Controls.Add(this.GuardarAlta);
            this.AlumnosAlta.Controls.Add(this.checkBox1);
            this.AlumnosAlta.Controls.Add(this.textBox3);
            this.AlumnosAlta.Controls.Add(this.textBox2);
            this.AlumnosAlta.Controls.Add(this.textBox1);
            this.AlumnosAlta.Controls.Add(this.label1);
            this.AlumnosAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlumnosAlta.Location = new System.Drawing.Point(0, 24);
            this.AlumnosAlta.Name = "AlumnosAlta";
            this.AlumnosAlta.Size = new System.Drawing.Size(800, 426);
            this.AlumnosAlta.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nif";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // GuardarAlta
            // 
            this.GuardarAlta.Location = new System.Drawing.Point(73, 194);
            this.GuardarAlta.Name = "GuardarAlta";
            this.GuardarAlta.Size = new System.Drawing.Size(75, 23);
            this.GuardarAlta.TabIndex = 5;
            this.GuardarAlta.Text = "Guardar";
            this.GuardarAlta.UseVisualStyleBackColor = true;
            this.GuardarAlta.Click += new System.EventHandler(this.guardarAlta_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(73, 155);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(47, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Baja";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos Alta";
            // 
            // AlumnosListar
            // 
            this.AlumnosListar.Controls.Add(this.ListadoAlumnos);
            this.AlumnosListar.Controls.Add(this.label2);
            this.AlumnosListar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlumnosListar.Location = new System.Drawing.Point(0, 24);
            this.AlumnosListar.Name = "AlumnosListar";
            this.AlumnosListar.Size = new System.Drawing.Size(800, 426);
            this.AlumnosListar.TabIndex = 2;
            // 
            // ListadoAlumnos
            // 
            this.ListadoAlumnos.AllowUserToAddRows = false;
            this.ListadoAlumnos.AllowUserToDeleteRows = false;
            this.ListadoAlumnos.AllowUserToOrderColumns = true;
            this.ListadoAlumnos.AutoGenerateColumns = false;
            this.ListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.bajaDataGridViewCheckBoxColumn});
            this.ListadoAlumnos.DataSource = this.alumnosBindingSource;
            this.ListadoAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoAlumnos.Location = new System.Drawing.Point(0, 0);
            this.ListadoAlumnos.Name = "ListadoAlumnos";
            this.ListadoAlumnos.ReadOnly = true;
            this.ListadoAlumnos.Size = new System.Drawing.Size(800, 426);
            this.ListadoAlumnos.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bajaDataGridViewCheckBoxColumn
            // 
            this.bajaDataGridViewCheckBoxColumn.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn.Name = "bajaDataGridViewCheckBoxColumn";
            this.bajaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.practicaDataSetBindingSource;
            // 
            // practicaDataSetBindingSource
            // 
            this.practicaDataSetBindingSource.DataSource = this.practicaDataSet;
            this.practicaDataSetBindingSource.Position = 0;
            // 
            // practicaDataSet
            // 
            this.practicaDataSet.DataSetName = "practicaDataSet";
            this.practicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alumnos Listar";
            // 
            // AlumnosModificar
            // 
            this.AlumnosModificar.Controls.Add(this.GuardarModificar);
            this.AlumnosModificar.Controls.Add(this.ListadoModificar);
            this.AlumnosModificar.Controls.Add(this.label3);
            this.AlumnosModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlumnosModificar.Location = new System.Drawing.Point(0, 24);
            this.AlumnosModificar.Name = "AlumnosModificar";
            this.AlumnosModificar.Size = new System.Drawing.Size(800, 426);
            this.AlumnosModificar.TabIndex = 3;
            // 
            // GuardarModificar
            // 
            this.GuardarModificar.Location = new System.Drawing.Point(713, 378);
            this.GuardarModificar.Name = "GuardarModificar";
            this.GuardarModificar.Size = new System.Drawing.Size(75, 23);
            this.GuardarModificar.TabIndex = 6;
            this.GuardarModificar.Text = "Guardar";
            this.GuardarModificar.UseVisualStyleBackColor = true;
            this.GuardarModificar.Click += new System.EventHandler(this.GuardarModificar_Click);
            // 
            // ListadoModificar
            // 
            this.ListadoModificar.AllowUserToAddRows = false;
            this.ListadoModificar.AllowUserToDeleteRows = false;
            this.ListadoModificar.AllowUserToOrderColumns = true;
            this.ListadoModificar.AutoGenerateColumns = false;
            this.ListadoModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidosDataGridViewTextBoxColumn1,
            this.nIFDataGridViewTextBoxColumn1,
            this.bajaDataGridViewCheckBoxColumn1});
            this.ListadoModificar.DataSource = this.alumnosBindingSource;
            this.ListadoModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoModificar.Location = new System.Drawing.Point(0, 0);
            this.ListadoModificar.Name = "ListadoModificar";
            this.ListadoModificar.Size = new System.Drawing.Size(800, 426);
            this.ListadoModificar.TabIndex = 1;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // apellidosDataGridViewTextBoxColumn1
            // 
            this.apellidosDataGridViewTextBoxColumn1.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn1.Name = "apellidosDataGridViewTextBoxColumn1";
            // 
            // nIFDataGridViewTextBoxColumn1
            // 
            this.nIFDataGridViewTextBoxColumn1.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn1.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn1.Name = "nIFDataGridViewTextBoxColumn1";
            // 
            // bajaDataGridViewCheckBoxColumn1
            // 
            this.bajaDataGridViewCheckBoxColumn1.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn1.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn1.Name = "bajaDataGridViewCheckBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alumnos Modificar";
            // 
            // AlumnosEliminar
            // 
            this.AlumnosEliminar.Controls.Add(this.GuardarEliminar);
            this.AlumnosEliminar.Controls.Add(this.ListadoEliminar);
            this.AlumnosEliminar.Controls.Add(this.label4);
            this.AlumnosEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlumnosEliminar.Location = new System.Drawing.Point(0, 24);
            this.AlumnosEliminar.Name = "AlumnosEliminar";
            this.AlumnosEliminar.Size = new System.Drawing.Size(800, 426);
            this.AlumnosEliminar.TabIndex = 4;
            // 
            // GuardarEliminar
            // 
            this.GuardarEliminar.Location = new System.Drawing.Point(713, 391);
            this.GuardarEliminar.Name = "GuardarEliminar";
            this.GuardarEliminar.Size = new System.Drawing.Size(75, 23);
            this.GuardarEliminar.TabIndex = 7;
            this.GuardarEliminar.Text = "Eliminar";
            this.GuardarEliminar.UseVisualStyleBackColor = true;
            this.GuardarEliminar.Click += new System.EventHandler(this.GuardarEliminar_Click);
            // 
            // ListadoEliminar
            // 
            this.ListadoEliminar.AllowUserToAddRows = false;
            this.ListadoEliminar.AutoGenerateColumns = false;
            this.ListadoEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nombreDataGridViewTextBoxColumn2,
            this.apellidosDataGridViewTextBoxColumn2,
            this.nIFDataGridViewTextBoxColumn2,
            this.bajaDataGridViewCheckBoxColumn2});
            this.ListadoEliminar.DataSource = this.alumnosBindingSource;
            this.ListadoEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoEliminar.Location = new System.Drawing.Point(0, 0);
            this.ListadoEliminar.Name = "ListadoEliminar";
            this.ListadoEliminar.ReadOnly = true;
            this.ListadoEliminar.Size = new System.Drawing.Size(800, 426);
            this.ListadoEliminar.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn2
            // 
            this.nombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn2.Name = "nombreDataGridViewTextBoxColumn2";
            this.nombreDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn2
            // 
            this.apellidosDataGridViewTextBoxColumn2.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn2.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn2.Name = "apellidosDataGridViewTextBoxColumn2";
            this.apellidosDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nIFDataGridViewTextBoxColumn2
            // 
            this.nIFDataGridViewTextBoxColumn2.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn2.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn2.Name = "nIFDataGridViewTextBoxColumn2";
            this.nIFDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // bajaDataGridViewCheckBoxColumn2
            // 
            this.bajaDataGridViewCheckBoxColumn2.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn2.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn2.Name = "bajaDataGridViewCheckBoxColumn2";
            this.bajaDataGridViewCheckBoxColumn2.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alumnos Eliminar";
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // EvaluacionesAlta
            // 
            this.EvaluacionesAlta.Controls.Add(this.GuardarAltaEvaluacion);
            this.EvaluacionesAlta.Controls.Add(this.label8);
            this.EvaluacionesAlta.Controls.Add(this.descripcionTextBox);
            this.EvaluacionesAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluacionesAlta.Location = new System.Drawing.Point(0, 24);
            this.EvaluacionesAlta.Name = "EvaluacionesAlta";
            this.EvaluacionesAlta.Size = new System.Drawing.Size(800, 426);
            this.EvaluacionesAlta.TabIndex = 2;
            // 
            // GuardarAltaEvaluacion
            // 
            this.GuardarAltaEvaluacion.Location = new System.Drawing.Point(705, 378);
            this.GuardarAltaEvaluacion.Name = "GuardarAltaEvaluacion";
            this.GuardarAltaEvaluacion.Size = new System.Drawing.Size(75, 23);
            this.GuardarAltaEvaluacion.TabIndex = 6;
            this.GuardarAltaEvaluacion.Text = "Guardar";
            this.GuardarAltaEvaluacion.UseVisualStyleBackColor = true;
            this.GuardarAltaEvaluacion.Click += new System.EventHandler(this.GuardarAltaEvaluacion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Descripción";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(26, 41);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(636, 316);
            this.descripcionTextBox.TabIndex = 0;
            // 
            // EvaluacionesListar
            // 
            this.EvaluacionesListar.Controls.Add(this.ListadoEvaluaciones);
            this.EvaluacionesListar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluacionesListar.Location = new System.Drawing.Point(0, 24);
            this.EvaluacionesListar.Name = "EvaluacionesListar";
            this.EvaluacionesListar.Size = new System.Drawing.Size(800, 426);
            this.EvaluacionesListar.TabIndex = 7;
            // 
            // ListadoEvaluaciones
            // 
            this.ListadoEvaluaciones.AllowUserToAddRows = false;
            this.ListadoEvaluaciones.AllowUserToDeleteRows = false;
            this.ListadoEvaluaciones.AllowUserToOrderColumns = true;
            this.ListadoEvaluaciones.AutoGenerateColumns = false;
            this.ListadoEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoEvaluaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.evaluacionDataGridViewTextBoxColumn});
            this.ListadoEvaluaciones.DataSource = this.evaluacionesBindingSource;
            this.ListadoEvaluaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListadoEvaluaciones.Location = new System.Drawing.Point(0, 0);
            this.ListadoEvaluaciones.Name = "ListadoEvaluaciones";
            this.ListadoEvaluaciones.ReadOnly = true;
            this.ListadoEvaluaciones.Size = new System.Drawing.Size(800, 426);
            this.ListadoEvaluaciones.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // evaluacionDataGridViewTextBoxColumn
            // 
            this.evaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.Name = "evaluacionDataGridViewTextBoxColumn";
            this.evaluacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluacionesBindingSource
            // 
            this.evaluacionesBindingSource.DataMember = "Evaluaciones";
            this.evaluacionesBindingSource.DataSource = this.practicaDataSetBindingSource;
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
            // 
            // evaluacionesNotasBindingSource
            // 
            this.evaluacionesNotasBindingSource.DataMember = "EvaluacionesNotas";
            this.evaluacionesNotasBindingSource.DataSource = this.evaluacionesBindingSource;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // EvaluacionModificar
            // 
            this.EvaluacionModificar.Controls.Add(this.GuardarEvaluacionModificar);
            this.EvaluacionModificar.Controls.Add(this.DescripcionEvaluacion);
            this.EvaluacionModificar.Controls.Add(this.SeleccionEvaluacion);
            this.EvaluacionModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluacionModificar.Location = new System.Drawing.Point(0, 24);
            this.EvaluacionModificar.Name = "EvaluacionModificar";
            this.EvaluacionModificar.Size = new System.Drawing.Size(800, 426);
            this.EvaluacionModificar.TabIndex = 1;
            // 
            // GuardarEvaluacionModificar
            // 
            this.GuardarEvaluacionModificar.Location = new System.Drawing.Point(713, 378);
            this.GuardarEvaluacionModificar.Name = "GuardarEvaluacionModificar";
            this.GuardarEvaluacionModificar.Size = new System.Drawing.Size(75, 23);
            this.GuardarEvaluacionModificar.TabIndex = 7;
            this.GuardarEvaluacionModificar.Text = "Guardar";
            this.GuardarEvaluacionModificar.UseVisualStyleBackColor = true;
            this.GuardarEvaluacionModificar.Click += new System.EventHandler(this.GuardarEvaluacionModificar_Click);
            // 
            // DescripcionEvaluacion
            // 
            this.DescripcionEvaluacion.Location = new System.Drawing.Point(26, 50);
            this.DescripcionEvaluacion.Multiline = true;
            this.DescripcionEvaluacion.Name = "DescripcionEvaluacion";
            this.DescripcionEvaluacion.Size = new System.Drawing.Size(673, 351);
            this.DescripcionEvaluacion.TabIndex = 1;
            // 
            // SeleccionEvaluacion
            // 
            this.SeleccionEvaluacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.evaluacionesBindingSource, "Evaluacion", true));
            this.SeleccionEvaluacion.DataSource = this.evaluacionesBindingSource;
            this.SeleccionEvaluacion.DisplayMember = "Evaluacion";
            this.SeleccionEvaluacion.FormattingEnabled = true;
            this.SeleccionEvaluacion.Location = new System.Drawing.Point(26, 21);
            this.SeleccionEvaluacion.Name = "SeleccionEvaluacion";
            this.SeleccionEvaluacion.Size = new System.Drawing.Size(147, 21);
            this.SeleccionEvaluacion.TabIndex = 0;
            this.SeleccionEvaluacion.ValueMember = "Evaluacion";
            this.SeleccionEvaluacion.SelectedIndexChanged += new System.EventHandler(this.SeleccionEvaluacion_SelectedIndexChanged);
            // 
            // EvaluacionEliminar
            // 
            this.EvaluacionEliminar.Controls.Add(this.button1);
            this.EvaluacionEliminar.Controls.Add(this.SeleccionEliminar);
            this.EvaluacionEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EvaluacionEliminar.Location = new System.Drawing.Point(0, 24);
            this.EvaluacionEliminar.Name = "EvaluacionEliminar";
            this.EvaluacionEliminar.Size = new System.Drawing.Size(800, 426);
            this.EvaluacionEliminar.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeleccionEliminar
            // 
            this.SeleccionEliminar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.evaluacionesBindingSource, "Evaluacion", true));
            this.SeleccionEliminar.DataSource = this.evaluacionesBindingSource;
            this.SeleccionEliminar.DisplayMember = "Evaluacion";
            this.SeleccionEliminar.FormattingEnabled = true;
            this.SeleccionEliminar.Location = new System.Drawing.Point(26, 16);
            this.SeleccionEliminar.Name = "SeleccionEliminar";
            this.SeleccionEliminar.Size = new System.Drawing.Size(215, 21);
            this.SeleccionEliminar.TabIndex = 0;
            this.SeleccionEliminar.ValueMember = "Evaluacion";
            // 
            // NotasConsultar
            // 
            this.NotasConsultar.Controls.Add(this.Eliminar);
            this.NotasConsultar.Controls.Add(this.Modificar);
            this.NotasConsultar.Controls.Add(this.Agregar);
            this.NotasConsultar.Controls.Add(this.Guardar);
            this.NotasConsultar.Controls.Add(this.Buscar);
            this.NotasConsultar.Controls.Add(this.ListadoNotas);
            this.NotasConsultar.Controls.Add(this.SeleccionEvaluacionNotas);
            this.NotasConsultar.Controls.Add(this.TodosCheckBox);
            this.NotasConsultar.Controls.Add(this.AlumnosNotas);
            this.NotasConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotasConsultar.Location = new System.Drawing.Point(0, 24);
            this.NotasConsultar.Name = "NotasConsultar";
            this.NotasConsultar.Size = new System.Drawing.Size(800, 426);
            this.NotasConsultar.TabIndex = 9;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(713, 386);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 7;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(549, 386);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 6;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(395, 386);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 5;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(245, 386);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 4;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(713, 38);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 8;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ListadoNotas
            // 
            this.ListadoNotas.AllowUserToAddRows = false;
            this.ListadoNotas.AllowUserToDeleteRows = false;
            this.ListadoNotas.AllowUserToOrderColumns = true;
            this.ListadoNotas.AutoGenerateColumns = false;
            this.ListadoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.idEvaluacionDataGridViewTextBoxColumn,
            this.dIDataGridViewTextBoxColumn,
            this.pMDMDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn});
            this.ListadoNotas.DataSource = this.notasBindingSource;
            this.ListadoNotas.Location = new System.Drawing.Point(245, 73);
            this.ListadoNotas.Name = "ListadoNotas";
            this.ListadoNotas.Size = new System.Drawing.Size(543, 299);
            this.ListadoNotas.TabIndex = 3;
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            // 
            // idEvaluacionDataGridViewTextBoxColumn
            // 
            this.idEvaluacionDataGridViewTextBoxColumn.DataPropertyName = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.HeaderText = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.Name = "idEvaluacionDataGridViewTextBoxColumn";
            // 
            // dIDataGridViewTextBoxColumn
            // 
            this.dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            this.dIDataGridViewTextBoxColumn.HeaderText = "DI";
            this.dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            // 
            // pMDMDataGridViewTextBoxColumn
            // 
            this.pMDMDataGridViewTextBoxColumn.DataPropertyName = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.HeaderText = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.Name = "pMDMDataGridViewTextBoxColumn";
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.practicaDataSetBindingSource;
            // 
            // SeleccionEvaluacionNotas
            // 
            this.SeleccionEvaluacionNotas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.evaluacionesBindingSource, "Evaluacion", true));
            this.SeleccionEvaluacionNotas.DataSource = this.evaluacionesBindingSource;
            this.SeleccionEvaluacionNotas.DisplayMember = "Evaluacion";
            this.SeleccionEvaluacionNotas.FormattingEnabled = true;
            this.SeleccionEvaluacionNotas.Location = new System.Drawing.Point(245, 38);
            this.SeleccionEvaluacionNotas.Name = "SeleccionEvaluacionNotas";
            this.SeleccionEvaluacionNotas.Size = new System.Drawing.Size(383, 21);
            this.SeleccionEvaluacionNotas.TabIndex = 2;
            this.SeleccionEvaluacionNotas.ValueMember = "Evaluacion";
            // 
            // TodosCheckBox
            // 
            this.TodosCheckBox.AutoSize = true;
            this.TodosCheckBox.Location = new System.Drawing.Point(12, 16);
            this.TodosCheckBox.Name = "TodosCheckBox";
            this.TodosCheckBox.Size = new System.Drawing.Size(56, 17);
            this.TodosCheckBox.TabIndex = 1;
            this.TodosCheckBox.Text = "Todos";
            this.TodosCheckBox.UseVisualStyleBackColor = true;
            this.TodosCheckBox.CheckedChanged += new System.EventHandler(this.TodosCheckBox_CheckedChanged);
            // 
            // AlumnosNotas
            // 
            this.AlumnosNotas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.alumnosBindingSource, "Id", true));
            this.AlumnosNotas.DataSource = this.alumnosBindingSource;
            this.AlumnosNotas.DisplayMember = "Id";
            this.AlumnosNotas.FormattingEnabled = true;
            this.AlumnosNotas.Location = new System.Drawing.Point(12, 38);
            this.AlumnosNotas.Name = "AlumnosNotas";
            this.AlumnosNotas.Size = new System.Drawing.Size(194, 368);
            this.AlumnosNotas.TabIndex = 0;
            this.AlumnosNotas.ValueMember = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotasConsultar);
            this.Controls.Add(this.EvaluacionEliminar);
            this.Controls.Add(this.EvaluacionModificar);
            this.Controls.Add(this.EvaluacionesListar);
            this.Controls.Add(this.EvaluacionesAlta);
            this.Controls.Add(this.AlumnosListar);
            this.Controls.Add(this.AlumnosModificar);
            this.Controls.Add(this.AlumnosEliminar);
            this.Controls.Add(this.AlumnosAlta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AlumnosAlta.ResumeLayout(false);
            this.AlumnosAlta.PerformLayout();
            this.AlumnosListar.ResumeLayout(false);
            this.AlumnosListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).EndInit();
            this.AlumnosModificar.ResumeLayout(false);
            this.AlumnosModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoModificar)).EndInit();
            this.AlumnosEliminar.ResumeLayout(false);
            this.AlumnosEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEliminar)).EndInit();
            this.EvaluacionesAlta.ResumeLayout(false);
            this.EvaluacionesAlta.PerformLayout();
            this.EvaluacionesListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoEvaluaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesNotasBindingSource)).EndInit();
            this.EvaluacionModificar.ResumeLayout(false);
            this.EvaluacionModificar.PerformLayout();
            this.EvaluacionEliminar.ResumeLayout(false);
            this.NotasConsultar.ResumeLayout(false);
            this.NotasConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.Panel AlumnosAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AlumnosListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AlumnosModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel AlumnosEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GuardarAlta;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ListadoAlumnos;
        private System.Windows.Forms.BindingSource practicaDataSetBindingSource;
        private practicaDataSet practicaDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private practicaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.DataGridView ListadoModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button GuardarModificar;
        private System.Windows.Forms.DataGridView ListadoEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.Button GuardarEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Panel EvaluacionesAlta;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GuardarAltaEvaluacion;
        private System.Windows.Forms.Panel EvaluacionesListar;
        private System.Windows.Forms.DataGridView ListadoEvaluaciones;
        private System.Windows.Forms.BindingSource evaluacionesBindingSource;
        private practicaDataSetTableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private System.Windows.Forms.BindingSource evaluacionesNotasBindingSource;
        private practicaDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel EvaluacionModificar;
        private System.Windows.Forms.ComboBox SeleccionEvaluacion;
        private System.Windows.Forms.TextBox DescripcionEvaluacion;
        private System.Windows.Forms.Button GuardarEvaluacionModificar;
        private System.Windows.Forms.Panel EvaluacionEliminar;
        private System.Windows.Forms.ComboBox SeleccionEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel NotasConsultar;
        private System.Windows.Forms.ListBox AlumnosNotas;
        private System.Windows.Forms.CheckBox TodosCheckBox;
        private System.Windows.Forms.ComboBox SeleccionEvaluacionNotas;
        private System.Windows.Forms.DataGridView ListadoNotas;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Buscar;
    }
}

