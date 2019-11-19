using System;

namespace Examen_ToDoList_Form
{
    partial class Form1
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.NumeroTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btMostrarTareas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTarea,
            this.NombreTarea,
            this.UsuarioTarea,
            this.DetalleTarea});
            this.dgv.Location = new System.Drawing.Point(12, 85);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(776, 362);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumeroTarea
            // 
            this.NumeroTarea.HeaderText = "Numero de tarea";
            this.NumeroTarea.Name = "NumeroTarea";
            // 
            // NombreTarea
            // 
            this.NombreTarea.HeaderText = "Nombre de la tarea";
            this.NombreTarea.Name = "NombreTarea";
            // 
            // UsuarioTarea
            // 
            this.UsuarioTarea.HeaderText = "Quien hara la tarea";
            this.UsuarioTarea.Name = "UsuarioTarea";
            // 
            // DetalleTarea
            // 
            this.DetalleTarea.HeaderText = "Detalle";
            this.DetalleTarea.Name = "DetalleTarea";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarea";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quien hara la tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detalle";
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(12, 53);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(100, 26);
            this.txtTarea.TabIndex = 4;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(319, 53);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(100, 26);
            this.txtDetalle.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(165, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(446, 13);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(108, 66);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btMostrarTareas
            // 
            this.btMostrarTareas.Location = new System.Drawing.Point(560, 13);
            this.btMostrarTareas.Name = "btMostrarTareas";
            this.btMostrarTareas.Size = new System.Drawing.Size(112, 66);
            this.btMostrarTareas.TabIndex = 9;
            this.btMostrarTareas.Text = "Mostrar tareas";
            this.btMostrarTareas.UseVisualStyleBackColor = true;
            this.btMostrarTareas.Click += new System.EventHandler(this.btMostrarTareas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMostrarTareas);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btMostrarTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleTarea;
    }
}

