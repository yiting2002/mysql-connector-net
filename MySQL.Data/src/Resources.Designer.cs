namespace MySql.Data {
    using System;
    
    internal class Resources {
        
        /// <summary>
        ///   Looks up a localized string similar to Improper MySqlCommandBuilder state: adapter is null.
        /// </summary>
        public const string AdapterIsNull = @"Improper MySqlCommandBuilder state: adapter is null";
        
        /// <summary>
        ///   Looks up a localized string similar to Improper MySqlCommandBuilder state: adapter&apos;s SelectCommand is null.
        /// </summary>
        public const string AdapterSelectIsNull = @"Improper MySqlCommandBuilder state: adapter's SelectCommand is null";
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to access a field before calling Read().
        /// </summary>
        public const string AttemptToAccessBeforeRead = @"Invalid attempt to access a field before calling Read()";
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication to host &apos;{0}&apos; for user &apos;{1}&apos; using method &apos;{2}&apos; failed with message: {3}.
        /// </summary>
        public const string AuthenticationFailed = @"Authentication to host '{0}' for user '{1}' using method '{2}' failed with message: {3}";
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication method &apos;{0}&apos; not supported by any of the available plugins..
        /// </summary>
        public const string AuthenticationMethodNotSupported = @"Authentication method '{0}' not supported by any of the available plugins.";
        
        /// <summary>
        ///   Looks up a localized string similar to Version string not in acceptable format.
        /// </summary>
        public const string BadVersionFormat = @"Version string not in acceptable format";
        
        /// <summary>
        ///   Looks up a localized string similar to  The buffer cannot be null.
        /// </summary>
        public const string BufferCannotBeNull = @" The buffer cannot be null";
        
        /// <summary>
        ///   Looks up a localized string similar to  Buffer is not large enough.
        /// </summary>
        public const string BufferNotLargeEnough = @" Buffer is not large enough";
        
        /// <summary>
        ///   Looks up a localized string similar to Canceling an executing query requires MySQL 5.0 or higher..
        /// </summary>
        public const string CancelNeeds50 = @"Canceling an executing query requires MySQL 5.0 or higher.";
        
        /// <summary>
        ///   Looks up a localized string similar to Canceling an active query is only supported on MySQL 5.0.0 and above. .
        /// </summary>
        public const string CancelNotSupported = @"Canceling an active query is only supported on MySQL 5.0.0 and above. ";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameters can only be derived for commands using the StoredProcedure command type..
        /// </summary>
        public const string CanNotDeriveParametersForTextCommands = @"Parameters can only be derived for commands using the StoredProcedure command type.";
        
        /// <summary>
        ///   Looks up a localized string similar to MySqlCommandBuilder does not support multi-table statements.
        /// </summary>
        public const string CBMultiTableNotSupported = @"MySqlCommandBuilder does not support multi-table statements";
        
        /// <summary>
        ///   Looks up a localized string similar to MySqlCommandBuilder cannot operate on tables with no unique or key columns.
        /// </summary>
        public const string CBNoKeyColumn = @"MySqlCommandBuilder cannot operate on tables with no unique or key columns";
        
        /// <summary>
        ///   Looks up a localized string similar to Chaos isolation level is not supported .
        /// </summary>
        public const string ChaosNotSupported = @"Chaos isolation level is not supported ";
        
        /// <summary>
        ///   Looks up a localized string similar to The CommandText property has not been properly initialized..
        /// </summary>
        public const string CommandTextNotInitialized = @"The CommandText property has not been properly initialized.";
        
        /// <summary>
        ///   Looks up a localized string similar to Compression is not supported..
        /// </summary>
        public const string CompressionNotSupported = @"Compression is not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to The connection is already open..
        /// </summary>
        public const string ConnectionAlreadyOpen = @"The connection is already open.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connection unexpectedly terminated..
        /// </summary>
        public const string ConnectionBroken = @"Connection unexpectedly terminated.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connection must be valid and open.
        /// </summary>
        public const string ConnectionMustBeOpen = @"Connection must be valid and open";
        
        /// <summary>
        ///   Looks up a localized string similar to The connection is not open..
        /// </summary>
        public const string ConnectionNotOpen = @"The connection is not open.";
        
        /// <summary>
        ///   Looks up a localized string similar to The connection property has not been set or is null..
        /// </summary>
        public const string ConnectionNotSet = @"The connection property has not been set or is null.";
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find specified column in results: {0}.
        /// </summary>
        public const string CouldNotFindColumnName = @"Could not find specified column in results: {0}";
        
        /// <summary>
        ///   Looks up a localized string similar to  Count cannot be negative.
        /// </summary>
        public const string CountCannotBeNegative = @" Count cannot be negative";
        
        /// <summary>
        ///   Looks up a localized string similar to SetLength is not a valid operation on CompressedStream.
        /// </summary>
        public const string CSNoSetLength = @"SetLength is not a valid operation on CompressedStream";
        
        /// <summary>
        ///   Looks up a localized string similar to The given value was not in a supported format..
        /// </summary>
        public const string DataNotInSupportedFormat = @"The given value was not in a supported format.";
        
        /// <summary>
        ///   Looks up a localized string similar to There is already an open DataReader associated with this Connection which must be closed first..
        /// </summary>
        public const string DataReaderOpen = @"There is already an open DataReader associated with this Connection which must be closed first.";
        
        /// <summary>
        ///   Looks up a localized string similar to The default connection encoding was not found. Please report this as a bug along with your connection string and system details..
        /// </summary>
        public const string DefaultEncodingNotFound = @"The default connection encoding was not found. Please report this as a bug along with your connection string and system details.";
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} algorithm being used by the server({1}) has been deprecated and will be removed in a future version. It is recommended that you configure the server to use a non-deprecated {0} algorithm..
        /// </summary>
        public const string DeprecatedSshAlgorithm = @"The {0} algorithm being used by the server({1}) has been deprecated and will be removed in a future version. It is recommended that you configure the server to use a non-deprecated {0} algorithm.";
        
        /// <summary>
        ///   Looks up a localized string similar to MySQL Connector/NET does not currently support distributed transactions..
        /// </summary>
        public const string DistributedTxnNotSupported = @"MySQL Connector/NET does not currently support distributed transactions.";
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying multiple host names with DNS SRV lookup is not permitted..
        /// </summary>
        public const string DnsSrvInvalidConnOptionMultihost = @"Specifying multiple host names with DNS SRV lookup is not permitted.";
        
        /// <summary>
        ///   Looks up a localized string similar to Specifying a port number with DNS SRV lookup is not permitted..
        /// </summary>
        public const string DnsSrvInvalidConnOptionPort = @"Specifying a port number with DNS SRV lookup is not permitted.";
        
        /// <summary>
        ///   Looks up a localized string similar to Using Unix domain sockets with DNS SRV lookup is not permitted..
        /// </summary>
        public const string DnsSrvInvalidConnOptionUnixSocket = @"Using Unix domain sockets with DNS SRV lookup is not permitted.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate any hosts for {0}..
        /// </summary>
        public const string DnsSrvNoHostsAvailable = @"Unable to locate any hosts for {0}.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connection option &apos;{0}&apos; is duplicated..
        /// </summary>
        public const string DuplicatedConnectionOption = @"Connection option '{0}' is duplicated.";
        
        /// <summary>
        ///   Looks up a localized string similar to SSL connection option &apos;{0}&apos; is duplicated..
        /// </summary>
        public const string DuplicatedSslConnectionOption = @"SSL connection option '{0}' is duplicated.";
        
        /// <summary>
        ///   Looks up a localized string similar to Encoding error during validation..
        /// </summary>
        public const string EncodingError = @"Encoding error during validation.";
        
        /// <summary>
        ///   Looks up a localized string similar to Error creating socket connection.
        /// </summary>
        public const string ErrorCreatingSocket = @"Error creating socket connection";
        
        /// <summary>
        ///   Looks up a localized string similar to Verify that user &apos;{0}&apos;@&apos;{1}&apos; has enough privileges to execute..
        /// </summary>
        public const string ExecuteProcedureUnauthorized = @"Verify that user '{0}'@'{1}' has enough privileges to execute.";
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal error encountered during command execution..
        /// </summary>
        public const string FatalErrorDuringExecute = @"Fatal error encountered during command execution.";
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal error encountered during data read..
        /// </summary>
        public const string FatalErrorDuringRead = @"Fatal error encountered during data read.";
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal error encountered attempting to read the resultset..
        /// </summary>
        public const string FatalErrorReadingResult = @"Fatal error encountered attempting to read the resultset.";
        
        /// <summary>
        ///   Looks up a localized string similar to File based certificates are only supported when connecting to MySQL Server 5.1 or greater..
        /// </summary>
        public const string FileBasedCertificateNotSupported = @"File based certificates are only supported when connecting to MySQL Server 5.1 or greater.";
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file cannot be converted to a certificate..
        /// </summary>
        public const string FileIsNotACertificate = @"The specified file cannot be converted to a certificate.";
        
        /// <summary>
        ///   Looks up a localized string similar to The specified file cannot be converted to a key..
        /// </summary>
        public const string FileIsNotAKey = @"The specified file cannot be converted to a key.";
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to read file at the specified location..
        /// </summary>
        public const string FileNotFound = @"Failed to read file at the specified location.";
        
        /// <summary>
        ///   Looks up a localized string similar to No file path has been provided for the connection option {0}..
        /// </summary>
        public const string FilePathNotSet = @"No file path has been provided for the connection option {0}.";
        
        /// <summary>
        ///   Looks up a localized string similar to From index and length use more bytes than from contains.
        /// </summary>
        public const string FromAndLengthTooBig = @"From index and length use more bytes than from contains";
        
        /// <summary>
        ///   Looks up a localized string similar to From index must be a valid index inside the from buffer.
        /// </summary>
        public const string FromIndexMustBeValid = @"From index must be a valid index inside the from buffer";
        
        /// <summary>
        ///   Looks up a localized string similar to Call to GetHostEntry failed after {0} while querying for hostname &apos;{1}&apos;: SocketErrorCode={2}, ErrorCode={3}, NativeErrorCode={4}..
        /// </summary>
        public const string GetHostEntryFailed = @"Call to GetHostEntry failed after {0} while querying for hostname '{1}': SocketErrorCode={2}, ErrorCode={3}, NativeErrorCode={4}.";
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving procedure metadata for {0} from server..
        /// </summary>
        public const string HardProcQuery = @"Retrieving procedure metadata for {0} from server.";
        
        /// <summary>
        ///   Looks up a localized string similar to Value has an unsupported format..
        /// </summary>
        public const string ImproperValueFormat = @"Value has an unsupported format.";
        
        /// <summary>
        ///   Looks up a localized string similar to An incorrect response was received from the server..
        /// </summary>
        public const string IncorrectTransmission = @"An incorrect response was received from the server.";
        
        /// <summary>
        ///   Looks up a localized string similar to Index and length use more bytes than to has room for.
        /// </summary>
        public const string IndexAndLengthTooBig = @"Index and length use more bytes than to has room for";
        
        /// <summary>
        ///   Looks up a localized string similar to Index must be a valid position in the buffer.
        /// </summary>
        public const string IndexMustBeValid = @"Index must be a valid position in the buffer";
        
        /// <summary>
        ///   Looks up a localized string similar to The provided key is invalid..
        /// </summary>
        public const string InvalidCertificateKey = @"The provided key is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to You have specified an invalid column ordinal..
        /// </summary>
        public const string InvalidColumnOrdinal = @"You have specified an invalid column ordinal.";
        
        /// <summary>
        ///   Looks up a localized string similar to The requested value &apos;{0}&apos; is invalid for the given keyword &apos;{1}&apos;..
        /// </summary>
        public const string InvalidConnectionStringValue = @"The requested value '{0}' is invalid for the given keyword '{1}'.";
        
        /// <summary>
        ///   Looks up a localized string similar to The host name or IP address is invalid..
        /// </summary>
        public const string InvalidHostNameOrAddress = @"The host name or IP address is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Microsecond must be a value between 0 and 999999..
        /// </summary>
        public const string InvalidMicrosecondValue = @"Microsecond must be a value between 0 and 999999.";
        
        /// <summary>
        ///   Looks up a localized string similar to Millisecond must be a value between 0 and 999. For more precision use Microsecond..
        /// </summary>
        public const string InvalidMillisecondValue = @"Millisecond must be a value between 0 and 999. For more precision use Microsecond.";
        
        /// <summary>
        ///   Looks up a localized string similar to No other SSL options are accepted when SSL Mode is set to None..
        /// </summary>
        public const string InvalidOptionWhenSslDisabled = @"No other SSL options are accepted when SSL Mode is set to None.";
        
        /// <summary>
        ///   Looks up a localized string similar to Procedure or function &apos;{0}&apos; cannot be found in database &apos;{1}&apos;..
        /// </summary>
        public const string InvalidProcName = @"Procedure or function '{0}' cannot be found in database '{1}'.";
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate is invalid..
        /// </summary>
        public const string InvalidSslCertificate = @"The certificate is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to validate the signature..
        /// </summary>
        public const string InvalidSslCertificateSignature = @"Unable to validate the signature.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to verify the signature..
        /// </summary>
        public const string InvalidSslCertificateSignatureGeneral = @"Unable to verify the signature.";
        
        /// <summary>
        ///   Looks up a localized string similar to Value &apos;{0}&apos; is not of the correct type..
        /// </summary>
        public const string InvalidSslMode = @"Value '{0}' is not of the correct type.";
        
        /// <summary>
        ///   Looks up a localized string similar to Option "tls-version" can not be specified when SSL connections are disabled..
        /// </summary>
        public const string InvalidTlsVersionAndSslModeOption = @"Option ""tls-version"" can not be specified when SSL connections are disabled.";
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; not recognized as a valid TLS protocol version (should be one of TLSv1, TLSv1.1, TLSv1.2{1})..
        /// </summary>
        public const string InvalidTlsVersionOption = @"'{0}' not recognized as a valid TLS protocol version (should be one of TLSv1, TLSv1.1, TLSv1.2{1}).";
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is an illegal value for a boolean option..
        /// </summary>
        public const string InvalidValueForBoolean = @"'{0}' is an illegal value for a boolean option.";
        
        /// <summary>
        ///   Looks up a localized string similar to Keyword does not allow null values..
        /// </summary>
        public const string KeywordNoNull = @"Keyword does not allow null values.";
        
        /// <summary>
        ///   Looks up a localized string similar to Option not supported..
        /// </summary>
        public const string KeywordNotSupported = @"Option not supported.";
        
        /// <summary>
        ///   Looks up a localized string from &apos;keywords.txt&apos;.
        /// </summary>
        public const string keywords = @"ACCESSIBLE
ADD
ALL
ALTER
ANALYZE
AND
AS
ASC
ASENSITIVE
BEFORE
BEGIN
BETWEEN
BIGINT
BINARY
BLOB
BOTH
BY
CALL
CASCADE
CASE
CHANGE
CHAR
CHARACTER
CHECK
COLLATE
COLUMN
COMMIT
CONDITION
CONNECTION
CONSTRAINT
CONTINUE
CONVERT
CREATE
CROSS
CURRENT_DATE
CURRENT_TIME
CURRENT_TIMESTAMP
CURRENT_USER
CURSOR
DATABASE
DATABASES
DAY_HOUR
DAY_MICROSECOND
DAY_MINUTE
DAY_SECOND
DEC
DECIMAL
DECLARE
DEFAULT
DELAYED
DELETE
DESC
DESCRIBE
DETERMINISTIC
DISTINCT
DISTINCTROW
DIV
DO
DOUBLE
DROP
DUAL
EACH
ELSE
ELSEIF
ENCLOSED
END
ESCAPED
EXISTS
EXIT
EXPLAIN
FALSE
FETCH
FLOAT
FLOAT4
FLOAT8
FOR
FORCE
FOREIGN
FROM
FULLTEXT
GOTO
GRANT
GROUP
HAVING
HIGH_PRIORITY
HOUR_MICROSECOND
HOUR_MINUTE
HOUR_SECOND
IF
IGNORE
IN
INDEX
INFILE
INNER
INOUT
INSENSITIVE
INSERT
INT
INT1
INT2
INT3
INT4
INT8
INTEGER
INTERVAL
INTO
IS
ITERATE
JOIN
KEY
KEYS
KILL
LABEL
LEADING
LEAVE
LEFT
LIKE
LIMIT
LINEAR
LINES
LOAD
LOCALTIME
LOCALTIMESTAMP
LOCK
LONG
LONGBLOB
LONGTEXT
LOOP
LOW_PRIORITY
MASTER_SSL_VERIFY_SERVER_CERT
MATCH
MEDIUMBLOB
MEDIUMINT
MEDIUMTEXT
MIDDLEINT
MINUTE_MICROSECOND
MINUTE_SECOND
MOD
MODIFIES
NATURAL
NOT
NO_WRITE_TO_BINLOG
NULL
NUMERIC
ON
OPTIMIZE
OPTION
OPTIONALLY
OR
ORDER
OUT
OUTER
OUTFILE
PRECISION
PRIMARY
PROCEDURE
PURGE
RANGE
READ
READS
READ_ONLY
READ_WRITE
REAL
REFERENCES
REGEXP
RELEASE
RENAME
REPEAT
REPLACE
REQUIRE
RESTRICT
RETURN
REVOKE
RIGHT
RLIKE
ROLLBACK
SCHEMA
SCHEMAS
SECOND_MICROSECOND
SELECT
SENSITIVE
SEPARATOR
SET
SHOW
SHUTDOWN
SMALLINT
SPATIAL
SPECIFIC
SQL
SQLEXCEPTION
SQLSTATE
SQLWARNING
SQL_BIG_RESULT
SQL_CALC_FOUND_ROWS
SQL_SMALL_RESULT
SSL
STARTING
STRAIGHT_JOIN
TABLE
TERMINATED
THEN
TINYBLOB
TINYINT
TINYTEXT
TO
TRAILING
TRIGGER
TRUE
UNDO
UNION
UNIQUE
UNLOCK
UNSIGNED
UPDATE
UPGRADE
USAGE
USE
USING
UTC_DATE
UTC_TIME
UTC_TIMESTAMP
VALUE
VALUES
VARBINARY
VARCHAR
VARCHARACTER
VARYING
WHEN
WHERE
WHILE
WITH
WRITE
XOR
YEAR_MONTH
ZEROFILL";
        
        /// <summary>
        ///   Looks up a localized string similar to Server asked for stream in response to LOAD DATA LOCAL INFILE, but the functionality is disabled by the client setting &apos;allowlocalinfile&apos; to &apos;false&apos;..
        /// </summary>
        public const string LocalInfileDisabled = @"Server asked for stream in response to LOAD DATA LOCAL INFILE, but the functionality is disabled by the client setting 'allowlocalinfile' to 'false'.";
        
        /// <summary>
        ///   Looks up a localized string similar to Mixing named and unnamed parameters is not allowed..
        /// </summary>
        public const string MixedParameterNamingNotAllowed = @"Mixing named and unnamed parameters is not allowed.";
        
        /// <summary>
        ///   Looks up a localized string similar to INTERNAL ERROR:  More than one output parameter row detected..
        /// </summary>
        public const string MoreThanOneOPRow = @"INTERNAL ERROR:  More than one output parameter row detected.";
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple simultaneous connections or connections with different connection strings inside the same transaction are not currently supported..
        /// </summary>
        public const string MultipleConnectionsInTransactionNotSupported = @"Multiple simultaneous connections or connections with different connection strings inside the same transaction are not currently supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to NamedPipeStream does not support seeking.
        /// </summary>
        public const string NamedPipeNoSeek = @"NamedPipeStream does not support seeking";
        
        /// <summary>
        ///   Looks up a localized string similar to NamedPipeStream doesn&apos;t support SetLength.
        /// </summary>
        public const string NamedPipeNoSetLength = @"NamedPipeStream doesn't support SetLength";
        
        /// <summary>
        ///   Looks up a localized string similar to The new value must be a MySqlParameter object..
        /// </summary>
        public const string NewValueShouldBeMySqlParameter = @"The new value must be a MySqlParameter object.";
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to call NextResult when the reader is closed..
        /// </summary>
        public const string NextResultIsClosed = @"Invalid attempt to call NextResult when the reader is closed.";
        
        /// <summary>
        ///   Looks up a localized string similar to When calling stored procedures and &apos;Use Procedure Bodies&apos; is false, all parameters must have their type explicitly set..
        /// </summary>
        public const string NoBodiesAndTypeNotSet = @"When calling stored procedures and 'Use Procedure Bodies' is false, all parameters must have their type explicitly set.";
        
        /// <summary>
        ///   Looks up a localized string similar to Nested transactions are not supported..
        /// </summary>
        public const string NoNestedTransactions = @"Nested transactions are not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to The host {0} does not support SSL connections..
        /// </summary>
        public const string NoServerSSLSupport = @"The host {0} does not support SSL connections.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unix sockets are not supported on Windows..
        /// </summary>
        public const string NoUnixSocketsOnWindows = @"Unix sockets are not supported on Windows.";
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot retrieve Windows identity for current user. Connections that use  IntegratedSecurity cannot be  pooled. Use either &apos;ConnectionReset=true&apos; or  &apos;Pooling=false&apos; in the connection string to fix..
        /// </summary>
        public const string NoWindowsIdentity = @"Cannot retrieve Windows identity for current user. Connections that use  IntegratedSecurity cannot be  pooled. Use either 'ConnectionReset=true' or  'Pooling=false' in the connection string to fix.";
        
        /// <summary>
        ///   Looks up a localized string similar to The object is not open or has been disposed..
        /// </summary>
        public const string ObjectDisposed = @"The object is not open or has been disposed.";
        
        /// <summary>
        ///   Looks up a localized string similar to  Offset cannot be negative.
        /// </summary>
        public const string OffsetCannotBeNegative = @" Offset cannot be negative";
        
        /// <summary>
        ///   Looks up a localized string similar to Offset must be a valid position in buffer.
        /// </summary>
        public const string OffsetMustBeValid = @"Offset must be a valid position in buffer";
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication with old password no longer supported, use 4.1 style passwords..
        /// </summary>
        public const string OldPasswordsNotSupported = @"Authentication with old password no longer supported, use 4.1 style passwords.";
        
        /// <summary>
        ///   Looks up a localized string similar to The option &apos;{0}&apos; is not currently supported..
        /// </summary>
        public const string OptionNotCurrentlySupported = @"The option '{0}' is not currently supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; has already been defined..
        /// </summary>
        public const string ParameterAlreadyDefined = @"Parameter '{0}' has already been defined.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter cannot have a negative value.
        /// </summary>
        public const string ParameterCannotBeNegative = @"Parameter cannot have a negative value";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter cannot be null.
        /// </summary>
        public const string ParameterCannotBeNull = @"Parameter cannot be null";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; can&apos;t be null or empty..
        /// </summary>
        public const string ParameterCannotBeNullOrEmpty = @"Parameter '{0}' can't be null or empty.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter index was not found in Parameter Collection..
        /// </summary>
        public const string ParameterIndexNotFound = @"Parameter index was not found in Parameter Collection.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter is invalid..
        /// </summary>
        public const string ParameterIsInvalid = @"Parameter is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; must be defined..
        /// </summary>
        public const string ParameterMustBeDefined = @"Parameter '{0}' must be defined.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; was not found during prepare..
        /// </summary>
        public const string ParameterNotFoundDuringPrepare = @"Parameter '{0}' was not found during prepare.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter can&apos;t be null or empty..
        /// </summary>
        public const string ParameterNullOrEmpty = @"Parameter can't be null or empty.";
        
        /// <summary>
        ///   Looks up a localized string similar to Password must be valid and contain length characters.
        /// </summary>
        public const string PasswordMustHaveLegalChars = @"Password must be valid and contain length characters";
        
        /// <summary>
        ///   Looks up a localized string similar to This category includes a series of counters for MySQL.
        /// </summary>
        public const string PerfMonCategoryHelp = @"This category includes a series of counters for MySQL";
        
        /// <summary>
        ///   Looks up a localized string similar to .NET Data Provider for MySQL.
        /// </summary>
        public const string PerfMonCategoryName = @".NET Data Provider for MySQL";
        
        /// <summary>
        ///   Looks up a localized string similar to The number of times a procedures metadata had to be queried from the server..
        /// </summary>
        public const string PerfMonHardProcHelp = @"The number of times a procedures metadata had to be queried from the server.";
        
        /// <summary>
        ///   Looks up a localized string similar to Hard Procedure Queries.
        /// </summary>
        public const string PerfMonHardProcName = @"Hard Procedure Queries";
        
        /// <summary>
        ///   Looks up a localized string similar to The number of times a procedures metadata was retrieved from the client-side cache..
        /// </summary>
        public const string PerfMonSoftProcHelp = @"The number of times a procedures metadata was retrieved from the client-side cache.";
        
        /// <summary>
        ///   Looks up a localized string similar to Soft Procedure Queries.
        /// </summary>
        public const string PerfMonSoftProcName = @"Soft Procedure Queries";
        
        /// <summary>
        ///   Looks up a localized string similar to same name are not supported..
        /// </summary>
        public const string ProcAndFuncSameName = @"same name are not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to Packets larger than max_allowed_packet are not allowed..
        /// </summary>
        public const string QueryTooLarge = @"Packets larger than max_allowed_packet are not allowed.";
        
        /// <summary>
        ///   Looks up a localized string similar to Reading from the stream has failed..
        /// </summary>
        public const string ReadFromStreamFailed = @"Reading from the stream has failed.";
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid attempt to read a prior column using SequentialAccess.
        /// </summary>
        public const string ReadingPriorColumnUsingSeqAccess = @"Invalid attempt to read a prior column using SequentialAccess";
        
        /// <summary>
        ///   Looks up a localized string similar to Replicated connections allow only readonly statements..
        /// </summary>
        public const string ReplicatedConnectionsAllowOnlyReadonlyStatements = @"Replicated connections allow only readonly statements.";
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to connect to &apos;{0}&apos; server failed..
        /// </summary>
        public const string Replication_ConnectionAttemptFailed = @"Attempt to connect to '{0}' server failed.";
        
        /// <summary>
        ///   Looks up a localized string similar to No available server found..
        /// </summary>
        public const string Replication_NoAvailableServer = @"No available server found.";
        
        /// <summary>
        ///   Looks up a localized string similar to Replication group &apos;{0}&apos; not found..
        /// </summary>
        public const string ReplicationGroupNotFound = @"Replication group '{0}' not found.";
        
        /// <summary>
        ///   Looks up a localized string similar to Replicated server not found: &apos;{0}&apos;.
        /// </summary>
        public const string ReplicationServerNotFound = @"Replicated server not found: '{0}'";
        
        /// <summary>
        ///   Looks up a localized string from &apos;Properties\ReservedWords.txt&apos;.
        /// </summary>
        public const string ReservedWords = @"ACCESSIBLE ADD ALL 
ALTER ANALYZE AND 
AS ASC ASENSITIVE 
BEFORE BETWEEN BIGINT 
BINARY BLOB BOTH 
BY CALL CASCADE 
CASE CHANGE CHAR 
CHARACTER CHECK COLLATE 
COLUMN CONDITION CONNECTION 
CONSTRAINT CONTINUE CONTRIBUTORS 
CONVERT CREATE CROSS 
CURRENT_DATE CURRENT_TIME CURRENT_TIMESTAMP 
CURRENT_USER CURSOR DATABASE 
DATABASES DAY_HOUR DAY_MICROSECOND 
DAY_MINUTE DAY_SECOND DEC 
DECIMAL DECLARE DEFAULT 
DELAYED DELETE DESC 
DESCRIBE DETERMINISTIC DISTINCT 
DISTINCTROW DIV DOUBLE 
DROP DUAL EACH 
ELSE ELSEIF ENCLOSED 
ESCAPED EXISTS EXIT 
EXPLAIN FALSE FETCH 
FLOAT FLOAT4 FLOAT8 
FOR FORCE FOREIGN 
FROM FULLTEXT GRANT 
GROUP HAVING HIGH_PRIORITY 
HOUR_MICROSECOND HOUR_MINUTE HOUR_SECOND 
IF IGNORE IN 
INDEX INFILE INNER 
INOUT INSENSITIVE INSERT 
INT INT1 INT2 
INT3 INT4 INT8 
INTEGER INTERVAL INTO 
IS ITERATE JOIN 
KEY KEYS KILL 
LEADING LEAVE LEFT 
LIKE LIMIT LINEAR 
LINES LOAD LOCALTIME 
LOCALTIMESTAMP LOCK LONG 
LONGBLOB LONGTEXT LOOP 
LOW_PRIORITY MATCH MEDIUMBLOB 
MEDIUMINT MEDIUMTEXT MIDDLEINT 
MINUTE_MICROSECOND MINUTE_SECOND MOD 
MODIFIES NATURAL NOT 
NO_WRITE_TO_BINLOG NULL NUMERIC 
ON OPTIMIZE OPTION 
OPTIONALLY OR ORDER 
OUT OUTER OUTFILE 
PRECISION PRIMARY PROCEDURE 
PURGE RANGE READ 
READS READ_ONLY READ_WRITE 
REAL REFERENCES REGEXP 
RELEASE RENAME REPEAT 
REPLACE REQUIRE RESTRICT 
RETURN REVOKE RIGHT 
RLIKE SCHEMA SCHEMAS 
SECOND_MICROSECOND SELECT SENSITIVE 
SEPARATOR SET SHOW SHUTDOWN
SMALLINT SPATIAL SPECIFIC 
SQL SQLEXCEPTION SQLSTATE 
SQLWARNING SQL_BIG_RESULT SQL_CALC_FOUND_ROWS 
SQL_SMALL_RESULT SSL STARTING 
STRAIGHT_JOIN TABLE TERMINATED 
THEN TINYBLOB TINYINT 
TINYTEXT TO TRAILING 
TRIGGER TRUE UNDO 
UNION UNIQUE UNLOCK 
UNSIGNED UPDATE UPGRADE 
USAGE USE USING 
UTC_DATE UTC_TIME UTC_TIMESTAMP 
VALUES VARBINARY VARCHAR 
VARCHARACTER VARYING WHEN 
WHERE WHILE WITH 
WRITE X509 XOR 
YEAR_MONTH ZEROFILL   ";
        
        /// <summary>
        ///   Looks up a localized string similar to Routine &apos;{0}&apos; cannot be found. Either check the spelling or make sure you have sufficient rights to execute the routine..
        /// </summary>
        public const string RoutineNotFound = @"Routine '{0}' cannot be found. Either check the spelling or make sure you have sufficient rights to execute the routine.";
        
        /// <summary>
        ///   Looks up a localized string similar to Attempt to call stored function &apos;{0}&apos; without specifying a return parameter.
        /// </summary>
        public const string RoutineRequiresReturnParameter = @"Attempt to call stored function '{0}' without specifying a return parameter";
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieval of the RSA public key is not enabled for insecure connections..
        /// </summary>
        public const string RSAPublicKeyRetrievalNotEnabled = @"Retrieval of the RSA public key is not enabled for insecure connections.";
        
        /// <summary>
        ///   Looks up a localized string similar to Connector/NET no longer supports server versions prior to 5.0.
        /// </summary>
        public const string ServerTooOld = @"Connector/NET no longer supports server versions prior to 5.0";
        
        /// <summary>
        ///   Looks up a localized string similar to Snapshot isolation level is not supported..
        /// </summary>
        public const string SnapshotNotSupported = @"Snapshot isolation level is not supported.";
        
        /// <summary>
        ///   Looks up a localized string similar to Socket streams do not support seeking.
        /// </summary>
        public const string SocketNoSeek = @"Socket streams do not support seeking";
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving procedure metadata for {0} from procedure cache..
        /// </summary>
        public const string SoftProcQuery = @"Retrieving procedure metadata for {0} from procedure cache.";
        
        /// <summary>
        ///   Looks up a localized string similar to Stored procedures are not supported on this version of MySQL.
        /// </summary>
        public const string SPNotSupported = @"Stored procedures are not supported on this version of MySQL";
        
        /// <summary>
        ///   Looks up a localized string similar to The SSH Key File and/or SSH Password must be provided..
        /// </summary>
        public const string SshAuthenticationModeNotSet = @"The SSH Key File and/or SSH Password must be provided.";
        
        /// <summary>
        ///   Looks up a localized string similar to The provided passphrase is invalid..
        /// </summary>
        public const string SshInvalidPassphrase = @"The provided passphrase is invalid.";
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate authority (CA) does not match..
        /// </summary>
        public const string SslCertificateCAMismatch = @"The certificate authority (CA) does not match.";
        
        /// <summary>
        ///   Looks up a localized string similar to The host name does not match the name on the certificate..
        /// </summary>
        public const string SslCertificateHostNameMismatch = @"The host name does not match the name on the certificate.";
        
        /// <summary>
        ///   Looks up a localized string similar to The certificate is not a certificate authority (CA)..
        /// </summary>
        public const string SslCertificateIsNotCA = @"The certificate is not a certificate authority (CA).";
        
        /// <summary>
        ///   Looks up a localized string similar to SSL Connection error..
        /// </summary>
        public const string SslConnectionError = @"SSL Connection error.";
        
        /// <summary>
        ///   Looks up a localized string similar to The stream has already been closed.
        /// </summary>
        public const string StreamAlreadyClosed = @"The stream has already been closed";
        
        /// <summary>
        ///   Looks up a localized string similar to  The stream does not support reading.
        /// </summary>
        public const string StreamNoRead = @" The stream does not support reading";
        
        /// <summary>
        ///   Looks up a localized string similar to The stream does not support writing.
        /// </summary>
        public const string StreamNoWrite = @"The stream does not support writing";
        
        /// <summary>
        ///   Looks up a localized string similar to String can&apos;t be empty..
        /// </summary>
        public const string StringEmpty = @"String can't be empty.";
        
        /// <summary>
        ///   Looks up a localized string similar to Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding..
        /// </summary>
        public const string Timeout = @"Timeout expired.  The timeout period elapsed prior to completion of the operation or the server is not responding.";
        
        /// <summary>
        ///   Looks up a localized string similar to error connecting: Timeout expired.  The timeout period elapsed prior to obtaining a connection from the pool.  This may have occurred because all pooled connections were in use and max pool size was reached..
        /// </summary>
        public const string TimeoutGettingConnection = @"error connecting: Timeout expired.  The timeout period elapsed prior to obtaining a connection from the pool.  This may have occurred because all pooled connections were in use and max pool size was reached.";
        
        /// <summary>
        ///   Looks up a localized string similar to All server connection attempts were aborted. Timeout of {0} seconds was exceeded for each selected server..
        /// </summary>
        public const string TimeOutMultipleHost = @"All server connection attempts were aborted. Timeout of {0} seconds was exceeded for each selected server.";
        
        /// <summary>
        ///   Looks up a localized string similar to TLSv1.3 is supported in .NET Framework 4.8 or .NET Core 3.0..
        /// </summary>
        public const string Tlsv13NotSupported = @"TLSv1.3 is supported in .NET Framework 4.8 or .NET Core 3.0.";
        
        /// <summary>
        ///   Looks up a localized string similar to No supported TLS protocol version found in the &apos;tls-versions&apos; list..
        /// </summary>
        public const string TlsVersionNotSupported = @"No supported TLS protocol version found in the 'tls-versions' list.";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Connection Closed.
        /// </summary>
        public const string TraceCloseConnection = @"{0}: Connection Closed";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to trace.  There are more than Int32.MaxValue connections in use..
        /// </summary>
        public const string TraceErrorMoreThanMaxValueConnections = @"Unable to trace.  There are more than Int32.MaxValue connections in use.";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Error encountered during row fetch. Number = {1}, Message={2}.
        /// </summary>
        public const string TraceFetchError = @"{0}: Error encountered during row fetch. Number = {1}, Message={2}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Connection Opened: connection string = &apos;{1}&apos;.
        /// </summary>
        public const string TraceOpenConnection = @"{0}: Connection Opened: connection string = '{1}'";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Error encountered attempting to open result: Number={1}, Message={2}.
        /// </summary>
        public const string TraceOpenResultError = @"{0}: Error encountered attempting to open result: Number={1}, Message={2}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Query Closed.
        /// </summary>
        public const string TraceQueryDone = @"{0}: Query Closed";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Query Normalized: {2}.
        /// </summary>
        public const string TraceQueryNormalized = @"{0}: Query Normalized: {2}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Query Opened: {2}.
        /// </summary>
        public const string TraceQueryOpened = @"{0}: Query Opened: {2}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Resultset Opened: field(s) = {1}, affected rows = {2}, inserted id = {3}.
        /// </summary>
        public const string TraceResult = @"{0}: Resultset Opened: field(s) = {1}, affected rows = {2}, inserted id = {3}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Resultset Closed. Total rows={1}, skipped rows={2}, size (bytes)={3}.
        /// </summary>
        public const string TraceResultClosed = @"{0}: Resultset Closed. Total rows={1}, skipped rows={2}, size (bytes)={3}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Set Database: {1}.
        /// </summary>
        public const string TraceSetDatabase = @"{0}: Set Database: {1}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Statement closed: statement id = {1}.
        /// </summary>
        public const string TraceStatementClosed = @"{0}: Statement closed: statement id = {1}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Statement executed: statement id = {1}.
        /// </summary>
        public const string TraceStatementExecuted = @"{0}: Statement executed: statement id = {1}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Statement prepared: sql=&apos;{1}&apos;, statement id={2}.
        /// </summary>
        public const string TraceStatementPrepared = @"{0}: Statement prepared: sql='{1}', statement id={2}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Usage Advisor Warning: Query is using a bad index.
        /// </summary>
        public const string TraceUAWarningBadIndex = @"{0}: Usage Advisor Warning: Query is using a bad index";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Usage Advisor Warning: The field &apos;{2}&apos; was converted to the following types: {3}.
        /// </summary>
        public const string TraceUAWarningFieldConversion = @"{0}: Usage Advisor Warning: The field '{2}' was converted to the following types: {3}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Usage Advisor Warning: Query does not use an index.
        /// </summary>
        public const string TraceUAWarningNoIndex = @"{0}: Usage Advisor Warning: Query does not use an index";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Usage Advisor Warning: The following columns were not accessed: {2}.
        /// </summary>
        public const string TraceUAWarningSkippedColumns = @"{0}: Usage Advisor Warning: The following columns were not accessed: {2}";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: Usage Advisor Warning: Skipped {2} rows. Consider a more focused query..
        /// </summary>
        public const string TraceUAWarningSkippedRows = @"{0}: Usage Advisor Warning: Skipped {2} rows. Consider a more focused query.";
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: MySql Warning: Level={1}, Code={2}, Message={3}.
        /// </summary>
        public const string TraceWarning = @"{0}: MySql Warning: Level={1}, Code={2}, Message={3}";
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not derived from BaseCommandInterceptor.
        /// </summary>
        public const string TypeIsNotCommandInterceptor = @"Type '{0}' is not derived from BaseCommandInterceptor";
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; is not derived from BaseExceptionInterceptor.
        /// </summary>
        public const string TypeIsNotExceptionInterceptor = @"Type '{0}' is not derived from BaseExceptionInterceptor";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to any of the specified MySQL hosts..
        /// </summary>
        public const string UnableToConnectToHost = @"Unable to connect to any of the specified MySQL hosts.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create plugin for authentication method &apos;{0}&apos;. Please see inner exception for details..
        /// </summary>
        public const string UnableToCreateAuthPlugin = @"Unable to create plugin for authentication method '{0}'. Please see inner exception for details.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to derive stored routine parameters.  The &apos;Parameters&apos; information schema table is not available and access to the stored procedure body has been disabled..
        /// </summary>
        public const string UnableToDeriveParameters = @"Unable to derive stored routine parameters.  The 'Parameters' information schema table is not available and access to the stored procedure body has been disabled.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to enable query analysis.  Be sure the MySql.Data.EMTrace assembly is properly located and registered..
        /// </summary>
        public const string UnableToEnableQueryAnalysis = @"Unable to enable query analysis.  Be sure the MySql.Data.EMTrace assembly is properly located and registered.";
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured attempting to enumerate the user-defined functions.  Do you have SELECT privileges on the mysql.func table?.
        /// </summary>
        public const string UnableToEnumerateUDF = @"An error occured attempting to enumerate the user-defined functions.  Do you have SELECT privileges on the mysql.func table?";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to execute stored procedure &apos;{0}&apos;..
        /// </summary>
        public const string UnableToExecuteSP = @"Unable to execute stored procedure '{0}'.";
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error parsing the foreign key definition..
        /// </summary>
        public const string UnableToParseFK = @"There was an error parsing the foreign key definition.";
        
        /// <summary>
        ///   Looks up a localized string similar to Error encountered reading the RSA public key..
        /// </summary>
        public const string UnableToReadRSAKey = @"Error encountered reading the RSA public key.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve stored procedure metadata for routine &apos;{0}&apos;.  Either grant  SELECT privilege to mysql.proc for this user or use "check parameters=false" with  your connection string..
        /// </summary>
        public const string UnableToRetrieveParameters = @"Unable to retrieve stored procedure metadata for routine '{0}'.  Either grant  SELECT privilege to mysql.proc for this user or use ""check parameters=false"" with  your connection string.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to start a second async operation while one is running..
        /// </summary>
        public const string UnableToStartSecondAsyncOp = @"Unable to start a second async operation while one is running.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unix sockets are not supported on Windows.
        /// </summary>
        public const string UnixSocketsNotSupported = @"Unix sockets are not supported on Windows";
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown authentication method &apos;{0}&apos; was requested..
        /// </summary>
        public const string UnknownAuthenticationMethod = @"Unknown authentication method '{0}' was requested.";
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown connection protocol.
        /// </summary>
        public const string UnknownConnectionProtocol = @"Unknown connection protocol";
        
        /// <summary>
        ///   Looks up a localized string similar to Value &apos;{0}&apos; is not of the correct type..
        /// </summary>
        public const string ValueNotCorrectType = @"Value '{0}' is not of the correct type.";
        
        /// <summary>
        ///   Looks up a localized string similar to The requested column value could not be treated as or conveted to a Guid..
        /// </summary>
        public const string ValueNotSupportedForGuid = @"The requested column value could not be treated as or conveted to a Guid.";
        
        /// <summary>
        ///   Looks up a localized string similar to Windows authentication connections are not supported on {0}.
        /// </summary>
        public const string WinAuthNotSupportOnPlatform = @"Windows authentication connections are not supported on {0}";
        
        /// <summary>
        ///   Looks up a localized string similar to Writing to the stream failed..
        /// </summary>
        public const string WriteToStreamFailed = @"Writing to the stream failed.";
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &apos;{0}&apos; is not found but a parameter with the name &apos;{1}&apos; is found. Parameter names must include the leading parameter marker..
        /// </summary>
        public const string WrongParameterName = @"Parameter '{0}' is not found but a parameter with the name '{1}' is found. Parameter names must include the leading parameter marker.";
    }
}
