using MammasPizza;
// Obejct lists of toppingd for the pizza
List<Topping> toppings1 = new List<Topping> { new Topping("Tomato", 0, true ), new Topping("Cheese", 4, true), new Topping("Ham", 7, false), new Topping("Mushroom", 5, true)};
List<Topping> toppings2 = new List<Topping> { new Topping("Tomato", 0, true), new Topping("Cheese", 4, true), new Topping("Mussels", 10, false), new Topping("Shrimp", 9, false), new Topping("Garlic", 4, true) };
List<Topping> toppings3 = new List<Topping> { new Topping("Tomato", 0, true), new Topping("Cheese", 4, true), new Topping("Onion", 5, true), new Topping("Meat sauce", 10, false) };
// Pizza objects for customers
Pizza piz1 = new Pizza("3", 80, toppings1, "Capricossa");
Pizza piz2 = new Pizza("6", 85, toppings2, "Marinara");
Pizza piz3 = new Pizza("8", 75, toppings3, "Italiana");
//Customer objects
Customer bob = new Customer("Bob", "Hungry Highway 6, 4000", "12345678");
Customer anya = new Customer("Anya", "Munchies Mile 53, 8210", "82114564");
Customer misha = new Customer("Misha", "Snack Street 23, 2900", "56987412");
// Adding pizzas to customer orders
bob.Order.AddToOrder(piz1);
anya.Order.AddToOrder(piz2);
misha.Order.AddToOrder(piz3);
// Testing objects by printing out
Console.WriteLine(bob.ToString());
bob.Order.PrintInfo();
Console.WriteLine(anya.ToString());
anya.Order.PrintInfo();
Console.WriteLine(misha.ToString());
misha.Order.PrintInfo();
