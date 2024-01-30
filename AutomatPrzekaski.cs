using Sklep_z_Automatami_vendingowymi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class AutomatPrzekaski : Automat
    {
        public string snackType;
        public int rows;
        public int cols;
        public List<Automat> getSnackAutomats()
        {
            List<Automat> przekaskiAutomaty = new List<Automat>();
            string[] info = File.ReadAllLines("./dane/automaty.txt");

            foreach (string line in info)
            {
                string[] strings = line.Split(", ");

                AutomatPrzekaski automat = new AutomatPrzekaski
                {
                    name = strings[0],
                    width = int.Parse(strings[1]),
                    height = int.Parse(strings[2]),
                    depth = int.Parse(strings[3]),
                    price = int.Parse(strings[4]),
                    type = strings[5],
                    snackType = strings[6],
                    rows = int.Parse(strings[7]),
                    cols = int.Parse(strings[8])
                };
                if (automat.type == "Przekąski")
                {
                    przekaskiAutomaty.Add(automat);
                }

            }
            return przekaskiAutomaty;
        }
        public void getSnackAutomatInfo()
        {
            foreach (AutomatPrzekaski automat in getSnackAutomats())
            {
                string SnackAutomatInfo = "";
                SnackAutomatInfo += "Nazwa: " + automat.name + "\n";
                SnackAutomatInfo += "Wymiary: " + automat.width + "x" + automat.height + "x" + automat.depth + "\n";
                SnackAutomatInfo += "Cena: " + automat.price + "\n";
                SnackAutomatInfo += "Typ: " + automat.type + "\n";
                SnackAutomatInfo += "Rodzaj przekąski: " + automat.snackType + "\n";
                SnackAutomatInfo += "Ilość rzędów i kolumn: " + automat.rows + "x" + automat.cols +"\n";
                Console.WriteLine(SnackAutomatInfo);
            }
        }
    }
}

