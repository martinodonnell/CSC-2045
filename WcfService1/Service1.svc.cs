using System;
using System.Data.SqlClient;
using System.Data;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        SqlConnection con = new SqlConnection("Data Source=NET;Initial Catalog=modonnell24;Persist Security Info=True;User ID=modonnell24; Password=k4BkstyY2M6zvGJm");

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public DataSet getTemp()
        {
            con.Open();

            //SqlDataAdapter sqlDataAdatper = new SqlDataAdapter("Select count(test1) from test2", con);
            string query = "Select count(test1) from test2";
            SqlCommand cmd = new SqlCommand(query,con);
            int result = (int)cmd.ExecuteScalar();
            Console.WriteLine("result:" + result);
            con.Close();
           
            return null;
        }

        public bool RegisterUser(string email, string password)
        {
            con.Open();

            try
            {
                string query = "INSERT INTO UserDetails (id, email, password,displayName)  VALUES(0, '" + email + "', '" + password + "','displayName'); ";
                SqlCommand cmd = new SqlCommand(query, con);

                int result = (int)cmd.ExecuteScalar();

                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
                return false;
            }
            return true;
        }
    }
}
