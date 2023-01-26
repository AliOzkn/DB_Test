using System;

namespace DB_Test.Pages
{
     class Update : ReUsableMethods
    {
        public void update(String newNumber, String newName, String newLastName, String oldNumber)
        {
            connect();

            sql = "update Kisiler set Numara ='"+ newNumber + "', Ad = '" + newName + "',Soyad='" + newLastName + "' where Numara='" + oldNumber + "'";

            adapterCommands();
            Console.WriteLine("Successfully Updated");
            close();
        }

    }
}
