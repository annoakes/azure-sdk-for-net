// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Search.Models
{
    /// <summary> Divides text at non-letters; Applies the lowercase and stopword token filters. This analyzer is implemented using Apache Lucene. </summary>
    public partial class StopAnalyzer : Analyzer
    {
        /// <summary> Initializes a new instance of StopAnalyzer. </summary>
        public StopAnalyzer()
        {
            ODataType = "#Microsoft.Azure.Search.StopAnalyzer";
        }

        /// <summary> Initializes a new instance of StopAnalyzer. </summary>
        /// <param name="stopwords"> A list of stopwords. </param>
        /// <param name="oDataType"> The model type. </param>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal StopAnalyzer(IList<string> stopwords, string oDataType, string name) : base(oDataType, name)
        {
            Stopwords = stopwords;
            ODataType = "#Microsoft.Azure.Search.StopAnalyzer";
        }

        /// <summary> A list of stopwords. </summary>
        public IList<string> Stopwords { get; set; }
    }
}
