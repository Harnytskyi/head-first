using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoes1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Чорний" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Clogs, Color = "Коричневий" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Wingtips, Color = "Чорний" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Білий" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Loafers, Color = "Червоний" });
            shoeCloset.Add(new Shoe()
            { Style = Style.Sneakers, Color = "Зелений" });
            string result = "";
            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe sqoe in shoeCloset)
            {
                result += "\n" + sqoe.Style.ToString() + " " + sqoe.Color;
            }
            Console.WriteLine(result);
            shoeCloset.RemoveAt(4);
            
            Shoe thirdShoe = shoeCloset[2];
            Shoe secondShoe = shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(thirdShoe))
                Console.WriteLine("Дивовижно!");
            
            
        }
    }
}
