namespace Datos.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class tiposenmedico : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Medico", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Medico", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Medico", "Apellido", c => c.String());
            AlterColumn("dbo.Medico", "Nombre", c => c.String());
        }
    }
}
