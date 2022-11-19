namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void SholdConvertDecimalToInt()
    {
        decimal valor = 270.98M;

        var cents = valor.ToCents();

        Assert.AreEqual(27098,cents);
    }
}