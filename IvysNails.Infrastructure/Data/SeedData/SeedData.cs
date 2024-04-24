using IvysNails.Infrastructure.Data.Models;

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
            
        }

        //Users
        public ApplicationUser AdminUser { get; set; }
        public ApplicationUser GuestUser { get; set; }     

        //Categories of products
        public ProductCategory Shampoo { get; set; } 
        public ProductCategory Hairspray { get; set; } 
        public ProductCategory NailPolish { get; set; }
        public ProductCategory HairDye { get; set; } 
        public ProductCategory NailFile { get; set; } 
       
        //Product
        public Product Kerastase { get; set; } 
        public Product Syoss { get; set; } 
        public Product Nailberry { get; set; } 
        public Product NiegelohSolingen { get; set; } 
        
        //Services
        public Service Varnishing { get; set; } 
        public Service BuildingNails { get; set; } 
        public Service VarnishingWithGelNailPolish { get; set; }
        public Service ManicureForMen { get; set; } 
        public Service Pedicure { get; set; }
        public Service MedicalPedicure { get; set; } 

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
                FirstName = "Admincho",
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
                ImageUrl = "https://nstage.bg/product/resistance-bain-force-architecte-shampoo/#&gid=1&pid=1",
                ProductCategoryId = 1
            };
            Syoss = new Product()
            {
                Id = 2,
                Name = "SYOSS",
                Price = 13.90m,
                StockQuantity = 20,
                Details = "Подходящ за боядисана или коса на кичури. Предпазва интензивността на цвета и го защитава от избледняване. Косата е здрава, лъскава и сияйна",
                ImageUrl = "https://galen.bg/sayas-shampoan-zashtita-na-tsveta-750ml",
                ProductCategoryId = 1
            };
            Nailberry = new Product()
            {
                Id = 3,
                Name = "NAILBERRY",
                Price = 42.09m,
                StockQuantity = 7,
                Details = "Цвят: Сияйно фуксия-розово. Fuchsia in Love L'Oxygéné от Nailberry внася в живота ви сияйна цветна радост и подсилва всяко облекло със своя сияен цвят. Брилянтният лилаво-розов нюанс може да се нанася без усилие и без ивици, с особено дълготраен резултат. Гамата лакове за нокти L'Oxygéné използва патентована технология, насочена към по-здравословна форма на маникюр. Резултатът е дишащи, водопропускливи и съдържащи кислород лакове, които са особено нежни към ноктите ви.Продуктът е веганнски, без тестове с животни и халал и без глутен.",
                ImageUrl = "https://co.nice-cdn.com/upload/image/product/large/default/nailberry-lak-za-nokti-fuchsia-in-love-loxygene-15-ml-447434-bg.jpg",
                ProductCategoryId = 3
            };
            NiegelohSolingen = new Product()
            {
                Id = 4,
                Name = "Niegeloh Solingen",
                Price = 5.60m,
                StockQuantity = 10,
                Details = "Права диамантена пила за нокти. Двустранна - едра и финна. Бяла пластмасова дръжка. Обща дължина: 9 см / 3.5 инча. Дължина острие: 5.5 см",
                ImageUrl = "https://zasalona.com/za-kozmetika/abrazivi/solingen-17",
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
