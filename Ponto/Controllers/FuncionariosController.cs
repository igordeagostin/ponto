using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ponto.Entidades;
using LojaWeb.DAO;
using NHibernate;
using Ponto.Infra;

namespace Ponto.Controllers
{
    public class FuncionariosController
    {    
        
        public void addFuncionario(Funcionario funcionario)
        {
            ISession session = NHibernateHelper.AbreSession();
            FuncionarioDao funcionarioDAO = new FuncionarioDao(session);
            funcionarioDAO.Adiciona(funcionario);
        }
        public void delFuncionario(Funcionario funcionario)
        {
            ISession session = NHibernateHelper.AbreSession();
            FuncionarioDao funcionarioDAO = new FuncionarioDao(session);
            funcionarioDAO.Remove(funcionario);
        }
        public void attFuncionario(Funcionario funcionario)
        {
            ISession session = NHibernateHelper.AbreSession();
            FuncionarioDao funcionarioDAO = new FuncionarioDao(session);
            funcionarioDAO.Atualiza(funcionario);
        }
    }
}
