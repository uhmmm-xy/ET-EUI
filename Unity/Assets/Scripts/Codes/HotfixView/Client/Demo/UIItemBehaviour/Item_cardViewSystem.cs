
using UnityEngine;
using UnityEngine.UI;
namespace ET.Client
{
	[ObjectSystem]
	public class Scroll_Item_cardDestroySystem : DestroySystem<Scroll_Item_card> 
	{
		protected override void Destroy( Scroll_Item_card self )
		{
			self.DestroyWidget();
		}
	}
}
