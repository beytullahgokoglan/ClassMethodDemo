using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Interface;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            //var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcNo), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateofBirth);
            //return result.Result.Body.TCKimlikNoDogrulaResult;

            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcNo), gamer.FirstName, gamer.LastName, gamer.DateofBirth).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

     

