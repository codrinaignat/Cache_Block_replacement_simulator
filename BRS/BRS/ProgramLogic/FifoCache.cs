namespace BRS.ProgramLogic {
    public class FifoCache : AbstractCache {
        public FifoCache(int size, int numOfSets) : base(size, numOfSets) {
            for (var i = 0; i < numOfSets; i++)
                Sets[i] = new FifoSet(size / numOfSets);
        }
    }
}