using Ponto.Entidades;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace LojaWeb.DAO
{
    public class FuncionarioDao
    {
        private ISession session;

        public FuncionarioDao(ISession session)
        {
            this.session = session;
        }
        public FuncionarioDao()
        {

        }
        public void Adiciona(Funcionario funcionario)
        {
            ITransaction transacao = session.BeginTransaction();
            try
            {
                this.session.SaveOrUpdate(funcionario);
                transacao.Commit();
                MessageBox.Show("Funcionário salvo com sucesso!");
            }catch(Exception ex)
            {
                transacao.Rollback();
                MessageBox.Show("Erro ao cadastrar funcionário!\nErro: " + ex);
            }
            finally
            {
                this.session.Close();
            }
            
        }

        public void Remove(Funcionario funcionario)
        {
            ITransaction transacao = session.BeginTransaction();
            try
            {
                this.session.Delete(funcionario);
                MessageBox.Show("Funcionário excluído com sucesso!");
                transacao.Commit();
                
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                MessageBox.Show("Erro ao excluir Funcionário!\nErro:" + ex);
            }
            finally
            {
                this.session.Close();
            }
           
        }

        public Funcionario BuscaPorId(int id)
        {
            return this.session.Get<Funcionario>(id);
        }
        public IList<Funcionario> Lista()
        {
            String hql = "from Funcionario";
            IQuery query = session.CreateQuery(hql);
            //IList<Funcionario> funcionarios = query.List<Funcionario>();
            return query.List<Funcionario>();
        }
    }
}