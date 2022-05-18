using System;
using System.Collections.Generic;
using System.Text;

namespace Utad.Lab.G00.Domain
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private string nome;

        Categoria(string _nome)
        {
            nome = _nome;
        }

        ~Categoria()
        {

        }


    }


}
