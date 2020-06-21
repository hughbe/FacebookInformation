using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacebookInformation
{
    public class SecurityAndLoginInformation
    {
        public SecurityAndLoginInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public AccountActivity AccountActivity
            => Utilities.Read<AccountActivity>(FolderPath, "account_activity");

        public AccountStatusChanges AccountStatusChanges
            => Utilities.Read<AccountStatusChanges>(FolderPath, "account_status_changes");

        public AdministrativeRecords AdministrativeRecords
            => Utilities.Read<AdministrativeRecords>(FolderPath, "administrative_records");

        public DatrCookieInformation DatrCookieInformation
            => Utilities.Read<DatrCookieInformation>(FolderPath, "datr_cookie_info");

        public LoginProtectionData LoginProtectionData
            => Utilities.Read<LoginProtectionData>(FolderPath, "login_protection_data");

        public LoginsAndLogouts LoginsAndLogouts
            => Utilities.Read<LoginsAndLogouts>(FolderPath, "logins_and_logouts");

        public UsedIpAddresses UsedIpAddresses
            => Utilities.Read<UsedIpAddresses>(FolderPath, "used_ip_addresses");

        public ActiveSessions ActiveSessions
            => Utilities.Read<ActiveSessions>(FolderPath, "where_you're_logged_in");

        public YourFacebookActivity YourFacebookActivity
            => Utilities.Read<YourFacebookActivity>(FolderPath, "your_facebook_activity");
    }
}
