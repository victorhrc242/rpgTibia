using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    public class Sorcerer:Vocation
    {
        public Sorcerer()
        {
            base.setBaseHp(5);
            base.setBaseMp(30);
            base.setMp(base.calcularAtualMp());
            base.setHp(base.calcularAtualHp());
            base.setBaseHp(base.calcularlevel());
        }
    }
}
