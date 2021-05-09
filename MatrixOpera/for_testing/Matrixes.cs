/*
* MATLAB Compiler: 8.1 (R2020b)
* Date: Sun May  9 18:39:17 2021
* Arguments:
* "-B""macro_default""-W""dotnet:MatrixOpera,Matrixes,4.0,private,version=1.0""-T""link:li
* b""-d""P:\Documents\MatLab\MatrixOpera\for_testing""-v""class{Matrixes:P:\Documents\MatL
* ab\MatrixOpera.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MatrixOpera
{

  /// <summary>
  /// The Matrixes class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// P:\Documents\MatLab\MatrixOpera.m
  /// </summary>
  /// <remarks>
  /// @Version 1.0
  /// </remarks>
  public class Matrixes : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static Matrixes()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

		  int lastDelimiter = ctfFilePath.LastIndexOf(@"/");

	      if (lastDelimiter == -1)
		  {
		    lastDelimiter = ctfFilePath.LastIndexOf(@"\");
		  }

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "MatrixOpera.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Matrixes class.
    /// </summary>
    public Matrixes()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Matrixes()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the MatrixOpera MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixOpera()
    {
      return mcr.EvaluateFunction("MatrixOpera", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the MatrixOpera MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixOpera(MWArray a)
    {
      return mcr.EvaluateFunction("MatrixOpera", a);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the MatrixOpera MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray MatrixOpera(MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction("MatrixOpera", a, b);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the MatrixOpera MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixOpera(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixOpera", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the MatrixOpera MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixOpera(int numArgsOut, MWArray a)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixOpera", a);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the MatrixOpera MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="a">Input argument #1</param>
    /// <param name="b">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] MatrixOpera(int numArgsOut, MWArray a, MWArray b)
    {
      return mcr.EvaluateFunction(numArgsOut, "MatrixOpera", a, b);
    }


    /// <summary>
    /// Provides an interface for the MatrixOpera function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// 矩阵相加,相减
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void MatrixOpera(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("MatrixOpera", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
