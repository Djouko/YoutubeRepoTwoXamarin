package mono.com.felipecsl.gifimageview.library;


public class GifImageView_OnFrameAvailableListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.felipecsl.gifimageview.library.GifImageView.OnFrameAvailableListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onFrameAvailable:(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;:GetOnFrameAvailable_Landroid_graphics_Bitmap_Handler:Felipecsl.GifImageViewLibrary.GifImageView/IOnFrameAvailableListenerInvoker, Refractored.GifImageView\n" +
			"";
		mono.android.Runtime.register ("Felipecsl.GifImageViewLibrary.GifImageView+IOnFrameAvailableListenerImplementor, Refractored.GifImageView", GifImageView_OnFrameAvailableListenerImplementor.class, __md_methods);
	}


	public GifImageView_OnFrameAvailableListenerImplementor ()
	{
		super ();
		if (getClass () == GifImageView_OnFrameAvailableListenerImplementor.class)
			mono.android.TypeManager.Activate ("Felipecsl.GifImageViewLibrary.GifImageView+IOnFrameAvailableListenerImplementor, Refractored.GifImageView", "", this, new java.lang.Object[] {  });
	}


	public android.graphics.Bitmap onFrameAvailable (android.graphics.Bitmap p0)
	{
		return n_onFrameAvailable (p0);
	}

	private native android.graphics.Bitmap n_onFrameAvailable (android.graphics.Bitmap p0);

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
