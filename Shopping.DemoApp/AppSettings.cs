namespace Shopping.DemoApp
{
    public static class AppSettings
    {
        public const string ApiAddress = "http://xamarin-azure-demo-multitenant.azurewebsites.net/";
        //public const string ApiAddress = "http://localhost:62162/";
        public const string NotificationHubConnectionString = "Endpoint=sb://xamarinazuredemonotifications.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=R3E6O0BMgad19DaPuYq13UC2D4XF5Wi1wzoqjx2MbgA=";
        public const string NotificationHubPath = "xamarin-azure-demo-notifications";
        public const string EmotionApiKey = "628d564565954e8aa7dc3217ac34b3a7";

#if __ANDROID__
        public const string AndroidProjectNumber = "674319019911";
        public const string AndroidPackageId = "com.microsoft.shoppingdemoapp";
#endif
    }
}
