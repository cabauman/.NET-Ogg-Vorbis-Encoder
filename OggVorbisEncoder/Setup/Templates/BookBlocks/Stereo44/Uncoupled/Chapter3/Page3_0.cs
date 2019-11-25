namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter3
{
    public class Page3_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 4;

        public byte[] LengthList { get; } = {
         2, 4, 4, 7, 7, 5, 7, 7, 9, 9, 5, 7, 7, 9, 9, 8,
         9, 9,12,12, 8, 9, 9,11,12, 5, 7, 7,10,10, 7, 9,
         9,11,11, 7, 9, 9,10,11,10,11,11,13,13, 9,10,11,
        13,13, 5, 7, 7,10,10, 7, 9, 9,11,10, 7, 9, 9,11,
        11, 9,11,10,13,13,10,11,11,14,13, 8,10,10,14,13,
        10,11,11,15,14, 9,11,11,14,14,13,14,13,16,16,12,
        13,13,15,15, 8,10,10,13,14, 9,11,11,14,14,10,11,
        11,14,15,12,13,13,15,15,13,14,14,15,16, 5, 7, 7,
        10,10, 7, 9, 9,11,11, 7, 9, 9,11,12,10,11,11,14,
        14,10,11,11,14,14, 7, 9, 9,12,12, 9,11,11,13,13,
         9,11,11,13,13,12,12,13,15,15,11,12,13,15,16, 7,
         9, 9,11,11, 8,11,10,13,12, 9,11,11,13,13,11,13,
        12,15,13,11,13,13,15,16, 9,12,11,15,14,11,12,13,
        16,15,11,13,13,15,16,14,14,15,17,16,13,15,16, 0,
        17, 9,11,11,15,15,10,13,12,15,15,11,13,13,15,16,
        13,15,13,16,15,14,16,15, 0,19, 5, 7, 7,10,10, 7,
         9, 9,11,11, 7, 9, 9,11,11,10,12,11,14,14,10,11,
        12,14,14, 7, 9, 9,12,12, 9,11,11,14,13, 9,10,11,
        12,13,11,13,13,16,16,11,12,13,13,16, 7, 9, 9,12,
        12, 9,11,11,13,13, 9,11,11,13,13,11,13,13,15,15,
        12,13,12,15,14, 9,11,11,15,14,11,13,12,16,16,10,
        12,12,15,15,13,15,15,17,19,13,14,15,16,17,10,12,
        12,15,15,11,13,13,16,16,11,13,13,15,16,13,15,15,
         0, 0,14,15,15,16,16, 8,10,10,14,14,10,12,12,15,
        15,10,12,11,15,16,14,15,15,19,20,13,14,14,18,16,
         9,11,11,15,15,11,13,13,17,16,11,13,13,16,16,15,
        17,17,20,20,14,15,16,17,20, 9,11,11,15,15,10,13,
        12,16,15,11,13,13,15,17,14,16,15,18, 0,14,16,15,
        18,20,12,14,14, 0, 0,14,14,16, 0, 0,13,16,15, 0,
         0,17,17,18, 0, 0,16,17,19,19, 0,12,14,14,18, 0,
        12,16,14, 0,17,13,15,15,18, 0,16,18,17, 0,17,16,
        18,17, 0, 0, 7,10,10,14,14,10,12,11,15,15,10,12,
        12,16,15,13,15,15,18, 0,14,15,15,17, 0, 9,11,11,
        15,15,11,13,13,16,16,11,12,13,16,16,14,15,16,17,
        17,14,16,16,16,18, 9,11,12,16,16,11,13,13,17,17,
        11,14,13,20,17,15,16,16,19, 0,15,16,17, 0,19,11,
        13,14,17,16,14,15,15,20,18,13,14,15,17,19,16,18,
        18, 0,20,16,16,19,17, 0,12,15,14,17, 0,14,15,15,
        18,19,13,16,15,19,20,15,18,18, 0,20,17, 0,16, 0,
         0,
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