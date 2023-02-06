namespace Proje_OOP.Entity
{
    public class Product //Ürün adlı bir sınıf oluşturuyoruz.
    {
        //Ürün sınıfımızın elemanlarını oluşturuypruz.
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
