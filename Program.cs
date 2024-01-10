// See https://aka.ms/new-console-template for more information

using ProductDetails;

List<Products> product = new List<Products>()
{
    new Products() {PName="iPhone x15",PPrice=96000,PBrand="Apple",ManufacturingDate=new DateTime(day:12,month:03,year:2020),ExpiryDate=new DateTime(day:14,month:11,year:2022)},
    new Products() {PName="Oppo 10pro",PPrice=76000,PBrand="Oppo",ManufacturingDate=new DateTime(day:11,month:09,year:2019),ExpiryDate=new DateTime(day:11,month:09,year:2023)},
    new Products() {PName="Samsung S32",PPrice=86000,PBrand="Samsung",ManufacturingDate=new DateTime(day:10,month:08,year:2020),ExpiryDate=new DateTime(day:12,month:07,year:2024)},
    new Products() {PName="Redmi note12",PPrice=75000,PBrand="Mi",ManufacturingDate=new DateTime(day:15,month:07,year:2021),ExpiryDate=new DateTime(day:22,month:05,year:2022)},
    new Products() {PName="iPhone x13",PPrice=89000,PBrand="Apple",ManufacturingDate=new DateTime(day:12,month:09,year:2021),ExpiryDate=new DateTime(day:15,month:05,year:2022)},
    new Products() {PName="Vivo y35",PPrice=89000,PBrand="Vivo",ManufacturingDate=new DateTime(day:17,month:07,year:2021),ExpiryDate=new DateTime(day:19,month:09,year:2025)},
  
};
Console.WriteLine("PName\t \t PPrice \t PBrand \t MfDate \t \t ExpDate");
foreach (Products pro in product)
{
    Console.Write(pro.PName + "\t \t");
    Console.Write(pro.PPrice + "\t \t");
    Console.Write(pro.PBrand + "\t \t");
    Console.Write(pro.ManufacturingDate.ToLongDateString()+"\t \t");
    Console.Write(pro.ExpiryDate.ToLongDateString());
    Console.WriteLine("\n");
}