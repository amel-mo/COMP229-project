CREATE TABLE [dbo].[UploadImages] (
    [ImageId]  INT             IDENTITY (1, 1) NOT NULL,
    [Image]    VARBINARY (MAX) NULL,
    [RecipeId] INT             NOT NULL,
    CONSTRAINT [PK_UploadImages] PRIMARY KEY CLUSTERED ([ImageId] ASC),
    CONSTRAINT [FK_UploadImages_Recipes_RecipeId] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipes] ([RecipeId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UploadImages_RecipeId]
    ON [dbo].[UploadImages]([RecipeId] ASC);

