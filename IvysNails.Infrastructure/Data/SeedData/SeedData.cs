using IvysNails.Infrastructure.Data.Models;
using IvysNails.Infrastructure.Data.Models.Roles;
using Microsoft.AspNetCore.Identity;

namespace IvysNails.Infrastructure.Data.SeedData
{
    internal class SeedData
    {
        public SeedData() 
        {
            SeedUsers();
            SeedProduct();
            SeedProductCategory();
            SeedServices();
            SeedAdmin();
        }

        //Users
        public ApplicationUser AdminUser { get; set; }
        public ApplicationUser GuestUser { get; set; }

        //Roles
        public Admin Admin { get; set; }

        //Categories of products
        public ProductCategory Shampoo { get; set; } = null!;
        public ProductCategory Hairspray { get; set; } = null!;
        public ProductCategory NailPolish { get; set; } = null!;
        public ProductCategory HairDye { get; set; } = null!;
        public ProductCategory NailFile { get; set; } = null!;
       
        //Product
        public Product Kerastase { get; set; } = null!;
        public Product Syoss { get; set; } = null!;
        public Product Nailberry { get; set; } = null!;
        public Product NiegelohSolingen { get; set; } = null!;
        
        //Services
        public Service Varnishing { get; set; } = null!;
        public Service BuildingNails { get; set; } = null!;
        public Service VarnishingWithGelNailPolish { get; set; } = null!;
        public Service ManicureForMen { get; set; } = null!;
        public Service Pedicure { get; set; } = null!;
        public Service MedicalPedicure { get; set; } = null!;
        

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            AdminUser = new ApplicationUser()
            {
                Id = "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Admin",
                LastName = "Adminov"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin420");

            GuestUser = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@gmail.com",
                NormalizedUserName = "GUEST@GMAIL.COM",
                Email = "guest@gmail.com",
                NormalizedEmail = "GUEST@GMAIL.COM",
                FirstName = "Guest",
                LastName = "Guestov"
            };

            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest420");
        }

        private void SeedAdmin()
        {
            Admin = new Admin()
            {
                Id = 1,
                UserId = AdminUser.Id
            };
            
        }

        private void SeedProductCategory()
        {
            Shampoo = new ProductCategory()
            {
                Id = 1,
                Name = "Шампоан"
            };
            Hairspray = new ProductCategory()
            {
                Id = 2,
                Name = "Лак за коса"
            };
            NailPolish = new ProductCategory()
            {
                Id = 3,
                Name = "Лак за нокти"
            };
            HairDye = new ProductCategory()
            {
                Id=4,
                Name = "Боя за коса"
            };
            NailFile = new ProductCategory()
            {
                Id = 5,
                Name = "Пила за нокти"
            };

        }

