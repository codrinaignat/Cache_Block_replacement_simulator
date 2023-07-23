namespace BRS.ProgramLogic {
    public abstract class AbstractCache {
        #region coduri returnate de accesele la cache

        public const int Hit = 0;
        public const int ConflictMiss = 1;
        public const int CapacityMiss = 2;
        public const int CompulsoryMiss = 3;

        #endregion

        private int indexOfPreviouslyAccessedBlock;
        public int NumCapacityMisses;
        public int NumCompulsoryMisses;
        public int NumConflictMisses;
        public int NumHits;

        protected int NumOfSets;
        protected AbstractSet[] Sets;
        protected int Size;

        protected AbstractCache(int size, int numOfSets) {
            Size = size;
            NumOfSets = numOfSets;
            Sets = new AbstractSet[numOfSets];
        }

        public int TotalQueries() {
            return NumHits + NumCompulsoryMisses + NumConflictMisses + NumCapacityMisses;
        }

        public int TotalMisses() {
            return NumCompulsoryMisses + NumConflictMisses + NumCapacityMisses;
        }

        public int ComputeSetFromAddress(int address) {
            return address % NumOfSets;
        }

        public int ComputeTagFromAddress(int address) {
            return address / NumOfSets; 
        }

        public int GetIndexOfPreviouslyAccessedBlock() {
            return indexOfPreviouslyAccessedBlock;
        }

        public int CheckAddress(int address) {
            var result = 0;
            var tag = ComputeTagFromAddress(address);
            var setIndex = ComputeSetFromAddress(address);
            var indexOfMatchingBlock = Sets[setIndex].FindBlockIndexByTag(tag);
            if (indexOfMatchingBlock != Block.NotFound) {
                result = Hit;
                NumHits++;
                indexOfPreviouslyAccessedBlock = indexOfMatchingBlock;
            }
            else {
                int indexOfBlockToBeReplaced = Sets[setIndex].GetIndexOfBlockToBeReplaced();
                Block blockToBeReplaced = Sets[setIndex].GetBlock(indexOfBlockToBeReplaced);
                if (blockToBeReplaced.tag == Block.Empty) {
                    result = CompulsoryMiss;
                    NumCompulsoryMisses++;
                }
                else if (NumOfSets == 1) { 
                    result = CapacityMiss;
                    NumCapacityMisses++;
                }
                else {
                    result = ConflictMiss;
                    NumConflictMisses++;
                }

                indexOfPreviouslyAccessedBlock = indexOfBlockToBeReplaced;
                blockToBeReplaced.tag = tag;
                blockToBeReplaced.data = address;
            }

            return result;
        }
    }
}