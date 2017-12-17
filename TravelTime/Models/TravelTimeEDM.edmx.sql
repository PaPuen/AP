
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/13/2017 13:54:15
-- Generated from EDMX file: D:\AP\TravelTime\Models\TravelTimeEDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AP.TravelTime];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CUSTOMER_MAKE_ORDE_TOURORDE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CUSTOMER] DROP CONSTRAINT [FK_CUSTOMER_MAKE_ORDE_TOURORDE];
GO
IF OBJECT_ID(N'[dbo].[FK_DRIVE_DRIVE_TOUR_ID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DRIVE] DROP CONSTRAINT [FK_DRIVE_DRIVE_TOUR_ID];
GO
IF OBJECT_ID(N'[dbo].[FK_DRIVE_DRIVE2_DRIVER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DRIVE] DROP CONSTRAINT [FK_DRIVE_DRIVE2_DRIVER];
GO
IF OBJECT_ID(N'[dbo].[FK_GUIDE_GUIDE_TOUR_ID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GUIDE] DROP CONSTRAINT [FK_GUIDE_GUIDE_TOUR_ID];
GO
IF OBJECT_ID(N'[dbo].[FK_GUIDE_GUIDE2_GUIDER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GUIDE] DROP CONSTRAINT [FK_GUIDE_GUIDE2_GUIDER];
GO
IF OBJECT_ID(N'[dbo].[FK_SERVICES_SERVICES_PROGRAM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SERVICES] DROP CONSTRAINT [FK_SERVICES_SERVICES_PROGRAM];
GO
IF OBJECT_ID(N'[dbo].[FK_SERVICES_SERVICES2_SERVICEP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SERVICES] DROP CONSTRAINT [FK_SERVICES_SERVICES2_SERVICEP];
GO
IF OBJECT_ID(N'[dbo].[FK_TICKET_HOLD_TICK_CUSTOMER]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TICKET] DROP CONSTRAINT [FK_TICKET_HOLD_TICK_CUSTOMER];
GO
IF OBJECT_ID(N'[dbo].[FK_TICKET_TICKET_TOUR_ID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TICKET] DROP CONSTRAINT [FK_TICKET_TICKET_TOUR_ID];
GO
IF OBJECT_ID(N'[dbo].[FK_TOUR_ID_DEPARTURE_DEPARTUR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TOUR] DROP CONSTRAINT [FK_TOUR_ID_DEPARTURE_DEPARTUR];
GO
IF OBJECT_ID(N'[dbo].[FK_TOUR_ID_DESTINATI_DESTINAT]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TOUR] DROP CONSTRAINT [FK_TOUR_ID_DESTINATI_DESTINAT];
GO
IF OBJECT_ID(N'[dbo].[FK_TOUR_ID_TOUR_PROG_PROGRAM]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TOUR] DROP CONSTRAINT [FK_TOUR_ID_TOUR_PROG_PROGRAM];
GO
IF OBJECT_ID(N'[dbo].[FK_TOUR_ID_TRANSPORT_TRANSPOR]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TOUR] DROP CONSTRAINT [FK_TOUR_ID_TRANSPORT_TRANSPOR];
GO
IF OBJECT_ID(N'[dbo].[FK_TOURORDE_REGISTRAT_TOUR_ID]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TOURORDER] DROP CONSTRAINT [FK_TOURORDE_REGISTRAT_TOUR_ID];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CUSTOMER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CUSTOMER];
GO
IF OBJECT_ID(N'[dbo].[DEPARTURE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DEPARTURE];
GO
IF OBJECT_ID(N'[dbo].[DESTINATION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DESTINATION];
GO
IF OBJECT_ID(N'[dbo].[DRIVE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DRIVE];
GO
IF OBJECT_ID(N'[dbo].[DRIVER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DRIVER];
GO
IF OBJECT_ID(N'[dbo].[GUIDE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GUIDE];
GO
IF OBJECT_ID(N'[dbo].[GUIDER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GUIDER];
GO
IF OBJECT_ID(N'[dbo].[PROGRAM]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PROGRAM];
GO
IF OBJECT_ID(N'[dbo].[SERVICEPROVIDER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SERVICEPROVIDER];
GO
IF OBJECT_ID(N'[dbo].[SERVICES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SERVICES];
GO
IF OBJECT_ID(N'[dbo].[TICKET]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TICKET];
GO
IF OBJECT_ID(N'[dbo].[TOUR]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TOUR];
GO
IF OBJECT_ID(N'[dbo].[TOURORDER]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TOURORDER];
GO
IF OBJECT_ID(N'[dbo].[TRANSPORT]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TRANSPORT];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CUSTOMERs'
CREATE TABLE [dbo].[CUSTOMERs] (
    [ID] decimal(8,0) IDENTITY(1,1) NOT NULL,
    [ORDER_ID] decimal(8,0)  NULL,
    [NAME] char(256)  NULL,
    [PHONE] char(10)  NULL,
    [EMAIL] char(256)  NULL,
    [DOB] datetime  NULL
);
GO

-- Creating table 'DEPARTUREs'
CREATE TABLE [dbo].[DEPARTUREs] (
    [ID] decimal(8,0) IDENTITY(1,1) NOT NULL,
    [DESCRIPTION] varchar(max)  NULL,
    [ADDRESS] varchar(max)  NULL
);
GO

-- Creating table 'DESTINATIONs'
CREATE TABLE [dbo].[DESTINATIONs] (
    [ID] decimal(8,0) IDENTITY(1,1) NOT NULL,
    [NAME] char(256)  NULL
);
GO

-- Creating table 'DRIVERs'
CREATE TABLE [dbo].[DRIVERs] (
    [ID] decimal(8,0) IDENTITY(1,1) NOT NULL,
    [NAME] char(256)  NULL,
    [AGE] int  NULL,
    [GENDER] char(1)  NULL,
    [PERSONALID] decimal(8,0)  NULL
);
GO

-- Creating table 'GUIDERs'
CREATE TABLE [dbo].[GUIDERs] (
    [ID] decimal(8,0) IDENTITY(1,1) NOT NULL,
    [NAME] char(256)  NULL,
    [AGE] int  NULL,
    [PERSONALID] decimal(8,0)  NULL,
    [GENDER] char(1)  NULL
);
GO

-- Creating table 'PROGRAMs'
CREATE TABLE [dbo].[PROGRAMs] (
    [ID] decimal(8,0)  IDENTITY(1,1) NOT NULL,
    [DETAILS] varchar(max)  NULL
);
GO

-- Creating table 'SERVICEPROVIDERs'
CREATE TABLE [dbo].[SERVICEPROVIDERs] (
    [ID] decimal(8,0) IDENTITY(1,1) NOT NULL,
    [TYPE] varchar(max)  NULL,
    [COMPANYNAME] varchar(max)  NULL,
    [CONTACTNAME] char(256)  NULL,
    [PHONE] char(10)  NULL,
    [ADDRESS] varchar(max)  NULL,
    [MOREINFO] varchar(max)  NULL
);
GO

-- Creating table 'TICKETs'
CREATE TABLE [dbo].[TICKETs] (
    [ID] decimal(8,0)  IDENTITY(1,1) NOT NULL,
    [CUSTOMER_ID] decimal(8,0)  NULL,
    [TOUR_ID] decimal(8,0)  NOT NULL,
    [SEETNO] int  NULL
);
GO

-- Creating table 'TOURORDERs'
CREATE TABLE [dbo].[TOURORDERs] (
    [ID] decimal(8,0)  IDENTITY(1,1) NOT NULL,
    [TOUR_ID] decimal(8,0)  NOT NULL,
    [DATE] datetime  NULL,
    [NUMOFPEOPLE] int  NULL,
    [TOTALAMOUNT] float  NULL,
    [STATUS] int  NULL
);
GO

-- Creating table 'TRANSPORTs'
CREATE TABLE [dbo].[TRANSPORTs] (
    [ID] decimal(8,0)  IDENTITY(1,1) NOT NULL,
    [TYPE] varchar(max)  NULL,
    [MOREINFO] varchar(max)  NULL
);
GO

-- Creating table 'TOURs'
CREATE TABLE [dbo].[TOURs] (
    [ID] decimal(8,0)  IDENTITY(1,1) NOT NULL,
    [DEPARTURE_ID] decimal(8,0)  NOT NULL,
    [PROGRAM_ID] decimal(8,0)  NOT NULL,
    [DESTINATION_ID] decimal(8,0)  NOT NULL,
    [TRANS_ID] decimal(8,0)  NULL,
    [FROM] datetime  NULL,
    [TO] datetime  NULL,
    [NAME] char(256)  NULL,
    [DESCRIPTION] varchar(max)  NULL,
    [PRICE] float  NULL
);
GO

-- Creating table 'SERVICES'
CREATE TABLE [dbo].[SERVICES] (
    [PROGRAMs_ID] decimal(8,0)  NOT NULL,
    [SERVICEPROVIDERs_ID] decimal(8,0)  NOT NULL
);
GO

-- Creating table 'DRIVE1'
CREATE TABLE [dbo].[DRIVE1] (
    [TOURs_ID] decimal(8,0)  NOT NULL,
    [DRIVERs_ID] decimal(8,0)  NOT NULL
);
GO

-- Creating table 'GUIDE1'
CREATE TABLE [dbo].[GUIDE1] (
    [TOURs_ID] decimal(8,0)  NOT NULL,
    [GUIDERs_ID] decimal(8,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'CUSTOMERs'
ALTER TABLE [dbo].[CUSTOMERs]
ADD CONSTRAINT [PK_CUSTOMERs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'DEPARTUREs'
ALTER TABLE [dbo].[DEPARTUREs]
ADD CONSTRAINT [PK_DEPARTUREs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'DESTINATIONs'
ALTER TABLE [dbo].[DESTINATIONs]
ADD CONSTRAINT [PK_DESTINATIONs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'DRIVERs'
ALTER TABLE [dbo].[DRIVERs]
ADD CONSTRAINT [PK_DRIVERs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GUIDERs'
ALTER TABLE [dbo].[GUIDERs]
ADD CONSTRAINT [PK_GUIDERs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PROGRAMs'
ALTER TABLE [dbo].[PROGRAMs]
ADD CONSTRAINT [PK_PROGRAMs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'SERVICEPROVIDERs'
ALTER TABLE [dbo].[SERVICEPROVIDERs]
ADD CONSTRAINT [PK_SERVICEPROVIDERs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TICKETs'
ALTER TABLE [dbo].[TICKETs]
ADD CONSTRAINT [PK_TICKETs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TOURORDERs'
ALTER TABLE [dbo].[TOURORDERs]
ADD CONSTRAINT [PK_TOURORDERs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TRANSPORTs'
ALTER TABLE [dbo].[TRANSPORTs]
ADD CONSTRAINT [PK_TRANSPORTs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TOURs'
ALTER TABLE [dbo].[TOURs]
ADD CONSTRAINT [PK_TOURs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [PROGRAMs_ID], [SERVICEPROVIDERs_ID] in table 'SERVICES'
ALTER TABLE [dbo].[SERVICES]
ADD CONSTRAINT [PK_SERVICES]
    PRIMARY KEY CLUSTERED ([PROGRAMs_ID], [SERVICEPROVIDERs_ID] ASC);
GO

-- Creating primary key on [TOURs_ID], [DRIVERs_ID] in table 'DRIVE1'
ALTER TABLE [dbo].[DRIVE1]
ADD CONSTRAINT [PK_DRIVE1]
    PRIMARY KEY CLUSTERED ([TOURs_ID], [DRIVERs_ID] ASC);
GO

-- Creating primary key on [TOURs_ID], [GUIDERs_ID] in table 'GUIDE1'
ALTER TABLE [dbo].[GUIDE1]
ADD CONSTRAINT [PK_GUIDE1]
    PRIMARY KEY CLUSTERED ([TOURs_ID], [GUIDERs_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ORDER_ID] in table 'CUSTOMERs'
ALTER TABLE [dbo].[CUSTOMERs]
ADD CONSTRAINT [FK_CUSTOMER_MAKE_ORDE_TOURORDE]
    FOREIGN KEY ([ORDER_ID])
    REFERENCES [dbo].[TOURORDERs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CUSTOMER_MAKE_ORDE_TOURORDE'
CREATE INDEX [IX_FK_CUSTOMER_MAKE_ORDE_TOURORDE]
ON [dbo].[CUSTOMERs]
    ([ORDER_ID]);
GO

-- Creating foreign key on [CUSTOMER_ID] in table 'TICKETs'
ALTER TABLE [dbo].[TICKETs]
ADD CONSTRAINT [FK_TICKET_HOLD_TICK_CUSTOMER]
    FOREIGN KEY ([CUSTOMER_ID])
    REFERENCES [dbo].[CUSTOMERs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TICKET_HOLD_TICK_CUSTOMER'
CREATE INDEX [IX_FK_TICKET_HOLD_TICK_CUSTOMER]
ON [dbo].[TICKETs]
    ([CUSTOMER_ID]);
GO

-- Creating foreign key on [PROGRAMs_ID] in table 'SERVICES'
ALTER TABLE [dbo].[SERVICES]
ADD CONSTRAINT [FK_SERVICES_PROGRAM]
    FOREIGN KEY ([PROGRAMs_ID])
    REFERENCES [dbo].[PROGRAMs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [SERVICEPROVIDERs_ID] in table 'SERVICES'
ALTER TABLE [dbo].[SERVICES]
ADD CONSTRAINT [FK_SERVICES_SERVICEPROVIDER]
    FOREIGN KEY ([SERVICEPROVIDERs_ID])
    REFERENCES [dbo].[SERVICEPROVIDERs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SERVICES_SERVICEPROVIDER'
CREATE INDEX [IX_FK_SERVICES_SERVICEPROVIDER]
ON [dbo].[SERVICES]
    ([SERVICEPROVIDERs_ID]);
GO

-- Creating foreign key on [DEPARTURE_ID] in table 'TOURs'
ALTER TABLE [dbo].[TOURs]
ADD CONSTRAINT [FK_TOUR_ID_DEPARTURE_DEPARTUR1]
    FOREIGN KEY ([DEPARTURE_ID])
    REFERENCES [dbo].[DEPARTUREs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TOUR_ID_DEPARTURE_DEPARTUR1'
CREATE INDEX [IX_FK_TOUR_ID_DEPARTURE_DEPARTUR1]
ON [dbo].[TOURs]
    ([DEPARTURE_ID]);
GO

-- Creating foreign key on [DESTINATION_ID] in table 'TOURs'
ALTER TABLE [dbo].[TOURs]
ADD CONSTRAINT [FK_TOUR_ID_DESTINATI_DESTINAT1]
    FOREIGN KEY ([DESTINATION_ID])
    REFERENCES [dbo].[DESTINATIONs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TOUR_ID_DESTINATI_DESTINAT1'
CREATE INDEX [IX_FK_TOUR_ID_DESTINATI_DESTINAT1]
ON [dbo].[TOURs]
    ([DESTINATION_ID]);
GO

-- Creating foreign key on [PROGRAM_ID] in table 'TOURs'
ALTER TABLE [dbo].[TOURs]
ADD CONSTRAINT [FK_TOUR_ID_TOUR_PROG_PROGRAM1]
    FOREIGN KEY ([PROGRAM_ID])
    REFERENCES [dbo].[PROGRAMs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TOUR_ID_TOUR_PROG_PROGRAM1'
CREATE INDEX [IX_FK_TOUR_ID_TOUR_PROG_PROGRAM1]
ON [dbo].[TOURs]
    ([PROGRAM_ID]);
GO

-- Creating foreign key on [TOUR_ID] in table 'TICKETs'
ALTER TABLE [dbo].[TICKETs]
ADD CONSTRAINT [FK_TICKET_TICKET_TOUR_ID1]
    FOREIGN KEY ([TOUR_ID])
    REFERENCES [dbo].[TOURs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TICKET_TICKET_TOUR_ID1'
CREATE INDEX [IX_FK_TICKET_TICKET_TOUR_ID1]
ON [dbo].[TICKETs]
    ([TOUR_ID]);
GO

-- Creating foreign key on [TRANS_ID] in table 'TOURs'
ALTER TABLE [dbo].[TOURs]
ADD CONSTRAINT [FK_TOUR_ID_TRANSPORT_TRANSPOR1]
    FOREIGN KEY ([TRANS_ID])
    REFERENCES [dbo].[TRANSPORTs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TOUR_ID_TRANSPORT_TRANSPOR1'
CREATE INDEX [IX_FK_TOUR_ID_TRANSPORT_TRANSPOR1]
ON [dbo].[TOURs]
    ([TRANS_ID]);
GO

-- Creating foreign key on [TOUR_ID] in table 'TOURORDERs'
ALTER TABLE [dbo].[TOURORDERs]
ADD CONSTRAINT [FK_TOURORDE_REGISTRAT_TOUR_ID1]
    FOREIGN KEY ([TOUR_ID])
    REFERENCES [dbo].[TOURs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TOURORDE_REGISTRAT_TOUR_ID1'
CREATE INDEX [IX_FK_TOURORDE_REGISTRAT_TOUR_ID1]
ON [dbo].[TOURORDERs]
    ([TOUR_ID]);
GO

-- Creating foreign key on [TOURs_ID] in table 'DRIVE1'
ALTER TABLE [dbo].[DRIVE1]
ADD CONSTRAINT [FK_DRIVE1_TOUR]
    FOREIGN KEY ([TOURs_ID])
    REFERENCES [dbo].[TOURs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [DRIVERs_ID] in table 'DRIVE1'
ALTER TABLE [dbo].[DRIVE1]
ADD CONSTRAINT [FK_DRIVE1_DRIVER]
    FOREIGN KEY ([DRIVERs_ID])
    REFERENCES [dbo].[DRIVERs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DRIVE1_DRIVER'
CREATE INDEX [IX_FK_DRIVE1_DRIVER]
ON [dbo].[DRIVE1]
    ([DRIVERs_ID]);
GO

-- Creating foreign key on [TOURs_ID] in table 'GUIDE1'
ALTER TABLE [dbo].[GUIDE1]
ADD CONSTRAINT [FK_GUIDE1_TOUR]
    FOREIGN KEY ([TOURs_ID])
    REFERENCES [dbo].[TOURs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [GUIDERs_ID] in table 'GUIDE1'
ALTER TABLE [dbo].[GUIDE1]
ADD CONSTRAINT [FK_GUIDE1_GUIDER]
    FOREIGN KEY ([GUIDERs_ID])
    REFERENCES [dbo].[GUIDERs]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GUIDE1_GUIDER'
CREATE INDEX [IX_FK_GUIDE1_GUIDER]
ON [dbo].[GUIDE1]
    ([GUIDERs_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------