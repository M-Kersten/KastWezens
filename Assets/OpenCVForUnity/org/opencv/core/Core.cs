
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.CoreModule
{
    // C++: class Core


    public partial class Core
    {
        // these constants are wrapped inside functions to prevent inlining
        private static string getVersion() { return "4.10.0-dev"; }
        private static string getNativeLibraryName() { return "opencvforunity"; }
        private static int getVersionMajorJ() { return 4; }
        private static int getVersionMinorJ() { return 10; }
        private static int getVersionRevisionJ() { return 0; }
        private static string getVersionStatusJ() { return "-dev"; }

        public static readonly string VERSION = getVersion();
        public static readonly string NATIVE_LIBRARY_NAME = getNativeLibraryName();
        public static readonly int VERSION_MAJOR = getVersionMajorJ();
        public static readonly int VERSION_MINOR = getVersionMinorJ();
        public static readonly int VERSION_REVISION = getVersionRevisionJ();
        public static readonly string VERSION_STATUS = getVersionStatusJ();

        private const int CV_8U = 0;
        private const int CV_8S = 1;
        private const int CV_16U = 2;
        private const int CV_16S = 3;
        private const int CV_32S = 4;
        private const int CV_32F = 5;
        private const int CV_64F = 6;
        private const int CV_USRTYPE1 = 7;
        // C++: enum <unnamed>
        public const int SVD_MODIFY_A = 1;
        public const int SVD_NO_UV = 2;
        public const int SVD_FULL_UV = 4;
        public const int FILLED = -1;
        public const int REDUCE_SUM = 0;
        public const int REDUCE_AVG = 1;
        public const int REDUCE_MAX = 2;
        public const int REDUCE_MIN = 3;
        public const int RNG_UNIFORM = 0;
        public const int RNG_NORMAL = 1;
        // C++: enum cv.BorderTypes
        public const int BORDER_CONSTANT = 0;
        public const int BORDER_REPLICATE = 1;
        public const int BORDER_REFLECT = 2;
        public const int BORDER_WRAP = 3;
        public const int BORDER_REFLECT_101 = 4;
        public const int BORDER_TRANSPARENT = 5;
        public const int BORDER_REFLECT101 = BORDER_REFLECT_101;
        public const int BORDER_DEFAULT = BORDER_REFLECT_101;
        public const int BORDER_ISOLATED = 16;
        // C++: enum cv.CmpTypes
        public const int CMP_EQ = 0;
        public const int CMP_GT = 1;
        public const int CMP_GE = 2;
        public const int CMP_LT = 3;
        public const int CMP_LE = 4;
        public const int CMP_NE = 5;
        // C++: enum cv.CovarFlags
        public const int COVAR_SCRAMBLED = 0;
        public const int COVAR_NORMAL = 1;
        public const int COVAR_USE_AVG = 2;
        public const int COVAR_SCALE = 4;
        public const int COVAR_ROWS = 8;
        public const int COVAR_COLS = 16;
        // C++: enum cv.DecompTypes
        public const int DECOMP_LU = 0;
        public const int DECOMP_SVD = 1;
        public const int DECOMP_EIG = 2;
        public const int DECOMP_CHOLESKY = 3;
        public const int DECOMP_QR = 4;
        public const int DECOMP_NORMAL = 16;
        // C++: enum cv.DftFlags
        public const int DFT_INVERSE = 1;
        public const int DFT_SCALE = 2;
        public const int DFT_ROWS = 4;
        public const int DFT_COMPLEX_OUTPUT = 16;
        public const int DFT_REAL_OUTPUT = 32;
        public const int DFT_COMPLEX_INPUT = 64;
        public const int DCT_INVERSE = DFT_INVERSE;
        public const int DCT_ROWS = DFT_ROWS;
        // C++: enum cv.Error.Code
        public const int StsOk = 0;
        public const int StsBackTrace = -1;
        public const int StsError = -2;
        public const int StsInternal = -3;
        public const int StsNoMem = -4;
        public const int StsBadArg = -5;
        public const int StsBadFunc = -6;
        public const int StsNoConv = -7;
        public const int StsAutoTrace = -8;
        public const int HeaderIsNull = -9;
        public const int BadImageSize = -10;
        public const int BadOffset = -11;
        public const int BadDataPtr = -12;
        public const int BadStep = -13;
        public const int BadModelOrChSeq = -14;
        public const int BadNumChannels = -15;
        public const int BadNumChannel1U = -16;
        public const int BadDepth = -17;
        public const int BadAlphaChannel = -18;
        public const int BadOrder = -19;
        public const int BadOrigin = -20;
        public const int BadAlign = -21;
        public const int BadCallBack = -22;
        public const int BadTileSize = -23;
        public const int BadCOI = -24;
        public const int BadROISize = -25;
        public const int MaskIsTiled = -26;
        public const int StsNullPtr = -27;
        public const int StsVecLengthErr = -28;
        public const int StsFilterStructContentErr = -29;
        public const int StsKernelStructContentErr = -30;
        public const int StsFilterOffsetErr = -31;
        public const int StsBadSize = -201;
        public const int StsDivByZero = -202;
        public const int StsInplaceNotSupported = -203;
        public const int StsObjectNotFound = -204;
        public const int StsUnmatchedFormats = -205;
        public const int StsBadFlag = -206;
        public const int StsBadPoint = -207;
        public const int StsBadMask = -208;
        public const int StsUnmatchedSizes = -209;
        public const int StsUnsupportedFormat = -210;
        public const int StsOutOfRange = -211;
        public const int StsParseError = -212;
        public const int StsNotImplemented = -213;
        public const int StsBadMemBlock = -214;
        public const int StsAssert = -215;
        public const int GpuNotSupported = -216;
        public const int GpuApiCallError = -217;
        public const int OpenGlNotSupported = -218;
        public const int OpenGlApiCallError = -219;
        public const int OpenCLApiCallError = -220;
        public const int OpenCLDoubleNotSupported = -221;
        public const int OpenCLInitError = -222;
        public const int OpenCLNoAMDBlasFft = -223;
        // C++: enum cv.Formatter.FormatType
        public const int Formatter_FMT_DEFAULT = 0;
        public const int Formatter_FMT_MATLAB = 1;
        public const int Formatter_FMT_CSV = 2;
        public const int Formatter_FMT_PYTHON = 3;
        public const int Formatter_FMT_NUMPY = 4;
        public const int Formatter_FMT_C = 5;
        // C++: enum cv.GemmFlags
        public const int GEMM_1_T = 1;
        public const int GEMM_2_T = 2;
        public const int GEMM_3_T = 4;
        // C++: enum cv.KmeansFlags
        public const int KMEANS_RANDOM_CENTERS = 0;
        public const int KMEANS_PP_CENTERS = 2;
        public const int KMEANS_USE_INITIAL_LABELS = 1;
        // C++: enum cv.NormTypes
        public const int NORM_INF = 1;
        public const int NORM_L1 = 2;
        public const int NORM_L2 = 4;
        public const int NORM_L2SQR = 5;
        public const int NORM_HAMMING = 6;
        public const int NORM_HAMMING2 = 7;
        public const int NORM_TYPE_MASK = 7;
        public const int NORM_RELATIVE = 8;
        public const int NORM_MINMAX = 32;
        // C++: enum cv.PCA.Flags
        public const int PCA_DATA_AS_ROW = 0;
        public const int PCA_DATA_AS_COL = 1;
        public const int PCA_USE_AVG = 2;
        // C++: enum cv.Param
        public const int Param_INT = 0;
        public const int Param_BOOLEAN = 1;
        public const int Param_REAL = 2;
        public const int Param_STRING = 3;
        public const int Param_MAT = 4;
        public const int Param_MAT_VECTOR = 5;
        public const int Param_ALGORITHM = 6;
        public const int Param_FLOAT = 7;
        public const int Param_UNSIGNED_INT = 8;
        public const int Param_UINT64 = 9;
        public const int Param_UCHAR = 11;
        public const int Param_SCALAR = 12;
        // C++: enum cv.ReduceTypes
        public const int REDUCE_SUM2 = 4;
        // C++: enum cv.RotateFlags
        public const int ROTATE_90_CLOCKWISE = 0;
        public const int ROTATE_180 = 1;
        public const int ROTATE_90_COUNTERCLOCKWISE = 2;
        // C++: enum cv.SortFlags
        public const int SORT_EVERY_ROW = 0;
        public const int SORT_EVERY_COLUMN = 1;
        public const int SORT_ASCENDING = 0;
        public const int SORT_DESCENDING = 16;
        //
        // C++:  float cv::cubeRoot(float val)
        //

        /// <summary>
        ///  Computes the cube root of an argument.
        /// </summary>
        /// <remarks>
        ///   The function cubeRoot computes \f$\sqrt[3]{\texttt{val}}\f$. Negative arguments are handled correctly.
        ///   NaN and Inf are not handled. The accuracy approaches the maximum possible accuracy for
        ///   single-precision data.
        /// </remarks>
        /// <param name="val">
        /// A function argument.
        /// </param>
        public static float cubeRoot(float val)
        {


            return core_Core_cubeRoot_10(val);


        }


        //
        // C++:  float cv::fastAtan2(float y, float x)
        //

        /// <summary>
        ///  Calculates the angle of a 2D vector in degrees.
        /// </summary>
        /// <remarks>
        ///   The function fastAtan2 calculates the full-range angle of an input 2D vector. The angle is measured
        ///   in degrees and varies from 0 to 360 degrees. The accuracy is about 0.3 degrees.
        /// </remarks>
        /// <param name="x">
        /// x-coordinate of the vector.
        /// </param>
        /// <param name="y">
        /// y-coordinate of the vector.
        /// </param>
        public static float fastAtan2(float y, float x)
        {


            return core_Core_fastAtan2_10(y, x);


        }


        //
        // C++:  bool cv::ipp::useIPP()
        //

        /// <remarks>
        ///  proxy for hal::Cholesky
        /// </remarks>
        public static bool useIPP()
        {


            return core_Core_useIPP_10();


        }


        //
        // C++:  void cv::ipp::setUseIPP(bool flag)
        //

        public static void setUseIPP(bool flag)
        {


            core_Core_setUseIPP_10(flag);


        }


        //
        // C++:  String cv::ipp::getIppVersion()
        //

        public static string getIppVersion()
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_getIppVersion_10()));

            return retVal;
        }


        //
        // C++:  bool cv::ipp::useIPP_NotExact()
        //

        public static bool useIPP_NotExact()
        {


            return core_Core_useIPP_1NotExact_10();


        }


        //
        // C++:  void cv::ipp::setUseIPP_NotExact(bool flag)
        //

        public static void setUseIPP_NotExact(bool flag)
        {


            core_Core_setUseIPP_1NotExact_10(flag);


        }


        //
        // C++:  int cv::borderInterpolate(int p, int len, int borderType)
        //

        /// <summary>
        ///  Computes the source location of an extrapolated pixel.
        /// </summary>
        /// <remarks>
        ///  The function computes and returns the coordinate of a donor pixel corresponding to the specified
        ///  extrapolated pixel when using the specified extrapolation border mode. For example, if you use
        ///  cv::BORDER_WRAP mode in the horizontal direction, cv::BORDER_REFLECT_101 in the vertical direction and
        ///  want to compute value of the "virtual" pixel Point(-5, 100) in a floating-point image img, it
        ///  looks like:
        /// </remarks>
        /// <code language="c++">
        ///      float val = img.at&lt;float&gt;(borderInterpolate(100, img.rows, cv::BORDER_REFLECT_101),
        ///                                borderInterpolate(-5, img.cols, cv::BORDER_WRAP));
        /// </code>
        /// <remarks>
        ///  Normally, the function is not called directly. It is used inside filtering functions and also in
        ///  copyMakeBorder.
        /// </remarks>
        /// <param name="p">
        /// 0-based coordinate of the extrapolated pixel along one of the axes, likely &lt;0 or &gt;= len
        /// </param>
        /// <param name="len">
        /// Length of the array along the corresponding axis.
        /// </param>
        /// <param name="borderType">
        /// Border type, one of the #BorderTypes, except for #BORDER_TRANSPARENT and
        ///  #BORDER_ISOLATED. When borderType==#BORDER_CONSTANT, the function always returns -1, regardless
        ///  of p and len.
        /// </param>
        /// <remarks>
        ///  @sa copyMakeBorder
        /// </remarks>
        public static int borderInterpolate(int p, int len, int borderType)
        {


            return core_Core_borderInterpolate_10(p, len, borderType);


        }


        //
        // C++:  void cv::copyMakeBorder(Mat src, Mat& dst, int top, int bottom, int left, int right, int borderType, Scalar value = Scalar())
        //

        /// <summary>
        ///  Forms a border around an image.
        /// </summary>
        /// <remarks>
        ///  The function copies the source image into the middle of the destination image. The areas to the
        ///  left, to the right, above and below the copied source image will be filled with extrapolated
        ///  pixels. This is not what filtering functions based on it do (they extrapolate pixels on-fly), but
        ///  what other more complex functions, including your own, may do to simplify image boundary handling.
        ///  
        ///  The function supports the mode when src is already in the middle of dst . In this case, the
        ///  function does not copy src itself but simply constructs the border, for example:
        /// </remarks>
        /// <code language="c++">
        ///      // let border be the same in all directions
        ///      int border=2;
        ///      // constructs a larger image to fit both the image and the border
        ///      Mat gray_buf(rgb.rows + border*2, rgb.cols + border*2, rgb.depth());
        ///      // select the middle part of it w/o copying data
        ///      Mat gray(gray_canvas, Rect(border, border, rgb.cols, rgb.rows));
        ///      // convert image from RGB to grayscale
        ///      cvtColor(rgb, gray, COLOR_RGB2GRAY);
        ///      // form a border in-place
        ///      copyMakeBorder(gray, gray_buf, border, border,
        ///                     border, border, BORDER_REPLICATE);
        ///      // now do some custom filtering ...
        ///      ...
        /// </code>
        /// <remarks>
        ///  @note When the source image is a part (ROI) of a bigger image, the function will try to use the
        ///  pixels outside of the ROI to form a border. To disable this feature and always do extrapolation, as
        ///  if src was not a ROI, use borderType | #BORDER_ISOLATED.
        /// </remarks>
        /// <param name="src">
        /// Source image.
        /// </param>
        /// <param name="dst">
        /// Destination image of the same type as src and the size Size(src.cols+left+right,
        ///  src.rows+top+bottom) .
        /// </param>
        /// <param name="top">
        /// the top pixels
        /// </param>
        /// <param name="bottom">
        /// the bottom pixels
        /// </param>
        /// <param name="left">
        /// the left pixels
        /// </param>
        /// <param name="right">
        /// Parameter specifying how many pixels in each direction from the source image rectangle
        ///  to extrapolate. For example, top=1, bottom=1, left=1, right=1 mean that 1 pixel-wide border needs
        ///  to be built.
        /// </param>
        /// <param name="borderType">
        /// Border type. See borderInterpolate for details.
        /// </param>
        /// <param name="value">
        /// Border value if borderType==BORDER_CONSTANT .
        /// </param>
        /// <remarks>
        ///  @sa  borderInterpolate
        /// </remarks>
        public static void copyMakeBorder(Mat src, Mat dst, int top, int bottom, int left, int right, int borderType, Scalar value)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_copyMakeBorder_10(src.nativeObj, dst.nativeObj, top, bottom, left, right, borderType, value.val[0], value.val[1], value.val[2], value.val[3]);


        }

        /// <summary>
        ///  Forms a border around an image.
        /// </summary>
        /// <remarks>
        ///  The function copies the source image into the middle of the destination image. The areas to the
        ///  left, to the right, above and below the copied source image will be filled with extrapolated
        ///  pixels. This is not what filtering functions based on it do (they extrapolate pixels on-fly), but
        ///  what other more complex functions, including your own, may do to simplify image boundary handling.
        ///  
        ///  The function supports the mode when src is already in the middle of dst . In this case, the
        ///  function does not copy src itself but simply constructs the border, for example:
        /// </remarks>
        /// <code language="c++">
        ///      // let border be the same in all directions
        ///      int border=2;
        ///      // constructs a larger image to fit both the image and the border
        ///      Mat gray_buf(rgb.rows + border*2, rgb.cols + border*2, rgb.depth());
        ///      // select the middle part of it w/o copying data
        ///      Mat gray(gray_canvas, Rect(border, border, rgb.cols, rgb.rows));
        ///      // convert image from RGB to grayscale
        ///      cvtColor(rgb, gray, COLOR_RGB2GRAY);
        ///      // form a border in-place
        ///      copyMakeBorder(gray, gray_buf, border, border,
        ///                     border, border, BORDER_REPLICATE);
        ///      // now do some custom filtering ...
        ///      ...
        /// </code>
        /// <remarks>
        ///  @note When the source image is a part (ROI) of a bigger image, the function will try to use the
        ///  pixels outside of the ROI to form a border. To disable this feature and always do extrapolation, as
        ///  if src was not a ROI, use borderType | #BORDER_ISOLATED.
        /// </remarks>
        /// <param name="src">
        /// Source image.
        /// </param>
        /// <param name="dst">
        /// Destination image of the same type as src and the size Size(src.cols+left+right,
        ///  src.rows+top+bottom) .
        /// </param>
        /// <param name="top">
        /// the top pixels
        /// </param>
        /// <param name="bottom">
        /// the bottom pixels
        /// </param>
        /// <param name="left">
        /// the left pixels
        /// </param>
        /// <param name="right">
        /// Parameter specifying how many pixels in each direction from the source image rectangle
        ///  to extrapolate. For example, top=1, bottom=1, left=1, right=1 mean that 1 pixel-wide border needs
        ///  to be built.
        /// </param>
        /// <param name="borderType">
        /// Border type. See borderInterpolate for details.
        /// </param>
        /// <param name="value">
        /// Border value if borderType==BORDER_CONSTANT .
        /// </param>
        /// <remarks>
        ///  @sa  borderInterpolate
        /// </remarks>
        public static void copyMakeBorder(Mat src, Mat dst, int top, int bottom, int left, int right, int borderType)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_copyMakeBorder_11(src.nativeObj, dst.nativeObj, top, bottom, left, right, borderType);


        }


        //
        // C++:  void cv::add(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        /// <summary>
        ///  Calculates the per-element sum of two arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function add calculates:
        ///  - Sum of two arrays when both input arrays have the same size and the same number of channels:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) +  \texttt{src2}(I)) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Sum of an array and a scalar when src2 is constructed from Scalar or has the same number of
        ///  elements as `src1.channels()`:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) +  \texttt{src2} ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Sum of a scalar and an array when src1 is constructed from Scalar or has the same number of
        ///  elements as `src2.channels()`:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1} +  \texttt{src2}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  where `I` is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  
        ///  The first function in the list above can be replaced with matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1 + src2;
        ///      dst += src1; // equivalent to add(dst, src1, dst);
        /// </code>
        /// <remarks>
        ///  The input arrays and the output array can all have the same or different depths. For example, you
        ///  can add a 16-bit unsigned array to a 8-bit signed array and store the sum as a 32-bit
        ///  floating-point array. Depth of the output array is determined by the dtype parameter. In the second
        ///  and third cases above, as well as in the first case, when src1.depth() == src2.depth(), dtype can
        ///  be set to the default -1. In this case, the output array will have the same depth as the input
        ///  array, be it src1, src2 or both.
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `add(src,X)` means `add(src,(X,X,X,X))`.
        ///  `add(src,(X,))` means `add(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and number of channels as the input array(s); the
        ///  depth is defined by dtype or src1/src2.
        /// </param>
        /// <param name="mask">
        /// optional operation mask - 8-bit single channel array, that specifies elements of the
        ///  output array to be changed.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array (see the discussion below).
        ///  @sa subtract, addWeighted, scaleAdd, Mat::convertTo
        /// </param>
        public static void add(Mat src1, Mat src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_add_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj, dtype);


        }

        /// <summary>
        ///  Calculates the per-element sum of two arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function add calculates:
        ///  - Sum of two arrays when both input arrays have the same size and the same number of channels:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) +  \texttt{src2}(I)) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Sum of an array and a scalar when src2 is constructed from Scalar or has the same number of
        ///  elements as `src1.channels()`:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) +  \texttt{src2} ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Sum of a scalar and an array when src1 is constructed from Scalar or has the same number of
        ///  elements as `src2.channels()`:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1} +  \texttt{src2}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  where `I` is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  
        ///  The first function in the list above can be replaced with matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1 + src2;
        ///      dst += src1; // equivalent to add(dst, src1, dst);
        /// </code>
        /// <remarks>
        ///  The input arrays and the output array can all have the same or different depths. For example, you
        ///  can add a 16-bit unsigned array to a 8-bit signed array and store the sum as a 32-bit
        ///  floating-point array. Depth of the output array is determined by the dtype parameter. In the second
        ///  and third cases above, as well as in the first case, when src1.depth() == src2.depth(), dtype can
        ///  be set to the default -1. In this case, the output array will have the same depth as the input
        ///  array, be it src1, src2 or both.
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `add(src,X)` means `add(src,(X,X,X,X))`.
        ///  `add(src,(X,))` means `add(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and number of channels as the input array(s); the
        ///  depth is defined by dtype or src1/src2.
        /// </param>
        /// <param name="mask">
        /// optional operation mask - 8-bit single channel array, that specifies elements of the
        ///  output array to be changed.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array (see the discussion below).
        ///  @sa subtract, addWeighted, scaleAdd, Mat::convertTo
        /// </param>
        public static void add(Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_add_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///  Calculates the per-element sum of two arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function add calculates:
        ///  - Sum of two arrays when both input arrays have the same size and the same number of channels:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) +  \texttt{src2}(I)) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Sum of an array and a scalar when src2 is constructed from Scalar or has the same number of
        ///  elements as `src1.channels()`:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) +  \texttt{src2} ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Sum of a scalar and an array when src1 is constructed from Scalar or has the same number of
        ///  elements as `src2.channels()`:
        ///  \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1} +  \texttt{src2}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  where `I` is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  
        ///  The first function in the list above can be replaced with matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1 + src2;
        ///      dst += src1; // equivalent to add(dst, src1, dst);
        /// </code>
        /// <remarks>
        ///  The input arrays and the output array can all have the same or different depths. For example, you
        ///  can add a 16-bit unsigned array to a 8-bit signed array and store the sum as a 32-bit
        ///  floating-point array. Depth of the output array is determined by the dtype parameter. In the second
        ///  and third cases above, as well as in the first case, when src1.depth() == src2.depth(), dtype can
        ///  be set to the default -1. In this case, the output array will have the same depth as the input
        ///  array, be it src1, src2 or both.
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `add(src,X)` means `add(src,(X,X,X,X))`.
        ///  `add(src,(X,))` means `add(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and number of channels as the input array(s); the
        ///  depth is defined by dtype or src1/src2.
        /// </param>
        /// <param name="mask">
        /// optional operation mask - 8-bit single channel array, that specifies elements of the
        ///  output array to be changed.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array (see the discussion below).
        ///  @sa subtract, addWeighted, scaleAdd, Mat::convertTo
        /// </param>
        public static void add(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_add_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::subtract(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        /// <summary>
        ///  Calculates the per-element difference between two arrays or array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function subtract calculates:
        ///  - Difference between two arrays, when both input arrays have the same size and the same number of
        ///  channels:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) -  \texttt{src2}(I)) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Difference between an array and a scalar, when src2 is constructed from Scalar or has the same
        ///  number of elements as `src1.channels()`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) -  \texttt{src2} ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Difference between a scalar and an array, when src1 is constructed from Scalar or has the same
        ///  number of elements as `src2.channels()`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1} -  \texttt{src2}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - The reverse difference between a scalar and an array in the case of `SubRS`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src2} -  \texttt{src1}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  where I is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  
        ///  The first function in the list above can be replaced with matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1 - src2;
        ///      dst -= src1; // equivalent to subtract(dst, src1, dst);
        /// </code>
        /// <remarks>
        ///  The input arrays and the output array can all have the same or different depths. For example, you
        ///  can subtract to 8-bit unsigned arrays and store the difference in a 16-bit signed array. Depth of
        ///  the output array is determined by dtype parameter. In the second and third cases above, as well as
        ///  in the first case, when src1.depth() == src2.depth(), dtype can be set to the default -1. In this
        ///  case the output array will have the same depth as the input array, be it src1, src2 or both.
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `subtract(src,X)` means `subtract(src,(X,X,X,X))`.
        ///  `subtract(src,(X,))` means `subtract(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and the same number of channels as the input array.
        /// </param>
        /// <param name="mask">
        /// optional operation mask; this is an 8-bit single channel array that specifies elements
        ///  of the output array to be changed.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array
        ///  @sa  add, addWeighted, scaleAdd, Mat::convertTo
        /// </param>
        public static void subtract(Mat src1, Mat src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_subtract_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj, dtype);


        }

        /// <summary>
        ///  Calculates the per-element difference between two arrays or array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function subtract calculates:
        ///  - Difference between two arrays, when both input arrays have the same size and the same number of
        ///  channels:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) -  \texttt{src2}(I)) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Difference between an array and a scalar, when src2 is constructed from Scalar or has the same
        ///  number of elements as `src1.channels()`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) -  \texttt{src2} ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Difference between a scalar and an array, when src1 is constructed from Scalar or has the same
        ///  number of elements as `src2.channels()`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1} -  \texttt{src2}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - The reverse difference between a scalar and an array in the case of `SubRS`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src2} -  \texttt{src1}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  where I is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  
        ///  The first function in the list above can be replaced with matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1 - src2;
        ///      dst -= src1; // equivalent to subtract(dst, src1, dst);
        /// </code>
        /// <remarks>
        ///  The input arrays and the output array can all have the same or different depths. For example, you
        ///  can subtract to 8-bit unsigned arrays and store the difference in a 16-bit signed array. Depth of
        ///  the output array is determined by dtype parameter. In the second and third cases above, as well as
        ///  in the first case, when src1.depth() == src2.depth(), dtype can be set to the default -1. In this
        ///  case the output array will have the same depth as the input array, be it src1, src2 or both.
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `subtract(src,X)` means `subtract(src,(X,X,X,X))`.
        ///  `subtract(src,(X,))` means `subtract(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and the same number of channels as the input array.
        /// </param>
        /// <param name="mask">
        /// optional operation mask; this is an 8-bit single channel array that specifies elements
        ///  of the output array to be changed.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array
        ///  @sa  add, addWeighted, scaleAdd, Mat::convertTo
        /// </param>
        public static void subtract(Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_subtract_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///  Calculates the per-element difference between two arrays or array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function subtract calculates:
        ///  - Difference between two arrays, when both input arrays have the same size and the same number of
        ///  channels:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) -  \texttt{src2}(I)) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Difference between an array and a scalar, when src2 is constructed from Scalar or has the same
        ///  number of elements as `src1.channels()`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1}(I) -  \texttt{src2} ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - Difference between a scalar and an array, when src1 is constructed from Scalar or has the same
        ///  number of elements as `src2.channels()`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src1} -  \texttt{src2}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  - The reverse difference between a scalar and an array in the case of `SubRS`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} ( \texttt{src2} -  \texttt{src1}(I) ) \quad \texttt{if mask}(I) \ne0\f]
        ///  where I is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  
        ///  The first function in the list above can be replaced with matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1 - src2;
        ///      dst -= src1; // equivalent to subtract(dst, src1, dst);
        /// </code>
        /// <remarks>
        ///  The input arrays and the output array can all have the same or different depths. For example, you
        ///  can subtract to 8-bit unsigned arrays and store the difference in a 16-bit signed array. Depth of
        ///  the output array is determined by dtype parameter. In the second and third cases above, as well as
        ///  in the first case, when src1.depth() == src2.depth(), dtype can be set to the default -1. In this
        ///  case the output array will have the same depth as the input array, be it src1, src2 or both.
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `subtract(src,X)` means `subtract(src,(X,X,X,X))`.
        ///  `subtract(src,(X,))` means `subtract(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and the same number of channels as the input array.
        /// </param>
        /// <param name="mask">
        /// optional operation mask; this is an 8-bit single channel array that specifies elements
        ///  of the output array to be changed.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array
        ///  @sa  add, addWeighted, scaleAdd, Mat::convertTo
        /// </param>
        public static void subtract(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_subtract_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::multiply(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        /// <summary>
        ///  Calculates the per-element scaled product of two arrays.
        /// </summary>
        /// <remarks>
        ///  The function multiply calculates the per-element product of two arrays:
        ///  
        ///  \f[\texttt{dst} (I)= \texttt{saturate} ( \texttt{scale} \cdot \texttt{src1} (I)  \cdot \texttt{src2} (I))\f]
        ///  
        ///  There is also a @ref MatrixExpressions -friendly variant of the first function. See Mat::mul .
        ///  
        ///  For a not-per-element matrix product, see gemm .
        ///  
        ///  @note Saturation is not applied when the output array has the depth
        ///  CV_32S. You may even get result of an incorrect sign in the case of
        ///  overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `multiply(src,X)` means `multiply(src,(X,X,X,X))`.
        ///  `multiply(src,(X,))` means `multiply(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and the same type as src1.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src1.
        /// </param>
        /// <param name="scale">
        /// optional scale factor.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array
        ///  @sa add, subtract, divide, scaleAdd, addWeighted, accumulate, accumulateProduct, accumulateSquare,
        ///  Mat::convertTo
        /// </param>
        public static void multiply(Mat src1, Mat src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_multiply_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale, dtype);


        }

        /// <summary>
        ///  Calculates the per-element scaled product of two arrays.
        /// </summary>
        /// <remarks>
        ///  The function multiply calculates the per-element product of two arrays:
        ///  
        ///  \f[\texttt{dst} (I)= \texttt{saturate} ( \texttt{scale} \cdot \texttt{src1} (I)  \cdot \texttt{src2} (I))\f]
        ///  
        ///  There is also a @ref MatrixExpressions -friendly variant of the first function. See Mat::mul .
        ///  
        ///  For a not-per-element matrix product, see gemm .
        ///  
        ///  @note Saturation is not applied when the output array has the depth
        ///  CV_32S. You may even get result of an incorrect sign in the case of
        ///  overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `multiply(src,X)` means `multiply(src,(X,X,X,X))`.
        ///  `multiply(src,(X,))` means `multiply(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and the same type as src1.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src1.
        /// </param>
        /// <param name="scale">
        /// optional scale factor.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array
        ///  @sa add, subtract, divide, scaleAdd, addWeighted, accumulate, accumulateProduct, accumulateSquare,
        ///  Mat::convertTo
        /// </param>
        public static void multiply(Mat src1, Mat src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_multiply_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale);


        }

        /// <summary>
        ///  Calculates the per-element scaled product of two arrays.
        /// </summary>
        /// <remarks>
        ///  The function multiply calculates the per-element product of two arrays:
        ///  
        ///  \f[\texttt{dst} (I)= \texttt{saturate} ( \texttt{scale} \cdot \texttt{src1} (I)  \cdot \texttt{src2} (I))\f]
        ///  
        ///  There is also a @ref MatrixExpressions -friendly variant of the first function. See Mat::mul .
        ///  
        ///  For a not-per-element matrix product, see gemm .
        ///  
        ///  @note Saturation is not applied when the output array has the depth
        ///  CV_32S. You may even get result of an incorrect sign in the case of
        ///  overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `multiply(src,X)` means `multiply(src,(X,X,X,X))`.
        ///  `multiply(src,(X,))` means `multiply(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and the same type as src1.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src1.
        /// </param>
        /// <param name="scale">
        /// optional scale factor.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array
        ///  @sa add, subtract, divide, scaleAdd, addWeighted, accumulate, accumulateProduct, accumulateSquare,
        ///  Mat::convertTo
        /// </param>
        public static void multiply(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_multiply_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::divide(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        /// <summary>
        ///  Performs per-element division of two arrays or a scalar by an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::divide divides one array by another:
        ///  \f[\texttt{dst(I) = saturate(src1(I)*scale/src2(I))}\f]
        ///  or a scalar by an array when there is no src1 :
        ///  \f[\texttt{dst(I) = saturate(scale/src2(I))}\f]
        ///  
        ///  Different channels of multi-channel arrays are processed independently.
        ///  
        ///  For integer types when src2(I) is zero, dst(I) will also be zero.
        ///  
        ///  @note In case of floating point data there is no special defined behavior for zero src2(I) values.
        ///  Regular floating-point division is used.
        ///  Expect correct IEEE-754 behaviour for floating-point data (with NaN, Inf result values).
        ///  
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `divide(src,X)` means `divide(src,(X,X,X,X))`.
        ///  `divide(src,(X,))` means `divide(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and type as src1.
        /// </param>
        /// <param name="scale">
        /// scalar factor.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src2.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array; if -1, dst will have depth src2.depth(), but in
        ///  case of an array-by-array division, you can only pass -1 when src1.depth()==src2.depth().
        ///  @sa  multiply, add, subtract
        /// </param>
        public static void divide(Mat src1, Mat src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale, dtype);


        }

        /// <summary>
        ///  Performs per-element division of two arrays or a scalar by an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::divide divides one array by another:
        ///  \f[\texttt{dst(I) = saturate(src1(I)*scale/src2(I))}\f]
        ///  or a scalar by an array when there is no src1 :
        ///  \f[\texttt{dst(I) = saturate(scale/src2(I))}\f]
        ///  
        ///  Different channels of multi-channel arrays are processed independently.
        ///  
        ///  For integer types when src2(I) is zero, dst(I) will also be zero.
        ///  
        ///  @note In case of floating point data there is no special defined behavior for zero src2(I) values.
        ///  Regular floating-point division is used.
        ///  Expect correct IEEE-754 behaviour for floating-point data (with NaN, Inf result values).
        ///  
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `divide(src,X)` means `divide(src,(X,X,X,X))`.
        ///  `divide(src,(X,))` means `divide(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and type as src1.
        /// </param>
        /// <param name="scale">
        /// scalar factor.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src2.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array; if -1, dst will have depth src2.depth(), but in
        ///  case of an array-by-array division, you can only pass -1 when src1.depth()==src2.depth().
        ///  @sa  multiply, add, subtract
        /// </param>
        public static void divide(Mat src1, Mat src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale);


        }

        /// <summary>
        ///  Performs per-element division of two arrays or a scalar by an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::divide divides one array by another:
        ///  \f[\texttt{dst(I) = saturate(src1(I)*scale/src2(I))}\f]
        ///  or a scalar by an array when there is no src1 :
        ///  \f[\texttt{dst(I) = saturate(scale/src2(I))}\f]
        ///  
        ///  Different channels of multi-channel arrays are processed independently.
        ///  
        ///  For integer types when src2(I) is zero, dst(I) will also be zero.
        ///  
        ///  @note In case of floating point data there is no special defined behavior for zero src2(I) values.
        ///  Regular floating-point division is used.
        ///  Expect correct IEEE-754 behaviour for floating-point data (with NaN, Inf result values).
        ///  
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `divide(src,X)` means `divide(src,(X,X,X,X))`.
        ///  `divide(src,(X,))` means `divide(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and type as src1.
        /// </param>
        /// <param name="scale">
        /// scalar factor.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src2.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array; if -1, dst will have depth src2.depth(), but in
        ///  case of an array-by-array division, you can only pass -1 when src1.depth()==src2.depth().
        ///  @sa  multiply, add, subtract
        /// </param>
        public static void divide(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::divide(double scale, Mat src2, Mat& dst, int dtype = -1)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static void divide(double scale, Mat src2, Mat dst, int dtype)
        {
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_13(scale, src2.nativeObj, dst.nativeObj, dtype);


        }

        /// <remarks>
        ///  @overload
        /// </remarks>
        public static void divide(double scale, Mat src2, Mat dst)
        {
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_14(scale, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::scaleAdd(Mat src1, double alpha, Mat src2, Mat& dst)
        //

        /// <summary>
        ///  Calculates the sum of a scaled array and another array.
        /// </summary>
        /// <remarks>
        ///  The function scaleAdd is one of the classical primitive linear algebra operations, known as DAXPY
        ///  or SAXPY in [BLAS](http://en.wikipedia.org/wiki/Basic_Linear_Algebra_Subprograms). It calculates
        ///  the sum of a scaled array and another array:
        ///  \f[\texttt{dst} (I)= \texttt{scale} \cdot \texttt{src1} (I) +  \texttt{src2} (I)\f]
        ///  The function can also be emulated with a matrix expression, for example:
        /// </remarks>
        /// <code language="c++">
        ///      Mat A(3, 3, CV_64F);
        ///      ...
        ///      A.row(0) = A.row(1)*2 + A.row(2);
        /// </code>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="alpha">
        /// scale factor for the first array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and type as src1.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src1.
        ///  @sa add, addWeighted, subtract, Mat::dot, Mat::convertTo
        /// </param>
        public static void scaleAdd(Mat src1, double alpha, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_scaleAdd_10(src1.nativeObj, alpha, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::addWeighted(Mat src1, double alpha, Mat src2, double beta, double gamma, Mat& dst, int dtype = -1)
        //

        /// <summary>
        ///  Calculates the weighted sum of two arrays.
        /// </summary>
        /// <remarks>
        ///  The function addWeighted calculates the weighted sum of two arrays as follows:
        ///  \f[\texttt{dst} (I)= \texttt{saturate} ( \texttt{src1} (I)* \texttt{alpha} +  \texttt{src2} (I)* \texttt{beta} +  \texttt{gamma} )\f]
        ///  where I is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  The function can be replaced with a matrix expression:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1*alpha + src2*beta + gamma;
        /// </code>
        /// <remarks>
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="alpha">
        /// weight of the first array elements.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and channel number as src1.
        /// </param>
        /// <param name="beta">
        /// weight of the second array elements.
        /// </param>
        /// <param name="gamma">
        /// scalar added to each sum.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and number of channels as the input arrays.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array; when both input arrays have the same depth, dtype
        ///  can be set to -1, which will be equivalent to src1.depth().
        ///  @sa  add, subtract, scaleAdd, Mat::convertTo
        /// </param>
        public static void addWeighted(Mat src1, double alpha, Mat src2, double beta, double gamma, Mat dst, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_addWeighted_10(src1.nativeObj, alpha, src2.nativeObj, beta, gamma, dst.nativeObj, dtype);


        }

        /// <summary>
        ///  Calculates the weighted sum of two arrays.
        /// </summary>
        /// <remarks>
        ///  The function addWeighted calculates the weighted sum of two arrays as follows:
        ///  \f[\texttt{dst} (I)= \texttt{saturate} ( \texttt{src1} (I)* \texttt{alpha} +  \texttt{src2} (I)* \texttt{beta} +  \texttt{gamma} )\f]
        ///  where I is a multi-dimensional index of array elements. In case of multi-channel arrays, each
        ///  channel is processed independently.
        ///  The function can be replaced with a matrix expression:
        /// </remarks>
        /// <code language="c++">
        ///      dst = src1*alpha + src2*beta + gamma;
        /// </code>
        /// <remarks>
        ///  @note Saturation is not applied when the output array has the depth CV_32S. You may even get
        ///  result of an incorrect sign in the case of overflow.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="alpha">
        /// weight of the first array elements.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and channel number as src1.
        /// </param>
        /// <param name="beta">
        /// weight of the second array elements.
        /// </param>
        /// <param name="gamma">
        /// scalar added to each sum.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and number of channels as the input arrays.
        /// </param>
        /// <param name="dtype">
        /// optional depth of the output array; when both input arrays have the same depth, dtype
        ///  can be set to -1, which will be equivalent to src1.depth().
        ///  @sa  add, subtract, scaleAdd, Mat::convertTo
        /// </param>
        public static void addWeighted(Mat src1, double alpha, Mat src2, double beta, double gamma, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_addWeighted_11(src1.nativeObj, alpha, src2.nativeObj, beta, gamma, dst.nativeObj);


        }


        //
        // C++:  void cv::convertScaleAbs(Mat src, Mat& dst, double alpha = 1, double beta = 0)
        //

        /// <summary>
        ///  Scales, calculates absolute values, and converts the result to 8-bit.
        /// </summary>
        /// <remarks>
        ///  On each element of the input array, the function convertScaleAbs
        ///  performs three operations sequentially: scaling, taking an absolute
        ///  value, conversion to an unsigned 8-bit type:
        ///  \f[\texttt{dst} (I)= \texttt{saturate\_cast&lt;uchar&gt;} (| \texttt{src} (I)* \texttt{alpha} +  \texttt{beta} |)\f]
        ///  In case of multi-channel arrays, the function processes each channel
        ///  independently. When the output is not 8-bit, the operation can be
        ///  emulated by calling the Mat::convertTo method (or by using matrix
        ///  expressions) and then by calculating an absolute value of the result.
        ///  For example:
        /// </remarks>
        /// <code language="c++">
        ///      Mat_&lt;float&gt; A(30,30);
        ///      randu(A, Scalar(-100), Scalar(100));
        ///      Mat_&lt;float&gt; B = A*5 + 3;
        ///      B = abs(B);
        ///      // Mat_&lt;float&gt; B = abs(A*5+3) will also do the job,
        ///      // but it will allocate a temporary matrix
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array.
        /// </param>
        /// <param name="alpha">
        /// optional scale factor.
        /// </param>
        /// <param name="beta">
        /// optional delta added to the scaled values.
        ///  @sa  Mat::convertTo, cv::abs(const Mat&amp;)
        /// </param>
        public static void convertScaleAbs(Mat src, Mat dst, double alpha, double beta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_convertScaleAbs_10(src.nativeObj, dst.nativeObj, alpha, beta);


        }

        /// <summary>
        ///  Scales, calculates absolute values, and converts the result to 8-bit.
        /// </summary>
        /// <remarks>
        ///  On each element of the input array, the function convertScaleAbs
        ///  performs three operations sequentially: scaling, taking an absolute
        ///  value, conversion to an unsigned 8-bit type:
        ///  \f[\texttt{dst} (I)= \texttt{saturate\_cast&lt;uchar&gt;} (| \texttt{src} (I)* \texttt{alpha} +  \texttt{beta} |)\f]
        ///  In case of multi-channel arrays, the function processes each channel
        ///  independently. When the output is not 8-bit, the operation can be
        ///  emulated by calling the Mat::convertTo method (or by using matrix
        ///  expressions) and then by calculating an absolute value of the result.
        ///  For example:
        /// </remarks>
        /// <code language="c++">
        ///      Mat_&lt;float&gt; A(30,30);
        ///      randu(A, Scalar(-100), Scalar(100));
        ///      Mat_&lt;float&gt; B = A*5 + 3;
        ///      B = abs(B);
        ///      // Mat_&lt;float&gt; B = abs(A*5+3) will also do the job,
        ///      // but it will allocate a temporary matrix
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array.
        /// </param>
        /// <param name="alpha">
        /// optional scale factor.
        /// </param>
        /// <param name="beta">
        /// optional delta added to the scaled values.
        ///  @sa  Mat::convertTo, cv::abs(const Mat&amp;)
        /// </param>
        public static void convertScaleAbs(Mat src, Mat dst, double alpha)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_convertScaleAbs_11(src.nativeObj, dst.nativeObj, alpha);


        }

        /// <summary>
        ///  Scales, calculates absolute values, and converts the result to 8-bit.
        /// </summary>
        /// <remarks>
        ///  On each element of the input array, the function convertScaleAbs
        ///  performs three operations sequentially: scaling, taking an absolute
        ///  value, conversion to an unsigned 8-bit type:
        ///  \f[\texttt{dst} (I)= \texttt{saturate\_cast&lt;uchar&gt;} (| \texttt{src} (I)* \texttt{alpha} +  \texttt{beta} |)\f]
        ///  In case of multi-channel arrays, the function processes each channel
        ///  independently. When the output is not 8-bit, the operation can be
        ///  emulated by calling the Mat::convertTo method (or by using matrix
        ///  expressions) and then by calculating an absolute value of the result.
        ///  For example:
        /// </remarks>
        /// <code language="c++">
        ///      Mat_&lt;float&gt; A(30,30);
        ///      randu(A, Scalar(-100), Scalar(100));
        ///      Mat_&lt;float&gt; B = A*5 + 3;
        ///      B = abs(B);
        ///      // Mat_&lt;float&gt; B = abs(A*5+3) will also do the job,
        ///      // but it will allocate a temporary matrix
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array.
        /// </param>
        /// <param name="alpha">
        /// optional scale factor.
        /// </param>
        /// <param name="beta">
        /// optional delta added to the scaled values.
        ///  @sa  Mat::convertTo, cv::abs(const Mat&amp;)
        /// </param>
        public static void convertScaleAbs(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_convertScaleAbs_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::convertFp16(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Converts an array to half precision floating number.
        /// </summary>
        /// <remarks>
        ///  This function converts FP32 (single precision floating point) from/to FP16 (half precision floating point). CV_16S format is used to represent FP16 data.
        ///  There are two use modes (src -&gt; dst): CV_32F -&gt; CV_16S and CV_16S -&gt; CV_32F. The input array has to have type of CV_32F or
        ///  CV_16S to represent the bit depth. If the input array is neither of them, the function will raise an error.
        ///  The format of half precision floating point is defined in IEEE 754-2008.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array.
        /// </param>
        /// <remarks>
        ///  @deprecated Use Mat::convertTo with CV_16F instead.
        /// </remarks>
        [Obsolete("This method is deprecated.")]
        public static void convertFp16(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_convertFp16_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::LUT(Mat src, Mat lut, Mat& dst)
        //

        /// <summary>
        ///  Performs a look-up table transform of an array.
        /// </summary>
        /// <remarks>
        ///  The function LUT fills the output array with values from the look-up table. Indices of the entries
        ///  are taken from the input array. That is, the function processes each element of src as follows:
        ///  \f[\texttt{dst} (I)  \leftarrow \texttt{lut(src(I) + d)}\f]
        ///  where
        ///  \f[d =  \fork{0}{if \(\texttt{src}\) has depth \(\texttt{CV_8U}\)}{128}{if \(\texttt{src}\) has depth \(\texttt{CV_8S}\)}\f]
        /// </remarks>
        /// <param name="src">
        /// input array of 8-bit elements.
        /// </param>
        /// <param name="lut">
        /// look-up table of 256 elements; in case of multi-channel input array, the table should
        ///  either have a single channel (in this case the same table is used for all channels) or the same
        ///  number of channels as in the input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and number of channels as src, and the same depth as lut.
        ///  @sa  convertScaleAbs, Mat::convertTo
        /// </param>
        public static void LUT(Mat src, Mat lut, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (lut != null) lut.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_LUT_10(src.nativeObj, lut.nativeObj, dst.nativeObj);


        }


        //
        // C++:  Scalar cv::sum(Mat src)
        //

        /// <summary>
        ///  Calculates the sum of array elements.
        /// </summary>
        /// <remarks>
        ///  The function cv::sum calculates and returns the sum of array elements,
        ///  independently for each channel.
        /// </remarks>
        /// <param name="src">
        /// input array that must have from 1 to 4 channels.
        ///  @sa  countNonZero, mean, meanStdDev, norm, minMaxLoc, reduce
        /// </param>
        public static Scalar sumElems(Mat src)
        {
            if (src != null) src.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            core_Core_sumElems_10(src.nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }


        //
        // C++:  bool cv::hasNonZero(Mat src)
        //

        /// <summary>
        ///  Checks for the presence of at least one non-zero array element.
        /// </summary>
        /// <remarks>
        ///  The function returns whether there are non-zero elements in src
        ///  
        ///  The function do not work with multi-channel arrays. If you need to check non-zero array
        ///  elements across all the channels, use Mat::reshape first to reinterpret the array as
        ///  single-channel. Or you may extract the particular channel using either extractImageCOI, or
        ///  mixChannels, or split.
        ///  
        ///  @note
        ///  - If the location of non-zero array elements is important, @ref findNonZero is helpful.
        ///  - If the count of non-zero array elements is important, @ref countNonZero is helpful.
        /// </remarks>
        /// <param name="src">
        /// single-channel array.
        ///  @sa  mean, meanStdDev, norm, minMaxLoc, calcCovarMatrix
        ///  @sa  findNonZero, countNonZero
        /// </param>
        public static bool hasNonZero(Mat src)
        {
            if (src != null) src.ThrowIfDisposed();

            return core_Core_hasNonZero_10(src.nativeObj);


        }


        //
        // C++:  int cv::countNonZero(Mat src)
        //

        /// <summary>
        ///  Counts non-zero array elements.
        /// </summary>
        /// <remarks>
        ///  The function returns the number of non-zero elements in src :
        ///  \f[\sum _{I: \; \texttt{src} (I) \ne0 } 1\f]
        ///  
        ///  The function do not work with multi-channel arrays. If you need to count non-zero array
        ///  elements across all the channels, use Mat::reshape first to reinterpret the array as
        ///  single-channel. Or you may extract the particular channel using either extractImageCOI, or
        ///  mixChannels, or split.
        ///  
        ///  @note
        ///  - If only whether there are non-zero elements is important, @ref hasNonZero is helpful.
        ///  - If the location of non-zero array elements is important, @ref findNonZero is helpful.
        /// </remarks>
        /// <param name="src">
        /// single-channel array.
        ///  @sa  mean, meanStdDev, norm, minMaxLoc, calcCovarMatrix
        ///  @sa  findNonZero, hasNonZero
        /// </param>
        public static int countNonZero(Mat src)
        {
            if (src != null) src.ThrowIfDisposed();

            return core_Core_countNonZero_10(src.nativeObj);


        }


        //
        // C++:  void cv::findNonZero(Mat src, Mat& idx)
        //

        /// <summary>
        ///  Returns the list of locations of non-zero pixels
        /// </summary>
        /// <remarks>
        ///  Given a binary matrix (likely returned from an operation such
        ///  as threshold(), compare(), &gt;, ==, etc, return all of
        ///  the non-zero indices as a cv::Mat or std::vector&lt;cv::Point&gt; (x,y)
        ///  For example:
        /// </remarks>
        /// <code language="c++">
        ///      cv::Mat binaryImage; // input, binary image
        ///      cv::Mat locations;   // output, locations of non-zero pixels
        ///      cv::findNonZero(binaryImage, locations);
        ///  
        ///      // access pixel coordinates
        ///      Point pnt = locations.at&lt;Point&gt;(i);
        /// </code>
        /// <remarks>
        ///  or
        /// </remarks>
        /// <code language="c++">
        ///      cv::Mat binaryImage; // input, binary image
        ///      vector&lt;Point&gt; locations;   // output, locations of non-zero pixels
        ///      cv::findNonZero(binaryImage, locations);
        ///  
        ///      // access pixel coordinates
        ///      Point pnt = locations[i];
        /// </code>
        /// <remarks>
        ///  The function do not work with multi-channel arrays. If you need to find non-zero
        ///  elements across all the channels, use Mat::reshape first to reinterpret the array as
        ///  single-channel. Or you may extract the particular channel using either extractImageCOI, or
        ///  mixChannels, or split.
        ///  
        ///  @note
        ///  - If only count of non-zero array elements is important, @ref countNonZero is helpful.
        ///  - If only whether there are non-zero elements is important, @ref hasNonZero is helpful.
        /// </remarks>
        /// <param name="src">
        /// single-channel array
        /// </param>
        /// <param name="idx">
        /// the output array, type of cv::Mat or std::vector&lt;Point&gt;, corresponding to non-zero indices in the input
        ///  @sa  countNonZero, hasNonZero
        /// </param>
        public static void findNonZero(Mat src, Mat idx)
        {
            if (src != null) src.ThrowIfDisposed();
            if (idx != null) idx.ThrowIfDisposed();

            core_Core_findNonZero_10(src.nativeObj, idx.nativeObj);


        }


        //
        // C++:  Scalar cv::mean(Mat src, Mat mask = Mat())
        //

        /// <summary>
        ///  Calculates an average (mean) of array elements.
        /// </summary>
        /// <remarks>
        ///  The function cv::mean calculates the mean value M of array elements,
        ///  independently for each channel, and return it:
        ///  \f[\begin{array}{l} N =  \sum _{I: \; \texttt{mask} (I) \ne 0} 1 \\ M_c =  \left ( \sum _{I: \; \texttt{mask} (I) \ne 0}{ \texttt{mtx} (I)_c} \right )/N \end{array}\f]
        ///  When all the mask elements are 0's, the function returns Scalar::all(0)
        /// </remarks>
        /// <param name="src">
        /// input array that should have from 1 to 4 channels so that the result can be stored in
        ///  Scalar_ .
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa  countNonZero, meanStdDev, norm, minMaxLoc
        /// </param>
        public static Scalar mean(Mat src, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            core_Core_mean_10(src.nativeObj, mask.nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }

        /// <summary>
        ///  Calculates an average (mean) of array elements.
        /// </summary>
        /// <remarks>
        ///  The function cv::mean calculates the mean value M of array elements,
        ///  independently for each channel, and return it:
        ///  \f[\begin{array}{l} N =  \sum _{I: \; \texttt{mask} (I) \ne 0} 1 \\ M_c =  \left ( \sum _{I: \; \texttt{mask} (I) \ne 0}{ \texttt{mtx} (I)_c} \right )/N \end{array}\f]
        ///  When all the mask elements are 0's, the function returns Scalar::all(0)
        /// </remarks>
        /// <param name="src">
        /// input array that should have from 1 to 4 channels so that the result can be stored in
        ///  Scalar_ .
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa  countNonZero, meanStdDev, norm, minMaxLoc
        /// </param>
        public static Scalar mean(Mat src)
        {
            if (src != null) src.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            core_Core_mean_11(src.nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }


        //
        // C++:  void cv::meanStdDev(Mat src, vector_double& mean, vector_double& stddev, Mat mask = Mat())
        //

        /// <remarks>
        ///  Calculates a mean and standard deviation of array elements.
        ///  
        ///  The function cv::meanStdDev calculates the mean and the standard deviation M
        ///  of array elements independently for each channel and returns it via the
        ///  output parameters:
        ///  \f[\begin{array}{l} N =  \sum _{I, \texttt{mask} (I)  \ne 0} 1 \\ \texttt{mean} _c =  \frac{\sum_{ I: \; \texttt{mask}(I) \ne 0} \texttt{src} (I)_c}{N} \\ \texttt{stddev} _c =  \sqrt{\frac{\sum_{ I: \; \texttt{mask}(I) \ne 0} \left ( \texttt{src} (I)_c -  \texttt{mean} _c \right )^2}{N}} \end{array}\f]
        ///  When all the mask elements are 0's, the function returns
        ///  mean=stddev=Scalar::all(0).
        ///  @note The calculated standard deviation is only the diagonal of the
        ///  complete normalized covariance matrix. If the full matrix is needed, you
        ///  can reshape the multi-channel array M x N to the single-channel array
        ///  M\*N x mtx.channels() (only possible when the matrix is continuous) and
        ///  then pass the matrix to calcCovarMatrix .
        /// </remarks>
        /// <param name="src">
        /// input array that should have from 1 to 4 channels so that the results can be stored in
        ///  Scalar_ 's.
        /// </param>
        /// <param name="mean">
        /// output parameter: calculated mean value.
        /// </param>
        /// <param name="stddev">
        /// output parameter: calculated standard deviation.
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa  countNonZero, mean, norm, minMaxLoc, calcCovarMatrix
        /// </param>
        public static void meanStdDev(Mat src, MatOfDouble mean, MatOfDouble stddev, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (stddev != null) stddev.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();
            Mat mean_mat = mean;
            Mat stddev_mat = stddev;
            core_Core_meanStdDev_10(src.nativeObj, mean_mat.nativeObj, stddev_mat.nativeObj, mask.nativeObj);


        }

        /// <remarks>
        ///  Calculates a mean and standard deviation of array elements.
        ///  
        ///  The function cv::meanStdDev calculates the mean and the standard deviation M
        ///  of array elements independently for each channel and returns it via the
        ///  output parameters:
        ///  \f[\begin{array}{l} N =  \sum _{I, \texttt{mask} (I)  \ne 0} 1 \\ \texttt{mean} _c =  \frac{\sum_{ I: \; \texttt{mask}(I) \ne 0} \texttt{src} (I)_c}{N} \\ \texttt{stddev} _c =  \sqrt{\frac{\sum_{ I: \; \texttt{mask}(I) \ne 0} \left ( \texttt{src} (I)_c -  \texttt{mean} _c \right )^2}{N}} \end{array}\f]
        ///  When all the mask elements are 0's, the function returns
        ///  mean=stddev=Scalar::all(0).
        ///  @note The calculated standard deviation is only the diagonal of the
        ///  complete normalized covariance matrix. If the full matrix is needed, you
        ///  can reshape the multi-channel array M x N to the single-channel array
        ///  M\*N x mtx.channels() (only possible when the matrix is continuous) and
        ///  then pass the matrix to calcCovarMatrix .
        /// </remarks>
        /// <param name="src">
        /// input array that should have from 1 to 4 channels so that the results can be stored in
        ///  Scalar_ 's.
        /// </param>
        /// <param name="mean">
        /// output parameter: calculated mean value.
        /// </param>
        /// <param name="stddev">
        /// output parameter: calculated standard deviation.
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa  countNonZero, mean, norm, minMaxLoc, calcCovarMatrix
        /// </param>
        public static void meanStdDev(Mat src, MatOfDouble mean, MatOfDouble stddev)
        {
            if (src != null) src.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (stddev != null) stddev.ThrowIfDisposed();
            Mat mean_mat = mean;
            Mat stddev_mat = stddev;
            core_Core_meanStdDev_11(src.nativeObj, mean_mat.nativeObj, stddev_mat.nativeObj);


        }


        //
        // C++:  double cv::norm(Mat src1, int normType = NORM_L2, Mat mask = Mat())
        //

        /// <summary>
        ///  Calculates the  absolute norm of an array.
        /// </summary>
        /// <remarks>
        ///  This version of #norm calculates the absolute norm of src1. The type of norm to calculate is specified using #NormTypes.
        ///  
        ///  As example for one array consider the function \f$r(x)= \begin{pmatrix} x \\ 1-x \end{pmatrix}, x \in [-1;1]\f$.
        ///  The \f$ L_{1}, L_{2} \f$ and \f$ L_{\infty} \f$ norm for the sample value \f$r(-1) = \begin{pmatrix} -1 \\ 2 \end{pmatrix}\f$
        ///  is calculated as follows
        ///  \f{align*}
        ///      \| r(-1) \|_{L_1} &amp;= |-1| + |2| = 3 \\
        ///      \| r(-1) \|_{L_2} &amp;= \sqrt{(-1)^{2} + (2)^{2}} = \sqrt{5} \\
        ///      \| r(-1) \|_{L_\infty} &amp;= \max(|-1|,|2|) = 2
        ///  \f}
        ///  and for \f$r(0.5) = \begin{pmatrix} 0.5 \\ 0.5 \end{pmatrix}\f$ the calculation is
        ///  \f{align*}
        ///      \| r(0.5) \|_{L_1} &amp;= |0.5| + |0.5| = 1 \\
        ///      \| r(0.5) \|_{L_2} &amp;= \sqrt{(0.5)^{2} + (0.5)^{2}} = \sqrt{0.5} \\
        ///      \| r(0.5) \|_{L_\infty} &amp;= \max(|0.5|,|0.5|) = 0.5.
        ///  \f}
        ///  The following graphic shows all values for the three norm functions \f$\| r(x) \|_{L_1}, \| r(x) \|_{L_2}\f$ and \f$\| r(x) \|_{L_\infty}\f$.
        ///  It is notable that the \f$ L_{1} \f$ norm forms the upper and the \f$ L_{\infty} \f$ norm forms the lower border for the example function \f$ r(x) \f$.
        ///  ![Graphs for the different norm functions from the above example](pics/NormTypes_OneArray_1-2-INF.png)
        ///  
        ///  When the mask parameter is specified and it is not empty, the norm is
        ///  
        ///  If normType is not specified, #NORM_L2 is used.
        ///  calculated only over the region specified by the mask.
        ///  
        ///  Multi-channel input arrays are treated as single-channel arrays, that is,
        ///  the results for all channels are combined.
        ///  
        ///  Hamming norms can only be calculated with CV_8U depth arrays.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="normType">
        /// type of the norm (see #NormTypes).
        /// </param>
        /// <param name="mask">
        /// optional operation mask; it must have the same size as src1 and CV_8UC1 type.
        /// </param>
        public static double norm(Mat src1, int normType, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return core_Core_norm_10(src1.nativeObj, normType, mask.nativeObj);


        }

        /// <summary>
        ///  Calculates the  absolute norm of an array.
        /// </summary>
        /// <remarks>
        ///  This version of #norm calculates the absolute norm of src1. The type of norm to calculate is specified using #NormTypes.
        ///  
        ///  As example for one array consider the function \f$r(x)= \begin{pmatrix} x \\ 1-x \end{pmatrix}, x \in [-1;1]\f$.
        ///  The \f$ L_{1}, L_{2} \f$ and \f$ L_{\infty} \f$ norm for the sample value \f$r(-1) = \begin{pmatrix} -1 \\ 2 \end{pmatrix}\f$
        ///  is calculated as follows
        ///  \f{align*}
        ///      \| r(-1) \|_{L_1} &amp;= |-1| + |2| = 3 \\
        ///      \| r(-1) \|_{L_2} &amp;= \sqrt{(-1)^{2} + (2)^{2}} = \sqrt{5} \\
        ///      \| r(-1) \|_{L_\infty} &amp;= \max(|-1|,|2|) = 2
        ///  \f}
        ///  and for \f$r(0.5) = \begin{pmatrix} 0.5 \\ 0.5 \end{pmatrix}\f$ the calculation is
        ///  \f{align*}
        ///      \| r(0.5) \|_{L_1} &amp;= |0.5| + |0.5| = 1 \\
        ///      \| r(0.5) \|_{L_2} &amp;= \sqrt{(0.5)^{2} + (0.5)^{2}} = \sqrt{0.5} \\
        ///      \| r(0.5) \|_{L_\infty} &amp;= \max(|0.5|,|0.5|) = 0.5.
        ///  \f}
        ///  The following graphic shows all values for the three norm functions \f$\| r(x) \|_{L_1}, \| r(x) \|_{L_2}\f$ and \f$\| r(x) \|_{L_\infty}\f$.
        ///  It is notable that the \f$ L_{1} \f$ norm forms the upper and the \f$ L_{\infty} \f$ norm forms the lower border for the example function \f$ r(x) \f$.
        ///  ![Graphs for the different norm functions from the above example](pics/NormTypes_OneArray_1-2-INF.png)
        ///  
        ///  When the mask parameter is specified and it is not empty, the norm is
        ///  
        ///  If normType is not specified, #NORM_L2 is used.
        ///  calculated only over the region specified by the mask.
        ///  
        ///  Multi-channel input arrays are treated as single-channel arrays, that is,
        ///  the results for all channels are combined.
        ///  
        ///  Hamming norms can only be calculated with CV_8U depth arrays.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="normType">
        /// type of the norm (see #NormTypes).
        /// </param>
        /// <param name="mask">
        /// optional operation mask; it must have the same size as src1 and CV_8UC1 type.
        /// </param>
        public static double norm(Mat src1, int normType)
        {
            if (src1 != null) src1.ThrowIfDisposed();

            return core_Core_norm_11(src1.nativeObj, normType);


        }

        /// <summary>
        ///  Calculates the  absolute norm of an array.
        /// </summary>
        /// <remarks>
        ///  This version of #norm calculates the absolute norm of src1. The type of norm to calculate is specified using #NormTypes.
        ///  
        ///  As example for one array consider the function \f$r(x)= \begin{pmatrix} x \\ 1-x \end{pmatrix}, x \in [-1;1]\f$.
        ///  The \f$ L_{1}, L_{2} \f$ and \f$ L_{\infty} \f$ norm for the sample value \f$r(-1) = \begin{pmatrix} -1 \\ 2 \end{pmatrix}\f$
        ///  is calculated as follows
        ///  \f{align*}
        ///      \| r(-1) \|_{L_1} &amp;= |-1| + |2| = 3 \\
        ///      \| r(-1) \|_{L_2} &amp;= \sqrt{(-1)^{2} + (2)^{2}} = \sqrt{5} \\
        ///      \| r(-1) \|_{L_\infty} &amp;= \max(|-1|,|2|) = 2
        ///  \f}
        ///  and for \f$r(0.5) = \begin{pmatrix} 0.5 \\ 0.5 \end{pmatrix}\f$ the calculation is
        ///  \f{align*}
        ///      \| r(0.5) \|_{L_1} &amp;= |0.5| + |0.5| = 1 \\
        ///      \| r(0.5) \|_{L_2} &amp;= \sqrt{(0.5)^{2} + (0.5)^{2}} = \sqrt{0.5} \\
        ///      \| r(0.5) \|_{L_\infty} &amp;= \max(|0.5|,|0.5|) = 0.5.
        ///  \f}
        ///  The following graphic shows all values for the three norm functions \f$\| r(x) \|_{L_1}, \| r(x) \|_{L_2}\f$ and \f$\| r(x) \|_{L_\infty}\f$.
        ///  It is notable that the \f$ L_{1} \f$ norm forms the upper and the \f$ L_{\infty} \f$ norm forms the lower border for the example function \f$ r(x) \f$.
        ///  ![Graphs for the different norm functions from the above example](pics/NormTypes_OneArray_1-2-INF.png)
        ///  
        ///  When the mask parameter is specified and it is not empty, the norm is
        ///  
        ///  If normType is not specified, #NORM_L2 is used.
        ///  calculated only over the region specified by the mask.
        ///  
        ///  Multi-channel input arrays are treated as single-channel arrays, that is,
        ///  the results for all channels are combined.
        ///  
        ///  Hamming norms can only be calculated with CV_8U depth arrays.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="normType">
        /// type of the norm (see #NormTypes).
        /// </param>
        /// <param name="mask">
        /// optional operation mask; it must have the same size as src1 and CV_8UC1 type.
        /// </param>
        public static double norm(Mat src1)
        {
            if (src1 != null) src1.ThrowIfDisposed();

            return core_Core_norm_12(src1.nativeObj);


        }


        //
        // C++:  double cv::norm(Mat src1, Mat src2, int normType = NORM_L2, Mat mask = Mat())
        //

        /// <summary>
        ///  Calculates an absolute difference norm or a relative difference norm.
        /// </summary>
        /// <remarks>
        ///  This version of cv::norm calculates the absolute difference norm
        ///  or the relative difference norm of arrays src1 and src2.
        ///  The type of norm to calculate is specified using #NormTypes.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and the same type as src1.
        /// </param>
        /// <param name="normType">
        /// type of the norm (see #NormTypes).
        /// </param>
        /// <param name="mask">
        /// optional operation mask; it must have the same size as src1 and CV_8UC1 type.
        /// </param>
        public static double norm(Mat src1, Mat src2, int normType, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            return core_Core_norm_13(src1.nativeObj, src2.nativeObj, normType, mask.nativeObj);


        }

        /// <summary>
        ///  Calculates an absolute difference norm or a relative difference norm.
        /// </summary>
        /// <remarks>
        ///  This version of cv::norm calculates the absolute difference norm
        ///  or the relative difference norm of arrays src1 and src2.
        ///  The type of norm to calculate is specified using #NormTypes.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and the same type as src1.
        /// </param>
        /// <param name="normType">
        /// type of the norm (see #NormTypes).
        /// </param>
        /// <param name="mask">
        /// optional operation mask; it must have the same size as src1 and CV_8UC1 type.
        /// </param>
        public static double norm(Mat src1, Mat src2, int normType)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();

            return core_Core_norm_14(src1.nativeObj, src2.nativeObj, normType);


        }

        /// <summary>
        ///  Calculates an absolute difference norm or a relative difference norm.
        /// </summary>
        /// <remarks>
        ///  This version of cv::norm calculates the absolute difference norm
        ///  or the relative difference norm of arrays src1 and src2.
        ///  The type of norm to calculate is specified using #NormTypes.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and the same type as src1.
        /// </param>
        /// <param name="normType">
        /// type of the norm (see #NormTypes).
        /// </param>
        /// <param name="mask">
        /// optional operation mask; it must have the same size as src1 and CV_8UC1 type.
        /// </param>
        public static double norm(Mat src1, Mat src2)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();

            return core_Core_norm_15(src1.nativeObj, src2.nativeObj);


        }


        //
        // C++:  double cv::PSNR(Mat src1, Mat src2, double R = 255.)
        //

        /// <summary>
        ///  Computes the Peak Signal-to-Noise Ratio (PSNR) image quality metric.
        /// </summary>
        /// <remarks>
        ///  This function calculates the Peak Signal-to-Noise Ratio (PSNR) image quality metric in decibels (dB),
        ///  between two input arrays src1 and src2. The arrays must have the same type.
        ///  
        ///  The PSNR is calculated as follows:
        ///  
        ///  \f[
        ///  \texttt{PSNR} = 10 \cdot \log_{10}{\left( \frac{R^2}{MSE} \right) }
        ///  \f]
        ///  
        ///  where R is the maximum integer value of depth (e.g. 255 in the case of CV_8U data)
        ///  and MSE is the mean squared error between the two arrays.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size as src1.
        /// </param>
        /// <param name="R">
        /// the maximum pixel value (255 by default)
        /// </param>
        public static double PSNR(Mat src1, Mat src2, double R)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();

            return core_Core_PSNR_10(src1.nativeObj, src2.nativeObj, R);


        }

        /// <summary>
        ///  Computes the Peak Signal-to-Noise Ratio (PSNR) image quality metric.
        /// </summary>
        /// <remarks>
        ///  This function calculates the Peak Signal-to-Noise Ratio (PSNR) image quality metric in decibels (dB),
        ///  between two input arrays src1 and src2. The arrays must have the same type.
        ///  
        ///  The PSNR is calculated as follows:
        ///  
        ///  \f[
        ///  \texttt{PSNR} = 10 \cdot \log_{10}{\left( \frac{R^2}{MSE} \right) }
        ///  \f]
        ///  
        ///  where R is the maximum integer value of depth (e.g. 255 in the case of CV_8U data)
        ///  and MSE is the mean squared error between the two arrays.
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size as src1.
        /// </param>
        /// <param name="R">
        /// the maximum pixel value (255 by default)
        /// </param>
        public static double PSNR(Mat src1, Mat src2)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();

            return core_Core_PSNR_11(src1.nativeObj, src2.nativeObj);


        }


        //
        // C++:  void cv::batchDistance(Mat src1, Mat src2, Mat& dist, int dtype, Mat& nidx, int normType = NORM_L2, int K = 0, Mat mask = Mat(), int update = 0, bool crosscheck = false)
        //

        /// <summary>
        ///  naive nearest neighbor finder
        /// </summary>
        /// <remarks>
        ///  see http://en.wikipedia.org/wiki/Nearest_neighbor_search
        ///  @todo document
        /// </remarks>
        public static void batchDistance(Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType, int K, Mat mask, int update, bool crosscheck)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
            if (nidx != null) nidx.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_batchDistance_10(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType, K, mask.nativeObj, update, crosscheck);


        }

        /// <summary>
        ///  naive nearest neighbor finder
        /// </summary>
        /// <remarks>
        ///  see http://en.wikipedia.org/wiki/Nearest_neighbor_search
        ///  @todo document
        /// </remarks>
        public static void batchDistance(Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType, int K, Mat mask, int update)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
            if (nidx != null) nidx.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_batchDistance_11(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType, K, mask.nativeObj, update);


        }

        /// <summary>
        ///  naive nearest neighbor finder
        /// </summary>
        /// <remarks>
        ///  see http://en.wikipedia.org/wiki/Nearest_neighbor_search
        ///  @todo document
        /// </remarks>
        public static void batchDistance(Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType, int K, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
            if (nidx != null) nidx.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_batchDistance_12(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType, K, mask.nativeObj);


        }

        /// <summary>
        ///  naive nearest neighbor finder
        /// </summary>
        /// <remarks>
        ///  see http://en.wikipedia.org/wiki/Nearest_neighbor_search
        ///  @todo document
        /// </remarks>
        public static void batchDistance(Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType, int K)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
            if (nidx != null) nidx.ThrowIfDisposed();

            core_Core_batchDistance_13(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType, K);


        }

        /// <summary>
        ///  naive nearest neighbor finder
        /// </summary>
        /// <remarks>
        ///  see http://en.wikipedia.org/wiki/Nearest_neighbor_search
        ///  @todo document
        /// </remarks>
        public static void batchDistance(Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
            if (nidx != null) nidx.ThrowIfDisposed();

            core_Core_batchDistance_14(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType);


        }

        /// <summary>
        ///  naive nearest neighbor finder
        /// </summary>
        /// <remarks>
        ///  see http://en.wikipedia.org/wiki/Nearest_neighbor_search
        ///  @todo document
        /// </remarks>
        public static void batchDistance(Mat src1, Mat src2, Mat dist, int dtype, Mat nidx)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dist != null) dist.ThrowIfDisposed();
            if (nidx != null) nidx.ThrowIfDisposed();

            core_Core_batchDistance_15(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj);


        }


        //
        // C++:  void cv::normalize(Mat src, Mat& dst, double alpha = 1, double beta = 0, int norm_type = NORM_L2, int dtype = -1, Mat mask = Mat())
        //

        /// <summary>
        ///  Normalizes the norm or value range of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::normalize normalizes scale and shift the input array elements so that
        ///  \f[\| \texttt{dst} \| _{L_p}= \texttt{alpha}\f]
        ///  (where p=Inf, 1 or 2) when normType=NORM_INF, NORM_L1, or NORM_L2, respectively; or so that
        ///  \f[\min _I  \texttt{dst} (I)= \texttt{alpha} , \, \, \max _I  \texttt{dst} (I)= \texttt{beta}\f]
        ///  
        ///  when normType=NORM_MINMAX (for dense arrays only). The optional mask specifies a sub-array to be
        ///  normalized. This means that the norm or min-n-max are calculated over the sub-array, and then this
        ///  sub-array is modified to be normalized. If you want to only use the mask to calculate the norm or
        ///  min-max but modify the whole array, you can use norm and Mat::convertTo.
        ///  
        ///  In case of sparse matrices, only the non-zero values are analyzed and transformed. Because of this,
        ///  the range transformation for sparse matrices is not allowed since it can shift the zero level.
        ///  
        ///  Possible usage with some positive example data:
        /// </remarks>
        /// <code language="c++">
        ///      vector&lt;double&gt; positiveData = { 2.0, 8.0, 10.0 };
        ///      vector&lt;double&gt; normalizedData_l1, normalizedData_l2, normalizedData_inf, normalizedData_minmax;
        ///  
        ///      // Norm to probability (total count)
        ///      // sum(numbers) = 20.0
        ///      // 2.0      0.1     (2.0/20.0)
        ///      // 8.0      0.4     (8.0/20.0)
        ///      // 10.0     0.5     (10.0/20.0)
        ///      normalize(positiveData, normalizedData_l1, 1.0, 0.0, NORM_L1);
        ///  
        ///      // Norm to unit vector: ||positiveData|| = 1.0
        ///      // 2.0      0.15
        ///      // 8.0      0.62
        ///      // 10.0     0.77
        ///      normalize(positiveData, normalizedData_l2, 1.0, 0.0, NORM_L2);
        ///  
        ///      // Norm to max element
        ///      // 2.0      0.2     (2.0/10.0)
        ///      // 8.0      0.8     (8.0/10.0)
        ///      // 10.0     1.0     (10.0/10.0)
        ///      normalize(positiveData, normalizedData_inf, 1.0, 0.0, NORM_INF);
        ///  
        ///      // Norm to range [0.0;1.0]
        ///      // 2.0      0.0     (shift to left border)
        ///      // 8.0      0.75    (6.0/8.0)
        ///      // 10.0     1.0     (shift to right border)
        ///      normalize(positiveData, normalizedData_minmax, 1.0, 0.0, NORM_MINMAX);
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src .
        /// </param>
        /// <param name="alpha">
        /// norm value to normalize to or the lower range boundary in case of the range
        ///  normalization.
        /// </param>
        /// <param name="beta">
        /// upper range boundary in case of the range normalization; it is not used for the norm
        ///  normalization.
        /// </param>
        /// <param name="norm_type">
        /// normalization type (see cv::NormTypes).
        /// </param>
        /// <param name="dtype">
        /// when negative, the output array has the same type as src; otherwise, it has the same
        ///  number of channels as src and the depth =CV_MAT_DEPTH(dtype).
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa norm, Mat::convertTo, SparseMat::convertTo
        /// </param>
        public static void normalize(Mat src, Mat dst, double alpha, double beta, int norm_type, int dtype, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_normalize_10(src.nativeObj, dst.nativeObj, alpha, beta, norm_type, dtype, mask.nativeObj);


        }

        /// <summary>
        ///  Normalizes the norm or value range of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::normalize normalizes scale and shift the input array elements so that
        ///  \f[\| \texttt{dst} \| _{L_p}= \texttt{alpha}\f]
        ///  (where p=Inf, 1 or 2) when normType=NORM_INF, NORM_L1, or NORM_L2, respectively; or so that
        ///  \f[\min _I  \texttt{dst} (I)= \texttt{alpha} , \, \, \max _I  \texttt{dst} (I)= \texttt{beta}\f]
        ///  
        ///  when normType=NORM_MINMAX (for dense arrays only). The optional mask specifies a sub-array to be
        ///  normalized. This means that the norm or min-n-max are calculated over the sub-array, and then this
        ///  sub-array is modified to be normalized. If you want to only use the mask to calculate the norm or
        ///  min-max but modify the whole array, you can use norm and Mat::convertTo.
        ///  
        ///  In case of sparse matrices, only the non-zero values are analyzed and transformed. Because of this,
        ///  the range transformation for sparse matrices is not allowed since it can shift the zero level.
        ///  
        ///  Possible usage with some positive example data:
        /// </remarks>
        /// <code language="c++">
        ///      vector&lt;double&gt; positiveData = { 2.0, 8.0, 10.0 };
        ///      vector&lt;double&gt; normalizedData_l1, normalizedData_l2, normalizedData_inf, normalizedData_minmax;
        ///  
        ///      // Norm to probability (total count)
        ///      // sum(numbers) = 20.0
        ///      // 2.0      0.1     (2.0/20.0)
        ///      // 8.0      0.4     (8.0/20.0)
        ///      // 10.0     0.5     (10.0/20.0)
        ///      normalize(positiveData, normalizedData_l1, 1.0, 0.0, NORM_L1);
        ///  
        ///      // Norm to unit vector: ||positiveData|| = 1.0
        ///      // 2.0      0.15
        ///      // 8.0      0.62
        ///      // 10.0     0.77
        ///      normalize(positiveData, normalizedData_l2, 1.0, 0.0, NORM_L2);
        ///  
        ///      // Norm to max element
        ///      // 2.0      0.2     (2.0/10.0)
        ///      // 8.0      0.8     (8.0/10.0)
        ///      // 10.0     1.0     (10.0/10.0)
        ///      normalize(positiveData, normalizedData_inf, 1.0, 0.0, NORM_INF);
        ///  
        ///      // Norm to range [0.0;1.0]
        ///      // 2.0      0.0     (shift to left border)
        ///      // 8.0      0.75    (6.0/8.0)
        ///      // 10.0     1.0     (shift to right border)
        ///      normalize(positiveData, normalizedData_minmax, 1.0, 0.0, NORM_MINMAX);
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src .
        /// </param>
        /// <param name="alpha">
        /// norm value to normalize to or the lower range boundary in case of the range
        ///  normalization.
        /// </param>
        /// <param name="beta">
        /// upper range boundary in case of the range normalization; it is not used for the norm
        ///  normalization.
        /// </param>
        /// <param name="norm_type">
        /// normalization type (see cv::NormTypes).
        /// </param>
        /// <param name="dtype">
        /// when negative, the output array has the same type as src; otherwise, it has the same
        ///  number of channels as src and the depth =CV_MAT_DEPTH(dtype).
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa norm, Mat::convertTo, SparseMat::convertTo
        /// </param>
        public static void normalize(Mat src, Mat dst, double alpha, double beta, int norm_type, int dtype)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_normalize_11(src.nativeObj, dst.nativeObj, alpha, beta, norm_type, dtype);


        }

        /// <summary>
        ///  Normalizes the norm or value range of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::normalize normalizes scale and shift the input array elements so that
        ///  \f[\| \texttt{dst} \| _{L_p}= \texttt{alpha}\f]
        ///  (where p=Inf, 1 or 2) when normType=NORM_INF, NORM_L1, or NORM_L2, respectively; or so that
        ///  \f[\min _I  \texttt{dst} (I)= \texttt{alpha} , \, \, \max _I  \texttt{dst} (I)= \texttt{beta}\f]
        ///  
        ///  when normType=NORM_MINMAX (for dense arrays only). The optional mask specifies a sub-array to be
        ///  normalized. This means that the norm or min-n-max are calculated over the sub-array, and then this
        ///  sub-array is modified to be normalized. If you want to only use the mask to calculate the norm or
        ///  min-max but modify the whole array, you can use norm and Mat::convertTo.
        ///  
        ///  In case of sparse matrices, only the non-zero values are analyzed and transformed. Because of this,
        ///  the range transformation for sparse matrices is not allowed since it can shift the zero level.
        ///  
        ///  Possible usage with some positive example data:
        /// </remarks>
        /// <code language="c++">
        ///      vector&lt;double&gt; positiveData = { 2.0, 8.0, 10.0 };
        ///      vector&lt;double&gt; normalizedData_l1, normalizedData_l2, normalizedData_inf, normalizedData_minmax;
        ///  
        ///      // Norm to probability (total count)
        ///      // sum(numbers) = 20.0
        ///      // 2.0      0.1     (2.0/20.0)
        ///      // 8.0      0.4     (8.0/20.0)
        ///      // 10.0     0.5     (10.0/20.0)
        ///      normalize(positiveData, normalizedData_l1, 1.0, 0.0, NORM_L1);
        ///  
        ///      // Norm to unit vector: ||positiveData|| = 1.0
        ///      // 2.0      0.15
        ///      // 8.0      0.62
        ///      // 10.0     0.77
        ///      normalize(positiveData, normalizedData_l2, 1.0, 0.0, NORM_L2);
        ///  
        ///      // Norm to max element
        ///      // 2.0      0.2     (2.0/10.0)
        ///      // 8.0      0.8     (8.0/10.0)
        ///      // 10.0     1.0     (10.0/10.0)
        ///      normalize(positiveData, normalizedData_inf, 1.0, 0.0, NORM_INF);
        ///  
        ///      // Norm to range [0.0;1.0]
        ///      // 2.0      0.0     (shift to left border)
        ///      // 8.0      0.75    (6.0/8.0)
        ///      // 10.0     1.0     (shift to right border)
        ///      normalize(positiveData, normalizedData_minmax, 1.0, 0.0, NORM_MINMAX);
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src .
        /// </param>
        /// <param name="alpha">
        /// norm value to normalize to or the lower range boundary in case of the range
        ///  normalization.
        /// </param>
        /// <param name="beta">
        /// upper range boundary in case of the range normalization; it is not used for the norm
        ///  normalization.
        /// </param>
        /// <param name="norm_type">
        /// normalization type (see cv::NormTypes).
        /// </param>
        /// <param name="dtype">
        /// when negative, the output array has the same type as src; otherwise, it has the same
        ///  number of channels as src and the depth =CV_MAT_DEPTH(dtype).
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa norm, Mat::convertTo, SparseMat::convertTo
        /// </param>
        public static void normalize(Mat src, Mat dst, double alpha, double beta, int norm_type)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_normalize_12(src.nativeObj, dst.nativeObj, alpha, beta, norm_type);


        }

        /// <summary>
        ///  Normalizes the norm or value range of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::normalize normalizes scale and shift the input array elements so that
        ///  \f[\| \texttt{dst} \| _{L_p}= \texttt{alpha}\f]
        ///  (where p=Inf, 1 or 2) when normType=NORM_INF, NORM_L1, or NORM_L2, respectively; or so that
        ///  \f[\min _I  \texttt{dst} (I)= \texttt{alpha} , \, \, \max _I  \texttt{dst} (I)= \texttt{beta}\f]
        ///  
        ///  when normType=NORM_MINMAX (for dense arrays only). The optional mask specifies a sub-array to be
        ///  normalized. This means that the norm or min-n-max are calculated over the sub-array, and then this
        ///  sub-array is modified to be normalized. If you want to only use the mask to calculate the norm or
        ///  min-max but modify the whole array, you can use norm and Mat::convertTo.
        ///  
        ///  In case of sparse matrices, only the non-zero values are analyzed and transformed. Because of this,
        ///  the range transformation for sparse matrices is not allowed since it can shift the zero level.
        ///  
        ///  Possible usage with some positive example data:
        /// </remarks>
        /// <code language="c++">
        ///      vector&lt;double&gt; positiveData = { 2.0, 8.0, 10.0 };
        ///      vector&lt;double&gt; normalizedData_l1, normalizedData_l2, normalizedData_inf, normalizedData_minmax;
        ///  
        ///      // Norm to probability (total count)
        ///      // sum(numbers) = 20.0
        ///      // 2.0      0.1     (2.0/20.0)
        ///      // 8.0      0.4     (8.0/20.0)
        ///      // 10.0     0.5     (10.0/20.0)
        ///      normalize(positiveData, normalizedData_l1, 1.0, 0.0, NORM_L1);
        ///  
        ///      // Norm to unit vector: ||positiveData|| = 1.0
        ///      // 2.0      0.15
        ///      // 8.0      0.62
        ///      // 10.0     0.77
        ///      normalize(positiveData, normalizedData_l2, 1.0, 0.0, NORM_L2);
        ///  
        ///      // Norm to max element
        ///      // 2.0      0.2     (2.0/10.0)
        ///      // 8.0      0.8     (8.0/10.0)
        ///      // 10.0     1.0     (10.0/10.0)
        ///      normalize(positiveData, normalizedData_inf, 1.0, 0.0, NORM_INF);
        ///  
        ///      // Norm to range [0.0;1.0]
        ///      // 2.0      0.0     (shift to left border)
        ///      // 8.0      0.75    (6.0/8.0)
        ///      // 10.0     1.0     (shift to right border)
        ///      normalize(positiveData, normalizedData_minmax, 1.0, 0.0, NORM_MINMAX);
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src .
        /// </param>
        /// <param name="alpha">
        /// norm value to normalize to or the lower range boundary in case of the range
        ///  normalization.
        /// </param>
        /// <param name="beta">
        /// upper range boundary in case of the range normalization; it is not used for the norm
        ///  normalization.
        /// </param>
        /// <param name="norm_type">
        /// normalization type (see cv::NormTypes).
        /// </param>
        /// <param name="dtype">
        /// when negative, the output array has the same type as src; otherwise, it has the same
        ///  number of channels as src and the depth =CV_MAT_DEPTH(dtype).
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa norm, Mat::convertTo, SparseMat::convertTo
        /// </param>
        public static void normalize(Mat src, Mat dst, double alpha, double beta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_normalize_13(src.nativeObj, dst.nativeObj, alpha, beta);


        }

        /// <summary>
        ///  Normalizes the norm or value range of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::normalize normalizes scale and shift the input array elements so that
        ///  \f[\| \texttt{dst} \| _{L_p}= \texttt{alpha}\f]
        ///  (where p=Inf, 1 or 2) when normType=NORM_INF, NORM_L1, or NORM_L2, respectively; or so that
        ///  \f[\min _I  \texttt{dst} (I)= \texttt{alpha} , \, \, \max _I  \texttt{dst} (I)= \texttt{beta}\f]
        ///  
        ///  when normType=NORM_MINMAX (for dense arrays only). The optional mask specifies a sub-array to be
        ///  normalized. This means that the norm or min-n-max are calculated over the sub-array, and then this
        ///  sub-array is modified to be normalized. If you want to only use the mask to calculate the norm or
        ///  min-max but modify the whole array, you can use norm and Mat::convertTo.
        ///  
        ///  In case of sparse matrices, only the non-zero values are analyzed and transformed. Because of this,
        ///  the range transformation for sparse matrices is not allowed since it can shift the zero level.
        ///  
        ///  Possible usage with some positive example data:
        /// </remarks>
        /// <code language="c++">
        ///      vector&lt;double&gt; positiveData = { 2.0, 8.0, 10.0 };
        ///      vector&lt;double&gt; normalizedData_l1, normalizedData_l2, normalizedData_inf, normalizedData_minmax;
        ///  
        ///      // Norm to probability (total count)
        ///      // sum(numbers) = 20.0
        ///      // 2.0      0.1     (2.0/20.0)
        ///      // 8.0      0.4     (8.0/20.0)
        ///      // 10.0     0.5     (10.0/20.0)
        ///      normalize(positiveData, normalizedData_l1, 1.0, 0.0, NORM_L1);
        ///  
        ///      // Norm to unit vector: ||positiveData|| = 1.0
        ///      // 2.0      0.15
        ///      // 8.0      0.62
        ///      // 10.0     0.77
        ///      normalize(positiveData, normalizedData_l2, 1.0, 0.0, NORM_L2);
        ///  
        ///      // Norm to max element
        ///      // 2.0      0.2     (2.0/10.0)
        ///      // 8.0      0.8     (8.0/10.0)
        ///      // 10.0     1.0     (10.0/10.0)
        ///      normalize(positiveData, normalizedData_inf, 1.0, 0.0, NORM_INF);
        ///  
        ///      // Norm to range [0.0;1.0]
        ///      // 2.0      0.0     (shift to left border)
        ///      // 8.0      0.75    (6.0/8.0)
        ///      // 10.0     1.0     (shift to right border)
        ///      normalize(positiveData, normalizedData_minmax, 1.0, 0.0, NORM_MINMAX);
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src .
        /// </param>
        /// <param name="alpha">
        /// norm value to normalize to or the lower range boundary in case of the range
        ///  normalization.
        /// </param>
        /// <param name="beta">
        /// upper range boundary in case of the range normalization; it is not used for the norm
        ///  normalization.
        /// </param>
        /// <param name="norm_type">
        /// normalization type (see cv::NormTypes).
        /// </param>
        /// <param name="dtype">
        /// when negative, the output array has the same type as src; otherwise, it has the same
        ///  number of channels as src and the depth =CV_MAT_DEPTH(dtype).
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa norm, Mat::convertTo, SparseMat::convertTo
        /// </param>
        public static void normalize(Mat src, Mat dst, double alpha)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_normalize_14(src.nativeObj, dst.nativeObj, alpha);


        }

        /// <summary>
        ///  Normalizes the norm or value range of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::normalize normalizes scale and shift the input array elements so that
        ///  \f[\| \texttt{dst} \| _{L_p}= \texttt{alpha}\f]
        ///  (where p=Inf, 1 or 2) when normType=NORM_INF, NORM_L1, or NORM_L2, respectively; or so that
        ///  \f[\min _I  \texttt{dst} (I)= \texttt{alpha} , \, \, \max _I  \texttt{dst} (I)= \texttt{beta}\f]
        ///  
        ///  when normType=NORM_MINMAX (for dense arrays only). The optional mask specifies a sub-array to be
        ///  normalized. This means that the norm or min-n-max are calculated over the sub-array, and then this
        ///  sub-array is modified to be normalized. If you want to only use the mask to calculate the norm or
        ///  min-max but modify the whole array, you can use norm and Mat::convertTo.
        ///  
        ///  In case of sparse matrices, only the non-zero values are analyzed and transformed. Because of this,
        ///  the range transformation for sparse matrices is not allowed since it can shift the zero level.
        ///  
        ///  Possible usage with some positive example data:
        /// </remarks>
        /// <code language="c++">
        ///      vector&lt;double&gt; positiveData = { 2.0, 8.0, 10.0 };
        ///      vector&lt;double&gt; normalizedData_l1, normalizedData_l2, normalizedData_inf, normalizedData_minmax;
        ///  
        ///      // Norm to probability (total count)
        ///      // sum(numbers) = 20.0
        ///      // 2.0      0.1     (2.0/20.0)
        ///      // 8.0      0.4     (8.0/20.0)
        ///      // 10.0     0.5     (10.0/20.0)
        ///      normalize(positiveData, normalizedData_l1, 1.0, 0.0, NORM_L1);
        ///  
        ///      // Norm to unit vector: ||positiveData|| = 1.0
        ///      // 2.0      0.15
        ///      // 8.0      0.62
        ///      // 10.0     0.77
        ///      normalize(positiveData, normalizedData_l2, 1.0, 0.0, NORM_L2);
        ///  
        ///      // Norm to max element
        ///      // 2.0      0.2     (2.0/10.0)
        ///      // 8.0      0.8     (8.0/10.0)
        ///      // 10.0     1.0     (10.0/10.0)
        ///      normalize(positiveData, normalizedData_inf, 1.0, 0.0, NORM_INF);
        ///  
        ///      // Norm to range [0.0;1.0]
        ///      // 2.0      0.0     (shift to left border)
        ///      // 8.0      0.75    (6.0/8.0)
        ///      // 10.0     1.0     (shift to right border)
        ///      normalize(positiveData, normalizedData_minmax, 1.0, 0.0, NORM_MINMAX);
        /// </code>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src .
        /// </param>
        /// <param name="alpha">
        /// norm value to normalize to or the lower range boundary in case of the range
        ///  normalization.
        /// </param>
        /// <param name="beta">
        /// upper range boundary in case of the range normalization; it is not used for the norm
        ///  normalization.
        /// </param>
        /// <param name="norm_type">
        /// normalization type (see cv::NormTypes).
        /// </param>
        /// <param name="dtype">
        /// when negative, the output array has the same type as src; otherwise, it has the same
        ///  number of channels as src and the depth =CV_MAT_DEPTH(dtype).
        /// </param>
        /// <param name="mask">
        /// optional operation mask.
        ///  @sa norm, Mat::convertTo, SparseMat::convertTo
        /// </param>
        public static void normalize(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_normalize_15(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::reduceArgMin(Mat src, Mat& dst, int axis, bool lastIndex = false)
        //

        /// <summary>
        ///  Finds indices of min elements along provided axis
        /// </summary>
        /// <remarks>
        ///     @note
        ///          - If input or output array is not continuous, this function will create an internal copy.
        ///          - NaN handling is left unspecified, see patchNaNs().
        ///          - The returned index is always in bounds of input matrix.
        /// </remarks>
        /// <param name="src">
        /// input single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of type CV_32SC1 with the same dimensionality as src,
        ///     except for axis being reduced - it should be set to 1.
        /// </param>
        /// <param name="lastIndex">
        /// whether to get the index of first or last occurrence of min.
        /// </param>
        /// <param name="axis">
        /// axis to reduce along.
        ///     @sa reduceArgMax, minMaxLoc, min, max, compare, reduce
        /// </param>
        public static void reduceArgMin(Mat src, Mat dst, int axis, bool lastIndex)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_reduceArgMin_10(src.nativeObj, dst.nativeObj, axis, lastIndex);


        }

        /// <summary>
        ///  Finds indices of min elements along provided axis
        /// </summary>
        /// <remarks>
        ///     @note
        ///          - If input or output array is not continuous, this function will create an internal copy.
        ///          - NaN handling is left unspecified, see patchNaNs().
        ///          - The returned index is always in bounds of input matrix.
        /// </remarks>
        /// <param name="src">
        /// input single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of type CV_32SC1 with the same dimensionality as src,
        ///     except for axis being reduced - it should be set to 1.
        /// </param>
        /// <param name="lastIndex">
        /// whether to get the index of first or last occurrence of min.
        /// </param>
        /// <param name="axis">
        /// axis to reduce along.
        ///     @sa reduceArgMax, minMaxLoc, min, max, compare, reduce
        /// </param>
        public static void reduceArgMin(Mat src, Mat dst, int axis)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_reduceArgMin_11(src.nativeObj, dst.nativeObj, axis);


        }


        //
        // C++:  void cv::reduceArgMax(Mat src, Mat& dst, int axis, bool lastIndex = false)
        //

        /// <summary>
        ///  Finds indices of max elements along provided axis
        /// </summary>
        /// <remarks>
        ///     @note
        ///          - If input or output array is not continuous, this function will create an internal copy.
        ///          - NaN handling is left unspecified, see patchNaNs().
        ///          - The returned index is always in bounds of input matrix.
        /// </remarks>
        /// <param name="src">
        /// input single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of type CV_32SC1 with the same dimensionality as src,
        ///     except for axis being reduced - it should be set to 1.
        /// </param>
        /// <param name="lastIndex">
        /// whether to get the index of first or last occurrence of max.
        /// </param>
        /// <param name="axis">
        /// axis to reduce along.
        ///     @sa reduceArgMin, minMaxLoc, min, max, compare, reduce
        /// </param>
        public static void reduceArgMax(Mat src, Mat dst, int axis, bool lastIndex)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_reduceArgMax_10(src.nativeObj, dst.nativeObj, axis, lastIndex);


        }

        /// <summary>
        ///  Finds indices of max elements along provided axis
        /// </summary>
        /// <remarks>
        ///     @note
        ///          - If input or output array is not continuous, this function will create an internal copy.
        ///          - NaN handling is left unspecified, see patchNaNs().
        ///          - The returned index is always in bounds of input matrix.
        /// </remarks>
        /// <param name="src">
        /// input single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of type CV_32SC1 with the same dimensionality as src,
        ///     except for axis being reduced - it should be set to 1.
        /// </param>
        /// <param name="lastIndex">
        /// whether to get the index of first or last occurrence of max.
        /// </param>
        /// <param name="axis">
        /// axis to reduce along.
        ///     @sa reduceArgMin, minMaxLoc, min, max, compare, reduce
        /// </param>
        public static void reduceArgMax(Mat src, Mat dst, int axis)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_reduceArgMax_11(src.nativeObj, dst.nativeObj, axis);


        }


        //
        // C++:  void cv::reduce(Mat src, Mat& dst, int dim, int rtype, int dtype = -1)
        //

        /// <summary>
        ///  Reduces a matrix to a vector.
        /// </summary>
        /// <remarks>
        ///  The function #reduce reduces the matrix to a vector by treating the matrix rows/columns as a set of
        ///  1D vectors and performing the specified operation on the vectors until a single row/column is
        ///  obtained. For example, the function can be used to compute horizontal and vertical projections of a
        ///  raster image. In case of #REDUCE_MAX and #REDUCE_MIN, the output image should have the same type as the source one.
        ///  In case of #REDUCE_SUM, #REDUCE_SUM2 and #REDUCE_AVG, the output may have a larger element bit-depth to preserve accuracy.
        ///  And multi-channel arrays are also supported in these two reduction modes.
        ///  
        ///  The following code demonstrates its usage for a single channel matrix.
        ///  @snippet snippets/core_reduce.cpp example
        ///  
        ///  And the following code demonstrates its usage for a two-channel matrix.
        ///  @snippet snippets/core_reduce.cpp example2
        /// </remarks>
        /// <param name="src">
        /// input 2D matrix.
        /// </param>
        /// <param name="dst">
        /// output vector. Its size and type is defined by dim and dtype parameters.
        /// </param>
        /// <param name="dim">
        /// dimension index along which the matrix is reduced. 0 means that the matrix is reduced to
        ///  a single row. 1 means that the matrix is reduced to a single column.
        /// </param>
        /// <param name="rtype">
        /// reduction operation that could be one of #ReduceTypes
        /// </param>
        /// <param name="dtype">
        /// when negative, the output vector will have the same type as the input matrix,
        ///  otherwise, its type will be CV_MAKE_TYPE(CV_MAT_DEPTH(dtype), src.channels()).
        ///  @sa repeat, reduceArgMin, reduceArgMax
        /// </param>
        public static void reduce(Mat src, Mat dst, int dim, int rtype, int dtype)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_reduce_10(src.nativeObj, dst.nativeObj, dim, rtype, dtype);


        }

        /// <summary>
        ///  Reduces a matrix to a vector.
        /// </summary>
        /// <remarks>
        ///  The function #reduce reduces the matrix to a vector by treating the matrix rows/columns as a set of
        ///  1D vectors and performing the specified operation on the vectors until a single row/column is
        ///  obtained. For example, the function can be used to compute horizontal and vertical projections of a
        ///  raster image. In case of #REDUCE_MAX and #REDUCE_MIN, the output image should have the same type as the source one.
        ///  In case of #REDUCE_SUM, #REDUCE_SUM2 and #REDUCE_AVG, the output may have a larger element bit-depth to preserve accuracy.
        ///  And multi-channel arrays are also supported in these two reduction modes.
        ///  
        ///  The following code demonstrates its usage for a single channel matrix.
        ///  @snippet snippets/core_reduce.cpp example
        ///  
        ///  And the following code demonstrates its usage for a two-channel matrix.
        ///  @snippet snippets/core_reduce.cpp example2
        /// </remarks>
        /// <param name="src">
        /// input 2D matrix.
        /// </param>
        /// <param name="dst">
        /// output vector. Its size and type is defined by dim and dtype parameters.
        /// </param>
        /// <param name="dim">
        /// dimension index along which the matrix is reduced. 0 means that the matrix is reduced to
        ///  a single row. 1 means that the matrix is reduced to a single column.
        /// </param>
        /// <param name="rtype">
        /// reduction operation that could be one of #ReduceTypes
        /// </param>
        /// <param name="dtype">
        /// when negative, the output vector will have the same type as the input matrix,
        ///  otherwise, its type will be CV_MAKE_TYPE(CV_MAT_DEPTH(dtype), src.channels()).
        ///  @sa repeat, reduceArgMin, reduceArgMax
        /// </param>
        public static void reduce(Mat src, Mat dst, int dim, int rtype)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_reduce_11(src.nativeObj, dst.nativeObj, dim, rtype);


        }


        //
        // C++:  void cv::merge(vector_Mat mv, Mat& dst)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="mv">
        /// input vector of matrices to be merged; all the matrices in mv must have the same
        ///  size and the same depth.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and the same depth as mv[0]; The number of channels will
        ///  be the total number of channels in the matrix array.
        /// </param>
        public static void merge(List<Mat> mv, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat mv_mat = Converters.vector_Mat_to_Mat(mv);
            core_Core_merge_10(mv_mat.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::split(Mat m, vector_Mat& mv)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="m">
        /// input multi-channel array.
        /// </param>
        /// <param name="mv">
        /// output vector of arrays; the arrays themselves are reallocated, if needed.
        /// </param>
        public static void split(Mat m, List<Mat> mv)
        {
            if (m != null) m.ThrowIfDisposed();
            Mat mv_mat = new Mat();
            core_Core_split_10(m.nativeObj, mv_mat.nativeObj);
            Converters.Mat_to_vector_Mat(mv_mat, mv);
            mv_mat.release();

        }


        //
        // C++:  void cv::mixChannels(vector_Mat src, vector_Mat dst, vector_int fromTo)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <param name="src">
        /// input array or vector of matrices; all of the matrices must have the same size and the
        ///  same depth.
        /// </param>
        /// <param name="dst">
        /// output array or vector of matrices; all the matrices **must be allocated**; their size and
        ///  depth must be the same as in src[0].
        /// </param>
        /// <param name="fromTo">
        /// array of index pairs specifying which channels are copied and where; fromTo[k\*2] is
        ///  a 0-based index of the input channel in src, fromTo[k\*2+1] is an index of the output channel in
        ///  dst; the continuous channel numbering is used: the first input image channels are indexed from 0 to
        ///  src[0].channels()-1, the second input image channels are indexed from src[0].channels() to
        ///  src[0].channels() + src[1].channels()-1, and so on, the same scheme is used for the output image
        ///  channels; as a special case, when fromTo[k\*2] is negative, the corresponding output channel is
        ///  filled with zero .
        /// </param>
        public static void mixChannels(List<Mat> src, List<Mat> dst, MatOfInt fromTo)
        {
            if (fromTo != null) fromTo.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
            Mat fromTo_mat = fromTo;
            core_Core_mixChannels_10(src_mat.nativeObj, dst_mat.nativeObj, fromTo_mat.nativeObj);


        }


        //
        // C++:  void cv::extractChannel(Mat src, Mat& dst, int coi)
        //

        /// <summary>
        ///  Extracts a single channel from src (coi is 0-based index)
        /// </summary>
        /// <param name="src">
        /// input array
        /// </param>
        /// <param name="dst">
        /// output array
        /// </param>
        /// <param name="coi">
        /// index of channel to extract
        ///  @sa mixChannels, split
        /// </param>
        public static void extractChannel(Mat src, Mat dst, int coi)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_extractChannel_10(src.nativeObj, dst.nativeObj, coi);


        }


        //
        // C++:  void cv::insertChannel(Mat src, Mat& dst, int coi)
        //

        /// <summary>
        ///  Inserts a single channel to dst (coi is 0-based index)
        /// </summary>
        /// <param name="src">
        /// input array
        /// </param>
        /// <param name="dst">
        /// output array
        /// </param>
        /// <param name="coi">
        /// index of channel for insertion
        ///  @sa mixChannels, merge
        /// </param>
        public static void insertChannel(Mat src, Mat dst, int coi)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_insertChannel_10(src.nativeObj, dst.nativeObj, coi);


        }


        //
        // C++:  void cv::flip(Mat src, Mat& dst, int flipCode)
        //

        /// <summary>
        ///  Flips a 2D array around vertical, horizontal, or both axes.
        /// </summary>
        /// <remarks>
        ///  The function cv::flip flips the array in one of three different ways (row
        ///  and column indices are 0-based):
        ///  \f[\texttt{dst} _{ij} =
        ///  \left\{
        ///  \begin{array}{l l}
        ///  \texttt{src} _{\texttt{src.rows}-i-1,j} &amp; if\;  \texttt{flipCode} = 0 \\
        ///  \texttt{src} _{i, \texttt{src.cols} -j-1} &amp; if\;  \texttt{flipCode} &gt; 0 \\
        ///  \texttt{src} _{ \texttt{src.rows} -i-1, \texttt{src.cols} -j-1} &amp; if\; \texttt{flipCode} &lt; 0 \\
        ///  \end{array}
        ///  \right.\f]
        ///  The example scenarios of using the function are the following:
        ///      Vertical flipping of the image (flipCode == 0) to switch between
        ///      top-left and bottom-left image origin. This is a typical operation
        ///      in video processing on Microsoft Windows\* OS.
        ///      Horizontal flipping of the image with the subsequent horizontal
        ///      shift and absolute difference calculation to check for a
        ///      vertical-axis symmetry (flipCode &gt; 0).
        ///      Simultaneous horizontal and vertical flipping of the image with
        ///      the subsequent shift and absolute difference calculation to check
        ///      for a central symmetry (flipCode &lt; 0).
        ///      Reversing the order of point arrays (flipCode &gt; 0 or
        ///      flipCode == 0).
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        /// </param>
        /// <param name="flipCode">
        /// a flag to specify how to flip the array; 0 means
        ///  flipping around the x-axis and positive value (for example, 1) means
        ///  flipping around y-axis. Negative value (for example, -1) means flipping
        ///  around both axes.
        ///  @sa transpose, repeat, completeSymm
        /// </param>
        public static void flip(Mat src, Mat dst, int flipCode)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_flip_10(src.nativeObj, dst.nativeObj, flipCode);


        }


        //
        // C++:  void cv::flipND(Mat src, Mat& dst, int axis)
        //

        /// <summary>
        ///  Flips a n-dimensional at given axis
        /// </summary>
        /// <param name="src">
        /// input array
        /// </param>
        /// <param name="dst">
        /// output array that has the same shape of src
        /// </param>
        /// <param name="axis">
        /// axis that performs a flip on. 0 &lt;= axis &lt; src.dims.
        /// </param>
        public static void flipND(Mat src, Mat dst, int axis)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_flipND_10(src.nativeObj, dst.nativeObj, axis);


        }


        //
        // C++:  void cv::broadcast(Mat src, Mat shape, Mat& dst)
        //

        /// <summary>
        ///  Broadcast the given Mat to the given shape.
        /// </summary>
        /// <param name="src">
        /// input array
        /// </param>
        /// <param name="shape">
        /// target shape. Should be a list of CV_32S numbers. Note that negative values are not supported.
        /// </param>
        /// <param name="dst">
        /// output array that has the given shape
        /// </param>
        public static void broadcast(Mat src, Mat shape, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (shape != null) shape.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_broadcast_10(src.nativeObj, shape.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::rotate(Mat src, Mat& dst, int rotateCode)
        //

        /// <summary>
        ///  Rotates a 2D array in multiples of 90 degrees.
        ///  The function cv::rotate rotates the array in one of three different ways:
        ///      Rotate by 90 degrees clockwise (rotateCode = ROTATE_90_CLOCKWISE).
        ///      Rotate by 180 degrees clockwise (rotateCode = ROTATE_180).
        ///      Rotate by 270 degrees clockwise (rotateCode = ROTATE_90_COUNTERCLOCKWISE).
        /// </summary>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same type as src.  The size is the same with ROTATE_180,
        ///  and the rows and cols are switched for ROTATE_90_CLOCKWISE and ROTATE_90_COUNTERCLOCKWISE.
        /// </param>
        /// <param name="rotateCode">
        /// an enum to specify how to rotate the array; see the enum #RotateFlags
        ///  @sa transpose, repeat, completeSymm, flip, RotateFlags
        /// </param>
        public static void rotate(Mat src, Mat dst, int rotateCode)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_rotate_10(src.nativeObj, dst.nativeObj, rotateCode);


        }


        //
        // C++:  void cv::repeat(Mat src, int ny, int nx, Mat& dst)
        //

        /// <summary>
        ///  Fills the output array with repeated copies of the input array.
        /// </summary>
        /// <remarks>
        ///  The function cv::repeat duplicates the input array one or more times along each of the two axes:
        ///  \f[\texttt{dst} _{ij}= \texttt{src} _{i\mod src.rows, \; j\mod src.cols }\f]
        ///  The second variant of the function is more convenient to use with @ref MatrixExpressions.
        /// </remarks>
        /// <param name="src">
        /// input array to replicate.
        /// </param>
        /// <param name="ny">
        /// Flag to specify how many times the `src` is repeated along the
        ///  vertical axis.
        /// </param>
        /// <param name="nx">
        /// Flag to specify how many times the `src` is repeated along the
        ///  horizontal axis.
        /// </param>
        /// <param name="dst">
        /// output array of the same type as `src`.
        ///  @sa cv::reduce
        /// </param>
        public static void repeat(Mat src, int ny, int nx, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_repeat_10(src.nativeObj, ny, nx, dst.nativeObj);


        }


        //
        // C++:  void cv::hconcat(vector_Mat src, Mat& dst)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <code language="c++">
        ///      std::vector&lt;cv::Mat&gt; matrices = { cv::Mat(4, 1, CV_8UC1, cv::Scalar(1)),
        ///                                        cv::Mat(4, 1, CV_8UC1, cv::Scalar(2)),
        ///                                        cv::Mat(4, 1, CV_8UC1, cv::Scalar(3)),};
        ///  
        ///      cv::Mat out;
        ///      cv::hconcat( matrices, out );
        ///      //out:
        ///      //[1, 2, 3;
        ///      // 1, 2, 3;
        ///      // 1, 2, 3;
        ///      // 1, 2, 3]
        /// </code>
        /// <param name="src">
        /// input array or vector of matrices. all of the matrices must have the same number of rows and the same depth.
        /// </param>
        /// <param name="dst">
        /// output array. It has the same number of rows and depth as the src, and the sum of cols of the src.
        ///  same depth.
        /// </param>
        public static void hconcat(List<Mat> src, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            core_Core_hconcat_10(src_mat.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::vconcat(vector_Mat src, Mat& dst)
        //

        /// <remarks>
        ///  @overload
        /// </remarks>
        /// <code language="c++">
        ///      std::vector&lt;cv::Mat&gt; matrices = { cv::Mat(1, 4, CV_8UC1, cv::Scalar(1)),
        ///                                        cv::Mat(1, 4, CV_8UC1, cv::Scalar(2)),
        ///                                        cv::Mat(1, 4, CV_8UC1, cv::Scalar(3)),};
        ///  
        ///      cv::Mat out;
        ///      cv::vconcat( matrices, out );
        ///      //out:
        ///      //[1,   1,   1,   1;
        ///      // 2,   2,   2,   2;
        ///      // 3,   3,   3,   3]
        /// </code>
        /// <param name="src">
        /// input array or vector of matrices. all of the matrices must have the same number of cols and the same depth
        /// </param>
        /// <param name="dst">
        /// output array. It has the same number of cols and depth as the src, and the sum of rows of the src.
        ///  same depth.
        /// </param>
        public static void vconcat(List<Mat> src, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed();
            Mat src_mat = Converters.vector_Mat_to_Mat(src);
            core_Core_vconcat_10(src_mat.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::bitwise_and(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        //

        /// <summary>
        ///  computes bitwise conjunction of the two arrays (dst = src1 &amp; src2)
        ///  Calculates the per-element bit-wise conjunction of two arrays or an
        ///  array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_and calculates the per-element bit-wise logical conjunction for:
        ///      Two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \wedge \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///      An array and a scalar when src2 is constructed from Scalar or has
        ///      the same number of elements as `src1.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \wedge \texttt{src2} \quad \texttt{if mask} (I) \ne0\f]
        ///      A scalar and an array when src1 is constructed from Scalar or has
        ///      the same number of elements as `src2.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \wedge \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///  In case of floating-point arrays, their machine-specific bit
        ///  representations (usually IEEE754-compliant) are used for the operation.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. In the second and third cases above, the scalar is first
        ///  converted to the array type.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  arrays.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_and(Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_bitwise_1and_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///  computes bitwise conjunction of the two arrays (dst = src1 &amp; src2)
        ///  Calculates the per-element bit-wise conjunction of two arrays or an
        ///  array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_and calculates the per-element bit-wise logical conjunction for:
        ///      Two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \wedge \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///      An array and a scalar when src2 is constructed from Scalar or has
        ///      the same number of elements as `src1.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \wedge \texttt{src2} \quad \texttt{if mask} (I) \ne0\f]
        ///      A scalar and an array when src1 is constructed from Scalar or has
        ///      the same number of elements as `src2.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \wedge \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///  In case of floating-point arrays, their machine-specific bit
        ///  representations (usually IEEE754-compliant) are used for the operation.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. In the second and third cases above, the scalar is first
        ///  converted to the array type.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  arrays.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_and(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_bitwise_1and_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::bitwise_or(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        //

        /// <summary>
        ///  Calculates the per-element bit-wise disjunction of two arrays or an
        ///  array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_or calculates the per-element bit-wise logical disjunction for:
        ///      Two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \vee \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///      An array and a scalar when src2 is constructed from Scalar or has
        ///      the same number of elements as `src1.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \vee \texttt{src2} \quad \texttt{if mask} (I) \ne0\f]
        ///      A scalar and an array when src1 is constructed from Scalar or has
        ///      the same number of elements as `src2.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \vee \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///  In case of floating-point arrays, their machine-specific bit
        ///  representations (usually IEEE754-compliant) are used for the operation.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. In the second and third cases above, the scalar is first
        ///  converted to the array type.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  arrays.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_or(Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_bitwise_1or_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///  Calculates the per-element bit-wise disjunction of two arrays or an
        ///  array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_or calculates the per-element bit-wise logical disjunction for:
        ///      Two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \vee \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///      An array and a scalar when src2 is constructed from Scalar or has
        ///      the same number of elements as `src1.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \vee \texttt{src2} \quad \texttt{if mask} (I) \ne0\f]
        ///      A scalar and an array when src1 is constructed from Scalar or has
        ///      the same number of elements as `src2.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \vee \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///  In case of floating-point arrays, their machine-specific bit
        ///  representations (usually IEEE754-compliant) are used for the operation.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. In the second and third cases above, the scalar is first
        ///  converted to the array type.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  arrays.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_or(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_bitwise_1or_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::bitwise_xor(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        //

        /// <summary>
        ///  Calculates the per-element bit-wise "exclusive or" operation on two
        ///  arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_xor calculates the per-element bit-wise logical "exclusive-or"
        ///  operation for:
        ///      Two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \oplus \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///      An array and a scalar when src2 is constructed from Scalar or has
        ///      the same number of elements as `src1.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \oplus \texttt{src2} \quad \texttt{if mask} (I) \ne0\f]
        ///      A scalar and an array when src1 is constructed from Scalar or has
        ///      the same number of elements as `src2.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \oplus \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///  In case of floating-point arrays, their machine-specific bit
        ///  representations (usually IEEE754-compliant) are used for the operation.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. In the 2nd and 3rd cases above, the scalar is first
        ///  converted to the array type.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  arrays.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_xor(Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_bitwise_1xor_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///  Calculates the per-element bit-wise "exclusive or" operation on two
        ///  arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_xor calculates the per-element bit-wise logical "exclusive-or"
        ///  operation for:
        ///      Two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \oplus \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///      An array and a scalar when src2 is constructed from Scalar or has
        ///      the same number of elements as `src1.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \oplus \texttt{src2} \quad \texttt{if mask} (I) \ne0\f]
        ///      A scalar and an array when src1 is constructed from Scalar or has
        ///      the same number of elements as `src2.channels()`:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \oplus \texttt{src2} (I) \quad \texttt{if mask} (I) \ne0\f]
        ///  In case of floating-point arrays, their machine-specific bit
        ///  representations (usually IEEE754-compliant) are used for the operation.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. In the 2nd and 3rd cases above, the scalar is first
        ///  converted to the array type.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  arrays.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_xor(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_bitwise_1xor_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::bitwise_not(Mat src, Mat& dst, Mat mask = Mat())
        //

        /// <summary>
        ///   Inverts every bit of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_not calculates per-element bit-wise inversion of the input
        ///  array:
        ///  \f[\texttt{dst} (I) =  \neg \texttt{src} (I)\f]
        ///  In case of a floating-point input array, its machine-specific bit
        ///  representation (usually IEEE754-compliant) is used for the operation. In
        ///  case of multi-channel arrays, each channel is processed independently.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  array.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_not(Mat src, Mat dst, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_bitwise_1not_10(src.nativeObj, dst.nativeObj, mask.nativeObj);


        }

        /// <summary>
        ///   Inverts every bit of an array.
        /// </summary>
        /// <remarks>
        ///  The function cv::bitwise_not calculates per-element bit-wise inversion of the input
        ///  array:
        ///  \f[\texttt{dst} (I) =  \neg \texttt{src} (I)\f]
        ///  In case of a floating-point input array, its machine-specific bit
        ///  representation (usually IEEE754-compliant) is used for the operation. In
        ///  case of multi-channel arrays, each channel is processed independently.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as the input
        ///  array.
        /// </param>
        /// <param name="mask">
        /// optional operation mask, 8-bit single channel array, that
        ///  specifies elements of the output array to be changed.
        /// </param>
        public static void bitwise_not(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_bitwise_1not_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::absdiff(Mat src1, Mat src2, Mat& dst)
        //

        /// <summary>
        ///  Calculates the per-element absolute difference between two arrays or between an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::absdiff calculates:
        ///      Absolute difference between two arrays when they have the same
        ///      size and type:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} (| \texttt{src1}(I) -  \texttt{src2}(I)|)\f]
        ///      Absolute difference between an array and a scalar when the second
        ///      array is constructed from Scalar or has as many elements as the
        ///      number of channels in `src1`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} (| \texttt{src1}(I) -  \texttt{src2} |)\f]
        ///      Absolute difference between a scalar and an array when the first
        ///      array is constructed from Scalar or has as many elements as the
        ///      number of channels in `src2`:
        ///      \f[\texttt{dst}(I) =  \texttt{saturate} (| \texttt{src1} -  \texttt{src2}(I) |)\f]
        ///      where I is a multi-dimensional index of array elements. In case of
        ///      multi-channel arrays, each channel is processed independently.
        ///  @note Saturation is not applied when the arrays have the depth CV_32S.
        ///  You may even get a negative value in the case of overflow.
        ///  @note (Python) Be careful to difference behaviour between src1/src2 are single number and they are tuple/array.
        ///  `absdiff(src,X)` means `absdiff(src,(X,X,X,X))`.
        ///  `absdiff(src,(X,))` means `absdiff(src,(X,0,0,0))`.
        /// </remarks>
        /// <param name="src1">
        /// first input array or a scalar.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array that has the same size and type as input arrays.
        ///  @sa cv::abs(const Mat&amp;)
        /// </param>
        public static void absdiff(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_absdiff_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::copyTo(Mat src, Mat& dst, Mat mask)
        //

        /// <summary>
        ///   This is an overloaded member function, provided for convenience (python)
        ///  Copies the matrix to another one.
        ///  When the operation mask is specified, if the Mat::create call shown above reallocates the matrix, the newly allocated matrix is initialized with all zeros before copying the data.
        /// </summary>
        /// <param name="src">
        /// source matrix.
        /// </param>
        /// <param name="dst">
        /// Destination matrix. If it does not have a proper size or type before the operation, it is
        ///  reallocated.
        /// </param>
        /// <param name="mask">
        /// Operation mask of the same size as \*this. Its non-zero elements indicate which matrix
        ///  elements need to be copied. The mask has to be of type CV_8U and can have 1 or multiple channels.
        /// </param>
        public static void copyTo(Mat src, Mat dst, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_copyTo_10(src.nativeObj, dst.nativeObj, mask.nativeObj);


        }


        //
        // C++:  void cv::inRange(Mat src, Scalar lowerb, Scalar upperb, Mat& dst)
        //

        /// <summary>
        ///   Checks if array elements lie between the elements of two other arrays.
        /// </summary>
        /// <remarks>
        ///  The function checks the range as follows:
        ///  -   For every element of a single-channel input array:
        ///      \f[\texttt{dst} (I)= \texttt{lowerb} (I)_0  \leq \texttt{src} (I)_0 \leq  \texttt{upperb} (I)_0\f]
        ///  -   For two-channel arrays:
        ///      \f[\texttt{dst} (I)= \texttt{lowerb} (I)_0  \leq \texttt{src} (I)_0 \leq  \texttt{upperb} (I)_0  \land \texttt{lowerb} (I)_1  \leq \texttt{src} (I)_1 \leq  \texttt{upperb} (I)_1\f]
        ///  -   and so forth.
        ///  
        ///  That is, dst (I) is set to 255 (all 1 -bits) if src (I) is within the
        ///  specified 1D, 2D, 3D, ... box and 0 otherwise.
        ///  
        ///  When the lower and/or upper boundary parameters are scalars, the indexes
        ///  (I) at lowerb and upperb in the above formulas should be omitted.
        /// </remarks>
        /// <param name="src">
        /// first input array.
        /// </param>
        /// <param name="lowerb">
        /// inclusive lower boundary array or a scalar.
        /// </param>
        /// <param name="upperb">
        /// inclusive upper boundary array or a scalar.
        /// </param>
        /// <param name="dst">
        /// output array of the same size as src and CV_8U type.
        /// </param>
        public static void inRange(Mat src, Scalar lowerb, Scalar upperb, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_inRange_10(src.nativeObj, lowerb.val[0], lowerb.val[1], lowerb.val[2], lowerb.val[3], upperb.val[0], upperb.val[1], upperb.val[2], upperb.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::compare(Mat src1, Mat src2, Mat& dst, int cmpop)
        //

        /// <summary>
        ///  Performs the per-element comparison of two arrays or an array and scalar value.
        /// </summary>
        /// <remarks>
        ///  The function compares:
        ///      Elements of two arrays when src1 and src2 have the same size:
        ///      \f[\texttt{dst} (I) =  \texttt{src1} (I)  \,\texttt{cmpop}\, \texttt{src2} (I)\f]
        ///      Elements of src1 with a scalar src2 when src2 is constructed from
        ///      Scalar or has a single element:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}(I) \,\texttt{cmpop}\,  \texttt{src2}\f]
        ///      src1 with elements of src2 when src1 is constructed from Scalar or
        ///      has a single element:
        ///      \f[\texttt{dst} (I) =  \texttt{src1}  \,\texttt{cmpop}\, \texttt{src2} (I)\f]
        ///  When the comparison result is true, the corresponding element of output
        ///  array is set to 255. The comparison operations can be replaced with the
        ///  equivalent matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      Mat dst1 = src1 &gt;= src2;
        ///      Mat dst2 = src1 &lt; 8;
        ///      ...
        /// </code>
        /// <param name="src1">
        /// first input array or a scalar; when it is an array, it must have a single channel.
        /// </param>
        /// <param name="src2">
        /// second input array or a scalar; when it is an array, it must have a single channel.
        /// </param>
        /// <param name="dst">
        /// output array of type ref CV_8U that has the same size and the same number of channels as
        ///      the input arrays.
        /// </param>
        /// <param name="cmpop">
        /// a flag, that specifies correspondence between the arrays (cv::CmpTypes)
        ///  @sa checkRange, min, max, threshold
        /// </param>
        public static void compare(Mat src1, Mat src2, Mat dst, int cmpop)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_compare_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, cmpop);


        }


        //
        // C++:  void cv::min(Mat src1, Mat src2, Mat& dst)
        //

        /// <summary>
        ///  Calculates per-element minimum of two arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::min calculates the per-element minimum of two arrays:
        ///  \f[\texttt{dst} (I)= \min ( \texttt{src1} (I), \texttt{src2} (I))\f]
        ///  or array and a scalar:
        ///  \f[\texttt{dst} (I)= \min ( \texttt{src1} (I), \texttt{value} )\f]
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and type as src1.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src1.
        ///  @sa max, compare, inRange, minMaxLoc
        /// </param>
        public static void min(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_min_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::max(Mat src1, Mat src2, Mat& dst)
        //

        /// <summary>
        ///  Calculates per-element maximum of two arrays or an array and a scalar.
        /// </summary>
        /// <remarks>
        ///  The function cv::max calculates the per-element maximum of two arrays:
        ///  \f[\texttt{dst} (I)= \max ( \texttt{src1} (I), \texttt{src2} (I))\f]
        ///  or array and a scalar:
        ///  \f[\texttt{dst} (I)= \max ( \texttt{src1} (I), \texttt{value} )\f]
        /// </remarks>
        /// <param name="src1">
        /// first input array.
        /// </param>
        /// <param name="src2">
        /// second input array of the same size and type as src1 .
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src1.
        ///  @sa  min, compare, inRange, minMaxLoc, @ref MatrixExpressions
        /// </param>
        public static void max(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_max_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::sqrt(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Calculates a square root of array elements.
        /// </summary>
        /// <remarks>
        ///  The function cv::sqrt calculates a square root of each input array element.
        ///  In case of multi-channel arrays, each channel is processed
        ///  independently. The accuracy is approximately the same as of the built-in
        ///  std::sqrt .
        /// </remarks>
        /// <param name="src">
        /// input floating-point array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        /// </param>
        public static void sqrt(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_sqrt_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::pow(Mat src, double power, Mat& dst)
        //

        /// <summary>
        ///  Raises every array element to a power.
        /// </summary>
        /// <remarks>
        ///  The function cv::pow raises every element of the input array to power :
        ///  \f[\texttt{dst} (I) =  \fork{\texttt{src}(I)^{power}}{if \(\texttt{power}\) is integer}{|\texttt{src}(I)|^{power}}{otherwise}\f]
        ///  
        ///  So, for a non-integer power exponent, the absolute values of input array
        ///  elements are used. However, it is possible to get true values for
        ///  negative values using some extra operations. In the example below,
        ///  computing the 5th root of array src shows:
        /// </remarks>
        /// <code language="c++">
        ///      Mat mask = src &lt; 0;
        ///      pow(src, 1./5, dst);
        ///      subtract(Scalar::all(0), dst, dst, mask);
        /// </code>
        /// <remarks>
        ///  For some values of power, such as integer values, 0.5 and -0.5,
        ///  specialized faster algorithms are used.
        ///  
        ///  Special values (NaN, Inf) are not handled.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="power">
        /// exponent of power.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        ///  @sa sqrt, exp, log, cartToPolar, polarToCart
        /// </param>
        public static void pow(Mat src, double power, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_pow_10(src.nativeObj, power, dst.nativeObj);


        }


        //
        // C++:  void cv::exp(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Calculates the exponent of every array element.
        /// </summary>
        /// <remarks>
        ///  The function cv::exp calculates the exponent of every element of the input
        ///  array:
        ///  \f[\texttt{dst} [I] = e^{ src(I) }\f]
        ///  
        ///  The maximum relative error is about 7e-6 for single-precision input and
        ///  less than 1e-10 for double-precision input. Currently, the function
        ///  converts denormalized values to zeros on output. Special values (NaN,
        ///  Inf) are not handled.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        ///  @sa log, cartToPolar, polarToCart, phase, pow, sqrt, magnitude
        /// </param>
        public static void exp(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_exp_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::log(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Calculates the natural logarithm of every array element.
        /// </summary>
        /// <remarks>
        ///  The function cv::log calculates the natural logarithm of every element of the input array:
        ///  \f[\texttt{dst} (I) =  \log (\texttt{src}(I)) \f]
        ///  
        ///  Output on zero, negative and special (NaN, Inf) values is undefined.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src .
        ///  @sa exp, cartToPolar, polarToCart, phase, pow, sqrt, magnitude
        /// </param>
        public static void log(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_log_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::polarToCart(Mat magnitude, Mat angle, Mat& x, Mat& y, bool angleInDegrees = false)
        //

        /// <summary>
        ///  Calculates x and y coordinates of 2D vectors from their magnitude and angle.
        /// </summary>
        /// <remarks>
        ///  The function cv::polarToCart calculates the Cartesian coordinates of each 2D
        ///  vector represented by the corresponding elements of magnitude and angle:
        ///  \f[\begin{array}{l} \texttt{x} (I) =  \texttt{magnitude} (I) \cos ( \texttt{angle} (I)) \\ \texttt{y} (I) =  \texttt{magnitude} (I) \sin ( \texttt{angle} (I)) \\ \end{array}\f]
        ///  
        ///  The relative accuracy of the estimated coordinates is about 1e-6.
        /// </remarks>
        /// <param name="magnitude">
        /// input floating-point array of magnitudes of 2D vectors;
        ///  it can be an empty matrix (=Mat()), in this case, the function assumes
        ///  that all the magnitudes are =1; if it is not empty, it must have the
        ///  same size and type as angle.
        /// </param>
        /// <param name="angle">
        /// input floating-point array of angles of 2D vectors.
        /// </param>
        /// <param name="x">
        /// output array of x-coordinates of 2D vectors; it has the same
        ///  size and type as angle.
        /// </param>
        /// <param name="y">
        /// output array of y-coordinates of 2D vectors; it has the same
        ///  size and type as angle.
        /// </param>
        /// <param name="angleInDegrees">
        /// when true, the input angles are measured in
        ///  degrees, otherwise, they are measured in radians.
        ///  @sa cartToPolar, magnitude, phase, exp, log, pow, sqrt
        /// </param>
        public static void polarToCart(Mat magnitude, Mat angle, Mat x, Mat y, bool angleInDegrees)
        {
            if (magnitude != null) magnitude.ThrowIfDisposed();
            if (angle != null) angle.ThrowIfDisposed();
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();

            core_Core_polarToCart_10(magnitude.nativeObj, angle.nativeObj, x.nativeObj, y.nativeObj, angleInDegrees);


        }

        /// <summary>
        ///  Calculates x and y coordinates of 2D vectors from their magnitude and angle.
        /// </summary>
        /// <remarks>
        ///  The function cv::polarToCart calculates the Cartesian coordinates of each 2D
        ///  vector represented by the corresponding elements of magnitude and angle:
        ///  \f[\begin{array}{l} \texttt{x} (I) =  \texttt{magnitude} (I) \cos ( \texttt{angle} (I)) \\ \texttt{y} (I) =  \texttt{magnitude} (I) \sin ( \texttt{angle} (I)) \\ \end{array}\f]
        ///  
        ///  The relative accuracy of the estimated coordinates is about 1e-6.
        /// </remarks>
        /// <param name="magnitude">
        /// input floating-point array of magnitudes of 2D vectors;
        ///  it can be an empty matrix (=Mat()), in this case, the function assumes
        ///  that all the magnitudes are =1; if it is not empty, it must have the
        ///  same size and type as angle.
        /// </param>
        /// <param name="angle">
        /// input floating-point array of angles of 2D vectors.
        /// </param>
        /// <param name="x">
        /// output array of x-coordinates of 2D vectors; it has the same
        ///  size and type as angle.
        /// </param>
        /// <param name="y">
        /// output array of y-coordinates of 2D vectors; it has the same
        ///  size and type as angle.
        /// </param>
        /// <param name="angleInDegrees">
        /// when true, the input angles are measured in
        ///  degrees, otherwise, they are measured in radians.
        ///  @sa cartToPolar, magnitude, phase, exp, log, pow, sqrt
        /// </param>
        public static void polarToCart(Mat magnitude, Mat angle, Mat x, Mat y)
        {
            if (magnitude != null) magnitude.ThrowIfDisposed();
            if (angle != null) angle.ThrowIfDisposed();
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();

            core_Core_polarToCart_11(magnitude.nativeObj, angle.nativeObj, x.nativeObj, y.nativeObj);


        }


        //
        // C++:  void cv::cartToPolar(Mat x, Mat y, Mat& magnitude, Mat& angle, bool angleInDegrees = false)
        //

        /// <summary>
        ///  Calculates the magnitude and angle of 2D vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::cartToPolar calculates either the magnitude, angle, or both
        ///  for every 2D vector (x(I),y(I)):
        ///  \f[\begin{array}{l} \texttt{magnitude} (I)= \sqrt{\texttt{x}(I)^2+\texttt{y}(I)^2} , \\ \texttt{angle} (I)= \texttt{atan2} ( \texttt{y} (I), \texttt{x} (I))[ \cdot180 / \pi ] \end{array}\f]
        ///  
        ///  The angles are calculated with accuracy about 0.3 degrees. For the point
        ///  (0,0), the angle is set to 0.
        /// </remarks>
        /// <param name="x">
        /// array of x-coordinates; this must be a single-precision or
        ///  double-precision floating-point array.
        /// </param>
        /// <param name="y">
        /// array of y-coordinates, that must have the same size and same type as x.
        /// </param>
        /// <param name="magnitude">
        /// output array of magnitudes of the same size and type as x.
        /// </param>
        /// <param name="angle">
        /// output array of angles that has the same size and type as
        ///  x; the angles are measured in radians (from 0 to 2\*Pi) or in degrees (0 to 360 degrees).
        /// </param>
        /// <param name="angleInDegrees">
        /// a flag, indicating whether the angles are measured
        ///  in radians (which is by default), or in degrees.
        ///  @sa Sobel, Scharr
        /// </param>
        public static void cartToPolar(Mat x, Mat y, Mat magnitude, Mat angle, bool angleInDegrees)
        {
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();
            if (magnitude != null) magnitude.ThrowIfDisposed();
            if (angle != null) angle.ThrowIfDisposed();

            core_Core_cartToPolar_10(x.nativeObj, y.nativeObj, magnitude.nativeObj, angle.nativeObj, angleInDegrees);


        }

        /// <summary>
        ///  Calculates the magnitude and angle of 2D vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::cartToPolar calculates either the magnitude, angle, or both
        ///  for every 2D vector (x(I),y(I)):
        ///  \f[\begin{array}{l} \texttt{magnitude} (I)= \sqrt{\texttt{x}(I)^2+\texttt{y}(I)^2} , \\ \texttt{angle} (I)= \texttt{atan2} ( \texttt{y} (I), \texttt{x} (I))[ \cdot180 / \pi ] \end{array}\f]
        ///  
        ///  The angles are calculated with accuracy about 0.3 degrees. For the point
        ///  (0,0), the angle is set to 0.
        /// </remarks>
        /// <param name="x">
        /// array of x-coordinates; this must be a single-precision or
        ///  double-precision floating-point array.
        /// </param>
        /// <param name="y">
        /// array of y-coordinates, that must have the same size and same type as x.
        /// </param>
        /// <param name="magnitude">
        /// output array of magnitudes of the same size and type as x.
        /// </param>
        /// <param name="angle">
        /// output array of angles that has the same size and type as
        ///  x; the angles are measured in radians (from 0 to 2\*Pi) or in degrees (0 to 360 degrees).
        /// </param>
        /// <param name="angleInDegrees">
        /// a flag, indicating whether the angles are measured
        ///  in radians (which is by default), or in degrees.
        ///  @sa Sobel, Scharr
        /// </param>
        public static void cartToPolar(Mat x, Mat y, Mat magnitude, Mat angle)
        {
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();
            if (magnitude != null) magnitude.ThrowIfDisposed();
            if (angle != null) angle.ThrowIfDisposed();

            core_Core_cartToPolar_11(x.nativeObj, y.nativeObj, magnitude.nativeObj, angle.nativeObj);


        }


        //
        // C++:  void cv::phase(Mat x, Mat y, Mat& angle, bool angleInDegrees = false)
        //

        /// <summary>
        ///  Calculates the rotation angle of 2D vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::phase calculates the rotation angle of each 2D vector that
        ///  is formed from the corresponding elements of x and y :
        ///  \f[\texttt{angle} (I) =  \texttt{atan2} ( \texttt{y} (I), \texttt{x} (I))\f]
        ///  
        ///  The angle estimation accuracy is about 0.3 degrees. When x(I)=y(I)=0 ,
        ///  the corresponding angle(I) is set to 0.
        /// </remarks>
        /// <param name="x">
        /// input floating-point array of x-coordinates of 2D vectors.
        /// </param>
        /// <param name="y">
        /// input array of y-coordinates of 2D vectors; it must have the
        ///  same size and the same type as x.
        /// </param>
        /// <param name="angle">
        /// output array of vector angles; it has the same size and
        ///  same type as x .
        /// </param>
        /// <param name="angleInDegrees">
        /// when true, the function calculates the angle in
        ///  degrees, otherwise, they are measured in radians.
        /// </param>
        public static void phase(Mat x, Mat y, Mat angle, bool angleInDegrees)
        {
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();
            if (angle != null) angle.ThrowIfDisposed();

            core_Core_phase_10(x.nativeObj, y.nativeObj, angle.nativeObj, angleInDegrees);


        }

        /// <summary>
        ///  Calculates the rotation angle of 2D vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::phase calculates the rotation angle of each 2D vector that
        ///  is formed from the corresponding elements of x and y :
        ///  \f[\texttt{angle} (I) =  \texttt{atan2} ( \texttt{y} (I), \texttt{x} (I))\f]
        ///  
        ///  The angle estimation accuracy is about 0.3 degrees. When x(I)=y(I)=0 ,
        ///  the corresponding angle(I) is set to 0.
        /// </remarks>
        /// <param name="x">
        /// input floating-point array of x-coordinates of 2D vectors.
        /// </param>
        /// <param name="y">
        /// input array of y-coordinates of 2D vectors; it must have the
        ///  same size and the same type as x.
        /// </param>
        /// <param name="angle">
        /// output array of vector angles; it has the same size and
        ///  same type as x .
        /// </param>
        /// <param name="angleInDegrees">
        /// when true, the function calculates the angle in
        ///  degrees, otherwise, they are measured in radians.
        /// </param>
        public static void phase(Mat x, Mat y, Mat angle)
        {
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();
            if (angle != null) angle.ThrowIfDisposed();

            core_Core_phase_11(x.nativeObj, y.nativeObj, angle.nativeObj);


        }


        //
        // C++:  void cv::magnitude(Mat x, Mat y, Mat& magnitude)
        //

        /// <summary>
        ///  Calculates the magnitude of 2D vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::magnitude calculates the magnitude of 2D vectors formed
        ///  from the corresponding elements of x and y arrays:
        ///  \f[\texttt{dst} (I) =  \sqrt{\texttt{x}(I)^2 + \texttt{y}(I)^2}\f]
        /// </remarks>
        /// <param name="x">
        /// floating-point array of x-coordinates of the vectors.
        /// </param>
        /// <param name="y">
        /// floating-point array of y-coordinates of the vectors; it must
        ///  have the same size as x.
        /// </param>
        /// <param name="magnitude">
        /// output array of the same size and type as x.
        ///  @sa cartToPolar, polarToCart, phase, sqrt
        /// </param>
        public static void magnitude(Mat x, Mat y, Mat magnitude)
        {
            if (x != null) x.ThrowIfDisposed();
            if (y != null) y.ThrowIfDisposed();
            if (magnitude != null) magnitude.ThrowIfDisposed();

            core_Core_magnitude_10(x.nativeObj, y.nativeObj, magnitude.nativeObj);


        }


        //
        // C++:  bool cv::checkRange(Mat a, bool quiet = true,  _hidden_ * pos = 0, double minVal = -DBL_MAX, double maxVal = DBL_MAX)
        //

        /// <summary>
        ///  Checks every element of an input array for invalid values.
        /// </summary>
        /// <remarks>
        ///  The function cv::checkRange checks that every array element is neither NaN nor infinite. When minVal &gt;
        ///  -DBL_MAX and maxVal &lt; DBL_MAX, the function also checks that each value is between minVal and
        ///  maxVal. In case of multi-channel arrays, each channel is processed independently. If some values
        ///  are out of range, position of the first outlier is stored in pos (when pos != NULL). Then, the
        ///  function either returns false (when quiet=true) or throws an exception.
        /// </remarks>
        /// <param name="a">
        /// input array.
        /// </param>
        /// <param name="quiet">
        /// a flag, indicating whether the functions quietly return false when the array elements
        ///  are out of range or they throw an exception.
        /// </param>
        /// <param name="pos">
        /// optional output parameter, when not NULL, must be a pointer to array of src.dims
        ///  elements.
        /// </param>
        /// <param name="minVal">
        /// inclusive lower boundary of valid values range.
        /// </param>
        /// <param name="maxVal">
        /// exclusive upper boundary of valid values range.
        /// </param>
        public static bool checkRange(Mat a, bool quiet, double minVal, double maxVal)
        {
            if (a != null) a.ThrowIfDisposed();

            return core_Core_checkRange_10(a.nativeObj, quiet, minVal, maxVal);


        }

        /// <summary>
        ///  Checks every element of an input array for invalid values.
        /// </summary>
        /// <remarks>
        ///  The function cv::checkRange checks that every array element is neither NaN nor infinite. When minVal &gt;
        ///  -DBL_MAX and maxVal &lt; DBL_MAX, the function also checks that each value is between minVal and
        ///  maxVal. In case of multi-channel arrays, each channel is processed independently. If some values
        ///  are out of range, position of the first outlier is stored in pos (when pos != NULL). Then, the
        ///  function either returns false (when quiet=true) or throws an exception.
        /// </remarks>
        /// <param name="a">
        /// input array.
        /// </param>
        /// <param name="quiet">
        /// a flag, indicating whether the functions quietly return false when the array elements
        ///  are out of range or they throw an exception.
        /// </param>
        /// <param name="pos">
        /// optional output parameter, when not NULL, must be a pointer to array of src.dims
        ///  elements.
        /// </param>
        /// <param name="minVal">
        /// inclusive lower boundary of valid values range.
        /// </param>
        /// <param name="maxVal">
        /// exclusive upper boundary of valid values range.
        /// </param>
        public static bool checkRange(Mat a, bool quiet, double minVal)
        {
            if (a != null) a.ThrowIfDisposed();

            return core_Core_checkRange_11(a.nativeObj, quiet, minVal);


        }

        /// <summary>
        ///  Checks every element of an input array for invalid values.
        /// </summary>
        /// <remarks>
        ///  The function cv::checkRange checks that every array element is neither NaN nor infinite. When minVal &gt;
        ///  -DBL_MAX and maxVal &lt; DBL_MAX, the function also checks that each value is between minVal and
        ///  maxVal. In case of multi-channel arrays, each channel is processed independently. If some values
        ///  are out of range, position of the first outlier is stored in pos (when pos != NULL). Then, the
        ///  function either returns false (when quiet=true) or throws an exception.
        /// </remarks>
        /// <param name="a">
        /// input array.
        /// </param>
        /// <param name="quiet">
        /// a flag, indicating whether the functions quietly return false when the array elements
        ///  are out of range or they throw an exception.
        /// </param>
        /// <param name="pos">
        /// optional output parameter, when not NULL, must be a pointer to array of src.dims
        ///  elements.
        /// </param>
        /// <param name="minVal">
        /// inclusive lower boundary of valid values range.
        /// </param>
        /// <param name="maxVal">
        /// exclusive upper boundary of valid values range.
        /// </param>
        public static bool checkRange(Mat a, bool quiet)
        {
            if (a != null) a.ThrowIfDisposed();

            return core_Core_checkRange_12(a.nativeObj, quiet);


        }

        /// <summary>
        ///  Checks every element of an input array for invalid values.
        /// </summary>
        /// <remarks>
        ///  The function cv::checkRange checks that every array element is neither NaN nor infinite. When minVal &gt;
        ///  -DBL_MAX and maxVal &lt; DBL_MAX, the function also checks that each value is between minVal and
        ///  maxVal. In case of multi-channel arrays, each channel is processed independently. If some values
        ///  are out of range, position of the first outlier is stored in pos (when pos != NULL). Then, the
        ///  function either returns false (when quiet=true) or throws an exception.
        /// </remarks>
        /// <param name="a">
        /// input array.
        /// </param>
        /// <param name="quiet">
        /// a flag, indicating whether the functions quietly return false when the array elements
        ///  are out of range or they throw an exception.
        /// </param>
        /// <param name="pos">
        /// optional output parameter, when not NULL, must be a pointer to array of src.dims
        ///  elements.
        /// </param>
        /// <param name="minVal">
        /// inclusive lower boundary of valid values range.
        /// </param>
        /// <param name="maxVal">
        /// exclusive upper boundary of valid values range.
        /// </param>
        public static bool checkRange(Mat a)
        {
            if (a != null) a.ThrowIfDisposed();

            return core_Core_checkRange_14(a.nativeObj);


        }


        //
        // C++:  void cv::patchNaNs(Mat& a, double val = 0)
        //

        /// <summary>
        ///  Replaces NaNs by given number
        /// </summary>
        /// <param name="a">
        /// input/output matrix (CV_32F type).
        /// </param>
        /// <param name="val">
        /// value to convert the NaNs
        /// </param>
        public static void patchNaNs(Mat a, double val)
        {
            if (a != null) a.ThrowIfDisposed();

            core_Core_patchNaNs_10(a.nativeObj, val);


        }

        /// <summary>
        ///  Replaces NaNs by given number
        /// </summary>
        /// <param name="a">
        /// input/output matrix (CV_32F type).
        /// </param>
        /// <param name="val">
        /// value to convert the NaNs
        /// </param>
        public static void patchNaNs(Mat a)
        {
            if (a != null) a.ThrowIfDisposed();

            core_Core_patchNaNs_11(a.nativeObj);


        }


        //
        // C++:  void cv::gemm(Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat& dst, int flags = 0)
        //

        /// <summary>
        ///  Performs generalized matrix multiplication.
        /// </summary>
        /// <remarks>
        ///  The function cv::gemm performs generalized matrix multiplication similar to the
        ///  gemm functions in BLAS level 3. For example,
        ///  `gemm(src1, src2, alpha, src3, beta, dst, GEMM_1_T + GEMM_3_T)`
        ///  corresponds to
        ///  \f[\texttt{dst} =  \texttt{alpha} \cdot \texttt{src1} ^T  \cdot \texttt{src2} +  \texttt{beta} \cdot \texttt{src3} ^T\f]
        ///  
        ///  In case of complex (two-channel) data, performed a complex matrix
        ///  multiplication.
        ///  
        ///  The function can be replaced with a matrix expression. For example, the
        ///  above call can be replaced with:
        /// </remarks>
        /// <code language="c++">
        ///      dst = alpha*src1.t()*src2 + beta*src3.t();
        /// </code>
        /// <param name="src1">
        /// first multiplied input matrix that could be real(CV_32FC1,
        ///  CV_64FC1) or complex(CV_32FC2, CV_64FC2).
        /// </param>
        /// <param name="src2">
        /// second multiplied input matrix of the same type as src1.
        /// </param>
        /// <param name="alpha">
        /// weight of the matrix product.
        /// </param>
        /// <param name="src3">
        /// third optional delta matrix added to the matrix product; it
        ///  should have the same type as src1 and src2.
        /// </param>
        /// <param name="beta">
        /// weight of src3.
        /// </param>
        /// <param name="dst">
        /// output matrix; it has the proper size and the same type as
        ///  input matrices.
        /// </param>
        /// <param name="flags">
        /// operation flags (cv::GemmFlags)
        ///  @sa mulTransposed, transform
        /// </param>
        public static void gemm(Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat dst, int flags)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (src3 != null) src3.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_gemm_10(src1.nativeObj, src2.nativeObj, alpha, src3.nativeObj, beta, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Performs generalized matrix multiplication.
        /// </summary>
        /// <remarks>
        ///  The function cv::gemm performs generalized matrix multiplication similar to the
        ///  gemm functions in BLAS level 3. For example,
        ///  `gemm(src1, src2, alpha, src3, beta, dst, GEMM_1_T + GEMM_3_T)`
        ///  corresponds to
        ///  \f[\texttt{dst} =  \texttt{alpha} \cdot \texttt{src1} ^T  \cdot \texttt{src2} +  \texttt{beta} \cdot \texttt{src3} ^T\f]
        ///  
        ///  In case of complex (two-channel) data, performed a complex matrix
        ///  multiplication.
        ///  
        ///  The function can be replaced with a matrix expression. For example, the
        ///  above call can be replaced with:
        /// </remarks>
        /// <code language="c++">
        ///      dst = alpha*src1.t()*src2 + beta*src3.t();
        /// </code>
        /// <param name="src1">
        /// first multiplied input matrix that could be real(CV_32FC1,
        ///  CV_64FC1) or complex(CV_32FC2, CV_64FC2).
        /// </param>
        /// <param name="src2">
        /// second multiplied input matrix of the same type as src1.
        /// </param>
        /// <param name="alpha">
        /// weight of the matrix product.
        /// </param>
        /// <param name="src3">
        /// third optional delta matrix added to the matrix product; it
        ///  should have the same type as src1 and src2.
        /// </param>
        /// <param name="beta">
        /// weight of src3.
        /// </param>
        /// <param name="dst">
        /// output matrix; it has the proper size and the same type as
        ///  input matrices.
        /// </param>
        /// <param name="flags">
        /// operation flags (cv::GemmFlags)
        ///  @sa mulTransposed, transform
        /// </param>
        public static void gemm(Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (src3 != null) src3.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_gemm_11(src1.nativeObj, src2.nativeObj, alpha, src3.nativeObj, beta, dst.nativeObj);


        }


        //
        // C++:  void cv::mulTransposed(Mat src, Mat& dst, bool aTa, Mat delta = Mat(), double scale = 1, int dtype = -1)
        //

        /// <summary>
        ///  Calculates the product of a matrix and its transposition.
        /// </summary>
        /// <remarks>
        ///  The function cv::mulTransposed calculates the product of src and its
        ///  transposition:
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} )^T ( \texttt{src} - \texttt{delta} )\f]
        ///  if aTa=true, and
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} ) ( \texttt{src} - \texttt{delta} )^T\f]
        ///  otherwise. The function is used to calculate the covariance matrix. With
        ///  zero delta, it can be used as a faster substitute for general matrix
        ///  product A\*B when B=A'
        /// </remarks>
        /// <param name="src">
        /// input single-channel matrix. Note that unlike gemm, the
        ///  function can multiply not only floating-point matrices.
        /// </param>
        /// <param name="dst">
        /// output square matrix.
        /// </param>
        /// <param name="aTa">
        /// Flag specifying the multiplication ordering. See the
        ///  description below.
        /// </param>
        /// <param name="delta">
        /// Optional delta matrix subtracted from src before the
        ///  multiplication. When the matrix is empty ( delta=noArray() ), it is
        ///  assumed to be zero, that is, nothing is subtracted. If it has the same
        ///  size as src, it is simply subtracted. Otherwise, it is "repeated" (see
        ///  repeat ) to cover the full src and then subtracted. Type of the delta
        ///  matrix, when it is not empty, must be the same as the type of created
        ///  output matrix. See the dtype parameter description below.
        /// </param>
        /// <param name="scale">
        /// Optional scale factor for the matrix product.
        /// </param>
        /// <param name="dtype">
        /// Optional type of the output matrix. When it is negative,
        ///  the output matrix will have the same type as src . Otherwise, it will be
        ///  type=CV_MAT_DEPTH(dtype) that should be either CV_32F or CV_64F .
        ///  @sa calcCovarMatrix, gemm, repeat, reduce
        /// </param>
        public static void mulTransposed(Mat src, Mat dst, bool aTa, Mat delta, double scale, int dtype)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (delta != null) delta.ThrowIfDisposed();

            core_Core_mulTransposed_10(src.nativeObj, dst.nativeObj, aTa, delta.nativeObj, scale, dtype);


        }

        /// <summary>
        ///  Calculates the product of a matrix and its transposition.
        /// </summary>
        /// <remarks>
        ///  The function cv::mulTransposed calculates the product of src and its
        ///  transposition:
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} )^T ( \texttt{src} - \texttt{delta} )\f]
        ///  if aTa=true, and
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} ) ( \texttt{src} - \texttt{delta} )^T\f]
        ///  otherwise. The function is used to calculate the covariance matrix. With
        ///  zero delta, it can be used as a faster substitute for general matrix
        ///  product A\*B when B=A'
        /// </remarks>
        /// <param name="src">
        /// input single-channel matrix. Note that unlike gemm, the
        ///  function can multiply not only floating-point matrices.
        /// </param>
        /// <param name="dst">
        /// output square matrix.
        /// </param>
        /// <param name="aTa">
        /// Flag specifying the multiplication ordering. See the
        ///  description below.
        /// </param>
        /// <param name="delta">
        /// Optional delta matrix subtracted from src before the
        ///  multiplication. When the matrix is empty ( delta=noArray() ), it is
        ///  assumed to be zero, that is, nothing is subtracted. If it has the same
        ///  size as src, it is simply subtracted. Otherwise, it is "repeated" (see
        ///  repeat ) to cover the full src and then subtracted. Type of the delta
        ///  matrix, when it is not empty, must be the same as the type of created
        ///  output matrix. See the dtype parameter description below.
        /// </param>
        /// <param name="scale">
        /// Optional scale factor for the matrix product.
        /// </param>
        /// <param name="dtype">
        /// Optional type of the output matrix. When it is negative,
        ///  the output matrix will have the same type as src . Otherwise, it will be
        ///  type=CV_MAT_DEPTH(dtype) that should be either CV_32F or CV_64F .
        ///  @sa calcCovarMatrix, gemm, repeat, reduce
        /// </param>
        public static void mulTransposed(Mat src, Mat dst, bool aTa, Mat delta, double scale)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (delta != null) delta.ThrowIfDisposed();

            core_Core_mulTransposed_11(src.nativeObj, dst.nativeObj, aTa, delta.nativeObj, scale);


        }

        /// <summary>
        ///  Calculates the product of a matrix and its transposition.
        /// </summary>
        /// <remarks>
        ///  The function cv::mulTransposed calculates the product of src and its
        ///  transposition:
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} )^T ( \texttt{src} - \texttt{delta} )\f]
        ///  if aTa=true, and
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} ) ( \texttt{src} - \texttt{delta} )^T\f]
        ///  otherwise. The function is used to calculate the covariance matrix. With
        ///  zero delta, it can be used as a faster substitute for general matrix
        ///  product A\*B when B=A'
        /// </remarks>
        /// <param name="src">
        /// input single-channel matrix. Note that unlike gemm, the
        ///  function can multiply not only floating-point matrices.
        /// </param>
        /// <param name="dst">
        /// output square matrix.
        /// </param>
        /// <param name="aTa">
        /// Flag specifying the multiplication ordering. See the
        ///  description below.
        /// </param>
        /// <param name="delta">
        /// Optional delta matrix subtracted from src before the
        ///  multiplication. When the matrix is empty ( delta=noArray() ), it is
        ///  assumed to be zero, that is, nothing is subtracted. If it has the same
        ///  size as src, it is simply subtracted. Otherwise, it is "repeated" (see
        ///  repeat ) to cover the full src and then subtracted. Type of the delta
        ///  matrix, when it is not empty, must be the same as the type of created
        ///  output matrix. See the dtype parameter description below.
        /// </param>
        /// <param name="scale">
        /// Optional scale factor for the matrix product.
        /// </param>
        /// <param name="dtype">
        /// Optional type of the output matrix. When it is negative,
        ///  the output matrix will have the same type as src . Otherwise, it will be
        ///  type=CV_MAT_DEPTH(dtype) that should be either CV_32F or CV_64F .
        ///  @sa calcCovarMatrix, gemm, repeat, reduce
        /// </param>
        public static void mulTransposed(Mat src, Mat dst, bool aTa, Mat delta)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (delta != null) delta.ThrowIfDisposed();

            core_Core_mulTransposed_12(src.nativeObj, dst.nativeObj, aTa, delta.nativeObj);


        }

        /// <summary>
        ///  Calculates the product of a matrix and its transposition.
        /// </summary>
        /// <remarks>
        ///  The function cv::mulTransposed calculates the product of src and its
        ///  transposition:
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} )^T ( \texttt{src} - \texttt{delta} )\f]
        ///  if aTa=true, and
        ///  \f[\texttt{dst} = \texttt{scale} ( \texttt{src} - \texttt{delta} ) ( \texttt{src} - \texttt{delta} )^T\f]
        ///  otherwise. The function is used to calculate the covariance matrix. With
        ///  zero delta, it can be used as a faster substitute for general matrix
        ///  product A\*B when B=A'
        /// </remarks>
        /// <param name="src">
        /// input single-channel matrix. Note that unlike gemm, the
        ///  function can multiply not only floating-point matrices.
        /// </param>
        /// <param name="dst">
        /// output square matrix.
        /// </param>
        /// <param name="aTa">
        /// Flag specifying the multiplication ordering. See the
        ///  description below.
        /// </param>
        /// <param name="delta">
        /// Optional delta matrix subtracted from src before the
        ///  multiplication. When the matrix is empty ( delta=noArray() ), it is
        ///  assumed to be zero, that is, nothing is subtracted. If it has the same
        ///  size as src, it is simply subtracted. Otherwise, it is "repeated" (see
        ///  repeat ) to cover the full src and then subtracted. Type of the delta
        ///  matrix, when it is not empty, must be the same as the type of created
        ///  output matrix. See the dtype parameter description below.
        /// </param>
        /// <param name="scale">
        /// Optional scale factor for the matrix product.
        /// </param>
        /// <param name="dtype">
        /// Optional type of the output matrix. When it is negative,
        ///  the output matrix will have the same type as src . Otherwise, it will be
        ///  type=CV_MAT_DEPTH(dtype) that should be either CV_32F or CV_64F .
        ///  @sa calcCovarMatrix, gemm, repeat, reduce
        /// </param>
        public static void mulTransposed(Mat src, Mat dst, bool aTa)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_mulTransposed_13(src.nativeObj, dst.nativeObj, aTa);


        }


        //
        // C++:  void cv::transpose(Mat src, Mat& dst)
        //

        /// <summary>
        ///  Transposes a matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::transpose transposes the matrix src :
        ///  \f[\texttt{dst} (i,j) =  \texttt{src} (j,i)\f]
        ///  @note No complex conjugation is done in case of a complex matrix. It
        ///  should be done separately if needed.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="dst">
        /// output array of the same type as src.
        /// </param>
        public static void transpose(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_transpose_10(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::transposeND(Mat src, vector_int order, Mat& dst)
        //

        /// <summary>
        ///  Transpose for n-dimensional matrices.
        /// </summary>
        /// <remarks>
        ///     @note Input should be continuous single-channel matrix.
        /// </remarks>
        /// <param name="src">
        /// input array.
        /// </param>
        /// <param name="order">
        /// a permutation of [0,1,..,N-1] where N is the number of axes of src.
        ///     The i'th axis of dst will correspond to the axis numbered order[i] of the input.
        /// </param>
        /// <param name="dst">
        /// output array of the same type as src.
        /// </param>
        public static void transposeND(Mat src, MatOfInt order, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (order != null) order.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            Mat order_mat = order;
            core_Core_transposeND_10(src.nativeObj, order_mat.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::transform(Mat src, Mat& dst, Mat m)
        //

        /// <summary>
        ///  Performs the matrix transformation of every array element.
        /// </summary>
        /// <remarks>
        ///  The function cv::transform performs the matrix transformation of every
        ///  element of the array src and stores the results in dst :
        ///  \f[\texttt{dst} (I) =  \texttt{m} \cdot \texttt{src} (I)\f]
        ///  (when m.cols=src.channels() ), or
        ///  \f[\texttt{dst} (I) =  \texttt{m} \cdot [ \texttt{src} (I); 1]\f]
        ///  (when m.cols=src.channels()+1 )
        ///  
        ///  Every element of the N -channel array src is interpreted as N -element
        ///  vector that is transformed using the M x N or M x (N+1) matrix m to
        ///  M-element vector - the corresponding element of the output array dst .
        ///  
        ///  The function may be used for geometrical transformation of
        ///  N -dimensional points, arbitrary linear color space transformation (such
        ///  as various kinds of RGB to YUV transforms), shuffling the image
        ///  channels, and so forth.
        /// </remarks>
        /// <param name="src">
        /// input array that must have as many channels (1 to 4) as
        ///  m.cols or m.cols-1.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and depth as src; it has as
        ///  many channels as m.rows.
        /// </param>
        /// <param name="m">
        /// transformation 2x2 or 2x3 floating-point matrix.
        ///  @sa perspectiveTransform, getAffineTransform, estimateAffine2D, warpAffine, warpPerspective
        /// </param>
        public static void transform(Mat src, Mat dst, Mat m)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (m != null) m.ThrowIfDisposed();

            core_Core_transform_10(src.nativeObj, dst.nativeObj, m.nativeObj);


        }


        //
        // C++:  void cv::perspectiveTransform(Mat src, Mat& dst, Mat m)
        //

        /// <summary>
        ///  Performs the perspective matrix transformation of vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::perspectiveTransform transforms every element of src by
        ///  treating it as a 2D or 3D vector, in the following way:
        ///  \f[(x, y, z)  \rightarrow (x'/w, y'/w, z'/w)\f]
        ///  where
        ///  \f[(x', y', z', w') =  \texttt{mat} \cdot \begin{bmatrix} x &amp; y &amp; z &amp; 1  \end{bmatrix}\f]
        ///  and
        ///  \f[w =  \fork{w'}{if \(w' \ne 0\)}{\infty}{otherwise}\f]
        ///  
        ///  Here a 3D vector transformation is shown. In case of a 2D vector
        ///  transformation, the z component is omitted.
        ///  
        ///  @note The function transforms a sparse set of 2D or 3D vectors. If you
        ///  want to transform an image using perspective transformation, use
        ///  warpPerspective . If you have an inverse problem, that is, you want to
        ///  compute the most probable perspective transformation out of several
        ///  pairs of corresponding points, you can use getPerspectiveTransform or
        ///  findHomography .
        /// </remarks>
        /// <param name="src">
        /// input two-channel or three-channel floating-point array; each
        ///  element is a 2D/3D vector to be transformed.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        /// </param>
        /// <param name="m">
        /// 3x3 or 4x4 floating-point transformation matrix.
        ///  @sa  transform, warpPerspective, getPerspectiveTransform, findHomography
        /// </param>
        public static void perspectiveTransform(Mat src, Mat dst, Mat m)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (m != null) m.ThrowIfDisposed();

            core_Core_perspectiveTransform_10(src.nativeObj, dst.nativeObj, m.nativeObj);


        }


        //
        // C++:  void cv::completeSymm(Mat& m, bool lowerToUpper = false)
        //

        /// <summary>
        ///  Copies the lower or the upper half of a square matrix to its another half.
        /// </summary>
        /// <remarks>
        ///  The function cv::completeSymm copies the lower or the upper half of a square matrix to
        ///  its another half. The matrix diagonal remains unchanged:
        ///   - \f$\texttt{m}_{ij}=\texttt{m}_{ji}\f$ for \f$i &gt; j\f$ if
        ///      lowerToUpper=false
        ///   - \f$\texttt{m}_{ij}=\texttt{m}_{ji}\f$ for \f$i &lt; j\f$ if
        ///      lowerToUpper=true
        /// </remarks>
        /// <param name="m">
        /// input-output floating-point square matrix.
        /// </param>
        /// <param name="lowerToUpper">
        /// operation flag; if true, the lower half is copied to
        ///  the upper half. Otherwise, the upper half is copied to the lower half.
        ///  @sa flip, transpose
        /// </param>
        public static void completeSymm(Mat m, bool lowerToUpper)
        {
            if (m != null) m.ThrowIfDisposed();

            core_Core_completeSymm_10(m.nativeObj, lowerToUpper);


        }

        /// <summary>
        ///  Copies the lower or the upper half of a square matrix to its another half.
        /// </summary>
        /// <remarks>
        ///  The function cv::completeSymm copies the lower or the upper half of a square matrix to
        ///  its another half. The matrix diagonal remains unchanged:
        ///   - \f$\texttt{m}_{ij}=\texttt{m}_{ji}\f$ for \f$i &gt; j\f$ if
        ///      lowerToUpper=false
        ///   - \f$\texttt{m}_{ij}=\texttt{m}_{ji}\f$ for \f$i &lt; j\f$ if
        ///      lowerToUpper=true
        /// </remarks>
        /// <param name="m">
        /// input-output floating-point square matrix.
        /// </param>
        /// <param name="lowerToUpper">
        /// operation flag; if true, the lower half is copied to
        ///  the upper half. Otherwise, the upper half is copied to the lower half.
        ///  @sa flip, transpose
        /// </param>
        public static void completeSymm(Mat m)
        {
            if (m != null) m.ThrowIfDisposed();

            core_Core_completeSymm_11(m.nativeObj);


        }


        //
        // C++:  void cv::setIdentity(Mat& mtx, Scalar s = Scalar(1))
        //

        /// <summary>
        ///  Initializes a scaled identity matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::setIdentity initializes a scaled identity matrix:
        ///  \f[\texttt{mtx} (i,j)= \fork{\texttt{value}}{ if \(i=j\)}{0}{otherwise}\f]
        ///  
        ///  The function can also be emulated using the matrix initializers and the
        ///  matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      Mat A = Mat::eye(4, 3, CV_32F)*5;
        ///      // A will be set to [[5, 0, 0], [0, 5, 0], [0, 0, 5], [0, 0, 0]]
        /// </code>
        /// <param name="mtx">
        /// matrix to initialize (not necessarily square).
        /// </param>
        /// <param name="s">
        /// value to assign to diagonal elements.
        ///  @sa Mat::zeros, Mat::ones, Mat::setTo, Mat::operator=
        /// </param>
        public static void setIdentity(Mat mtx, Scalar s)
        {
            if (mtx != null) mtx.ThrowIfDisposed();

            core_Core_setIdentity_10(mtx.nativeObj, s.val[0], s.val[1], s.val[2], s.val[3]);


        }

        /// <summary>
        ///  Initializes a scaled identity matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::setIdentity initializes a scaled identity matrix:
        ///  \f[\texttt{mtx} (i,j)= \fork{\texttt{value}}{ if \(i=j\)}{0}{otherwise}\f]
        ///  
        ///  The function can also be emulated using the matrix initializers and the
        ///  matrix expressions:
        /// </remarks>
        /// <code language="c++">
        ///      Mat A = Mat::eye(4, 3, CV_32F)*5;
        ///      // A will be set to [[5, 0, 0], [0, 5, 0], [0, 0, 5], [0, 0, 0]]
        /// </code>
        /// <param name="mtx">
        /// matrix to initialize (not necessarily square).
        /// </param>
        /// <param name="s">
        /// value to assign to diagonal elements.
        ///  @sa Mat::zeros, Mat::ones, Mat::setTo, Mat::operator=
        /// </param>
        public static void setIdentity(Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed();

            core_Core_setIdentity_11(mtx.nativeObj);


        }


        //
        // C++:  double cv::determinant(Mat mtx)
        //

        /// <summary>
        ///  Returns the determinant of a square floating-point matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::determinant calculates and returns the determinant of the
        ///  specified matrix. For small matrices ( mtx.cols=mtx.rows&lt;=3 ), the
        ///  direct method is used. For larger matrices, the function uses LU
        ///  factorization with partial pivoting.
        ///  
        ///  For symmetric positively-determined matrices, it is also possible to use
        ///  eigen decomposition to calculate the determinant.
        /// </remarks>
        /// <param name="mtx">
        /// input matrix that must have CV_32FC1 or CV_64FC1 type and
        ///  square size.
        ///  @sa trace, invert, solve, eigen, @ref MatrixExpressions
        /// </param>
        public static double determinant(Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed();

            return core_Core_determinant_10(mtx.nativeObj);


        }


        //
        // C++:  Scalar cv::trace(Mat mtx)
        //

        /// <summary>
        ///  Returns the trace of a matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::trace returns the sum of the diagonal elements of the
        ///  matrix mtx .
        ///  \f[\mathrm{tr} ( \texttt{mtx} ) =  \sum _i  \texttt{mtx} (i,i)\f]
        /// </remarks>
        /// <param name="mtx">
        /// input matrix.
        /// </param>
        public static Scalar trace(Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed();

            double[] tmpArray = new double[4];
            core_Core_trace_10(mtx.nativeObj, tmpArray);
            Scalar retVal = new Scalar(tmpArray);

            return retVal;
        }


        //
        // C++:  double cv::invert(Mat src, Mat& dst, int flags = DECOMP_LU)
        //

        /// <summary>
        ///  Finds the inverse or pseudo-inverse of a matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::invert inverts the matrix src and stores the result in dst
        ///  . When the matrix src is singular or non-square, the function calculates
        ///  the pseudo-inverse matrix (the dst matrix) so that norm(src\*dst - I) is
        ///  minimal, where I is an identity matrix.
        ///  
        ///  In case of the #DECOMP_LU method, the function returns non-zero value if
        ///  the inverse has been successfully calculated and 0 if src is singular.
        ///  
        ///  In case of the #DECOMP_SVD method, the function returns the inverse
        ///  condition number of src (the ratio of the smallest singular value to the
        ///  largest singular value) and 0 if src is singular. The SVD method
        ///  calculates a pseudo-inverse matrix if src is singular.
        ///  
        ///  Similarly to #DECOMP_LU, the method #DECOMP_CHOLESKY works only with
        ///  non-singular square matrices that should also be symmetrical and
        ///  positively defined. In this case, the function stores the inverted
        ///  matrix in dst and returns non-zero. Otherwise, it returns 0.
        /// </remarks>
        /// <param name="src">
        /// input floating-point M x N matrix.
        /// </param>
        /// <param name="dst">
        /// output matrix of N x M size and the same type as src.
        /// </param>
        /// <param name="flags">
        /// inversion method (cv::DecompTypes)
        ///  @sa solve, SVD
        /// </param>
        public static double invert(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            return core_Core_invert_10(src.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Finds the inverse or pseudo-inverse of a matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::invert inverts the matrix src and stores the result in dst
        ///  . When the matrix src is singular or non-square, the function calculates
        ///  the pseudo-inverse matrix (the dst matrix) so that norm(src\*dst - I) is
        ///  minimal, where I is an identity matrix.
        ///  
        ///  In case of the #DECOMP_LU method, the function returns non-zero value if
        ///  the inverse has been successfully calculated and 0 if src is singular.
        ///  
        ///  In case of the #DECOMP_SVD method, the function returns the inverse
        ///  condition number of src (the ratio of the smallest singular value to the
        ///  largest singular value) and 0 if src is singular. The SVD method
        ///  calculates a pseudo-inverse matrix if src is singular.
        ///  
        ///  Similarly to #DECOMP_LU, the method #DECOMP_CHOLESKY works only with
        ///  non-singular square matrices that should also be symmetrical and
        ///  positively defined. In this case, the function stores the inverted
        ///  matrix in dst and returns non-zero. Otherwise, it returns 0.
        /// </remarks>
        /// <param name="src">
        /// input floating-point M x N matrix.
        /// </param>
        /// <param name="dst">
        /// output matrix of N x M size and the same type as src.
        /// </param>
        /// <param name="flags">
        /// inversion method (cv::DecompTypes)
        ///  @sa solve, SVD
        /// </param>
        public static double invert(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            return core_Core_invert_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  bool cv::solve(Mat src1, Mat src2, Mat& dst, int flags = DECOMP_LU)
        //

        /// <summary>
        ///  Solves one or more linear systems or least-squares problems.
        /// </summary>
        /// <remarks>
        ///  The function cv::solve solves a linear system or least-squares problem (the
        ///  latter is possible with SVD or QR methods, or by specifying the flag
        ///  #DECOMP_NORMAL ):
        ///  \f[\texttt{dst} =  \arg \min _X \| \texttt{src1} \cdot \texttt{X} -  \texttt{src2} \|\f]
        ///  
        ///  If #DECOMP_LU or #DECOMP_CHOLESKY method is used, the function returns 1
        ///  if src1 (or \f$\texttt{src1}^T\texttt{src1}\f$ ) is non-singular. Otherwise,
        ///  it returns 0. In the latter case, dst is not valid. Other methods find a
        ///  pseudo-solution in case of a singular left-hand side part.
        ///  
        ///  @note If you want to find a unity-norm solution of an under-defined
        ///  singular system \f$\texttt{src1}\cdot\texttt{dst}=0\f$ , the function solve
        ///  will not do the work. Use SVD::solveZ instead.
        /// </remarks>
        /// <param name="src1">
        /// input matrix on the left-hand side of the system.
        /// </param>
        /// <param name="src2">
        /// input matrix on the right-hand side of the system.
        /// </param>
        /// <param name="dst">
        /// output solution.
        /// </param>
        /// <param name="flags">
        /// solution (matrix inversion) method (#DecompTypes)
        ///  @sa invert, SVD, eigen
        /// </param>
        public static bool solve(Mat src1, Mat src2, Mat dst, int flags)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            return core_Core_solve_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Solves one or more linear systems or least-squares problems.
        /// </summary>
        /// <remarks>
        ///  The function cv::solve solves a linear system or least-squares problem (the
        ///  latter is possible with SVD or QR methods, or by specifying the flag
        ///  #DECOMP_NORMAL ):
        ///  \f[\texttt{dst} =  \arg \min _X \| \texttt{src1} \cdot \texttt{X} -  \texttt{src2} \|\f]
        ///  
        ///  If #DECOMP_LU or #DECOMP_CHOLESKY method is used, the function returns 1
        ///  if src1 (or \f$\texttt{src1}^T\texttt{src1}\f$ ) is non-singular. Otherwise,
        ///  it returns 0. In the latter case, dst is not valid. Other methods find a
        ///  pseudo-solution in case of a singular left-hand side part.
        ///  
        ///  @note If you want to find a unity-norm solution of an under-defined
        ///  singular system \f$\texttt{src1}\cdot\texttt{dst}=0\f$ , the function solve
        ///  will not do the work. Use SVD::solveZ instead.
        /// </remarks>
        /// <param name="src1">
        /// input matrix on the left-hand side of the system.
        /// </param>
        /// <param name="src2">
        /// input matrix on the right-hand side of the system.
        /// </param>
        /// <param name="dst">
        /// output solution.
        /// </param>
        /// <param name="flags">
        /// solution (matrix inversion) method (#DecompTypes)
        ///  @sa invert, SVD, eigen
        /// </param>
        public static bool solve(Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (src2 != null) src2.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            return core_Core_solve_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::sort(Mat src, Mat& dst, int flags)
        //

        /// <summary>
        ///  Sorts each row or each column of a matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::sort sorts each matrix row or each matrix column in
        ///  ascending or descending order. So you should pass two operation flags to
        ///  get desired behaviour. If you want to sort matrix rows or columns
        ///  lexicographically, you can use STL std::sort generic function with the
        ///  proper comparison predicate.
        /// </remarks>
        /// <param name="src">
        /// input single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        /// </param>
        /// <param name="flags">
        /// operation flags, a combination of #SortFlags
        ///  @sa sortIdx, randShuffle
        /// </param>
        public static void sort(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_sort_10(src.nativeObj, dst.nativeObj, flags);


        }


        //
        // C++:  void cv::sortIdx(Mat src, Mat& dst, int flags)
        //

        /// <summary>
        ///  Sorts each row or each column of a matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::sortIdx sorts each matrix row or each matrix column in the
        ///  ascending or descending order. So you should pass two operation flags to
        ///  get desired behaviour. Instead of reordering the elements themselves, it
        ///  stores the indices of sorted elements in the output array. For example:
        /// </remarks>
        /// <code language="c++">
        ///      Mat A = Mat::eye(3,3,CV_32F), B;
        ///      sortIdx(A, B, SORT_EVERY_ROW + SORT_ASCENDING);
        ///      // B will probably contain
        ///      // (because of equal elements in A some permutations are possible):
        ///      // [[1, 2, 0], [0, 2, 1], [0, 1, 2]]
        /// </code>
        /// <param name="src">
        /// input single-channel array.
        /// </param>
        /// <param name="dst">
        /// output integer array of the same size as src.
        /// </param>
        /// <param name="flags">
        /// operation flags that could be a combination of cv::SortFlags
        ///  @sa sort, randShuffle
        /// </param>
        public static void sortIdx(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_sortIdx_10(src.nativeObj, dst.nativeObj, flags);


        }


        //
        // C++:  int cv::solveCubic(Mat coeffs, Mat& roots)
        //

        /// <summary>
        ///  Finds the real roots of a cubic equation.
        /// </summary>
        /// <remarks>
        ///  The function solveCubic finds the real roots of a cubic equation:
        ///  -   if coeffs is a 4-element vector:
        ///  \f[\texttt{coeffs} [0] x^3 +  \texttt{coeffs} [1] x^2 +  \texttt{coeffs} [2] x +  \texttt{coeffs} [3] = 0\f]
        ///  -   if coeffs is a 3-element vector:
        ///  \f[x^3 +  \texttt{coeffs} [0] x^2 +  \texttt{coeffs} [1] x +  \texttt{coeffs} [2] = 0\f]
        ///  
        ///  The roots are stored in the roots array.
        /// </remarks>
        /// <param name="coeffs">
        /// equation coefficients, an array of 3 or 4 elements.
        /// </param>
        /// <param name="roots">
        /// output array of real roots that has 1 or 3 elements.
        /// </param>
        /// <returns>
        ///  number of real roots. It can be 0, 1 or 2.
        /// </returns>
        public static int solveCubic(Mat coeffs, Mat roots)
        {
            if (coeffs != null) coeffs.ThrowIfDisposed();
            if (roots != null) roots.ThrowIfDisposed();

            return core_Core_solveCubic_10(coeffs.nativeObj, roots.nativeObj);


        }


        //
        // C++:  double cv::solvePoly(Mat coeffs, Mat& roots, int maxIters = 300)
        //

        /// <summary>
        ///  Finds the real or complex roots of a polynomial equation.
        /// </summary>
        /// <remarks>
        ///  The function cv::solvePoly finds real and complex roots of a polynomial equation:
        ///  \f[\texttt{coeffs} [n] x^{n} +  \texttt{coeffs} [n-1] x^{n-1} + ... +  \texttt{coeffs} [1] x +  \texttt{coeffs} [0] = 0\f]
        /// </remarks>
        /// <param name="coeffs">
        /// array of polynomial coefficients.
        /// </param>
        /// <param name="roots">
        /// output (complex) array of roots.
        /// </param>
        /// <param name="maxIters">
        /// maximum number of iterations the algorithm does.
        /// </param>
        public static double solvePoly(Mat coeffs, Mat roots, int maxIters)
        {
            if (coeffs != null) coeffs.ThrowIfDisposed();
            if (roots != null) roots.ThrowIfDisposed();

            return core_Core_solvePoly_10(coeffs.nativeObj, roots.nativeObj, maxIters);


        }

        /// <summary>
        ///  Finds the real or complex roots of a polynomial equation.
        /// </summary>
        /// <remarks>
        ///  The function cv::solvePoly finds real and complex roots of a polynomial equation:
        ///  \f[\texttt{coeffs} [n] x^{n} +  \texttt{coeffs} [n-1] x^{n-1} + ... +  \texttt{coeffs} [1] x +  \texttt{coeffs} [0] = 0\f]
        /// </remarks>
        /// <param name="coeffs">
        /// array of polynomial coefficients.
        /// </param>
        /// <param name="roots">
        /// output (complex) array of roots.
        /// </param>
        /// <param name="maxIters">
        /// maximum number of iterations the algorithm does.
        /// </param>
        public static double solvePoly(Mat coeffs, Mat roots)
        {
            if (coeffs != null) coeffs.ThrowIfDisposed();
            if (roots != null) roots.ThrowIfDisposed();

            return core_Core_solvePoly_11(coeffs.nativeObj, roots.nativeObj);


        }


        //
        // C++:  bool cv::eigen(Mat src, Mat& eigenvalues, Mat& eigenvectors = Mat())
        //

        /// <summary>
        ///  Calculates eigenvalues and eigenvectors of a symmetric matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::eigen calculates just eigenvalues, or eigenvalues and eigenvectors of the symmetric
        ///  matrix src:
        /// </remarks>
        /// <code language="c++">
        ///      src*eigenvectors.row(i).t() = eigenvalues.at&lt;srcType&gt;(i)*eigenvectors.row(i).t()
        /// </code>
        /// <remarks>
        ///  @note Use cv::eigenNonSymmetric for calculation of real eigenvalues and eigenvectors of non-symmetric matrix.
        /// </remarks>
        /// <param name="src">
        /// input matrix that must have CV_32FC1 or CV_64FC1 type, square size and be symmetrical
        ///  (src ^T^ == src).
        /// </param>
        /// <param name="eigenvalues">
        /// output vector of eigenvalues of the same type as src; the eigenvalues are stored
        ///  in the descending order.
        /// </param>
        /// <param name="eigenvectors">
        /// output matrix of eigenvectors; it has the same size and type as src; the
        ///  eigenvectors are stored as subsequent matrix rows, in the same order as the corresponding
        ///  eigenvalues.
        ///  @sa eigenNonSymmetric, completeSymm, PCA
        /// </param>
        public static bool eigen(Mat src, Mat eigenvalues, Mat eigenvectors)
        {
            if (src != null) src.ThrowIfDisposed();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();

            return core_Core_eigen_10(src.nativeObj, eigenvalues.nativeObj, eigenvectors.nativeObj);


        }

        /// <summary>
        ///  Calculates eigenvalues and eigenvectors of a symmetric matrix.
        /// </summary>
        /// <remarks>
        ///  The function cv::eigen calculates just eigenvalues, or eigenvalues and eigenvectors of the symmetric
        ///  matrix src:
        /// </remarks>
        /// <code language="c++">
        ///      src*eigenvectors.row(i).t() = eigenvalues.at&lt;srcType&gt;(i)*eigenvectors.row(i).t()
        /// </code>
        /// <remarks>
        ///  @note Use cv::eigenNonSymmetric for calculation of real eigenvalues and eigenvectors of non-symmetric matrix.
        /// </remarks>
        /// <param name="src">
        /// input matrix that must have CV_32FC1 or CV_64FC1 type, square size and be symmetrical
        ///  (src ^T^ == src).
        /// </param>
        /// <param name="eigenvalues">
        /// output vector of eigenvalues of the same type as src; the eigenvalues are stored
        ///  in the descending order.
        /// </param>
        /// <param name="eigenvectors">
        /// output matrix of eigenvectors; it has the same size and type as src; the
        ///  eigenvectors are stored as subsequent matrix rows, in the same order as the corresponding
        ///  eigenvalues.
        ///  @sa eigenNonSymmetric, completeSymm, PCA
        /// </param>
        public static bool eigen(Mat src, Mat eigenvalues)
        {
            if (src != null) src.ThrowIfDisposed();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed();

            return core_Core_eigen_11(src.nativeObj, eigenvalues.nativeObj);


        }


        //
        // C++:  void cv::eigenNonSymmetric(Mat src, Mat& eigenvalues, Mat& eigenvectors)
        //

        /// <summary>
        ///  Calculates eigenvalues and eigenvectors of a non-symmetric matrix (real eigenvalues only).
        /// </summary>
        /// <remarks>
        ///  @note Assumes real eigenvalues.
        ///  
        ///  The function calculates eigenvalues and eigenvectors (optional) of the square matrix src:
        /// </remarks>
        /// <code language="c++">
        ///      src*eigenvectors.row(i).t() = eigenvalues.at&lt;srcType&gt;(i)*eigenvectors.row(i).t()
        /// </code>
        /// <param name="src">
        /// input matrix (CV_32FC1 or CV_64FC1 type).
        /// </param>
        /// <param name="eigenvalues">
        /// output vector of eigenvalues (type is the same type as src).
        /// </param>
        /// <param name="eigenvectors">
        /// output matrix of eigenvectors (type is the same type as src). The eigenvectors are stored as subsequent matrix rows, in the same order as the corresponding eigenvalues.
        ///  @sa eigen
        /// </param>
        public static void eigenNonSymmetric(Mat src, Mat eigenvalues, Mat eigenvectors)
        {
            if (src != null) src.ThrowIfDisposed();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();

            core_Core_eigenNonSymmetric_10(src.nativeObj, eigenvalues.nativeObj, eigenvectors.nativeObj);


        }


        //
        // C++:  void cv::calcCovarMatrix(Mat samples, Mat& covar, Mat& mean, int flags, int ctype = CV_64F)
        //

        /// <remarks>
        ///  @overload
        ///  @note use #COVAR_ROWS or #COVAR_COLS flag
        /// </remarks>
        /// <param name="samples">
        /// samples stored as rows/columns of a single matrix.
        /// </param>
        /// <param name="covar">
        /// output covariance matrix of the type ctype and square size.
        /// </param>
        /// <param name="mean">
        /// input or output (depending on the flags) array as the average value of the input vectors.
        /// </param>
        /// <param name="flags">
        /// operation flags as a combination of #CovarFlags
        /// </param>
        /// <param name="ctype">
        /// type of the matrixl; it equals 'CV_64F' by default.
        /// </param>
        public static void calcCovarMatrix(Mat samples, Mat covar, Mat mean, int flags, int ctype)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (covar != null) covar.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();

            core_Core_calcCovarMatrix_10(samples.nativeObj, covar.nativeObj, mean.nativeObj, flags, ctype);


        }

        /// <remarks>
        ///  @overload
        ///  @note use #COVAR_ROWS or #COVAR_COLS flag
        /// </remarks>
        /// <param name="samples">
        /// samples stored as rows/columns of a single matrix.
        /// </param>
        /// <param name="covar">
        /// output covariance matrix of the type ctype and square size.
        /// </param>
        /// <param name="mean">
        /// input or output (depending on the flags) array as the average value of the input vectors.
        /// </param>
        /// <param name="flags">
        /// operation flags as a combination of #CovarFlags
        /// </param>
        /// <param name="ctype">
        /// type of the matrixl; it equals 'CV_64F' by default.
        /// </param>
        public static void calcCovarMatrix(Mat samples, Mat covar, Mat mean, int flags)
        {
            if (samples != null) samples.ThrowIfDisposed();
            if (covar != null) covar.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();

            core_Core_calcCovarMatrix_11(samples.nativeObj, covar.nativeObj, mean.nativeObj, flags);


        }


        //
        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, int maxComponents = 0)
        //

        /// <remarks>
        ///  wrap PCA::operator()
        /// </remarks>
        public static void PCACompute(Mat data, Mat mean, Mat eigenvectors, int maxComponents)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();

            core_Core_PCACompute_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, maxComponents);


        }

        /// <remarks>
        ///  wrap PCA::operator()
        /// </remarks>
        public static void PCACompute(Mat data, Mat mean, Mat eigenvectors)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();

            core_Core_PCACompute_11(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj);


        }


        //
        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, Mat& eigenvalues, int maxComponents = 0)
        //

        /// <remarks>
        ///  wrap PCA::operator() and add eigenvalues output parameter
        /// </remarks>
        public static void PCACompute2(Mat data, Mat mean, Mat eigenvectors, Mat eigenvalues, int maxComponents)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed();

            core_Core_PCACompute2_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, eigenvalues.nativeObj, maxComponents);


        }

        /// <remarks>
        ///  wrap PCA::operator() and add eigenvalues output parameter
        /// </remarks>
        public static void PCACompute2(Mat data, Mat mean, Mat eigenvectors, Mat eigenvalues)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed();

            core_Core_PCACompute2_11(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, eigenvalues.nativeObj);


        }


        //
        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, double retainedVariance)
        //

        /// <remarks>
        ///  wrap PCA::operator()
        /// </remarks>
        public static void PCACompute(Mat data, Mat mean, Mat eigenvectors, double retainedVariance)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();

            core_Core_PCACompute_12(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, retainedVariance);


        }


        //
        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, Mat& eigenvalues, double retainedVariance)
        //

        /// <remarks>
        ///  wrap PCA::operator() and add eigenvalues output parameter
        /// </remarks>
        public static void PCACompute2(Mat data, Mat mean, Mat eigenvectors, Mat eigenvalues, double retainedVariance)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed();

            core_Core_PCACompute2_12(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, eigenvalues.nativeObj, retainedVariance);


        }


        //
        // C++:  void cv::PCAProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        //

        /// <remarks>
        ///  wrap PCA::project
        /// </remarks>
        public static void PCAProject(Mat data, Mat mean, Mat eigenvectors, Mat result)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            core_Core_PCAProject_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, result.nativeObj);


        }


        //
        // C++:  void cv::PCABackProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        //

        /// <remarks>
        ///  wrap PCA::backProject
        /// </remarks>
        public static void PCABackProject(Mat data, Mat mean, Mat eigenvectors, Mat result)
        {
            if (data != null) data.ThrowIfDisposed();
            if (mean != null) mean.ThrowIfDisposed();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed();
            if (result != null) result.ThrowIfDisposed();

            core_Core_PCABackProject_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, result.nativeObj);


        }


        //
        // C++:  void cv::SVDecomp(Mat src, Mat& w, Mat& u, Mat& vt, int flags = 0)
        //

        /// <remarks>
        ///  wrap SVD::compute
        /// </remarks>
        public static void SVDecomp(Mat src, Mat w, Mat u, Mat vt, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (w != null) w.ThrowIfDisposed();
            if (u != null) u.ThrowIfDisposed();
            if (vt != null) vt.ThrowIfDisposed();

            core_Core_SVDecomp_10(src.nativeObj, w.nativeObj, u.nativeObj, vt.nativeObj, flags);


        }

        /// <remarks>
        ///  wrap SVD::compute
        /// </remarks>
        public static void SVDecomp(Mat src, Mat w, Mat u, Mat vt)
        {
            if (src != null) src.ThrowIfDisposed();
            if (w != null) w.ThrowIfDisposed();
            if (u != null) u.ThrowIfDisposed();
            if (vt != null) vt.ThrowIfDisposed();

            core_Core_SVDecomp_11(src.nativeObj, w.nativeObj, u.nativeObj, vt.nativeObj);


        }


        //
        // C++:  void cv::SVBackSubst(Mat w, Mat u, Mat vt, Mat rhs, Mat& dst)
        //

        /// <remarks>
        ///  wrap SVD::backSubst
        /// </remarks>
        public static void SVBackSubst(Mat w, Mat u, Mat vt, Mat rhs, Mat dst)
        {
            if (w != null) w.ThrowIfDisposed();
            if (u != null) u.ThrowIfDisposed();
            if (vt != null) vt.ThrowIfDisposed();
            if (rhs != null) rhs.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_SVBackSubst_10(w.nativeObj, u.nativeObj, vt.nativeObj, rhs.nativeObj, dst.nativeObj);


        }


        //
        // C++:  double cv::Mahalanobis(Mat v1, Mat v2, Mat icovar)
        //

        /// <summary>
        ///  Calculates the Mahalanobis distance between two vectors.
        /// </summary>
        /// <remarks>
        ///  The function cv::Mahalanobis calculates and returns the weighted distance between two vectors:
        ///  \f[d( \texttt{vec1} , \texttt{vec2} )= \sqrt{\sum_{i,j}{\texttt{icovar(i,j)}\cdot(\texttt{vec1}(I)-\texttt{vec2}(I))\cdot(\texttt{vec1(j)}-\texttt{vec2(j)})} }\f]
        ///  The covariance matrix may be calculated using the #calcCovarMatrix function and then inverted using
        ///  the invert function (preferably using the #DECOMP_SVD method, as the most accurate).
        /// </remarks>
        /// <param name="v1">
        /// first 1D input vector.
        /// </param>
        /// <param name="v2">
        /// second 1D input vector.
        /// </param>
        /// <param name="icovar">
        /// inverse covariance matrix.
        /// </param>
        public static double Mahalanobis(Mat v1, Mat v2, Mat icovar)
        {
            if (v1 != null) v1.ThrowIfDisposed();
            if (v2 != null) v2.ThrowIfDisposed();
            if (icovar != null) icovar.ThrowIfDisposed();

            return core_Core_Mahalanobis_10(v1.nativeObj, v2.nativeObj, icovar.nativeObj);


        }


        //
        // C++:  void cv::dft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        //

        /// <summary>
        ///  Performs a forward or inverse Discrete Fourier transform of a 1D or 2D floating-point array.
        /// </summary>
        /// <remarks>
        ///  The function cv::dft performs one of the following:
        ///  -   Forward the Fourier transform of a 1D vector of N elements:
        ///      \f[Y = F^{(N)}  \cdot X,\f]
        ///      where \f$F^{(N)}_{jk}=\exp(-2\pi i j k/N)\f$ and \f$i=\sqrt{-1}\f$
        ///  -   Inverse the Fourier transform of a 1D vector of N elements:
        ///      \f[\begin{array}{l} X'=  \left (F^{(N)} \right )^{-1}  \cdot Y =  \left (F^{(N)} \right )^*  \cdot y  \\ X = (1/N)  \cdot X, \end{array}\f]
        ///      where \f$F^*=\left(\textrm{Re}(F^{(N)})-\textrm{Im}(F^{(N)})\right)^T\f$
        ///  -   Forward the 2D Fourier transform of a M x N matrix:
        ///      \f[Y = F^{(M)}  \cdot X  \cdot F^{(N)}\f]
        ///  -   Inverse the 2D Fourier transform of a M x N matrix:
        ///      \f[\begin{array}{l} X'=  \left (F^{(M)} \right )^*  \cdot Y  \cdot \left (F^{(N)} \right )^* \\ X =  \frac{1}{M \cdot N} \cdot X' \end{array}\f]
        ///  
        ///  In case of real (single-channel) data, the output spectrum of the forward Fourier transform or input
        ///  spectrum of the inverse Fourier transform can be represented in a packed format called *CCS*
        ///  (complex-conjugate-symmetrical). It was borrowed from IPL (Intel\* Image Processing Library). Here
        ///  is how 2D *CCS* spectrum looks:
        ///  \f[\begin{bmatrix} Re Y_{0,0} &amp; Re Y_{0,1} &amp; Im Y_{0,1} &amp; Re Y_{0,2} &amp; Im Y_{0,2} &amp;  \cdots &amp; Re Y_{0,N/2-1} &amp; Im Y_{0,N/2-1} &amp; Re Y_{0,N/2}  \\ Re Y_{1,0} &amp; Re Y_{1,1} &amp; Im Y_{1,1} &amp; Re Y_{1,2} &amp; Im Y_{1,2} &amp;  \cdots &amp; Re Y_{1,N/2-1} &amp; Im Y_{1,N/2-1} &amp; Re Y_{1,N/2}  \\ Im Y_{1,0} &amp; Re Y_{2,1} &amp; Im Y_{2,1} &amp; Re Y_{2,2} &amp; Im Y_{2,2} &amp;  \cdots &amp; Re Y_{2,N/2-1} &amp; Im Y_{2,N/2-1} &amp; Im Y_{1,N/2}  \\ \hdotsfor{9} \\ Re Y_{M/2-1,0} &amp;  Re Y_{M-3,1}  &amp; Im Y_{M-3,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-3,N/2-1} &amp; Im Y_{M-3,N/2-1}&amp; Re Y_{M/2-1,N/2}  \\ Im Y_{M/2-1,0} &amp;  Re Y_{M-2,1}  &amp; Im Y_{M-2,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-2,N/2-1} &amp; Im Y_{M-2,N/2-1}&amp; Im Y_{M/2-1,N/2}  \\ Re Y_{M/2,0}  &amp;  Re Y_{M-1,1} &amp;  Im Y_{M-1,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-1,N/2-1} &amp; Im Y_{M-1,N/2-1}&amp; Re Y_{M/2,N/2} \end{bmatrix}\f]
        ///  
        ///  In case of 1D transform of a real vector, the output looks like the first row of the matrix above.
        ///  
        ///  So, the function chooses an operation mode depending on the flags and size of the input array:
        ///  -   If #DFT_ROWS is set or the input array has a single row or single column, the function
        ///      performs a 1D forward or inverse transform of each row of a matrix when #DFT_ROWS is set.
        ///      Otherwise, it performs a 2D transform.
        ///  -   If the input array is real and #DFT_INVERSE is not set, the function performs a forward 1D or
        ///      2D transform:
        ///      -   When #DFT_COMPLEX_OUTPUT is set, the output is a complex matrix of the same size as
        ///          input.
        ///      -   When #DFT_COMPLEX_OUTPUT is not set, the output is a real matrix of the same size as
        ///          input. In case of 2D transform, it uses the packed format as shown above. In case of a
        ///          single 1D transform, it looks like the first row of the matrix above. In case of
        ///          multiple 1D transforms (when using the #DFT_ROWS flag), each row of the output matrix
        ///          looks like the first row of the matrix above.
        ///  -   If the input array is complex and either #DFT_INVERSE or #DFT_REAL_OUTPUT are not set, the
        ///      output is a complex array of the same size as input. The function performs a forward or
        ///      inverse 1D or 2D transform of the whole input array or each row of the input array
        ///      independently, depending on the flags DFT_INVERSE and DFT_ROWS.
        ///  -   When #DFT_INVERSE is set and the input array is real, or it is complex but #DFT_REAL_OUTPUT
        ///      is set, the output is a real array of the same size as input. The function performs a 1D or 2D
        ///      inverse transformation of the whole input array or each individual row, depending on the flags
        ///      #DFT_INVERSE and #DFT_ROWS.
        ///  
        ///  If #DFT_SCALE is set, the scaling is done after the transformation.
        ///  
        ///  Unlike dct, the function supports arrays of arbitrary size. But only those arrays are processed
        ///  efficiently, whose sizes can be factorized in a product of small prime numbers (2, 3, and 5 in the
        ///  current implementation). Such an efficient DFT size can be calculated using the getOptimalDFTSize
        ///  method.
        ///  
        ///  The sample below illustrates how to calculate a DFT-based convolution of two 2D real arrays:
        /// </remarks>
        /// <code language="c++">
        ///      void convolveDFT(InputArray A, InputArray B, OutputArray C)
        ///      {
        ///          // reallocate the output array if needed
        ///          C.create(abs(A.rows - B.rows)+1, abs(A.cols - B.cols)+1, A.type());
        ///          Size dftSize;
        ///          // calculate the size of DFT transform
        ///          dftSize.width = getOptimalDFTSize(A.cols + B.cols - 1);
        ///          dftSize.height = getOptimalDFTSize(A.rows + B.rows - 1);
        ///  
        ///          // allocate temporary buffers and initialize them with 0's
        ///          Mat tempA(dftSize, A.type(), Scalar::all(0));
        ///          Mat tempB(dftSize, B.type(), Scalar::all(0));
        ///  
        ///          // copy A and B to the top-left corners of tempA and tempB, respectively
        ///          Mat roiA(tempA, Rect(0,0,A.cols,A.rows));
        ///          A.copyTo(roiA);
        ///          Mat roiB(tempB, Rect(0,0,B.cols,B.rows));
        ///          B.copyTo(roiB);
        ///  
        ///          // now transform the padded A &amp; B in-place;
        ///          // use "nonzeroRows" hint for faster processing
        ///          dft(tempA, tempA, 0, A.rows);
        ///          dft(tempB, tempB, 0, B.rows);
        ///  
        ///          // multiply the spectrums;
        ///          // the function handles packed spectrum representations well
        ///          mulSpectrums(tempA, tempB, tempA);
        ///  
        ///          // transform the product back from the frequency domain.
        ///          // Even though all the result rows will be non-zero,
        ///          // you need only the first C.rows of them, and thus you
        ///          // pass nonzeroRows == C.rows
        ///          dft(tempA, tempA, DFT_INVERSE + DFT_SCALE, C.rows);
        ///  
        ///          // now copy the result back to C.
        ///          tempA(Rect(0, 0, C.cols, C.rows)).copyTo(C);
        ///  
        ///          // all the temporary buffers will be deallocated automatically
        ///      }
        /// </code>
        /// <remarks>
        ///  To optimize this sample, consider the following approaches:
        ///  -   Since nonzeroRows != 0 is passed to the forward transform calls and since A and B are copied to
        ///      the top-left corners of tempA and tempB, respectively, it is not necessary to clear the whole
        ///      tempA and tempB. It is only necessary to clear the tempA.cols - A.cols ( tempB.cols - B.cols)
        ///      rightmost columns of the matrices.
        ///  -   This DFT-based convolution does not have to be applied to the whole big arrays, especially if B
        ///      is significantly smaller than A or vice versa. Instead, you can calculate convolution by parts.
        ///      To do this, you need to split the output array C into multiple tiles. For each tile, estimate
        ///      which parts of A and B are required to calculate convolution in this tile. If the tiles in C are
        ///      too small, the speed will decrease a lot because of repeated work. In the ultimate case, when
        ///      each tile in C is a single pixel, the algorithm becomes equivalent to the naive convolution
        ///      algorithm. If the tiles are too big, the temporary arrays tempA and tempB become too big and
        ///      there is also a slowdown because of bad cache locality. So, there is an optimal tile size
        ///      somewhere in the middle.
        ///  -   If different tiles in C can be calculated in parallel and, thus, the convolution is done by
        ///      parts, the loop can be threaded.
        ///  
        ///  All of the above improvements have been implemented in #matchTemplate and #filter2D . Therefore, by
        ///  using them, you can get the performance even better than with the above theoretically optimal
        ///  implementation. Though, those two functions actually calculate cross-correlation, not convolution,
        ///  so you need to "flip" the second convolution operand B vertically and horizontally using flip .
        ///  @note
        ///  -   An example using the discrete fourier transform can be found at
        ///      opencv_source_code/samples/cpp/dft.cpp
        ///  -   (Python) An example using the dft functionality to perform Wiener deconvolution can be found
        ///      at opencv_source/samples/python/deconvolution.py
        ///  -   (Python) An example rearranging the quadrants of a Fourier image can be found at
        ///      opencv_source/samples/python/dft.py
        /// </remarks>
        /// <param name="src">
        /// input array that could be real or complex.
        /// </param>
        /// <param name="dst">
        /// output array whose size and type depends on the flags .
        /// </param>
        /// <param name="flags">
        /// transformation flags, representing a combination of the #DftFlags
        /// </param>
        /// <param name="nonzeroRows">
        /// when the parameter is not zero, the function assumes that only the first
        ///  nonzeroRows rows of the input array (#DFT_INVERSE is not set) or only the first nonzeroRows of the
        ///  output array (#DFT_INVERSE is set) contain non-zeros, thus, the function can handle the rest of the
        ///  rows more efficiently and save some time; this technique is very useful for calculating array
        ///  cross-correlation or convolution using DFT.
        ///  @sa dct, getOptimalDFTSize, mulSpectrums, filter2D, matchTemplate, flip, cartToPolar,
        ///  magnitude, phase
        /// </param>
        public static void dft(Mat src, Mat dst, int flags, int nonzeroRows)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_dft_10(src.nativeObj, dst.nativeObj, flags, nonzeroRows);


        }

        /// <summary>
        ///  Performs a forward or inverse Discrete Fourier transform of a 1D or 2D floating-point array.
        /// </summary>
        /// <remarks>
        ///  The function cv::dft performs one of the following:
        ///  -   Forward the Fourier transform of a 1D vector of N elements:
        ///      \f[Y = F^{(N)}  \cdot X,\f]
        ///      where \f$F^{(N)}_{jk}=\exp(-2\pi i j k/N)\f$ and \f$i=\sqrt{-1}\f$
        ///  -   Inverse the Fourier transform of a 1D vector of N elements:
        ///      \f[\begin{array}{l} X'=  \left (F^{(N)} \right )^{-1}  \cdot Y =  \left (F^{(N)} \right )^*  \cdot y  \\ X = (1/N)  \cdot X, \end{array}\f]
        ///      where \f$F^*=\left(\textrm{Re}(F^{(N)})-\textrm{Im}(F^{(N)})\right)^T\f$
        ///  -   Forward the 2D Fourier transform of a M x N matrix:
        ///      \f[Y = F^{(M)}  \cdot X  \cdot F^{(N)}\f]
        ///  -   Inverse the 2D Fourier transform of a M x N matrix:
        ///      \f[\begin{array}{l} X'=  \left (F^{(M)} \right )^*  \cdot Y  \cdot \left (F^{(N)} \right )^* \\ X =  \frac{1}{M \cdot N} \cdot X' \end{array}\f]
        ///  
        ///  In case of real (single-channel) data, the output spectrum of the forward Fourier transform or input
        ///  spectrum of the inverse Fourier transform can be represented in a packed format called *CCS*
        ///  (complex-conjugate-symmetrical). It was borrowed from IPL (Intel\* Image Processing Library). Here
        ///  is how 2D *CCS* spectrum looks:
        ///  \f[\begin{bmatrix} Re Y_{0,0} &amp; Re Y_{0,1} &amp; Im Y_{0,1} &amp; Re Y_{0,2} &amp; Im Y_{0,2} &amp;  \cdots &amp; Re Y_{0,N/2-1} &amp; Im Y_{0,N/2-1} &amp; Re Y_{0,N/2}  \\ Re Y_{1,0} &amp; Re Y_{1,1} &amp; Im Y_{1,1} &amp; Re Y_{1,2} &amp; Im Y_{1,2} &amp;  \cdots &amp; Re Y_{1,N/2-1} &amp; Im Y_{1,N/2-1} &amp; Re Y_{1,N/2}  \\ Im Y_{1,0} &amp; Re Y_{2,1} &amp; Im Y_{2,1} &amp; Re Y_{2,2} &amp; Im Y_{2,2} &amp;  \cdots &amp; Re Y_{2,N/2-1} &amp; Im Y_{2,N/2-1} &amp; Im Y_{1,N/2}  \\ \hdotsfor{9} \\ Re Y_{M/2-1,0} &amp;  Re Y_{M-3,1}  &amp; Im Y_{M-3,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-3,N/2-1} &amp; Im Y_{M-3,N/2-1}&amp; Re Y_{M/2-1,N/2}  \\ Im Y_{M/2-1,0} &amp;  Re Y_{M-2,1}  &amp; Im Y_{M-2,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-2,N/2-1} &amp; Im Y_{M-2,N/2-1}&amp; Im Y_{M/2-1,N/2}  \\ Re Y_{M/2,0}  &amp;  Re Y_{M-1,1} &amp;  Im Y_{M-1,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-1,N/2-1} &amp; Im Y_{M-1,N/2-1}&amp; Re Y_{M/2,N/2} \end{bmatrix}\f]
        ///  
        ///  In case of 1D transform of a real vector, the output looks like the first row of the matrix above.
        ///  
        ///  So, the function chooses an operation mode depending on the flags and size of the input array:
        ///  -   If #DFT_ROWS is set or the input array has a single row or single column, the function
        ///      performs a 1D forward or inverse transform of each row of a matrix when #DFT_ROWS is set.
        ///      Otherwise, it performs a 2D transform.
        ///  -   If the input array is real and #DFT_INVERSE is not set, the function performs a forward 1D or
        ///      2D transform:
        ///      -   When #DFT_COMPLEX_OUTPUT is set, the output is a complex matrix of the same size as
        ///          input.
        ///      -   When #DFT_COMPLEX_OUTPUT is not set, the output is a real matrix of the same size as
        ///          input. In case of 2D transform, it uses the packed format as shown above. In case of a
        ///          single 1D transform, it looks like the first row of the matrix above. In case of
        ///          multiple 1D transforms (when using the #DFT_ROWS flag), each row of the output matrix
        ///          looks like the first row of the matrix above.
        ///  -   If the input array is complex and either #DFT_INVERSE or #DFT_REAL_OUTPUT are not set, the
        ///      output is a complex array of the same size as input. The function performs a forward or
        ///      inverse 1D or 2D transform of the whole input array or each row of the input array
        ///      independently, depending on the flags DFT_INVERSE and DFT_ROWS.
        ///  -   When #DFT_INVERSE is set and the input array is real, or it is complex but #DFT_REAL_OUTPUT
        ///      is set, the output is a real array of the same size as input. The function performs a 1D or 2D
        ///      inverse transformation of the whole input array or each individual row, depending on the flags
        ///      #DFT_INVERSE and #DFT_ROWS.
        ///  
        ///  If #DFT_SCALE is set, the scaling is done after the transformation.
        ///  
        ///  Unlike dct, the function supports arrays of arbitrary size. But only those arrays are processed
        ///  efficiently, whose sizes can be factorized in a product of small prime numbers (2, 3, and 5 in the
        ///  current implementation). Such an efficient DFT size can be calculated using the getOptimalDFTSize
        ///  method.
        ///  
        ///  The sample below illustrates how to calculate a DFT-based convolution of two 2D real arrays:
        /// </remarks>
        /// <code language="c++">
        ///      void convolveDFT(InputArray A, InputArray B, OutputArray C)
        ///      {
        ///          // reallocate the output array if needed
        ///          C.create(abs(A.rows - B.rows)+1, abs(A.cols - B.cols)+1, A.type());
        ///          Size dftSize;
        ///          // calculate the size of DFT transform
        ///          dftSize.width = getOptimalDFTSize(A.cols + B.cols - 1);
        ///          dftSize.height = getOptimalDFTSize(A.rows + B.rows - 1);
        ///  
        ///          // allocate temporary buffers and initialize them with 0's
        ///          Mat tempA(dftSize, A.type(), Scalar::all(0));
        ///          Mat tempB(dftSize, B.type(), Scalar::all(0));
        ///  
        ///          // copy A and B to the top-left corners of tempA and tempB, respectively
        ///          Mat roiA(tempA, Rect(0,0,A.cols,A.rows));
        ///          A.copyTo(roiA);
        ///          Mat roiB(tempB, Rect(0,0,B.cols,B.rows));
        ///          B.copyTo(roiB);
        ///  
        ///          // now transform the padded A &amp; B in-place;
        ///          // use "nonzeroRows" hint for faster processing
        ///          dft(tempA, tempA, 0, A.rows);
        ///          dft(tempB, tempB, 0, B.rows);
        ///  
        ///          // multiply the spectrums;
        ///          // the function handles packed spectrum representations well
        ///          mulSpectrums(tempA, tempB, tempA);
        ///  
        ///          // transform the product back from the frequency domain.
        ///          // Even though all the result rows will be non-zero,
        ///          // you need only the first C.rows of them, and thus you
        ///          // pass nonzeroRows == C.rows
        ///          dft(tempA, tempA, DFT_INVERSE + DFT_SCALE, C.rows);
        ///  
        ///          // now copy the result back to C.
        ///          tempA(Rect(0, 0, C.cols, C.rows)).copyTo(C);
        ///  
        ///          // all the temporary buffers will be deallocated automatically
        ///      }
        /// </code>
        /// <remarks>
        ///  To optimize this sample, consider the following approaches:
        ///  -   Since nonzeroRows != 0 is passed to the forward transform calls and since A and B are copied to
        ///      the top-left corners of tempA and tempB, respectively, it is not necessary to clear the whole
        ///      tempA and tempB. It is only necessary to clear the tempA.cols - A.cols ( tempB.cols - B.cols)
        ///      rightmost columns of the matrices.
        ///  -   This DFT-based convolution does not have to be applied to the whole big arrays, especially if B
        ///      is significantly smaller than A or vice versa. Instead, you can calculate convolution by parts.
        ///      To do this, you need to split the output array C into multiple tiles. For each tile, estimate
        ///      which parts of A and B are required to calculate convolution in this tile. If the tiles in C are
        ///      too small, the speed will decrease a lot because of repeated work. In the ultimate case, when
        ///      each tile in C is a single pixel, the algorithm becomes equivalent to the naive convolution
        ///      algorithm. If the tiles are too big, the temporary arrays tempA and tempB become too big and
        ///      there is also a slowdown because of bad cache locality. So, there is an optimal tile size
        ///      somewhere in the middle.
        ///  -   If different tiles in C can be calculated in parallel and, thus, the convolution is done by
        ///      parts, the loop can be threaded.
        ///  
        ///  All of the above improvements have been implemented in #matchTemplate and #filter2D . Therefore, by
        ///  using them, you can get the performance even better than with the above theoretically optimal
        ///  implementation. Though, those two functions actually calculate cross-correlation, not convolution,
        ///  so you need to "flip" the second convolution operand B vertically and horizontally using flip .
        ///  @note
        ///  -   An example using the discrete fourier transform can be found at
        ///      opencv_source_code/samples/cpp/dft.cpp
        ///  -   (Python) An example using the dft functionality to perform Wiener deconvolution can be found
        ///      at opencv_source/samples/python/deconvolution.py
        ///  -   (Python) An example rearranging the quadrants of a Fourier image can be found at
        ///      opencv_source/samples/python/dft.py
        /// </remarks>
        /// <param name="src">
        /// input array that could be real or complex.
        /// </param>
        /// <param name="dst">
        /// output array whose size and type depends on the flags .
        /// </param>
        /// <param name="flags">
        /// transformation flags, representing a combination of the #DftFlags
        /// </param>
        /// <param name="nonzeroRows">
        /// when the parameter is not zero, the function assumes that only the first
        ///  nonzeroRows rows of the input array (#DFT_INVERSE is not set) or only the first nonzeroRows of the
        ///  output array (#DFT_INVERSE is set) contain non-zeros, thus, the function can handle the rest of the
        ///  rows more efficiently and save some time; this technique is very useful for calculating array
        ///  cross-correlation or convolution using DFT.
        ///  @sa dct, getOptimalDFTSize, mulSpectrums, filter2D, matchTemplate, flip, cartToPolar,
        ///  magnitude, phase
        /// </param>
        public static void dft(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_dft_11(src.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Performs a forward or inverse Discrete Fourier transform of a 1D or 2D floating-point array.
        /// </summary>
        /// <remarks>
        ///  The function cv::dft performs one of the following:
        ///  -   Forward the Fourier transform of a 1D vector of N elements:
        ///      \f[Y = F^{(N)}  \cdot X,\f]
        ///      where \f$F^{(N)}_{jk}=\exp(-2\pi i j k/N)\f$ and \f$i=\sqrt{-1}\f$
        ///  -   Inverse the Fourier transform of a 1D vector of N elements:
        ///      \f[\begin{array}{l} X'=  \left (F^{(N)} \right )^{-1}  \cdot Y =  \left (F^{(N)} \right )^*  \cdot y  \\ X = (1/N)  \cdot X, \end{array}\f]
        ///      where \f$F^*=\left(\textrm{Re}(F^{(N)})-\textrm{Im}(F^{(N)})\right)^T\f$
        ///  -   Forward the 2D Fourier transform of a M x N matrix:
        ///      \f[Y = F^{(M)}  \cdot X  \cdot F^{(N)}\f]
        ///  -   Inverse the 2D Fourier transform of a M x N matrix:
        ///      \f[\begin{array}{l} X'=  \left (F^{(M)} \right )^*  \cdot Y  \cdot \left (F^{(N)} \right )^* \\ X =  \frac{1}{M \cdot N} \cdot X' \end{array}\f]
        ///  
        ///  In case of real (single-channel) data, the output spectrum of the forward Fourier transform or input
        ///  spectrum of the inverse Fourier transform can be represented in a packed format called *CCS*
        ///  (complex-conjugate-symmetrical). It was borrowed from IPL (Intel\* Image Processing Library). Here
        ///  is how 2D *CCS* spectrum looks:
        ///  \f[\begin{bmatrix} Re Y_{0,0} &amp; Re Y_{0,1} &amp; Im Y_{0,1} &amp; Re Y_{0,2} &amp; Im Y_{0,2} &amp;  \cdots &amp; Re Y_{0,N/2-1} &amp; Im Y_{0,N/2-1} &amp; Re Y_{0,N/2}  \\ Re Y_{1,0} &amp; Re Y_{1,1} &amp; Im Y_{1,1} &amp; Re Y_{1,2} &amp; Im Y_{1,2} &amp;  \cdots &amp; Re Y_{1,N/2-1} &amp; Im Y_{1,N/2-1} &amp; Re Y_{1,N/2}  \\ Im Y_{1,0} &amp; Re Y_{2,1} &amp; Im Y_{2,1} &amp; Re Y_{2,2} &amp; Im Y_{2,2} &amp;  \cdots &amp; Re Y_{2,N/2-1} &amp; Im Y_{2,N/2-1} &amp; Im Y_{1,N/2}  \\ \hdotsfor{9} \\ Re Y_{M/2-1,0} &amp;  Re Y_{M-3,1}  &amp; Im Y_{M-3,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-3,N/2-1} &amp; Im Y_{M-3,N/2-1}&amp; Re Y_{M/2-1,N/2}  \\ Im Y_{M/2-1,0} &amp;  Re Y_{M-2,1}  &amp; Im Y_{M-2,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-2,N/2-1} &amp; Im Y_{M-2,N/2-1}&amp; Im Y_{M/2-1,N/2}  \\ Re Y_{M/2,0}  &amp;  Re Y_{M-1,1} &amp;  Im Y_{M-1,1} &amp;  \hdotsfor{3} &amp; Re Y_{M-1,N/2-1} &amp; Im Y_{M-1,N/2-1}&amp; Re Y_{M/2,N/2} \end{bmatrix}\f]
        ///  
        ///  In case of 1D transform of a real vector, the output looks like the first row of the matrix above.
        ///  
        ///  So, the function chooses an operation mode depending on the flags and size of the input array:
        ///  -   If #DFT_ROWS is set or the input array has a single row or single column, the function
        ///      performs a 1D forward or inverse transform of each row of a matrix when #DFT_ROWS is set.
        ///      Otherwise, it performs a 2D transform.
        ///  -   If the input array is real and #DFT_INVERSE is not set, the function performs a forward 1D or
        ///      2D transform:
        ///      -   When #DFT_COMPLEX_OUTPUT is set, the output is a complex matrix of the same size as
        ///          input.
        ///      -   When #DFT_COMPLEX_OUTPUT is not set, the output is a real matrix of the same size as
        ///          input. In case of 2D transform, it uses the packed format as shown above. In case of a
        ///          single 1D transform, it looks like the first row of the matrix above. In case of
        ///          multiple 1D transforms (when using the #DFT_ROWS flag), each row of the output matrix
        ///          looks like the first row of the matrix above.
        ///  -   If the input array is complex and either #DFT_INVERSE or #DFT_REAL_OUTPUT are not set, the
        ///      output is a complex array of the same size as input. The function performs a forward or
        ///      inverse 1D or 2D transform of the whole input array or each row of the input array
        ///      independently, depending on the flags DFT_INVERSE and DFT_ROWS.
        ///  -   When #DFT_INVERSE is set and the input array is real, or it is complex but #DFT_REAL_OUTPUT
        ///      is set, the output is a real array of the same size as input. The function performs a 1D or 2D
        ///      inverse transformation of the whole input array or each individual row, depending on the flags
        ///      #DFT_INVERSE and #DFT_ROWS.
        ///  
        ///  If #DFT_SCALE is set, the scaling is done after the transformation.
        ///  
        ///  Unlike dct, the function supports arrays of arbitrary size. But only those arrays are processed
        ///  efficiently, whose sizes can be factorized in a product of small prime numbers (2, 3, and 5 in the
        ///  current implementation). Such an efficient DFT size can be calculated using the getOptimalDFTSize
        ///  method.
        ///  
        ///  The sample below illustrates how to calculate a DFT-based convolution of two 2D real arrays:
        /// </remarks>
        /// <code language="c++">
        ///      void convolveDFT(InputArray A, InputArray B, OutputArray C)
        ///      {
        ///          // reallocate the output array if needed
        ///          C.create(abs(A.rows - B.rows)+1, abs(A.cols - B.cols)+1, A.type());
        ///          Size dftSize;
        ///          // calculate the size of DFT transform
        ///          dftSize.width = getOptimalDFTSize(A.cols + B.cols - 1);
        ///          dftSize.height = getOptimalDFTSize(A.rows + B.rows - 1);
        ///  
        ///          // allocate temporary buffers and initialize them with 0's
        ///          Mat tempA(dftSize, A.type(), Scalar::all(0));
        ///          Mat tempB(dftSize, B.type(), Scalar::all(0));
        ///  
        ///          // copy A and B to the top-left corners of tempA and tempB, respectively
        ///          Mat roiA(tempA, Rect(0,0,A.cols,A.rows));
        ///          A.copyTo(roiA);
        ///          Mat roiB(tempB, Rect(0,0,B.cols,B.rows));
        ///          B.copyTo(roiB);
        ///  
        ///          // now transform the padded A &amp; B in-place;
        ///          // use "nonzeroRows" hint for faster processing
        ///          dft(tempA, tempA, 0, A.rows);
        ///          dft(tempB, tempB, 0, B.rows);
        ///  
        ///          // multiply the spectrums;
        ///          // the function handles packed spectrum representations well
        ///          mulSpectrums(tempA, tempB, tempA);
        ///  
        ///          // transform the product back from the frequency domain.
        ///          // Even though all the result rows will be non-zero,
        ///          // you need only the first C.rows of them, and thus you
        ///          // pass nonzeroRows == C.rows
        ///          dft(tempA, tempA, DFT_INVERSE + DFT_SCALE, C.rows);
        ///  
        ///          // now copy the result back to C.
        ///          tempA(Rect(0, 0, C.cols, C.rows)).copyTo(C);
        ///  
        ///          // all the temporary buffers will be deallocated automatically
        ///      }
        /// </code>
        /// <remarks>
        ///  To optimize this sample, consider the following approaches:
        ///  -   Since nonzeroRows != 0 is passed to the forward transform calls and since A and B are copied to
        ///      the top-left corners of tempA and tempB, respectively, it is not necessary to clear the whole
        ///      tempA and tempB. It is only necessary to clear the tempA.cols - A.cols ( tempB.cols - B.cols)
        ///      rightmost columns of the matrices.
        ///  -   This DFT-based convolution does not have to be applied to the whole big arrays, especially if B
        ///      is significantly smaller than A or vice versa. Instead, you can calculate convolution by parts.
        ///      To do this, you need to split the output array C into multiple tiles. For each tile, estimate
        ///      which parts of A and B are required to calculate convolution in this tile. If the tiles in C are
        ///      too small, the speed will decrease a lot because of repeated work. In the ultimate case, when
        ///      each tile in C is a single pixel, the algorithm becomes equivalent to the naive convolution
        ///      algorithm. If the tiles are too big, the temporary arrays tempA and tempB become too big and
        ///      there is also a slowdown because of bad cache locality. So, there is an optimal tile size
        ///      somewhere in the middle.
        ///  -   If different tiles in C can be calculated in parallel and, thus, the convolution is done by
        ///      parts, the loop can be threaded.
        ///  
        ///  All of the above improvements have been implemented in #matchTemplate and #filter2D . Therefore, by
        ///  using them, you can get the performance even better than with the above theoretically optimal
        ///  implementation. Though, those two functions actually calculate cross-correlation, not convolution,
        ///  so you need to "flip" the second convolution operand B vertically and horizontally using flip .
        ///  @note
        ///  -   An example using the discrete fourier transform can be found at
        ///      opencv_source_code/samples/cpp/dft.cpp
        ///  -   (Python) An example using the dft functionality to perform Wiener deconvolution can be found
        ///      at opencv_source/samples/python/deconvolution.py
        ///  -   (Python) An example rearranging the quadrants of a Fourier image can be found at
        ///      opencv_source/samples/python/dft.py
        /// </remarks>
        /// <param name="src">
        /// input array that could be real or complex.
        /// </param>
        /// <param name="dst">
        /// output array whose size and type depends on the flags .
        /// </param>
        /// <param name="flags">
        /// transformation flags, representing a combination of the #DftFlags
        /// </param>
        /// <param name="nonzeroRows">
        /// when the parameter is not zero, the function assumes that only the first
        ///  nonzeroRows rows of the input array (#DFT_INVERSE is not set) or only the first nonzeroRows of the
        ///  output array (#DFT_INVERSE is set) contain non-zeros, thus, the function can handle the rest of the
        ///  rows more efficiently and save some time; this technique is very useful for calculating array
        ///  cross-correlation or convolution using DFT.
        ///  @sa dct, getOptimalDFTSize, mulSpectrums, filter2D, matchTemplate, flip, cartToPolar,
        ///  magnitude, phase
        /// </param>
        public static void dft(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_dft_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::idft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        //

        /// <summary>
        ///  Calculates the inverse Discrete Fourier Transform of a 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  idft(src, dst, flags) is equivalent to dft(src, dst, flags | #DFT_INVERSE) .
        ///  @note None of dft and idft scales the result by default. So, you should pass #DFT_SCALE to one of
        ///  dft or idft explicitly to make these transforms mutually inverse.
        ///  @sa dft, dct, idct, mulSpectrums, getOptimalDFTSize
        /// </remarks>
        /// <param name="src">
        /// input floating-point real or complex array.
        /// </param>
        /// <param name="dst">
        /// output array whose size and type depend on the flags.
        /// </param>
        /// <param name="flags">
        /// operation flags (see dft and #DftFlags).
        /// </param>
        /// <param name="nonzeroRows">
        /// number of dst rows to process; the rest of the rows have undefined content (see
        ///  the convolution sample in dft description.
        /// </param>
        public static void idft(Mat src, Mat dst, int flags, int nonzeroRows)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_idft_10(src.nativeObj, dst.nativeObj, flags, nonzeroRows);


        }

        /// <summary>
        ///  Calculates the inverse Discrete Fourier Transform of a 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  idft(src, dst, flags) is equivalent to dft(src, dst, flags | #DFT_INVERSE) .
        ///  @note None of dft and idft scales the result by default. So, you should pass #DFT_SCALE to one of
        ///  dft or idft explicitly to make these transforms mutually inverse.
        ///  @sa dft, dct, idct, mulSpectrums, getOptimalDFTSize
        /// </remarks>
        /// <param name="src">
        /// input floating-point real or complex array.
        /// </param>
        /// <param name="dst">
        /// output array whose size and type depend on the flags.
        /// </param>
        /// <param name="flags">
        /// operation flags (see dft and #DftFlags).
        /// </param>
        /// <param name="nonzeroRows">
        /// number of dst rows to process; the rest of the rows have undefined content (see
        ///  the convolution sample in dft description.
        /// </param>
        public static void idft(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_idft_11(src.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Calculates the inverse Discrete Fourier Transform of a 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  idft(src, dst, flags) is equivalent to dft(src, dst, flags | #DFT_INVERSE) .
        ///  @note None of dft and idft scales the result by default. So, you should pass #DFT_SCALE to one of
        ///  dft or idft explicitly to make these transforms mutually inverse.
        ///  @sa dft, dct, idct, mulSpectrums, getOptimalDFTSize
        /// </remarks>
        /// <param name="src">
        /// input floating-point real or complex array.
        /// </param>
        /// <param name="dst">
        /// output array whose size and type depend on the flags.
        /// </param>
        /// <param name="flags">
        /// operation flags (see dft and #DftFlags).
        /// </param>
        /// <param name="nonzeroRows">
        /// number of dst rows to process; the rest of the rows have undefined content (see
        ///  the convolution sample in dft description.
        /// </param>
        public static void idft(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_idft_12(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::dct(Mat src, Mat& dst, int flags = 0)
        //

        /// <summary>
        ///  Performs a forward or inverse discrete Cosine transform of 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  The function cv::dct performs a forward or inverse discrete Cosine transform (DCT) of a 1D or 2D
        ///  floating-point array:
        ///  -   Forward Cosine transform of a 1D vector of N elements:
        ///      \f[Y = C^{(N)}  \cdot X\f]
        ///      where
        ///      \f[C^{(N)}_{jk}= \sqrt{\alpha_j/N} \cos \left ( \frac{\pi(2k+1)j}{2N} \right )\f]
        ///      and
        ///      \f$\alpha_0=1\f$, \f$\alpha_j=2\f$ for *j &gt; 0*.
        ///  -   Inverse Cosine transform of a 1D vector of N elements:
        ///      \f[X =  \left (C^{(N)} \right )^{-1}  \cdot Y =  \left (C^{(N)} \right )^T  \cdot Y\f]
        ///      (since \f$C^{(N)}\f$ is an orthogonal matrix, \f$C^{(N)} \cdot \left(C^{(N)}\right)^T = I\f$ )
        ///  -   Forward 2D Cosine transform of M x N matrix:
        ///      \f[Y = C^{(N)}  \cdot X  \cdot \left (C^{(N)} \right )^T\f]
        ///  -   Inverse 2D Cosine transform of M x N matrix:
        ///      \f[X =  \left (C^{(N)} \right )^T  \cdot X  \cdot C^{(N)}\f]
        ///  
        ///  The function chooses the mode of operation by looking at the flags and size of the input array:
        ///  -   If (flags &amp; #DCT_INVERSE) == 0, the function does a forward 1D or 2D transform. Otherwise, it
        ///      is an inverse 1D or 2D transform.
        ///  -   If (flags &amp; #DCT_ROWS) != 0, the function performs a 1D transform of each row.
        ///  -   If the array is a single column or a single row, the function performs a 1D transform.
        ///  -   If none of the above is true, the function performs a 2D transform.
        ///  
        ///  @note Currently dct supports even-size arrays (2, 4, 6 ...). For data analysis and approximation, you
        ///  can pad the array when necessary.
        ///  Also, the function performance depends very much, and not monotonically, on the array size (see
        ///  getOptimalDFTSize ). In the current implementation DCT of a vector of size N is calculated via DFT
        ///  of a vector of size N/2 . Thus, the optimal DCT size N1 &gt;= N can be calculated as:
        /// </remarks>
        /// <code language="c++">
        ///      size_t getOptimalDCTSize(size_t N) { return 2*getOptimalDFTSize((N+1)/2); }
        ///      N1 = getOptimalDCTSize(N);
        /// </code>
        /// <param name="src">
        /// input floating-point array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src .
        /// </param>
        /// <param name="flags">
        /// transformation flags as a combination of cv::DftFlags (DCT_*)
        ///  @sa dft, getOptimalDFTSize, idct
        /// </param>
        public static void dct(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_dct_10(src.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Performs a forward or inverse discrete Cosine transform of 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  The function cv::dct performs a forward or inverse discrete Cosine transform (DCT) of a 1D or 2D
        ///  floating-point array:
        ///  -   Forward Cosine transform of a 1D vector of N elements:
        ///      \f[Y = C^{(N)}  \cdot X\f]
        ///      where
        ///      \f[C^{(N)}_{jk}= \sqrt{\alpha_j/N} \cos \left ( \frac{\pi(2k+1)j}{2N} \right )\f]
        ///      and
        ///      \f$\alpha_0=1\f$, \f$\alpha_j=2\f$ for *j &gt; 0*.
        ///  -   Inverse Cosine transform of a 1D vector of N elements:
        ///      \f[X =  \left (C^{(N)} \right )^{-1}  \cdot Y =  \left (C^{(N)} \right )^T  \cdot Y\f]
        ///      (since \f$C^{(N)}\f$ is an orthogonal matrix, \f$C^{(N)} \cdot \left(C^{(N)}\right)^T = I\f$ )
        ///  -   Forward 2D Cosine transform of M x N matrix:
        ///      \f[Y = C^{(N)}  \cdot X  \cdot \left (C^{(N)} \right )^T\f]
        ///  -   Inverse 2D Cosine transform of M x N matrix:
        ///      \f[X =  \left (C^{(N)} \right )^T  \cdot X  \cdot C^{(N)}\f]
        ///  
        ///  The function chooses the mode of operation by looking at the flags and size of the input array:
        ///  -   If (flags &amp; #DCT_INVERSE) == 0, the function does a forward 1D or 2D transform. Otherwise, it
        ///      is an inverse 1D or 2D transform.
        ///  -   If (flags &amp; #DCT_ROWS) != 0, the function performs a 1D transform of each row.
        ///  -   If the array is a single column or a single row, the function performs a 1D transform.
        ///  -   If none of the above is true, the function performs a 2D transform.
        ///  
        ///  @note Currently dct supports even-size arrays (2, 4, 6 ...). For data analysis and approximation, you
        ///  can pad the array when necessary.
        ///  Also, the function performance depends very much, and not monotonically, on the array size (see
        ///  getOptimalDFTSize ). In the current implementation DCT of a vector of size N is calculated via DFT
        ///  of a vector of size N/2 . Thus, the optimal DCT size N1 &gt;= N can be calculated as:
        /// </remarks>
        /// <code language="c++">
        ///      size_t getOptimalDCTSize(size_t N) { return 2*getOptimalDFTSize((N+1)/2); }
        ///      N1 = getOptimalDCTSize(N);
        /// </code>
        /// <param name="src">
        /// input floating-point array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src .
        /// </param>
        /// <param name="flags">
        /// transformation flags as a combination of cv::DftFlags (DCT_*)
        ///  @sa dft, getOptimalDFTSize, idct
        /// </param>
        public static void dct(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_dct_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::idct(Mat src, Mat& dst, int flags = 0)
        //

        /// <summary>
        ///  Calculates the inverse Discrete Cosine Transform of a 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  idct(src, dst, flags) is equivalent to dct(src, dst, flags | DCT_INVERSE).
        /// </remarks>
        /// <param name="src">
        /// input floating-point single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        /// </param>
        /// <param name="flags">
        /// operation flags.
        ///  @sa  dct, dft, idft, getOptimalDFTSize
        /// </param>
        public static void idct(Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_idct_10(src.nativeObj, dst.nativeObj, flags);


        }

        /// <summary>
        ///  Calculates the inverse Discrete Cosine Transform of a 1D or 2D array.
        /// </summary>
        /// <remarks>
        ///  idct(src, dst, flags) is equivalent to dct(src, dst, flags | DCT_INVERSE).
        /// </remarks>
        /// <param name="src">
        /// input floating-point single-channel array.
        /// </param>
        /// <param name="dst">
        /// output array of the same size and type as src.
        /// </param>
        /// <param name="flags">
        /// operation flags.
        ///  @sa  dct, dft, idft, getOptimalDFTSize
        /// </param>
        public static void idct(Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_idct_11(src.nativeObj, dst.nativeObj);


        }


        //
        // C++:  void cv::mulSpectrums(Mat a, Mat b, Mat& c, int flags, bool conjB = false)
        //

        /// <summary>
        ///  Performs the per-element multiplication of two Fourier spectrums.
        /// </summary>
        /// <remarks>
        ///  The function cv::mulSpectrums performs the per-element multiplication of the two CCS-packed or complex
        ///  matrices that are results of a real or complex Fourier transform.
        ///  
        ///  The function, together with dft and idft, may be used to calculate convolution (pass conjB=false )
        ///  or correlation (pass conjB=true ) of two arrays rapidly. When the arrays are complex, they are
        ///  simply multiplied (per element) with an optional conjugation of the second-array elements. When the
        ///  arrays are real, they are assumed to be CCS-packed (see dft for details).
        /// </remarks>
        /// <param name="a">
        /// first input array.
        /// </param>
        /// <param name="b">
        /// second input array of the same size and type as src1 .
        /// </param>
        /// <param name="c">
        /// output array of the same size and type as src1 .
        /// </param>
        /// <param name="flags">
        /// operation flags; currently, the only supported flag is cv::DFT_ROWS, which indicates that
        ///  each row of src1 and src2 is an independent 1D Fourier spectrum. If you do not want to use this flag, then simply add a `0` as value.
        /// </param>
        /// <param name="conjB">
        /// optional flag that conjugates the second input array before the multiplication (true)
        ///  or not (false).
        /// </param>
        public static void mulSpectrums(Mat a, Mat b, Mat c, int flags, bool conjB)
        {
            if (a != null) a.ThrowIfDisposed();
            if (b != null) b.ThrowIfDisposed();
            if (c != null) c.ThrowIfDisposed();

            core_Core_mulSpectrums_10(a.nativeObj, b.nativeObj, c.nativeObj, flags, conjB);


        }

        /// <summary>
        ///  Performs the per-element multiplication of two Fourier spectrums.
        /// </summary>
        /// <remarks>
        ///  The function cv::mulSpectrums performs the per-element multiplication of the two CCS-packed or complex
        ///  matrices that are results of a real or complex Fourier transform.
        ///  
        ///  The function, together with dft and idft, may be used to calculate convolution (pass conjB=false )
        ///  or correlation (pass conjB=true ) of two arrays rapidly. When the arrays are complex, they are
        ///  simply multiplied (per element) with an optional conjugation of the second-array elements. When the
        ///  arrays are real, they are assumed to be CCS-packed (see dft for details).
        /// </remarks>
        /// <param name="a">
        /// first input array.
        /// </param>
        /// <param name="b">
        /// second input array of the same size and type as src1 .
        /// </param>
        /// <param name="c">
        /// output array of the same size and type as src1 .
        /// </param>
        /// <param name="flags">
        /// operation flags; currently, the only supported flag is cv::DFT_ROWS, which indicates that
        ///  each row of src1 and src2 is an independent 1D Fourier spectrum. If you do not want to use this flag, then simply add a `0` as value.
        /// </param>
        /// <param name="conjB">
        /// optional flag that conjugates the second input array before the multiplication (true)
        ///  or not (false).
        /// </param>
        public static void mulSpectrums(Mat a, Mat b, Mat c, int flags)
        {
            if (a != null) a.ThrowIfDisposed();
            if (b != null) b.ThrowIfDisposed();
            if (c != null) c.ThrowIfDisposed();

            core_Core_mulSpectrums_11(a.nativeObj, b.nativeObj, c.nativeObj, flags);


        }


        //
        // C++:  int cv::getOptimalDFTSize(int vecsize)
        //

        /// <summary>
        ///  Returns the optimal DFT size for a given vector size.
        /// </summary>
        /// <remarks>
        ///  DFT performance is not a monotonic function of a vector size. Therefore, when you calculate
        ///  convolution of two arrays or perform the spectral analysis of an array, it usually makes sense to
        ///  pad the input data with zeros to get a bit larger array that can be transformed much faster than the
        ///  original one. Arrays whose size is a power-of-two (2, 4, 8, 16, 32, ...) are the fastest to process.
        ///  Though, the arrays whose size is a product of 2's, 3's, and 5's (for example, 300 = 5\*5\*3\*2\*2)
        ///  are also processed quite efficiently.
        ///  
        ///  The function cv::getOptimalDFTSize returns the minimum number N that is greater than or equal to vecsize
        ///  so that the DFT of a vector of size N can be processed efficiently. In the current implementation N
        ///  = 2 ^p^ \* 3 ^q^ \* 5 ^r^ for some integer p, q, r.
        ///  
        ///  The function returns a negative number if vecsize is too large (very close to INT_MAX ).
        ///  
        ///  While the function cannot be used directly to estimate the optimal vector size for DCT transform
        ///  (since the current DCT implementation supports only even-size vectors), it can be easily processed
        ///  as getOptimalDFTSize((vecsize+1)/2)\*2.
        /// </remarks>
        /// <param name="vecsize">
        /// vector size.
        ///  @sa dft, dct, idft, idct, mulSpectrums
        /// </param>
        public static int getOptimalDFTSize(int vecsize)
        {


            return core_Core_getOptimalDFTSize_10(vecsize);


        }


        //
        // C++:  void cv::setRNGSeed(int seed)
        //

        /// <summary>
        ///  Sets state of default random number generator.
        /// </summary>
        /// <remarks>
        ///  The function cv::setRNGSeed sets state of default random number generator to custom value.
        /// </remarks>
        /// <param name="seed">
        /// new state for default random number generator
        ///  @sa RNG, randu, randn
        /// </param>
        public static void setRNGSeed(int seed)
        {


            core_Core_setRNGSeed_10(seed);


        }


        //
        // C++:  void cv::randu(Mat& dst, double low, double high)
        //

        /// <summary>
        ///  Generates a single uniformly-distributed random number or an array of random numbers.
        /// </summary>
        /// <remarks>
        ///  Non-template variant of the function fills the matrix dst with uniformly-distributed
        ///  random numbers from the specified range:
        ///  \f[\texttt{low} _c  \leq \texttt{dst} (I)_c &lt;  \texttt{high} _c\f]
        /// </remarks>
        /// <param name="dst">
        /// output array of random numbers; the array must be pre-allocated.
        /// </param>
        /// <param name="low">
        /// inclusive lower boundary of the generated random numbers.
        /// </param>
        /// <param name="high">
        /// exclusive upper boundary of the generated random numbers.
        ///  @sa RNG, randn, theRNG
        /// </param>
        public static void randu(Mat dst, double low, double high)
        {
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_randu_10(dst.nativeObj, low, high);


        }


        //
        // C++:  void cv::randn(Mat& dst, double mean, double stddev)
        //

        /// <summary>
        ///  Fills the array with normally distributed random numbers.
        /// </summary>
        /// <remarks>
        ///  The function cv::randn fills the matrix dst with normally distributed random numbers with the specified
        ///  mean vector and the standard deviation matrix. The generated random numbers are clipped to fit the
        ///  value range of the output array data type.
        /// </remarks>
        /// <param name="dst">
        /// output array of random numbers; the array must be pre-allocated and have 1 to 4 channels.
        /// </param>
        /// <param name="mean">
        /// mean value (expectation) of the generated random numbers.
        /// </param>
        /// <param name="stddev">
        /// standard deviation of the generated random numbers; it can be either a vector (in
        ///  which case a diagonal standard deviation matrix is assumed) or a square matrix.
        ///  @sa RNG, randu
        /// </param>
        public static void randn(Mat dst, double mean, double stddev)
        {
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_randn_10(dst.nativeObj, mean, stddev);


        }


        //
        // C++:  void cv::randShuffle(Mat& dst, double iterFactor = 1., RNG* rng = 0)
        //

        /// <summary>
        ///  Shuffles the array elements randomly.
        /// </summary>
        /// <remarks>
        ///  The function cv::randShuffle shuffles the specified 1D array by randomly choosing pairs of elements and
        ///  swapping them. The number of such swap operations will be dst.rows\*dst.cols\*iterFactor .
        /// </remarks>
        /// <param name="dst">
        /// input/output numerical 1D array.
        /// </param>
        /// <param name="iterFactor">
        /// scale factor that determines the number of random swap operations (see the details
        ///  below).
        /// </param>
        /// <param name="rng">
        /// optional random number generator used for shuffling; if it is zero, theRNG () is used
        ///  instead.
        ///  @sa RNG, sort
        /// </param>
        public static void randShuffle(Mat dst, double iterFactor)
        {
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_randShuffle_10(dst.nativeObj, iterFactor);


        }

        /// <summary>
        ///  Shuffles the array elements randomly.
        /// </summary>
        /// <remarks>
        ///  The function cv::randShuffle shuffles the specified 1D array by randomly choosing pairs of elements and
        ///  swapping them. The number of such swap operations will be dst.rows\*dst.cols\*iterFactor .
        /// </remarks>
        /// <param name="dst">
        /// input/output numerical 1D array.
        /// </param>
        /// <param name="iterFactor">
        /// scale factor that determines the number of random swap operations (see the details
        ///  below).
        /// </param>
        /// <param name="rng">
        /// optional random number generator used for shuffling; if it is zero, theRNG () is used
        ///  instead.
        ///  @sa RNG, sort
        /// </param>
        public static void randShuffle(Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_randShuffle_12(dst.nativeObj);


        }


        //
        // C++:  double cv::kmeans(Mat data, int K, Mat& bestLabels, TermCriteria criteria, int attempts, int flags, Mat& centers = Mat())
        //

        /// <summary>
        ///  Finds centers of clusters and groups input samples around the clusters.
        /// </summary>
        /// <remarks>
        ///  The function kmeans implements a k-means algorithm that finds the centers of cluster_count clusters
        ///  and groups the input samples around the clusters. As an output, \f$\texttt{bestLabels}_i\f$ contains a
        ///  0-based cluster index for the sample stored in the \f$i^{th}\f$ row of the samples matrix.
        ///  
        ///  @note
        ///  -   (Python) An example on K-means clustering can be found at
        ///      opencv_source_code/samples/python/kmeans.py
        /// </remarks>
        /// <param name="data">
        /// Data for clustering. An array of N-Dimensional points with float coordinates is needed.
        ///  Examples of this array can be:
        ///  -   Mat points(count, 2, CV_32F);
        ///  -   Mat points(count, 1, CV_32FC2);
        ///  -   Mat points(1, count, CV_32FC2);
        ///  -   std::vector&lt;cv::Point2f&gt; points(sampleCount);
        /// </param>
        /// <param name="K">
        /// Number of clusters to split the set by.
        /// </param>
        /// <param name="bestLabels">
        /// Input/output integer array that stores the cluster indices for every sample.
        /// </param>
        /// <param name="criteria">
        /// The algorithm termination criteria, that is, the maximum number of iterations and/or
        ///  the desired accuracy. The accuracy is specified as criteria.epsilon. As soon as each of the cluster
        ///  centers moves by less than criteria.epsilon on some iteration, the algorithm stops.
        /// </param>
        /// <param name="attempts">
        /// Flag to specify the number of times the algorithm is executed using different
        ///  initial labellings. The algorithm returns the labels that yield the best compactness (see the last
        ///  function parameter).
        /// </param>
        /// <param name="flags">
        /// Flag that can take values of cv::KmeansFlags
        /// </param>
        /// <param name="centers">
        /// Output matrix of the cluster centers, one row per each cluster center.
        /// </param>
        /// <returns>
        ///  The function returns the compactness measure that is computed as
        ///  \f[\sum _i  \| \texttt{samples} _i -  \texttt{centers} _{ \texttt{labels} _i} \| ^2\f]
        ///  after every attempt. The best (minimum) value is chosen and the corresponding labels and the
        ///  compactness value are returned by the function. Basically, you can use only the core of the
        ///  function, set the number of attempts to 1, initialize labels each time using a custom algorithm,
        ///  pass them with the ( flags = #KMEANS_USE_INITIAL_LABELS ) flag, and then choose the best
        ///  (most-compact) clustering.
        /// </returns>
        public static double kmeans(Mat data, int K, Mat bestLabels, TermCriteria criteria, int attempts, int flags, Mat centers)
        {
            if (data != null) data.ThrowIfDisposed();
            if (bestLabels != null) bestLabels.ThrowIfDisposed();
            if (centers != null) centers.ThrowIfDisposed();

            return core_Core_kmeans_10(data.nativeObj, K, bestLabels.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon, attempts, flags, centers.nativeObj);


        }

        /// <summary>
        ///  Finds centers of clusters and groups input samples around the clusters.
        /// </summary>
        /// <remarks>
        ///  The function kmeans implements a k-means algorithm that finds the centers of cluster_count clusters
        ///  and groups the input samples around the clusters. As an output, \f$\texttt{bestLabels}_i\f$ contains a
        ///  0-based cluster index for the sample stored in the \f$i^{th}\f$ row of the samples matrix.
        ///  
        ///  @note
        ///  -   (Python) An example on K-means clustering can be found at
        ///      opencv_source_code/samples/python/kmeans.py
        /// </remarks>
        /// <param name="data">
        /// Data for clustering. An array of N-Dimensional points with float coordinates is needed.
        ///  Examples of this array can be:
        ///  -   Mat points(count, 2, CV_32F);
        ///  -   Mat points(count, 1, CV_32FC2);
        ///  -   Mat points(1, count, CV_32FC2);
        ///  -   std::vector&lt;cv::Point2f&gt; points(sampleCount);
        /// </param>
        /// <param name="K">
        /// Number of clusters to split the set by.
        /// </param>
        /// <param name="bestLabels">
        /// Input/output integer array that stores the cluster indices for every sample.
        /// </param>
        /// <param name="criteria">
        /// The algorithm termination criteria, that is, the maximum number of iterations and/or
        ///  the desired accuracy. The accuracy is specified as criteria.epsilon. As soon as each of the cluster
        ///  centers moves by less than criteria.epsilon on some iteration, the algorithm stops.
        /// </param>
        /// <param name="attempts">
        /// Flag to specify the number of times the algorithm is executed using different
        ///  initial labellings. The algorithm returns the labels that yield the best compactness (see the last
        ///  function parameter).
        /// </param>
        /// <param name="flags">
        /// Flag that can take values of cv::KmeansFlags
        /// </param>
        /// <param name="centers">
        /// Output matrix of the cluster centers, one row per each cluster center.
        /// </param>
        /// <returns>
        ///  The function returns the compactness measure that is computed as
        ///  \f[\sum _i  \| \texttt{samples} _i -  \texttt{centers} _{ \texttt{labels} _i} \| ^2\f]
        ///  after every attempt. The best (minimum) value is chosen and the corresponding labels and the
        ///  compactness value are returned by the function. Basically, you can use only the core of the
        ///  function, set the number of attempts to 1, initialize labels each time using a custom algorithm,
        ///  pass them with the ( flags = #KMEANS_USE_INITIAL_LABELS ) flag, and then choose the best
        ///  (most-compact) clustering.
        /// </returns>
        public static double kmeans(Mat data, int K, Mat bestLabels, TermCriteria criteria, int attempts, int flags)
        {
            if (data != null) data.ThrowIfDisposed();
            if (bestLabels != null) bestLabels.ThrowIfDisposed();

            return core_Core_kmeans_11(data.nativeObj, K, bestLabels.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon, attempts, flags);


        }


        //
        // C++:  void cv::setNumThreads(int nthreads)
        //

        /// <summary>
        ///  OpenCV will try to set the number of threads for subsequent parallel regions.
        /// </summary>
        /// <remarks>
        ///  If threads == 1, OpenCV will disable threading optimizations and run all it's functions
        ///  sequentially. Passing threads &lt; 0 will reset threads number to system default.
        ///  The function is not thread-safe. It must not be called in parallel region or concurrent threads.
        ///  
        ///  OpenCV will try to run its functions with specified threads number, but some behaviour differs from
        ///  framework:
        ///  -   `TBB` - User-defined parallel constructions will run with the same threads number, if
        ///      another is not specified. If later on user creates his own scheduler, OpenCV will use it.
        ///  -   `OpenMP` - No special defined behaviour.
        ///  -   `Concurrency` - If threads == 1, OpenCV will disable threading optimizations and run its
        ///      functions sequentially.
        ///  -   `GCD` - Supports only values &lt;= 0.
        ///  -   `C=` - No special defined behaviour.
        /// </remarks>
        /// <param name="nthreads">
        /// Number of threads used by OpenCV.
        ///  @sa getNumThreads, getThreadNum
        /// </param>
        public static void setNumThreads(int nthreads)
        {


            core_Core_setNumThreads_10(nthreads);


        }


        //
        // C++:  int cv::getNumThreads()
        //

        /// <summary>
        ///  Returns the number of threads used by OpenCV for parallel regions.
        /// </summary>
        /// <remarks>
        ///  Always returns 1 if OpenCV is built without threading support.
        ///  
        ///  The exact meaning of return value depends on the threading framework used by OpenCV library:
        ///  - `TBB` - The number of threads, that OpenCV will try to use for parallel regions. If there is
        ///    any tbb::thread_scheduler_init in user code conflicting with OpenCV, then function returns
        ///    default number of threads used by TBB library.
        ///  - `OpenMP` - An upper bound on the number of threads that could be used to form a new team.
        ///  - `Concurrency` - The number of threads, that OpenCV will try to use for parallel regions.
        ///  - `GCD` - Unsupported; returns the GCD thread pool limit (512) for compatibility.
        ///  - `C=` - The number of threads, that OpenCV will try to use for parallel regions, if before
        ///    called setNumThreads with threads &gt; 0, otherwise returns the number of logical CPUs,
        ///    available for the process.
        ///  @sa setNumThreads, getThreadNum
        /// </remarks>
        public static int getNumThreads()
        {


            return core_Core_getNumThreads_10();


        }


        //
        // C++:  int cv::getThreadNum()
        //

        /// <summary>
        ///  Returns the index of the currently executed thread within the current parallel region. Always
        ///  returns 0 if called outside of parallel region.
        /// </summary>
        /// <remarks>
        ///  @deprecated Current implementation doesn't corresponding to this documentation.
        ///  
        ///  The exact meaning of the return value depends on the threading framework used by OpenCV library:
        ///  - `TBB` - Unsupported with current 4.1 TBB release. Maybe will be supported in future.
        ///  - `OpenMP` - The thread number, within the current team, of the calling thread.
        ///  - `Concurrency` - An ID for the virtual processor that the current context is executing on (0
        ///    for master thread and unique number for others, but not necessary 1,2,3,...).
        ///  - `GCD` - System calling thread's ID. Never returns 0 inside parallel region.
        ///  - `C=` - The index of the current parallel task.
        ///  @sa setNumThreads, getNumThreads
        /// </remarks>
        [Obsolete("This method is deprecated.")]
        public static int getThreadNum()
        {


            return core_Core_getThreadNum_10();


        }


        //
        // C++:  String cv::getBuildInformation()
        //

        /// <summary>
        ///  Returns full configuration time cmake output.
        /// </summary>
        /// <remarks>
        ///  Returned value is raw cmake output including version control system revision, compiler version,
        ///  compiler flags, enabled modules and third party libraries, etc. Output format depends on target
        ///  architecture.
        /// </remarks>
        public static string getBuildInformation()
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_getBuildInformation_10()));

            return retVal;
        }


        //
        // C++:  String cv::getVersionString()
        //

        /// <summary>
        ///  Returns library version string
        /// </summary>
        /// <remarks>
        ///  For example "3.4.1-dev".
        ///  
        ///  @sa getMajorVersion, getMinorVersion, getRevisionVersion
        /// </remarks>
        public static string getVersionString()
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_getVersionString_10()));

            return retVal;
        }


        //
        // C++:  int cv::getVersionMajor()
        //

        /// <summary>
        ///  Returns major library version
        /// </summary>
        public static int getVersionMajor()
        {


            return core_Core_getVersionMajor_10();


        }


        //
        // C++:  int cv::getVersionMinor()
        //

        /// <summary>
        ///  Returns minor library version
        /// </summary>
        public static int getVersionMinor()
        {


            return core_Core_getVersionMinor_10();


        }


        //
        // C++:  int cv::getVersionRevision()
        //

        /// <summary>
        ///  Returns revision field of the library version
        /// </summary>
        public static int getVersionRevision()
        {


            return core_Core_getVersionRevision_10();


        }


        //
        // C++:  int64 cv::getTickCount()
        //

        /// <summary>
        ///  Returns the number of ticks.
        /// </summary>
        /// <remarks>
        ///  The function returns the number of ticks after the certain event (for example, when the machine was
        ///  turned on). It can be used to initialize RNG or to measure a function execution time by reading the
        ///  tick count before and after the function call.
        ///  @sa getTickFrequency, TickMeter
        /// </remarks>
        public static long getTickCount()
        {


            return core_Core_getTickCount_10();


        }


        //
        // C++:  double cv::getTickFrequency()
        //

        /// <summary>
        ///  Returns the number of ticks per second.
        /// </summary>
        /// <remarks>
        ///  The function returns the number of ticks per second. That is, the following code computes the
        ///  execution time in seconds:
        /// </remarks>
        /// <code language="c++">
        ///      double t = (double)getTickCount();
        ///      // do something ...
        ///      t = ((double)getTickCount() - t)/getTickFrequency();
        /// </code>
        /// <remarks>
        ///  @sa getTickCount, TickMeter
        /// </remarks>
        public static double getTickFrequency()
        {


            return core_Core_getTickFrequency_10();


        }


        //
        // C++:  int64 cv::getCPUTickCount()
        //

        /// <summary>
        ///  Returns the number of CPU ticks.
        /// </summary>
        /// <remarks>
        ///  The function returns the current number of CPU ticks on some architectures (such as x86, x64,
        ///  PowerPC). On other platforms the function is equivalent to getTickCount. It can also be used for
        ///  very accurate time measurements, as well as for RNG initialization. Note that in case of multi-CPU
        ///  systems a thread, from which getCPUTickCount is called, can be suspended and resumed at another CPU
        ///  with its own counter. So, theoretically (and practically) the subsequent calls to the function do
        ///  not necessary return the monotonously increasing values. Also, since a modern CPU varies the CPU
        ///  frequency depending on the load, the number of CPU clocks spent in some code cannot be directly
        ///  converted to time units. Therefore, getTickCount is generally a preferable solution for measuring
        ///  execution time.
        /// </remarks>
        public static long getCPUTickCount()
        {


            return core_Core_getCPUTickCount_10();


        }


        //
        // C++:  bool cv::checkHardwareSupport(int feature)
        //

        /// <summary>
        ///  Returns true if the specified feature is supported by the host hardware.
        /// </summary>
        /// <remarks>
        ///  The function returns true if the host hardware supports the specified feature. When user calls
        ///  setUseOptimized(false), the subsequent calls to checkHardwareSupport() will return false until
        ///  setUseOptimized(true) is called. This way user can dynamically switch on and off the optimized code
        ///  in OpenCV.
        /// </remarks>
        /// <param name="feature">
        /// The feature of interest, one of cv::CpuFeatures
        /// </param>
        public static bool checkHardwareSupport(int feature)
        {


            return core_Core_checkHardwareSupport_10(feature);


        }


        //
        // C++:  String cv::getHardwareFeatureName(int feature)
        //

        /// <summary>
        ///  Returns feature name by ID
        /// </summary>
        /// <remarks>
        ///  Returns empty string if feature is not defined
        /// </remarks>
        public static string getHardwareFeatureName(int feature)
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_getHardwareFeatureName_10(feature)));

            return retVal;
        }


        //
        // C++:  string cv::getCPUFeaturesLine()
        //

        /// <summary>
        ///  Returns list of CPU features enabled during compilation.
        /// </summary>
        /// <remarks>
        ///  Returned value is a string containing space separated list of CPU features with following markers:
        ///  
        ///  - no markers - baseline features
        ///  - prefix `*` - features enabled in dispatcher
        ///  - suffix `?` - features enabled but not available in HW
        ///  
        ///  Example: `SSE SSE2 SSE3 *SSE4.1 *SSE4.2 *FP16 *AVX *AVX2 *AVX512-SKX?`
        /// </remarks>
        public static string getCPUFeaturesLine()
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_getCPUFeaturesLine_10()));

            return retVal;
        }


        //
        // C++:  int cv::getNumberOfCPUs()
        //

        /// <summary>
        ///  Returns the number of logical CPUs available for the process.
        /// </summary>
        public static int getNumberOfCPUs()
        {


            return core_Core_getNumberOfCPUs_10();


        }


        //
        // C++:  void cv::setUseOptimized(bool onoff)
        //

        /// <summary>
        ///  Enables or disables the optimized code.
        /// </summary>
        /// <remarks>
        ///  The function can be used to dynamically turn on and off optimized dispatched code (code that uses SSE4.2, AVX/AVX2,
        ///  and other instructions on the platforms that support it). It sets a global flag that is further
        ///  checked by OpenCV functions. Since the flag is not checked in the inner OpenCV loops, it is only
        ///  safe to call the function on the very top level in your application where you can be sure that no
        ///  other OpenCV function is currently executed.
        ///  
        ///  By default, the optimized code is enabled unless you disable it in CMake. The current status can be
        ///  retrieved using useOptimized.
        /// </remarks>
        /// <param name="onoff">
        /// The boolean flag specifying whether the optimized code should be used (onoff=true)
        ///  or not (onoff=false).
        /// </param>
        public static void setUseOptimized(bool onoff)
        {


            core_Core_setUseOptimized_10(onoff);


        }


        //
        // C++:  bool cv::useOptimized()
        //

        /// <summary>
        ///  Returns the status of optimized code usage.
        /// </summary>
        /// <remarks>
        ///  The function returns true if the optimized code is enabled. Otherwise, it returns false.
        /// </remarks>
        public static bool useOptimized()
        {


            return core_Core_useOptimized_10();


        }


        //
        // C++:  String cv::samples::findFile(String relative_path, bool required = true, bool silentMode = false)
        //

        /// <summary>
        ///  Try to find requested data file
        /// </summary>
        /// <remarks>
        ///  Search directories:
        ///  
        ///  1. Directories passed via `addSamplesDataSearchPath()`
        ///  2. OPENCV_SAMPLES_DATA_PATH_HINT environment variable
        ///  3. OPENCV_SAMPLES_DATA_PATH environment variable
        ///     If parameter value is not empty and nothing is found then stop searching.
        ///  4. Detects build/install path based on:
        ///     a. current working directory (CWD)
        ///     b. and/or binary module location (opencv_core/opencv_world, doesn't work with static linkage)
        ///  5. Scan `&lt;source&gt;/{,data,samples/data}` directories if build directory is detected or the current directory is in source tree.
        ///  6. Scan `&lt;install&gt;/share/OpenCV` directory if install directory is detected.
        ///  
        ///  @see cv::utils::findDataFile
        /// </remarks>
        /// <param name="relative_path">
        /// Relative path to data file
        /// </param>
        /// <param name="required">
        /// Specify "file not found" handling.
        ///         If true, function prints information message and raises cv::Exception.
        ///         If false, function returns empty result
        /// </param>
        /// <param name="silentMode">
        /// Disables messages
        /// </param>
        /// <returns>
        ///  Returns path (absolute or relative to the current directory) or empty string if file is not found
        /// </returns>
        public static string findFile(string relative_path, bool required, bool silentMode)
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_findFile_10(relative_path, required, silentMode)));

            return retVal;
        }

        /// <summary>
        ///  Try to find requested data file
        /// </summary>
        /// <remarks>
        ///  Search directories:
        ///  
        ///  1. Directories passed via `addSamplesDataSearchPath()`
        ///  2. OPENCV_SAMPLES_DATA_PATH_HINT environment variable
        ///  3. OPENCV_SAMPLES_DATA_PATH environment variable
        ///     If parameter value is not empty and nothing is found then stop searching.
        ///  4. Detects build/install path based on:
        ///     a. current working directory (CWD)
        ///     b. and/or binary module location (opencv_core/opencv_world, doesn't work with static linkage)
        ///  5. Scan `&lt;source&gt;/{,data,samples/data}` directories if build directory is detected or the current directory is in source tree.
        ///  6. Scan `&lt;install&gt;/share/OpenCV` directory if install directory is detected.
        ///  
        ///  @see cv::utils::findDataFile
        /// </remarks>
        /// <param name="relative_path">
        /// Relative path to data file
        /// </param>
        /// <param name="required">
        /// Specify "file not found" handling.
        ///         If true, function prints information message and raises cv::Exception.
        ///         If false, function returns empty result
        /// </param>
        /// <param name="silentMode">
        /// Disables messages
        /// </param>
        /// <returns>
        ///  Returns path (absolute or relative to the current directory) or empty string if file is not found
        /// </returns>
        public static string findFile(string relative_path, bool required)
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_findFile_11(relative_path, required)));

            return retVal;
        }

        /// <summary>
        ///  Try to find requested data file
        /// </summary>
        /// <remarks>
        ///  Search directories:
        ///  
        ///  1. Directories passed via `addSamplesDataSearchPath()`
        ///  2. OPENCV_SAMPLES_DATA_PATH_HINT environment variable
        ///  3. OPENCV_SAMPLES_DATA_PATH environment variable
        ///     If parameter value is not empty and nothing is found then stop searching.
        ///  4. Detects build/install path based on:
        ///     a. current working directory (CWD)
        ///     b. and/or binary module location (opencv_core/opencv_world, doesn't work with static linkage)
        ///  5. Scan `&lt;source&gt;/{,data,samples/data}` directories if build directory is detected or the current directory is in source tree.
        ///  6. Scan `&lt;install&gt;/share/OpenCV` directory if install directory is detected.
        ///  
        ///  @see cv::utils::findDataFile
        /// </remarks>
        /// <param name="relative_path">
        /// Relative path to data file
        /// </param>
        /// <param name="required">
        /// Specify "file not found" handling.
        ///         If true, function prints information message and raises cv::Exception.
        ///         If false, function returns empty result
        /// </param>
        /// <param name="silentMode">
        /// Disables messages
        /// </param>
        /// <returns>
        ///  Returns path (absolute or relative to the current directory) or empty string if file is not found
        /// </returns>
        public static string findFile(string relative_path)
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_findFile_12(relative_path)));

            return retVal;
        }


        //
        // C++:  String cv::samples::findFileOrKeep(String relative_path, bool silentMode = false)
        //

        public static string findFileOrKeep(string relative_path, bool silentMode)
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_findFileOrKeep_10(relative_path, silentMode)));

            return retVal;
        }

        public static string findFileOrKeep(string relative_path)
        {


            string retVal = Marshal.PtrToStringAnsi(DisposableObject.ThrowIfNullIntPtr(core_Core_findFileOrKeep_11(relative_path)));

            return retVal;
        }


        //
        // C++:  void cv::samples::addSamplesDataSearchPath(String path)
        //

        /// <summary>
        ///  Override search data path by adding new search location
        /// </summary>
        /// <remarks>
        ///  Use this only to override default behavior
        ///  Passed paths are used in LIFO order.
        /// </remarks>
        /// <param name="path">
        /// Path to used samples data
        /// </param>
        public static void addSamplesDataSearchPath(string path)
        {


            core_Core_addSamplesDataSearchPath_10(path);


        }


        //
        // C++:  void cv::samples::addSamplesDataSearchSubDirectory(String subdir)
        //

        /// <summary>
        ///  Append samples search data sub directory
        /// </summary>
        /// <remarks>
        ///  General usage is to add OpenCV modules name (`&lt;opencv_contrib&gt;/modules/&lt;name&gt;/samples/data` -&gt; `&lt;name&gt;/samples/data` + `modules/&lt;name&gt;/samples/data`).
        ///  Passed subdirectories are used in LIFO order.
        /// </remarks>
        /// <param name="subdir">
        /// samples data sub directory
        /// </param>
        public static void addSamplesDataSearchSubDirectory(string subdir)
        {


            core_Core_addSamplesDataSearchSubDirectory_10(subdir);


        }


        //
        // C++:  void cv::setErrorVerbosity(bool verbose)
        //

        public static void setErrorVerbosity(bool verbose)
        {


            core_Core_setErrorVerbosity_10(verbose);


        }


        //
        // C++:  void cv::add(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        public static void add(Mat src1, Scalar src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_add_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj, dtype);


        }

        public static void add(Mat src1, Scalar src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_add_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj);


        }

        public static void add(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_add_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::subtract(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        public static void subtract(Mat src1, Scalar src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_subtract_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj, dtype);


        }

        public static void subtract(Mat src1, Scalar src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();
            if (mask != null) mask.ThrowIfDisposed();

            core_Core_subtract_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj);


        }

        public static void subtract(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_subtract_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::multiply(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        public static void multiply(Mat src1, Scalar src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_multiply_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale, dtype);


        }

        public static void multiply(Mat src1, Scalar src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_multiply_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale);


        }

        public static void multiply(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_multiply_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::divide(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        public static void divide(Mat src1, Scalar src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale, dtype);


        }

        public static void divide(Mat src1, Scalar src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_16(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale);


        }

        public static void divide(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_divide_17(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::absdiff(Mat src1, Scalar src2, Mat& dst)
        //

        public static void absdiff(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_absdiff_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::compare(Mat src1, Scalar src2, Mat& dst, int cmpop)
        //

        public static void compare(Mat src1, Scalar src2, Mat dst, int cmpop)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_compare_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, cmpop);


        }


        //
        // C++:  void cv::min(Mat src1, Scalar src2, Mat& dst)
        //

        public static void min(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_min_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }


        //
        // C++:  void cv::max(Mat src1, Scalar src2, Mat& dst)
        //

        public static void max(Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            core_Core_max_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);


        }

        // manual port
        public class MinMaxLocResult
        {
            public double minVal;
            public double maxVal;
            public Point minLoc;
            public Point maxLoc;


            public MinMaxLocResult()
            {
                minVal = 0; maxVal = 0;
                minLoc = new Point();
                maxLoc = new Point();
            }
        }


        // C++: minMaxLoc(Mat src, double* minVal, double* maxVal=0, Point* minLoc=0, Point* maxLoc=0, InputArray mask=noArray())


        //javadoc: minMaxLoc(src, mask)
        public static MinMaxLocResult minMaxLoc(Mat src, Mat mask)
        {
            if (src != null)
                src.ThrowIfDisposed();
            if (mask != null)
                mask.ThrowIfDisposed();


            MinMaxLocResult res = new MinMaxLocResult();
            IntPtr maskNativeObj = IntPtr.Zero;
            if (mask != null)
            {
                maskNativeObj = mask.nativeObj;
            }
            double[] resarr = new double[6];
            core_Core_n_1minMaxLocManual(src.nativeObj, maskNativeObj, resarr);
            res.minVal = resarr[0];
            res.maxVal = resarr[1];
            res.minLoc.x = resarr[2];
            res.minLoc.y = resarr[3];
            res.maxLoc.x = resarr[4];
            res.maxLoc.y = resarr[5];
            return res;
        }


        //javadoc: minMaxLoc(src)
        public static MinMaxLocResult minMaxLoc(Mat src)
        {
            if (src != null)
                src.ThrowIfDisposed();


            return minMaxLoc(src, null);
        }
#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  float cv::cubeRoot(float val)
        [DllImport(LIBNAME)]
        private static extern float core_Core_cubeRoot_10(float val);

        // C++:  float cv::fastAtan2(float y, float x)
        [DllImport(LIBNAME)]
        private static extern float core_Core_fastAtan2_10(float y, float x);

        // C++:  bool cv::ipp::useIPP()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_useIPP_10();

        // C++:  void cv::ipp::setUseIPP(bool flag)
        [DllImport(LIBNAME)]
        private static extern void core_Core_setUseIPP_10([MarshalAs(UnmanagedType.U1)] bool flag);

        // C++:  String cv::ipp::getIppVersion()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_getIppVersion_10();

        // C++:  bool cv::ipp::useIPP_NotExact()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_useIPP_1NotExact_10();

        // C++:  void cv::ipp::setUseIPP_NotExact(bool flag)
        [DllImport(LIBNAME)]
        private static extern void core_Core_setUseIPP_1NotExact_10([MarshalAs(UnmanagedType.U1)] bool flag);

        // C++:  int cv::borderInterpolate(int p, int len, int borderType)
        [DllImport(LIBNAME)]
        private static extern int core_Core_borderInterpolate_10(int p, int len, int borderType);

        // C++:  void cv::copyMakeBorder(Mat src, Mat& dst, int top, int bottom, int left, int right, int borderType, Scalar value = Scalar())
        [DllImport(LIBNAME)]
        private static extern void core_Core_copyMakeBorder_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int top, int bottom, int left, int right, int borderType, double value_val0, double value_val1, double value_val2, double value_val3);
        [DllImport(LIBNAME)]
        private static extern void core_Core_copyMakeBorder_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int top, int bottom, int left, int right, int borderType);

        // C++:  void cv::add(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_add_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_add_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_add_12(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::subtract(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_subtract_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_subtract_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_subtract_12(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::multiply(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_multiply_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_multiply_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void core_Core_multiply_12(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::divide(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_12(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::divide(double scale, Mat src2, Mat& dst, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_13(double scale, IntPtr src2_nativeObj, IntPtr dst_nativeObj, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_14(double scale, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::scaleAdd(Mat src1, double alpha, Mat src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_scaleAdd_10(IntPtr src1_nativeObj, double alpha, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::addWeighted(Mat src1, double alpha, Mat src2, double beta, double gamma, Mat& dst, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_addWeighted_10(IntPtr src1_nativeObj, double alpha, IntPtr src2_nativeObj, double beta, double gamma, IntPtr dst_nativeObj, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_addWeighted_11(IntPtr src1_nativeObj, double alpha, IntPtr src2_nativeObj, double beta, double gamma, IntPtr dst_nativeObj);

        // C++:  void cv::convertScaleAbs(Mat src, Mat& dst, double alpha = 1, double beta = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_convertScaleAbs_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta);
        [DllImport(LIBNAME)]
        private static extern void core_Core_convertScaleAbs_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha);
        [DllImport(LIBNAME)]
        private static extern void core_Core_convertScaleAbs_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::convertFp16(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_convertFp16_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::LUT(Mat src, Mat lut, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_LUT_10(IntPtr src_nativeObj, IntPtr lut_nativeObj, IntPtr dst_nativeObj);

        // C++:  Scalar cv::sum(Mat src)
        [DllImport(LIBNAME)]
        private static extern void core_Core_sumElems_10(IntPtr src_nativeObj, double[] retVal);

        // C++:  bool cv::hasNonZero(Mat src)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_hasNonZero_10(IntPtr src_nativeObj);

        // C++:  int cv::countNonZero(Mat src)
        [DllImport(LIBNAME)]
        private static extern int core_Core_countNonZero_10(IntPtr src_nativeObj);

        // C++:  void cv::findNonZero(Mat src, Mat& idx)
        [DllImport(LIBNAME)]
        private static extern void core_Core_findNonZero_10(IntPtr src_nativeObj, IntPtr idx_nativeObj);

        // C++:  Scalar cv::mean(Mat src, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_mean_10(IntPtr src_nativeObj, IntPtr mask_nativeObj, double[] retVal);
        [DllImport(LIBNAME)]
        private static extern void core_Core_mean_11(IntPtr src_nativeObj, double[] retVal);

        // C++:  void cv::meanStdDev(Mat src, vector_double& mean, vector_double& stddev, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_meanStdDev_10(IntPtr src_nativeObj, IntPtr mean_mat_nativeObj, IntPtr stddev_mat_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_meanStdDev_11(IntPtr src_nativeObj, IntPtr mean_mat_nativeObj, IntPtr stddev_mat_nativeObj);

        // C++:  double cv::norm(Mat src1, int normType = NORM_L2, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern double core_Core_norm_10(IntPtr src1_nativeObj, int normType, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double core_Core_norm_11(IntPtr src1_nativeObj, int normType);
        [DllImport(LIBNAME)]
        private static extern double core_Core_norm_12(IntPtr src1_nativeObj);

        // C++:  double cv::norm(Mat src1, Mat src2, int normType = NORM_L2, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern double core_Core_norm_13(IntPtr src1_nativeObj, IntPtr src2_nativeObj, int normType, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double core_Core_norm_14(IntPtr src1_nativeObj, IntPtr src2_nativeObj, int normType);
        [DllImport(LIBNAME)]
        private static extern double core_Core_norm_15(IntPtr src1_nativeObj, IntPtr src2_nativeObj);

        // C++:  double cv::PSNR(Mat src1, Mat src2, double R = 255.)
        [DllImport(LIBNAME)]
        private static extern double core_Core_PSNR_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, double R);
        [DllImport(LIBNAME)]
        private static extern double core_Core_PSNR_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj);

        // C++:  void cv::batchDistance(Mat src1, Mat src2, Mat& dist, int dtype, Mat& nidx, int normType = NORM_L2, int K = 0, Mat mask = Mat(), int update = 0, bool crosscheck = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_batchDistance_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType, int K, IntPtr mask_nativeObj, int update, [MarshalAs(UnmanagedType.U1)] bool crosscheck);
        [DllImport(LIBNAME)]
        private static extern void core_Core_batchDistance_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType, int K, IntPtr mask_nativeObj, int update);
        [DllImport(LIBNAME)]
        private static extern void core_Core_batchDistance_12(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType, int K, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_batchDistance_13(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType, int K);
        [DllImport(LIBNAME)]
        private static extern void core_Core_batchDistance_14(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType);
        [DllImport(LIBNAME)]
        private static extern void core_Core_batchDistance_15(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj);

        // C++:  void cv::normalize(Mat src, Mat& dst, double alpha = 1, double beta = 0, int norm_type = NORM_L2, int dtype = -1, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_normalize_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta, int norm_type, int dtype, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_normalize_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta, int norm_type, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_normalize_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta, int norm_type);
        [DllImport(LIBNAME)]
        private static extern void core_Core_normalize_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta);
        [DllImport(LIBNAME)]
        private static extern void core_Core_normalize_14(IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha);
        [DllImport(LIBNAME)]
        private static extern void core_Core_normalize_15(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::reduceArgMin(Mat src, Mat& dst, int axis, bool lastIndex = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_reduceArgMin_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int axis, [MarshalAs(UnmanagedType.U1)] bool lastIndex);
        [DllImport(LIBNAME)]
        private static extern void core_Core_reduceArgMin_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int axis);

        // C++:  void cv::reduceArgMax(Mat src, Mat& dst, int axis, bool lastIndex = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_reduceArgMax_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int axis, [MarshalAs(UnmanagedType.U1)] bool lastIndex);
        [DllImport(LIBNAME)]
        private static extern void core_Core_reduceArgMax_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int axis);

        // C++:  void cv::reduce(Mat src, Mat& dst, int dim, int rtype, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_reduce_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dim, int rtype, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_reduce_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int dim, int rtype);

        // C++:  void cv::merge(vector_Mat mv, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_merge_10(IntPtr mv_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::split(Mat m, vector_Mat& mv)
        [DllImport(LIBNAME)]
        private static extern void core_Core_split_10(IntPtr m_nativeObj, IntPtr mv_mat_nativeObj);

        // C++:  void cv::mixChannels(vector_Mat src, vector_Mat dst, vector_int fromTo)
        [DllImport(LIBNAME)]
        private static extern void core_Core_mixChannels_10(IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr fromTo_mat_nativeObj);

        // C++:  void cv::extractChannel(Mat src, Mat& dst, int coi)
        [DllImport(LIBNAME)]
        private static extern void core_Core_extractChannel_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int coi);

        // C++:  void cv::insertChannel(Mat src, Mat& dst, int coi)
        [DllImport(LIBNAME)]
        private static extern void core_Core_insertChannel_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int coi);

        // C++:  void cv::flip(Mat src, Mat& dst, int flipCode)
        [DllImport(LIBNAME)]
        private static extern void core_Core_flip_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flipCode);

        // C++:  void cv::flipND(Mat src, Mat& dst, int axis)
        [DllImport(LIBNAME)]
        private static extern void core_Core_flipND_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int axis);

        // C++:  void cv::broadcast(Mat src, Mat shape, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_broadcast_10(IntPtr src_nativeObj, IntPtr shape_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::rotate(Mat src, Mat& dst, int rotateCode)
        [DllImport(LIBNAME)]
        private static extern void core_Core_rotate_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int rotateCode);

        // C++:  void cv::repeat(Mat src, int ny, int nx, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_repeat_10(IntPtr src_nativeObj, int ny, int nx, IntPtr dst_nativeObj);

        // C++:  void cv::hconcat(vector_Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_hconcat_10(IntPtr src_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::vconcat(vector_Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_vconcat_10(IntPtr src_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::bitwise_and(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1and_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1and_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::bitwise_or(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1or_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1or_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::bitwise_xor(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1xor_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1xor_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::bitwise_not(Mat src, Mat& dst, Mat mask = Mat())
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1not_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_bitwise_1not_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::absdiff(Mat src1, Mat src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_absdiff_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::copyTo(Mat src, Mat& dst, Mat mask)
        [DllImport(LIBNAME)]
        private static extern void core_Core_copyTo_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);

        // C++:  void cv::inRange(Mat src, Scalar lowerb, Scalar upperb, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_inRange_10(IntPtr src_nativeObj, double lowerb_val0, double lowerb_val1, double lowerb_val2, double lowerb_val3, double upperb_val0, double upperb_val1, double upperb_val2, double upperb_val3, IntPtr dst_nativeObj);

        // C++:  void cv::compare(Mat src1, Mat src2, Mat& dst, int cmpop)
        [DllImport(LIBNAME)]
        private static extern void core_Core_compare_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, int cmpop);

        // C++:  void cv::min(Mat src1, Mat src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_min_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::max(Mat src1, Mat src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_max_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::sqrt(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_sqrt_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::pow(Mat src, double power, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_pow_10(IntPtr src_nativeObj, double power, IntPtr dst_nativeObj);

        // C++:  void cv::exp(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_exp_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::log(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_log_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::polarToCart(Mat magnitude, Mat angle, Mat& x, Mat& y, bool angleInDegrees = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_polarToCart_10(IntPtr magnitude_nativeObj, IntPtr angle_nativeObj, IntPtr x_nativeObj, IntPtr y_nativeObj, [MarshalAs(UnmanagedType.U1)] bool angleInDegrees);
        [DllImport(LIBNAME)]
        private static extern void core_Core_polarToCart_11(IntPtr magnitude_nativeObj, IntPtr angle_nativeObj, IntPtr x_nativeObj, IntPtr y_nativeObj);

        // C++:  void cv::cartToPolar(Mat x, Mat y, Mat& magnitude, Mat& angle, bool angleInDegrees = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_cartToPolar_10(IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr magnitude_nativeObj, IntPtr angle_nativeObj, [MarshalAs(UnmanagedType.U1)] bool angleInDegrees);
        [DllImport(LIBNAME)]
        private static extern void core_Core_cartToPolar_11(IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr magnitude_nativeObj, IntPtr angle_nativeObj);

        // C++:  void cv::phase(Mat x, Mat y, Mat& angle, bool angleInDegrees = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_phase_10(IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr angle_nativeObj, [MarshalAs(UnmanagedType.U1)] bool angleInDegrees);
        [DllImport(LIBNAME)]
        private static extern void core_Core_phase_11(IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr angle_nativeObj);

        // C++:  void cv::magnitude(Mat x, Mat y, Mat& magnitude)
        [DllImport(LIBNAME)]
        private static extern void core_Core_magnitude_10(IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr magnitude_nativeObj);

        // C++:  bool cv::checkRange(Mat a, bool quiet = true,  _hidden_ * pos = 0, double minVal = -DBL_MAX, double maxVal = DBL_MAX)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_checkRange_10(IntPtr a_nativeObj, [MarshalAs(UnmanagedType.U1)] bool quiet, double minVal, double maxVal);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_checkRange_11(IntPtr a_nativeObj, [MarshalAs(UnmanagedType.U1)] bool quiet, double minVal);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_checkRange_12(IntPtr a_nativeObj, [MarshalAs(UnmanagedType.U1)] bool quiet);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_checkRange_14(IntPtr a_nativeObj);

        // C++:  void cv::patchNaNs(Mat& a, double val = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_patchNaNs_10(IntPtr a_nativeObj, double val);
        [DllImport(LIBNAME)]
        private static extern void core_Core_patchNaNs_11(IntPtr a_nativeObj);

        // C++:  void cv::gemm(Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat& dst, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_gemm_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, double alpha, IntPtr src3_nativeObj, double beta, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void core_Core_gemm_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, double alpha, IntPtr src3_nativeObj, double beta, IntPtr dst_nativeObj);

        // C++:  void cv::mulTransposed(Mat src, Mat& dst, bool aTa, Mat delta = Mat(), double scale = 1, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_mulTransposed_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, [MarshalAs(UnmanagedType.U1)] bool aTa, IntPtr delta_nativeObj, double scale, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_mulTransposed_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, [MarshalAs(UnmanagedType.U1)] bool aTa, IntPtr delta_nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void core_Core_mulTransposed_12(IntPtr src_nativeObj, IntPtr dst_nativeObj, [MarshalAs(UnmanagedType.U1)] bool aTa, IntPtr delta_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_mulTransposed_13(IntPtr src_nativeObj, IntPtr dst_nativeObj, [MarshalAs(UnmanagedType.U1)] bool aTa);

        // C++:  void cv::transpose(Mat src, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_transpose_10(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::transposeND(Mat src, vector_int order, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_transposeND_10(IntPtr src_nativeObj, IntPtr order_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::transform(Mat src, Mat& dst, Mat m)
        [DllImport(LIBNAME)]
        private static extern void core_Core_transform_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr m_nativeObj);

        // C++:  void cv::perspectiveTransform(Mat src, Mat& dst, Mat m)
        [DllImport(LIBNAME)]
        private static extern void core_Core_perspectiveTransform_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr m_nativeObj);

        // C++:  void cv::completeSymm(Mat& m, bool lowerToUpper = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_completeSymm_10(IntPtr m_nativeObj, [MarshalAs(UnmanagedType.U1)] bool lowerToUpper);
        [DllImport(LIBNAME)]
        private static extern void core_Core_completeSymm_11(IntPtr m_nativeObj);

        // C++:  void cv::setIdentity(Mat& mtx, Scalar s = Scalar(1))
        [DllImport(LIBNAME)]
        private static extern void core_Core_setIdentity_10(IntPtr mtx_nativeObj, double s_val0, double s_val1, double s_val2, double s_val3);
        [DllImport(LIBNAME)]
        private static extern void core_Core_setIdentity_11(IntPtr mtx_nativeObj);

        // C++:  double cv::determinant(Mat mtx)
        [DllImport(LIBNAME)]
        private static extern double core_Core_determinant_10(IntPtr mtx_nativeObj);

        // C++:  Scalar cv::trace(Mat mtx)
        [DllImport(LIBNAME)]
        private static extern void core_Core_trace_10(IntPtr mtx_nativeObj, double[] retVal);

        // C++:  double cv::invert(Mat src, Mat& dst, int flags = DECOMP_LU)
        [DllImport(LIBNAME)]
        private static extern double core_Core_invert_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern double core_Core_invert_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  bool cv::solve(Mat src1, Mat src2, Mat& dst, int flags = DECOMP_LU)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_solve_10(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_solve_11(IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::sort(Mat src, Mat& dst, int flags)
        [DllImport(LIBNAME)]
        private static extern void core_Core_sort_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);

        // C++:  void cv::sortIdx(Mat src, Mat& dst, int flags)
        [DllImport(LIBNAME)]
        private static extern void core_Core_sortIdx_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);

        // C++:  int cv::solveCubic(Mat coeffs, Mat& roots)
        [DllImport(LIBNAME)]
        private static extern int core_Core_solveCubic_10(IntPtr coeffs_nativeObj, IntPtr roots_nativeObj);

        // C++:  double cv::solvePoly(Mat coeffs, Mat& roots, int maxIters = 300)
        [DllImport(LIBNAME)]
        private static extern double core_Core_solvePoly_10(IntPtr coeffs_nativeObj, IntPtr roots_nativeObj, int maxIters);
        [DllImport(LIBNAME)]
        private static extern double core_Core_solvePoly_11(IntPtr coeffs_nativeObj, IntPtr roots_nativeObj);

        // C++:  bool cv::eigen(Mat src, Mat& eigenvalues, Mat& eigenvectors = Mat())
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_eigen_10(IntPtr src_nativeObj, IntPtr eigenvalues_nativeObj, IntPtr eigenvectors_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_eigen_11(IntPtr src_nativeObj, IntPtr eigenvalues_nativeObj);

        // C++:  void cv::eigenNonSymmetric(Mat src, Mat& eigenvalues, Mat& eigenvectors)
        [DllImport(LIBNAME)]
        private static extern void core_Core_eigenNonSymmetric_10(IntPtr src_nativeObj, IntPtr eigenvalues_nativeObj, IntPtr eigenvectors_nativeObj);

        // C++:  void cv::calcCovarMatrix(Mat samples, Mat& covar, Mat& mean, int flags, int ctype = CV_64F)
        [DllImport(LIBNAME)]
        private static extern void core_Core_calcCovarMatrix_10(IntPtr samples_nativeObj, IntPtr covar_nativeObj, IntPtr mean_nativeObj, int flags, int ctype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_calcCovarMatrix_11(IntPtr samples_nativeObj, IntPtr covar_nativeObj, IntPtr mean_nativeObj, int flags);

        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, int maxComponents = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCACompute_10(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, int maxComponents);
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCACompute_11(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj);

        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, Mat& eigenvalues, int maxComponents = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCACompute2_10(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr eigenvalues_nativeObj, int maxComponents);
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCACompute2_11(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr eigenvalues_nativeObj);

        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, double retainedVariance)
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCACompute_12(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, double retainedVariance);

        // C++:  void cv::PCACompute(Mat data, Mat& mean, Mat& eigenvectors, Mat& eigenvalues, double retainedVariance)
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCACompute2_12(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr eigenvalues_nativeObj, double retainedVariance);

        // C++:  void cv::PCAProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCAProject_10(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr result_nativeObj);

        // C++:  void cv::PCABackProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        [DllImport(LIBNAME)]
        private static extern void core_Core_PCABackProject_10(IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr result_nativeObj);

        // C++:  void cv::SVDecomp(Mat src, Mat& w, Mat& u, Mat& vt, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_SVDecomp_10(IntPtr src_nativeObj, IntPtr w_nativeObj, IntPtr u_nativeObj, IntPtr vt_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void core_Core_SVDecomp_11(IntPtr src_nativeObj, IntPtr w_nativeObj, IntPtr u_nativeObj, IntPtr vt_nativeObj);

        // C++:  void cv::SVBackSubst(Mat w, Mat u, Mat vt, Mat rhs, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_SVBackSubst_10(IntPtr w_nativeObj, IntPtr u_nativeObj, IntPtr vt_nativeObj, IntPtr rhs_nativeObj, IntPtr dst_nativeObj);

        // C++:  double cv::Mahalanobis(Mat v1, Mat v2, Mat icovar)
        [DllImport(LIBNAME)]
        private static extern double core_Core_Mahalanobis_10(IntPtr v1_nativeObj, IntPtr v2_nativeObj, IntPtr icovar_nativeObj);

        // C++:  void cv::dft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_dft_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, int nonzeroRows);
        [DllImport(LIBNAME)]
        private static extern void core_Core_dft_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void core_Core_dft_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::idft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_idft_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, int nonzeroRows);
        [DllImport(LIBNAME)]
        private static extern void core_Core_idft_11(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void core_Core_idft_12(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::dct(Mat src, Mat& dst, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_dct_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void core_Core_dct_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::idct(Mat src, Mat& dst, int flags = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_idct_10(IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport(LIBNAME)]
        private static extern void core_Core_idct_11(IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void cv::mulSpectrums(Mat a, Mat b, Mat& c, int flags, bool conjB = false)
        [DllImport(LIBNAME)]
        private static extern void core_Core_mulSpectrums_10(IntPtr a_nativeObj, IntPtr b_nativeObj, IntPtr c_nativeObj, int flags, [MarshalAs(UnmanagedType.U1)] bool conjB);
        [DllImport(LIBNAME)]
        private static extern void core_Core_mulSpectrums_11(IntPtr a_nativeObj, IntPtr b_nativeObj, IntPtr c_nativeObj, int flags);

        // C++:  int cv::getOptimalDFTSize(int vecsize)
        [DllImport(LIBNAME)]
        private static extern int core_Core_getOptimalDFTSize_10(int vecsize);

        // C++:  void cv::setRNGSeed(int seed)
        [DllImport(LIBNAME)]
        private static extern void core_Core_setRNGSeed_10(int seed);

        // C++:  void cv::randu(Mat& dst, double low, double high)
        [DllImport(LIBNAME)]
        private static extern void core_Core_randu_10(IntPtr dst_nativeObj, double low, double high);

        // C++:  void cv::randn(Mat& dst, double mean, double stddev)
        [DllImport(LIBNAME)]
        private static extern void core_Core_randn_10(IntPtr dst_nativeObj, double mean, double stddev);

        // C++:  void cv::randShuffle(Mat& dst, double iterFactor = 1., RNG* rng = 0)
        [DllImport(LIBNAME)]
        private static extern void core_Core_randShuffle_10(IntPtr dst_nativeObj, double iterFactor);
        [DllImport(LIBNAME)]
        private static extern void core_Core_randShuffle_12(IntPtr dst_nativeObj);

        // C++:  double cv::kmeans(Mat data, int K, Mat& bestLabels, TermCriteria criteria, int attempts, int flags, Mat& centers = Mat())
        [DllImport(LIBNAME)]
        private static extern double core_Core_kmeans_10(IntPtr data_nativeObj, int K, IntPtr bestLabels_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon, int attempts, int flags, IntPtr centers_nativeObj);
        [DllImport(LIBNAME)]
        private static extern double core_Core_kmeans_11(IntPtr data_nativeObj, int K, IntPtr bestLabels_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon, int attempts, int flags);

        // C++:  void cv::setNumThreads(int nthreads)
        [DllImport(LIBNAME)]
        private static extern void core_Core_setNumThreads_10(int nthreads);

        // C++:  int cv::getNumThreads()
        [DllImport(LIBNAME)]
        private static extern int core_Core_getNumThreads_10();

        // C++:  int cv::getThreadNum()
        [DllImport(LIBNAME)]
        private static extern int core_Core_getThreadNum_10();

        // C++:  String cv::getBuildInformation()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_getBuildInformation_10();

        // C++:  String cv::getVersionString()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_getVersionString_10();

        // C++:  int cv::getVersionMajor()
        [DllImport(LIBNAME)]
        private static extern int core_Core_getVersionMajor_10();

        // C++:  int cv::getVersionMinor()
        [DllImport(LIBNAME)]
        private static extern int core_Core_getVersionMinor_10();

        // C++:  int cv::getVersionRevision()
        [DllImport(LIBNAME)]
        private static extern int core_Core_getVersionRevision_10();

        // C++:  int64 cv::getTickCount()
        [DllImport(LIBNAME)]
        private static extern long core_Core_getTickCount_10();

        // C++:  double cv::getTickFrequency()
        [DllImport(LIBNAME)]
        private static extern double core_Core_getTickFrequency_10();

        // C++:  int64 cv::getCPUTickCount()
        [DllImport(LIBNAME)]
        private static extern long core_Core_getCPUTickCount_10();

        // C++:  bool cv::checkHardwareSupport(int feature)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_checkHardwareSupport_10(int feature);

        // C++:  String cv::getHardwareFeatureName(int feature)
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_getHardwareFeatureName_10(int feature);

        // C++:  string cv::getCPUFeaturesLine()
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_getCPUFeaturesLine_10();

        // C++:  int cv::getNumberOfCPUs()
        [DllImport(LIBNAME)]
        private static extern int core_Core_getNumberOfCPUs_10();

        // C++:  void cv::setUseOptimized(bool onoff)
        [DllImport(LIBNAME)]
        private static extern void core_Core_setUseOptimized_10([MarshalAs(UnmanagedType.U1)] bool onoff);

        // C++:  bool cv::useOptimized()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool core_Core_useOptimized_10();

        // C++:  String cv::samples::findFile(String relative_path, bool required = true, bool silentMode = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_findFile_10(string relative_path, [MarshalAs(UnmanagedType.U1)] bool required, [MarshalAs(UnmanagedType.U1)] bool silentMode);
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_findFile_11(string relative_path, [MarshalAs(UnmanagedType.U1)] bool required);
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_findFile_12(string relative_path);

        // C++:  String cv::samples::findFileOrKeep(String relative_path, bool silentMode = false)
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_findFileOrKeep_10(string relative_path, [MarshalAs(UnmanagedType.U1)] bool silentMode);
        [DllImport(LIBNAME)]
        private static extern IntPtr core_Core_findFileOrKeep_11(string relative_path);

        // C++:  void cv::samples::addSamplesDataSearchPath(String path)
        [DllImport(LIBNAME)]
        private static extern void core_Core_addSamplesDataSearchPath_10(string path);

        // C++:  void cv::samples::addSamplesDataSearchSubDirectory(String subdir)
        [DllImport(LIBNAME)]
        private static extern void core_Core_addSamplesDataSearchSubDirectory_10(string subdir);

        // C++:  void cv::setErrorVerbosity(bool verbose)
        [DllImport(LIBNAME)]
        private static extern void core_Core_setErrorVerbosity_10([MarshalAs(UnmanagedType.U1)] bool verbose);

        // C++:  void cv::add(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_add_13(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_add_14(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_add_15(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void cv::subtract(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_subtract_13(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_subtract_14(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_subtract_15(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void cv::multiply(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_multiply_13(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_multiply_14(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void core_Core_multiply_15(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void cv::divide(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_15(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_16(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale);
        [DllImport(LIBNAME)]
        private static extern void core_Core_divide_17(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void cv::absdiff(Mat src1, Scalar src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_absdiff_11(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void cv::compare(Mat src1, Scalar src2, Mat& dst, int cmpop)
        [DllImport(LIBNAME)]
        private static extern void core_Core_compare_11(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, int cmpop);

        // C++:  void cv::min(Mat src1, Scalar src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_min_11(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void cv::max(Mat src1, Scalar src2, Mat& dst)
        [DllImport(LIBNAME)]
        private static extern void core_Core_max_11(IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);
        [DllImport(LIBNAME)]
        private static extern void core_Core_n_1minMaxLocManual(IntPtr src_nativeObj, IntPtr mask_nativeObj, double[] vals);
    }
}
