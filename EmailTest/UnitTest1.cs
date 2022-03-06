using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using UserRegistrationProblem;

namespace UserRegistraionTest
{
    [TestClass]
        public class EmailTest
        {
            const string emailRegex = "^[A-Za-z0-9]+([._#%+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
            UserRegistration userRegistration=new UserRegistration();
            
            // Tests the valid emails
            [TestMethod]
            [DataRow(@"abc@yahoo.com")]
            [DataRow(@"abc-100@yahoo.com")]
            [DataRow(@"abc.100@yahoo.com")]
            [DataRow(@"abc111@abc.com")]
            [DataRow(@"abc-100@abc.net")]
            [DataRow(@"abc.100@abc.com.au")]
            [DataRow(@"abc@1.com")]
            [DataRow(@"abc@gmail.com.com")]
            [DataRow(@"abc+100@gmail.com")]
            public void TestValidEmails(string email)
            {
                var result = userRegistration.EmailID(email);
                Assert.IsTrue(result);
            }

            
            // Tests the invalid emails
           
            [TestMethod]
            [DataRow(@"abc")]
            [DataRow(@"abc@.com.my")]
            [DataRow(@"abc123@gmail.a")]
            [DataRow(@"abc123@.com")]
            [DataRow(@"abc123@.com.com ")]
            [DataRow(@".abc@abc.com")]
            [DataRow(@"abc()*@gmail.com")]
            [DataRow(@"abc@%*.com")]
            [DataRow(@"abc..2002@gmail.com")]
            [DataRow(@"abc.@gmail.com")]
            [DataRow(@"abc@abc@gmail.com")]
            [DataRow(@"abc@gmail.com.1a")]
            [DataRow(@"abc@gmail.com.aa.au")]
            public void TestInvalidEmails(string email)
            {
            object UserRegistration = null;
            var result = userRegistration.EmailID(email);
            Assert.IsFalse(result);
            }
        }
}