using System;
/* 
    An imminent hurricane threatens the coastal town of Codeville. 
    If at most two people can fit in a rescue boat, and the maximum weight limit for a given boat is k, 
    determine how many boats will be needed to save everyone.

    For example, given a population with weights [100, 200, 150, 80] and a boat limit of 200, 
    the smallest number of boats required will be three. 
*/
namespace challenges {
    public static class RescueBoats {
        public static int NumberOfBoats(int[] weights, int limit) {
            DataStructures.Heap<int> maxRemainingCap = new DataStructures.Heap<int>();
            int boats = 0;
            foreach (var weight in weights) {
                if (!maxRemainingCap.Empty() && maxRemainingCap.Peek() >= weight) {
                    maxRemainingCap.Poll();
                }
                else {
                    maxRemainingCap.Add(limit - weight);
                    boats++;
                }
            }
            Console.WriteLine("[" + string.Join(",", maxRemainingCap.ShowHeap()) + "]");
            return boats;
        }
    }
}
