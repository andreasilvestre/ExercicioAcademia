namespace Entity_Relacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasSistemaGaragem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModeloId = c.Int(nullable: false),
                        Nome = c.String(),
                        Ano = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modelos", t => t.ModeloId, cascadeDelete: true)
                .Index(t => t.ModeloId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculos", "ModeloId", "dbo.Modelos");
            DropIndex("dbo.Veiculos", new[] { "ModeloId" });
            DropTable("dbo.Veiculos");
            DropTable("dbo.Modelos");
        }
    }
}
