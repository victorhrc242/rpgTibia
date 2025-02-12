using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    public class Paladin:Vocation
    {
        public Paladin()
        {
            base.setBaseHp(10);
            base.setBaseMp(15);
            base.setMp(base.calcularAtualMp());
            base.setHp(base.calcularAtualHp());
            base.setBaseHp(base.calcularlevel());
        }
    }
}
