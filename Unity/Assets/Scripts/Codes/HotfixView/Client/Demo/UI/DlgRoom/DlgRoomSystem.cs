using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[FriendOf(typeof(DlgRoom))]
	public static  class DlgRoomSystem
	{

		public static void RegisterUIEvent(this DlgRoom self)
		{
			self.View.ELoopScrollList_CardLoopHorizontalScrollRect.AddItemRefreshListener((Transform transform, int index) => { self.OnLoadItemHandler(transform, index); });
		}

		public static void ShowWindow(this DlgRoom self, Entity contextData = null)
		{
			self.AddUIScrollItems(ref self.cardDict, 15);
			self.View.ELoopScrollList_CardLoopHorizontalScrollRect.SetVisible(true, 15);

		}

		public static void OnLoadItemHandler(this DlgRoom self,Transform transform, int index) { }

		 

	}
}
