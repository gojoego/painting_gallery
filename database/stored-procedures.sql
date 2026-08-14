CREATE OR ALTER PROCEDURE dbo.sp_GetPublishedArtwork
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Id,
        Title,
        Description,
        Medium,
        Dimensions,
        Price,
        Status,
        ImageUrl,
        CreatedDate
    FROM dbo.Artworks
    WHERE Status = 'Published'
    ORDER BY CreatedDate DESC, Id DESC;
END;
GO