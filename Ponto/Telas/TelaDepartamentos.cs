using Ponto.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ponto.Telas
{
    public partial class TelaDepartamentos : Form
    {
        public TelaDepartamentos()
        {
            InitializeComponent();
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastroDepartamento tela = new TelaCadastroDepartamento();
            tela.ShowDialog();
        }

        public void configuraDataGridView()
        {
            DepartamentoController departamentoController = new DepartamentoController();
            dataGridViewDepartamentos.DataSource = departamentoController.Lista();
            // Renomeia as colunas do DataGridView

            dataGridViewDepartamentos.Columns[0].HeaderText = "ID";
            dataGridViewDepartamentos.Columns[0].Name = "ID";
            dataGridViewDepartamentos.Columns[1].HeaderText = "NOME";
            dataGridViewDepartamentos.Columns[2].HeaderText = "FUNCIONÁRIOS";
            dataGridViewDepartamentos.Columns[3].HeaderText = "FUNÇÕES";

            dataGridViewDepartamentos.Columns[2].Visible = false;
            //dataGridViewDepartamentos.Columns[3].Visible = false;
        }
        }
    }
