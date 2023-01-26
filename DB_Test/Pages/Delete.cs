using System;
using System.Data.SqlClient;

namespace DB_Test.Pages
{
     class Delete : ReUsableMethods
    {

        public void delete(String number)
        {
            connect();

           sql = "delete from Kisiler where Numara ='" + number +"'";


            adapterCommands();
            Console.WriteLine("Successfully Deleted");
            close();
        }
    }
}
