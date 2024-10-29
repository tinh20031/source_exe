
UPDATE Services
SET CategoryId = 1
WHERE CategoryId IN (2, 3, 4, 5, 6);

UPDATE Salons
SET CategoryId = 1
WHERE CategoryId IN (2, 3, 4, 5, 6);

DELETE FROM [dbo].[Categories]
WHERE Id IN (2, 3, 4, 5, 6);


