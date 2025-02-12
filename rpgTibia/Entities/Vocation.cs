using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    public class Vocation
    {
        public Vocation()
        {

        }
        private int level = 1;
        private int hp;
        private int mp;
        private int cap;
        private int baseHp = 5;
        private int baseMp = 5;
        // aqui eu edito as informçãoes
        public void setLevel(int level)
        {
            this.level = level;
        }
        public void setHp(int hp)
        {
            this.hp = hp;
        }
        public void setMp(int mp)
        {
            this.mp = mp;
        }
        public void setCap(int cap)
        {
            this.cap = cap;
        }

        public void setBaseHp(int baseHp)
        {
            this.baseHp = baseHp;
        }

        public void setBaseMp(int baseMp)
        {
            this.baseMp = baseMp;
        }
        // aqui eu edito as informaçãoes
        public int getLevel()
        {
            return level;
        }

        public int getHp()
        {
            return hp;
        }

        public int getMp()
        {
            return mp;
        }

        public int getCap()
        {
            return cap;
        }
        // aqui eu calculo as coisas que tem que almentar como o level e o level dos hatributos
        public int calcularAtualHp()
        {
            return level * baseHp;
        }

        public int calcularAtualMp()
        {
            return level * baseMp;
        }

        public int calcularlevel()
        {
            return level = level + 1;
        }



    }
}
