package md5f79b0bbca6d6be9131c2fd663bd0d067;


public class FormattedButtonRenderer
	extends md58432a647068b097f9637064b8985a5e0.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("InTheHand.Forms.Platform.Android.FormattedButtonRenderer, InTheHand.Forms.Platform.Android", FormattedButtonRenderer.class, __md_methods);
	}


	public FormattedButtonRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == FormattedButtonRenderer.class)
			mono.android.TypeManager.Activate ("InTheHand.Forms.Platform.Android.FormattedButtonRenderer, InTheHand.Forms.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public FormattedButtonRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == FormattedButtonRenderer.class)
			mono.android.TypeManager.Activate ("InTheHand.Forms.Platform.Android.FormattedButtonRenderer, InTheHand.Forms.Platform.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public FormattedButtonRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == FormattedButtonRenderer.class)
			mono.android.TypeManager.Activate ("InTheHand.Forms.Platform.Android.FormattedButtonRenderer, InTheHand.Forms.Platform.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
