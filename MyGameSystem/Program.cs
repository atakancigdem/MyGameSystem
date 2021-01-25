using MyGameSystem.Activity.Abstract;
using MyGameSystem.Activity.Concrete;
using MyGameSystem.Activity.Concrete.DiscountService;
using MyGameSystem.Activity.Concrete.Platform;
using MyGameSystem.Activity.CustomerInformationVerification;
using MyGameSystem.Activity.CustomerInformationVerification.ValidateService;
using MyGameSystem.DataSaving.Abstract;
using MyGameSystem.DataSaving.Database;
using MyGameSystem.DataSaving.File;
using MyGameSystem.Entities;
using MyGameSystem.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace MyGameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService fileLogger = new FileLoggerService();
            ILoggerService databaseLogger = new DatabaseLoggerService();
            IPersonVerificationService personVerificationService = new ValidateService();
            ICustomerService gameManager = new GameManager(new List<ILoggerService> { databaseLogger });
            ICustomerService customerManager = new CustomerManager(new List<ILoggerService> { databaseLogger, fileLogger }, personVerificationService );
            IDiscountService summerSale = new DiscountSummerManager();

            IEntity game1 = new Game() { Name = "Game-1", Price = 100, StockQuantity = 5, Id = 1};
            IEntity game2 = new Game() { Name = "Game-2", Price = 200, StockQuantity = 7, Id = 2 };
            IEntity game3 = new Game() { Name = "Game-3", Price = 300, StockQuantity = 12, Id = 3 };

            Customer customer1 = new Customer() { Name = "Atakan", LastName = "Çiğdem", DateOfBirth = 2001, NationalityId = "1111111", Id = 1 };
            Customer customer2 = new Customer() { Name = "Furkan", LastName = "Çiğdem", DateOfBirth = 1991, NationalityId = "2222222", Id = 2 };
            Customer customer3 = new Customer() { Name = "Melek", LastName = "Gül", DateOfBirth = 1974, NationalityId = "3333333", Id = 3 };

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Add(game3);

            IGameTradeService epic = new EpicGamesManager(new List<IDiscountService> { summerSale });
            epic.BuyGame(customer1, game1);
            epic.BuyGame(customer2, game2);
            epic.BuyGame(customer3, game3);




        }
    }
}
