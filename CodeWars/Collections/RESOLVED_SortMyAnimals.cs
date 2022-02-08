using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

//https://www.codewars.com/kata/58ff1c8b13b001a5a50005b4/train/csharp
namespace CodeWars.Collections
{
    public class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
    }

    public class AnimalSorter
    {
        public List<Animal>? Sort(List<Animal> input)
        {
            return input?.OrderBy(i => i.Name).OrderBy(i => i.NumberOfLegs).ToList();
        }
    }

    [TestFixture]
    public class AnimalSorterTests
    {
        [Test]
        public void SortTest()
        {
            var animals = new List<Animal>
      {
        new Animal {Name = "Cat", NumberOfLegs = 4},
        new Animal {Name = "Snake", NumberOfLegs = 0},
        new Animal {Name = "Dog", NumberOfLegs = 4},
        new Animal {Name = "Pig", NumberOfLegs = 4},
        new Animal {Name = "Human", NumberOfLegs = 2},
        new Animal {Name = "Bird", NumberOfLegs = 2}
      };
            var output = new AnimalSorter().Sort(animals);
            Assert.AreEqual(output[0].Name, "Snake");
            Assert.AreEqual(output[3].Name, "Cat");
        }
    }
}
