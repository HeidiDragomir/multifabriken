
using Multifabriken;
using Multifabriken.Products;

var order = new Order();

//order.AddProduct(new Car());
order.AddProduct(new Sweets());
order.AddProduct(new Pipe());
order.AddProduct(new OatMilk());

var car = new Car();


Console.ReadKey();
