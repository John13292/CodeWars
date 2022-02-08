using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace CodeWars.REFACTORING
{
    internal class RESOLVED_RefactorOutASwitchStatementUsingPolymorphism
    {
        private readonly Status _status;

        public RESOLVED_RefactorOutASwitchStatementUsingPolymorphism()
            : this(new DefaultStatus())
        {
        }

        public RESOLVED_RefactorOutASwitchStatementUsingPolymorphism(Status status)
        {
            _status = status;
        }

        public string GetStatusDescription()
        {
            return _status.GetStatusDescription();
        }
    }

    public abstract class Status
    {
        public abstract string GetStatusDescription();
    }

    class DefaultStatus : Status
    {
        public override string GetStatusDescription()
        {
            return "I have never been set";
        }
    }

    class NewStatus : Status
    {
        public override string GetStatusDescription()
        {
            return "I am new!";
        }
    }

    class ActiveStatus : Status
    {
        public override string GetStatusDescription()
        {
            return "I am active";
        }
    }

    class DeactivatedStatus : Status
    {
        public override string GetStatusDescription()
        {
            return "I have been deactivated";
        }
    }

    [TestFixture]
    public class ExampleTestCases
    {
        [Test]
        public void StatusCorrect()
        {
            Assert.AreEqual("I have never been set", new RESOLVED_RefactorOutASwitchStatementUsingPolymorphism().GetStatusDescription());
            Assert.AreEqual("I am new!", new RESOLVED_RefactorOutASwitchStatementUsingPolymorphism(new NewStatus()).GetStatusDescription());
            Assert.AreEqual("I am active", new RESOLVED_RefactorOutASwitchStatementUsingPolymorphism(new ActiveStatus()).GetStatusDescription());
            Assert.AreEqual("I have been deactivated", new RESOLVED_RefactorOutASwitchStatementUsingPolymorphism(new DeactivatedStatus()).GetStatusDescription());
        }

        [Test]
        public void HasStatusField()
        {
            Type type = typeof(RESOLVED_RefactorOutASwitchStatementUsingPolymorphism);
            FieldInfo field = type.GetField("_status", BindingFlags.NonPublic | BindingFlags.Instance);
            Assert.IsNotNull(field);
            Type fieldType = field.FieldType;
            Assert.AreEqual(fieldType, typeof(Status));
        }
    }
}
