using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OzturkOtoMarketWEBUI.Entity
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var Kategoriler = new List<Category>()
            {
                new Category() { Name ="Balata", Description="Balata Ürünleri"},
                new Category() { Name ="Kayış", Description="Kayış Ürünleri"}, 
                new Category() { Name ="Yağ Filtreleri", Description="Yağ Filtre Ürünleri"},
                new Category() { Name ="Hava Filtreleri", Description="Hava Filtre Ürünleri"},
                new Category() { Name ="Mazot Filtreleri", Description="Mazot Filtre Ürünleri"},
                new Category() { Name ="Polen Filtreleri", Description="Polen Filtre Ürünleri"},
                new Category() { Name ="Yağlar", Description="Yağ Ürünleri"}
               
            };

            foreach (var kategori in Kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() { Name ="Tofaş SLX Ön Balata", Description = "Orijinal Tofaş DOĞAN, Kartal Ön Balata", Price ="400", Stock = 10, IsApproved =true, CategoryId =1, Image="10.jpg" },
                new Product() { Name ="Tofaş Arka Balata", Description = "Orijinal Tofaş DOĞAN, Kartal Arka Balata", Price ="300", Stock = 10, IsApproved =false, CategoryId =1,Image="20.png"},
                new Product() { Name ="Renault 9 Ön Balata", Description = "Orijinal Reno 9 Ön Balata", Price ="450", Stock = 10, IsApproved =true, CategoryId =1,Image="030.png"},

                new Product() { Name ="6 PK 1750 Kayış", Description = "OTK Marka 6PK1750 Kayış", Price ="700", Stock = 8, IsApproved =true, CategoryId =2,Image="40.jpg",},
                new Product() { Name ="5 PK 1400 Kayış", Description = "MTK Marka 5PK1400 Kayış", Price ="600", Stock = 4, IsApproved =true, CategoryId =2,Image="50.jpg"},
                new Product() { Name ="4 PK 1200 Kayış", Description = "KTL Marka 4PK1200 Kayış", Price ="500", Stock = 3, IsApproved =true, CategoryId =2,Image="60.jpg"},

                new Product() { Name ="Tofaş Yağ Filtresi", Description = "Orijinal Tofaş Yağ Filtresi", Price ="300", Stock = 5, IsApproved =true, CategoryId =3,Image="70.jpg" },
                new Product() { Name ="Reno Yağ Filtresi", Description = "Orijinal Reno Yağ Filtresi", Price ="350", Stock = 40, IsApproved =true, CategoryId =3,Image="80.jpg"},
                new Product() { Name ="Pejo Yağ Filtresi", Description = "Orijinal Pejo Yağ Filtresi", Price ="400", Stock = 50, IsApproved =false, CategoryId =3,Image="90.jpg" },

                new Product() { Name ="Tofaş Hava Filtresi", Description = "Orijinal Tofaş Hava Filtresi", Price ="200", Stock = 10, IsApproved =true, CategoryId =4,Image="0100.jpg" },
                new Product() { Name ="Reno Hava Filtresi", Description = "Orijinal Reno Hava Filtresi", Price ="300", Stock = 10, IsApproved =true, CategoryId =4,Image="110.jpg" },
                new Product() { Name ="Pejo Hava Filtresi", Description = "Orijinal Pejo Hava Filtresi", Price ="500", Stock = 10, IsApproved =true, CategoryId =4,Image="120.jpg" },

                new Product() { Name ="Tofaş Mazot Filtresi", Description = "Orijinal Tofaş Mazot Filtresi", Price ="200", Stock = 10, IsApproved =true, CategoryId =5,Image="aa.png" },
                new Product() { Name ="Reno Mazot Filtresi", Description = "Orijinal Reno Mazot Filtresi", Price ="300", Stock = 10, IsApproved =true, CategoryId =5,Image="bb.jpg" },
                new Product() { Name ="Pejo Mazot Filtresi", Description = "Orijinal Pejo Mazot Filtresi", Price ="800", Stock = 10, IsApproved =true, CategoryId =5,Image="cc.jpg" },

                new Product() { Name ="Tofaş Polen Filtresi", Description = "Orijinal Tofaş Polen Filtresi", Price ="400", Stock = 8, IsApproved =true, CategoryId =6,Image="130.jpg"},
                new Product() { Name ="Reno Polen Filtresi", Description = "Orijinal Reno Polen Filtresi", Price ="300", Stock = 3, IsApproved =false, CategoryId =6,Image="140.jpg"},
                new Product() { Name ="Pejo Polen Filtresi", Description = "Orijinal Pejo Polen Filtresi", Price ="600", Stock = 5, IsApproved =true, CategoryId =6,Image="150.jpg"},

                new Product() { Name ="Castrol 4 LT 10/40 Yağ", Description = "Orijinal Castrol 10/40 Yağ", Price ="700", Stock = 10, IsApproved =true, CategoryId =7,Image="160.jpg" },
                new Product() { Name ="Castrol 4 LT 5/40 Yağ", Description = "Orijinal Castrol 5/40 Yağ", Price ="800", Stock = 30, IsApproved =true, CategoryId =7 ,Image="170.jpg" },
                new Product() { Name ="Castrol 4 LT 5/30 Yağ", Description = "Orijinal Castrol 5/30 Yağ", Price ="900", Stock = 20, IsApproved =false, CategoryId =7, Image="180.jpg"}



            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();





            base.Seed(context);
        }
    }
}