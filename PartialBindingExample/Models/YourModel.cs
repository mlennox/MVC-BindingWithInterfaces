namespace PartialBindingExample.Models
{
	public class YourModel : IYourModelUpdate, IYourModelCreate
	{
		public string PublicValue { get; set; }

		public string AlterOnlyInCreate { get; set; }

		public string AlterOnlyInUpdate { get; set; }
	}
}