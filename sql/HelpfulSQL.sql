USE CDCatalog
SELECT *
FROM Artist;

USE CDCatalog
SELECT *
FROM Song;

USE CDCatalog
SELECT *
FROM Album;

USE CDCatalog
DELETE FROM Album
WHERE AlbumId > 4;

USE CDCatalog
DELETE FROM Artist
WHERE ArtistId = 12;

USE CDCatalog
SELECT *
FROM Genre
WHERE GenreId > 120

USE CDCatalog
DELETE FROM Song
WHERE SongID = 1