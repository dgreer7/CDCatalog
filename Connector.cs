namespace CDCatalog
{
    using System.Linq;

    class Connector
    {
        internal void AddSong(string songTitle, string artistName, int songRating, string songGenre, 
            int songLength, int trackNumber, string albumName, int albumYear, int albumRating)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Song song = new Song();
                song.Title = songTitle;
                song.Artist = FindArtist(context, artistName) ?? CreateArtist(context, artistName);
                song.Rating = songRating;
                song.Genre = FindGenre(context, songGenre) ?? CreateGenre(context, songGenre);
                song.TrackLengthSeconds = songLength;
                song.TrackNumber = trackNumber;
                song.Album = FindAlbum(context, albumName, albumYear) ?? 
                    CreateAlbum(context, albumName, albumYear, albumRating, song.Artist);
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        #region Genre Methods
        private Genre CreateGenre(CDCatalogEntities context, string genreName)
        {
            var genre = new Genre();
            genre.GenreName = genreName;
            context.Genres.Add(genre);
            context.SaveChanges();
            return genre;
        }

        private Genre FindGenre(CDCatalogEntities context, string genreName)
        {
            return context.Genres.Where(g => g.GenreName == genreName).FirstOrDefault();
        }
        #endregion

        #region Album Methods
        private Album CreateAlbum(CDCatalogEntities context, string albumTitle, int albumYear, int albumRating, Artist artist)
        {
            var album = new Album();
            album.Title = albumTitle;
            album.Year = albumYear;
            album.Rating = albumRating;
            album.Artist = artist;
            context.Albums.Add(album);
            context.SaveChanges();
            return album;
        }

        private Album FindAlbum(CDCatalogEntities context, string albumTitle, int year)
        {
            return context.Albums.Where(a => a.Title == albumTitle && a.Year == year).FirstOrDefault();
        }
        #endregion

        #region Artist Methods
        private Artist FindArtist(CDCatalogEntities context, string artistName)
        {
            return context.Artists.Where(a => a.ArtistName == artistName).FirstOrDefault();
        }

        private Artist CreateArtist(CDCatalogEntities context, string artistName)
        {
            var artist = new Artist();
            artist.ArtistName = artistName;
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }
        #endregion
    }
}
