using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using WSVeiculos.DTO;
using System.Data.Entity.ModelConfiguration.Conventions;
using WSVeiculos.DAL.EntitiesConfig;

namespace WSVeiculos.DAL
{
    public class Context: DbContext
    {

        public Context(): base("strConnection")
        {
            //Database.SetInitializer<Context>(new ContextInitializer());
        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produtos> Produtos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            modelBuilder.Properties()
                .Where(p=>p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties()
               .Where(p => p.Name == "Cod" + p.ReflectedType.Name)
               .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));


            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ProdutosMap());


            base.OnModelCreating(modelBuilder);
        }

        //public SqlConnection conexao;

        //private SqlConnection CriarConexao()
        //{

        //    conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConnection"].ConnectionString);

        //    return conexao;

        //}


        //private SqlParameterCollection sqlparametercollection = new SqlCommand().Parameters;

        //private SqlCommand criarComando(CommandType commandtype, string nomeProcedure)
        //{
        //    conexao = CriarConexao();
        //    conexao.Open();
        //    SqlCommand cmd = conexao.CreateCommand();
        //    cmd.CommandType = commandtype;
        //    cmd.CommandText = nomeProcedure;
        //    cmd.CommandTimeout = 7200;

        //    foreach (SqlParameter sqlparameter in sqlparametercollection)
        //    {
        //        cmd.Parameters.Add(new SqlParameter(sqlparameter.ParameterName, sqlparameter.Value));
        //    }

        //    return cmd;
        //}


        //protected void AdicionarParametros(string nomeParametro, object valorParametro)
        //{
        //    sqlparametercollection.AddWithValue(nomeParametro, valorParametro);
        //}

        //protected void LimparParametros()
        //{
        //    sqlparametercollection.Clear();
        //}

        //protected object ExecutarComando(CommandType commandtype, string nomeprocedure)
        //{
        //    try
        //    {
        //        SqlCommand cmd = criarComando(commandtype, nomeprocedure);
        //        return cmd.ExecuteScalar();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //    finally
        //    {
        //        conexao.Close();
        //    }

        //}

        //protected DataTable ExecutarConsulta(CommandType commandtype, string nomeprocedure)
        //{

        //    try
        //    {
        //        SqlCommand cmd = criarComando(commandtype, nomeprocedure);
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter sqldataadapter = new SqlDataAdapter(cmd);
        //        sqldataadapter.Fill(dt);

        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //    finally
        //    {
        //        conexao.Close();
        //    }


        //}


    }

   
    //public class ContextInitializer: DropCreateDatabaseIfModelChanges<Context>
    //{


    //    protected override void Seed(Context context)
    //    {
    //        context.Cliente.Add( new Cliente { CodCliente = 1, Nome = "Pedro" });
    //        context.Cliente.Add(new Cliente { CodCliente = 2, Nome = "Rosângela" });
    //        context.SaveChanges();

    //        context.Produtos.Add(new Produtos {  CodProdutos = 1, Modelo = "HKW", Marca="CHEVROLET", CodClient = 1, Preco = 15.000});
    //        context.Produtos.Add(new Produtos { CodProdutos = 2, Modelo = "SSH", Marca = "CHEVROLET", CodClient = 2, Preco = 35.000 });
    //        context.SaveChanges();

    //        base.Seed(context); 
    //    }


    //}













































}
