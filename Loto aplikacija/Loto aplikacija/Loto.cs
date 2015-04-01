using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto_aplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        ///<summary>
        ///konstruktor klase
        ///</summary>
        
        public Loto(){
            UplaceniBrojevi=new List<int>();
            DobitniBrojevi=new List<int>();

        }//public loto

        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti) {

            bool ispravni = false;
            UplaceniBrojevi.Clear();

            foreach (string v in korisnickeVrijednosti) {
                int broj = 0;
                if(int.TryParse(v, out broj)==true){
                
                    if(UplaceniBrojevi.Contains(broj)==false)
                    {
                    UplaceniBrojevi.Add(broj);
                    }//if
                }

                if (UplaceniBrojevi.Count == 7) { ispravni = true; }
            
            
            }//foreach

            return ispravni;
        }//unesiuplacenebrojeve


        public void GenerirajDobitnuKombinaciju() {

            DobitniBrojevi.Clear();
            Random generatorBrojeva = new Random();

            while (DobitniBrojevi.Count < 7) {

                int broj = generatorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false) {

                    DobitniBrojevi.Add(broj);
                }//if
            
            }//while



        
        }//GenerirajDobitnuKombinaciju


        public int IzracunBrojaPogotka() {
            int brojPogotka = 0;

            foreach (int broj in UplaceniBrojevi) {
                if (DobitniBrojevi.Contains(broj) == true) {
                    brojPogotka++;
                }
            
            }


            return brojPogotka;
        }

    }//class loto




}
