
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/28/2020 14:27:41
-- Generated from EDMX file: D:\DP\WebMVCdp\WebMVCdp\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Movies'
CREATE TABLE [dbo].[Movies] (
    [Movie_id] int IDENTITY(1,1) NOT NULL,
    [Mname] nvarchar(max)  NOT NULL,
    [RealeseDate] datetime  NOT NULL
);
GO

-- Creating table 'Multiplexes'
CREATE TABLE [dbo].[Multiplexes] (
    [Multi_id] int IDENTITY(1,1) NOT NULL,
    [Multi_Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Movie_id] nvarchar(max)  NOT NULL,
    [MovieMovie_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Movie_id] in table 'Movies'
ALTER TABLE [dbo].[Movies]
ADD CONSTRAINT [PK_Movies]
    PRIMARY KEY CLUSTERED ([Movie_id] ASC);
GO

-- Creating primary key on [Multi_id] in table 'Multiplexes'
ALTER TABLE [dbo].[Multiplexes]
ADD CONSTRAINT [PK_Multiplexes]
    PRIMARY KEY CLUSTERED ([Multi_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MovieMovie_id] in table 'Multiplexes'
ALTER TABLE [dbo].[Multiplexes]
ADD CONSTRAINT [FK_MovieMultiplex]
    FOREIGN KEY ([MovieMovie_id])
    REFERENCES [dbo].[Movies]
        ([Movie_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieMultiplex'
CREATE INDEX [IX_FK_MovieMultiplex]
ON [dbo].[Multiplexes]
    ([MovieMovie_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------