
using Pizzaria;
//Customer creation
Customer customer01 = new Customer("Foo");
Customer customer02 = new Customer("Bar");


//Pizza creation
Pizza pizza01 = new Pizza("Margherita", "Tomato & cheese", 69);
Pizza pizza02 = new Pizza("Vesuvio", "Tomato, cheese & ham", 75);
Pizza pizza03 = new Pizza("Capricciosa", "Tomato, cheese, ham & mushrooms", 80);
Pizza pizza04 = new Pizza("Calzone", "Baked pizza with tomato, cheese, ham & mushrooms", 80);


//Order creation
Order order01 = new Order(customer01, pizza01);
Order order02 = new Order(customer02, pizza02);
Order order03 = new Order(customer01, pizza04);


//Console 
Console.WriteLine(order01);
Menu.PrintMenu();
OrderRegister.PrintOrderList();
CustomerRegister.PrintCustomerList();
CustomerRegister.RemoveCustomerFromList(customer02);
Menu.RemovePizzaFromMenu(pizza01);
OrderRegister.RemoveOrderFromList(order01);