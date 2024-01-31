using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep_z_Automatami_vendingowymi
{
    public class Zamowienia
    {

        public int getPrice(string name)
        {
            bool found = false;
            int cena = 0;
            Automat automats = new Automat();
            List<Automat> lista = automats.getAutomats();
            foreach (Automat automat in lista)
                if (automat.name == name)
                {
                    cena = automat.price;
                    found = true;
                }
            if (found == false)
                cena = 0;
            return cena;
        }
        public void addZamowienie(string client, string name, int quantity, DateOnly date)
        {
            int cena = getPrice(name);
            if (cena != 0)
                File.AppendAllText("./dane/zamowienia.txt", client + ", " + name + ", " + quantity + ", " + cena * quantity+ "zł" + ", " + date + "\n");
            else
                Console.WriteLine("Nie ma takiego automatu!!!");
        }

        public void removeZamowiene(string client, string name)
        {
            string[] orders = File.ReadAllLines("./dane/zamowienia.txt");
            string[] filteredOrders = orders.Where(line => !line.Contains(client) && !line.Contains(name)).ToArray();
            File.WriteAllLines("./dane/zamowienia.txt", filteredOrders);
        }


        public void showZamowienia()
        {
            string[] orders = File.ReadAllLines("./dane/zamowienia.txt");
            foreach(string order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
