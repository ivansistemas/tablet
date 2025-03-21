using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
public class Class1
{
    [JsonProperty("status")]
    public bool Status { get; set; }
    [JsonProperty("message")]
    public string Message { get; set; }
    [JsonProperty("data")]
    public Info[] Data { get; set; }
    public Class1()
	{
    }
    public class Info
    {
        [JsonProperty("id")] public int id { get; set; }
        [JsonProperty("locationForValidationScan")] public string locationForValidationScan { get; set; }
        [JsonProperty("binForValidationScan")] public string binForValidationScan { get; set; }
        [JsonProperty("DESCRIPCION")] public string DESCRIPCION { get; set; }
        [JsonProperty("display")] public string display { get; set; }



    }
}
