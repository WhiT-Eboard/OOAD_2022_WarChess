using System;

namespace OOAD_WarChess.Item.Equipment
{
    public class Equipment : IEquipment
    {
        public string Name { get; set; }
        public int LVL { get; set; }
        public int PHY_ATK { get; set; }
        public int PHY_DEF { get; set; }
        public int MAG_ATK { get; set; }
        public int MAG_DEF { get; set; }
        
        public void Upgrade()
        {
            LVL++;
            PHY_ATK += 10;
            PHY_DEF += 10;
            MAG_ATK += 10;
            MAG_DEF += 10;
        }
        
        public Equipment(){}

        public Equipment(int phyatk, int phydef, int magatk, int magdef)
        {
            LVL = 0;
            PHY_ATK = phyatk;
            PHY_DEF = phydef;
            MAG_ATK = magatk;
            MAG_DEF = magdef;
        }
    }
}