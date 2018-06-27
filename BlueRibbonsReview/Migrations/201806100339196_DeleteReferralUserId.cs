namespace BlueRibbonsReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteReferralUserId : DbMigration
    {
        public override void Up()
        {

            Sql("UPDATE dbo.Referrals SET ApplicationUser_Id = UserID WHERE ApplicationUser_Id IS NULL");
            DropColumn("dbo.Referrals", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Referrals", "UserID", c => c.String());
            //Note: SqlScript needed to rollback update above. Spec unavailable so appended to User Story #1667
        }
    }
