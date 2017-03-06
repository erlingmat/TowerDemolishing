using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerApp
{
   public class DemolishBeam
    {
       public bool lessOrEqual(int one, int two)
       {
           if (one < two) return true;
           return false;
       }
       public int MovesToDemolishBuildings(int NumBuildings, int[] buildingHeights)
       {
            List<int> heightList = new List<int>(buildingHeights);
            // .Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));
            heightList.Sort((y, x) => x.CompareTo(y));
            int moves = 0;
            if (heightList.First() > NumBuildings)
                while (heightList.First() > heightList.Count)
                {
                    heightList.RemoveAt(0);
                    moves ++;
                    if (heightList.Count == 0) break;
                }
            if (heightList.Count >0)
               moves += heightList.First();
           return moves;
       }
    }
}
