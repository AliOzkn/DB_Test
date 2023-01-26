using System;
using System.Data.SqlClient;

namespace DB_Test.Pages
{
    // Kullanmak istediğiniz komutun başındaki yorum satırını kaldırmak yeterli.
     class MainClass
    {
        static void Main()
        {
            Insert insert = new Insert();
            Update update = new Update();
            Delete delete = new Delete();
            Select select= new Select();

         // insert.insert("", "", "");     // 1. parametre Ad - 2. parametre Soyad - 3. parametre Numara
         // update.update("", "", "", ""); // 1. parametre Yeni Numara - 2. parametre Yeni Ad - 3. parametre Yeni Soyad - 4. parametre Güncel Numara
         // delete.delete("");             // parametre Güncel Numara
            select.select();

        }
    }
}




