namespace KursMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Pay as You Go' WHERE Id ='1'; ");

           
        }
        
        public override void Down()
        {
        }
    }
}
