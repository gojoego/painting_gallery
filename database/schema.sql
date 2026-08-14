CREATE TABLE dbo.Artworks (
    Id INT IDENTITY(1,1) NOT NULL,
    Title NVARCHAR(MAX) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Medium NVARCHAR(MAX) NOT NULL,
    Dimensions NVARCHAR(MAX) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Status NVARCHAR(MAX) NOT NULL,
    ImageUrl NVARCHAR(MAX) NOT NULL,
    CreatedDate DATETIME2(7) NOT NULL,

    CONSTRAINT PK_Artworks PRIMARY KEY CLUSTERED (Id), 
    CONSTRAINT CK_Artworks_Price_NonNegative
        CHECK (Price >= 0),
    CONSTRAINT CK_Artworks_STATUS 
        CHECK (Status IN ('Draft', 'Published'))
);
GO

CREATE INDEX IX_Artworks_Status_CreatedDate
ON dbo.Artworks (Status, CreatedDate DESC);
GO  