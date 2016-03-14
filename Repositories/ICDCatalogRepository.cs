namespace CDCatalog.Repository
{
    using CDCatalog;
    using System.Collections.Generic;

    /// <summary>
    /// ICDCatalogRepository
    /// </summary>
    public interface ICDCatalogRepository
    {
        Album CreateAlbum(string albumTitle, Artist albumArtist, int albumYear, int albumRating);

        Artist CreateArtist(string artistName);

        Genre CreateGenre(string name);

        Song CreateSong(string songTitle, Artist artist, Genre genre, int songLengthSeconds, int songRating, Album album = null, int albumTrackNumber = 0);

        void UpdateSongRating(string songTitle, int songRating, Album album = null);

        void UpdateAlbumRating(string albumTitle, int albumRating);

        IList<AlbumView> SearchAlbumsByAlbumTitle(string albumTitle);
        IList<AlbumView> SearchAlbumsByArtistName(string artistName);

        IList<SongView> SearchSongsBySongTitle(string songTitle);
        IList<SongView> SearchSongsByArtistName(string artistName);
        IList<SongView> SearchSongsByGenreName(string genreName);
        IList<Genre> SearchGenreByGenreName(string genreName);

        IList<AlbumView> GetAllAlbums();
        IList<Artist> GetAllArtists();
        IList<Genre> GetAllGenres();
        IList<SongView> GetAllSongs();

        Song GetSongByID(int songId);
        Album GetAlbumByID(int albumId);
        Artist GetArtistByID(int aritstID);
        IList<Song> GetSongsByAlbumID(int albumId);

        IList<SongView> GeneratePlaylist(int lengthMinutes);
    }
}
