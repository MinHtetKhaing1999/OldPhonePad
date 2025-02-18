namespace OldPhonePadTest;

[TestClass]
public class Validate
{
    [TestMethod]
    public void SendMessageTest1()
    {
        Assert.AreEqual("E", PhonePadService.OldPhonePad("33#"));
    }

    [TestMethod]
    public void SendMessageTest2()
    {
        Assert.AreEqual("B", PhonePadService.OldPhonePad("227*#"));
    }

    [TestMethod]
    public void SendMessageTest3()
    {
        Assert.AreEqual("HELLO", PhonePadService.OldPhonePad("4433555 555666#"));
    }

    [TestMethod]
    public void SendMessageTest4()
    {
        Assert.AreEqual("TURING", PhonePadService.OldPhonePad("8 88777444666*664#"));
    }
}
