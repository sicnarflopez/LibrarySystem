USE [LibrarySystemDb]
GO
/****** Object:  StoredProcedure [dbo].[GetBooks]    Script Date: 23/02/2023 9:19:44 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetBooks]
                        AS
                        BEGIN
	                        -- SET NOCOUNT ON added to prevent extra result sets from
	                        -- interfering with SELECT statements.
	                        SET NOCOUNT ON;

                            -- Insert statements for procedure here
	                        SELECT *
	                        FROM Books
	
                        END
