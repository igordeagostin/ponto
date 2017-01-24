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
    public partial class TelaFuncoes : Form
    {
        public TelaFuncoes()
        {
            InitializeComponent();
            configuraDataGridView();
        }

        public void configuraDataGridView()
        {
            FuncaoController funcaoController = new FuncaoController();
            dataGridViewFuncoes.DataSource = funcaoController.Lista();
            // Renomeia as colunas do DataGridView

            dataGridViewFuncoes.Columns[0].HeaderText = "ID";
            dataGridViewFuncoes.Columns[0].Name = "ID";
            dataGridViewFuncoes.Columns[1].HeaderText = "NOME";
            dataGridViewFuncoes.Columns[2].HeaderText = "DEPARTAMENTO";
            dataGridViewFuncoes.Columns[3].HeaderText = "FUNCIONÁRIOS";

            dataGridViewFuncoes.Columns[3].Visible = false;
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            TelaCadastroFuncoes form = new TelaCadastroFuncoes();
            form.ShowDialog();
        }
    }
}
