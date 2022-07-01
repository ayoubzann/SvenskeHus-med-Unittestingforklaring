using SvenskeHus;

namespace TestSvenskeHus
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSquareMeterCost() // All tests have to return void-type.
        {
            // F�RST: H�yreklikk Dependencies i Solution Explorer, og marker programmet du skal teste/klassen.

            // Expected - Du m� alltid lage objektet f�rst fordi du ikke er i klassen.  Deretter fyller man ut hva ditt forventede resultat er, fordi du tester ut
            // TestSquareMeterCost() metoden. Deretter expecter man hva resultatet er ved <var expected = value>.
            Hus Hjem1 = new Hus(1995, 200, "Yellow");       
            int expected = 312;

            // Actual - Her tester man ut metoden og f�r det faktiske svaret. 
            int actual = Hjem1.SquareMeterCost();

            // Assert - Her tester man ut hva som faktisk skjer - Man bruker Assert. for � sjekke ut om de er equal.
            Assert.AreEqual(expected, actual);

            // Deretter h�yreklikker du p� UnitTest1.cs i SolutionExplorer.
        }
    }
}