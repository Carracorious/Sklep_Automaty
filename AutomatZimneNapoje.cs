using Sklep_z_Automatami_vendingowymi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class AutomatZimneNapoje : Automat
    {
        public int cupCapacity;
        public string cupType;

        public List<Automat> getColdAutomats()
        {
            List<Automat> zimneAutomaty = new List<Automat>();
            string[] info = File.ReadAllLines("./dane/automaty.txt");

            foreach (string line in info)
            {
                string[] strings = line.Split(", ");

                AutomatZimneNapoje automat = new AutomatZimneNapoje
                {
                    name = strings[0],
                    width = int.Parse(strings[1]),
                    height = int.Parse(strings[2]),
                    depth = int.Parse(strings[3]),
                    price = int.Parse(strings[4]),
                    type = strings[5],
                    cupType = strings[6],
                    cupCapacity = int.Parse(strings[7])
                };
                if (automat.type == "Zimne Napoje")
                {
                    zimneAutomaty.Add(automat);
                }

            }
            return zimneAutomaty;
        }
        public void getColdAutomatInfo()
        {
            foreach (AutomatZimneNapoje automat in getColdAutomats())
            {
                string ColdAutomatInfo = "";
                ColdAutomatInfo += "Nazwa: " + automat.name + "\n";
                ColdAutomatInfo += "Wymiary: " + automat.width + "x" + automat.height + "x" + automat.depth + "\n";
                ColdAutomatInfo += "Cena: " + automat.price + "\n";
                ColdAutomatInfo += "Typ: " + automat.type + "\n";
                ColdAutomatInfo += "Rodzaj pojemnika: " + automat.cupType + "\n";
                ColdAutomatInfo += "Pojemność: " + automat.cupCapacity + "ml\n";
                Console.WriteLine(ColdAutomatInfo);
            }
        }
    }
}
