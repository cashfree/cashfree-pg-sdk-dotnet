namespace cashfreepg.Interface {

    public class CFHeader {
        public string? requestID;
        public string? idempotencyKey;

        public CFHeader() {}

        public CFHeader(string? requestID = null, string? idempotencyKey = null) {
            if(requestID != null) {
                this.requestID = requestID;
            }
            if(idempotencyKey != null) {
                this.idempotencyKey = idempotencyKey;
            }
        }
    }

}