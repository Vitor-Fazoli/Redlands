using System.Numerics;

namespace Redlands.Entities
{
    public class Table()
    {
        public int[,] Slots = new int[3, 3];

        public void PlacePart(int part, int x, int y){
            Slots[x, y] = part;
        }
        public bool VerifyCombo(int[,] combo){
            for(int i = 0; i < Slots.GetLength(0); i++){
                for(int j = 0; j < Slots.GetLength(1); j++){
                    if (Slots[i,j] !=  combo[i,j]){
                        return false;
                    }
                }
            }
            return true;
        }
    }
}