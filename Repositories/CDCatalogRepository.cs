namespace CDCatalog.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CDCatalogRepository : ICDCatalogRepository
    {
        private const int playlistMarginInSeconds = 60;

        public Album CreateAlbum(string albumTitle, Artist albumArtist, int albumYear, int albumRating)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var album = new Album();
                album.Title = albumTitle;
                album.Year = albumYear;
                album.Rating = albumRating;
                album.ArtistId = albumArtist.ArtistId;
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
                song.AlbumId = album?.AlbumId;
                song.TrackNumber = albumTrackNumber;

                context.Songs.Add(song);
                context.SaveChanges();
                return song;
            }
        }

        public IList<SongView> GeneratePlaylist(int lengthMinutes)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var targetLengthInSeconds = lengthMinutes * 60;
                //Load all songs into a list to work from
                var fullSongList = GetAllSongs();
                //Create playlist that will have songs added to it
                var playlist = new List<SongView>();
                //Create object to be used for random number generation
                var rand = new Random();
                //variable to keep track of playlist length
                var playlistLengthInSeconds = 0;
                //variable to insure that infinate loop does not occur
                var numberOfIterations = 0;

                //Perform functions so long as playlist is under the desired length and there are songs that can still be added
                while (playlistLengthInSeconds < targetLengthInSeconds - playlistMarginInSeconds && fullSongList.Count != 0)
                {
                    //generate index at random
                    int index = rand.Next(fullSongList.Count);
                    //add song at that index to playlist
                    playlist.Add(fullSongList[index]);
                    //update playlist length accordingly
                    playlistLengthInSeconds += fullSongList[index].Track_Length_Seconds;
                    //remove track from song list source
                    fullSongList.RemoveAt(index);

                    //will remove a random song from the playlist if it is too long
                    while (playlistLengthInSeconds > targetLengthInSeconds + playlistMarginInSeconds)
                    {
                        //generate index at random
                        index = rand.Next(playlist.Count);
                        //add song back to list of songs to choose from
                        fullSongList.Add(playlist[index]);
                        //remove track length from playlist
                        playlistLengthInSeconds -= playlist[index].Track_Length_Seconds;
                        //remove song from playl
                        playlist.RemoveAt(index);
                    }

                    numberOfIterations++;
                    if (numberOfIterations > 999)
                        break;
                    
                }

                return playlist;
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

        public IList<AlbumView> GetAllAlbums()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.AlbumViews.OrderBy(a => a.Title).ToList();
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
                return context.Genres.OrderBy(g => g.GenreName).ToList();
            }
        }

        public IList<SongView> GetAllSongs()
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.OrderBy(s => s.Rating).ToList();
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

        public IList<AlbumView> SearchAlbumsByAlbumTitle(string albumTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.AlbumViews.Where(a => a.Title.ToLower().Contains(albumTitle.ToLower())).OrderByDescending(a => a.Rating).ToList();
            }
        }

        public IList<AlbumView> SearchAlbumsByArtistName(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.AlbumViews.Where(a => a.Artist_Name.ToLower() == artistName.ToLower()).ToList();
            }
        }

        public IList<SongView> SearchSongsByArtistName(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.Where(s => s.Artist.ToLower() == artistName.ToLower()).ToList();
            }
        }

        public IList<SongView> SearchSongsByGenreName(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.Where(s => s.Genre.ToLower() == genreName.ToLower()).ToList();
            }
        }

        public IList<SongView> SearchSongsBySongTitle(string songTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.Where(s => s.Title.ToLower().Contains(songTitle.ToLower())).OrderByDescending(s => s.Rating).ToList();
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

                context.SaveChanges();
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
                {
                    var songs = SearchSongsBySongTitle(songTitle);
                    song = GetSongByID((songs.Where(s => s.Album == album.Title).FirstOrDefault()).SongID);
                }
                song.Rating = songRating;

                context.SaveChanges();
            }
        }
    }
}
