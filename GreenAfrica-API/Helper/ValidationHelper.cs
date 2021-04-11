namespace GreenAfrica_API.Helper
{

    public static class ValidationHelper
    {
        public static (bool Valid, string PhoneNumber) ValidatePhoneNumber(string phoneNumber, string countryCode)
        {
            phoneNumber = phoneNumber.Replace("+", "");
            if (string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(countryCode))
            {
                return (false, phoneNumber);
            }
            if (phoneNumber != "000000")
            {
                switch (countryCode)
                {
                    case "KE":
                        {
                            if (!phoneNumber.StartsWith("254"))
                            {

                                if (phoneNumber.Length != 10 && phoneNumber.Length != 9)
                                {
                                    return (false, phoneNumber);
                                }
                                if (phoneNumber.StartsWith("0"))
                                {
                                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1);
                                }
                                phoneNumber = "254" + phoneNumber;
                            }
                            return (true, phoneNumber);
                        }
                    case "UG":
                        {
                            if (!phoneNumber.StartsWith("256"))
                            {
                                if (phoneNumber.Length != 10 && phoneNumber.Length != 9)
                                {
                                    return (false, phoneNumber);
                                }
                                if (phoneNumber.StartsWith("0"))
                                {
                                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1);
                                }
                                phoneNumber = "256" + phoneNumber;
                            }
                            return (true, phoneNumber);
                        }
                    case "CD":
                        {
                            if (!phoneNumber.StartsWith("243"))
                            {
                                if (phoneNumber.Length != 10 && phoneNumber.Length != 9)
                                {
                                    return (false, phoneNumber);
                                }
                                if (phoneNumber.StartsWith("0"))
                                {
                                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1);
                                }
                                phoneNumber = "243" + phoneNumber;
                            }
                            return (true, phoneNumber);
                        }
                    case "TZ":
                        {
                            if (!phoneNumber.StartsWith("255"))
                            {
                                if (phoneNumber.Length != 10 && phoneNumber.Length != 9)
                                {
                                    return (false, phoneNumber);
                                }
                                if (phoneNumber.StartsWith("0"))
                                {
                                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1);
                                }
                                phoneNumber = "255" + phoneNumber;
                            }
                            return (true, phoneNumber);
                        }
                    case "RW":
                        {
                            if (!phoneNumber.StartsWith("250"))
                            {
                                if (phoneNumber.Length != 10 && phoneNumber.Length != 9)
                                {
                                    return (false, phoneNumber);
                                }
                                if (phoneNumber.StartsWith("0"))
                                {
                                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1);
                                }
                                phoneNumber = "250" + phoneNumber;
                            }
                            return (true, phoneNumber);
                        }
                    case "SS":
                        {
                            if (!phoneNumber.StartsWith("211"))
                            {
                                if (phoneNumber.Length != 10 && phoneNumber.Length != 9)
                                {
                                    return (false, phoneNumber);
                                }
                                if (phoneNumber.StartsWith("0"))
                                {
                                    phoneNumber = phoneNumber.Substring(1, phoneNumber.Length - 1);
                                }
                                phoneNumber = "211" + phoneNumber;
                            }
                            return (true, phoneNumber);
                        }
                    default:
                        break;
                }
            }
            return (true, phoneNumber);

        }


        public static string CleanPhoneNumber(string phoneNumber, string countryCode = "KE")
        {
            if (phoneNumber.StartsWith("0") && countryCode == "CD")
            {
                phoneNumber = "+243" + phoneNumber.Remove(0, 1);
            }
            if (countryCode == "KE")
            {
                // 254763679023
                if (phoneNumber.StartsWith("000"))
                {
                    phoneNumber = "254" + phoneNumber.Remove(0, 3);
                }
                if (phoneNumber.StartsWith("00"))
                {
                    phoneNumber = "254" + phoneNumber.Remove(0, 2);
                }
                if (phoneNumber.StartsWith("0"))
                {
                    phoneNumber = "254" + phoneNumber.Remove(0, 1);
                }
                if (phoneNumber.StartsWith("25400") && phoneNumber.Length > 12)
                {
                    phoneNumber = "254" + phoneNumber.Remove(0, 5);
                }
                if (phoneNumber.StartsWith("2540254") && phoneNumber.Length > 12)
                {
                    phoneNumber = "254" + phoneNumber.Remove(0, 7);
                }
                if (phoneNumber.StartsWith("25400") && phoneNumber.Length > 12)
                {
                    phoneNumber = "254" + phoneNumber.Remove(0, 5);
                }
                if (phoneNumber.StartsWith("254254") && phoneNumber.Length > 12)
                {
                    phoneNumber = phoneNumber.Remove(0, 3);
                }
            }

            return phoneNumber;
        }
        public static bool ValidateTransferType(string transferType)
        {
            if (string.IsNullOrEmpty(transferType))
                return false;

            if (transferType.ToLower().Contains("interbank") || transferType.ToLower().Contains("intrabank") || transferType.ToLower().Contains("ownaccount")
                || transferType.ToLower().Contains("swift"))
                return true;

            return false;
        }
    }
}
