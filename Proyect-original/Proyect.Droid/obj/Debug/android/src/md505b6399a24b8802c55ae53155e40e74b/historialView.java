package md505b6399a24b8802c55ae53155e40e74b;


public class historialView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Proyect.Droid.Views.historialView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", historialView.class, __md_methods);
	}


	public historialView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == historialView.class)
			mono.android.TypeManager.Activate ("Proyect.Droid.Views.historialView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
