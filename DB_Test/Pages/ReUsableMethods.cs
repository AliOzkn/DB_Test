using System;
using System.Data.SqlClient;

namespace DB_Test.Pages
{
     class ReUsableMethods
    {

        public SqlConnection con;        // SQL Server bağlantısı için.
        public SqlCommand command;       // Veri girişi ve okuma işlemleri için komut kullanılmalı.
        public SqlDataReader dataReader; // Tablo satırlarını okumak için.
        public SqlDataAdapter adapter;   // DataAdapter insert, update ve delete komutları için kullanılır.
        public string sql, output = "";

        // connect() metodu, SQL Server üzerinde oluşturulmuş, aşağıda path'i verilen veri tabanının C# ile bağlantısını sağlamaktadır.
        public void connect()
        {                         //"Data Source={SERVER ADI};Initial Catalog={DB ADI};Integrated Security=True,{Varsa Server için id ve pass}"
            con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TelefonRehberi;Integrated Security=True");
            con.Open();
            Console.WriteLine("Connected!");

        }

        public void adapterCommands()
        {
            adapter = new SqlDataAdapter();
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
        }
        
        public void sqlCommand()
        {
            command = new SqlCommand(sql, con);
        }
        public void dataReaderCommand()
        {
            dataReader = command.ExecuteReader();
        }

        public void close()
        {
            con.Dispose();
            con.Close();
        }

    }
}
