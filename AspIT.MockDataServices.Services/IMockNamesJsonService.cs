using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AspIT.MockDataServices.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMockNamesJsonService
    {
        /// <summary>
        /// Selects all names from the DanishNames table, and then returns the names in JSON format.
        /// </summary>
        /// <returns>The names in JSON format</returns>
        [OperationContract]
        string GetAllDanishNames();

        /// <summary>
        /// Selects the amount of names specified from the DanishNames table, and then returns the names in JSON format.
        /// </summary>
        /// <returns>The names in JSON format</returns>
        /// <param name="amount">How many names to select.</param>
        [OperationContract]
        string GetDanishNames(int amount);
    }
}