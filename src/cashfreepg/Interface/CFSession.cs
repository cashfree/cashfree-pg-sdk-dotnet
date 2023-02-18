namespace cashfreepg.Interface {

    public enum CFEnvironment {
        SANDBOX,
        PRODUCTION
    }
    public class CFConfig {
        public CFEnvironment environment;
        public string apiVersion;
        public string clientId;
        public string clientSecret;

        public int timeout;

        public System.Net.WebProxy? webProxy;

        public CFConfig() {}

        public CFConfig(CFEnvironment environment, string apiVersion, string clientId, string clientSecret, int timeout = 180000, System.Net.WebProxy? webProxy = null) {
            this.environment = environment;
            this.apiVersion = apiVersion;
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.webProxy = webProxy;
            this.timeout = timeout;
        }
    }

}