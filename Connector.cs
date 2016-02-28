namespace CDCatalog
{
    using System.Collections.Generic;
    using System.Linq;

    class Connector
    {

        #region Song Methods
        private Song FindSong(CDCatalogEntities context, string songTitle, string artistName)
        {
            //locates the first case insensitive match of song name
            return context.Songs.FirstOrDefault(s => s.Title.ToLower() == songTitle.ToLower() && s.Artist.ArtistName.ToLower() == artistName.ToLower());
        }

        internal List<Song> FindSongsExactMatch(CDCatalogEntities context, string songTitle)
        {
            //locates the all case insensitive exact match of song name
            return context.Songs.Where(s => s.Title.ToLower() == songTitle.ToLower()).ToList();
        }

        internal List<Song> FindSongsContainingMatch(CDCatalogEntities context, string songTitle)
        {
            //locates the all case insensitive match of song name containing query
            return context.Songs.Where(s => s.Title.ToLower().Contains(songTitle.ToLower())).ToList();
        }

        internal void AddSong(string songTitle, string artistName, int songRating, string songGenre, 
            int songLength, int trackNumber, string albumName, int albumYear, int albumRating)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Song song = new Song();
                song.Title = songTitle;
                //if unable to find Artist, will create one
                song.Artist = FindArtist(context, artistName) ?? CreateArtist(context, artistName); 
                song.Rating = songRating;
                //if unable to find Genre, will create one
                song.Genre = FindGenre(context, songGenre) ?? CreateGenre(context, songGenre);
                song.TrackLengthSeconds = songLength;
                song.TrackNumber = trackNumber;
                //if unable to find Album, will create one
                song.Album = FindAlbum(context, albumName, albumYear) ?? 
                    CreateAlbum(context, albumName, albumYear, albumRating, song.Artist);
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }
        #endregion

        #region Genre Methods
        private Genre FindGenre(CDCatalogEntities context, string genreName)
        {
            //locates the first case insensitive match of genre name
            return context.Genres.FirstOrDefault(g => g.GenreName.ToLower() == genreName.ToLower());
        }

        private Genre CreateGenre(CDCatalogEntities context, string genreName)
        {
            var genre = new Genre();
            genre.GenreName = genreName;
            context.Genres.Add(genre);
            context.SaveChanges();
            return genre;
        }
        #endregion

        #region Album Methods
        private Album FindAlbum(CDCatalogEntities context, string albumTitle, int year)
        {
            //locates the first case insensitive match of album name
            return context.Albums.FirstOrDefault(a => a.Title.ToLower() == albumTitle.ToLower() && a.Year == year);
        }

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
        #endregion

        #region Artist Methods
        private Artist FindArtist(CDCatalogEntities context, string artistName)
        {
            //locates the first case insensitive match of artist name
            return context.Artists.FirstOrDefault(a => a.ArtistName.ToLower() == artistName.ToLower());
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
