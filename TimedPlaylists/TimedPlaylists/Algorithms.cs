using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedPlaylists
{
    class AlgorithmBase
    {
        public virtual string Name { get; }
        public virtual string Description { get; }
        public virtual string SubDescription { get; }

        public virtual List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts);
    }

    /// <summary>
    /// Total random finding algorithm. Blackjack-style (!) add until broke or close enough.
    /// </summary>
    class TotallyBogoRithm : AlgorithmBase
    {
        public override string Name { get { return "Random Search"; } }
        public override string Description { get { return "Adds random songs to the playlist, reshuffling until it gets the right combination."; } }
        public override string SubDescription 
        { get { return "Best when used with a larger margin of error or smaller playlist, it's all about luck (and probability). It'll work eventually (statistically)."; } }

        public override List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts)
        {
            // Summary:
            // Add songs to a list
            //   If we can stop, stop
            //   If the list is too long
            //     Start over
            // return the list.

            var turn = new List<Song>();
            long counter = 0;
            var currentSpam = new TimeSpan();

            while (counter < maximumAttempts)
            {
                
            }
            return turn;
        }
    }

    /// <summary>
    /// Applies bogo initial steps, attempts to track back into a successful list.
    /// </summary>
    class GuidedBogoRithm : AlgorithmBase
    {

    }

    /// <summary>
    /// Attempts to put as many of the first songs in the playlist as possible.
    /// </summary>
    class AlphabeticalFirstRithm : AlgorithmBase
    {

    }

    /// <summary>
    /// Attemps to make a playlist with the fewest songs in it.
    /// </summary>
    class FewestSongsRithm : AlgorithmBase
    {

    }

    /// <summary>
    /// Attempts to make a playlist with a lot of songs.
    /// </summary>
    class MostSongsRithm : AlgorithmBase
    {

    }
}
