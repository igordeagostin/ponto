using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class HistoricoDao
    {
        private ISession session;

        public HistoricoDao(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Historico historico)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(historico);
            transacao.Commit();
        }

        public void Remove(Historico historico)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(historico);
        }

        public void Atualiza(Historico historico)
        {
            session.Merge(historico);
        }
    }
}