﻿namespace CDCatalog.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
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
                //Pulls the accepted margin of tolarance in seconds from the app.config. If it cannot get the value, will default to 60
                int marginInSeconds;
                if (!int.TryParse(ConfigurationManager.AppSettings["GeneratePlaylistMarginInSeconds"], out marginInSeconds))
                    marginInSeconds = 60;

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
                while (playlistLengthInSeconds < targetLengthInSeconds - marginInSeconds && fullSongList.Count != 0)
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
                    while (playlistLengthInSeconds > targetLengthInSeconds + marginInSeconds)
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

        public AlbumView GetAlbumViewByID(int albumId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.AlbumViews.FirstOrDefault(a => a.AlbumId == albumId);
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
                return context.Albums.OrderBy(a => a.Title).ToList();
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
                return context.SongViews.OrderByDescending(s => s.Rating).ToList();
            }
        }

        public Song GetSongByID(int songId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Songs.FirstOrDefault(s => s.SongID == songId);
            }
        }

        public SongView GetSongViewByID(int songId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.FirstOrDefault(s => s.SongID == songId);
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
                if (string.IsNullOrEmpty(albumTitle))
                    return context.Set<AlbumView>().ToList(); ;
                return context.AlbumViews.Where(a => a.Title.ToLower().Contains(albumTitle.ToLower())).OrderByDescending(a => a.Rating).ToList();
            }
        }

        public IList<Album> SearchAlbumsByAlbumTitleExclusive(string albumTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Albums.Where(a => a.Title.ToLower() == albumTitle.ToLower()).OrderByDescending(a => a.Rating).ToList();
            }
        }

        public IList<AlbumView> SearchAlbumsByArtistName(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.AlbumViews.Where(a => a.Artist_Name.ToLower() == artistName.ToLower()).OrderByDescending(a => a.Rating).ToList();
            }
        }

        public IList<AlbumView> SearchAlbumsByGenreName(string genre)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var results = new List<AlbumView>();
                var matchingSongs = SearchSongsByGenreName(genre);
                foreach (var match in matchingSongs)
                {
                    results.AddRange(context.AlbumViews.Where(a => a.Title == match.Album));
                }
                results = results.Distinct().ToList();
                return results;
            }
        }

        public IList<Artist> SearchArtistByArtistNameExclusive(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Artists.Where(a => a.ArtistName.ToLower() == artistName.ToLower()).ToList();
            }
        }

        public IList<SongView> SearchSongsByAlbumID(int albumId)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                var songsInAlbum = context.Songs.Where(s => s.AlbumId == albumId).ToList();
                var songViewInAlbum = new List<SongView>();
                foreach (var song in songsInAlbum)
                {
                    songViewInAlbum.Add(GetSongViewByID(song.SongID));
                }
                songViewInAlbum = songViewInAlbum.OrderBy(s => s.Track).ToList();
                return songViewInAlbum;
            }
        }


        public IList<SongView> SearchSongsByArtistName(string artistName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.Where(s => s.Artist.ToLower() == artistName.ToLower()).OrderByDescending(s => s.Rating).ToList();
            }
        }

        public IList<SongView> SearchSongsByGenreName(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.Where(s => s.Genre.ToLower() == genreName.ToLower()).OrderByDescending(s => s.Rating).ToList();
            }
        }

        public IList<SongView> SearchSongsBySongTitle(string songTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                //if nothing is passed in, all songs will be returned
                if (string.IsNullOrEmpty(songTitle))
                    return GetAllSongs();
                return context.SongViews.Where(s => s.Title.ToLower().Contains(songTitle.ToLower())).OrderByDescending(s => s.Rating).ToList();
            }
        }

        public IList<SongView> SearchSongsBySongTitleExclusive(string songTitle)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.SongViews.Where(s => s.Title.ToLower() == songTitle.ToLower()).OrderByDescending(s => s.Rating).ToList();
            }
        }

        public IList<Genre> SearchGenreByGenreName(string genreName)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                return context.Genres.Where(g => g.GenreName.Contains(genreName.ToLower())).OrderBy(g => g.GenreName).ToList();
            }
        }

        public void UpdateAlbumRating(string albumTitle, int albumRating, string artistName = null)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Album album;
                if (artistName == null)
                {
                    album = GetAlbumByID(SearchAlbumsByAlbumTitle(albumTitle).First().AlbumId);
                }
                else
                {
                    var albums = SearchAlbumsByAlbumTitle(albumTitle).ToList();
                    album = GetAlbumByID(albums.Where(a => a.Artist_Name == artistName).FirstOrDefault().AlbumId);
                }
                album.Rating = albumRating;

                context.Albums.Attach(album);
                var entry = context.Entry(album);
                entry.Property(e => e.Rating).IsModified = true;
                context.SaveChanges();
            }
        }

        public void UpdateSongRating(string songTitle, int songRating, Album album = null)
        {
            using (CDCatalogEntities context = new CDCatalogEntities())
            {
                Song song;
                if (album == null)
                    song = GetSongByID(SearchSongsBySongTitle(songTitle).First().SongID);
                else
                {
                    var songs = SearchSongsBySongTitle(songTitle);
                    song = GetSongByID((songs.Where(s => s.Album == album.Title).FirstOrDefault()).SongID);
                }
                song.Rating = songRating;

                context.Songs.Attach(song);
                var entry = context.Entry(song);
                entry.Property(e => e.Rating).IsModified = true;
                context.SaveChanges();
            }
        }
    }
}
