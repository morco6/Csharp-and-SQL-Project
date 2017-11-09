using Microsoft.VisualStudio.TestTools.UnitTesting;
using project___13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project___13.Tests
{
    [TestClass()]
    public class DBCTests
    {//mor//
        public int id = 123456813;
        public int permission = 4;
        public int salary = 30000;
        public string mail = "testing@gmail.com";
        public string username = "Tester";
        public String TableName1 = "Users";
        public String TableName2 = "Salary";
        DBC Con = new DBC();
        [TestMethod()]
        public void search_by_idTest()
        {
            Assert.AreEqual(true, Con.search_by_id(id, TableName1));
        }

        [TestMethod()]
        public void get_salaryTest()
        {
            Assert.AreEqual(salary, Con.get_salary(id, TableName2));
        }

        [TestMethod()]
        public void search_by_mailTest()
        {
            Assert.AreEqual(true, Con.search_by_mail(mail, TableName1));
        }

        [TestMethod()]
        public void get_username_from_DBTest()
        {
            Assert.AreEqual(username, Con.get_username_from_DB(mail));
        }

        [TestMethod()]
        public void setNewPremissionTest()
        {
            Assert.AreEqual(true, Con.setNewPremission(permission, username));
        }

        [TestMethod()]
        public void get_row_by_usernameTest()
        {
            Assert.AreNotEqual(null, Con.get_row_by_username(username));
        }

        [TestMethod()]
        public void get_Users_DbTest()
        {
            Assert.AreNotEqual(null, Con.get_Users_Db());
        }

        [TestMethod()]
        public void get_courses_DB_by_sem_and_yearTest()
        {
            Assert.AreNotEqual(null, Con.get_courses_DB_by_sem_and_year('A', 'A'));
        }

        [TestMethod()]
        public void get_courses_DBrTest()
        {
            Assert.AreNotEqual(null, Con.get_courses_DBr());
        }

        [TestMethod()]
        public void RemoveFromDBByUserNameTest()
        {
            Assert.AreEqual(true, Con.RemoveFromDBByUserName(username));
        }
    }
}