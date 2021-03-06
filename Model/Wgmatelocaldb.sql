USE [WGmate_l]
GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TMatsRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP TABLE [dbo].[Cpa1Tmp.CPA1TMatsRec]
GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TMatsNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP TABLE [dbo].[Cpa1Tmp.CPA1TMatsNotsRec]
GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP TABLE [dbo].[Cpa1Tmp.CPA1TMainRec]
GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TInstRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP TABLE [dbo].[Cpa1Tmp.CPA1TInstRec]
GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TInstNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP TABLE [dbo].[Cpa1Tmp.CPA1TInstNotsRec]
GO
/****** Object:  StoredProcedure [dbo].[InsertCPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[InsertCPA1TMainRec]
GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMatsRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GetCpa1TmpCPA1TMatsRec]
GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMatsNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GetCpa1TmpCPA1TMatsNotsRec]
GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMainRecList]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GetCpa1TmpCPA1TMainRecList]
GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GetCpa1TmpCPA1TMainRec]
GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TInstRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GetCpa1TmpCPA1TInstRec]
GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TInstNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GetCpa1TmpCPA1TInstNotsRec]
GO
/****** Object:  StoredProcedure [dbo].[GenerateClass]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[GenerateClass]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCPA1TMainRecAll]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[DeleteCPA1TMainRecAll]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
DROP PROCEDURE [dbo].[DeleteCPA1TMainRec]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,>
-- Description:	<Description,,Delete CPA1TMainRec>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteCPA1TMainRec] 
	@ID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [dbo].[Cpa1Tmp.CPA1TMainRec] WHERE [ID] = @ID
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TInstRec] WHERE [CPA1TMainRecID] = @ID
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TInstNotsRec] WHERE [CPA1TMainRecID] = @ID
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TMatsRec] WHERE [CPA1TMainRecID] = @ID
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TMatsNotsRec] WHERE [CPA1TMainRecID] = @ID
END


GO
/****** Object:  StoredProcedure [dbo].[DeleteCPA1TMainRecAll]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,24/09/2016>
-- Description:	<Description,,DeleteCPA1TMainRecAll>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteCPA1TMainRecAll] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;


	DELETE FROM [dbo].[Cpa1Tmp.CPA1TMainRec]
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TMatsRec]
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TMatsNotsRec]
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TInstRec]
	DELETE FROM [dbo].[Cpa1Tmp.CPA1TInstNotsRec]
END

GO
/****** Object:  StoredProcedure [dbo].[GenerateClass]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GenerateClass]
@RecName nvarchar(70)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @TableName VARCHAR(MAX) = @RecName -- Replace 'NewsItem' with your table name
	DECLARE @TableSchema VARCHAR(MAX) = 'dbo' -- Replace 'Markets' with your schema name
	DECLARE @result varchar(max) = ''

	SET @result = @result + 'using System;' + CHAR(13) + CHAR(13) 

	IF (@TableSchema IS NOT NULL) 
	BEGIN
		SET @result = @result + 'namespace ' + @TableSchema  + CHAR(13) + '{' + CHAR(13) 
	END

	SET @result = @result + 'public class ' + @TableName + CHAR(13) + '{' + CHAR(13) 
	SET @result = @result + '#region Instance Properties' + CHAR(13)  

	SELECT @result = @result + CHAR(13) 
		+ ' public ' + ColumnType + ' ' + ColumnName + ' { get; set; } ' + CHAR(13) 
	FROM
	(
		SELECT  c.COLUMN_NAME   AS ColumnName 
			, CASE c.DATA_TYPE   
				WHEN 'bigint' THEN
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Int64?' ELSE 'Int64' END
				WHEN 'binary' THEN 'Byte[]'
				WHEN 'bit' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Boolean?' ELSE 'Boolean' END            
				WHEN 'char' THEN 'String'
				WHEN 'date' THEN
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'DateTime?' ELSE 'DateTime' END                        
				WHEN 'datetime' THEN
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'DateTime?' ELSE 'DateTime' END                        
				WHEN 'datetime2' THEN  
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'DateTime?' ELSE 'DateTime' END                        
				WHEN 'datetimeoffset' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'DateTimeOffset?' ELSE 'DateTimeOffset' END                                    
				WHEN 'decimal' THEN  
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Decimal?' ELSE 'Decimal' END                                    
				WHEN 'float' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'double?' ELSE 'double' END                                    
				WHEN 'image' THEN 'Byte[]'
				WHEN 'int' THEN  
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Int32?' ELSE 'Int32' END
				WHEN 'money' THEN
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Decimal?' ELSE 'Decimal' END                                                
				WHEN 'nchar' THEN 'String'
				WHEN 'ntext' THEN 'String'
				WHEN 'numeric' THEN
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Decimal?' ELSE 'Decimal' END                                                            
				WHEN 'nvarchar' THEN 'String'
				WHEN 'real' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Double?' ELSE 'Double' END                                                                        
				WHEN 'smalldatetime' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'DateTime?' ELSE 'DateTime' END                                    
				WHEN 'smallint' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Int16?' ELSE 'Int16'END            
				WHEN 'smallmoney' THEN  
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Decimal?' ELSE 'Decimal' END                                                                        
				WHEN 'text' THEN 'String'
				WHEN 'time' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'TimeSpan?' ELSE 'TimeSpan' END                                                                                    
				WHEN 'timestamp' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'DateTime?' ELSE 'DateTime' END                                    
				WHEN 'tinyint' THEN 
					CASE C.IS_NULLABLE
						WHEN 'YES' THEN 'Byte?' ELSE 'Byte' END                                                
				WHEN 'uniqueidentifier' THEN 'Guid'
				WHEN 'varbinary' THEN 'Byte[]'
				WHEN 'varchar' THEN 'String'
				ELSE 'Object'
			END AS ColumnType
			, c.ORDINAL_POSITION 
	FROM    INFORMATION_SCHEMA.COLUMNS c
	WHERE   c.TABLE_NAME = @TableName and ISNULL(@TableSchema, c.TABLE_SCHEMA) = c.TABLE_SCHEMA  
	) t
	ORDER BY t.ORDINAL_POSITION

	SET @result = @result + CHAR(13) + '#endregion Instance Properties' + CHAR(13)  
	SET @result = @result  + '}' + CHAR(13)

	IF (@TableSchema IS NOT NULL) 
	BEGIN
		SET @result = @result + CHAR(13) + '}' 
	END
	
	PRINT @result;
END
























































GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TInstNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,08/1/2015>
-- Description:	<Description,,Get Cpa1Tmp CPA1TInstNotsRec>
-- =============================================
CREATE PROCEDURE [dbo].[GetCpa1TmpCPA1TInstNotsRec]
	@CPA1TMainRecID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT [ID]
		  ,[CPA1TMainRecID]
		  ,[CPA1TIsInstNo]
		  ,[CPA1TIsNotes]
	  FROM [dbo].[Cpa1Tmp.CPA1TInstNotsRec] WHERE [CPA1TMainRecID]=@CPA1TMainRecID
END


GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TInstRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,08/1/2015>
-- Description:	<Description,,Get Cpa1Tmp CPA1TInstRec>
-- =============================================
CREATE PROCEDURE [dbo].[GetCpa1TmpCPA1TInstRec]
	@CPA1TMainRecID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT [ID]
		  ,[CPA1TMainRecID]
		  ,[CPA1TInstNo]
		  ,[CPA1TIsOrdDate]
		  ,[CPA1TIsIssDate]
		  ,[CPA1TOperOutst]
	  FROM [dbo].[Cpa1Tmp.CPA1TInstRec] WHERE [CPA1TMainRecID]=@CPA1TMainRecID
END


GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,08/1/2015>
-- Description:	<Description,,Get Cpa1Tmp CPA1TMainRec>
-- =============================================
CREATE PROCEDURE [dbo].[GetCpa1TmpCPA1TMainRec]
	@CPA1TFileNo int,
	@CPA1TDelPoint smallint,
	@CPA1TStyle nvarchar(13),
	@CPA1TVarn nvarchar(9)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT [ID]
		  ,[CPA1TRecNo]
		  ,[CPA1TFileNo]
		  ,[CPA1TDelPoint]
		  ,[CPA1TStyle]
		  ,[CPA1TVarn]
		  ,[CPA1TCustNo]
		  ,[CPA1TCustRef]
		  ,[CPA1TDelDate]
		  ,[CPA1TAgntNo]
		  ,[CPA1TDockNo]
		  ,[CPA1TFactNo]
		  ,[CPA1TDockDelDate]
		  ,[CPA1TMainFabric]
		  ,[CPA1TOrderOuts]
		  ,[CPA1TInFileFlag]
	  FROM [dbo].[Cpa1Tmp.CPA1TMainRec] WHERE [CPA1TFileNo]=@CPA1TFileNo AND
						[CPA1TDelPoint]=@CPA1TDelPoint AND [CPA1TStyle]=@CPA1TStyle AND [CPA1TVarn]=@CPA1TVarn
END


GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMainRecList]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,31/12/2016>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCpa1TmpCPA1TMainRecList]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT [ID]
      ,[CPA1TRecNo]
      ,[CPA1TFileNo]
      ,[CPA1TDelPoint]
      ,[CPA1TStyle]
      ,[CPA1TVarn]
      ,[CPA1TCustNo]
      ,[CPA1TCustRef]
      ,[CPA1TDelDate]
      ,[CPA1TAgntNo]
      ,[CPA1TDockNo]
      ,[CPA1TFactNo]
      ,[CPA1TDockDelDate]
      ,[CPA1TMainFabric]
      ,[CPA1TOrderOuts]
      ,[CPA1TInFileFlag]
  FROM [dbo].[Cpa1Tmp.CPA1TMainRec]
END

GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMatsNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,08/1/2015>
-- Description:	<Description,,Get Cpa1Tmp CPA1TMatsNotsRec>
-- =============================================
CREATE PROCEDURE [dbo].[GetCpa1TmpCPA1TMatsNotsRec]
	@CPA1TMainRecID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT [ID]
		  ,[CPA1TMainRecID]
		  ,[CPA1TMaMatsNo]
		  ,[CPA1TMaNotes]
	  FROM [dbo].[Cpa1Tmp.CPA1TMatsNotsRec] WHERE [CPA1TMainRecID]=@CPA1TMainRecID
END


GO
/****** Object:  StoredProcedure [dbo].[GetCpa1TmpCPA1TMatsRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,08/1/2015>
-- Description:	<Description,,Get Cpa1Tmp CPA1TMatsRec>
-- =============================================
CREATE PROCEDURE [dbo].[GetCpa1TmpCPA1TMatsRec]
	@CPA1TMainRecID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT [ID]
		  ,[CPA1TMainRecID]
		  ,[CPA1TMatsNo]
		  ,[CPA1TMaOrdDate]
		  ,[CPA1TMaIssDate]
		  ,[CPA1TMaOrdNo]
		  ,[CPA1TMatsOutst]
	  FROM [dbo].[Cpa1Tmp.CPA1TMatsRec] WHERE [CPA1TMainRecID]=@CPA1TMainRecID
END


GO
/****** Object:  StoredProcedure [dbo].[InsertCPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Henry McBean>
-- Create date: <Create Date,,08/11/2015>
-- Description:	<Description,,Insert CPA1TMainRec>
-- =============================================
CREATE PROCEDURE [dbo].[InsertCPA1TMainRec]
	@lTranID int OUTPUT,
	@XmlString text
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	BEGIN TRANSACTION
	BEGIN TRY
	DECLARE @MainRecID int

		DECLARE @XMLDocPointer INT    
		EXEC sp_xml_preparedocument @XMLDocPointer OUTPUT, @XmlString
		
		---- Insert Cpa1Tmp.CPA1TMainRec
		INSERT INTO [dbo].[Cpa1Tmp.CPA1TMainRec]
					   ([CPA1TRecNo]
					   ,[CPA1TFileNo]
					   ,[CPA1TDelPoint]
					   ,[CPA1TStyle]
					   ,[CPA1TVarn]
					   ,[CPA1TCustNo]
					   ,[CPA1TCustRef]
					   ,[CPA1TDelDate]
					   ,[CPA1TAgntNo]
					   ,[CPA1TDockNo]
					   ,[CPA1TFactNo]
					   ,[CPA1TDockDelDate]
					   ,[CPA1TMainFabric]
					   ,[CPA1TOrderOuts]
					   ,[CPA1TInFileFlag])
			SELECT [CPA1TRecNo]
				  ,[CPA1TFileNo]
				  ,[CPA1TDelPoint]
				  ,[CPA1TStyle]
				  ,[CPA1TVarn]
				  ,[CPA1TCustNo]
				  ,[CPA1TCustRef]
				  ,[CPA1TDelDate]
				  ,[CPA1TAgntNo]
				  ,[CPA1TDockNo]
				  ,[CPA1TFactNo]
				  ,[CPA1TDockDelDate]
				  ,[CPA1TMainFabric]
				  ,[CPA1TOrderOuts]
				  ,[CPA1TInFileFlag]
			  FROM OPENXML(@XMLDocPointer,'/ROOT/Cpa1Tmp.CPA1TMainRec',2)
			 WITH (CPA1TRecNo int,
				   CPA1TFileNo int,
				   CPA1TDelPoint smallint,
				   CPA1TStyle nvarchar(13),
				   CPA1TVarn nvarchar(9),
				   CPA1TCustNo smallint,
				   CPA1TCustRef nvarchar(26),
				   CPA1TDelDate smalldatetime,
				   CPA1TAgntNo smallint,
				   CPA1TDockNo int,
				   CPA1TFactNo smallint,
				   CPA1TDockDelDate smalldatetime,
				   CPA1TMainFabric nvarchar(26),
				   CPA1TOrderOuts smallint,
				   CPA1TInFileFlag smallint)

		IF (@@ROWCOUNT > 0)
		BEGIN
			SET @MainRecID = @@IDENTITY

			---- Insert Cpa1Tmp.CPA1TInstRec
			INSERT INTO [dbo].[Cpa1Tmp.CPA1TInstRec]
							([CPA1TMainRecID]
							,[CPA1TInstNo]
							,[CPA1TIsOrdDate]
							,[CPA1TIsIssDate]
							,[CPA1TOperOutst])
				SELECT @MainRecID
					  ,[CPA1TInstNo]
					  ,[CPA1TIsOrdDate]
					  ,[CPA1TIsIssDate]
					  ,[CPA1TOperOutst]
				  FROM OPENXML(@XMLDocPointer,'/ROOT/Cpa1Tmp.CPA1TInstRec',2)
					WITH (CPA1TMainRecID int,
						CPA1TInstNo smallint,
						CPA1TIsOrdDate smalldatetime,
						CPA1TIsIssDate smalldatetime,
						CPA1TOperOutst smallint)

			---- Insert Cpa1Tmp.CPA1TInstNotsRec
			INSERT INTO [dbo].[Cpa1Tmp.CPA1TInstNotsRec]
						   ([CPA1TMainRecID]
						   ,[CPA1TIsInstNo]
						   ,[CPA1TIsNotes])
				SELECT @MainRecID
					  ,[CPA1TIsInstNo]
					  ,[CPA1TIsNotes]
				  FROM OPENXML(@XMLDocPointer,'/ROOT/Cpa1Tmp.CPA1TInstNotsRec',2)
					 WITH (CPA1TMainRecID int,
						   CPA1TIsInstNo smallint,
						   CPA1TIsNotes nvarchar(62))

			---- Insert Cpa1Tmp.CPA1TMatsRec
			INSERT INTO [dbo].[Cpa1Tmp.CPA1TMatsRec]
						   ([CPA1TMainRecID]
						   ,[CPA1TMatsNo]
						   ,[CPA1TMaOrdDate]
						   ,[CPA1TMaIssDate]
						   ,[CPA1TMaOrdNo]
						   ,[CPA1TMatsOutst])
				SELECT @MainRecID
					  ,[CPA1TMatsNo]
					  ,[CPA1TMaOrdDate]
					  ,[CPA1TMaIssDate]
					  ,[CPA1TMaOrdNo]
					  ,[CPA1TMatsOutst]
				  FROM OPENXML(@XMLDocPointer,'/ROOT/Cpa1Tmp.CPA1TMatsRec',2)
					 WITH (CPA1TMainRecID int,
						   CPA1TMatsNo smallint,
						   CPA1TMaOrdDate smalldatetime,
						   CPA1TMaIssDate smalldatetime,
						   CPA1TMaOrdNo int,
						   CPA1TMatsOutst smallint)

			---- Insert Cpa1Tmp.CPA1TMatsNotsRec
			INSERT INTO [dbo].[Cpa1Tmp.CPA1TMatsNotsRec]
							   ([CPA1TMainRecID]
							   ,[CPA1TMaMatsNo]
							   ,[CPA1TMaNotes])
				SELECT @MainRecID
					  ,[CPA1TMaMatsNo]
					  ,[CPA1TMaNotes]
				  FROM OPENXML(@XMLDocPointer,'/ROOT/Cpa1Tmp.CPA1TMatsNotsRec',2)
					WITH (CPA1TMainRecID  int,
						CPA1TMaMatsNo  smallint,
						CPA1TMaNotes  nvarchar(62))
		END
		EXEC sp_xml_removedocument @XMLDocPointer

		SET @lTranID = @MainRecID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
	IF (@@TRANCOUNT > 0)  
		ROLLBACK TRAN

		SET @lTranID = 0

		-- Throw the error message  
		DECLARE @ErrorMessage NVARCHAR(4000);  
		DECLARE @ErrorSeverity INT;  
		DECLARE @ErrorState INT;  
		SELECT @ErrorMessage = ERROR_MESSAGE(), @ErrorSeverity = ERROR_SEVERITY(), @ErrorState = ERROR_STATE();  
		RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);  
	END CATCH
END


GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TInstNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cpa1Tmp.CPA1TInstNotsRec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPA1TMainRecID] [int] NULL,
	[CPA1TIsInstNo] [smallint] NULL,
	[CPA1TIsNotes] [nvarchar](62) NULL,
 CONSTRAINT [PK_CPA1TInstNotsRec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TInstRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cpa1Tmp.CPA1TInstRec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPA1TMainRecID] [int] NULL,
	[CPA1TInstNo] [smallint] NULL,
	[CPA1TIsOrdDate] [smalldatetime] NULL,
	[CPA1TIsIssDate] [smalldatetime] NOT NULL,
	[CPA1TOperOutst] [smallint] NULL,
 CONSTRAINT [PK_CPA1TInstRec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TMainRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cpa1Tmp.CPA1TMainRec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPA1TRecNo] [int] NULL,
	[CPA1TFileNo] [int] NULL,
	[CPA1TDelPoint] [smallint] NULL,
	[CPA1TStyle] [nvarchar](13) NULL,
	[CPA1TVarn] [nvarchar](9) NULL,
	[CPA1TCustNo] [smallint] NULL,
	[CPA1TCustRef] [nvarchar](26) NULL,
	[CPA1TDelDate] [smalldatetime] NULL,
	[CPA1TAgntNo] [smallint] NULL,
	[CPA1TDockNo] [int] NULL,
	[CPA1TFactNo] [smallint] NULL,
	[CPA1TDockDelDate] [smalldatetime] NULL,
	[CPA1TMainFabric] [nvarchar](26) NULL,
	[CPA1TOrderOuts] [smallint] NULL,
	[CPA1TInFileFlag] [smallint] NULL,
 CONSTRAINT [PK_CPA1TMainRec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TMatsNotsRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cpa1Tmp.CPA1TMatsNotsRec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPA1TMainRecID] [int] NULL,
	[CPA1TMaMatsNo] [smallint] NULL,
	[CPA1TMaNotes] [nvarchar](62) NULL,
 CONSTRAINT [PK_CPA1TMatsNotsRec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cpa1Tmp.CPA1TMatsRec]    Script Date: 31/12/2016 20:23:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cpa1Tmp.CPA1TMatsRec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CPA1TMainRecID] [int] NULL,
	[CPA1TMatsNo] [smallint] NULL,
	[CPA1TMaOrdDate] [smalldatetime] NULL,
	[CPA1TMaIssDate] [smalldatetime] NULL,
	[CPA1TMaOrdNo] [int] NULL,
	[CPA1TMatsOutst] [smallint] NULL,
 CONSTRAINT [PK_CPA1TMatsRec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
