using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen_ToDoList_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tarea tr = new Tarea();
        
        

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Tarea tr = new Tarea();
            tr.NumeroTarea = 1;
            tr.NombreTarea = txtTarea.Text;
            tr.NombrePersona = txtNombre.Text;
            tr.DetalleTarea = txtDetalle.Text;

            dgv.Rows.Add(tr.NumeroTarea, tr.NombreTarea, tr.NombrePersona, tr.DetalleTarea);

            tr.NumeroTarea = tr.NumeroTarea + 1;

            MessageBox.Show("Se ha agregado la tarea");
            txtTarea.Text = "";
            txtNombre.Text = "";
            txtDetalle.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgv.CurrentRow.Selected = true;
                    MessageBox.Show(dgv.Rows[e.RowIndex].Cells["DetalleTarea"].FormattedValue.ToString());

                }

            

        }

        private void btMostrarDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btMostrarTareas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
