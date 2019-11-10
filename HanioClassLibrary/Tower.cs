using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HanoiClassLibrary
{
    public class Towers
    {

        public int numberOfDiscs;
        public int numberOfmoves;
        public bool isComplete;
        public int minimumPossibleMoves;

        Stack<int>[] poles = new Stack<int>[3]; 

        public Towers(int numberOfDiscs)
        {
            if (numberOfDiscs > 9 || numberOfDiscs < 1)
                throw new InvalidHeightException($"invalid number of disks {numberOfDiscs}");

            this.numberOfDiscs = numberOfDiscs;
            minimumPossibleMoves = 2 ^ numberOfDiscs - 1;
            for (int j = 0; j < 3; j++)
            {
                poles[j] = new Stack<int>();
            }
            for (int i = numberOfDiscs; i >= 1; i--)
            {
                poles[0].Push(i);
            }
        }

        public void Move(int from, int to)
        {
            //1. check if the user is asking for a valid move
            // 1.1 if from < 1 or from > 3, throw exception "invalid from value"
            // 1.2 if to < 1 or to > 3, throw exception "invalid to value"
            // 1.3 if "from" pole is empty, throw exception 'source pole is empty"
            // 1.4 do the check above to make sure we are not putting smaller disk on larger disk
            //  1.4.1 find the size of the top disk on the "from" pole, assign to var topDiskOnFromPole
            //  1.4.2 find the size of the top disk on the "to" pole, assign to var topDiskOnToPole
            //  1.4.3 compare topDiskOnFromPole and topDiskOnToPole
            //  1.4.4 if topDiskOnFromPole < topDiskOnToPole, then the move is allowed
            //  1.4.5 if topDiskOnFromPole > topDiskOnToPole, then the move is not allowed
            //2. if all checks above pass, move the from the "from" pole to the "to" pole
            //3. check of all disks are now on pole number 3. if yes, we are finished with the puzzle.
        }

        public int[][] ToArray()
        {
            int[][] jaggedarray = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                int[] disksOnThisPole = new int[poles[i].Count];
                poles[i].CopyTo(disksOnThisPole, 0);
                jaggedarray[i] = disksOnThisPole;
            }
            return jaggedarray;
        }
    }

    [Serializable]
    internal class InvalidMoveException : Exception
    {
        public InvalidMoveException()
        {
        }

        public InvalidMoveException(string message) : base(message)
        {
        }

        public InvalidMoveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidMoveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class InvalidHeightException : Exception
    {
        public InvalidHeightException()
        {
        }

        public InvalidHeightException(string message) : base(message)
        {
        }

        public InvalidHeightException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidHeightException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
