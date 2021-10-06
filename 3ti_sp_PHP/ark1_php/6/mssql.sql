USE [3tisp_SamolotyArk1]
GO

/****** Object: Table [dbo].[odloty] Script Date: 06.10.2021 12:36:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[odloty] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [samoloty_id] INT           NOT NULL,
    [nr_rejsu]    NVARCHAR (8)  NULL,
    [kierunek]    NVARCHAR (10) NULL,
    [czas]        TIME (7)      NOT NULL,
    [dzien]       DATE          NULL,
    [status_lotu] NVARCHAR (50) NULL
) GO

INSERT INTO [dbo].[odloty] (samoloty_id, nr_rejsu, kierunek, czas, dzien, status_lotu) VALUES
( 1, 'FR1646', 'Neapol', '09:20:00', '2019-07-25', 'wystartowal'),
( 1, 'FR1327', 'ALICANTE', '09:10:00', '2019-07-25', 'Opozniony 10 min'),
( 2, 'W63425', 'Warszawa', '09:45:00', '2019-07-25', 'odprawa'),
( 3, 'LX5647', 'Londyn LT', '10:03:00', '2019-07-25', 'odprawa'),
( 3, 'LX5673', 'Malta', '10:06:00', '2019-07-25', ''),
( 3, 'LX5622', 'Wieden', '10:13:00', '2019-07-25', ''),
( 4, 'LH9821', 'Berlin', '10:16:00', '2019-07-25', ''),
( 4, 'LH9888', 'Hamburg', '10:19:00', '2019-07-25', ''),
( 4, 'LH9331', 'Monachium', '10:22:00', '2019-07-25', ''),
( 2, 'W68769', 'Zurych', '09:56:00', '2019-07-25', 'boarding');