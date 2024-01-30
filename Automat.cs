using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class Automat
    {
        public string name;
        public int width;
        public int height;
        public int depth;
        public int price;
        public string type;

        public List<Automat> getAutomats()
        {
            List<Automat> automaty = new List<Automat>();
            string[] info = File.ReadAllLines("./dane/automaty.txt");

            foreach (string line in info)
            {
                string[] strings = line.Split(", ");

                Automat automat = new Automat
                {
                    name = strings[0],
                    width = int.Parse(strings[1]),
                    height = int.Parse(strings[2]),
                    depth = int.Parse(strings[3]),
                    price = int.Parse(strings[4]),
                    type = strings[5]
                };

                automaty.Add(automat);
            }
            return automaty;
        }

        public void getAutomatInfo()
        {
            foreach (Automat automat in getAutomats())
            {
                string AutomatInfo = "";
                AutomatInfo += "Nazwa: " + automat.name + "\n";
                AutomatInfo += "Wymiary: " + automat.width + "x" + automat.height + "x" + automat.depth + "\n";
                AutomatInfo += "Cena: " + automat.price + "\n";
                AutomatInfo += "Typ: " + automat.type + "\n";
                Console.WriteLine(AutomatInfo);
            }
        }
    }
}