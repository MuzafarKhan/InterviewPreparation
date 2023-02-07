using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities.Result
{
    public enum ServiceErrorCode : int
    {
        /// <summary>
        /// The no error
        /// </summary>
        NoError = 0,
        /// <summary>
        /// The validation failed
        /// </summary>
        ValidationFailed = 10400,
        /// <summary>
        /// The unauthorized
        /// </summary>
        Unauthorized = 10401,
        /// <summary>
        /// The forbidden
        /// </summary>
        Forbidden = 10403,
        /// <summary>
        /// The general error
        /// </summary>
        GeneralError = 10500,
        /// <summary>
        /// The not implemented
        /// </summary>
        NotImplemented = 10501,
        /// <summary>
        /// The not implemented
        /// </summary>
        IsNewBankAccount = 10502,
        /// <summary>
        /// The not implemented
        /// </summary>
        IsDifferentBankAccount = 10503
    }
}
