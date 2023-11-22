using State.Models;

Order order = new(500);

order.ApplyDiscount();

Console.WriteLine(order.Value);

order.Approve();

order.ApplyDiscount();

Console.WriteLine(order.Value);

Console.ReadKey();

// After executing the program the result must be: 475 and 465.5