//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.11
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


		using System;
	
class HDFqlPINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="SWIGRegisterExceptionCallbacks_HDFql")]
    public static extern void SWIGRegisterExceptionCallbacks_HDFql(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_HDFql")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_HDFql(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_HDFql(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_HDFql(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(HDFqlPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(HDFqlPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="SWIGRegisterStringCallback_HDFql")]
    public static extern void SWIGRegisterStringCallback_HDFql(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_HDFql(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static HDFqlPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_new_HDFqlCursor")]
  public static extern global::System.IntPtr new_HDFqlCursor();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_delete_HDFqlCursor")]
  public static extern void delete_HDFqlCursor(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Version_get")]
  public static extern string Version_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_BufferSize_get")]
  public static extern int BufferSize_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Yes_get")]
  public static extern int Yes_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_No_get")]
  public static extern int No_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Enabled_get")]
  public static extern int Enabled_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Disabled_get")]
  public static extern int Disabled_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Default_get")]
  public static extern int Default_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Undefined_get")]
  public static extern int Undefined_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Global_get")]
  public static extern int Global_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Local_get")]
  public static extern int Local_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Tracked_get")]
  public static extern int Tracked_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Indexed_get")]
  public static extern int Indexed_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Directory_get")]
  public static extern int Directory_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_File_get")]
  public static extern int File_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Group_get")]
  public static extern int Group_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Dataset_get")]
  public static extern int Dataset_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Attribute_get")]
  public static extern int Attribute_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SoftLink_get")]
  public static extern int SoftLink_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_HardLink_get")]
  public static extern int HardLink_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ExternalLink_get")]
  public static extern int ExternalLink_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Contiguous_get")]
  public static extern int Contiguous_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Compact_get")]
  public static extern int Compact_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Chunked_get")]
  public static extern int Chunked_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_TinyInt_get")]
  public static extern int TinyInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedTinyInt_get")]
  public static extern int UnsignedTinyInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SmallInt_get")]
  public static extern int SmallInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedSmallInt_get")]
  public static extern int UnsignedSmallInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Int_get")]
  public static extern int Int_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedInt_get")]
  public static extern int UnsignedInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_BigInt_get")]
  public static extern int BigInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedBigInt_get")]
  public static extern int UnsignedBigInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Float_get")]
  public static extern int Float_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Double_get")]
  public static extern int Double_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Char_get")]
  public static extern int Char_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarTinyInt_get")]
  public static extern int VarTinyInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedVarTinyInt_get")]
  public static extern int UnsignedVarTinyInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarSmallInt_get")]
  public static extern int VarSmallInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedVarSmallInt_get")]
  public static extern int UnsignedVarSmallInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarInt_get")]
  public static extern int VarInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedVarInt_get")]
  public static extern int UnsignedVarInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarBigInt_get")]
  public static extern int VarBigInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_UnsignedVarBigInt_get")]
  public static extern int UnsignedVarBigInt_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarFloat_get")]
  public static extern int VarFloat_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarDouble_get")]
  public static extern int VarDouble_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VarChar_get")]
  public static extern int VarChar_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Opaque_get")]
  public static extern int Opaque_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_NativeEndian_get")]
  public static extern int NativeEndian_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_LittleEndian_get")]
  public static extern int LittleEndian_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_BigEndian_get")]
  public static extern int BigEndian_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Ascii_get")]
  public static extern int Ascii_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Utf8_get")]
  public static extern int Utf8_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Success_get")]
  public static extern int Success_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorParse_get")]
  public static extern int ErrorParse_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorNotFound_get")]
  public static extern int ErrorNotFound_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorNoAccess_get")]
  public static extern int ErrorNoAccess_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorAlreadyExists_get")]
  public static extern int ErrorAlreadyExists_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorEmpty_get")]
  public static extern int ErrorEmpty_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorFull_get")]
  public static extern int ErrorFull_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorBeforeFirst_get")]
  public static extern int ErrorBeforeFirst_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorAfterLast_get")]
  public static extern int ErrorAfterLast_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorNoAddress_get")]
  public static extern int ErrorNoAddress_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorNotRegistered_get")]
  public static extern int ErrorNotRegistered_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorOutsideLimit_get")]
  public static extern int ErrorOutsideLimit_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorUnknown_get")]
  public static extern int ErrorUnknown_get();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_Execute")]
  public static extern int Execute(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ExecuteGetStatus")]
  public static extern int ExecuteGetStatus();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorGetLine")]
  public static extern int ErrorGetLine();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorGetPosition")]
  public static extern int ErrorGetPosition();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_ErrorGetMessage")]
  public static extern string ErrorGetMessage();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableRegister")]
  public static extern void VariableRegister(int jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableUnregister")]
  public static extern void VariableUnregister(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableGetDatatype")]
  public static extern int VariableGetDatatype(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableGetCount")]
  public static extern int VariableGetCount(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableGetSize")]
  public static extern int VariableGetSize(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableGetDimensionCount")]
  public static extern int VariableGetDimensionCount(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_VariableGetDimension")]
  public static extern int VariableGetDimension(int jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorInitialize")]
  public static extern int CursorInitialize(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorUse")]
  public static extern int CursorUse(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorUseDefault")]
  public static extern int CursorUseDefault();

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorClear")]
  public static extern int CursorClear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorClone")]
  public static extern int CursorClone(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetDatatype")]
  public static extern int CursorGetDatatype(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetCount")]
  public static extern int CursorGetCount(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetCount")]
  public static extern int SubcursorGetCount(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetPosition")]
  public static extern int CursorGetPosition(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetPosition")]
  public static extern int SubcursorGetPosition(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorFirst")]
  public static extern int CursorFirst(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorFirst")]
  public static extern int SubcursorFirst(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorLast")]
  public static extern int CursorLast(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorLast")]
  public static extern int SubcursorLast(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorNext")]
  public static extern int CursorNext(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorNext")]
  public static extern int SubcursorNext(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorPrevious")]
  public static extern int CursorPrevious(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorPrevious")]
  public static extern int SubcursorPrevious(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorAbsolute")]
  public static extern int CursorAbsolute(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorAbsolute")]
  public static extern int SubcursorAbsolute(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorRelative")]
  public static extern int CursorRelative(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorRelative")]
  public static extern int SubcursorRelative(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetSize")]
  public static extern int CursorGetSize(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetSize")]
  public static extern int SubcursorGetSize(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetTinyInt")]
  public static extern IntPtr CursorGetTinyInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetTinyInt")]
  public static extern IntPtr SubcursorGetTinyInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetUnsignedTinyInt")]
  public static extern global::System.IntPtr CursorGetUnsignedTinyInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetUnsignedTinyInt")]
  public static extern global::System.IntPtr SubcursorGetUnsignedTinyInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetSmallInt")]
  public static extern global::System.IntPtr CursorGetSmallInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetSmallInt")]
  public static extern global::System.IntPtr SubcursorGetSmallInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetUnsignedSmallInt")]
  public static extern global::System.IntPtr CursorGetUnsignedSmallInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetUnsignedSmallInt")]
  public static extern global::System.IntPtr SubcursorGetUnsignedSmallInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetInt")]
  public static extern global::System.IntPtr CursorGetInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetInt")]
  public static extern global::System.IntPtr SubcursorGetInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetUnsignedInt")]
  public static extern global::System.IntPtr CursorGetUnsignedInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetUnsignedInt")]
  public static extern global::System.IntPtr SubcursorGetUnsignedInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetBigInt")]
  public static extern global::System.IntPtr CursorGetBigInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetBigInt")]
  public static extern global::System.IntPtr SubcursorGetBigInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetUnsignedBigInt")]
  public static extern global::System.IntPtr CursorGetUnsignedBigInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetUnsignedBigInt")]
  public static extern global::System.IntPtr SubcursorGetUnsignedBigInt(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetFloat")]
  public static extern global::System.IntPtr CursorGetFloat(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetFloat")]
  public static extern global::System.IntPtr SubcursorGetFloat(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetDouble")]
  public static extern global::System.IntPtr CursorGetDouble(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetDouble")]
  public static extern global::System.IntPtr SubcursorGetDouble(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_CursorGetChar")]
  public static extern string CursorGetChar(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_SubcursorGetChar")]
  public static extern string SubcursorGetChar(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("HDFql", EntryPoint="CSharp_GetCanonicalPath")]
  public static extern string GetCanonicalPath(string jarg1);
}