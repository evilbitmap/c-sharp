        static void RNGcrypto()
        {
            RNGCryptoServiceProvider rngTEST = new RNGCryptoServiceProvider();
            byte[] data = new byte[4];
            rngTEST.GetBytes(data);
            int value = BitConverter.ToInt32(data, 0);
            Console.WriteLine(value);
        }
        
        static int RandomInteger(int min, int max)
        {
            //http://csharphelper.com/blog/2014/08/use-a-cryptographic-random-number-generator-in-c/
            //unit scale = unit.maxvalue = 4,294,967,295
            //pokud scale = unit.maxvalue tak...
            //rng.getbytes(4)
            //scale = Bitconverter(data, 0)

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            uint scale = uint.MaxValue;
            while (scale == uint.MaxValue)
            {
                byte[] data = new byte[4]; 
                rng.GetBytes(data);
                scale = BitConverter.ToUInt32(data, 0);
            }
            return (int)(min + (max - min) *
                (scale / (double)uint.MaxValue));
        }
