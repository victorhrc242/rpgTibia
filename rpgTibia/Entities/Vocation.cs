using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgTibia.Entities
{
    internal class Vocation
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

        public void setLevel(int level)
        {
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

        public int calcularAtualHp()
        {
            return level * baseHp;
        }

        public int calcularAtualMp()
        {
            return level * baseMp;
        }



    }
}
