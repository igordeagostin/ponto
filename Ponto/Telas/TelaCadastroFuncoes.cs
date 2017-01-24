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
    public partial class TelaCadastroFuncoes : Form
    {
        public TelaCadastroFuncoes()
        {
            InitializeComponent();
            DepartamentoController deparamentoController = new DepartamentoController();
            comboBoxDepartamentos.DataSource = deparamentoController.Lista();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
