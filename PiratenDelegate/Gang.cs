using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenDelegate {
    class Gang {
        public string Name { get; set; }
        private List<Pirat> pirats = new List<Pirat> ();

        public void Add (Pirat pirat) {
            pirats.Add (pirat);
        }

        public void ZeigtEuchIhrPiraten () {
            foreach ( var item in pirats ) {
                Console.WriteLine (item);
            }
        }

        public void MeinDelegateDatenTyp_2_Methode_1 ( string s1, string s2, int n ) {

            for ( int i = 0 ; i < n ; i++ ) {
                Console.WriteLine (s1 +" " + s2 + " Methode_1");
            }
            
        }
        public void MeinDelegateDatenTyp_2_Methode_2 ( string s1, string s2, int n ) {
            for ( int i = 0 ; i < n ; i++ ) {
                Console.WriteLine ( s1 + " " + s2 + " Methode_2" );
                Console.WriteLine ("Hallo Martin");
            }
        }

        public void MartinDelegateAufruf ( MeinDelegateDatenTyp_2 martinFunktionszeiger, string s1, string s2, int n ) {
            martinFunktionszeiger ( s1, s2, n );
        }


    }
}
