using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface OpstiDomenskiObjekat
    {
        string tabela { get; }
        string kljuc { get; }
        string uslovJedan { get; }
        string uslovVise { get; }
        string azuriranje { get; }
        string upisivanje { get; }

        OpstiDomenskiObjekat Napuni(DataRow red);

       
    }
}
