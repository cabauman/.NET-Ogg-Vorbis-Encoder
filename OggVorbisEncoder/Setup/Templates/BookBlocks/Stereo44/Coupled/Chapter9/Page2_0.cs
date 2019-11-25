namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter9
{
    public class Page2_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 4;

        public byte[] LengthList { get; } = {
         3, 5, 5, 8, 8, 0, 5, 5, 8, 8, 0, 5, 5, 8, 8, 0,
         7, 7, 9, 9, 0, 0, 0, 9, 9, 6, 7, 7, 9, 8, 0, 8,
         8, 9, 9, 0, 8, 7, 9, 9, 0, 9,10,10,10, 0, 0, 0,
        11,10, 6, 7, 7, 8, 9, 0, 8, 8, 9, 9, 0, 7, 8, 9,
         9, 0,10, 9,11,10, 0, 0, 0,10,10, 8, 9, 8,10,10,
         0,10,10,12,11, 0,10,10,11,11, 0,12,13,13,13, 0,
         0, 0,13,12, 8, 8, 9,10,10, 0,10,10,11,12, 0,10,
        10,11,11, 0,13,12,13,13, 0, 0, 0,13,13, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 6, 8, 7,10,10, 0, 7, 7,10, 9,
         0, 7, 7,10,10, 0, 9, 9,10,10, 0, 0, 0,10,10, 6,
         7, 8,10,10, 0, 7, 7, 9,10, 0, 7, 7,10,10, 0, 9,
         9,10,10, 0, 0, 0,10,10, 8, 9, 9,11,11, 0,10,10,
        11,11, 0,10,10,11,11, 0,12,12,12,12, 0, 0, 0,12,
        12, 8, 9,10,11,11, 0, 9,10,11,11, 0,10,10,11,11,
         0,12,12,12,12, 0, 0, 0,12,12, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 5, 8, 7,10,10, 0, 7, 7,10,10, 0, 7, 7,
        10, 9, 0, 9, 9,10,10, 0, 0, 0,10,10, 6, 7, 8,10,
        10, 0, 7, 7,10,10, 0, 7, 7, 9,10, 0, 9, 9,10,10,
         0, 0, 0,10,10, 8,10, 9,12,11, 0,10,10,12,11, 0,
        10, 9,11,11, 0,11,12,12,12, 0, 0, 0,12,12, 8, 9,
        10,11,12, 0,10,10,11,11, 0, 9,10,11,11, 0,12,11,
        12,12, 0, 0, 0,12,12, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         7,10, 9,12,12, 0, 9, 9,12,11, 0, 9, 9,11,11, 0,
        10,10,12,11, 0, 0, 0,11,12, 7, 9,10,12,12, 0, 9,
         9,11,12, 0, 9, 9,11,11, 0,10,10,11,12, 0, 0, 0,
        11,11, 9,11,10,13,12, 0,10,10,12,12, 0,10,10,12,
        12, 0,11,11,12,12, 0, 0, 0,13,12, 9,10,11,12,13,
         0,10,10,12,12, 0,10,10,12,12, 0,11,12,12,12, 0,
         0, 0,12,13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9,
        11,10,13,13, 0,10,10,12,12, 0,10,10,12,12, 0,11,
        12,12,12, 0, 0, 0,12,12, 9,10,11,13,13, 0,10,10,
        12,12, 0,10,10,12,12, 0,12,11,13,12, 0, 0, 0,12,
        12,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -533725184;
        public int QuantDelta { get; } = 1611661312;
        public int Quant { get; } = 3;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        2,
        1,
        3,
        0,
        4,
};
    }
}