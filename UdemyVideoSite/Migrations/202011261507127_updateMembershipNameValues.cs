namespace UdemyVideoSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipNameValues : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes " +
                "SET Id='1',SignUpFee='0',DurationInMonths='0',DiscountRate='0',Name='Pay as You Go'" +
                "WHERE Id='1'");

            Sql("UPDATE MembershipTypes " +
                "SET Id='2',SignUpFee='30',DurationInMonths='1',DiscountRate='10',Name='Monthly'" +
                "WHERE Id='2'");

            Sql("UPDATE MembershipTypes " +
                "SET Id='3',SignUpFee='90',DurationInMonths='3',DiscountRate='15',Name='Quarterly'" +
                "WHERE Id='3'");

            Sql("UPDATE MembershipTypes " +
                "SET Id='4',SignUpFee='300',DurationInMonths='12',DiscountRate='20',Name='Yearly'" +
                "WHERE Id='4'");
        }
        
        public override void Down()
        {
        }
    }
}
