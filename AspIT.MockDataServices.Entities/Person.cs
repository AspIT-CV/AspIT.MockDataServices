using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspIT.MockDataServices.Entities
{
    public class Person
    {
        #region [Fields]
        /// <summary>
        /// The first name of the person.
        /// </summary>
        protected string firstName;

        /// <summary>
        /// The last name of the person.
        /// </summary>
        protected string lastName;
        #endregion

        #region [Constructors]
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region [Properties]
        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        public string LastName { get => lastName; set => lastName = value; }
        #endregion
    }
}
