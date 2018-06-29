namespace BlueRibbonsReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCampaignUserId : DbMigration
    {
        public override void Up()
        {

           Sql("UPDATE dbo.Campaigns SET ApplicationUser_Id = UserID WHERE ApplicationUser_Id IS NULL");
            DropColumn("dbo.Campaigns", "UserID");
        }
  
        public override void Down()
        {
            AddColumn("dbo.Campaigns", "UserID", c => c.String());
            //Note: SqlScript needed to rollback update above. Spec unavailable so appended to User Story #1667
        }
    }
 