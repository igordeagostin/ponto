using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class EmpresaDao
    {
        private ISession session;

        public EmpresaDao(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Empresa empresa)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(empresa);
            transacao.Commit();
        }

        public void Remove(Empresa empresa)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(empresa);
        }

        public void Atualiza(Empresa empresa)
        {
            session.Merge(empresa);
        }
    }
}