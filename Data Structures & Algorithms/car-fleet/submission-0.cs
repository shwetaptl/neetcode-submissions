public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
      int n = position.Length;
        var cars = new (int pos, double time)[n];

        // Step 1: Pair position and speed, then sort by position (descending)
        for (int i = 0; i < n; i++)
            cars[i] = (position[i], (double)(target - position[i]) / speed[i]);

        cars = cars.OrderByDescending(car => car.pos).ToArray();

        //Traverse and count fleets
        int fleets = 0;
        double currentMaxTime = 0;

        for (int i = 0; i < n; i++) {
            if (cars[i].time > currentMaxTime) {
                fleets++;
                currentMaxTime = cars[i].time;
            }
        }

        return fleets;
    }
}
