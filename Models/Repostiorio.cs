using System.Collections.Generic;

namespace Enquete.Models {
    public static class Repositorio 
    {
        private static List<Resposta> r = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return r; }}

        public static void AdicionarResposta(Resposta resposta)
        {
            r.Add(resposta);
        }
    }
}