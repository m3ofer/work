using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    class Employe
    {
        int matricule;
        string nomPrenom;
        double salaire;
        string pays = "Maroc";
        const double taxeIGR = 0.20;
        readonly int nbHjour;
        public int Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                matricule = value;
            }
        }
        public string NomPrenom
        {
            get
            {
                return nomPrenom;
            }
            set
            {
                if (value == "")
                    nomPrenom = "???????";
                else
                    nomPrenom = value;
            }
        }

        public double Salaire { get { return salaire; } set { salaire = value; } }
        public string Pays { get => pays; set => pays = value; }

        public int NbHjour { get => nbHjour; }

        public Employe()
        {
            Matricule = 0;
            NomPrenom = "";
            nbHjour = 8;//ça devient maintenant une constante
            Salaire = (nbHjour * 20 * 100) * (1 - taxeIGR);
        }
        public Employe(int matricule)
            : this()//appel au 1er constructeur
        {
            this.matricule = matricule;
        }
        public Employe(int matricule, string nomPrenom)
            : this(matricule)
        {
            this.nomPrenom = nomPrenom;
        }

        public override string ToString()
        {
            return matricule + " " + nomPrenom + " " + Pays + " " + Salaire;
        }
    }
}
