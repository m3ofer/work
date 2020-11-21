using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    enum Etat { Fermé, Ouvert }
    enum Jour { Lundi, Mardi, Vendredi }
    enum Climat { Gel = -5, Froid = 0, Tempere = 25, Chaud = 30, Cannicule = 40 }
    class Program
    {
        static void Main(string[] args)
        {
            #region classes
            //Produit p1 = new Produit();
            //Console.WriteLine(p1);
            //p1.Code = 1000;
            //p1.Designation = "TV";
            //Console.WriteLine(p1.Code+" "+p1.Designation);

            Employe e1 = new Employe();
            Console.WriteLine(e1.ToString());
            e1.Matricule = 50;
            e1.NomPrenom = "";
            e1.Salaire = e1.Salaire - 10000;
            Console.WriteLine(e1);
            Console.WriteLine(e1.Matricule);
            //e1.NbHjour = 12;

            Employe e2 = new Employe(200);
            Console.WriteLine(e2.ToString());
            Employe e3 = new Employe(100, "Bendriss Ali");
            Console.WriteLine(e3.ToString());
            #endregion
            #region string
            //string s1 = "Bonjour";
            //string s2=" tout le monde";
            //string s3 = "bonjour tout le monde";
            ////s1[0] = 'b';//interdit
            //s1=s1 + s2;
            //if (s1 == s3)//test de l'égalité des chaines
            //    Console.WriteLine("égalité");
            //else
            //    Console.WriteLine("Différentes");

            //Console.WriteLine("entrer le nom 1:");
            //s1 = Console.ReadLine();
            //Console.WriteLine("entrer le nom 2:");
            //s3 = Console.ReadLine();

            //int i = s1.CompareTo(s3);
            //Console.WriteLine(i);
            //if (i < 0)
            //    Console.WriteLine($"{s1} est inferieur à {s3}");
            //else
            //    if (i > 0)
            //        Console.WriteLine($"{s1} est superieur à {s3}");
            //    else
            //        Console.WriteLine($"{s1} est égale à {s3}");

            //s1 = Environment.MachineName;
            //s2 = Environment.UserName;
            //s3 = Environment.CurrentDirectory;
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //int pos = s3.IndexOf("bin");
            //Console.WriteLine(pos);
            //string[] t= s3.Split('\\');
            //foreach (string item in t)
            //{
            //    Console.WriteLine(item);
            //}
            //string s = new string('*', 50);
            //Console.WriteLine(s);
            //StringBuilder ch = new StringBuilder(s);
            //Console.WriteLine(ch);
            //string s4 =ch.ToString();
            //Console.WriteLine(s4);
            #endregion
            #region tableaux

            //int[,] t3 = new int[2, 3] { { 1, 3, 5 },{ 6, 7, 8 } };//matrice 2 lignes 3 colonnes
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(t3[i, j]+" \t");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] t2 = new int[3][];//tableau de tableaux
            //for (int i = 0; i < 3; i++)
            //{
            //    t2[i] = new int[ 2 * i + 1];
            //    for (int j = 0; j < t2[i].Length; j++)
            //    {
            //        t2[i][j] = (i+1) * j;
            //        Console.Write(t2[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //int[] t1 = new int[] { 12, 15, 13, 16 };
            //int[] t2 = (int[])t1.Clone();

            //Array.Sort(t2);
            //Array.Reverse(t2);
            //foreach (int item in t1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********************");
            //foreach (int item in t2)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] t3= { 100, 200, 300, 400 };

            //Console.WriteLine("**********************");
            //Array.Copy(t1,2,t3,1,2);//copie d'une portion du tableau t1 dans t3
            //foreach (int item in t3)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********************");
            //t1 = new int[10];
            //Random rand = new Random();
            //for (int i = 0; i < t1.Length; i++)
            //{
            //    t1[i] = rand.Next(20);
            //}
            //foreach (int item in t1)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region test enum
            //Etat etat;
            //etat = Etat.Fermé;
            //Console.WriteLine("etat=" + etat+" valeur="+(int)etat);
            //Jour j;
            //Console.WriteLine("entrer l'ordre du jour (0..7)");
            //int pos = int.Parse(Console.ReadLine());
            //switch (pos)
            //{
            //    case 0:j = Jour.Lundi;
            //        break;
            //    case 1:j = Jour.Mardi;
            //        break;
            //    default:
            //        j = Jour.Vendredi;
            //        break;
            //}
            //Console.WriteLine("le jour est :" + j);
            //Climat c = Climat.Gel;
            //Console.WriteLine("Climat " + c + " temperature avoisinant les " + (int)c);
            #endregion
            #region test exception

            //long a, b, c;
            //string s1="", s2="";
            //try
            //{
            //    Console.WriteLine("entrer deux entiers:");
            //s1 = Console.ReadLine();
            //s2 = Console.ReadLine();
            //a = long.Parse(s1);
            //b = long.Parse(s2);

            //c = a / b;
            //Console.WriteLine(c);
            //}
            //catch (OverflowException ex)
            //{
            //    double aa = double.Parse(s1);
            //    double bb = double.Parse(s2);
            //    c = (long)(aa / bb);
            //    Console.WriteLine("c=" + c);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    c = int.MaxValue;
            //    Console.WriteLine("c est infini ~" + c);
            //}
            //catch (FormatException ex)
            //{

            //    Console.WriteLine("erreur, présence de caractères qui ne sont pas des entiers");
            //    return;
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("erreur de saisie!!" + ex.Message);
            //    return;
            //}
            //Console.WriteLine("suite du programme");
            #endregion

            #region test foreach

            /*
            String[] T = { "Lundi", "Mardi", "Vendredi" };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(T[i]);
            }
            foreach (string s in T)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();*/
            #endregion

        }
    }
}
