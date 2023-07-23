namespace BRS.ProgramLogic {
    public class LruSet : AbstractSet {
        private int[] lruCounters;

        public LruSet(int numBlocks) : base(numBlocks) {
            lruCounters = new int[numBlocks];
            for (var i = 0; i < numBlocks; i++) 
                lruCounters[i] = i;
        }

        public override int FindBlockIndexByTag(int tag) {
            for (var i = 0; i < numBlocks; i++)
                if (blocks[i].tag == tag) {
                    DecrementOthersAndRefill(i);
                    return i;
                }

            return Block.NotFound;
        }

        protected override int ChooseVictimByAlgorithm() {
            var victimIndex = 0;
            for (var i = 0; i < numBlocks; i++) {
                if (lruCounters[i] == 0) {
                    victimIndex = i;
                    DecrementOthersAndRefill(i);
                    break;
                }
            }

            return victimIndex;
        }

        private void DecrementOthersAndRefill(int blockIndex) {
            for (var i = 0; i < numBlocks; i++) {
                if (lruCounters[i] > 0)
                    lruCounters[i]--;
            }

            lruCounters[blockIndex] = numBlocks - 1; 
        }
    }
}