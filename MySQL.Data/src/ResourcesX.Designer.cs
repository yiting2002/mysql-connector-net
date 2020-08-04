namespace MySql.Data {
    using System;
    
    internal class ResourcesX {
        
        /// <summary>
        ///   Looks up a localized string similar to Appdata path is not defined..
        /// </summary>
        public const string AppdataNotDefined = @"Appdata path is not defined.";
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication failed using MYSQL41 and SHA256_MEMORY. Check the user name and password or try using a secure connection..
        /// </summary>
        public const string AuthenticationFailed = @"Authentication failed using MYSQL41 and SHA256_MEMORY. Check the user name and password or try using a secure connection.";
        
        /// <summary>
        ///   Looks up a localized string similar to You can&apos;t get more sessions because Client is closed..
        /// </summary>
        public const string ClientIsClosed = @"You can't get more sessions because Client is closed.";
        
        /// <summary>
        ///   Looks up a localized string similar to Client option &apos;{0}&apos; does not support value &apos;{1}&apos;..
        /// </summary>
        public const string ClientOptionInvalidValue = @"Client option '{0}' does not support value '{1}'.";
        
        /// <summary>
        ///   Looks up a localized string similar to Client option &apos;{0}&apos; is not recognized as valid..
        /// </summary>
        public const string ClientOptionNotValid = @"Client option '{0}' is not recognized as valid.";
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}&apos; does not exist in schema &apos;{2}&apos;..
        /// </summary>
        public const string CollectionTableDoesNotExist = @"{0} '{1}' does not exist in schema '{2}'.";
        
        /// <summary>
        ///   Looks up a localized string similar to Compression requested but the compression algorithm negotiation failed..
        /// </summary>
        public const string CompressionAlgorithmNegotiationFailed = @"Compression requested but the compression algorithm negotiation failed.";
        
        /// <summary>
        ///   Looks up a localized string similar to Compression using {0} is not supported..
        /// </summary>
        public const string CompressionAlgorithmNotSupported = @"Compression using {0} is not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load libzstd.dll. Removing zstd_stream from the client supported compression algorithms..
        /// </summary>
        public const string CompressionFailedToLoadLibzstdAssembly = @"Failed to load libzstd.dll. Removing zstd_stream from the client supported compression algorithms.";
        
        /// <summary>
        ///   Looks up a localized string similar to Compression using {0} is not supported in .NET Framework..
        /// </summary>
        public const string CompressionForSpecificAlgorithmNotSupportedInNetFramework = @"Compression using {0} is not supported in .NET Framework.";
        
        /// <summary>
        ///   Looks up a localized string similar to The connection property &apos;compression&apos; acceptable values are: &apos;preferred&apos;, &apos;required&apos; or &apos;disabled&apos;. The value &apos;{0}&apos; is not acceptable..
        /// </summary>
        public const string CompressionInvalidValue = @"The connection property 'compression' acceptable values are: 'preferred', 'required' or 'disabled'. The value '{0}' is not acceptable.";
        
        /// <summary>
        ///   Looks up a localized string similar to Compression is not enabled..
        /// </summary>
        public const string CompressionNotEnabled = @"Compression is not enabled.";
        
        /// <summary>
        ///   Looks up a localized string similar to Compression requested but the server does not support it..
        /// </summary>
        public const string CompressionNotSupportedByServer = @"Compression requested but the server does not support it.";
        
        /// <summary>
        ///   Looks up a localized string similar to There are still decompressed messages pending to be processed..
        /// </summary>
        public const string CompressionPendingMessagesToProcess = @"There are still decompressed messages pending to be processed.";
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be set to false with DNS SRV lookup enabled..
        /// </summary>
        public const string DnsSrvConflictingOptions = @"'{0}' cannot be set to false with DNS SRV lookup enabled.";
        
        /// <summary>
        ///   Looks up a localized string similar to Scheme &apos;{0}&apos; is not valid..
        /// </summary>
        public const string DnsSrvInvalidScheme = @"Scheme '{0}' is not valid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate key &apos;{0}&apos; used in "connection-attributes"..
        /// </summary>
        public const string DuplicateUserDefinedAttribute = @"Duplicate key '{0}' used in ""connection-attributes"".";
        
        /// <summary>
        ///   Looks up a localized string similar to Key name in connection attribute cannot be an empty string..
        /// </summary>
        public const string EmptyKeyConnectionAttribute = @"Key name in connection attribute cannot be an empty string.";
        
        /// <summary>
        ///   Looks up a localized string similar to At least one option must be specified..
        /// </summary>
        public const string EmptyOptions = @"At least one option must be specified.";
        
        /// <summary>
        ///   Looks up a localized string similar to This feature is currently not supported..
        /// </summary>
        public const string FeatureNotSupported = @"This feature is currently not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to This functionality is only supported in MySQL {0} and higher..
        /// </summary>
        public const string FunctionalityNotSupported = @"This functionality is only supported in MySQL {0} and higher.";
        
        /// <summary>
        ///   Looks up a localized string similar to Collation with id &apos;{0}&apos; not found..
        /// </summary>
        public const string InvalidCollationId = @"Collation with id '{0}' not found.";
        
        /// <summary>
        ///   Looks up a localized string similar to The value of "connection-attributes" must be either a boolean or a list of key-value pairs..
        /// </summary>
        public const string InvalidConnectionAttributes = @"The value of ""connection-attributes"" must be either a boolean or a list of key-value pairs.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Data is incorrect..
        /// </summary>
        public const string InvalidConnectionData = @"Connection Data is incorrect.";
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string is invalid..
        /// </summary>
        public const string InvalidConnectionString = @"The connection string is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid connection string attribute..
        /// </summary>
        public const string InvalidConnectionStringAttribute = @"'{0}' is not a valid connection string attribute.";
        
        /// <summary>
        ///   Looks up a localized string similar to The connection timeout value must be a positive integer (including 0)..
        /// </summary>
        public const string InvalidConnectionTimeoutValue = @"The connection timeout value must be a positive integer (including 0).";
        
        /// <summary>
        ///   Looks up a localized string similar to Decimal (BCD) format is invalid..
        /// </summary>
        public const string InvalidDecimalFormat = @"Decimal (BCD) format is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Field type with name &apos;{0}&apos; not found..
        /// </summary>
        public const string InvalidFieldType = @"Field type with name '{0}' not found.";
        
        /// <summary>
        ///   Looks up a localized string similar to Index type with name &apos;{0}&apos; not found..
        /// </summary>
        public const string InvalidIndexType = @"Index type with name '{0}' not found.";
        
        /// <summary>
        ///   Looks up a localized string similar to The value provided is not a valid JSON document. {0}.
        /// </summary>
        public const string InvalidJsonDocument = @"The value provided is not a valid JSON document. {0}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid column name in the row..
        /// </summary>
        public const string InvalidNameIndex = @"{0} is not a valid column name in the row.";
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid index for the row..
        /// </summary>
        public const string InvalidRowIndex = @"{0} is not a valid index for the row.";
        
        /// <summary>
        ///   Looks up a localized string similar to Session state is not valid..
        /// </summary>
        public const string InvalidSession = @"Session state is not valid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Uri .
        /// </summary>
        public const string InvalidUriData = @"Invalid Uri ";
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid uri query value.
        /// </summary>
        public const string InvalidUriQuery = @"Invalid uri query value";
        
        /// <summary>
        ///   Looks up a localized string similar to Key names in "connection-attributes" cannot start with "_"..
        /// </summary>
        public const string InvalidUserDefinedAttribute = @"Key names in ""connection-attributes"" cannot start with ""_"".";
        
        /// <summary>
        ///   Looks up a localized string similar to Json configuration must contain &apos;uri&apos; or &apos;host&apos; but not both..
        /// </summary>
        public const string JsonUriOrHost = @"Json configuration must contain 'uri' or 'host' but not both.";
        
        /// <summary>
        ///   Looks up a localized string similar to Keyword &apos;{0}&apos; not found..
        /// </summary>
        public const string KeywordNotFound = @"Keyword '{0}' not found.";
        
        /// <summary>
        ///   Looks up a localized string similar to Keyword not supported..
        /// </summary>
        public const string KeywordNotSupported = @"Keyword not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; is mandatory..
        /// </summary>
        public const string MandatoryFieldNotFound = @"Field '{0}' is mandatory.";
        
        /// <summary>
        ///   Looks up a localized string similar to Missed required schema option..
        /// </summary>
        public const string MissingSchemaOption = @"Missed required schema option.";
        
        /// <summary>
        ///   Looks up a localized string similar to More than one document id was generated.  Please use the DocumentIds property instead..
        /// </summary>
        public const string MoreThanOneDocumentId = @"More than one document id was generated.  Please use the DocumentIds property instead.";
        
        /// <summary>
        ///   Looks up a localized string similar to There is no data at index {0}.
        /// </summary>
        public const string NoDataAtIndex = @"There is no data at index {0}";
        
        /// <summary>
        ///   Looks up a localized string similar to No &apos;host&apos; has been specified..
        /// </summary>
        public const string NoHost = @"No 'host' has been specified.";
        
        /// <summary>
        ///   Looks up a localized string similar to No more data in resultset..
        /// </summary>
        public const string NoMoreData = @"No more data in resultset.";
        
        /// <summary>
        ///   Looks up a localized string similar to Object &apos;{0}&apos; not found.
        /// </summary>
        public const string NoObjectFound = @"Object '{0}' not found";
        
        /// <summary>
        ///   Looks up a localized string similar to No placeholders..
        /// </summary>
        public const string NoPlaceholders = @"No placeholders.";
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be a value greater than 0..
        /// </summary>
        public const string NumberNotGreaterThanZero = @"{0} must be a value greater than 0.";
        
        /// <summary>
        ///   Looks up a localized string similar to Path not found &apos;{0}&apos;..
        /// </summary>
        public const string PathNotFound = @"Path not found '{0}'.";
        
        /// <summary>
        ///   Looks up a localized string similar to Queue timeout expired. The timeout period elapsed prior to getting a session from the pool..
        /// </summary>
        public const string PoolingQueueTimeout = @"Queue timeout expired. The timeout period elapsed prior to getting a session from the pool.";
        
        /// <summary>
        ///   Looks up a localized string similar to Providing a port number as part of the host address isn&apos;t supported when using connection strings in basic format or anonymous objects. Use URI format instead..
        /// </summary>
        public const string PortNotSupported = @"Providing a port number as part of the host address isn't supported when using connection strings in basic format or anonymous objects. Use URI format instead.";
        
        /// <summary>
        ///   Looks up a localized string similar to You must either assign no priority to any of the hosts or give a priority for every host..
        /// </summary>
        public const string PriorityForAllOrNoHosts = @"You must either assign no priority to any of the hosts or give a priority for every host.";
        
        /// <summary>
        ///   Looks up a localized string similar to The priority must be between 0 and 100..
        /// </summary>
        public const string PriorityOutOfLimits = @"The priority must be between 0 and 100.";
        
        /// <summary>
        ///   Looks up a localized string similar to ProgramData path is not defined..
        /// </summary>
        public const string ProgramDataNotDefined = @"ProgramData path is not defined.";
        
        /// <summary>
        ///   Looks up a localized string similar to The server doesn&apos;t support the requested operation. Please update the MySQL Server, client library, or both..
        /// </summary>
        public const string SchemaCreateCollectionMsg = @"The server doesn't support the requested operation. Please update the MySQL Server, client library, or both.";
        
        /// <summary>
        ///   Looks up a localized string similar to The process of closing the resultset and resulted in results being lost..
        /// </summary>
        public const string ThrowingAwayResults = @"The process of closing the resultset and resulted in results being lost.";
        
        /// <summary>
        ///   Looks up a localized string similar to All server connection attempts were aborted. Timeout of {0} milliseconds was exceeded for each selected server..
        /// </summary>
        public const string TimeOutMultipleHost = @"All server connection attempts were aborted. Timeout of {0} milliseconds was exceeded for each selected server.";
        
        /// <summary>
        ///   Looks up a localized string similar to All server connection attempts were aborted. Timeout was exceeded for each selected server..
        /// </summary>
        public const string TimeOutMultipleHost0ms = @"All server connection attempts were aborted. Timeout was exceeded for each selected server.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connection attempt to the server was aborted. Timeout of {0} milliseconds was exceeded..
        /// </summary>
        public const string TimeOutSingleHost = @"Connection attempt to the server was aborted. Timeout of {0} milliseconds was exceeded.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connection attempt to the server was aborted. Timeout was exceeded..
        /// </summary>
        public const string TimeOutSingleHost0ms = @"Connection attempt to the server was aborted. Timeout was exceeded.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to any specified host..
        /// </summary>
        public const string UnableToConnect = @"Unable to connect to any specified host.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read or decode data value..
        /// </summary>
        public const string UnableToDecodeDataValue = @"Unable to read or decode data value.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open a session..
        /// </summary>
        public const string UnableToOpenSession = @"Unable to open a session.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end of packet found while reading data values.
        /// </summary>
        public const string UnexpectedEndOfPacketFound = @"Unexpected end of packet found while reading data values";
        
        /// <summary>
        ///   Looks up a localized string similar to Field name &apos;{0}&apos; is not allowed..
        /// </summary>
        public const string UnexpectedField = @"Field name '{0}' is not allowed.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown placeholder :{0}.
        /// </summary>
        public const string UnknownPlaceholder = @"Unknown placeholder :{0}";
        
        /// <summary>
        ///   Looks up a localized string similar to Value &apos;{0}&apos; is not of the correct type..
        /// </summary>
        public const string ValueNotCorrectType = @"Value '{0}' is not of the correct type.";
    }
}
