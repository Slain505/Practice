-- SQLite
INSERT INTO Users (Id, UserName)
VALUES (1, 'John Doe');

INSERT INTO Users (Id, UserName)
VALUES (2, 'Joan Doe');

INSERT INTO Users (Id, UserName)
VALUES (3, 'Jane Doe');

DELETE FROM Users
WHERE Id = 3;