﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300072
{
    class KodePos
    {
        public enum Kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        }

        private static int[] kodePosList = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

        public static int GetKodePos(Kelurahan kelurahan)
        {
            return kodePosList[(int)kelurahan];
        }
    }
}
