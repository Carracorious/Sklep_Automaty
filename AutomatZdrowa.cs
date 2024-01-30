using Sklep_z_Automatami_vendingowymi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class AutomatZdrowa : Automat
    {
        public string healthyType;
        public int discs;
        public int slots;
        public List<Automat> getHealthyAutomats()
        {
            List<Automat> zdrowaAutomaty = new List<Automat>();
            string[] info = File.ReadAllLines("./dane/automaty.txt");

            foreach (string line in info)
            {
                string[] strings = line.Split(", ");

                AutomatZdrowa automat = new AutomatZdrowa
                {
                    name = strings[0],
                    width = int.Parse(strings[1]),
                    height = int.Parse(strings[2]),
                    depth = int.Parse(strings[3]),
                    price = int.Parse(strings[4]),
                    type = strings[5],
                    healthyType = strings[6],
                    discs = int.Parse(strings[7]),
                    slots = int.Parse(strings[8])
                };
                if (automat.type == "Zdrowa Żywność")
                {
                    zdrowaAutomaty.Add(automat);
                }

            }
            return zdrowaAutomaty;
        }
        public void getHealthyAutomatInfo()
        {
            foreach (AutomatZdrowa automat in getHealthyAutomats())
            {
                string HealthyAutomatInfo = "";
                HealthyAutomatInfo += "Nazwa: " + automat.name + "\n";
                HealthyAutomatInfo += "Wymiary: " + automat.width + "x" + automat.height + "x" + automat.depth + "\n";
                HealthyAutomatInfo += "Cena: " + automat.price + "\n";
                HealthyAutomatInfo += "Typ: " + automat.type + "\n";
                HealthyAutomatInfo += "Rodzaj żywności: " + automat.healthyType + "\n";
                HealthyAutomatInfo += "Ilość dysków i slotów: " + automat.discs + "x" + automat.slots + "\n";
                Console.WriteLine(HealthyAutomatInfo);
            }
        }
    }
}

