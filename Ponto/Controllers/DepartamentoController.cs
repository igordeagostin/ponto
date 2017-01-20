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
    public class DepartamentoController
    {
        DepartamentoDao departamentoDAO;
        ISession session;
        public DepartamentoController()
        {
            session = NHibernateHelper.AbreSession();
            departamentoDAO = new DepartamentoDao(session);
        }
        public void SaveOrUpdate(Departamento departamento)
        {            
            departamentoDAO.SaveOrUpdate(departamento);
        }
        public void Remove(Departamento departamento)
        {
            departamentoDAO.Remove(departamento);
        }

        public Departamento BuscaPorId(int id)
        {            
            return session.Get<Departamento>(id);
        }

        public IList<Departamento> Lista()
        {
            return departamentoDAO.Lista();
        }

    }
}
