using System;
using System.Collections.Generic;
using System.Text;

namespace Utad.Lab.G00.Domain
{
    public class Lista
    {
        public string Name { get; private set; }   // AVISO: SEM CERTEZA QUE PODE TER O MESMO NOME DAS OUTRAS CLASSES;
        public string descriçao { get; private set; }

        private List<Item> items;

       private string name;
       private string descricao;
        
        Lista(string _name, string _descricao)
        {
            Name = _name;
            descricao = _descricao;
            items = new List<Item>();
        }

        ~Lista()
        {

        }

    }
}
