USE CDCatalog
SELECT *
FROM Artist
ORDER BY ArtistName;

USE CDCatalog
SELECT *
FROM Song;

USE CDCatalog
SELECT *
FROM Album;

USE CDCatalog
UPDATE Song
SET TrackLengthSeconds = 48 --,Rating = 5, TrackNumber = 15
WHERE SongID = 12;

USE CDCatalog
DELETE FROM Album
WHERE AlbumId > 4;

USE CDCatalog
DELETE FROM Artist
WHERE ArtistId > 21;

USE CDCatalog
DELETE
FROM Genre
WHERE GenreId > 137

USE CDCatalog
DELETE FROM Song
WHERE SongID > 20