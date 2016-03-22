namespace CDCatalog.Processor
{
    using System.Collections.Generic;

    public interface IProcessSongAlbumAggregator
    {
        IList<AlbumSongResult> FindSongOrAlbumByTitle(string title);
        IList<AlbumSongResult> FindSongOrAlbumByArtist(string artist);
        IList<AlbumSongResult> FindSongOrAlbumByGenre(string genre);
    }
}
