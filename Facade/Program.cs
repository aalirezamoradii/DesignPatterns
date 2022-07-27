using Facade;

var facadeForClient = new RestaurantFacade();

Console.WriteLine("----------------------CLIENT ORDERS FOR PIZZA----------------------------\n");
facadeForClient.GetNonVegPizza();
facadeForClient.GetVegPizza();

Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
facadeForClient.GetGarlicBread();
facadeForClient.GetCheesyGarlicBread();