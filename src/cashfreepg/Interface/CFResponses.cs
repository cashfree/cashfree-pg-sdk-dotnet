using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using cashfreepg.Model;
namespace cashfreepg.Interface {

public class CFOrderResponse {  
    public CFOrder? cfOrder;  
    public Dictionary<string, string>? cfHeaders;

    protected CFOrderResponse() {}

    public CFOrderResponse(CFOrder cfOrder, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfOrder = cfOrder;
        this.cfHeaders = cfHeaders;
    }
}

public class CFPayResponse {
    public CFOrderPayResponse? cfOrderPayResponse;  
    public Dictionary<string, string>? cfHeaders;

    protected CFPayResponse() {}

    public CFPayResponse(CFOrderPayResponse cfOrderPayResponse, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfOrderPayResponse = cfOrderPayResponse;
        this.cfHeaders = cfHeaders;
    }
}

public class CFPaymentsForOrderResponse {
    public List<CFPaymentsEntity>? cfPaymentsEntities;  
    public Dictionary<string, string>? cfHeaders;

    protected CFPaymentsForOrderResponse() {}

    public CFPaymentsForOrderResponse(List<CFPaymentsEntity>? cfPaymentsEntities, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfPaymentsEntities = cfPaymentsEntities;
        this.cfHeaders = cfHeaders;
    }
}

public class CFPaymentEntityResponse {
    public CFPaymentsEntity? cfPaymentsEntity;  
    public Dictionary<string, string>? cfHeaders;

    protected CFPaymentEntityResponse() {}

    public CFPaymentEntityResponse(CFPaymentsEntity? cfPaymentsEntity, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfPaymentsEntity = cfPaymentsEntity;
        this.cfHeaders = cfHeaders;
    }
}

public class CFRefundResponse {
    public CFRefund? cfRefund;  
    public Dictionary<string, string>? cfHeaders;

    protected CFRefundResponse() {}

    public CFRefundResponse(CFRefund? cfRefund, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfRefund = cfRefund;
        this.cfHeaders = cfHeaders;
    }
}

public class CFAllRefundsResponse {
    public List<CFRefund>? cfRefunds;  
    public Dictionary<string, string>? cfHeaders;

    protected CFAllRefundsResponse() {}

    public CFAllRefundsResponse(List<CFRefund>? cfRefunds, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfRefunds = cfRefunds;
        this.cfHeaders = cfHeaders;
    }
}

public class CFSettlementsResponse {
    public CFSettlementsEntity cfSettlementsEntity;  
    public Dictionary<string, string>? cfHeaders;

    protected CFSettlementsResponse() {}

    public CFSettlementsResponse(CFSettlementsEntity? cfSettlementsEntity, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfSettlementsEntity = cfSettlementsEntity;
        this.cfHeaders = cfHeaders;
    }
}

public class CFAllInstrumentsResponse {
    public List<CFFetchAllSavedInstruments> cfInstruments;  
    public Dictionary<string, string>? cfHeaders;

    protected CFAllInstrumentsResponse() {}

    public CFAllInstrumentsResponse(List<CFFetchAllSavedInstruments>? cfInstruments, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfInstruments = cfInstruments;
        this.cfHeaders = cfHeaders;
    }
}

public class CFInstrumentsResponse {
    public CFFetchAllSavedInstruments cfInstrument;  
    public Dictionary<string, string>? cfHeaders;

    protected CFInstrumentsResponse() {}

    public CFInstrumentsResponse(CFFetchAllSavedInstruments? cfInstrument, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfInstrument = cfInstrument;
        this.cfHeaders = cfHeaders;
    }
}

public class CFCryptogramResponse {
    public CFCryptogram cfCryptogram;  
    public Dictionary<string, string>? cfHeaders;

    protected CFCryptogramResponse() {}

    public CFCryptogramResponse(CFCryptogram? cfCryptogram, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfCryptogram = cfCryptogram;
        this.cfHeaders = cfHeaders;
    }
}

public class CFLinkResponse {
    public CFLink? cfLink;  
    public Dictionary<string, string>? cfHeaders;

    protected CFLinkResponse() {}

    public CFLinkResponse(CFLink? cfLink, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfLink = cfLink;
        this.cfHeaders = cfHeaders;
    }
}

public class CFCancelledLinkResponse {
    public CFLinkCancelledResponse cfLink;  
    public Dictionary<string, string>? cfHeaders;

    protected CFCancelledLinkResponse() {}

    public CFCancelledLinkResponse(CFLinkCancelledResponse? cfLink, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfLink = cfLink;
        this.cfHeaders = cfHeaders;
    }
}

public class CFPaymentLinkOrdersRespnse {
    public List<CFLinkOrders> cfLinkOrders;  
    public Dictionary<string, string>? cfHeaders;

    protected CFPaymentLinkOrdersRespnse() {}

    public CFPaymentLinkOrdersRespnse(List<CFLinkOrders>? cfLinkOrders, Dictionary<string, string>? cfHeaders = default(Dictionary<string, string>?)) {
        this.cfLinkOrders = cfLinkOrders;
        this.cfHeaders = cfHeaders;
    }
}

}