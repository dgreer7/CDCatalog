namespace CDCatalog
{
    public class AlbumSongResult
    {
        public int ItemID { get; private set; }
        public string Type { get; private set; }
        public string Title { get; private set; }
        public string Artist { get; private set; }

        public AlbumSongResult(int itemID, string type, string title, string artist)
        {
            ItemID = itemID;
            Type = type;
            Title = title;
            Artist = artist;
        }
    }
}
