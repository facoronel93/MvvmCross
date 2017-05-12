package md505b6399a24b8802c55ae53155e40e74b;


public class MenuView
	extends mvvmcross.droid.views.MvxActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Proyect.Droid.Views.MenuView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MenuView.class, __md_methods);
	}


	public MenuView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MenuView.class)
			mono.android.TypeManager.Activate ("Proyect.Droid.Views.MenuView, Proyect.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
