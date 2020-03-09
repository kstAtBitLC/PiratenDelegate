using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenDelegate {

    delegate void MeinDelegateDatenTyp (string s1);
    delegate void MeinDelegateDatenTyp_2 (string s1, string s2, int n);


    class Program {
        static void Main ( string [] args ) {
            MeinDelegateDatenTyp mddt;
            MeinDelegateDatenTyp_2 martinDelegateVariable;

            Pirat p1 = new Pirat () {Name="Chris" };
            Pirat p2 = new Pirat () { Name = "Marko" };
            p1.ZweitName = " Der ungeheuerliche";
            p2.ZweitName = " Der phantastische";

            Gang g1 = new Gang () { Name = "Übergang" };
            Gang g2 = new Gang () { Name = "Durchgang" };

            g1.Add ( p1 );
            g1.Add ( p2 );

            mddt = new MeinDelegateDatenTyp (p1.ÄndereName);
            mddt += new MeinDelegateDatenTyp (p2.ÄndereZweitName);

            martinDelegateVariable = new MeinDelegateDatenTyp_2 ( g1.MeinDelegateDatenTyp_2_Methode_1);
            martinDelegateVariable += new MeinDelegateDatenTyp_2 ( g1.MeinDelegateDatenTyp_2_Methode_2);

            g1.MartinDelegateAufruf ( martinDelegateVariable, "Martin", "von der Burg", 10 );
  
            //p1.MachWasPirat (mddt, "_Aufruf 1");
            //p2.MachWasPirat (mddt, "_Aufruf_2");

            //Console.WriteLine (p1.Name + " " + p2.Name  + " " + p1.ZweitName  + " " +p2.ZweitName );

            Console.Read ();
        }
    }
}
