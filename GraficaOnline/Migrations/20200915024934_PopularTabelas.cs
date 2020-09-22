using Microsoft.EntityFrameworkCore.Migrations;

namespace GraficaOnline.Migrations
{
    public partial class PopularTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) VALUES ('Personalizado','Produto personalizado com sua arte')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) VALUES ('Não Personalizado','Produto não personalizado')");

            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,Descricao,ImagemThumbnailUrl,ImagemUrl,Marca,Quantidade,IsProdutoPreferida,ValorCompra,ValorVenda) VALUES (1,'Cartão temático','Cartão temático para festas e eventos','https://www.google.com/aclk?sa=l&ai=DChcSEwjokv6VzMnrAhWGEZEKHesBCm0YABAGGgJjZQ&sig=AOD64_322D9Y7K5nYtuS3S4kOo6R9KghIw&adurl&ctype=5&ved=2ahUKEwjsy_OVzMnrAhV-MLkGHU9WAqQQvhd6BAgBEF4','https://www.google.com/aclk?sa=l&ai=DChcSEwjokv6VzMnrAhWGEZEKHesBCm0YABAGGgJjZQ&sig=AOD64_322D9Y7K5nYtuS3S4kOo6R9KghIw&adurl&ctype=5&ved=2ahUKEwjsy_OVzMnrAhV-MLkGHU9WAqQQvhd6BAgBEF4','GraficArt',10,0,25.00,80.00)");
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,Descricao,ImagemThumbnailUrl,ImagemUrl,Marca,Quantidade,IsProdutoPreferida,ValorCompra,ValorVenda) VALUES (1,'Banner 1 metro','Banner 1m x 80cm para apresentação de trabalhos e eventos','https://www.google.com/aclk?sa=l&ai=DChcSEwj1sOagy8nrAhWCB5EKHc2hBMwYABAGGgJjZQ&sig=AOD64_22FCvoELIeQVkkRpZgLupQHz2guA&adurl&ctype=5&ved=2ahUKEwib1Nugy8nrAhUKJbkGHe3qCfsQvhd6BAgBEC8','https://www.google.com/aclk?sa=l&ai=DChcSEwj1sOagy8nrAhWCB5EKHc2hBMwYABAGGgJjZQ&sig=AOD64_22FCvoELIeQVkkRpZgLupQHz2guA&adurl&ctype=5&ved=2ahUKEwib1Nugy8nrAhUKJbkGHe3qCfsQvhd6BAgBEC8','GraficArt',2,1,30.00,90.00)");
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,Descricao,ImagemThumbnailUrl,ImagemUrl,Marca,Quantidade,IsProdutoPreferida,ValorCompra,ValorVenda) VALUES (1,'Camiseta personalizada','Camiseta personalizada com a sua arte','https://http2.mlstatic.com/D_NQ_NP_922195-MLB40750350656_022020-O.webp','https://http2.mlstatic.com/D_NQ_NP_922195-MLB40750350656_022020-O.webp','GraficArt 2.0',3,0,10.00,60.90)");
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,Descricao,ImagemThumbnailUrl,ImagemUrl,Marca,Quantidade,IsProdutoPreferida,ValorCompra,ValorVenda) VALUES (1,'Caneca personalizada','Caneca personalizada com sua arte','https://img.elo7.com.br/product/main/1FCA924/caneca-personalizada-de-porcelana-brinde-surpresa-dia-das-maes.jpg','https://img.elo7.com.br/product/main/1FCA924/caneca-personalizada-de-porcelana-brinde-surpresa-dia-das-maes.jpg','GraficArt',5,0,12.80,35.50)");
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,Descricao,ImagemThumbnailUrl,ImagemUrl,Marca,Quantidade,IsProdutoPreferida,ValorCompra,ValorVenda) VALUES (2,'Toalha de banho','Toalha de banho personalizada com a sua arte','https://mdpersonalizacoes.com.br/wp-content/uploads/2017/09/toalha-de-banho-com-foto-600x600.jpg','https://mdpersonalizacoes.com.br/wp-content/uploads/2017/09/toalha-de-banho-com-foto-600x600.jpg','GraficArt',2,1,30.00,40.00)");
            migrationBuilder.Sql("INSERT INTO Produtos(CategoriaId,Nome,Descricao,ImagemThumbnailUrl,ImagemUrl,Marca,Quantidade,IsProdutoPreferida,ValorCompra,ValorVenda) VALUES (2,'Quadro de fotos','Quadro com espaço para 6 fotos, 3 em pé e 3 deitada','https://http2.mlstatic.com/D_NQ_NP_201811-MLB20639854862_032016-O.webp','https://http2.mlstatic.com/D_NQ_NP_201811-MLB20639854862_032016-O.webp','GraficArt 2.0',3,0,10.00,32.70)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
