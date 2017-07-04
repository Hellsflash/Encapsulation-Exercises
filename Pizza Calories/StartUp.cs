using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Calories
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Dough")
                {
                    try
                    {
                        Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        Console.WriteLine($"{dough.Callories():F2}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else if (tokens[0] == "Topping")
                {
                    try
                    {
                        Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                        Console.WriteLine($"{topping.Callories():F2}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                }
                else if (tokens[0] == "Pizza")
               
                {
                    var name = tokens[1];
                    int numOfToppings = 0;
                    numOfToppings = int.Parse(tokens[2]);

                    if (numOfToppings>10)
                    {
                        Console.WriteLine("Number of toppings should be in range [0..10].");
                        return;
                        
                    }

                    input = Console.ReadLine();
                    tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                    Pizza pizza;

                    try
                    {
                        Dough dough = new Dough(tokens[1], tokens[2], int.Parse(tokens[3]));
                        pizza = new Pizza(name, dough);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }

                    for (int i = 0; i < numOfToppings; i++)
                    {
                        input = Console.ReadLine();
                        tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                            pizza.AddTopping(topping);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            return;
                        }
                    }
                    Console.WriteLine($"{pizza.Name} - {pizza.Callories():F2}");
                    return;
                }
                input = Console.ReadLine();
            }
        }
    }
}
