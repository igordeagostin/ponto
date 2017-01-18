using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class FeriadoDao
    {
        private ISession session;

        public FeriadoDao(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Feriado feriado)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(feriado);
            transacao.Commit();
        }

        public void Remove(Feriado feriado)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(feriado);
        }

        public void Atualiza(Feriado feriado)
        {
            session.Merge(feriado);
        }
    }
}