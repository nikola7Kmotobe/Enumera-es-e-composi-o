using System;
using Enumerações_e_Composição.entities;
using Enumerações_e_Composição.entities.enums;

Order order = new Order {
    Id = 1,
    Moment = DateTime.Now,
    Status = OrderStatus.Delivered
};

Console.WriteLine(order);

//Convertendo enum Para String
string txt = OrderStatus.PendingPayment.ToString();
// Convertendo String para um tipo enumerado
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);
Console.WriteLine(txt);
