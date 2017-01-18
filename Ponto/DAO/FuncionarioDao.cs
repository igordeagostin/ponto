using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaWeb.DAO
{
    public class FuncionarioDao
    {
        private ISession session;

        public FuncionarioDao(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Funcionario funcionario)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Save(funcionario);
            transacao.Commit();
        }

        public void Remove(Funcionario funcionario)
        {
            ITransaction transacao = session.BeginTransaction();
            this.session.Delete(funcionario);
        }

        public void Atualiza(Funcionario funcionario)
        {
            session.Merge(funcionario);
        }

        public IList<Funcionario> Lista()
        {
            String hql = "from Funcionario";
            IQuery query = session.CreateQuery(hql);
            IList<Funcionario> funcionarios = query.List<Funcionario>();
            return query.List<Funcionario>();
        }
    }
}