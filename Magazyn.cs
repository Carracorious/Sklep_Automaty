using Sklep_z_Automatami_vendingowymi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class Magazyn
    {
        public void getAmmount()
        {
            string[] ammont = File.ReadAllLines("./dane/magazyn.txt");
            foreach (string line in ammont) 
            {
                Console.WriteLine(line);
            }
        }

        public void addAutomat(string name)
        {
            bool found = false;
            string[] lines = File.ReadAllLines("./dane/magazyn.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] strings = lines[i].Split(", ");
                if (strings[0] == name)
                {   
                    found = true;
                    int storage = int.Parse(strings[1]) + 1;
                    strings[1] = storage.ToString();
                    lines[i] = string.Join(", ", strings);
                }
            }
            if (!found)
            {
                Console.WriteLine("Nie znaleziono automatu!!!");
            }
            string update = string.Join("\n", lines);
            File.WriteAllText("./dane/magazyn.txt", update);
        }
        public void removeAutomat(string name)
        {
            bool found = false;
            string[] lines = File.ReadAllLines("./dane/magazyn.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string[] strings = lines[i].Split(", ");
                if (strings[0] == name)
                {
                    found = true;
                    int storage = int.Parse(strings[1]) - 1;
                    strings[1] = storage.ToString();
                    lines[i] = string.Join(", ", strings);
                }
            }
            if (!found)
            {
                Console.WriteLine("Nie znaleziono automatu!!!");
            }
            string update = string.Join("\n", lines);
            File.WriteAllText("./dane/magazyn.txt", update);
        }
    }


}
