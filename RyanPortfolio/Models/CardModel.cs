namespace RyanPortfolio.Models
{
	public class CardModel
	{
		public int cardId { get; set; }
		public string name { get; set; }
		public int whiteCost { get; set; }
		public int greenCost { get; set; }
		public int blueCost { get; set; }
		public int redCost { get; set; }
		public int blackCost { get; set; }
		public int colorlessCost { get; set; }
		public string color { get; set; }
		public string type { get; set; }
		public string power { get; set; }
		public string toughness { get; set; }
		public string condition { get; set; }
		public string language { get; set; }
		public bool isLegendary { get; set; }
		public int cardsetid { get; set; }
	}
}
