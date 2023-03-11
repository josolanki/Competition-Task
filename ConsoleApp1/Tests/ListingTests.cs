using Competition_task.Pages;
using Competition_task.Utilities;
using NUnit.Framework;


namespace Competition_task.Tests
{
    [TestFixture]
    public class ListingTests : CommonDriver
    {
        ProfilePg ProfilePgObj;
        ListingPg ListingPgObj;
        SkillPg SkillPgObj;

       [SetUp]

        public void Setup()
        {
           ProfilePgObj = new ProfilePg();
           ListingPgObj = new ListingPg();
           SkillPg SkillPgObj = new SkillPg();

        }
        [Test,Order(1)]
        public void ShareSkillTest()
        {
            //Skill page
            ProfilePg ProfilePgObj = new ProfilePg();
            ProfilePgObj.ShareSkills();
            SkillPgObj.ShareSkill();
        }
        [Test, Order(2)]
        public void UpdateSkillTest()
        {
            //Manage listing page
           
            ProfilePgObj.ManageListings();
            ListingPgObj.UpdateSkill();

        }
        [Test, Order(3)]
        public void DeleteSkillTest()
        {
          
            ProfilePgObj.ManageListings();
            ListingPgObj.DeleteSkill();

        }
        [TearDown]
        public void CloseTestrun()
        {
            driver.Quit();
        }
    }
}
