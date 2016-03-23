namespace CDCatalog.Processor
{
    using CDCatalog.Repository;
    using System.Collections.Generic;

    class ProcessSongAlbumAggregator : IProcessSongAlbumAggregator
    {
        private List<AlbumSongResult> Results { get; set; }
        private CDCatalogRepository Repository = new CDCatalogRepository();

        public ProcessSongAlbumAggregator()
        {
            Results = new List<AlbumSongResult>();
        }

        /// <summary>
        /// Will locate list of songs or albums containing any matching to provided string.
        /// </summary>
        /// <param name="title"></param>
        /// <returns>List of AlbumSongResult</returns>
        public IList<AlbumSongResult> FindSongOrAlbumByTitle(string title)
        {
            Results.Clear();
            var songList = Repository.SearchSongsBySongTitle(title);
            var albumList = Repository.SearchAlbumsByAlbumTitle(title);

            PopulateList(songList, albumList);

            return Results;
        }

        /// <summary>
        /// Will locate list of songs or albums containing any matching to provided string.
        /// </summary>
        /// <param name="artist"></param>
        /// <returns>List of AlbumSongResult</returns>
        public IList<AlbumSongResult> FindSongOrAlbumByArtist(string artist)
        {
            Results.Clear();
            var songList = Repository.SearchSongsByArtistName(artist);
            var albumList = Repository.SearchAlbumsByArtistName(artist);

            PopulateList(songList, albumList);

            return Results;
        }

        /// <summary>
        /// Will locate list of songs or albums containing any matching to provided string
        /// </summary>
        /// <param name="genre"></param>
        /// <returns>List of AlbumSongResult</returns>
        public IList<AlbumSongResult> FindSongOrAlbumByGenre(string genre)
        {
            Results.Clear();
            var songList = Repository.SearchSongsByGenreName(genre);
            var albumList = Repository.SearchAlbumsByGenreName(genre);

            PopulateList(songList, albumList);

            return Results;
        }

        private void PopulateList(IList<SongView> songList, IList<AlbumView> albumList)
        {
            foreach (var song in songList)
            {
                var songResult = new AlbumSongResult(song.SongID, "Song", song.Title, song.Artist);
                Results.Add(songResult);
            }

            foreach (var album in albumList)
            {
                var albumResult = new AlbumSongResult(album.AlbumId, "Album", album.Title, album.Artist_Name);
                Results.Add(albumResult);
            }
        }
    }
}
