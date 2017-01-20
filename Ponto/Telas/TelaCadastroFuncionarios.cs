using Ponto.Controllers;
using Ponto.Entidades;
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
    public partial class TelaCadastroFuncionarios : Form
    {
        int id;
        public TelaCadastroFuncionarios()
        {
            InitializeComponent();
        }

        public TelaCadastroFuncionarios(Funcionario funcionario)
        {
            InitializeComponent();
            id = funcionario.Id;
            textBoxNome.Text = funcionario.Nome;             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Id = id;
            funcionario.Nome = textBoxNome.Text;
            funcionario.Senha = textBoxSenha.Text;
            funcionario.Cpf = textBoxCPF.Text;

            FuncionariosController funcionarioController = new FuncionariosController();
            funcionarioController.addFuncionario(funcionario);
            Close();
        }
    }
}
