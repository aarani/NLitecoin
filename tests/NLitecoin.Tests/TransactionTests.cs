using System;
using NBitcoin;

namespace NLitecoin.Tests
{
    public class TransactionTests
    {
        [Test]
        public void CanParseLTubLitecoin()
        {
            new BitcoinExtKey("Ltpv71G8qDifUiNesyXJM9i5RzRB5HHFWfjseAX7mXY6vim2BHMBHgZJi9poW2J5FveLFg4PnPXf6y2VLtYoTDxJAhbVRRpo3GeKKx1wveysYnw", Litecoin.Instance.Mainnet);
            new BitcoinExtPubKey("Ltub2SSUS19CirucVaJxxH11bYDCEmze824yTDJCzRg5fDNN3oBWussWgRA7Zyiya98dAErcvDsw7rAuuZuZug3Ve6iT5uVkwPAKwQphBiQdjNd", Litecoin.Instance.Mainnet);
        }
    }
}