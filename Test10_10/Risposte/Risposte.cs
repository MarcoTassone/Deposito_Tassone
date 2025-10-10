using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test10_10.Risposte
{
    public class Risposte
    {
        // Marco Tassone, tassonemarco67@gmail.com
        // 2. 1
        // 3. 1
        // 4. 3
        // 5. 1
        //6. l'incapsulamento è uno dei 3 principi fondamentali della OOP che permette l'accesso ai dati in base a come li impostiamo, 
        // ovvero i dati potrebbero essere (tra quelli più utilizzati) public, private e protected.

        // Esempio di incapsulamento:

        // private string _psw;

        // public string Psw
        // {
        //    get {return _psw}
        //    set 
        //    {
        //       if(value != " ")
        //       {
        //          _psw = value;
        //        }
        //     }
        // }
        //7. l'ereditarietà è uno dei 3 principi fondamentali della OOP che permette la creazione di classi derivate (o figlio) basandosi sulla classe base(o padre) 
        // acquisendone anche i vari metodi e attributi.

        // Esempio di ereditarietà:

        // public class Operatore
        // {
        //   public string Nome;
        //   public string Turno;

        //   public Operatore(string nome, string turno)
        //   {
        //     Nome = nome;
        //     Turno = turno;
        //   }
        // }

        // public class OperatoreEmergenza : Operatore
        // {
        //    public int LivelloEmergenza;

        //    public OperatoreEmergenza(string nome, string turno, int livelloEmergenza)  : base(nome, turno)
        //    {
        //       LivelloEmergenza = livelloEmergenza;
        //    }
        // }

        //8.il polimorfismo è uno dei 3 principi fondamentali della OOP e che rende il codice più estendibile. Permette l'implementazione, alle classi derivate, di metodi virtual presenti nella classe base con il metodo override.

        // Esempio di polimorfismo:

        // //nella classe padre
        // public virtual void Stampa()
        // {
        //     Console.WriteLine("stampo cose");
        // }

        // //nella classe figlio
        // public override void Stampa()
        // {
        //     Console.WriteLine("non stampo più cose");
        // }

        //9. la DevOPS è un insieme di pratiche che permettono lo sviluppo di vita di un software in modo più automatizzato e veloce. 
        // Le sue fasi principali sono: pianificazione, sviluppo, building, testing, deployment, monitoraggio.

        //10.

        //11. 
    }
}