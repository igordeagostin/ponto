using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class UsuarioDao
    {
        private ISession session;

        public UsuarioDao(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Usuario usuario)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(usuario);
            transacao.Commit();
        }

        public void Remove(Usuario usuario)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(usuario);
        }

        public void Atualiza(Usuario usuario)
        {
            session.Merge(usuario);
        }
    }
}