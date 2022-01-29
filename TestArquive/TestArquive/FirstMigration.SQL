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
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211005182335_PrimeiraMigracao')
BEGIN
    CREATE TABLE [Usuarios] (
        [Id] CHAR(36) NOT NULL,
        [NameUser] VARCHAR(40) NOT NULL,
        [SubName] VARCHAR(40) NOT NULL,
        [Email] VARCHAR(40) NOT NULL,
        [Phone] VARCHAR(40) NOT NULL,
        [Date] VARCHAR(40) NOT NULL,
        [Password] VARCHAR(40) NOT NULL,
        [Photo] VARCHAR(MAX) NOT NULL,
        CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211005182335_PrimeiraMigracao')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211005182335_PrimeiraMigracao', N'5.0.10');
END;
GO

COMMIT;
GO

