﻿namespace MyUtilities.CWS_14_8
{
    using System.CodeDom.Compiler;
    using System.ServiceModel;

    [ServiceContract(Namespace="urn:wsdl.ws.rightnow.com/v1_2", ConfigurationName="CWS_14_8.RightNowFedAuthSyncPort"), GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface RightNowFedAuthSyncPort
    {
        [ServiceKnownType(typeof(AnalyticsReportSearchFilter)), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:BatchRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:BatchResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2")]
        BatchResponse Batch(BatchRequest request);
        [FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ConvertGenericToObjectRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ConvertGenericToObjectResponse"), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter))]
        ConvertGenericToObjectResponse ConvertGenericToObject(ConvertGenericToObjectRequest request);
        [ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ConvertObjectToGenericRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ConvertObjectToGenericResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), ServiceKnownType(typeof(RNFault))]
        ConvertObjectToGenericResponse ConvertObjectToGeneric(ConvertObjectToGenericRequest request);
        [FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault)), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:CreateRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:CreateResponse")]
        CreateResponse Create(CreateRequest request);
        [OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:DestroyRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:DestroyResponse"), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault))]
        DestroyResponse Destroy(DestroyRequest request);
        [OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ExecuteMarketingFlowRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ExecuteMarketingFlowResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter))]
        ExecuteMarketingFlowResponse ExecuteMarketingFlow(ExecuteMarketingFlowRequest request);
        [FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetResponse"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault))]
        GetResponse Get(GetRequest request);
        [OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetFileDataRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetFileDataResponse"), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true)]
        GetFileDataResponse GetFileData(GetFileDataRequest request);
        [XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetMetaDataRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetMetaDataResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2")]
        GetMetaDataResponse GetMetaData(GetMetaDataRequest request);
        [FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetMetaDataForClassRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetMetaDataForClassResponse"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault))]
        GetMetaDataForClassResponse GetMetaDataForClass(GetMetaDataForClassRequest request);
        [ServiceKnownType(typeof(AnalyticsReportSearchFilter)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetMetaDataLastChangeTimeRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetMetaDataLastChangeTimeResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault))]
        GetMetaDataLastChangeTimeResponse GetMetaDataLastChangeTime(GetMetaDataLastChangeTimeRequest request);
        [FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), ServiceKnownType(typeof(RNFault)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetValuesForNamedIDRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetValuesForNamedIDResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2")]
        GetValuesForNamedIDResponse GetValuesForNamedID(GetValuesForNamedIDRequest request);
        [XmlSerializerFormat(SupportFaults=true), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetValuesForNamedIDHierarchyRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:GetValuesForNamedIDHierarchyResponse")]
        GetValuesForNamedIDHierarchyResponse GetValuesForNamedIDHierarchy(GetValuesForNamedIDHierarchyRequest request);
        [ServiceKnownType(typeof(AnalyticsReportSearchFilter)), ServiceKnownType(typeof(RNFault)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:QueryCSVRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:QueryCSVResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true)]
        QueryCSVResponse QueryCSV(QueryCSVRequest request);
        [FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:QueryObjectsRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:QueryObjectsResponse")]
        QueryObjectsResponse QueryObjects(QueryObjectsRequest request);
        [ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ResetContactPasswordRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:ResetContactPasswordResponse")]
        ResetContactPasswordResponse ResetContactPassword(ResetContactPasswordRequest request);
        [XmlSerializerFormat(SupportFaults=true), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:RunAnalyticsReportRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:RunAnalyticsReportResponse"), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter))]
        RunAnalyticsReportResponse RunAnalyticsReport(RunAnalyticsReportRequest request);
        [OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:SendMailingToContactRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:SendMailingToContactResponse"), ServiceKnownType(typeof(RNFault)), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true)]
        SendMailingToContactResponse SendMailingToContact(SendMailingToContactRequest request);
        [OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:TransferSubObjectsRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:TransferSubObjectsResponse"), ServiceKnownType(typeof(AnalyticsReportSearchFilter)), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault))]
        TransferSubObjectsResponse TransferSubObjects(TransferSubObjectsRequest request);
        [ServiceKnownType(typeof(AnalyticsReportSearchFilter)), OperationContract(Action="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:UpdateRequest", ReplyAction="urn:wsdl.ws.rightnow.com/v1_2:RightNowFedAuthSyncPort:UpdateResponse"), FaultContract(typeof(RequestErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="RequestErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(ServerErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="ServerErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), FaultContract(typeof(UnexpectedErrorFaultType), Action="http://www.w3.org/2005/08/addressing/soap/fault", Name="UnexpectedErrorFault", Namespace="urn:faults.ws.rightnow.com/v1_2"), XmlSerializerFormat(SupportFaults=true), ServiceKnownType(typeof(RNFault))]
        UpdateResponse Update(UpdateRequest request);
    }
}
