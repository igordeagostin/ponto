using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LojaWeb.DAO
{
    public class FuncaoDao
    {
        private ISession session;

        public FuncaoDao(ISession session)
        {
            this.session = session;
        }

        public FuncaoDao()
        {

        }

        public void SaveOrUpdate(Funcao funcao)
        {
            ITransaction transacao = session.BeginTransaction();
            try
            {
                this.session.SaveOrUpdate(funcao);
                transacao.Commit();
                MessageBox.Show("Função salva com sucesso!");
            }
            catch(Exception ex)
            {
                transacao.Rollback();
                MessageBox.Show("Erro ao salvar a Função\nErro: " + ex);
            }
            finally
            {
                this.session.Close();
            }
            
        }

        public void Remove(Funcao funcao)
        {
            ITransaction transacao = session.BeginTransaction();
            try
            {
                this.session.Delete(funcao);
                transacao.Commit();
                MessageBox.Show("Função excluída com sucesso!");
            }catch(Exception ex)
            {
                transacao.Rollback();
                MessageBox.Show("Erro ao excluir a Função\nErro:" + ex);
            }
            finally
            {
                this.session.Close();
            }
            
        }
        public Funcao BuscaPorId(int id)
        {
            return this.session.Get<Funcao>(id);
        }
        public IList<Funcao> Lista()
        {
            String hql = "from Funcao";
            IQuery query = session.CreateQuery(hql);
            //IList<Funcao> funcionarios = query.List<Funcao>();
            return query.List<Funcao>();
        }

        public IList<Funcao> funcaoPorDepartamento(string nome)
        {
            String hql = "from Funcao f where f.Departamento.Nome = :nome";
            IQuery query = session.CreateQuery(hql);
            query.SetParameter("nome", nome);
            return query.List<Funcao>();
        }
    }
}