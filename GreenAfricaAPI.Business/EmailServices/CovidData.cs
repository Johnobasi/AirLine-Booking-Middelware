using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

public class CovidData
{
    //public CovidData()
    //{
    //    HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("https://covidnigeria.herokuapp.com/api");
    //    request.Method = "GET";
    //    String getresponse = String.Empty;
    //    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
    //    {
    //        Stream dataStream = response.GetResponseStream();
    //        StreamReader reader = new StreamReader(dataStream);
    //        getresponse = reader.ReadToEnd();

    //        reader.Close();
    //        dataStream.Close();
    //    }

    //    //List<Data =JsonConvert.DeserializeObject<List<data(Reader);
    //    CovidData covidData = JsonConvert.DeserializeObject<CovidData>(getresponse);
    //    Console.WriteLine("Total discharged: "+covidData.discharged);
    //}
}



//public class CovidData
//{
//    public string totalSamplesTested { get; set; }
//    public int totalConfirmedCases { get; set; }
//    public int totalActiveCases { get; set; }
//    public int discharged { get; set; }
//    public int death { get; set; }
//    public List<State> states { get; set; }
//}

//public class State
//{
//    public string state { get; set; }
//    public string _id { get; set; }
//    public int confirmedCases { get; set; }
//    public int casesOnAdmission { get; set; }
//    public int discharged { get; set; }
//    public int death { get; set; }
//}


