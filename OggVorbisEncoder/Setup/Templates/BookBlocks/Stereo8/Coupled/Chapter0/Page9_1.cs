namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Coupled.Chapter0
{
    public class Page9_1 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
         1, 4, 4, 5, 5,10, 8,11,11,11,11,11,11,11,11, 6,
         6, 6, 7, 6,11,10,11,11,11,11,11,11,11,11, 7, 5,
         6, 6, 6, 8, 7,11,11,11,11,11,11,11,11,11, 7, 8,
         8, 8, 9, 9,11,11,11,11,11,11,11,11,11, 9, 8, 7,
         8, 9,11,11,11,11,11,11,11,11,11,11,11,10,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,10,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -520986624;
        public int QuantDelta { get; } = 1620377600;
        public int Quant { get; } = 4;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        7,
        6,
        8,
        5,
        9,
        4,
        10,
        3,
        11,
        2,
        12,
        1,
        13,
        0,
        14,
};
    }
}