namespace JavaScriptAjx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _42819 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "AdmitDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "AdmitDate", c => c.DateTime(nullable: false));
        }
    }
}
