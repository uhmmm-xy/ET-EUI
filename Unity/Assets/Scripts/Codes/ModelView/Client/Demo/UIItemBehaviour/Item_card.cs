
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[EnableMethod]
	public  class Scroll_Item_card : Entity,IAwake,IDestroy,IUIScrollItem 
	{
		public long DataId {get;set;}
		private bool isCacheNode = false;
		public void SetCacheMode(bool isCache)
		{
			this.isCacheNode = isCache;
		}

		public Scroll_Item_card BindTrans(Transform trans)
		{
			this.uiTransform = trans;
			return this;
		}

		public UnityEngine.UI.Text ELabel_typeText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_ELabel_typeText == null )
     				{
		    			this.m_ELabel_typeText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_type");
     				}
     				return this.m_ELabel_typeText;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_type");
     			}
     		}
     	}

		public UnityEngine.UI.Text ELabel_textText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_ELabel_textText == null )
     				{
		    			this.m_ELabel_textText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_text");
     				}
     				return this.m_ELabel_textText;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_text");
     			}
     		}
     	}

		public UnityEngine.UI.Button EButton_buttonButton
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_EButton_buttonButton == null )
     				{
		    			this.m_EButton_buttonButton = UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_button");
     				}
     				return this.m_EButton_buttonButton;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Button>(this.uiTransform.gameObject,"EButton_button");
     			}
     		}
     	}

		public UnityEngine.UI.Image EButton_buttonImage
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if (this.isCacheNode)
     			{
     				if( this.m_EButton_buttonImage == null )
     				{
		    			this.m_EButton_buttonImage = UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_button");
     				}
     				return this.m_EButton_buttonImage;
     			}
     			else
     			{
		    		return UIFindHelper.FindDeepChild<UnityEngine.UI.Image>(this.uiTransform.gameObject,"EButton_button");
     			}
     		}
     	}

		public void DestroyWidget()
		{
			this.m_ELabel_typeText = null;
			this.m_ELabel_textText = null;
			this.m_EButton_buttonButton = null;
			this.m_EButton_buttonImage = null;
			this.uiTransform = null;
			this.DataId = 0;
		}

		private UnityEngine.UI.Text m_ELabel_typeText = null;
		private UnityEngine.UI.Text m_ELabel_textText = null;
		private UnityEngine.UI.Button m_EButton_buttonButton = null;
		private UnityEngine.UI.Image m_EButton_buttonImage = null;
		public Transform uiTransform = null;
	}
}
