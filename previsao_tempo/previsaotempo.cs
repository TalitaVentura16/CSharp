/// <summary>
/// O objetivo desse programa eh fornecer a previsao do tempo para um determinado
/// local,

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrevisaoTempo 
{
    class Previsao 
    {
        public string Local { get; set; }

        static void Localizacao()
        {
            Console.Writeline("Defina a local")
            Local = Console.ReadLine();
        }
        

    }

    
}