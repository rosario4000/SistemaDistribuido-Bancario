using System;
using System.Collections.Generic;
using System.Text;

namespace SisBank_AGNER
{
    class usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
    }
}
