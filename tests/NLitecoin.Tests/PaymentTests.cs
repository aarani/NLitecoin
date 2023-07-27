using System;

using NBitcoin.Payment;

namespace NLitecoin.Tests
{
    public class PaymentTests
    {
        [Test]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Assertion", "NUnit2005:Consider using Assert.That(actual, Is.EqualTo(expected)) instead of Assert.AreEqual(expected, actual)", Justification = "<Pending>")]
        public void CanParsePaymentUrl()
        {
            //Support litecoin
            var url = new BitcoinUrlBuilder("litecoin:LeLAhU5S7vbVxL4rsT69eMoMrpgV9SNbns", Litecoin.Instance.Mainnet);
            Assert.AreEqual(url.ToString(), new BitcoinUrlBuilder(url.ToString(), Litecoin.Instance.Mainnet).ToString());
            Assert.AreEqual("litecoin:LeLAhU5S7vbVxL4rsT69eMoMrpgV9SNbns", url.ToString());

            // Old verison of BitcoinUrl was only supporting bitcoin: to not break existing code, we should support this
            url = new BitcoinUrlBuilder("bitcoin:LeLAhU5S7vbVxL4rsT69eMoMrpgV9SNbns", Litecoin.Instance.Mainnet);
            Assert.AreEqual(url.ToString(), new BitcoinUrlBuilder(url.ToString(), Litecoin.Instance.Mainnet).ToString());
            Assert.AreEqual("bitcoin:LeLAhU5S7vbVxL4rsT69eMoMrpgV9SNbns", url.ToString());
        }
    }
}