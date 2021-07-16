using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string idade { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string telefone { get; set; }

        public void SalvarDados()
        {
            new Database.Pessoa().Salvar(this.nome, this.sobrenome, this.idade, this.endereco, this.bairro, this.cidade, this.telefone);
        }
    }
}
