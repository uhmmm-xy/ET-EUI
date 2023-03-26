using System.Collections.Generic;

namespace ET.Client
{
	 [ComponentOf(typeof(UIBaseWindow))]
	public  class DlgGameRoom :Entity,IAwake,IUILogic
	{

		public DlgGameRoomViewComponent View { get => this.GetComponent<DlgGameRoomViewComponent>();}

		public Dictionary<int, Scroll_Item_card> itemDic = new Dictionary<int, Scroll_Item_card>();

	}
}
