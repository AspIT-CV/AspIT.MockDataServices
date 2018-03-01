using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.MockDataServices.Entities
{
    /// <summary>
    /// Represents an address.
    /// </summary>
    public class Address
    {
        #region [Fields]
        /// <summary>
        /// The street name.
        /// </summary>
        protected string streetName;

        /// <summary>
        /// The street number.
        /// </summary>
        protected string streetNumber;

        /// <summary>
        /// The zip code.
        /// </summary>
        protected string zipCode;

        /// <summary>
        /// The city.
        /// </summary>
        protected string city;

        /// <summary>
        /// The region.
        /// </summary>
        protected string region;

        /// <summary>
        /// The country.
        /// </summary>
        protected string country;
        #endregion /[Fields]

        #region [Constructors]
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="streetName">The street name.</param>
        /// <param name="streetNumber">The street number.</param>
        /// <param name="zipCode">The city's zip code.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="country">The name of the country.</param>
        public Address(string streetName, string streetNumber, string zipCode, string city, string country)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="streetName">The street name.</param>
        /// <param name="streetNumber">The street number.</param>
        /// <param name="zipCode">The city's zip code.</param>
        /// <param name="city">The name of the city.</param>
        /// <param name="region">The name of the region.</param>
        /// <param name="country">The name of the country.</param>
        public Address(string streetName, string streetNumber, string zipCode, string city, string region, string country) : this(streetName, streetNumber, zipCode, city, country)
        {
            Region = region;
        }
        #endregion /[Constructors]

        #region [Properties]
        /// <summary>
        /// Gets or sets <see cref="streetName"/> if the length of the given <see cref="string"/> value length is less or equal to 50.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the given <see cref="string"/> value is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the given <see cref="string"/> value length is greater than 50.</exception>
        public virtual string StreetName
        {
            get => streetName;
            set
            {
                if(value.Replace(" ", string.Empty) == string.Empty)
                {
                    throw new ArgumentException("Street number can't be empty.");
                }

                if(value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of the given value is out of range. The length has to be less or equal to 50.");
                }

                streetName = value;
            }
        }

        /// <summary>
        /// Gets or sets <see cref="streetNumber"/> if the length of the given <see cref="string"/> value length is less or equal to 10.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the given <see cref="string"/> value is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the given <see cref="string"/> value length is greater than 10.</exception>
        public virtual string StreetNumber
        {
            get => streetNumber;
            set
            {
                if(value.Replace(" ", string.Empty) == string.Empty)
                {
                    throw new ArgumentException("Street number can't be empty.");
                }

                if(value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of the given value is out of range. The length has to be less or equal to 10.");
                }

                streetNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets <see cref="zipCode"/> if the length of the given <see cref="string"/> value length is less or equal to 10.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the given <see cref="string"/> value is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the given <see cref="string"/> value length is greater than 10.</exception>
        public virtual string ZipCode
        {
            get => zipCode;
            set
            {
                if(value.Replace(" ", string.Empty) == string.Empty)
                {
                    throw new ArgumentException("Zip code can't be empty.");
                }

                if(value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of the given value is out of range. The length has to be less or equal to 10.");
                }

                zipCode = value;
            }
        }

        /// <summary>
        /// Gets or sets <see cref="city"/> if the length of the given <see cref="string"/> value length is less or equal to 50.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the given <see cref="string"/> value is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the given <see cref="string"/> value length is greater than 50.</exception>
        public virtual string City
        {
            get => city;
            set
            {
                if(value.Replace(" ", string.Empty) == string.Empty)
                {
                    throw new ArgumentException("City can't be empty.");
                }

                if(value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of the given value is out of range. The length has to be less or equal to 50.");
                }

                city = value;
            }
        }

        /// <summary>
        /// Gets or sets <see cref="region"/> if the length of the given <see cref="string"/> value length is less or equal to 50.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the given <see cref="string"/> value length is greater than 50.</exception>
        public virtual string Region
        {
            get => region;
            set
            {
                if(value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of the given value is out of range. The length has to be less or equal to 50.");
                }

                region = value;
            }
        }

        /// <summary>
        /// Gets or sets <see cref="country"/> if the length of the given <see cref="string"/> value length is less or equal to 50.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if the given <see cref="string"/> value is empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the given <see cref="string"/> value length is greater than 50.</exception>
        public virtual string Country
        {
            get => country;
            set
            {
                if(value.Replace(" ", string.Empty) == string.Empty)
                {
                    throw new ArgumentException("Country can't be empty.");
                }

                if(value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("value", "The length of the given value is out of range. The length has to be less or equal to 50.");
                }

                country = value;
            }
        }
        #endregion /[Properties]
    }
}