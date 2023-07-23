namespace BRS.ProgramLogic {
    public class LruCache : AbstractCache {
        public LruCache(int size, int numOfSets) : base(size, numOfSets) {
            for (var i = 0; i < numOfSets; i++)
                Sets[i] = new LruSet(size / numOfSets);
        }
    }
}