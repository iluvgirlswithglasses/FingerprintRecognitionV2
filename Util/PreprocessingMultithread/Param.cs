namespace FingerprintRecognitionV2.Util.PreprocessingMultithread
{
	static public class Param
	{
		// Image Attributes
		static public readonly int 
			Height = 480, Width = 320, Size = Height * Width, 
			BlockSize = 16;

		// Gabor Filter Attributes
		static public readonly double
			AngleInc = Math.PI * 4 / 180;
	}
}