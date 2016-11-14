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

public class Account : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Account(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Account obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Account() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_Account(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Account() : this(pjsua2PINVOKE.new_Account(), true) {
    SwigDirectorConnect();
  }

  public void create(AccountConfig cfg, bool make_default) {
    pjsua2PINVOKE.Account_create__SWIG_0(swigCPtr, AccountConfig.getCPtr(cfg), make_default);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void create(AccountConfig cfg) {
    pjsua2PINVOKE.Account_create__SWIG_1(swigCPtr, AccountConfig.getCPtr(cfg));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void modify(AccountConfig cfg) {
    pjsua2PINVOKE.Account_modify(swigCPtr, AccountConfig.getCPtr(cfg));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isValid() {
    bool ret = pjsua2PINVOKE.Account_isValid(swigCPtr);
    return ret;
  }

  public void setDefault() {
    pjsua2PINVOKE.Account_setDefault(swigCPtr);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isDefault() {
    bool ret = pjsua2PINVOKE.Account_isDefault(swigCPtr);
    return ret;
  }

  public int getId() {
    int ret = pjsua2PINVOKE.Account_getId(swigCPtr);
    return ret;
  }

  public static Account lookup(int acc_id) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Account_lookup(acc_id);
    Account ret = (cPtr == global::System.IntPtr.Zero) ? null : new Account(cPtr, false);
    return ret;
  }

  public AccountInfo getInfo() {
    AccountInfo ret = new AccountInfo(pjsua2PINVOKE.Account_getInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRegistration(bool renew) {
    pjsua2PINVOKE.Account_setRegistration(swigCPtr, renew);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void setOnlineStatus(PresenceStatus pres_st) {
    pjsua2PINVOKE.Account_setOnlineStatus(swigCPtr, PresenceStatus.getCPtr(pres_st));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTransport(int tp_id) {
    pjsua2PINVOKE.Account_setTransport(swigCPtr, tp_id);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void presNotify(PresNotifyParam prm) {
    pjsua2PINVOKE.Account_presNotify(swigCPtr, PresNotifyParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public BuddyVector enumBuddies() {
    BuddyVector ret = new BuddyVector(pjsua2PINVOKE.Account_enumBuddies(swigCPtr), false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Buddy findBuddy(string uri, FindBuddyMatch buddy_match) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Account_findBuddy__SWIG_0(swigCPtr, uri, FindBuddyMatch.getCPtr(buddy_match));
    Buddy ret = (cPtr == global::System.IntPtr.Zero) ? null : new Buddy(cPtr, false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Buddy findBuddy(string uri) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Account_findBuddy__SWIG_1(swigCPtr, uri);
    Buddy ret = (cPtr == global::System.IntPtr.Zero) ? null : new Buddy(cPtr, false);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addBuddy(Buddy buddy) {
    pjsua2PINVOKE.Account_addBuddy(swigCPtr, Buddy.getCPtr(buddy));
  }

  public void removeBuddy(Buddy buddy) {
    pjsua2PINVOKE.Account_removeBuddy(swigCPtr, Buddy.getCPtr(buddy));
  }

  public virtual void onIncomingCall(OnIncomingCallParam prm) {
    if (SwigDerivedClassHasMethod("onIncomingCall", swigMethodTypes0)) pjsua2PINVOKE.Account_onIncomingCallSwigExplicitAccount(swigCPtr, OnIncomingCallParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onIncomingCall(swigCPtr, OnIncomingCallParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onRegStarted(OnRegStartedParam prm) {
    if (SwigDerivedClassHasMethod("onRegStarted", swigMethodTypes1)) pjsua2PINVOKE.Account_onRegStartedSwigExplicitAccount(swigCPtr, OnRegStartedParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onRegStarted(swigCPtr, OnRegStartedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onRegState(OnRegStateParam prm) {
    if (SwigDerivedClassHasMethod("onRegState", swigMethodTypes2)) pjsua2PINVOKE.Account_onRegStateSwigExplicitAccount(swigCPtr, OnRegStateParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onRegState(swigCPtr, OnRegStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onIncomingSubscribe(OnIncomingSubscribeParam prm) {
    if (SwigDerivedClassHasMethod("onIncomingSubscribe", swigMethodTypes3)) pjsua2PINVOKE.Account_onIncomingSubscribeSwigExplicitAccount(swigCPtr, OnIncomingSubscribeParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onIncomingSubscribe(swigCPtr, OnIncomingSubscribeParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onInstantMessage(OnInstantMessageParam prm) {
    if (SwigDerivedClassHasMethod("onInstantMessage", swigMethodTypes4)) pjsua2PINVOKE.Account_onInstantMessageSwigExplicitAccount(swigCPtr, OnInstantMessageParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onInstantMessage(swigCPtr, OnInstantMessageParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onInstantMessageStatus(OnInstantMessageStatusParam prm) {
    if (SwigDerivedClassHasMethod("onInstantMessageStatus", swigMethodTypes5)) pjsua2PINVOKE.Account_onInstantMessageStatusSwigExplicitAccount(swigCPtr, OnInstantMessageStatusParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onInstantMessageStatus(swigCPtr, OnInstantMessageStatusParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onTypingIndication(OnTypingIndicationParam prm) {
    if (SwigDerivedClassHasMethod("onTypingIndication", swigMethodTypes6)) pjsua2PINVOKE.Account_onTypingIndicationSwigExplicitAccount(swigCPtr, OnTypingIndicationParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onTypingIndication(swigCPtr, OnTypingIndicationParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onMwiInfo(OnMwiInfoParam prm) {
    if (SwigDerivedClassHasMethod("onMwiInfo", swigMethodTypes7)) pjsua2PINVOKE.Account_onMwiInfoSwigExplicitAccount(swigCPtr, OnMwiInfoParam.getCPtr(prm)); else pjsua2PINVOKE.Account_onMwiInfo(swigCPtr, OnMwiInfoParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("onIncomingCall", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateAccount_0(SwigDirectoronIncomingCall);
    if (SwigDerivedClassHasMethod("onRegStarted", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateAccount_1(SwigDirectoronRegStarted);
    if (SwigDerivedClassHasMethod("onRegState", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateAccount_2(SwigDirectoronRegState);
    if (SwigDerivedClassHasMethod("onIncomingSubscribe", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateAccount_3(SwigDirectoronIncomingSubscribe);
    if (SwigDerivedClassHasMethod("onInstantMessage", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateAccount_4(SwigDirectoronInstantMessage);
    if (SwigDerivedClassHasMethod("onInstantMessageStatus", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateAccount_5(SwigDirectoronInstantMessageStatus);
    if (SwigDerivedClassHasMethod("onTypingIndication", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateAccount_6(SwigDirectoronTypingIndication);
    if (SwigDerivedClassHasMethod("onMwiInfo", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateAccount_7(SwigDirectoronMwiInfo);
    pjsua2PINVOKE.Account_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Account));
    return hasDerivedMethod;
  }

  private void SwigDirectoronIncomingCall(global::System.IntPtr prm) {
    onIncomingCall(new OnIncomingCallParam(prm, false));
  }

  private void SwigDirectoronRegStarted(global::System.IntPtr prm) {
    onRegStarted(new OnRegStartedParam(prm, false));
  }

  private void SwigDirectoronRegState(global::System.IntPtr prm) {
    onRegState(new OnRegStateParam(prm, false));
  }

  private void SwigDirectoronIncomingSubscribe(global::System.IntPtr prm) {
    onIncomingSubscribe(new OnIncomingSubscribeParam(prm, false));
  }

  private void SwigDirectoronInstantMessage(global::System.IntPtr prm) {
    onInstantMessage(new OnInstantMessageParam(prm, false));
  }

  private void SwigDirectoronInstantMessageStatus(global::System.IntPtr prm) {
    onInstantMessageStatus(new OnInstantMessageStatusParam(prm, false));
  }

  private void SwigDirectoronTypingIndication(global::System.IntPtr prm) {
    onTypingIndication(new OnTypingIndicationParam(prm, false));
  }

  private void SwigDirectoronMwiInfo(global::System.IntPtr prm) {
    onMwiInfo(new OnMwiInfoParam(prm, false));
  }

  public delegate void SwigDelegateAccount_0(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_1(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_2(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_3(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_4(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_5(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_6(global::System.IntPtr prm);
  public delegate void SwigDelegateAccount_7(global::System.IntPtr prm);

  private SwigDelegateAccount_0 swigDelegate0;
  private SwigDelegateAccount_1 swigDelegate1;
  private SwigDelegateAccount_2 swigDelegate2;
  private SwigDelegateAccount_3 swigDelegate3;
  private SwigDelegateAccount_4 swigDelegate4;
  private SwigDelegateAccount_5 swigDelegate5;
  private SwigDelegateAccount_6 swigDelegate6;
  private SwigDelegateAccount_7 swigDelegate7;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(OnIncomingCallParam) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(OnRegStartedParam) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(OnRegStateParam) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(OnIncomingSubscribeParam) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(OnInstantMessageParam) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(OnInstantMessageStatusParam) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(OnTypingIndicationParam) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(OnMwiInfoParam) };
}

}
