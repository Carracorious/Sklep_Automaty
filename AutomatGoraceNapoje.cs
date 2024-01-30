using Sklep_z_Automatami_vendingowymi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class AutomatGoraceNapoje : Automat
    {
        public int cupCapacity;
        public int cupQuantity;
        public string cupType;

        public List<Automat> getHotAutomats()
        {
            List<Automat> goraceAutomaty = new List<Automat>();
            string[] info = File.ReadAllLines("./dane/automaty.txt");

            foreach (string line in info)
            {
                string[] strings = line.Split(", ");

                AutomatGoraceNapoje automat = new AutomatGoraceNapoje
                {
                    name = strings[0],
                    width = int.Parse(strings[1]),
                    height = int.Parse(strings[2]),
                    depth = int.Parse(strings[3]),
                    price = int.Parse(strings[4]),
                    type = strings[5],
                    cupCapacity = int.Parse(strings[7]),
                    cupQuantity = int.Parse(strings[8])
                };
                if(automat.type == "Gorace Napoje")
                {
                    goraceAutomaty.Add(automat);
                }
                
            }
            return goraceAutomaty;
        }
        public void getHotAutomatInfo()
        {
            foreach (AutomatGoraceNapoje automat in getHotAutomats())
            {
                string HotAutomatInfo = "";
                HotAutomatInfo += "Nazwa: " + automat.name + "\n";
                HotAutomatInfo += "Wymiary: " + automat.width + "x" + automat.height + "x" + automat.depth + "\n";
                HotAutomatInfo += "Cena: " + automat.price + "\n";
                HotAutomatInfo += "Pojemność kubka: " + automat.cupCapacity + "ml\n";
                HotAutomatInfo += "Ilość kubków: " + automat.cupQuantity + "\n";
                Console.WriteLine(HotAutomatInfo);
            }
        }
    }
}
