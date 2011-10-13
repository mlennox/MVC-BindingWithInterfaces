namespace PartialBindingExample.Models
{
	public interface IYourModelCreate
	{
		string PublicValue { get; set; }
		string AlterOnlyInCreate { get; set; }
	}
}