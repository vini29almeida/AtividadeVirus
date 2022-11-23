using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaboratorioVacinas.Models
{
    public class Virus
    {
        public Virus()
        {
            TemVacina = false;
        }

        public int VirusId { get; set; }
        public string Nome { get; set; }
        public bool TemVacina { get; set; }
        public virtual ICollection<Vacina>? Vacinas { get; set; }

        public void AtualizarTemVacina()
        {
            if (Vacinas != null)
            {
                if (Vacinas.Count > 0)
                {
                    TemVacina = true;
                }
            }
        }
    }
}