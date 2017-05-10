package md5d2b99979f632ebc8511266eb02403f08;


public class climaView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Proyect.Droid.climaView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", climaView.class, __md_methods);
	}


	public climaView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == climaView.class)
			mono.android.TypeManager.Activate ("Proyect.Droid.climaView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
