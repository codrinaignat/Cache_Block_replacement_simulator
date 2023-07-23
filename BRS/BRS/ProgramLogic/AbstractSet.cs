namespace BRS.ProgramLogic {
    public abstract class AbstractSet {
        protected Block[] blocks;
        protected int numBlocks;
        private int numUsedBlocks;

        protected AbstractSet(int numBlocks) {
            numUsedBlocks = 0;
            this.numBlocks = numBlocks;
            blocks = new Block[numBlocks];
            for (var i = 0; i < numBlocks; i++)
                blocks[i] = new Block();
        }

        public Block GetBlock(int blockIndex) {
            return blocks[blockIndex];
        }

        public virtual int FindBlockIndexByTag(int tag) {
            for (var i = 0; i < numBlocks; i++) {
                if (blocks[i].tag == tag) {
                    return i;
                }
            }

            return Block.NotFound;
        }

        public int GetIndexOfBlockToBeReplaced() {
            if (numUsedBlocks < numBlocks) {
                return numUsedBlocks++;
            }
            else {
                return ChooseVictimByAlgorithm();
            }
        }

        protected abstract int ChooseVictimByAlgorithm();
    }
}