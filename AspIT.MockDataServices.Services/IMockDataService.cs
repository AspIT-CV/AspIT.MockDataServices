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
    public interface IMockDataService
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

        /// <summary>
        /// Gets all addresses from the Addresses table in the database, and then returns it in JSON format.
        /// </summary>
        /// <returns>Addresses in JSON format</returns>
        [OperationContract]
        string GetAllAddresses();

        /// <summary>
        /// Gets the specified amount of addresses from the Addresses table in the database, and then returns it in JSON format.
        /// </summary>
        /// <param name="amount">The amount of addresses to get. If the amount is more than what is in the table, then only that amount will be retreived.</param>
        /// <returns>Addresses in JSON format</returns>
        [OperationContract]
        string GetAddresses(int amount);
    }
}