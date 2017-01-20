using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LojaWeb.DAO
{
    public class DepartamentoDao
    {
        private ISession session;

        public DepartamentoDao(ISession session)
        {
            this.session = session;
        }

        public void SaveOrUpdate(Departamento departamento)
        {
            ITransaction transacao = session.BeginTransaction();
            try
            {
                this.session.SaveOrUpdate(departamento);
                transacao.Commit();
                MessageBox.Show("Departamento salvo com sucesso!");
            }catch(Exception ex)
            {
                transacao.Rollback();
                MessageBox.Show("Erro ao salvar Departamento\nErro: " + ex);
            }
            finally
            {
                this.session.Close();
            }                    
        }

        public void Remove(Departamento departamento)
        {
            ITransaction transacao = session.BeginTransaction();
            try
            {
                this.session.Delete(departamento);
                transacao.Commit();
                MessageBox.Show("Departamento excluído com sucesso!");
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                MessageBox.Show("Erro ao excluir Departamento\nErro: " + ex);
            }
            finally
            {
                this.session.Close();
            }
        }

        public Departamento BuscaPorId(int id)
        {
            return this.session.Get<Departamento>(id);
        }
        public IList<Departamento> Lista()
        {
            String hql = "from Departamento";
            IQuery query = session.CreateQuery(hql);
            IList<Departamento> funcionarios = query.List<Departamento>();
            return query.List<Departamento>();
        }
    }
}