using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1,   37,   -1,   37,   -1, }
        ;
        // Count = 343
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                8, // array length: 8
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                8, // array length: 8
                1351, // index: 1351, string: "ETag"
                1356, // index: 1356, string: "ExpirationTime"
                1371, // index: 1371, string: "RegistrationId"
                1386, // index: 1386, string: "Tags"
                1391, // index: 1391, string: "ChannelUri"
                1402, // index: 1402, string: "BodyTemplate"
                478, // index: 478, string: "WnsHeaders"
                1415, // index: 1415, string: "TemplateName"
                8, // array length: 8
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                5, // array length: 5
                1351, // index: 1351, string: "ETag"
                1356, // index: 1356, string: "ExpirationTime"
                1371, // index: 1371, string: "RegistrationId"
                1386, // index: 1386, string: "Tags"
                1391, // index: 1391, string: "ChannelUri"
                5, // array length: 5
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                535, // index: 535, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                1428, // index: 1428, string: "Key"
                506, // index: 506, string: "Value"
                2, // array length: 2
                535, // index: 535, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                535, // index: 535, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                620, // index: 620, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1432, // index: 1432, string: "key"
                1436, // index: 1436, string: "value"
                2, // array length: 2
                620, // index: 620, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                620, // index: 620, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                20, // array length: 20
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                20, // array length: 20
                1442, // index: 1442, string: "LockDuration"
                1455, // index: 1455, string: "MaxSizeInMegabytes"
                1474, // index: 1474, string: "RequiresDuplicateDetection"
                1501, // index: 1501, string: "RequiresSession"
                1517, // index: 1517, string: "DefaultMessageTimeToLive"
                1542, // index: 1542, string: "DeadLetteringOnMessageExpiration"
                1575, // index: 1575, string: "DuplicateDetectionHistoryTimeWindow"
                1611, // index: 1611, string: "MaxDeliveryCount"
                1628, // index: 1628, string: "EnableBatchedOperations"
                1652, // index: 1652, string: "IsAnonymousAccessible"
                1674, // index: 1674, string: "SizeInBytes"
                1686, // index: 1686, string: "Status"
                1693, // index: 1693, string: "ForwardTo"
                1703, // index: 1703, string: "MessageCount"
                1716, // index: 1716, string: "CreatedAt"
                1726, // index: 1726, string: "UpdatedAt"
                1736, // index: 1736, string: "AccessedAt"
                1747, // index: 1747, string: "UserMetadata"
                1760, // index: 1760, string: "SupportOrdering"
                1776, // index: 1776, string: "CountDetails"
                20, // array length: 20
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                3, // array length: 3
                717, // index: 717, string: "Active"
                724, // index: 724, string: "Disabled"
                733, // index: 733, string: "Restoring"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                5, // array length: 5
                1789, // index: 1789, string: "ActiveMessageCount"
                1808, // index: 1808, string: "DeadLetterMessageCount"
                1831, // index: 1831, string: "ScheduledMessageCount"
                1853, // index: 1853, string: "TransferMessageCount"
                1874, // index: 1874, string: "TransferDeadLetterMessageCount"
                5, // array length: 5
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                17, // array length: 17
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                17, // array length: 17
                1517, // index: 1517, string: "DefaultMessageTimeToLive"
                1455, // index: 1455, string: "MaxSizeInMegabytes"
                1474, // index: 1474, string: "RequiresDuplicateDetection"
                1575, // index: 1575, string: "DuplicateDetectionHistoryTimeWindow"
                1628, // index: 1628, string: "EnableBatchedOperations"
                1674, // index: 1674, string: "SizeInBytes"
                1905, // index: 1905, string: "FilteringMessagesBeforePublishing"
                1652, // index: 1652, string: "IsAnonymousAccessible"
                1686, // index: 1686, string: "Status"
                1693, // index: 1693, string: "ForwardTo"
                1716, // index: 1716, string: "CreatedAt"
                1726, // index: 1726, string: "UpdatedAt"
                1736, // index: 1736, string: "AccessedAt"
                1747, // index: 1747, string: "UserMetadata"
                1760, // index: 1760, string: "SupportOrdering"
                1939, // index: 1939, string: "SubscriptionCount"
                1776, // index: 1776, string: "CountDetails"
                17, // array length: 17
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                15, // array length: 15
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                15, // array length: 15
                1442, // index: 1442, string: "LockDuration"
                1501, // index: 1501, string: "RequiresSession"
                1517, // index: 1517, string: "DefaultMessageTimeToLive"
                1542, // index: 1542, string: "DeadLetteringOnMessageExpiration"
                1957, // index: 1957, string: "DeadLetteringOnFilterEvaluationExceptions"
                1703, // index: 1703, string: "MessageCount"
                1611, // index: 1611, string: "MaxDeliveryCount"
                1628, // index: 1628, string: "EnableBatchedOperations"
                1686, // index: 1686, string: "Status"
                1693, // index: 1693, string: "ForwardTo"
                1716, // index: 1716, string: "CreatedAt"
                1726, // index: 1726, string: "UpdatedAt"
                1736, // index: 1736, string: "AccessedAt"
                1747, // index: 1747, string: "UserMetadata"
                1776, // index: 1776, string: "CountDetails"
                15, // array length: 15
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                2, // array length: 2
                1999, // index: 1999, string: "Filter"
                2006, // index: 2006, string: "Action"
                2, // array length: 2
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                294, // index: 294, string: "http://schemas.microsoft.com/netservices/2010/10/servicebus/connect"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                405, // index: 405, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging"
                2, // array length: 2
                2013, // index: 2013, string: "NewPnsHandle"
                2026, // index: 2026, string: "OriginalPnsHandle"
                2, // array length: 2
                405, // index: 405, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging"
                405, // index: 405, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging"
                16, // array length: 16
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                16, // array length: 16
                2044, // index: 2044, string: "CorrelationId"
                2058, // index: 2058, string: "DeliveryCount"
                2072, // index: 2072, string: "EnqueuedTimeUtc"
                2088, // index: 2088, string: "ExpiresAtUtc"
                2101, // index: 2101, string: "Label"
                2107, // index: 2107, string: "LockToken"
                2117, // index: 2117, string: "LockedUntilUtc"
                2132, // index: 2132, string: "MessageId"
                2142, // index: 2142, string: "ReplyTo"
                2150, // index: 2150, string: "ReplyToSessionId"
                2167, // index: 2167, string: "ScheduledEnqueueTimeUtc"
                2191, // index: 2191, string: "SequenceNumber"
                2206, // index: 2206, string: "SessionId"
                2216, // index: 2216, string: "Size"
                2221, // index: 2221, string: "TimeToLive"
                2232, // index: 2232, string: "To"
                16, // array length: 16
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860, // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
                860  // index: 860, string: "http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http"
        };
        // Count = 3
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[] {
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 717, // Active
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 724, // Disabled
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 733, // Restoring
                    Value = 2,
                }
        };
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=56
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.TemplateRegistration, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0" +
                                ", Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Registration, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultur" +
                                "e=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.CDataMember, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Culture" +
                                "=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 4, // 0x4
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.WnsHeaderCollection, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0," +
                                " Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.QueueDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cu" +
                                "lture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.EntityStatus, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultur" +
                                "e=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Microsoft.WindowsAzure.Messaging.EntityStatus, Microsoft.WindowsAzure.Messaging.Managed, Vers" +
                                "ion=1.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]], mscorlib, Version=4.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=b77a5c561934e089")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.MessageCountDetails, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0," +
                                " Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.TopicDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cu" +
                                "lture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.SubscriptionDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0." +
                                "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Http.RuleInfo, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultu" +
                                "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.UpdateChannelUriPayload, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0." +
                                "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Http.BrokerProperties, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0." +
                                "0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Message, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Culture=neu" +
                                "tral, PublicKeyToken=31bf3856ad364e35")),
                    TableIndex = 336, // 0x150
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=22
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 938, // Message
                        NamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        StableNameIndex = 938, // Message
                        StableNameNamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        TopLevelElementNameIndex = 938, // Message
                        TopLevelElementNamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Message, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Culture=neu" +
                                    "tral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Message, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Culture=neu" +
                                    "tral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    ErrorMessageIndex = 946, // Type 'Microsoft.WindowsAzure.Messaging.Message' cannot be serialized. Consider marking it with the DataContractAttribute attribute, and marking all of its members you want serialized with the DataMemberAttribute attribute.  If the type is a collection, consider marking it with the CollectionDataContractAttribute.  See the Microsoft .NET Framework documentation for other supported types.
                    Kind = global::DataContractKind.InvalidDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=11
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // WindowsTemplateRegistrationDescription
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 255, // WindowsTemplateRegistrationDescription
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 255, // WindowsTemplateRegistrationDescription
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.TemplateRegistration, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.TemplateRegistration, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadWindowsTemplateRegistrationDescriptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteWindowsTemplateRegistrationDescriptionToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 10,
                    MemberNamesListIndex = 13,
                    MemberNamespacesListIndex = 22,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 362, // WindowsRegistrationDescription
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 362, // WindowsRegistrationDescription
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 362, // WindowsRegistrationDescription
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Registration, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Registration, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=31bf3856ad364e35")),
                        KnownDataContractsListIndex = 3,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type2.ReadWindowsRegistrationDescriptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type3.WriteWindowsRegistrationDescriptionToXml),
                    ChildElementNamespacesListIndex = 31,
                    ContractNamespacesListIndex = 37,
                    MemberNamesListIndex = 39,
                    MemberNamespacesListIndex = 45,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 512, // KeyValueOfstringstring
                        NamespaceIndex = 535, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 512, // KeyValueOfstringstring
                        StableNameNamespaceIndex = 535, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 512, // KeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 535, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.0.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type8.ReadKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type9.WriteKeyValueOfstringstringToXml),
                    ChildElementNamespacesListIndex = 51,
                    ContractNamespacesListIndex = 54,
                    MemberNamesListIndex = 56,
                    MemberNamespacesListIndex = 59,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 593, // KeyValuePairOfstringstring
                        NamespaceIndex = 620, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 593, // KeyValuePairOfstringstring
                        StableNameNamespaceIndex = 620, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 593, // KeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 620, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type10.ReadKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type11.WriteKeyValuePairOfstringstringToXml),
                    ChildElementNamespacesListIndex = 62,
                    ContractNamespacesListIndex = 65,
                    MemberNamesListIndex = 67,
                    MemberNamespacesListIndex = 70,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 687, // QueueDescription
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 687, // QueueDescription
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 687, // QueueDescription
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.QueueDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.QueueDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadQueueDescriptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WriteQueueDescriptionToXml),
                    ChildElementNamespacesListIndex = 73,
                    ContractNamespacesListIndex = 94,
                    MemberNamesListIndex = 96,
                    MemberNamespacesListIndex = 117,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 743, // MessageCountDetails
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 743, // MessageCountDetails
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 743, // MessageCountDetails
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.MessageCountDetails, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.MessageCountDetails, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type14.ReadMessageCountDetailsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type15.WriteMessageCountDetailsToXml),
                    ChildElementNamespacesListIndex = 142,
                    ContractNamespacesListIndex = 148,
                    MemberNamesListIndex = 150,
                    MemberNamespacesListIndex = 156,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 763, // TopicDescription
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 763, // TopicDescription
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 763, // TopicDescription
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.TopicDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.TopicDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cu" +
                                    "lture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type16.ReadTopicDescriptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type17.WriteTopicDescriptionToXml),
                    ChildElementNamespacesListIndex = 162,
                    ContractNamespacesListIndex = 180,
                    MemberNamesListIndex = 182,
                    MemberNamespacesListIndex = 200,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 780, // SubscriptionDescription
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 780, // SubscriptionDescription
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 780, // SubscriptionDescription
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.SubscriptionDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0." +
                                    "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.SubscriptionDescription, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0." +
                                    "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type18.ReadSubscriptionDescriptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type19.WriteSubscriptionDescriptionToXml),
                    ChildElementNamespacesListIndex = 218,
                    ContractNamespacesListIndex = 234,
                    MemberNamesListIndex = 236,
                    MemberNamespacesListIndex = 252,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 804, // RuleDescription
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 804, // RuleDescription
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 804, // RuleDescription
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Http.RuleInfo, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Http.RuleInfo, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type20.ReadRuleDescriptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type21.WriteRuleDescriptionToXml),
                    ChildElementNamespacesListIndex = 268,
                    ContractNamespacesListIndex = 271,
                    MemberNamesListIndex = 273,
                    MemberNamespacesListIndex = 276,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 820, // UpdatePnsHandlePayload
                        NamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        StableNameIndex = 820, // UpdatePnsHandlePayload
                        StableNameNamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        TopLevelElementNameIndex = 820, // UpdatePnsHandlePayload
                        TopLevelElementNamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.UpdateChannelUriPayload, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0." +
                                    "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.UpdateChannelUriPayload, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0." +
                                    "0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 279,
                    ContractNamespacesListIndex = 282,
                    MemberNamesListIndex = 284,
                    MemberNamespacesListIndex = 287,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 843, // BrokerProperties
                        NamespaceIndex = 860, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http
                        StableNameIndex = 843, // BrokerProperties
                        StableNameNamespaceIndex = 860, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http
                        TopLevelElementNameIndex = 843, // BrokerProperties
                        TopLevelElementNamespaceIndex = 860, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging.Http
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Http.BrokerProperties, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.Http.BrokerProperties, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 290,
                    ContractNamespacesListIndex = 307,
                    MemberNamesListIndex = 309,
                    MemberNamespacesListIndex = 326,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=2
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 478, // WnsHeaders
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 478, // WnsHeaders
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 478, // WnsHeaders
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.WnsHeaderCollection, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.WnsHeaderCollection, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type5.ReadWnsHeadersFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type6.WriteWnsHeadersToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type7.ReadWnsHeadersFromXmlIsGetOnly),
                    CollectionItemNameIndex = 489, // WnsHeader
                    KeyNameIndex = 499, // Header
                    ItemNameIndex = 489, // WnsHeader
                    ValueNameIndex = 506, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1336, // ArrayOfanyType
                        NamespaceIndex = 535, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1336, // ArrayOfanyType
                        StableNameNamespaceIndex = 535, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1336, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 535, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=1
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[] {
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 704, // EntityStatus
                        NamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        StableNameIndex = 704, // EntityStatus
                        StableNameNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        TopLevelElementNameIndex = 704, // EntityStatus
                        TopLevelElementNamespaceIndex = 294, // http://schemas.microsoft.com/netservices/2010/10/servicebus/connect
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.EntityStatus, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.EntityStatus, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Cultur" +
                                    "e=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 138,
                    MemberCount = 3,
                }
        };
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=1
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[] {
                new global::XmlDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 393, // CDataMember
                        NamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        StableNameIndex = 393, // CDataMember
                        StableNameNamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        TopLevelElementNameIndex = 393, // CDataMember
                        TopLevelElementNamespaceIndex = 405, // http://schemas.datacontract.org/2004/07/Microsoft.WindowsAzure.Messaging
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.CDataMember, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Culture" +
                                    "=neutral, PublicKeyToken=31bf3856ad364e35")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.WindowsAzure.Messaging.CDataMember, Microsoft.WindowsAzure.Messaging.Managed, Version=1.0.0.0, Culture" +
                                    "=neutral, PublicKeyToken=31bf3856ad364e35")),
                    },
                    CreateXmlSerializableDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.CreateXmlSerializableDelegate>(global::Type4.CreateCDataMember),
                }
        };
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=3
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type25.WriteUpdatePnsHandlePayloadToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type24.ReadUpdatePnsHandlePayloadFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 53,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type29.WriteBrokerPropertiesToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type28.ReadBrokerPropertiesFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type34.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type33.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type35.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','W','i','n','d','o','w','s','T','e','m','p','l','a','t','e',
            'R','e','g','i','s','t','r','a','t','i','o','n','D','e','s','c','r','i','p','t','i','o','n','\0','h','t','t','p',':','/',
            '/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','n','e','t','s','e','r','v',
            'i','c','e','s','/','2','0','1','0','/','1','0','/','s','e','r','v','i','c','e','b','u','s','/','c','o','n','n','e','c',
            't','\0','W','i','n','d','o','w','s','R','e','g','i','s','t','r','a','t','i','o','n','D','e','s','c','r','i','p','t','i',
            'o','n','\0','C','D','a','t','a','M','e','m','b','e','r','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.',
            'd','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o',
            's','o','f','t','.','W','i','n','d','o','w','s','A','z','u','r','e','.','M','e','s','s','a','g','i','n','g','\0','W','n',
            's','H','e','a','d','e','r','s','\0','W','n','s','H','e','a','d','e','r','\0','H','e','a','d','e','r','\0','V','a','l','u',
            'e','\0','K','e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','h','t','t','p',':',
            '/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1',
            '0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','K','e','y','V','a','l','u',
            'e','P','a','i','r','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h',
            'e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/',
            'S','y','s','t','e','m','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n','e','r','i','c','\0','Q','u','e',
            'u','e','D','e','s','c','r','i','p','t','i','o','n','\0','E','n','t','i','t','y','S','t','a','t','u','s','\0','A','c','t',
            'i','v','e','\0','D','i','s','a','b','l','e','d','\0','R','e','s','t','o','r','i','n','g','\0','M','e','s','s','a','g','e',
            'C','o','u','n','t','D','e','t','a','i','l','s','\0','T','o','p','i','c','D','e','s','c','r','i','p','t','i','o','n','\0',
            'S','u','b','s','c','r','i','p','t','i','o','n','D','e','s','c','r','i','p','t','i','o','n','\0','R','u','l','e','D','e',
            's','c','r','i','p','t','i','o','n','\0','U','p','d','a','t','e','P','n','s','H','a','n','d','l','e','P','a','y','l','o',
            'a','d','\0','B','r','o','k','e','r','P','r','o','p','e','r','t','i','e','s','\0','h','t','t','p',':','/','/','s','c','h',
            'e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/',
            'M','i','c','r','o','s','o','f','t','.','W','i','n','d','o','w','s','A','z','u','r','e','.','M','e','s','s','a','g','i',
            'n','g','.','H','t','t','p','\0','M','e','s','s','a','g','e','\0','T','y','p','e',' ','\'','M','i','c','r','o','s','o','f',
            't','.','W','i','n','d','o','w','s','A','z','u','r','e','.','M','e','s','s','a','g','i','n','g','.','M','e','s','s','a',
            'g','e','\'',' ','c','a','n','n','o','t',' ','b','e',' ','s','e','r','i','a','l','i','z','e','d','.',' ','C','o','n','s',
            'i','d','e','r',' ','m','a','r','k','i','n','g',' ','i','t',' ','w','i','t','h',' ','t','h','e',' ','D','a','t','a','C',
            'o','n','t','r','a','c','t','A','t','t','r','i','b','u','t','e',' ','a','t','t','r','i','b','u','t','e',',',' ','a','n',
            'd',' ','m','a','r','k','i','n','g',' ','a','l','l',' ','o','f',' ','i','t','s',' ','m','e','m','b','e','r','s',' ','y',
            'o','u',' ','w','a','n','t',' ','s','e','r','i','a','l','i','z','e','d',' ','w','i','t','h',' ','t','h','e',' ','D','a',
            't','a','M','e','m','b','e','r','A','t','t','r','i','b','u','t','e',' ','a','t','t','r','i','b','u','t','e','.',' ',' ',
            'I','f',' ','t','h','e',' ','t','y','p','e',' ','i','s',' ','a',' ','c','o','l','l','e','c','t','i','o','n',',',' ','c',
            'o','n','s','i','d','e','r',' ','m','a','r','k','i','n','g',' ','i','t',' ','w','i','t','h',' ','t','h','e',' ','C','o',
            'l','l','e','c','t','i','o','n','D','a','t','a','C','o','n','t','r','a','c','t','A','t','t','r','i','b','u','t','e','.',
            ' ',' ','S','e','e',' ','t','h','e',' ','M','i','c','r','o','s','o','f','t',' ','.','N','E','T',' ','F','r','a','m','e',
            'w','o','r','k',' ','d','o','c','u','m','e','n','t','a','t','i','o','n',' ','f','o','r',' ','o','t','h','e','r',' ','s',
            'u','p','p','o','r','t','e','d',' ','t','y','p','e','s','.','\0','A','r','r','a','y','O','f','a','n','y','T','y','p','e',
            '\0','E','T','a','g','\0','E','x','p','i','r','a','t','i','o','n','T','i','m','e','\0','R','e','g','i','s','t','r','a','t',
            'i','o','n','I','d','\0','T','a','g','s','\0','C','h','a','n','n','e','l','U','r','i','\0','B','o','d','y','T','e','m','p',
            'l','a','t','e','\0','T','e','m','p','l','a','t','e','N','a','m','e','\0','K','e','y','\0','k','e','y','\0','v','a','l','u',
            'e','\0','L','o','c','k','D','u','r','a','t','i','o','n','\0','M','a','x','S','i','z','e','I','n','M','e','g','a','b','y',
            't','e','s','\0','R','e','q','u','i','r','e','s','D','u','p','l','i','c','a','t','e','D','e','t','e','c','t','i','o','n',
            '\0','R','e','q','u','i','r','e','s','S','e','s','s','i','o','n','\0','D','e','f','a','u','l','t','M','e','s','s','a','g',
            'e','T','i','m','e','T','o','L','i','v','e','\0','D','e','a','d','L','e','t','t','e','r','i','n','g','O','n','M','e','s',
            's','a','g','e','E','x','p','i','r','a','t','i','o','n','\0','D','u','p','l','i','c','a','t','e','D','e','t','e','c','t',
            'i','o','n','H','i','s','t','o','r','y','T','i','m','e','W','i','n','d','o','w','\0','M','a','x','D','e','l','i','v','e',
            'r','y','C','o','u','n','t','\0','E','n','a','b','l','e','B','a','t','c','h','e','d','O','p','e','r','a','t','i','o','n',
            's','\0','I','s','A','n','o','n','y','m','o','u','s','A','c','c','e','s','s','i','b','l','e','\0','S','i','z','e','I','n',
            'B','y','t','e','s','\0','S','t','a','t','u','s','\0','F','o','r','w','a','r','d','T','o','\0','M','e','s','s','a','g','e',
            'C','o','u','n','t','\0','C','r','e','a','t','e','d','A','t','\0','U','p','d','a','t','e','d','A','t','\0','A','c','c','e',
            's','s','e','d','A','t','\0','U','s','e','r','M','e','t','a','d','a','t','a','\0','S','u','p','p','o','r','t','O','r','d',
            'e','r','i','n','g','\0','C','o','u','n','t','D','e','t','a','i','l','s','\0','A','c','t','i','v','e','M','e','s','s','a',
            'g','e','C','o','u','n','t','\0','D','e','a','d','L','e','t','t','e','r','M','e','s','s','a','g','e','C','o','u','n','t',
            '\0','S','c','h','e','d','u','l','e','d','M','e','s','s','a','g','e','C','o','u','n','t','\0','T','r','a','n','s','f','e',
            'r','M','e','s','s','a','g','e','C','o','u','n','t','\0','T','r','a','n','s','f','e','r','D','e','a','d','L','e','t','t',
            'e','r','M','e','s','s','a','g','e','C','o','u','n','t','\0','F','i','l','t','e','r','i','n','g','M','e','s','s','a','g',
            'e','s','B','e','f','o','r','e','P','u','b','l','i','s','h','i','n','g','\0','S','u','b','s','c','r','i','p','t','i','o',
            'n','C','o','u','n','t','\0','D','e','a','d','L','e','t','t','e','r','i','n','g','O','n','F','i','l','t','e','r','E','v',
            'a','l','u','a','t','i','o','n','E','x','c','e','p','t','i','o','n','s','\0','F','i','l','t','e','r','\0','A','c','t','i',
            'o','n','\0','N','e','w','P','n','s','H','a','n','d','l','e','\0','O','r','i','g','i','n','a','l','P','n','s','H','a','n',
            'd','l','e','\0','C','o','r','r','e','l','a','t','i','o','n','I','d','\0','D','e','l','i','v','e','r','y','C','o','u','n',
            't','\0','E','n','q','u','e','u','e','d','T','i','m','e','U','t','c','\0','E','x','p','i','r','e','s','A','t','U','t','c',
            '\0','L','a','b','e','l','\0','L','o','c','k','T','o','k','e','n','\0','L','o','c','k','e','d','U','n','t','i','l','U','t',
            'c','\0','M','e','s','s','a','g','e','I','d','\0','R','e','p','l','y','T','o','\0','R','e','p','l','y','T','o','S','e','s',
            's','i','o','n','I','d','\0','S','c','h','e','d','u','l','e','d','E','n','q','u','e','u','e','T','i','m','e','U','t','c',
            '\0','S','e','q','u','e','n','c','e','N','u','m','b','e','r','\0','S','e','s','s','i','o','n','I','d','\0','S','i','z','e',
            '\0','T','i','m','e','T','o','L','i','v','e','\0','T','o','\0'};
    }
}
