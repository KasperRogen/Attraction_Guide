package md592dad29b48c921d86ac04e6f0466f88a;


public class IndependentAnimalActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("GuidR.Droid.IndependentAnimalActivity, GuidR.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", IndependentAnimalActivity.class, __md_methods);
	}


	public IndependentAnimalActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == IndependentAnimalActivity.class)
			mono.android.TypeManager.Activate ("GuidR.Droid.IndependentAnimalActivity, GuidR.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
