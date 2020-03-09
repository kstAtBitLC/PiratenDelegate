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

    }
}
