namespace CDCatalog.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CDCatalogRepository : ICDCatalogRepository
    {
        public Album CreateAlbum(string albumTitle, Artist albumArtist, int albumYear, int albumRating)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var album = new Album();
                album.Title = albumTitle;
                album.Year = albumYear;
                album.Rating = albumRating;
                album.ArtistId =  albumArtist.ArtistId;
                context.Albums.Add(album);
                context.SaveChanges();
                return album;
            }
        }

        public Artist CreateArtist(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var artist = new Artist();
                artist.ArtistName = artistName;
                context.Artists.Add(artist);
                context.SaveChanges();
                return artist;
            }
        }

        public Genre CreateGenre(string name)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var genre = new Genre();
                genre.GenreName = name;
                context.Genres.Add(genre);
                context.SaveChanges();
                return genre;
            }
        }

        public Song CreateSong(string songTitle, Artist artist, Genre genre, int songLengthSeconds, int songRating, Album album = null, int albumTrackNumber = 0)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var song = new Song();
                song.Title = songTitle;
                song.ArtistId = artist.ArtistId;
                song.GenreId = genre.GenreId;
                song.TrackLengthSeconds = songLengthSeconds;
                song.Rating = songRating;
                song.AlbumId = album.AlbumId;
                song.TrackNumber = albumTrackNumber;
                                
                context.Songs.Add(song);
                context.SaveChanges();
                return song;
            }
        }

        public IList<Song> GeneratePlaylist(int lengthMinutes)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                throw new NotImplementedException();
            }
        }

        public Album GetAlbumByID(int albumId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Albums.FirstOrDefault(a => a.AlbumId == albumId);
            }
        }

        public Artist GetArtistByID(int artistID)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Artists.FirstOrDefault(a => a.ArtistId == artistID);
            }
        }

        public IList<Album> GetAllAlbums()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Set<Album>().ToList();
            }
        }

        public IList<Artist> GetAllArtists()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Artists.OrderBy(a => a.ArtistName).ToList();
            }
        }

        public IList<Genre> GetAllGenres()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Set<Genre>().ToList();
            }
        }

        public Song GetSongByID(int songId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Songs.FirstOrDefault(s => s.SongID == songId);
            }
        }

        public IList<Song> GetSongsByAlbumID(int albumId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Songs.Where(s => s.AlbumId == albumId).ToList();
            }
        }

        public IList<Album> SearchAlbumsByAlbumTitle(string albumTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Albums.Where(a => a.Title.ToLower() == albumTitle.ToLower()).ToList();
            }
        }

        public IList<Album> SearchAlbumsByArtistName(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Albums.Where(a => a.Artist.ArtistName.ToLower() == artistName.ToLower()).ToList();
            }
        }

        public IList<Album> SearchAlbumsByGenreName(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                //will require modificaiton to db as Album doesn't have genere property
                //Is this needed??
                throw new NotImplementedException();
            }
        }

        public IList<Song> SearchSongsByArtistName(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Songs.Where(s => s.Artist.ArtistName.ToLower() == artistName.ToLower()).ToList();
            }
        }

        public IList<Song> SearchSongsByGenreName(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Songs.Where(s => s.Genre.GenreName.ToLower() == genreName.ToLower()).ToList();
            }
        }

        public IList<Song> SearchSongsBySongTitle(string songTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Songs.Where(s => s.Title.ToLower() == songTitle.ToLower()).ToList();
            }
        }

        public IList<Genre> SearchGenreByGenreName(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Genres.Where(g => g.GenreName.Contains(genreName)).OrderBy(g => g.GenreName).ToList();
            }
        }

        public void UpdateAlbumRating(string albumTitle, int albumRating)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                //TODO: Handle album not found
                var album = GetAlbumByID(SearchAlbumsByAlbumTitle(albumTitle).First().AlbumId);
                album.Rating = albumRating;
            }
        }

        public void UpdateSongRating(string songTitle, int songRating, Album album = null)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                //TODO: Handle song not found
                Song song;
                if (album == null)
                    song = GetSongByID(SearchSongsBySongTitle(songTitle).First().SongID);
                else
                    song = GetSongByID(album.AlbumId);
                song.Rating = songRating;
            }
        }
    }
}
