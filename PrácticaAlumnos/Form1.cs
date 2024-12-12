using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrácticaAlumnos
{
    public partial class Form1 : Form
    {

        OleDbCommand miCommand;
        OleDbDataAdapter miAdapter;
        OleDbCommandBuilder miBuilder;
        DataSet miDataSet;
        DataTable miTable;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.practicaDataSet.Notas);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Evaluaciones' Puede moverla o quitarla según sea necesario.
            this.evaluacionesTableAdapter.Fill(this.practicaDataSet.Evaluaciones);
            // TODO: esta línea de código carga datos en la tabla 'practicaDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.practicaDataSet.Alumnos);
            OcultarPaneles();
            AlumnosAlta.Visible = true;
        }

        private void OcultarPaneles()
        {
            ListadoEliminar.SelectionMode = DataGridViewSelectionMode.CellSelect;
            AlumnosEliminar.Visible = false;
            AlumnosAlta.Visible = false;
            AlumnosListar.Visible = false;
            AlumnosModificar.Visible = false;
            EvaluacionesAlta.Visible = false;
            EvaluacionesListar.Visible = false;
            EvaluacionModificar.Visible = false;
            EvaluacionEliminar.Visible = false;
            NotasConsultar.Visible = false;
        }

        //ALUMNOS---------------------------------------------------------------------------
        private void ActualizarListadoAlumnos()
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "SELECT* FROM Alumnos";
            try { 
                OleDbConnection miCnx = new OleDbConnection(conexion);
                miCnx.Open();
                miCommand = new OleDbCommand(sentencia, miCnx);
                miAdapter = new OleDbDataAdapter(miCommand);
                miBuilder = new OleDbCommandBuilder(miAdapter);
                miDataSet = new DataSet();
                miAdapter.Fill(miDataSet, "Alumnos");
                miTable = miDataSet.Tables["Alumnos"];
                miCnx.Close();
                ListadoEliminar.DataSource = miDataSet.Tables[0]; ;
                ListadoModificar.DataSource = miDataSet.Tables[0]; ;
                ListadoAlumnos.DataSource = miDataSet.Tables[0]; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        //Alta de Alumnos
        private void altaAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            AlumnosAlta.Visible = true;
        }

        private void guardarAlta_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string nif = textBox3.Text;
                Boolean baja = false;
                if (checkBox1.Checked)
                {
                    baja = true;
                }
                else
                {
                    baja = false;
                }
                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
                string sentencia = "insert into Alumnos (Nombre,Apellidos,NIF,baja) values ('" + nombre + "','" + apellido + "','" + nif + "'," + baja + ")";
                OleDbConnection miCnx = new OleDbConnection(conexion);
                OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
                miCnx.Open();
                miCmd.ExecuteNonQuery();
                miCnx.Close();
                miCnx.Dispose();
                MessageBox.Show("Guardado Correctamente");
            }
            catch
            {
                MessageBox.Show("Error de Guardado");
            }
        }

        //Listado de Alumnos
        private void listarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoAlumnos();
            AlumnosListar.Visible = true;

        }

        //Modificacion Alumnos
        private void modificarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoAlumnos();
            AlumnosModificar.Visible = true;
        }

        private void GuardarModificar_Click(object sender, EventArgs e)
        {
            
            miAdapter.Update(miTable);
            MessageBox.Show("Cambios Guardados");
        }

        //Eliminar Alumnos
        private void eliminarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoAlumnos();
            ListadoEliminar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AlumnosEliminar.Visible = true;
        }        

        private void GuardarEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar esta fila?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ListadoEliminar.Rows.RemoveAt(ListadoEliminar.SelectedRows[0].Index);
                miAdapter.Update(miTable);
            }
        }


        //EVALUACION-----------------------------------------------------------------------------
        private void ActualizarListadoEvaluaciones()
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "SELECT* FROM Evaluaciones";
            try
            {
                OleDbConnection miCnx = new OleDbConnection(conexion);
                miCnx.Open();
                miCommand = new OleDbCommand(sentencia, miCnx);
                miAdapter = new OleDbDataAdapter(miCommand);
                miBuilder = new OleDbCommandBuilder(miAdapter);
                miDataSet = new DataSet();
                miAdapter.Fill(miDataSet, "Evaluaciones");
                miTable = miDataSet.Tables["Evaluaciones"];
                miCnx.Close();
                SeleccionEliminar.DataSource = miDataSet.Tables[0]; ;
                ListadoEvaluaciones.DataSource = miDataSet.Tables[0];
                SeleccionEvaluacion.DataSource = miDataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        //Alta de Evaluaciones
        private void altaEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            EvaluacionesAlta.Visible = true;
        }

        private void GuardarAltaEvaluacion_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = descripcionTextBox.Text;
                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
                string sentencia = "insert into Evaluaciones (Evaluacion) values ('" + descripcion + "')";
                OleDbConnection miCnx = new OleDbConnection(conexion);
                OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
                miCnx.Open();
                miCmd.ExecuteNonQuery();
                miCnx.Close();
                miCnx.Dispose();
                MessageBox.Show("Guardado Correctamente");
            }
            catch
            {
                MessageBox.Show("Error de Guardado");
            }
        }

        //Listar Evaluaciones
        private void listarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoEvaluaciones();
            EvaluacionesListar.Visible = true;
        }

        //Modificar Evaluaciones
        private void modificarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoEvaluaciones();
            EvaluacionModificar.Visible = true;
        }

        private void SeleccionEvaluacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DescripcionEvaluacion.Text = SeleccionEvaluacion.Text;
        }

        private void GuardarEvaluacionModificar_Click(object sender, EventArgs e)
        {
            string sentencia = "update Evaluaciones set Evaluacion = '" +DescripcionEvaluacion.Text+"' where Id = "+(SeleccionEvaluacion.SelectedIndex+1) +";";
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            OleDbConnection miCnx = new OleDbConnection(conexion);
            OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
            miCnx.Open();
            miCmd.ExecuteNonQuery();
            miCnx.Close();
            ActualizarListadoEvaluaciones();
            MessageBox.Show("Cambios Guardados");
        }

        //Eliminar Evaluaciones
        private void eliminarEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoEvaluaciones();
            EvaluacionEliminar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentencia = "delete from Evaluaciones where Id = " + (SeleccionEliminar.SelectedIndex + 1) + ";";
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            OleDbConnection miCnx = new OleDbConnection(conexion);
            OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
            miCnx.Open();
            miCmd.ExecuteNonQuery();
            miCnx.Close();
            ActualizarListadoEvaluaciones();
            MessageBox.Show("Eliminado Correctamente");
        }


        //NOTAS----------------------------------------------------------------------------------------
        private void ActualizarListadoNotas()
        {
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            string sentenciaNotas = "SELECT* FROM Notas";
            string sentenciaAlumnos = "SELECT* FROM Alumnos";
            string sentenciaEvaluaciones = "SELECT* FROM Evaluaciones";
            try
            {
                OleDbConnection miCnx = new OleDbConnection(conexion);
                miCnx.Open();
                miCommand = new OleDbCommand(sentenciaNotas, miCnx);
                miAdapter = new OleDbDataAdapter(miCommand);
                miBuilder = new OleDbCommandBuilder(miAdapter);
                DataSet miDataSetNotas = new DataSet();
                miAdapter.Fill(miDataSetNotas, "Notas");
                miTable = miDataSetNotas.Tables["Notas"];
                miCnx.Close();

                miCnx = new OleDbConnection(conexion);
                miCnx.Open();
                miCommand = new OleDbCommand(sentenciaAlumnos, miCnx);
                miAdapter = new OleDbDataAdapter(miCommand);
                miBuilder = new OleDbCommandBuilder(miAdapter);
                DataSet miDataSetAlumnos = new DataSet();
                miAdapter.Fill(miDataSetAlumnos, "Alumnos");
                miTable = miDataSetAlumnos.Tables["Alumnos"];
                miCnx.Close();

                miCnx = new OleDbConnection(conexion);
                miCnx.Open();
                miCommand = new OleDbCommand(sentenciaEvaluaciones, miCnx);
                miAdapter = new OleDbDataAdapter(miCommand);
                miBuilder = new OleDbCommandBuilder(miAdapter);
                DataSet miDataSetEvaluaciones = new DataSet();
                miAdapter.Fill(miDataSetEvaluaciones, "Evaluaciones");
                miTable = miDataSetEvaluaciones.Tables["Evaluaciones"];
                miCnx.Close();

                AlumnosNotas.DataSource = miDataSetAlumnos.Tables[0]; ;
                ListadoNotas.DataSource = miDataSetNotas.Tables[0];
                SeleccionEvaluacionNotas.DataSource = miDataSetEvaluaciones.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }

        }

        //Consultar Notas
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            ActualizarListadoNotas();
            NotasConsultar.Visible = true;
        }

        private void TodosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TodosCheckBox.Checked == true)
            {
                AlumnosNotas.Visible = false;
            }else
            {
                ActualizarListadoNotas();
                AlumnosNotas.Visible = true;
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            
            if( ListadoNotas.AllowUserToAddRows == true)
            {
                ListadoNotas.AllowUserToAddRows = false;
                ListadoNotas.ReadOnly = true;
                Modificar.Visible = true;
                Eliminar.Visible = true;
                Buscar.Visible = true;
            }
            else{
                ListadoNotas.AllowUserToAddRows = true;
                ListadoNotas.ReadOnly = false;
                Modificar.Visible = false;
                Eliminar.Visible = false;
                Buscar.Visible = false;
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            string Id_alumno = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[0].Value.ToString();
            string Id_evaluacion = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[1].Value.ToString();
            string DI = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[2].Value.ToString();
            string PMDM = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[3].Value.ToString();
            string AD = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[4].Value.ToString();

            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            string sentencia = "insert into Notas (Id_Alumno, Id_Evaluacion, DI,PMDM,AD) values ('" + Id_alumno + "','" + Id_evaluacion + "','"+DI+"','"+ PMDM+"','"+AD+"')";
            OleDbConnection miCnx = new OleDbConnection(conexion);
            OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
            miCnx.Open();
            miCmd.ExecuteNonQuery();
            miCnx.Close();
            miCnx.Dispose();
            MessageBox.Show("Guardado Correctamente");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string sentencia = null;
            if (TodosCheckBox.Checked == true)
            {
                sentencia = "SELECT* FROM Notas where Id_Evaluacion ="+ (SeleccionEvaluacionNotas.SelectedIndex + 1);
                MessageBox.Show(sentencia);
            }
            else
            {
                string id_alumno = AlumnosNotas.Text;
                sentencia = "SELECT* FROM Notas where Id_Evaluacion ="+ (SeleccionEvaluacionNotas.SelectedIndex + 1)+" and Id_Alumno ="+ id_alumno;
                MessageBox.Show(sentencia);
            }
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
            OleDbConnection miCnx = new OleDbConnection(conexion);
            miCnx.Open();
            miCommand = new OleDbCommand(sentencia, miCnx);
            miAdapter = new OleDbDataAdapter(miCommand);
            miBuilder = new OleDbCommandBuilder(miAdapter);
            DataSet miDataNotas = new DataSet();
            miAdapter.Fill(miDataNotas, "Notas");
            miTable = miDataNotas.Tables["Notas"];
            miCnx.Close();
            ListadoNotas.DataSource = miDataNotas.Tables[0];
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar esta fila?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                string Id_alumno = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[0].Value.ToString();
                string Id_evaluacion = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[1].Value.ToString();
                string sentencia = "DELETE FROM Notas where Id_Evaluacion =" + Id_evaluacion + " and Id_Alumno =" + Id_alumno;
                MessageBox.Show(sentencia);
                
                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
                OleDbConnection miCnx = new OleDbConnection(conexion);
                miCnx.Open();
                miCommand = new OleDbCommand(sentencia, miCnx);
                miAdapter = new OleDbDataAdapter(miCommand);
                miBuilder = new OleDbCommandBuilder(miAdapter);
                DataSet miDataNotas = new DataSet();
                miAdapter.Fill(miDataNotas, "Notas");
                miTable = miDataNotas.Tables["Notas"];
                miCnx.Close();
                ActualizarListadoNotas();
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (ListadoNotas.ReadOnly == true)
            {
                ListadoNotas.ReadOnly = false;
                Guardar.Visible = false;
                Agregar.Visible = false;
                Eliminar.Visible = false;
                Buscar.Visible = false;
            }
            else
            {
                ListadoNotas.ReadOnly = true;

                string Id_alumno = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[0].Value.ToString();
                string Id_evaluacion = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[1].Value.ToString();
                string DI = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[2].Value.ToString();
                string PMDM = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[3].Value.ToString();
                string AD = ListadoNotas.Rows[ListadoNotas.CurrentRow.Index].Cells[4].Value.ToString();

                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\practica.accdb";
                string sentencia = "update Notas set Id_Alumno= '" + Id_alumno + "', Id_Evaluacion='" + Id_evaluacion + "', DI='" + DI + "',PMDM='" + PMDM + "',AD= '" + AD + "'";
                OleDbConnection miCnx = new OleDbConnection(conexion);
                OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
                miCnx.Open();
                miCmd.ExecuteNonQuery();
                miCnx.Close();
                miCnx.Dispose();

                Guardar.Visible = true;
                Agregar.Visible = true;
                Eliminar.Visible = true;
                Buscar.Visible = true;
                MessageBox.Show("Cambios Guardados");
            }
        }
    }
}