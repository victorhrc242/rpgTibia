using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    public class Druid:Vocation
    {
        public Druid()
        {
            base.setBaseHp(5);
            base.setBaseMp(30);
            base.setMp(base.calcularAtualMp());
            base.setHp(base.calcularAtualHp());
        }
    }
}
