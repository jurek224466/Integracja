using MySqlConnector;
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
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „Service1” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik Service1.svc lub Service1.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class Service1 : IServiceFiltering
    {
        public List<string> AspectRadio()
        {
            ServiceMethods servics = new ServiceMethods();
            /* return servics.aspectRadio();*/
            return new List<String>();
        }

        public List<string> aspectRatioList(DataTable dt)
        {
            ServiceMethods methods = new ServiceMethods();
           return methods.CalcAspectRadio(dt);
        }

        public DataTable filteringBrand(DataTable dt,String brand)
        {
            ServiceMethods methods = new ServiceMethods();
            return methods.filteringBrand(dt,brand);
           
                
        }

        public DataTable FilteringScreenAspectRadio(DataTable dt,String brand)
        {
            ServiceMethods service = new ServiceMethods();
            service.CalcAspectRadio(dt);
            return service.FilteringScreenAspectRadio(dt,brand);
        }

        public DataTable GetDataFromDataBase()
        {
            ServiceMethods service = new ServiceMethods();
            return service.GetDataFromDataBase();
        }
    }
}
