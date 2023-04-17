using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Models.bytebank.Modelos.ADM.Utilitario
{
    private class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaTentativa.Equals(senhaVerdadeira);
        }
    }
}
