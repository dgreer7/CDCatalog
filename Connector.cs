namespace CDCatalog
{
    using System;
    using System.Linq;

    class Connector
    {
        internal void AddSong(string SongTitle, string ArtistName, int SongRating, int SongLength)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Song song = new Song
                {
                    Title = SongTitle,
                    Rating = SongRating,
                    Artist = FindArtist(context) ?? CreateArtist(context, ArtistName),
                    TrackLengthSeconds = SongLength,
                    Genre = new Genre { GenreId = 96, GenreName = "Pop/Rock" }
                };

                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        internal void AddAlbum(string albumName, int year, int albumRating, string artist)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Album album = FindAlbum(context, albumName);

                if (album == null)
                {
                    album = new Album
                    {
                        Title = albumName
                    };

                    context.Albums.Add(album);
                    context.SaveChanges();
                }
            }
        }

        private Artist FindArtist(CDCatalogEntities context)
        {
            return context.Artists.Where(a => a.ArtistId == 5).FirstOrDefault();
        }


        private Artist CreateArtist(CDCatalogEntities context, string artistName)
        {
            var artist = new Artist();
            artist.ArtistName = artistName;
            context.Artists.Add(artist);
            context.SaveChanges();
            return artist;
        }

        private Album FindAlbum(CDCatalogEntities context, string albumName)
        {
            return context.Albums.Where(a => a.Title == albumName).FirstOrDefault();
        }
    }
}
