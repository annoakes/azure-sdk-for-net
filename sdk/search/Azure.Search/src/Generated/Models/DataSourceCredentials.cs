// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Models
{
    /// <summary> Represents credentials that can be used to connect to a datasource. </summary>
    public partial class DataSourceCredentials
    {
        /// <summary> Initializes a new instance of DataSourceCredentials. </summary>
        public DataSourceCredentials()
        {
        }

        /// <summary> Initializes a new instance of DataSourceCredentials. </summary>
        /// <param name="connectionString"> The connection string for the datasource. </param>
        internal DataSourceCredentials(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary> The connection string for the datasource. </summary>
        public string ConnectionString { get; set; }
    }
}
