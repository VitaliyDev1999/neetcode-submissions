public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
            double[] carTimes = new double[target];
            for(int i = 0; i < position.Length; i++)
            {
                carTimes[position[i]] = (double)(target - position[i]) / speed[i];
            }

            int fleets = 0;
            double prevTime = 0.0;

            for(int i = target - 1; i >= 0; i--)
            {
                if(carTimes[i] > prevTime)
                {
                    prevTime = carTimes[i];
                    fleets++;
                }
            }
            return fleets;    
    }
}
