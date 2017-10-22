using System.Numerics;

namespace RSASignature.Auth.Sign
{
    public struct Signature
    {
        public string Message { get; set; }
        public BigInteger RSASignature { get; set; }

        public Signature(string message, BigInteger signtature)
        {
            Message = message;
            RSASignature = signtature;
        }
    }
}
