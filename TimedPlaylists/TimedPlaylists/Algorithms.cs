using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimedPlaylists
{
    abstract class AlgorithmBase
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract string SubDescription { get; }

        public abstract List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts);
    }

    /// <summary>
    /// Total random finding algorithm. Blackjack-style (!) add until broke or close enough.
    /// </summary>
    class TotallyBogoRithm : AlgorithmBase
    {
        public override string Name { get { return "Random Shuffle"; } }
        public override string Description { get { return "Adds random songs to the playlist, rebuilding until it hits the perfect combination."; } }
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
            var currentSpan = new TimeSpan();

            while (counter < maximumAttempts)
            {
                
            }
            return turn;
        }
    }

    class BogoShuffleRithm : AlgorithmBase
    {
        public override string Name { get { return "Random Shuffle + Random Fixes"; } }
        public override string Description { get { return "Adds random songs to the playlist, reviewing random songs until the set works."; } }
        public override string SubDescription { get { return "The most efficient random will ever be here."; } }

        public override List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Applies bogo initial steps, attempts to track back into a successful list.
    /// </summary>
    class GuidedBogoRithm : AlgorithmBase
    {
        public override string Name { get { return "Guided Random Search"; } }
        public override string Description { get { return "Adds random songs to the playlist, then tries to fit all of the songs together."; } }
        public override string SubDescription { get { return "Still takes a long time, but it's much faster than totally random (statistically)."; } }

        public override List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts)
        {
            // Summary:
            // Initially, add songs until near overflow (or overflow - 1?)
            // 
            var turn = new List<Song>();
            return turn;
        }
    }

    /// <summary>
    /// Attempts to put as many of the first songs in the playlist as possible.
    /// </summary>
    class AlphabeticalFirstRithm : AlgorithmBase
    {
        public override string Name { get { return "Alphabetical First"; } }
        public override string Description { get { return "Attempts to place the songs that are alphabetically first into the list."; } }
        public override string SubDescription
        { get { return "This could also sort by any well-ordering sort, which does not affect the list's length, such as song popularity, or something."; } }

        public override List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Attemps to make a playlist with the fewest songs in it.
    /// </summary>
    class FewestSongsRithm : AlgorithmBase
    {
        public override string Name { get { return "Fewest Songs"; } }
        public override string Description { get { return "Creates a playlist with the fewest number of songs."; } }
        public override string SubDescription { get { return "A real algorithm."; } }

        public override List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts)
        {
            // Summary:
            // Add longest songs to the list until it fits or overflows.
            // Once overflow is reached:
            // Attempt (NP) to replace all possible songs.
            // Loop available by long -> short if distance > average
            // else loop shortest -> longest if distance < average
            // For each available:
            //  if simple addition works, cool.
            //  for each in-list
            //      if replacing the songs works, do it.
            var turn = new List<Song>();

            // Find the average song length. Accurate by seconds.
            double average = 0;
            foreach (var song in database)
                average += song.Span.TotalSeconds;
            average /= database.Count;



            return turn;
        }
    }

    /// <summary>
    /// Attempts to make a playlist with a lot of songs.
    /// </summary>
    class MostSongsRithm : AlgorithmBase
    {
        public override string Name { get { return "Most Songs"; } }
        public override string Description { get { return "Creates a playlist with the most songs possible."; } }
        public override string SubDescription { get { return "Also a real algorithm"; } }

        public override List<Song> Evaluate(TimeSpan desiredLength, List<Song> database, TimeSpan offCount, long maximumAttempts)
        {
            throw new NotImplementedException();
        }
    }
}
