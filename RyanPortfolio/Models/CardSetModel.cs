namespace RyanPortfolio.Models
{
	public class CardSetModel
	{
		public int cardSetId { get; set; }
		public string name { get; set; }
		public DateTime release { get; set; }
		public bool isModern { get; set; }
		public bool isStandard { get; set; }
		public bool isHistoric {get; set;}
	}
}
