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

public class OnNatDetectionCompleteParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnNatDetectionCompleteParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnNatDetectionCompleteParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnNatDetectionCompleteParam() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_OnNatDetectionCompleteParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int status {
    set {
      pjsua2PINVOKE.OnNatDetectionCompleteParam_status_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.OnNatDetectionCompleteParam_status_get(swigCPtr);
      return ret;
    } 
  }

  public string reason {
    set {
      pjsua2PINVOKE.OnNatDetectionCompleteParam_reason_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnNatDetectionCompleteParam_reason_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public pj_stun_nat_type natType {
    set {
      pjsua2PINVOKE.OnNatDetectionCompleteParam_natType_set(swigCPtr, (int)value);
    } 
    get {
      pj_stun_nat_type ret = (pj_stun_nat_type)pjsua2PINVOKE.OnNatDetectionCompleteParam_natType_get(swigCPtr);
      return ret;
    } 
  }

  public string natTypeName {
    set {
      pjsua2PINVOKE.OnNatDetectionCompleteParam_natTypeName_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnNatDetectionCompleteParam_natTypeName_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public OnNatDetectionCompleteParam() : this(pjsua2PINVOKE.new_OnNatDetectionCompleteParam(), true) {
  }

}

}
