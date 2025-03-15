using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Ecole
{
    internal class DAOEleve : Connexion, IDAO<Eleve>
    {
        public DAOEleve()
        {
            Connect("ensat");
        }
        public int delete(int id)
        {
            try
            {
                string sql = "delete from eleve where id=@id";
                Dictionary<string, object> param = new Dictionary<string, object>() { { "@id", id } };
                return iud(sql, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in delete: " + ex.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Eleve> find(Eleve o)
        {
            List<Eleve> list = new List<Eleve>();
            MySqlDataReader reader = null;
            try
            {
                string sql = "select * from eleve where ";
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico = o.ObjToDico();
                foreach (var p in dico)
                    sql += p.Key + "=" + "@" + p.Key + " and ";
                sql += "1=1";

                reader = (MySqlDataReader)select(sql, dico);

                while (reader.Read())
                    list.Add(new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in find: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }

        public string testfind(Eleve o)
        {
            List<Eleve> list = new List<Eleve>();
            MySqlDataReader reader = null;

            string sql = "select * from eleve where ";
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico = o.ObjToDico();
            foreach (var p in dico)
                sql += p.Key + "=" + p.Value + " and ";
            sql += "1=1";

           
            return sql;
        }

        public List<Eleve> findAll()
        {
            List<Eleve> list = new List<Eleve>();
            MySqlDataReader reader = null;
            try
            {
                string sql = "select * from eleve";

                reader = (MySqlDataReader)select(sql);

                while (reader.Read())
                    list.Add(new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4)));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in findAll: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
        public Eleve findById(int id)
        {
            Eleve eleve = null;
            MySqlDataReader reader = null;
            try
            {
                string sql = "select * from eleve where id=@id";
                Dictionary<string, object> param = new Dictionary<string, object>() { { "@id", id } };
                reader = (MySqlDataReader)select(sql, param);

                if (reader.Read())
                {
                    eleve = new Eleve(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in findById: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return eleve;
        }

        public int insert(Eleve o)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(o.Nom) ||
                    string.IsNullOrWhiteSpace(o.Prenom) ||
                    string.IsNullOrWhiteSpace(o.Ville) ||
                    string.IsNullOrWhiteSpace(o.Specialite))
                {
                    Console.WriteLine("Error in insert: Fields cannot be empty.");
                    return -1; 
                }
                string sql = "insert into eleve(nom,prenom,ville,specialite)" +
                             "values(@nom,@prenom,@ville,@specialite)";
                Dictionary<string, object> param = new Dictionary<string, object>() {
                    { "@nom", o.Nom },
                    { "@prenom", o.Prenom },
                    { "@ville", o.Ville },
                    { "@specialite", o.Specialite },
                };
                return iud(sql, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in insert: " + ex.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int update(Eleve o)
        {
            try
            {
                string sql = "update eleve set nom=@nom, prenom=@prenom, ville=@ville, specialite=@specialite where id=@id";
                Dictionary<string, object> param = new Dictionary<string, object>() {
                    { "@nom", o.Nom },
                    { "@prenom", o.Prenom },
                    { "@ville", o.Ville },
                    { "@specialite", o.Specialite },
                    { "@id", o.Id }
                };
                return iud(sql, param);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in update: " + ex.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
