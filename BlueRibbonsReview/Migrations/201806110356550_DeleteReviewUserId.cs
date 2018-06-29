namespace BlueRibbonsReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteReviewUserId : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE dbo.Reviews SET ApplicationUser_Id = UserID WHERE ApplicationUser_Id IS NULL");
             DropColumn("dbo.Reviews", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "UserId", c => c.String());
            //Note: SqlScript needed to rollback update above. Spec unavailable so appended to User Story #1667
        }
    }
}
 