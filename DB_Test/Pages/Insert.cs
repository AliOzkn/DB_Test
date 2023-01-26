using System;
namespace DB_Test.Pages
{
     class Insert : ReUsableMethods
    {
        public void insert(String name, String lastname, String number)
        {
            connect();

            sql = "insert into Kisiler values(" + "'" + name + "'" + "," + "'" + lastname + "'" + "," + "'" + number + "'" + ")";
            adapterCommands();
            Console.WriteLine("Successfully Added");
            close();
        }
    }
}
