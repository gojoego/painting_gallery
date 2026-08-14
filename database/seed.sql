INSERT INTO dbo.Artworks
    (Title, Description, Medium, Dimensions, Price, Status, ImageUrl, CreatedDate)
VALUES
    (
        'Golden Fields',
        'A warm landscape depicting rolling fields illuminated by late afternoon sunlight.',
        'Oil on Canvas',
        '24 x 36 in',
        1200.00,
        'Published',
        '/images/golden-fields.jpg',
        SYSDATETIME()
    ),
    (
        'Blue Horizon',
        'An atmospheric study of the meeting point between sea and sky.',
        'Acrylic on Canvas',
        '30 x 40 in',
        1450.00,
        'Published',
        '/images/blue-horizon.jpg',
        SYSDATETIME()
    ),
    (
        'Evening Light',
        'Soft evening light filters across a quiet landscape.',
        'Oil on Canvas',
        '20 x 30 in',
        950.00,
        'Published',
        '/images/evening-light.jpg',
        SYSDATETIME()
    ),
    (
        'Quiet Morning',
        'A peaceful morning scene rendered in muted colors and gentle light.',
        'Watercolor',
        '18 x 24 in',
        650.00,
        'Published',
        '/images/quiet-morning.jpg',
        SYSDATETIME()
    ),
    (
        'Summer Garden',
        'A colorful garden filled with summer flowers and dense foliage.',
        'Acrylic on Canvas',
        '24 x 30 in',
        1100.00,
        'Published',
        '/images/summer-garden.jpg',
        SYSDATETIME()
    ),
    (
        'Study in Red',
        'An abstract exploration of red tones, texture, and movement.',
        'Oil on Canvas',
        '20 x 20 in',
        800.00,
        'Published',
        '/images/study-in-red.jpg',
        SYSDATETIME()
    ),
    (
        'Autumn Path',
        'A winding woodland path surrounded by the colors of autumn.',
        'Oil on Canvas',
        '24 x 36 in',
        1300.00,
        'Published',
        '/images/autumn-path.jpg',
        SYSDATETIME()
    ),
    (
        'Coastal Mist',
        'A quiet coastline emerging through layers of morning mist.',
        'Acrylic on Canvas',
        '30 x 30 in',
        1250.00,
        'Published',
        '/images/coastal-mist.jpg',
        SYSDATETIME()
    ),
    (
        'Still Waters',
        'Reflections stretch across a calm lake beneath an open sky.',
        'Oil on Canvas',
        '18 x 24 in',
        750.00,
        'Published',
        '/images/still-waters.jpg',
        SYSDATETIME()
    ),
    (
        'Winter Trees',
        'Bare trees create a stark pattern against a pale winter landscape.',
        'Watercolor',
        '16 x 20 in',
        575.00,
        'Draft',
        '/images/winter-trees.jpg',
        SYSDATETIME()
    );
GO