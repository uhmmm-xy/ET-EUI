
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgRoom))]
	[EnableMethod]
	public  class DlgRoomViewComponent : Entity,IAwake,IDestroy 
	{
		public UnityEngine.UI.Text ELabel_HellowText
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELabel_HellowText == null )
     			{
		    		this.m_ELabel_HellowText = UIFindHelper.FindDeepChild<UnityEngine.UI.Text>(this.uiTransform.gameObject,"ELabel_Hellow");
     			}
     			return this.m_ELabel_HellowText;
     		}
     	}

		public UnityEngine.UI.LoopHorizontalScrollRect ELoopScrollList_CardLoopHorizontalScrollRect
     	{
     		get
     		{
     			if (this.uiTransform == null)
     			{
     				Log.Error("uiTransform is null.");
     				return null;
     			}
     			if( this.m_ELoopScrollList_CardLoopHorizontalScrollRect == null )
     			{
		    		this.m_ELoopScrollList_CardLoopHorizontalScrollRect = UIFindHelper.FindDeepChild<UnityEngine.UI.LoopHorizontalScrollRect>(this.uiTransform.gameObject,"ELoopScrollList_Card");
     			}
     			return this.m_ELoopScrollList_CardLoopHorizontalScrollRect;
     		}
     	}

		public void DestroyWidget()
		{
			this.m_ELabel_HellowText = null;
			this.m_ELoopScrollList_CardLoopHorizontalScrollRect = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.Text m_ELabel_HellowText = null;
		private UnityEngine.UI.LoopHorizontalScrollRect m_ELoopScrollList_CardLoopHorizontalScrollRect = null;
		public Transform uiTransform = null;
	}
}
