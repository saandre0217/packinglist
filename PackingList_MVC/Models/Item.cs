using System;
namespace PackingList_MVC.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string ItemName { get; set; }
		public bool isPacked { get; set; }

		public Item()
		{

		}

	}
}

