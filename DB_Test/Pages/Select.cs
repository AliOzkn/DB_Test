using System;

namespace DB_Test.Pages
{
     class Select : ReUsableMethods
    {
        public void select()
        {
           connect();

            sql = "Select * from Kisiler";

            sqlCommand();
            dataReaderCommand();

            while (dataReader.Read()) // While döngüsü ile tablodaki değerleri döndürerek, ekrana yazdırması sağlanır.
            {
                output = output + dataReader.GetValue(0) + " " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + "\n";
            }

            Console.Write(output);
            dataReader.Close();
            close();
            
        }

    }
}
