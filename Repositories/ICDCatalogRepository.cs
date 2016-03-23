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

        void UpdateAlbumRating(string albumTitle, int albumRating, string artistName = null);

        IList<AlbumView> SearchAlbumsByAlbumTitle(string albumTitle);
        IList<Album> SearchAlbumsByAlbumTitleExclusive(string albumTitle);
        IList<AlbumView> SearchAlbumsByArtistName(string artistName);
        IList<AlbumView> SearchAlbumsByGenreName(string genre);

        IList<Artist> SearchArtistByArtistNameExclusive(string artistName);

        IList<SongView> SearchSongsByAlbumID(int albumId);
        IList<SongView> SearchSongsBySongTitle(string songTitle);
        IList<SongView> SearchSongsBySongTitleExclusive(string songTitle);
        IList<SongView> SearchSongsByArtistName(string artistName);
        IList<SongView> SearchSongsByGenreName(string genreName);

        IList<Genre> SearchGenreByGenreName(string genreName);

        IList<Album> GetAllAlbums();
        IList<Artist> GetAllArtists();
        IList<Genre> GetAllGenres();
        IList<SongView> GetAllSongs();

        Song GetSongByID(int songId);
        SongView GetSongViewByID(int songId);
        Album GetAlbumByID(int albumId);
        Artist GetArtistByID(int aritstID);
        IList<Song> GetSongsByAlbumID(int albumId);

        IList<SongView> GeneratePlaylist(int lengthMinutes);
    }
}
