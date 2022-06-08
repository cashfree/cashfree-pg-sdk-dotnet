using System.Collections.Generic;
using System;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;
using Newtonsoft.Json;

namespace cashfreepg.Interface {

    public class CFPaymentGateway {
        private CFPaymentGateway() {}  
        private static CFPaymentGateway? instance;
        public static CFPaymentGateway getInstance {  
            get {  
                if (instance == null) {  
                    instance = new CFPaymentGateway();  
                }  
                return instance;  
            }  
        }

        public CFOrderResponse orderCreate(CFConfig cfConfig, CFOrderRequest cFOrderRequest, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try
            {
                // Create Order
                var apiInstance = new OrdersApi(config);
                CFOrderResponse result = apiInstance.CreateOrder(cfConfig.clientId, cfConfig.clientSecret, cfConfig.apiVersion,cFOrderRequest, header?.requestID ,null, header?.idempotencyKey);
                return result;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFPayResponse orderPay(CFConfig cfConfig, CFOrderPayRequest cFOrderPayRequest, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new OrdersApi(config);
                CFPayResponse cfPayResponse = apiInstance.OrderPay(cfConfig.apiVersion, cFOrderPayRequest, header?.requestID);
                return cfPayResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFOrderResponse getOrder(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new OrdersApi(config);
                CFOrderResponse cfOrderResponse = apiInstance.GetOrder(cfConfig.clientId,cfConfig.clientSecret, orderID, cfConfig.apiVersion, header?.requestID, null, null);
                Console.WriteLine(cfOrderResponse.cfOrder.OrderStatus);
                return cfOrderResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFPaymentsForOrderResponse getPaymentsForOrder(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new PaymentsApi(config);
                var cFPaymentsForOrderResponse = apiInstance.GetPaymentsfororder(cfConfig.clientId,cfConfig.clientSecret, orderID, cfConfig.apiVersion, null, header?.requestID, null);
                return cFPaymentsForOrderResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFPaymentEntityResponse getPaymentsByPaymentID(CFConfig cfConfig, string orderID, int cfPaymentID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new PaymentsApi(config);
                var cfPaymentsEntity = apiInstance.GetPaymentbyId(cfConfig.clientId,cfConfig.clientSecret, orderID, cfPaymentID, cfConfig.apiVersion, null, header?.requestID, null);
                return cfPaymentsEntity;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFRefundResponse createRefund(CFConfig cfConfig, string orderID, CFRefundRequest cfRefundRequest, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new RefundsApi(config);
                var cfRefundResponse = apiInstance.Createrefund(cfConfig.clientId, cfConfig.clientSecret, orderID, cfConfig.apiVersion, cfRefundRequest, null, header?.idempotencyKey, header?.requestID);
                return cfRefundResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFRefundResponse getRefund(CFConfig cfConfig, string orderID, string refundID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new RefundsApi(config);
                var cfRefundResponse = apiInstance.GetRefund(cfConfig.clientId, cfConfig.clientSecret, orderID, refundID, cfConfig.apiVersion, null, null, header?.requestID);
                return cfRefundResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFAllRefundsResponse getAllRefundsForOrder(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new RefundsApi(config);
                var cfRefundResponse = apiInstance.Getallrefundsfororder(cfConfig.clientId, cfConfig.clientSecret, orderID, cfConfig.apiVersion, header?.requestID, header?.idempotencyKey);
                return cfRefundResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFSettlementsResponse getSettlements(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new SettlementsApi(config);
                var cfSettlementResponse = apiInstance.Getsettlements(cfConfig.clientId, cfConfig.clientSecret, orderID, cfConfig.apiVersion, null, header?.idempotencyKey, header?.requestID);
                return cfSettlementResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFAllInstrumentsResponse getAllSavedInstruments(CFConfig cfConfig, string customerID, string instrumentType = "card", CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new TokenVaultApi(config);
                var instrumentsResponse = apiInstance.FetchAllSavedInstruments(cfConfig.clientId, cfConfig.clientSecret, customerID, instrumentType, cfConfig.apiVersion, null, header?.idempotencyKey, header?.requestID);
                return instrumentsResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFInstrumentsResponse getSavedInstrumentById(CFConfig cfConfig, string customerID, string instrumentID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new TokenVaultApi(config);
                var instrumentResponse = apiInstance.FetchSpecificSavedInstrument(cfConfig.clientId, cfConfig.clientSecret, customerID, instrumentID, cfConfig.apiVersion, null, header?.idempotencyKey, header?.requestID);
                return instrumentResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFCryptogramResponse getCryptogramByInstrumentID(CFConfig cfConfig, string customerID, string instrumentID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new TokenVaultApi(config);
                var cryptogramResponse = apiInstance.FetchCryptogram(cfConfig.clientId, cfConfig.clientSecret, customerID, instrumentID, cfConfig.apiVersion, null, header?.idempotencyKey, header?.requestID);
                return cryptogramResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFInstrumentsResponse deleteInstrumentByID(CFConfig cfConfig, string customerID, string instrumentID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new TokenVaultApi(config);
                var instrumentsResponse = apiInstance.DeleteSpecificSavedInstrument(cfConfig.clientId, cfConfig.clientSecret, customerID, instrumentID, cfConfig.apiVersion, header?.requestID, header?.idempotencyKey);
                return instrumentsResponse;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFLinkResponse createPaymentLink(CFConfig cfConfig, CFLinkRequest cfLinkRequest, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new PaymentLinksApi(config);
                var response = apiInstance.CreatePaymentLink(cfConfig.clientId,cfConfig.clientSecret, cfConfig.apiVersion, cfLinkRequest, header?.requestID, null, header?.idempotencyKey);
                return response;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFLinkResponse getPaymentLinkDetails(CFConfig cfConfig, string linkID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new PaymentLinksApi(config);
                var response = apiInstance.GetPaymentLinkDetails(cfConfig.clientId,cfConfig.clientSecret, linkID, cfConfig.apiVersion, header?.requestID, null, header?.idempotencyKey);
                return response;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFCancelledLinkResponse cancelPaymentLink(CFConfig cfConfig, string linkID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new PaymentLinksApi(config);
                var response = apiInstance.CancelPaymentLink(cfConfig.clientId,cfConfig.clientSecret, linkID, cfConfig.apiVersion, header?.requestID, header?.idempotencyKey);
                return response;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        public CFPaymentLinkOrdersRespnse getPaymentLinkOrders(CFConfig cfConfig, string linkID, CFHeader? header = null) {
            Configuration config = new Configuration();
            config.BasePath = this.getURL(cfConfig.environment);
            config.Timeout = cfConfig.timeout;
            if(cfConfig.webProxy != null) {
                config.Proxy = cfConfig.webProxy;
            }
            try {
                var apiInstance = new PaymentLinksApi(config);
                var response = apiInstance.GetPaymentLinkOrders(cfConfig.clientId,cfConfig.clientSecret, linkID, cfConfig.apiVersion, header?.requestID, null, header?.idempotencyKey);
                return response;
            } catch (ApiException e) {

                CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                if(cfError != null) {
                    throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                } else {
                    throw e;
                }
            }
        }

        private string getURL(CFEnvironment environment) {
            if(environment == CFEnvironment.SANDBOX) {
                return "https://sandbox.cashfree.com/pg";
            }
            return "https://api.cashfree.com/pg";
        }
    }

}