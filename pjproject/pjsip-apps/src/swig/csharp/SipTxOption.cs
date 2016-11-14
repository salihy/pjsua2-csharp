//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pj {

public class SipTxOption : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipTxOption(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SipTxOption obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipTxOption() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_SipTxOption(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string targetUri {
    set {
      pjsua2PINVOKE.SipTxOption_targetUri_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.SipTxOption_targetUri_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SipHeaderVector headers {
    set {
      pjsua2PINVOKE.SipTxOption_headers_set(swigCPtr, SipHeaderVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTxOption_headers_get(swigCPtr);
      SipHeaderVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipHeaderVector(cPtr, false);
      return ret;
    } 
  }

  public string contentType {
    set {
      pjsua2PINVOKE.SipTxOption_contentType_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.SipTxOption_contentType_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string msgBody {
    set {
      pjsua2PINVOKE.SipTxOption_msgBody_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.SipTxOption_msgBody_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SipMediaType multipartContentType {
    set {
      pjsua2PINVOKE.SipTxOption_multipartContentType_set(swigCPtr, SipMediaType.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTxOption_multipartContentType_get(swigCPtr);
      SipMediaType ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipMediaType(cPtr, false);
      return ret;
    } 
  }

  public SipMultipartPartVector multipartParts {
    set {
      pjsua2PINVOKE.SipTxOption_multipartParts_set(swigCPtr, SipMultipartPartVector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTxOption_multipartParts_get(swigCPtr);
      SipMultipartPartVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipMultipartPartVector(cPtr, false);
      return ret;
    } 
  }

  public bool isEmpty() {
    bool ret = pjsua2PINVOKE.SipTxOption_isEmpty(swigCPtr);
    return ret;
  }

  public SipTxOption() : this(pjsua2PINVOKE.new_SipTxOption(), true) {
  }

}

}
