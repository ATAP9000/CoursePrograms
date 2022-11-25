namespace AsyncPratice
{
    internal class Program
    {
        public class Pizza
        {
            public string Type { get; set; }
            public Pizza(string t)
            {
                Type = t;
            }
        }
        public class Pizzeria
        {
            public Task<Pizza> ServePizza(string type)
            {
                return new Task<Pizza>(() =>
                {
                    return new Pizza(type);
                });
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pidiendo una Pizza de Pepperoni con mi amigo");
            Console.WriteLine("============================================");
            Task t = FirstWait();
            t.Wait();
            Task t2 = WaitingPizza();
            t2.Wait();
            Console.WriteLine("\nBuen provecho\n");
            TalkingAboutFootball();
            Console.WriteLine("\nPulse cualquier tecla para finalizar");
            Console.Read();
        }

        public async static Task FirstWait()
        {
            var myPizza = new Pizza("Pepperoni");
            Console.WriteLine("Llegamos a la pizzeria a las {0} y esperamos para hacer el pedido", DateTime.Now.ToString("T"));
            TalkingAboutFootball();
            await Task.Delay(10000);
            Console.WriteLine("Pedimos una Pizza de {0} a las {1}", myPizza.Type,DateTime.Now.ToString("T"));
        }

        private static async Task<Pizza> WaitingPizza()
        {
            Pizzeria dominos = new();
            var task = dominos.ServePizza("Pepperoni");
            task.Start();
            TalkingAboutFootball();
            var myPizza = await task;
            await Task.Delay(1000);
            Console.WriteLine("Nos traen la pizza de {0} a las {1}", myPizza.Type, DateTime.Now.ToString("T"));
            return myPizza;
        }

        private static void TalkingAboutFootball()
        {
            Console.WriteLine("Hablando de futbol");
            Console.WriteLine("bla bla bla");
            Console.WriteLine();
        }

    }
}