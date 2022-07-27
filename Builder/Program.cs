using Builder;

Console.WriteLine("---------------------List Of Toys---------------------");  
var toyACreator = new ToyCreator(new ToyABuilder());  
toyACreator.CreateToy();
toyACreator.GetToy().WriteConsole();  
var toyBCreator = new ToyCreator(new ToyBBuilder());  
toyBCreator.CreateToy();  
toyBCreator.GetToy().WriteConsole();