USE [FinalDB]
GO

/****** Object: Table [dbo].[Carts] Script Date: 08/18/2016 2:46:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Carts];


GO
CREATE TABLE [dbo].[Carts] (
    [RecordId]    INT Identity (1,1)         NOT NULL Primary key,
    [CartId]      VARCHAR (50) NOT NULL,
    [Count]       INT          NOT NULL,
    [DateCreated] DATETIME     NOT NULL,
    [foodID]      INT          NOT NULL
);


