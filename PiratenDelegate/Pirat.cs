using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenDelegate {
    class Pirat {
        public string Name { get; set; }
        public string ZweitName { get; set; }


        public void SichbemerkbarMachen (Gang gang) {
            Console.WriteLine ("Hallo ich bin der Pirat {0}", Name);
        }

        public void MachWasPirat ( MeinDelegateDatenTyp mdg, string s ) {
            mdg (s);
        }

        public void ÄndereName (string s) {
            Name = Name + s;
        }

        public void ÄndereZweitName ( string s ) {
            ZweitName = ZweitName + s;
        }

    }
}
