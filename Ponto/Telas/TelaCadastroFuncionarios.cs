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
        public TelaCadastroFuncionarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = textBoxNome.Text;
            funcionario.Senha = textBoxSenha.Text;
            funcionario.Cpf = textBoxCPF.Text;

            FuncionariosController funcionarioController = new FuncionariosController();
            try
            {
                funcionarioController.addFuncionario(funcionario);
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar Funcionário, erro: " + ex);
            }
            
        }
    }
}
