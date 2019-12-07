using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicPlaylistAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
               Console.WriteLine("MusicPlaylistAnalyzer <music_playlist_file_path> <report_file_path>");
               Environment.Exit(1);
            }

            string playlist = args[0];
            string reportfile = args[1];

            List<Song> songs = null;
            try
            {
                songs = playlistloader.Load(playlist);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            }

            var report = SongReport.GenerateText(songs);

            try
            {
                System.IO.File.WriteAllText(reportfile, report);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }
        }
    }
}