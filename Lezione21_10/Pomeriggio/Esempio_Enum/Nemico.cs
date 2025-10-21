using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lezione21_10.Pomeriggio.Esempio_Enum
{
    public class Nemico
    {
        public enum TipoNemico { Zombie, Robot, Fantasma }

        // [SerializeFile]
        private TipoNemico tipo;

        // private void Start()
        // {
        //     switch (tipo)
        //     {
        //         case TipoNemico.Zombie:
        //             Debug.Log("Questo è uno zombie");
        //             break;
        //         case TipoNemico.Robot:
        //             Debug.Log("Questo é un robot");
        //             break;
        //         case TipoNemico.Fantasma:
        //             Debug.Log("Questo é un fantasma");
        //             break;
        //     }
        // }
    }
}