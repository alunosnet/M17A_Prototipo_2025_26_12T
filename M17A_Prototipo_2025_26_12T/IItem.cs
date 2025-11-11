using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12T
{
    internal interface IItem
    {
        //Validar dados
        List<string> Validar();
        //Adicionar
        void Adicionar();   //TODO: base de dados
        //Editar
        void Editar();
        //Apagar
        void Apagar();
    }
}
