using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;
using Ponto.Infra;
using System.Reflection;
using NHibernate.Tool.hbm2ddl;

namespace Ponto
{
    class Program
    {
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Telas.TelaPrincipal());

            Configuration configuracao = new Configuration();
            configuracao.Configure();
            configuracao.AddAssembly(Assembly.GetExecutingAssembly());
            try
            {
                new SchemaUpdate(configuracao).Execute(true, true);
                Console.WriteLine("Entidade criada no BD");
            }
            catch
            {
                Console.WriteLine("Falha ao criar a entidade no BD");
            }
            Console.ReadLine();

        }
    }
}
