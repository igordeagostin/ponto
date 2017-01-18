using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class DepartamentoDao
    {
        private ISession session;

        public DepartamentoDao(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Departamento departamento)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(departamento);
            transacao.Commit();
        }

        public void Remove(Departamento departamento)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(departamento);
        }

        public void Atualiza(Departamento departamento)
        {
            session.Merge(departamento);
        }
    }
}