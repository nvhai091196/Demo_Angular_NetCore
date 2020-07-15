namespace demo.utilities
{
    public class Statics
    {
        public const string LANG_VI = "VI";
        public const string LANG_EN = "EN";

        public const string dateFormat = "dd/MM/yyyy";
        public const string dateTimeFormat = "dd/MM/yyyy HH:mm";
        public const string ConfirmLimitStartTime = "07:30";
        public const string ConfirmLimitEndTime = "08:30";
        public const string BMI_For_Age = "BMI-for-age";
        public const string Height_For_Age = "height-for-age";
        public const string Weight_For_Age = "weight-for-age";
        public const string GIRLS = "girls";
        public const string BOYS = "boys";

        #if !DEBUG
                public const string DOMAIN = "http://hoangphatcoffee.com";
        #else
                public const string DOMAIN = "https://localhost:5001";
        #endif
    }
}