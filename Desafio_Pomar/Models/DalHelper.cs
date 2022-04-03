using System;
using Desafio_Pomar.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Pomar
{
    class DalHelper
    {
        private static SQLiteConnection sqliteConnection;

        public DalHelper()
        {

        }
        //CONECTAR AO BANCO DE DADOS
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=C:\\Desafio_Pomar\\databasePomar\\BancoPomar.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        //CRIAR O BANCO DE DADOS
        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"C:\Desafio_Pomar\databasePomar\BancoPomar.sqlite");
            }
            catch
            {
                throw;
            }
        }
        //TABELA ESPECIES
        #region TABELA ESPECIES
        //CRIAR TABELA ESPECIES
        public static void CriarTabelaTBEspecies()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TBEspecies(IDEspecies int PRIMARY KEY, DescEspecies VARCHAR(50))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR DADOS DA TABELA ESPECIES 
        public static DataTable GetTBEspecies()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TBEspecies";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR OS DADOS DA TABELA ESPECIES FEREFENTE AO ID
        public static DataTable GetTBEspecie(int IdEspecie)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TBEspecies Where IDEspecies=" + IdEspecie;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //INSERIR NA TABELA ESPECIES
        public static void Add(Especies especies)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TBEspecies(IDEspecies, DescEspecies) values (@IdEspecie, @DescEspecies)";
                    cmd.Parameters.AddWithValue("@IdEspecie", especies.IdEspecie);
                    cmd.Parameters.AddWithValue("@DescEspecies", especies.DescEspecies);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //ATUALIZAR REGISTRO NA TABELA  ESPECIES
        public static void Update(Especies especies)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (especies.IdEspecie != null)
                    {
                        cmd.CommandText = "UPDATE TBEspecies SET DescEspecies=@DescEspecies WHERE IDEspecies=@IdEspecie";
                        cmd.Parameters.AddWithValue("@IdEspecie", especies.IdEspecie);
                        cmd.Parameters.AddWithValue("@DescEspecies", especies.DescEspecies);

                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //DELETAR REGISTRO NA TABELA ESPECIE
        public static void Delete(int IdEspecie)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TBEspecies Where IDEspecies=@IdEspecie";
                    cmd.Parameters.AddWithValue("@IdEspecie", IdEspecie);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //METODO PARA PEGAR OS DADOS E INSERIR NO COMBOBOX ESPECIE
        public static Especies GetEspeciesCBB(int IdEspecie)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            Especies esp = new Especies();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TBEspecies Where IDEspecies=" + IdEspecie;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    esp.IdEspecie = Convert.ToInt32(dt.Rows[0]["IDEspecies"]);
                    esp.DescEspecies = dt.Rows[0]["DescEspecies"].ToString();
                    return esp;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        //TABELA ARVORE
        #region TABELA ARVORES
        //CRIAR TABELA ARVORE
        public static void CriarTabelaTBArvores()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TBArvores(IDArvore int PRIMARY KEY, DescArvore VARCHAR(50), " +
                        "idade VARCHAR(20), FK_Especies int, FOREIGN KEY (FK_Especies) REFERENCES TBEspecies (IDEspecies))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR DADOS DA TABELA ARVORE 
        public static DataTable GetTBArvores()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT a.*, b.DescEspecies FROM TBArvores a INNER JOIN " +
                    "TBEspecies b on(a.FK_Especies =b.IDEspecies)";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR OS DADOS DA TABELA ARVORE FEREFENTE AO ID
        public static DataTable GetTBArvore(int IDArvore)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "SELECT a.*, b.DescEspecies FROM TBArvores a INNER JOIN " +
                        "TBEspecies b on(a.FK_Especies =b.IDEspecies) Where IDArvore=" + IDArvore;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //INSERIR NA TABELA ARVORE
        public static void AddArvore(Arvores arvores)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TBArvores(IDArvore, DescArvore, idade, FK_Especies) " +
                        "values (@IdArvore, @DescArvore, @IdadeArvore, @EspecieArvore)";
                    cmd.Parameters.AddWithValue("@IdArvore", arvores.IdArvore);
                    cmd.Parameters.AddWithValue("@DescArvore", arvores.DescArvore);
                    cmd.Parameters.AddWithValue("@IdadeArvore", arvores.IdadeArvore);
                    cmd.Parameters.AddWithValue("@EspecieArvore", arvores.EspecieArvore);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //ATUALIZAR REGISTRO NA TABELA  ARVORE
        public static void UpdateArvore(Arvores arvores)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (arvores.IdArvore != null)
                    {
                        cmd.CommandText = "UPDATE TBArvores SET DescArvore=@DescArvore, FK_Especies=@EspecieArvore, idade=@IdadeArvore WHERE IDArvore=@IdArvore";
                        cmd.Parameters.AddWithValue("@IdArvore", arvores.IdArvore);
                        cmd.Parameters.AddWithValue("@DescArvore", arvores.DescArvore);
                        cmd.Parameters.AddWithValue("@EspecieArvore", arvores.EspecieArvore);
                        cmd.Parameters.AddWithValue("@IdadeArvore", arvores.IdadeArvore);

                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //DELETAR REGISTRO NA TABELA ARVORE
        public static void DeleteArvore(int IdArvore)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TBArvores Where IDArvore=@IdArvore";
                    cmd.Parameters.AddWithValue("@IdArvore", IdArvore);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        //METODO PARA PEGAR OS DADOS E INSERIR NO COMBOBOX ARVORE
        public static Arvores GetArvoreCBB(int IdArvore)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            Arvores arv = new Arvores();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TBArvores Where IDArvore=" + IdArvore;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    arv.IdArvore = Convert.ToInt32(dt.Rows[0]["IDArvore"]);
                    arv.DescArvore = dt.Rows[0]["DescArvore"].ToString();
                    return arv;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        //TABELA GRUPO ARVORE
        #region TABELA GRUPO ARVORE
        //CRIAR TABELA GRUPOARVORE
        public static void CriarTabelaTBGrupoArvore()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TBGrupoArvores(IDGrupo int PRIMARY KEY, NomeGrupo VARCHAR(50), " +
                        "DesGrupo VARCHAR(20), FK_Arvore int, FOREIGN KEY (FK_Arvore) REFERENCES TBArvores (IDArvore))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR DADOS DA TABELA ARVORE 
        public static DataTable GetTBGrupoArvores()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT a.*, b.DescArvore FROM TBGrupoArvores a INNER JOIN " +
                    "TBArvores b on(a.FK_Arvore =b.IDArvore)";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR OS DADOS DA TABELA ARVORE FEREFENTE AO ID
        public static DataTable GetTBGrupoArvore(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT a.*, b.DescArvore FROM TBGrupoArvores a INNER JOIN " +
                    "TBArvores b on(a.FK_Arvore =b.IDArvore) Where IDGrupo=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //INSERIR NA TABELA ARVORE
        public static void AddGrupoArvore(GrupoArvore grupoArv)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TBGrupoArvores(IDGrupo, NomeGrupo, DesGrupo, FK_Arvore ) " +
                        "values (@IdGrupoArvore, @NomeGrupoArvore, @DescGrupoArvore, @TipoArvore)";
                    cmd.Parameters.AddWithValue("@IdGrupoArvore", grupoArv.IdGrupoArvore);
                    cmd.Parameters.AddWithValue("@NomeGrupoArvore", grupoArv.NomeGrupoArvore);
                    cmd.Parameters.AddWithValue("@DescGrupoArvore", grupoArv.DescGrupoArvore);
                    cmd.Parameters.AddWithValue("@TipoArvore", grupoArv.TipoArvore);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //ATUALIZAR REGISTRO NA TABELA  ARVORE
        public static void UpdateGrupoArvore(GrupoArvore grupoArv)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (grupoArv.IdGrupoArvore != null)
                    {
                        cmd.CommandText = "UPDATE TBGrupoArvores SET NomeGrupo=@NomeGrupoArvore, DesGrupo=@DescGrupoArvore ,FK_Arvore=@TipoArvore WHERE IDGrupo=@IdGrupoArvore";
                        cmd.Parameters.AddWithValue("@IdGrupoArvore", grupoArv.IdGrupoArvore);
                        cmd.Parameters.AddWithValue("@NomeGrupoArvore", grupoArv.NomeGrupoArvore);
                        cmd.Parameters.AddWithValue("@DescGrupoArvore", grupoArv.DescGrupoArvore);
                        cmd.Parameters.AddWithValue("@TipoArvore", grupoArv.TipoArvore);

                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //DELETAR REGISTRO NA TABELA ARVORE
        public static void DeleteGrupoArvore(int IdArvore)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TBGrupoArvores Where IDGrupo=@IdArvore";
                    cmd.Parameters.AddWithValue("@IdArvore", IdArvore);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        #endregion
        //TABELA COLHEITA
        #region TABELA COLHEITA
        //CRIAR TABELA GRUPOARVORE
        public static void CriarTabelaTBColheitas()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TBColheitas(IDColheita int PRIMARY KEY, Informacao VARCHAR(50), " +
                        "DataColheita VARCHAR(20), Peso DECIMAL, FK_Arvore int, FOREIGN KEY (FK_Arvore) REFERENCES TBArvores (IDArvore))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR DADOS DA TABELA ARVORE 
        public static DataTable GetTBColheitas()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT a.*, b.DescArvore FROM TBColheitas a INNER JOIN " +
                    "TBArvores b on(a.FK_Arvore =b.IDArvore)";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //PEGAR OS DADOS DA TABELA ARVORE FEREFENTE AO ID
        public static DataTable GetTBColheita(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT a.*, b.DescArvore FROM TBColheitas a INNER JOIN " +
                    "TBArvores b on(a.FK_Arvore =b.IDArvore) Where IDColheita=" + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //INSERIR NA TABELA ARVORE
        public static void AddColheitas(Colheita colheita)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TBColheitas(IDColheita, Informacao, DataColheita, Peso, FK_Arvore ) " +
                        "values (@IDColheita, @Informacao, @DataColheita, @Peso, @TipoArvore)";
                    cmd.Parameters.AddWithValue("@IDColheita",colheita.IDColheita);
                    cmd.Parameters.AddWithValue("@Informacao", colheita.Informacao);
                    cmd.Parameters.AddWithValue("@DataColheita", colheita.DataColheita);
                    cmd.Parameters.AddWithValue("@Peso", colheita.Peso);
                    cmd.Parameters.AddWithValue("@TipoArvore", colheita.TipoArvore);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //ATUALIZAR REGISTRO NA TABELA  ARVORE
        public static void UpdateColheitas(Colheita colheita)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (colheita.IDColheita != null)
                    {
                        cmd.CommandText = "UPDATE TBColheitas SET Informacao=@Informacao, DataColheita=@DataColheita , Peso=@Peso, FK_Arvore=@TipoArvore WHERE IDColheita=@IDColheita";
                        cmd.Parameters.AddWithValue("@IDColheita", colheita.IDColheita);
                        cmd.Parameters.AddWithValue("@Informacao", colheita.Informacao);
                        cmd.Parameters.AddWithValue("@DataColheita", colheita.DataColheita);
                        cmd.Parameters.AddWithValue("@Peso", colheita.Peso);
                        cmd.Parameters.AddWithValue("@TipoArvore", colheita.TipoArvore);

                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //DELETAR REGISTRO NA TABELA ARVORE
        public static void DeleteColheitas(int idColheita)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TBColheitas Where IDColheita=@IDColheita";
                    cmd.Parameters.AddWithValue("@IDColheita", idColheita);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
        //RELATORIO 
        #region RELATORIO
        //PEGAR OS DADOS DA TABELA ARVORE 
        public static DataTable GetRelatorioArvore()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "SELECT a.IDArvore, a.DescArvore, a.idade, b.DescEspecies, c.NomeGrupo, c.DesGrupo, d.Informacao, d.DataColheita, d.Peso " +
                        "FROM TBArvores a INNER JOIN TBEspecies b ON (a.FK_Especies =b.IDEspecies) LEFT JOIN TBGrupoArvores c ON (c.FK_Arvore =a.IDArvore)" +
                        "LEFT JOIN TBColheitas d ON (d.FK_Arvore =a.IDArvore)";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        //PEGAR OS DADOS DA TABELA ARVORE FEREFENTE AO NOME ARVORE
        public static DataTable GetRelatorioArvores(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "SELECT a.IDArvore, a.DescArvore, a.idade, b.DescEspecies, c.NomeGrupo, c.DesGrupo, d.Informacao, d.DataColheita, d.Peso " +
                        "FROM TBArvores a INNER JOIN TBEspecies b ON (a.FK_Especies =b.IDEspecies) INNER JOIN TBGrupoArvores c ON (c.FK_Arvore =a.IDArvore)" +
                        "INNER JOIN TBColheitas d ON (d.FK_Arvore =a.IDArvore) WHERE a.DescArvore LIKE '%" + id + "%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        //PEGAR OS DADOS DA TABELA ARVORE FEREFENTE AO PERIODO
        public static DataTable GetRelatorioArvores2(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = "SELECT a.IDArvore, a.DescArvore, a.idade, b.DescEspecies, c.NomeGrupo, c.DesGrupo, d.Informacao, d.DataColheita, d.Peso " +
                        "FROM TBArvores a INNER JOIN TBEspecies b ON (a.FK_Especies =b.IDEspecies) INNER JOIN TBGrupoArvores c ON (c.FK_Arvore =a.IDArvore)" +
                        "INNER JOIN TBColheitas d ON (d.FK_Arvore =a.IDArvore) WHERE d.DataColheita LIKE '%" + id + "%'";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

        }
        #endregion
        //USUARIOS
        
    }
}
