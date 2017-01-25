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
    public class FuncaoController
    {
        FuncaoDao funcaoDAO;
        ISession session;
        public FuncaoController()
        {
            session = NHibernateHelper.AbreSession();
            funcaoDAO = new FuncaoDao(session);
        }
        public void SaveOrUpdate(Funcao funcao)
        {            
            funcaoDAO.SaveOrUpdate(funcao);
        }
        public void Remove(Funcao funcao)
        {
            funcaoDAO.Remove(funcao);
        }

        public Funcao BuscaPorId(int id)
        {            
            return session.Get<Funcao>(id);
        }

        public IList<Funcao> Lista()
        {
            return funcaoDAO.Lista();
        }

        public IList<Funcao> funcaoPorDepartamento(string nome)
        {
            return funcaoDAO.funcaoPorDepartamento(nome);
        }

    }
}
