using System;
using System.Collections.Generic;
using System.Text;

namespace Utad.Lab.G00.Domain
{
    public class Item
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantidade { get; private set; }
        public bool Estado { get; private set; }




        private string nome;
        private bool estado;
        private int quantidade;
        private Categoria categoria;

        Item(string _nome, bool _estado, int _quantidade, Categoria _categoria) 
        {
            nome = _nome;
            estado = _estado;
            Quantidade = _quantidade;
            categoria = _categoria;
        }

        ~Item()
        {

        }
    }
}
