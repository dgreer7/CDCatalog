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

        IList<Album> SearchAlbumsByAlbumTitle(string albumTitle);
        IList<Album> SearchAlbumsByArtistName(string artistName);
        IList<Album> SearchAlbumsByGenreName(string genreName);

        IList<Song> SearchSongsBySongTitle(string songTitle);
        IList<Song> SearchSongsByArtistName(string artistName);
        IList<Song> SearchSongsByGenreName(string genreName);
        IList<Genre> SearchGenreByGenreName(string genreName);
        

        IList<Artist> GetAllArtists();
        IList<Genre> GetAllGenres();
        IList<Album> GetAllAlbums();

        Song GetSongByID(int songId);
        Album GetAlbumByID(int albumId);
        Artist GetArtistByID(int aritstID);
        IList<Song> GetSongsByAlbumID(int albumId);

        IList<Song> GeneratePlaylist(int lengthMinutes);
    }
}
