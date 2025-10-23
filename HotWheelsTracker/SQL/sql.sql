USE [HotWheelsTrackerDB]
GO

/****** Object: SqlProcedure [dbo].[GetCarsBySeries] Script Date: 10/23/2025 3:15:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE GetCarsBySeries
	@Series NVARCHAR(50)
AS
BEGIN
	SELECT *
	FROM Cars
	WHERE Series = @Series
	ORDER BY Name;
END
