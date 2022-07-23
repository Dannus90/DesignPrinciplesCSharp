namespace Builder.FacetedBuilder;

public class Person
{
    public string StressAddress = "", Postcode = "", City = "";
    public string CompanyName = "", Position = "";
    public int AnnualIncome;
 
    public override string ToString()
    {
        return $"{nameof(StressAddress)}: {StressAddress}," +
               $" {nameof(Postcode)}: {Postcode}," +
               $" {nameof(City)}: {City}," +
               $" {nameof(CompanyName)}: {CompanyName}," +
               $" {nameof(Position)}: {Position}," +
               $" {nameof(AnnualIncome)}: {AnnualIncome}";
    }
}