        private void SeedProduct()
        {
            Kerastase = new Product()
            {
                Id = 1,
                Name = "KERASTASE",
                Price = 58.00m,
                StockQuantity = 9,
                Details = "Реконструиращ шампоан за слаба и безжизнена коса 250 мл",
                ImageUrl = "https://www.google.com/imgres?q=%D1%88%D0%B0%D0%BC%D0%BF%D0%BE%D0%B0%D0%BD%20%D0%B7%D0%B0%20%D0%BA%D0%BE%D1%81%D0%B0&imgurl=https%3A%2F%2Fwww.zlatnaribka.com%2Fimage%2Fcache%2Fcatalog%2F2019_Products_Pictures%2FKerastase%2FForce%2520Architecte%2FKerastase-Bain-Force-Architecte-shampoo-700-min-700x700.jpg&imgrefurl=http%3A%2F%2Fwww.zlatnaribka.com%2Fshampoan-za-silno-iztoshtena-i-nakasana-kosa-kerastase-bain-force-architecte-250-ml&docid=Fvk3PocZCYyuUM&tbnid=JtJ_86AoJVrdUM&vet=12ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECG0QAA..i&w=700&h=700&hcb=2&ved=2ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECG0QAA",
                ProductCategoryId = 1
            };
            Syoss = new Product()
            {
                Id = 2,
                Name = "SYOSS",
                Price = 13.90m,
                StockQuantity = 20,
                Details = "Подходящ за боядисана или коса на кичури. Предпазва интензивността на цвета и го защитава от избледняване. Косата е здрава, лъскава и сияйна",
                ImageUrl = "https://www.google.com/imgres?q=%D1%88%D0%B0%D0%BC%D0%BF%D0%BE%D0%B0%D0%BD%20%D0%B7%D0%B0%20%D0%BA%D0%BE%D1%81%D0%B0&imgurl=https%3A%2F%2Fgalen.bg%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F4587ace2ea33d73df121dcde1c6b054a%2F5%2F2-45491-29207%2Fsyoss-color-750-.jpg&imgrefurl=https%3A%2F%2Fgalen.bg%2Fsayas-shampoan-zashtita-na-tsveta-750ml&docid=2D0jEJAd2JKyoM&tbnid=CbN5yHRdk-GWxM&vet=12ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECGsQAA..i&w=700&h=700&hcb=2&ved=2ahUKEwiE2L_M_MGFAxVTR_EDHeQNANoQM3oECGsQAA",
                ProductCategoryId = 1
            };
            Nailberry = new Product()
            {
                Id = 3,
                Name = "NAILBERRY",
                Price = 42.09m,
                StockQuantity = 7,
                Details = "Цвят: Сияйно фуксия-розово. Fuchsia in Love L'Oxygéné от Nailberry внася в живота ви сияйна цветна радост и подсилва всяко облекло със своя сияен цвят. Брилянтният лилаво-розов нюанс може да се нанася без усилие и без ивици, с особено дълготраен резултат. Гамата лакове за нокти L'Oxygéné използва патентована технология, насочена към по-здравословна форма на маникюр. Резултатът е дишащи, водопропускливи и съдържащи кислород лакове, които са особено нежни към ноктите ви.Продуктът е веганнски, без тестове с животни и халал и без глутен.",
                ImageUrl = "https://www.google.com/imgres?q=%D0%BB%D0%B0%D0%BA%20%D0%B7%D0%B0%20%D0%BD%D0%BE%D0%BA%D1%82%D0%B8&imgurl=https%3A%2F%2Fco.nice-cdn.com%2Fupload%2Fimage%2Fproduct%2Flarge%2Fdefault%2Fnailberry-lak-za-nokti-fuchsia-in-love-loxygene-15-ml-447434-bg.jpg&imgrefurl=https%3A%2F%2Fwww.cosmeterie.bg%2Fnailberry%2Flak-za-nokti-fuchsia-in-love-loxygene&docid=_uoZbQhPXkWwjM&tbnid=jLTDHbnIasedpM&vet=12ahUKEwiQq7Pm_8GFAxVIQfEDHblaDtwQM3oECG4QAA..i&w=1920&h=1920&hcb=2&ved=2ahUKEwiQq7Pm_8GFAxVIQfEDHblaDtwQM3oECG4QAA",
                ProductCategoryId = 3
            };
            NiegelohSolingen = new Product()
            {
                Id = 4,
                Name = "Niegeloh Solingen",
                Price = 5.60m,
                StockQuantity = 10,
                Details = "Права диамантена пила за нокти. Двустранна - едра и финна. Бяла пластмасова дръжка. Обща дължина: 9 см / 3.5 инча. Дължина острие: 5.5 см",
                ImageUrl = "https://www.google.com/imgres?q=%D0%BF%D0%B8%D0%BB%D0%B0%20%D0%B7%D0%B0%20%D0%BD%D0%BE%D0%BA%D1%82%D0%B8&imgurl=https%3A%2F%2F2styrkela.com%2Fmedia%2Fcatalog%2Fproduct%2Fcache%2F1%2Fimage%2F9df78eab33525d08d6e5fb8d27136e95%2Fn%2Fi%2Fniegeloh-solingen_diamantena-pila-za-nokti_20421_3.jpg&imgrefurl=https%3A%2F%2F2styrkela.com%2Fpila-za-nokti-niegeloh-solingen-20421-13455.html&docid=ocZ1gRNnQXuHWM&tbnid=DijUBYehVscKSM&vet=12ahUKEwjzkJySgcKFAxVeBdsEHalVBbAQM3oECBUQAA..i&w=515&h=450&hcb=2&ved=2ahUKEwjzkJySgcKFAxVeBdsEHalVBbAQM3oECBUQAA",
                ProductCategoryId = 5
            };

        }

        private void SeedServices()
        {
            Varnishing = new Service()
            {
                Id = 1,
                Name = "Лакиране с обикновен лак",
                Price = 20.00m
            };
            BuildingNails = new Service()
            {
                Id = 2,
                Name = "Изграждане на нокти",
                Price = 80.00m
            };
            VarnishingWithGelNailPolish = new Service()
            {
                Id = 3,
                Name = "Лакиране с гел лаk",
                Price = 35.00m
            };
            ManicureForMen = new Service()
            {
                Id = 4,
                Name = "Мъжки маникюр",
                Price = 20.00m
            };
            Pedicure = new Service()
            {
                Id = 5,
                Name = "Педикюр",
                Price = 50.00m
            };
            MedicalPedicure = new Service()
            {
                Id = 6,
                Name = "медицински педикюр",
                Price = 80.00m
            };
        }
        
    }
}
