<Query Kind="Statements">
  <Reference>C:\code\Engage\trunk\projects\Engage.Core\bin\Debug\Engage.Core.dll</Reference>
  <Reference>C:\code\Engage\trunk\projects\packages\HtmlAgilityPack.1.7.2\lib\Net45\HtmlAgilityPack.dll</Reference>
  <Reference>C:\code\Engage\trunk\projects\packages\Newtonsoft.Json.11.0.2\lib\net45\Newtonsoft.Json.dll</Reference>
  <Namespace>Engage.Core.Contentful</Namespace>
  <Namespace>Engage.Core.Integration.Contentful</Namespace>
  <Namespace>HtmlAgilityPack</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
</Query>

Regex reggie = new Regex("^https?://[^ \"]+$");
var url = "https://images.ctfassets.net/5xr3i0mvoxlu/2qlJ3RGcooKaU60gsEkasU/543300b4943716b26b55cbccf2840afd/happynewyear-1.jpg";
if(reggie.IsMatch(url))
{
	Console.WriteLine("Matched");
}
else
{
	Console.WriteLine("No Match");
}
