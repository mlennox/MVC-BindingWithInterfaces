namespace PartialBindingExample.Models
{
	public interface IYourModelUpdate
	{
		string PublicValue { get; set; }
		string AlterOnlyInUpdate { get; set; } 
	}
}