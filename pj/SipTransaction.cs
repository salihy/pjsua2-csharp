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

public class SipTransaction : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipTransaction(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SipTransaction obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipTransaction() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_SipTransaction(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public pjsip_role_e role {
    set {
      pjsua2PINVOKE.SipTransaction_role_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_role_e ret = (pjsip_role_e)pjsua2PINVOKE.SipTransaction_role_get(swigCPtr);
      return ret;
    } 
  }

  public string method {
    set {
      pjsua2PINVOKE.SipTransaction_method_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.SipTransaction_method_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int statusCode {
    set {
      pjsua2PINVOKE.SipTransaction_statusCode_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.SipTransaction_statusCode_get(swigCPtr);
      return ret;
    } 
  }

  public string statusText {
    set {
      pjsua2PINVOKE.SipTransaction_statusText_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.SipTransaction_statusText_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public pjsip_tsx_state_e state {
    set {
      pjsua2PINVOKE.SipTransaction_state_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_tsx_state_e ret = (pjsip_tsx_state_e)pjsua2PINVOKE.SipTransaction_state_get(swigCPtr);
      return ret;
    } 
  }

  public SipTxData lastTx {
    set {
      pjsua2PINVOKE.SipTransaction_lastTx_set(swigCPtr, SipTxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTransaction_lastTx_get(swigCPtr);
      SipTxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipTxData(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pjTransaction {
    set {
      pjsua2PINVOKE.SipTransaction_pjTransaction_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTransaction_pjTransaction_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public SipTransaction() : this(pjsua2PINVOKE.new_SipTransaction(), true) {
  }

}

}