namespace BRS.ProgramLogic {
    public class FifoSet : AbstractSet {
        private int victimIndex = -1;

        public FifoSet(int numBlocks) : base(numBlocks) { }

        protected override int ChooseVictimByAlgorithm() {
            victimIndex = (victimIndex + 1) % numBlocks;
            return victimIndex;
        }
    }
}