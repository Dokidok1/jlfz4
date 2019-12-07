using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MusicPlaylistAnalyzer
{
    public static class SongReport
    {
        public static string GenerateText(List<Song> songs)
        {
            string report = "Music Playlist Report\n\n";

            if (songs.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }

            report += "Names Genres per Name > 200: \n";
            var over200 = from song in songs where song.Plays > 200 select song;

            foreach (Song song in over200)
            {
                report += song + "\n";   
            }
            report += "\n";

            //report += "How many songs are in the playlist with the Genre of “Alternative” ";
            var alter_count = (from song in songs where song.Genre == "Alternative" select song).Count();
            //from song in songs where song.Genre == "Pop" orderby song.Year descending select song;
            report += $"How many songs are in the playlist with the Genre of “Alternative”: {alter_count}\n";


            //How many songs are in the playlist with the Genre of “Hip - Hop / Rap”?
            var rap_count = (from song in songs where song.Genre == "Hip-Hop/Rap" select song).Count();
            report += $"How many songs are in the playlist with the Genre of “Hip Hop/Rap”: {rap_count}\n";
            report += "\n";

            //What songs are in the playlist from the album “Welcome to the Fishbowl?”
            var fishbowl = from song in songs where song.Album == "Welcome to the Fishbowl" select song;
            report += $"Songs from the album Welcome to the Fishbowl:";
            report += "\n";

            foreach(Song song in fishbowl)
            {
                report += song + "\n";
            }
            report += "\n";

            //What are the songs in the playlist from before 1970 ?
            var pSong = from song in songs where song.Year < 1970 select song;
            report += $"Songs from before 1970:";
            report += "\n";

            foreach (Song song in pSong)
            {
                report += song + "\n";
            }
            report += "\n";


            //What are the song names that are more than 85 characters long?

            var cSong = from song in songs where song.Name.Length > 85 select song.Name;
            report += $"Song names longer than 85 characters:";
            report += "\n";
            foreach (var song in cSong)
            {
                report += song + "\n";
            }
            report += "\n";

            //What is the longest song ? (longest in Time)
            var maxTime = (from song in songs select song.Time).Max();
            var lSong = (from song in songs where song.Time == maxTime select song);
            report += $"Longest song:";
            report += "\n";
            foreach (Song song in lSong)
            {
                report += song + "\n";
            }
            report += "\n";
           

            
            return report;
        }
    }
}