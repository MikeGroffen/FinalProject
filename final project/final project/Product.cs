using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    class Product
    {
        public List<ProductInformatie> producten = new List<ProductInformatie>();

        public void product ()
        {
            //hier kunnen we nieuwe producten toevoegen. Titel, Beschrijving, prijs, bool of het digitaal is of niet
            producten.Add(new ProductInformatie("Eendenhoofd", "beschrijving van een eendenhoofd. 600kg", 30.51f, "Fysiek")); 
            producten.Add(new ProductInformatie("Paard", "wat een paard nodig heeft om te beschrijven", 389.99f, "Fysiek")); 
            producten.Add(new ProductInformatie("Koe", "beschrijving van een dikke koe, voor vlees misschien ofzo", 450.99f, "Fysiek"));
            producten.Add(new ProductInformatie("aap", "beschrijving van een eendenhoofd. 600kg", 310.51f, "Fysiek"));
            producten.Add(new ProductInformatie("kippensoep", "wat een paard nodig heeft om te beschrijven", 39.99f, "Digitaal"));
            producten.Add(new ProductInformatie("telefoon", "beschrijving van een dikke koe, voor vlees misschien ofzo", 40.99f, "Fysiek"));
            producten.Add(new ProductInformatie("stenen", "beschrijving van een eendenhoofd. 600kg", 330.51f, "Fysiek"));
            producten.Add(new ProductInformatie("weetikveel", "wat een paard nodig heeft om te beschrijven", 89.99f, "Fysiek"));
            producten.Add(new ProductInformatie("straattaal", "JA DAT IS TE KOOP", 0.99f, "Fysiek"));
            producten.Add(new ProductInformatie("bamboem", "beschrijving van een eendenhoofd. 600kg", 30.51f, "Fysiek"));
            producten.Add(new ProductInformatie("ikprobeerhemoptevullen", "wat een paard nodig heeft om te beschrijven", 389.99f, "Fysiek"));
            producten.Add(new ProductInformatie("Maak er maar wat leuks van", "beschrijving van een dikke koe, voor vlees misschien ofzo", 450.99f, "Fysiek"));
        }
    }
}
