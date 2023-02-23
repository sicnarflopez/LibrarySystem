using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarySystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateGetBooksStoredProc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetBooks]
                        AS
                        BEGIN
	                        -- SET NOCOUNT ON added to prevent extra result sets from
	                        -- interfering with SELECT statements.
	                        SET NOCOUNT ON;

                            -- Insert statements for procedure here
	                        SELECT *
	                        FROM Books
	
                        END";

            migrationBuilder.Sql(sp);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROC GetBooks";

            migrationBuilder.Sql(sp);
        }
    }
}
