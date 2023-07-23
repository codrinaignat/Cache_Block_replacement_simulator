using System;

namespace BRS.ProgramLogic {
    public class RandomSet : AbstractSet {
        private readonly Random randomGenerator = new Random();

        public RandomSet(int numBlocks) : base(numBlocks) { }

        protected override int ChooseVictimByAlgorithm() {
            var victimIndex = randomGenerator.Next(0, numBlocks);
            return victimIndex;
        }
    }
}