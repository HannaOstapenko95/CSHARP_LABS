using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mobile;
using Mobile.MobilePhone;

namespace MobileTest
{
    [TestClass]
    public class ComparableTest
    {
        [TestMethod]
        public void Verify_Sorting_Of_List_after_Adding_Elements()
        {
            //Arrange
            var compare = new Call();
            List<Call> actualListCalls = new List<Call>();
            List<Call> expectedCalls = new List<Call>();
            SimCorpMobile mobilePhone = new SimCorpMobile();
            List<SimCorpMobile> mobilesList = new List<SimCorpMobile>();
            //Act
            actualListCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2010, 1, 1, 4, 0, 15), Direction.Incoming));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2016, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2008, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Sort();
            foreach (var item in actualListCalls)
            {
                Console.WriteLine(item.CallTime);
            }
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2008, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2010, 1, 1, 4, 0, 15), Direction.Incoming));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2016, 1, 1, 4, 0, 15), Direction.Outgoing));
            //Assert
            CollectionAssert.AreEqual(expectedCalls, actualListCalls, compare);
        }
        [TestMethod]
        public void Verify_Sorting_Of_List_after_Removing_Elements()
        {
            //Arrange
            var compare = new Call();
            List<Call> actualListCalls = new List<Call>();
            List<Call> expectedCalls = new List<Call>();
            SimCorpMobile mobilePhone = new SimCorpMobile();
            List<SimCorpMobile> mobilesList = new List<SimCorpMobile>();
            actualListCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2010, 1, 1, 4, 0, 15), Direction.Incoming));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2016, 1, 1, 4, 0, 15), Direction.Outgoing));
            actualListCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2008, 1, 1, 4, 0, 15), Direction.Outgoing));
            //Act
            actualListCalls.RemoveAt(0);
            actualListCalls.RemoveAt(3);
            actualListCalls.Sort();
            foreach (var item in actualListCalls)
            {
                Console.WriteLine(item.CallTime);
            }
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2016, 1, 1, 4, 0, 15), Direction.Outgoing));
            //Assert
            CollectionAssert.AreEqual(expectedCalls, actualListCalls, compare);
        }
        [TestMethod]
        public void Compare_Calls_By_User_And_Direction()
        {
            //Arrange
            var compare = new Call();
            List<Call> listCalls = new List<Call>();
            List<Call> expectedCalls = new List<Call>();
            List<bool> expectedResult = new List<bool>();
            List<bool> actualResult = new List<bool>();
            SimCorpMobile mobilePhone = new SimCorpMobile();
            List<SimCorpMobile> mobilesList = new List<SimCorpMobile>();
            listCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2010, 1, 1, 4, 0, 15), Direction.Incoming));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2016, 1, 1, 4, 0, 15), Direction.Outgoing));
            listCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2008, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Hanna, mobilesList), new DateTime(2010, 1, 1, 4, 0, 15), Direction.Incoming));
            expectedCalls.Add(new Call(new Contact(Users.Olga, mobilesList), new DateTime(2015, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2009, 1, 1, 4, 0, 15), Direction.Incoming));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2022, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedCalls.Add(new Call(new Contact(Users.Dmytro, mobilesList), new DateTime(2028, 1, 1, 4, 0, 15), Direction.Outgoing));
            expectedResult.Add(true);
            expectedResult.Add(false);
            expectedResult.Add(false);
            expectedResult.Add(true);
            expectedResult.Add(true);
            //Act
            for (int i = 0; i < listCalls.Count; i++)
            {
                actualResult.Add(listCalls[i].Equals(expectedCalls[i]));
                Console.WriteLine("Result: "  + actualResult[i].ToString() + 
                    "\n\tExpected User: " + expectedCalls[i].Contact.User.ToString() +
                    "\n\tActual User: " + listCalls[i].Contact.User.ToString() +
                    "\n\tExpected Direction: " + expectedCalls[i].CallDirection.ToString() +
                    "\n\tActual Direction: " + listCalls[i].CallDirection.ToString());
            }
            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
