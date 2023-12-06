using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookstore.ProductApi.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert Into Products(Name,Price,Description,Stock,ImageURL,CategoryId) " + "Values('A menina que roubava livros',40.00,'Livro por Markus Zusak',10,'livro1.jpg',1)");

            mb.Sql("Insert Into Products(Name,Price,Description,Stock,ImageURL,CategoryId) " + "Values('A culpa é das estrelas',30.99,'Livro por John Green',20,'livro2.jpg',2)");

            mb.Sql("Insert Into Products(Name,Price,Description,Stock,ImageURL,CategoryId) " + "Values('O Ladrão de Raios',35.99,'Livro por Rick Riordan',20,'livro3.jpg',1)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Products");
        }
    }
}
