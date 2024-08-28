Console.WriteLine("Selct order");
Console.WriteLine("Input a for akara and p for pap");
String selectOrder = Console.ReadLine().ToUpper();

Console.WriteLine("Input amout of akara or pap you want to buy");

Console.WriteLine("Input amout of akara or pap you want to buy");


int limit = 5;

switch (limit)
{
    case 1:
        while (limit > 5)
        {
            limit = 5;
            Console.WriteLine(limit);
            String order;
            Console.WriteLine("Place your order");
        }
        if (limit == 5)
        {
            Console.WriteLine("You exceeded the limit");
            return;
        }
        {
            string? a = null;
            string? b = null;
            string? order = null;
            if (order == a)
            {
                Console.WriteLine("Input amout of akara or pap you want to buy");
                return;
            }
            else if (order == b)
            {
                Console.WriteLine("Input amout of akara or pap you want to buy");
                return;
            }
            else
            {
                Console.WriteLine("invalid order");
            }
        }
        if (String.Equals(selectOrder, "p"))
        {
            Console.WriteLine("return to the order button");
            return;
        }
        else
        {

            Console.WriteLine("wrong entry");
            return;
        }
        break;
}