using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimedPlaylists
{
    /// <summary>
    /// Contains data for songs in the program.
    /// </summary>
    class Song
    {
        /// <summary>
        /// The title of the song.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// The author of the song
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The length of the song.
        /// </summary>
        public TimeSpan Span { get; private set; }

        /// <summary>
        /// The path to the file where the song is stored.
        /// </summary>
        public string FilePath { get; private set; }
        
        /// <summary>
        /// Retuns the title, author, and runtime.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} - {1} ({2})", Author, Title, Span);
        }
    }

    /// <summary>
    /// Time-mapped playlist with a title and length info.
    /// </summary>
    class Playlist
    {
        /// <summary>
        /// The title of the song.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The list of song objects.
        /// </summary>
        public List<Song> Songs { get; set; }

        /// <summary>
        /// The desired length of the playlist.
        /// </summary>
        public TimeSpan DesiredLength { get; set; }

        /// <summary>
        /// The error margin from the playlist length.
        /// </summary>
        public TimeSpan ErrorMargin { get; set; }

        /// <summary>
        /// Sums the lengths of the contained songs.
        /// </summary>
        public TimeSpan ActualLength 
        { 
            get 
            {
                TimeSpan turn = new TimeSpan();

                foreach (var song in Songs)
                    turn += song.Span;

                return turn;
            } 
        }

        /// <summary>
        /// The path to the file (if it exists) of the playlist.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Which algorithm was used to make it.
        /// </summary>
        public GenerationType AlgorithmType { get; private set; }

        /// <summary>
        /// Constructor from a file.
        /// </summary>
        /// <param name="reader"></param>
        public Playlist(StreamReader reader)
        {

        }

        /// <summary>
        /// Constructor during runtime.
        /// </summary>
        /// <param name="title">The title of the list</param>
        /// <param name="desiredLength">How long the user specifies to make it</param>
        public Playlist(string title, TimeSpan desiredLength)
        {
            Title = title;
            Songs = new List<Song>();
            DesiredLength = desiredLength;
        }
    }

    /// <summary>
    /// Enum for which type of algorithm is used to select the songs.
    /// </summary>
    enum GenerationType
    {
        /// <summary>
        /// Randomness is n!
        /// </summary>
        BogoGen = 0,

        /// <summary>
        /// Attempts to find the best solution by analyzing all of the songs.
        /// Probably best for smaller inputs.
        /// </summary>
        BruteForce = 2,

        /// <summary>
        /// Songs are made so that
        /// </summary>
        AsManyLongOnes = 3,

    }

    class GenerationAlgorithm
    {

    }

    static class Generation
    {
        /// <summary>
        /// Averages song lengths to estimate the number of songs required.
        /// </summary>
        /// <param name="desiredLength">The length to give the algorithm</param>
        /// <param name="songs">The songs to give the algorithm</param>
        /// <returns></returns>
        public static double ApproximateCountForInput(TimeSpan desiredLength, List<Song> songs)
        {
            var averageLength = songs[0].Span.TotalSeconds;

            if (songs.Count == 1) return averageLength;

            return 0; // TODO
        }


        public static List<Song> RandomPick(TimeSpan desiredLength, List<Song> playlist, TimeSpan errorMargin)
        {
            // Summary:
            // 



            // Create a return list
            var ret = new List<Song>();

            // Return the list
            return ret; 
        }
    }
}
