using Microsoft.EntityFrameworkCore;
using PediatricsDepartment.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PediatricsDepartment.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Define your DbSets for each of the models
        public DbSet<Hoca> Hocalar { get; set; }
        public DbSet<Assistant> Assistants { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<EmergencyAlert> EmergencyAlerts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentID = 1,
                    Name = "Çocuk Acil",
                    Description = "Çocuk Acil bölümü, hastanelerin çocuklara" +
                    "özel olarak tasarlanmış bir birimidir ve acil tıbbi müdahale " +
                    "gerektiren durumlarda 0-18 yaş arası çocuklara hizmet vermektedir. " +
                    "Bu bölümde, çocuk hastaların ihtiyaçlarına yönelik donanımlı ekipmanlar " +
                    "ve alanında uzman pediatrik doktorlar ile hemşireler görev alır.Amaç, küçük" +
                    " hastaların sağlık sorunlarını en kısa sürede çözerek, onların güvenliğini " +
                    "ve iyileşme sürecini en üst düzeye çıkarmaktır. Çocuk Acil bölümü, 7/24 hizmet" +
                    " vererek her türlü acil durumda ailelere güvence sağlar.",
                    TotalBeds = 100,
                    EmptyBeds = 10
                },
                new Department
                {
                    DepartmentID = 2,
                    Name = "Çocuk Yoğun Bakımı",
                    Description = "Çocuk Yoğun Bakım bölümü, hayati tehlike taşıyan hastalıklar " +
                    "veya durumlar yaşayan 0-18 yaş arası çocukların tedavi edildiği özel bir" +
                    " birimdir. Bu bölüm, ileri teknolojiye sahip tıbbi cihazlarla donatılmış " +
                    "olup, kritik durumdaki çocukların sürekli izlenmesi ve desteklenmesi için" +
                    " tasarlanmıştır. Birimde, çocukların sağlıklarını stabilize etmek ve " +
                    "iyileşmelerini sağlamak için her hasta özel bir yaklaşımla ele alınır. " +
                    "Ebeveynlerin de bu süreçte bilgilendirilmesi ve desteklenmesi sağlanarak" +
                    " çocukların hem fiziksel hem de duygusal ihtiyaçlarına kapsamlı bir şekilde " +
                    "yanıt verilir.",
                    TotalBeds = 50,
                    EmptyBeds = 5
                },

                new Department
                {
                    DepartmentID = 3,
                    Name = "Çocuk Hematolojisi ve Onkolojisi",
                    Description = "Çocuk Hematolojisi ve Onkolojisi bölümü, çocuklarda" +
                    " kan hastalıkları ve kanserlerin tanı ve tedavisiyle ilgilenen bir" +
                    " tıp dalıdır. Hematoloji, kanın yapısı, fonksiyonları ve hastalıklarını " +
                    "incelerken, onkoloji ise kanserin teşhis ve tedavisi üzerine odaklanır." +
                    " Bu alanda tedavi, multidisipliner bir yaklaşım gerektirir ve çocukların " +
                    "hem fiziksel hem de psikolojik olarak desteklenmesi çok önemlidir. Uzman" +
                    " doktorlar, hem tedavi sürecini yönlendirir hem de çocukların yaşam " +
                    "kalitelerini artırmak için çalışırlar.",
                    TotalBeds = 50,
                    EmptyBeds = 20
                }
            );

            modelBuilder.Entity<Hoca>().HasData(
                new Hoca
                {
                    HocaID = 25368,
                    FirstName = "Alice",
                    LastName = "Smith",
                    Email = "alicesmith@gmail.com",
                    DepartmentID = 1
                },

                new Hoca
                {
                    HocaID = 61291,
                    FirstName = "Arsalan",
                    LastName = "Köybaşı",
                    Email = "ak.1995@gmail.com",
                    DepartmentID = 2
                },

                new Hoca
                {
                    HocaID = 78642,
                    FirstName = "Cho",
                    LastName = "Ling",
                    Email = "choling@gmail.com",
                    DepartmentID = 3
                }

            );

            modelBuilder.Entity<Assistant>().HasData(
               new Assistant
               {
                   AssistantID = 1,
                   FirstName = "Masah",
                   LastName = "Jsri",
                   Email = "masah.jsri@sakarya.ogr.tr",

               },

               new Assistant
               {
                   AssistantID = 2,
                   FirstName = "Katara",
                   LastName = "Lee",
                   Email = "kataraalee@gmail.com",

               },

               new Assistant
               {
                   AssistantID = 3,
                   FirstName = "Amina",
                   LastName = "Ndiaye",
                   Email = "amina@gmail.com",

               },

               new Assistant
               {
                   AssistantID = 4,
                   FirstName = "Hiroshi",
                   LastName = "Tanaka",
                   Email = "tanakahiro@gmail.com",

               },

                new Assistant
                {
                    AssistantID = 5,
                    FirstName = "Li",
                    LastName = "Wei",
                    Email = "weiwei@gmail.com",

                },

                 new Assistant
                 {
                     AssistantID = 6,
                     FirstName = "Anastasia",
                     LastName = "Ivanova",
                     Email = "lostana@gmail.com",

                 },

                  new Assistant
                  {
                      AssistantID = 7,
                      FirstName = "Juan",
                      LastName = "Rodríguez",
                      Email = "juantaco@gmail.com",

                  },

                   new Assistant
                   {
                       AssistantID = 8,
                       FirstName = "Camille",
                       LastName = "Dupont",
                       Email = "french@gmail.com",

                   },

                    new Assistant
                    {
                        AssistantID = 9,
                        FirstName = "Luca",
                        LastName = "Rossi",
                        Email = "lucaluci@gmail.com",

                    },


                     new Assistant
                     {
                         AssistantID = 10,
                         FirstName = "Paulo",
                         LastName = "Silva",
                         Email = "silversilva@gmail.com",

                     },

                      new Assistant
                      {
                          AssistantID = 11,
                          FirstName = "Will",
                          LastName = "Turner",
                          Email = "piratewill@gmail.com",

                      },
                       new Assistant
                       {
                           AssistantID = 12,
                           FirstName = "Elizabeth",
                           LastName = "Swann",
                           Email = "ladyliz@gmail.com",

                       },
                        new Assistant
                        {
                            AssistantID = 13,
                            FirstName = "Cho",
                            LastName = "Ling",
                            Email = "choling@gmail.com",

                        }, new Assistant
                        {
                            AssistantID = 14,
                            FirstName = "Elif",
                            LastName = "Yılmaz",
                            Email = "choling@gmail.com",

                        }, new Assistant
                        {
                            AssistantID = 15,
                            FirstName = "Ashley",
                            LastName = "Alexander",
                            Email = "urmomashe@gmail.com",

                        }

             );

            /*Shifts are here*/

          /*  modelBuilder.Entity<Shift>().HasData(
            new Shift
            {
                ShiftID = 1,
                AssistantID = 12,
                ShiftStart = new DateTime(2024, 12, 8, 8, 0, 0), // 8:00 AM
                ShiftEnd = new DateTime(2024, 12, 8, 16, 0, 0),
                DepartmentId = 2,

            }

        );*/

        }



    }
}
