using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{
    public class SQL
    {

        public SQL()
        {

        }


        public void SqlINSERT_Livre(string Nom, string Genre, string Text, string Resumer, string Nb_Pages, string Mouvement, string Auteur)
        {
            
            MySqlConnection conn = new MySqlConnection("server=10.3.141.1;database=mydb;uid=root;pwd=root");

            MySqlCommand cmd = null;
            string cmdString = "";
            conn.Open();

            cmdString = SQL_constants.insertLivre +"'"+ Nom + "','" + Genre + "','" + Text + "','" + Resumer + "'," + 0 + ",'" + Mouvement + "','" + Auteur + "')";

            cmd = new MySqlCommand(cmdString, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            Console.WriteLine("Data Stored Successfully");
        }



        public List<List<string>> SqlRequest(string request)
        {
            //request = SQL_constants.selectAllBooks; //TEMPORAIRE POUR VOIR SI CA FONCTIONNE !!!!!!!!!!!!!

            //==================
            List<List<string>> outpute = new List<List<String>>();
            List<String> rowsElement = new List<String>();
            //==================

            string connectionString = "User=root;Password=root;Database=mydb;Server=10.3.141.1;Port=3306;";
            MySqlConnection conn = new MySqlConnection(connectionString);
           
            
            MySqlCommand cmd = new MySqlCommand(request, conn);
            cmd.Connection = conn;

            conn.Open();
            MySqlDataReader rdr = cmd.ExecuteReader();

            DataTable schemaTable = rdr.GetSchemaTable();

         
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rowsElement.Clear();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.WriteLine("\n /// value : "+ rdr[i].ToString());
                        rowsElement.Add(rdr[i].ToString());
                    }

                    //Console.WriteLine("\n //////\n \n taille des elements --> "+rowsElement.Count);

                    outpute.Add(new List<String>(rowsElement));
                    //rdr.NextResult();
                }
                rdr.Close();
            }

            return outpute;
        }



        
    }
}
