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

        List<Album> SearchAlbumsByAlbumTitle(string albumTitle);
        List<Album> SearchAlbumsByArtistName(string artistName);
        List<Album> SearchAlbumsByGenreName(string genreName);

        List<Song> SearchSongsBySongTitle(string songTitle);
        List<Song> SearchSongsByArtistName(string artistName);
        List<Song> SearchSongsByGenreName(string genreName);
        

        List<Artist> GetAllArtists();
        List<Genre> GetAllGenres();
        List<Album> GetAllAlbums();

        Song GetSongByID(int songId);
        Album GetAlbumByID(int albumId);
        Artist GetArtistByID(int aritstID);
        List<Song> GetSongsByAlbumID(int albumId);

        List<Song> GeneratePlaylist(int lengthMinutes);
    }
}
