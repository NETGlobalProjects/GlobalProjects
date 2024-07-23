using ArchivadorFEL.Datos;
using ArchivadorFEL.Modelos;
using Microsoft.VisualBasic.Logging;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivadorFEL
{
    public partial class frmLogs : Form
    {
        public List<Logs> logs;
        public frmLogs()
        {
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            this.tipocomboBox1.DataSource = logs.DistinctBy(a => a.Tipo).ToList();
            this.tipocomboBox1.ValueMember = "Tipo";
            this.tipocomboBox1.DisplayMember = "Tipo";

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = logs;

        }

        private void tipocomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = logs.Where(a => a.Tipo == Convert.ToString(this.tipocomboBox1.SelectedValue)).ToList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i <= this.dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToString(this.dataGridView1.Rows[i].Cells["Tipo"].Value) == "Error")
                {
                    this.dataGridView1.Rows[i].Cells["icon"].Value = Properties.Resources.Error;
                }
                else if (Convert.ToString(this.dataGridView1.Rows[i].Cells["Tipo"].Value) == "Exito")
                {
                    this.dataGridView1.Rows[i].Cells["icon"].Value = Properties.Resources.OK;
                }
            }
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dato = logs.Where(a => a.archivo == Convert.ToString(this.dataGridView1.CurrentRow.Cells["Archivo"].Value) && a.nombreCortoEmpresa == Convert.ToString(this.dataGridView1.CurrentRow.Cells["nombreCortoEmpresa"].Value)).SingleOrDefault();
            if (dato != null)
            {
                this.mensajetextBox1.Text = dato.Mensaje;
                this.archivotextBox2.Text = dato.archivo;
            }
        }

        private void exportarbutton1_Click(object sender, EventArgs e)
        {
            if (logs.Count > 0) 
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.FileName != "")
                    {
                        SLDocument sLDocument = new SLDocument();
                        sLDocument.ImportDataTable(1, 1, accesoDatos.instancia.ToDataTable(logs), true);
                        sLDocument.SaveAs(saveFileDialog1.FileName);
                        MessageBox.Show("Datos exportados exitosamente, guardado en: " + saveFileDialog1.FileName, "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar", "Exportar a excel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
