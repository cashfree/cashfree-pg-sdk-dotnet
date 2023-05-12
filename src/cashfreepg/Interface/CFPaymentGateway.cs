using System.Collections.Generic;
using System;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;
using Newtonsoft.Json;
using Sentry;

namespace cashfreepg.Interface {

    public class CFPaymentGateway {

        private CFPaymentGateway() {}  
        private static CFPaymentGateway? instance;
        private string release_version = "2.0.2";

        public static CFPaymentGateway getInstance {  
            get {  
                if (instance == null) {  
                    instance = new CFPaymentGateway();  
                }  
                return instance;  
            }  
        }

        public CFOrderResponse orderCreate(CFConfig cfConfig, CFOrderRequest cFOrderRequest, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFPaymentEntityResponse preAuthorization(CFConfig cfConfig, string orderId, CFAuthorizationRequest cfAuthorizationRequest, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    var result = apiInstance.Preauthorization(cfConfig.clientId, cfConfig.clientSecret, orderId, cfConfig.apiVersion, cfAuthorizationRequest, header?.requestID, null, header?.idempotencyKey);
                    return result;
                } catch (ApiException e) {
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFPayResponse orderPay(CFConfig cfConfig, CFOrderPayRequest cFOrderPayRequest, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFPayResponse orderPaySessions(CFConfig cfConfig, CFOrderPaySessionsRequest cFOrderPaySessionsRequest, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
                Configuration config = new Configuration();
                config.BasePath = this.getURL(cfConfig.environment);
                config.Timeout = cfConfig.timeout;
                if(cfConfig.webProxy != null) {
                    config.Proxy = cfConfig.webProxy;
                }
                try {
                    var apiInstance = new OrdersApi(config);
                    CFPayResponse cfPayResponse = apiInstance.OrderPaySessions(cfConfig.apiVersion, cFOrderPaySessionsRequest, header?.requestID);
                    return cfPayResponse;
                } catch (ApiException e) {
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFOrderResponse getOrder(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
                Configuration config = new Configuration();
                config.BasePath = this.getURL(cfConfig.environment);
                config.Timeout = cfConfig.timeout;
                if(cfConfig.webProxy != null) {
                    config.Proxy = cfConfig.webProxy;
                }
                try {
                    var apiInstance = new OrdersApi(config);
                    CFOrderResponse cfOrderResponse = apiInstance.GetOrder(cfConfig.clientId,cfConfig.clientSecret, orderID, cfConfig.apiVersion, header?.requestID, null, null);
                    return cfOrderResponse;
                } catch (ApiException e) {
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFPaymentsForOrderResponse getPaymentsForOrder(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFPaymentEntityResponse getPaymentsByPaymentID(CFConfig cfConfig, string orderID, int cfPaymentID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFRefundResponse createRefund(CFConfig cfConfig, string orderID, CFRefundRequest cfRefundRequest, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFRefundResponse getRefund(CFConfig cfConfig, string orderID, string refundID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFAllRefundsResponse getAllRefundsForOrder(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFSettlementsResponse getSettlements(CFConfig cfConfig, string orderID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFAllInstrumentsResponse getAllSavedInstruments(CFConfig cfConfig, string customerID, string instrumentType = "card", CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFInstrumentsResponse getSavedInstrumentById(CFConfig cfConfig, string customerID, string instrumentID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFCryptogramResponse getCryptogramByInstrumentID(CFConfig cfConfig, string customerID, string instrumentID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFInstrumentsResponse deleteInstrumentByID(CFConfig cfConfig, string customerID, string instrumentID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFLinkResponse createPaymentLink(CFConfig cfConfig, CFLinkRequest cfLinkRequest, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFLinkResponse getPaymentLinkDetails(CFConfig cfConfig, string linkID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFCancelledLinkResponse cancelPaymentLink(CFConfig cfConfig, string linkID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        public CFPaymentLinkOrdersRespnse getPaymentLinkOrders(CFConfig cfConfig, string linkID, CFHeader? header = null) {
            using (SentrySdk.Init(o =>
            {
                o.Dsn = "https://7674ee5291124b76894cb90a9ac6a33b@o330525.ingest.sentry.io/4505164135464960";
                // When configuring for the first time, to see what the SDK is doing:
                o.Debug = true;
                // Set traces_sample_rate to 1.0 to capture 100% of transactions for performance monitoring.
                // We recommend adjusting this value in production.
                o.TracesSampleRate = 1.0;
                // Enable Global Mode if running in a client app
                o.IsGlobalModeEnabled = false;
                o.EnableTracing = true;
                o.AttachStacktrace = true;
                o.Environment = getEnvironmentInString(cfConfig.environment);
                o.Release = release_version;
            })) {
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
                    SentrySdk.CaptureException(e);
                    CFError? cfError = JsonConvert.DeserializeObject<CFError?>(e.Message);
                    if(cfError != null) {
                        throw new cashfreepg.Client.ApiException(e.ErrorCode, e.StackTrace, cfError, e.Headers);
                    } else {
                        throw e;
                    }
                }
            }
        }

        private string getURL(CFEnvironment environment) {
            if(environment == CFEnvironment.SANDBOX) {
                return "https://sandbox.cashfree.com/pg";
            }
            return "https://api.cashfree.com/pg";
        }

        private string getEnvironmentInString(CFEnvironment environment) {
            if(environment == CFEnvironment.SANDBOX) {
                return "SANDBOX";
            }
            return "PRODUCTION";
        }
    }

}