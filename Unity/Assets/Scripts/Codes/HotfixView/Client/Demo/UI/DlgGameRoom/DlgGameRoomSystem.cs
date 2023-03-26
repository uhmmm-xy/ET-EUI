using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET.Client
{
	[FriendOf(typeof(DlgGameRoom))]
	public static  class DlgGameRoomSystem
	{

		public static void RegisterUIEvent(this DlgGameRoom self)
		{
			self.View.ELoopScrollList_CardLoopHorizontalScrollRect.AddItemRefreshListener((Transform transform ,int index) => { self.OnLoadItemHandler(transform, index); });
		}

		public static void ShowWindow(this DlgGameRoom self, Entity contextData = null)
		{
			self.AddUIScrollItems(ref self.itemDic, 15);
			self.View.ELoopScrollList_CardLoopHorizontalScrollRect.SetVisible(true,15);
		}

		public static void HideWindow(this DlgGameRoom self) 
		{
			self.RemoveUIScrollItems(ref self.itemDic);
		}

		private static void OnLoadItemHandler(this DlgGameRoom self,Transform transform,int index) 
		{
			Scroll_Item_card card = self.itemDic[index].BindTrans(transform);
			card.ELabel_typeText.text = index + "t";
			card.ELabel_textText.text = index + "v";
			card.EButton_buttonButton.onClick.AddListener(() => { self.CardClick(index); });
		}

		private static void CardClick(this DlgGameRoom self,int index) 
		{
			Log.Info("点击了按钮"+index.ToString());
		}

		 

	}
}
