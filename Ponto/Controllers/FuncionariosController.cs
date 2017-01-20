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
        FuncionarioDao funcionarioDAO;
        ISession session;
        public FuncionariosController()
        {
            session = NHibernateHelper.AbreSession();
            funcionarioDAO = new FuncionarioDao(session);
        }
        public void addFuncionario(Funcionario funcionario)
        {            
            funcionarioDAO.Adiciona(funcionario);
        }
        public void delFuncionario(Funcionario funcionario)
        {
            funcionarioDAO.Remove(funcionario);
            session.Close();
        }

        public Funcionario BuscaPorId(int id)
        {            
            return session.Get<Funcionario>(id);
        }

        public IList<Funcionario> Lista()
        {
            return funcionarioDAO.Lista();
        }

    }
}
