using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Windows.Forms;

namespace WcfServiceApp
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IServiceFiltering
    {

        [OperationContract]
        DataTable GetDataFromDataBase();

        [OperationContract]
        DataTable FilteringScreenAspectRadio(DataTable dt,String brand);

        [OperationContract]
        DataTable filteringBrand(DataTable dt,String brand);
        [OperationContract]
        List<String> aspectRatioList(DataTable dt);
        



    }


}
