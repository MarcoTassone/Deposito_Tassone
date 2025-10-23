using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lezione23_10.Mattina;

namespace Lezione23_10
{
    #region esempi delegate
    // public delegate void Saluto(string nome);
    // public delegate int OperationDelegate(int a, int b); //delegate con ritorno di somma
    #endregion

    #region esercizio operazioni delegate
    public delegate int Operazione(int a, int b);

    public delegate string Logger(string messaggio);
    #endregion

    #region 
    public delegate void PagamentoCompletatoHandler(string id, decimal totale);
    #endregion


    public class Program
    {
        #region esempi metodi delegate
        // static void Ciao(string nome)
        // {
        //     Console.WriteLine($"Ciao! {nome}");
        // }

        // static int Add(int x, int y) //metodo delegate con return
        // {
        //     return x + y;
        // }
        #endregion

        #region metodi esercizio operazioni delegate
        static int Somma(int a, int b) //metodo delegate con return
        {
            return a + b;

        }

        static int Moltiplica(int a, int b)
        {
            return a * b;
        }

        static int EseguiOperazione(int a, int b, Operazione op)
        {
            return op(a, b);
        }

        static string LogIn(string messaggio)
        {
            return $"[LogIn] {messaggio}";
        }

        static string LogOut(string messaggio)
        {
            return $"[LogOut] {messaggio}";
        }

        #endregion

        #region esercizio pagamento completato delegate

        static void EseguiPagamentoCompletato(string id, decimal totale, PagamentoCompletatoHandler handler)
        {
            handler(id, totale);
        }
        #endregion

        public static void Main(string[] args)
        {
            #region esempi delegate
            // Saluto s = Ciao;
            // s("Marco");

            // s += nome => Console.WriteLine($"Benvenuto {nome}"); //Delegate Multicast


            // OperationDelegate op1 = Add; //Delegate Multicast

            // Action<string> saluta = nome => Console.WriteLine($"Ciao, {nome}");
            // saluta("Michele");
            // Func<int, int, int> somma = (a, b) => a + b;
            // Console.WriteLine(somma(3, 4));

            // Pulsante p = new Pulsante();
            // p.Premuto += () => Console.WriteLine($"Evento ricevuto!");
            // p.SimulaClick();
            #endregion

            #region esercizio operazione delegate
            // Operazione somma = Somma;
            // Operazione moltiplica = Moltiplica;
            // Logger messaggioIn = LogIn;
            // Logger messaggioOut = LogOut;
            // bool continua = true;

            // Console.WriteLine($"Inserire nome utente: ");
            // string? nome = Console.ReadLine();
            // Utente u = new Utente(nome);
            // Console.WriteLine($"{messaggioIn($"L'utente {u.Nome} ha effettuato il login.")}");

            // Console.WriteLine($"Inserire l'operazione che vuoi eseguire: (somma/moltiplicazione)");
            // string? operazione = Console.ReadLine();
            // switch (operazione.Trim().ToLower())
            // {
            //     case "somma":
            //         Console.WriteLine($"Inserire il primo numero: ");
            //         int aS = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine($"Primo numero inserito.\n");
            //         Console.WriteLine($"Inserire il secondo numero: ");
            //         int bS = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine($"Secondo numero inserito.\n");
            //         EseguiOperazione(aS, bS, Somma);
            //         Console.WriteLine($"L'utente {u.Nome} ha eseguito l'operazione somma.");
            //         Console.WriteLine($"Il risultato è {EseguiOperazione(aS, bS, somma)}\n");
            //         Console.WriteLine($"Operazione terminata.\n{messaggioOut($"L'utente {u.Nome} ha effettuato il logout.")}");
            //         break;
            //     case "moltiplicazione":
            //         Console.WriteLine($"Inserire il primo numero: ");
            //         int aM = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine($"Primo numero inserito.\n");
            //         Console.WriteLine($"Inserire il secondo numero: ");
            //         int bM = Convert.ToInt32(Console.ReadLine());
            //         Console.WriteLine($"Secondo numero inserito.\n");
            //         EseguiOperazione(aM, bM, Moltiplica);
            //         Console.WriteLine($"L'utente {u.Nome} ha eseguito l'operazione moltiplicazione.");
            //         Console.WriteLine($"Il risultato è {EseguiOperazione(aM, bM, Moltiplica)}\n");
            //         Console.WriteLine($"Operazione terminata.\n{messaggioOut($"L'utente {u.Nome} ha effettuato il logout.")}");
            //         break;
            // }
            #endregion


            
            IPagamento pagamentoCarta = PagamentoFactory.Pagamento(TipoPagamento.Carta);
            bool continua = true;
            int scelta;

            // Console.WriteLine($"Benvenuto! Configura l'utente: ");

            while (continua)
            {
                Console.WriteLine($"------Menu pagamento------");
                Console.WriteLine($"1. Paypal");
                Console.WriteLine($"2. Carta");
                Console.WriteLine($"3. Bonifico");
                Console.WriteLine($"0. Esci");
                Console.WriteLine($"Scegli il tipo di pagamento: ");
                scelta = Convert.ToInt32(Console.ReadLine());

                if (scelta == 0)
                {
                    Console.WriteLine($"Arrivederci!");
                    continua = false;
                }

                TipoPagamento tipo;
                switch (scelta)
                {
                    case 1:
                        tipo = TipoPagamento.Paypal;
                        break;
                    case 2:
                        tipo = TipoPagamento.Carta;
                        break;
                    case 3:
                        tipo = TipoPagamento.Bonifico;
                        break;
                    default:
                        Console.WriteLine($"Scelta non valida.");
                        continue;
                }

                Console.WriteLine($"Inserisci l'importo: ");
                decimal importo = Convert.ToDecimal(Console.ReadLine());


                IPagamento pagamento = PagamentoFactory.Pagamento(tipo);
                ILoggerDelegate loggerDelegate = new ConsoleLoggerDelegate();

                var service = new PaymentService(pagamento, loggerDelegate);

                service.OnPagamentoCompletato += (id, totale) =>
                {
                    Console.WriteLine($"Pagamento di {totale} euro effettuato con successo. ID: {id}");
                };
                service.ProcessaPagamento(importo);

            }



        }
    }
}