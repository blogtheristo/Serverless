using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace XunitReview

{
    public class FirstUnitTest
    {
        //* [Fact] means a unit test
        [Fact]
        public void Assert_Account_Addition()
        {
            var account = new Account(8);
            account.AddBalance(1);

            Assert.Equal(9, account.Balance);
        }

        [Fact]
        public void Assert_Person_Equality()
        {
            var person1 = new Person()
            {
                FirstName = "Päärni",
                LastName = "Risto"
            };
            var person2 = new Person()
            {
                FirstName = "Päärni",
                LastName = "Risto"
            };
            
            
            ;
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Assert.NotSame(person2, person1);
            Console.ReadLine();

        }
    }

    public class Person
    { public string FirstName;
      public string LastName;

        public override bool Equals(object obj)
        {
            return true;
        }
    }

    public class Account
    {
        public Account(decimal initialBalance)
        {
            this.Balance = initialBalance;
        }
        public decimal Balance { get; set; }

        public void AddBalance(decimal value)
        {
            this.Balance += value;
        }
    }
    
    
}
