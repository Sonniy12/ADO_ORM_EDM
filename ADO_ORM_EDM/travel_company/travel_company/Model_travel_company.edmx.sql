
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/03/2021 17:39:02
-- Generated from EDMX file: C:\AКАДЕМИЯ шаг\1_D_Домашняя работа\1_C#_SQL\5_ADO_NET\travel_company\travel_company\Model_travel_company.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Travel_company_new];
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

-- Creating table 'tripSet'
CREATE TABLE [dbo].[tripSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nchar(30)  NULL,
    [departure] datetime  NULL,
    [client_baseId] int  NOT NULL,
    [customers_Id] int  NOT NULL
);
GO

-- Creating table 'customersSet'
CREATE TABLE [dbo].[customersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nchar(50)  NOT NULL,
    [last_name] nchar(50)  NOT NULL,
    [client_baseId] int  NOT NULL
);
GO

-- Creating table 'travel_agentSet'
CREATE TABLE [dbo].[travel_agentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nchar(50)  NOT NULL,
    [last_name] nchar(50)  NOT NULL,
    [client_baseId] int  NOT NULL
);
GO

-- Creating table 'client_baseSet'
CREATE TABLE [dbo].[client_baseSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fk_l_name] nvarchar(50)  NULL,
    [id_trip] int  NULL,
    [id_client] int  NULL
);
GO

-- Creating table 'Creat_table_baseClientSet'
CREATE TABLE [dbo].[Creat_table_baseClientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [id_trip_new] int  NULL,
    [id_client_new] int  NULL
);
GO

-- Creating table 'Creat_table_baseClienttrip'
CREATE TABLE [dbo].[Creat_table_baseClienttrip] (
    [Creat_table_baseClient_Id] int  NOT NULL,
    [trip_Id] int  NOT NULL
);
GO

-- Creating table 'Creat_table_baseClientcustomers'
CREATE TABLE [dbo].[Creat_table_baseClientcustomers] (
    [Creat_table_baseClient_Id] int  NOT NULL,
    [customers_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'tripSet'
ALTER TABLE [dbo].[tripSet]
ADD CONSTRAINT [PK_tripSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'customersSet'
ALTER TABLE [dbo].[customersSet]
ADD CONSTRAINT [PK_customersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [last_name] in table 'travel_agentSet'
ALTER TABLE [dbo].[travel_agentSet]
ADD CONSTRAINT [PK_travel_agentSet]
    PRIMARY KEY CLUSTERED ([last_name] ASC);
GO

-- Creating primary key on [Id] in table 'client_baseSet'
ALTER TABLE [dbo].[client_baseSet]
ADD CONSTRAINT [PK_client_baseSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Creat_table_baseClientSet'
ALTER TABLE [dbo].[Creat_table_baseClientSet]
ADD CONSTRAINT [PK_Creat_table_baseClientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Creat_table_baseClient_Id], [trip_Id] in table 'Creat_table_baseClienttrip'
ALTER TABLE [dbo].[Creat_table_baseClienttrip]
ADD CONSTRAINT [PK_Creat_table_baseClienttrip]
    PRIMARY KEY CLUSTERED ([Creat_table_baseClient_Id], [trip_Id] ASC);
GO

-- Creating primary key on [Creat_table_baseClient_Id], [customers_Id] in table 'Creat_table_baseClientcustomers'
ALTER TABLE [dbo].[Creat_table_baseClientcustomers]
ADD CONSTRAINT [PK_Creat_table_baseClientcustomers]
    PRIMARY KEY CLUSTERED ([Creat_table_baseClient_Id], [customers_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [customers_Id] in table 'tripSet'
ALTER TABLE [dbo].[tripSet]
ADD CONSTRAINT [FK_tripcustomers]
    FOREIGN KEY ([customers_Id])
    REFERENCES [dbo].[customersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tripcustomers'
CREATE INDEX [IX_FK_tripcustomers]
ON [dbo].[tripSet]
    ([customers_Id]);
GO

-- Creating foreign key on [client_baseId] in table 'travel_agentSet'
ALTER TABLE [dbo].[travel_agentSet]
ADD CONSTRAINT [FK_client_basetravel_agent]
    FOREIGN KEY ([client_baseId])
    REFERENCES [dbo].[client_baseSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_client_basetravel_agent'
CREATE INDEX [IX_FK_client_basetravel_agent]
ON [dbo].[travel_agentSet]
    ([client_baseId]);
GO

-- Creating foreign key on [client_baseId] in table 'tripSet'
ALTER TABLE [dbo].[tripSet]
ADD CONSTRAINT [FK_client_basetrip]
    FOREIGN KEY ([client_baseId])
    REFERENCES [dbo].[client_baseSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_client_basetrip'
CREATE INDEX [IX_FK_client_basetrip]
ON [dbo].[tripSet]
    ([client_baseId]);
GO

-- Creating foreign key on [client_baseId] in table 'customersSet'
ALTER TABLE [dbo].[customersSet]
ADD CONSTRAINT [FK_client_basecustomers]
    FOREIGN KEY ([client_baseId])
    REFERENCES [dbo].[client_baseSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_client_basecustomers'
CREATE INDEX [IX_FK_client_basecustomers]
ON [dbo].[customersSet]
    ([client_baseId]);
GO

-- Creating foreign key on [Creat_table_baseClient_Id] in table 'Creat_table_baseClienttrip'
ALTER TABLE [dbo].[Creat_table_baseClienttrip]
ADD CONSTRAINT [FK_Creat_table_baseClienttrip_Creat_table_baseClient]
    FOREIGN KEY ([Creat_table_baseClient_Id])
    REFERENCES [dbo].[Creat_table_baseClientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [trip_Id] in table 'Creat_table_baseClienttrip'
ALTER TABLE [dbo].[Creat_table_baseClienttrip]
ADD CONSTRAINT [FK_Creat_table_baseClienttrip_trip]
    FOREIGN KEY ([trip_Id])
    REFERENCES [dbo].[tripSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Creat_table_baseClienttrip_trip'
CREATE INDEX [IX_FK_Creat_table_baseClienttrip_trip]
ON [dbo].[Creat_table_baseClienttrip]
    ([trip_Id]);
GO

-- Creating foreign key on [Creat_table_baseClient_Id] in table 'Creat_table_baseClientcustomers'
ALTER TABLE [dbo].[Creat_table_baseClientcustomers]
ADD CONSTRAINT [FK_Creat_table_baseClientcustomers_Creat_table_baseClient]
    FOREIGN KEY ([Creat_table_baseClient_Id])
    REFERENCES [dbo].[Creat_table_baseClientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [customers_Id] in table 'Creat_table_baseClientcustomers'
ALTER TABLE [dbo].[Creat_table_baseClientcustomers]
ADD CONSTRAINT [FK_Creat_table_baseClientcustomers_customers]
    FOREIGN KEY ([customers_Id])
    REFERENCES [dbo].[customersSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Creat_table_baseClientcustomers_customers'
CREATE INDEX [IX_FK_Creat_table_baseClientcustomers_customers]
ON [dbo].[Creat_table_baseClientcustomers]
    ([customers_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------