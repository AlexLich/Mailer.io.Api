using System.Collections.Generic;
using Mailer.io.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mailer.io.Data.ApplicationContextMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Mailer.io.Data.Contexts.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"ApplicationContextMigrations";
        }

        protected override void Seed(Mailer.io.Data.Contexts.ApplicationContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

//            var users = new List<ApplicationUser>()
//            {
//                new ApplicationUser()
//                {
//                    UserName = "Admin",
//                    Email = "Admin@mail.ru",
//                    EmailConfirmed = true,
//                    Firstname = "Админ",
//                    Lastname = "Админович"
//                },
//                new ApplicationUser()
//                {
//                    UserName = "Test",
//                    Email = "Test@mail.ru",
//                    EmailConfirmed = false,
//                    Firstname = "Тест",
//                    Lastname = "Тестович"
//                }
//            };
//
//            userManager.Create(users[0], "Admin54321");
//            userManager.Create(users[1], "Test54321");

            var persons = new List<Person>
            {
                new Person()
                {
                    Firstname = "Наруто",
                    Middlename = "Наутович",
                    Lastname = "Нарутов",
                    Phonenumber = "8916-111-11-11"
                },
                new Person()
                {
                    Firstname = "Сазке",
                    Middlename = "Сазкович",
                    Lastname = "Сазков",
                    Phonenumber = "8916-222-22-22"
                },
            };

            context.Persons.AddRange(persons);
            context.SaveChanges();

        }
    }
}
