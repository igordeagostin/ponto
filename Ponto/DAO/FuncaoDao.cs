using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class FuncaoDao
    {
        private ISession session;

        public FuncaoDao(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Funcao funcao)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(funcao);
            transacao.Commit();
        }

        public void Remove(Funcao funcao)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(funcao);
        }

        public void Atualiza(Funcao funcao)
        {
            session.Merge(funcao);
        }
    }
}