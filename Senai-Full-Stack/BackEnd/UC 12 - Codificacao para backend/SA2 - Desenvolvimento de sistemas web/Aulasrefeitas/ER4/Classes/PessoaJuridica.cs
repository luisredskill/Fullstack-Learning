using System.Text.RegularExpressions;
using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        //XX.XXX.XXX/0001-XX --- XXXXXXXX0001XX
        bool IPessoaJuridica.validarCnpj(string cnpj)
        {
            if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if (cnpj.Length == 18)
                {
                    if (cnpj.Substring(11, 4) == "0001")
                    {
                        return true;
                    }
                }
                else if (cnpj.Length == 14)
                {
                    if (cnpj.Substring(8, 4) == "0001")
                    {
                        return true;
                    }

                }
                return false;

            }
        }
    }
}

