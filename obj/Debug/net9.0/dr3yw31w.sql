IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [products] (
    [id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [price] decimal(18,2) NOT NULL,
    [UnitsInStock] int NOT NULL,
    CONSTRAINT [PK_products] PRIMARY KEY ([id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261106035140_Initialcreate', N'9.0.14');

COMMIT;
GO

