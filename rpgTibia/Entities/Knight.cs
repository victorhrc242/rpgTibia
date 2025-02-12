using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    public class Knight : Vocation
    {
        public Knight()
        {
            base.setBaseHp(15);
            base.setBaseMp(5);
            base.setMp(base.calcularAtualMp());
            base.setHp(base.calcularAtualHp());

        }
    }
}
