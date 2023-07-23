namespace BRS.ProgramLogic {
    public class RandomCache : AbstractCache {
        public RandomCache(int size, int numOfSets) : base(size, numOfSets) {
            for (var i = 0; i < numOfSets; i++)
                Sets[i] = new RandomSet(size / numOfSets);
        }
    }
}