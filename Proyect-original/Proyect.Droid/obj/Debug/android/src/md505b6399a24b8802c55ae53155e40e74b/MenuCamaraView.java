package md505b6399a24b8802c55ae53155e40e74b;


public class MenuCamaraView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Proyect.Droid.Views.MenuCamaraView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MenuCamaraView.class, __md_methods);
	}


	public MenuCamaraView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MenuCamaraView.class)
			mono.android.TypeManager.Activate ("Proyect.Droid.Views.MenuCamaraView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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