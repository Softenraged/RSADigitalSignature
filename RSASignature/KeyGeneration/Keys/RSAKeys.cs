using System.Numerics;


namespace RSASignature.KeyGeneration.Keys
{
    public struct PublicKey
    {
        public BigInteger n { get; set; }
        public BigInteger e { get; set; }
    }

    public struct PrivateKey
    {
        public BigInteger d { get; set; }
        public BigInteger n { get; set; }
    }
}
