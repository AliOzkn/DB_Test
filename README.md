# DB_Test

SQL Server ile ***TelefonRehberi*** adında veri tabanı oluşturulmuştur.<br>
SQL Server üzerinde script oluşturularak tablo oluşturma, veri ekleme, güncelleme, silme ve listeleme işlemleri yapılmıştır.<br>
Yazılan script ***DB_Test/SqlServer/*** klasörü içindedir. [Buraya tıklayarak](https://github.com/AliOzkn/DB_Test/blob/master/DB_Test/SqlServer/Telefon_Rehberi_Query.sql) ulaşabilirsiniz. Bu dosya export edilerek SQL Server'da açılabilir. <br>
Aynı klasör içindeki ***TelefonRehberi.txt*** adlı dosyada tablo değerleri vardır. Export edilerek kullanılabilir.
  - Oluşturulan tablo
<p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214802868-c096da58-1d7e-4fe4-a577-fec92f5b3b4b.png"/>
</p>

  - Yazılan Script
  <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214802887-5265f821-6d48-48d3-875f-0e3e8b0dc552.png"/>
</p>

---

## C# - SQL Connection
Visual Studio kullanılarak C# - SQL bağlantısı yapılmış, basit bir kod yazılmıştır. <br>
Visual Studio ile projeye Database bağlantısı yapma adımları aşağıdaki resimlerde gösterilmiştir.<br>
  - Connect To Database seçeneğine tıklanır.
<p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214686980-ac48f633-0bfc-45d0-858a-2597c83e0643.png"/>
</p>
  - Açılan pencereden Server Name girilir ve kullanılmak istenen Database seçilir.
  <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214686994-d8dfcf52-36ad-4edb-8a8b-826da2050194.png"/>
</p>
  - Bağlantı başarılı şekilde yapılınca bu şekilde görünecektir.
  <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214687010-79470216-4bdf-4476-b887-b1b3ffd4e13b.png"/>
</p>
  - Bağlantıya sağ tıklayınca açılan Properties sekmesindeki "Connection String" değeri, kod içerisindeki connect() metodunda kullanılacaktır. Bu C# - SQL bağlantısı için gereklidir.
  <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214687019-8156f6cc-4785-4e98-bfe3-8cf147af2837.png"/>
</p> <br>

<h4>Dizayn</h4>
 <p align="center">
 <img src="https://user-images.githubusercontent.com/107454207/214803379-fe906b5e-93a4-4694-a2f2-aed95a452ad5.png"/>
</p> <br>

- Yukarıdaki resimdeki dizayna göre:
  - <b>ReUsableMethods</b> sınıfında, connect() ve tekrarlanarak kullanacak metotlar vardır.
  - <b> Insert, Update, Delete, Select</b> sınıfları her bir sql komutu için ayrı şekilde tasarlanmıştır.
  - <b> MainClass </b> sınıfında bu metotlar, parametrik olarak dinamk bir şekilde çalıştırılmaktadır. Gerekli açıklamalar sınıfların içerisinde yapılmıştır.

