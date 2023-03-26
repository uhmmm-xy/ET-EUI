
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ComponentOf(typeof(DlgGameRoom))]
	[EnableMethod]
	public  class DlgGameRoomViewComponent : Entity,IAwake,IDestroy 
	{
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
			this.m_ELoopScrollList_CardLoopHorizontalScrollRect = null;
			this.uiTransform = null;
		}

		private UnityEngine.UI.LoopHorizontalScrollRect m_ELoopScrollList_CardLoopHorizontalScrollRect = null;
		public Transform uiTransform = null;
	}
}
