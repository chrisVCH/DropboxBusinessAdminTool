﻿namespace DfBAdminToolkit.Model {

    using System.Collections.Generic;
    using System.IO;

    public class DumpUserContentModel
        : IDumpUserContentModel {
        public string UserAccessToken { get; set; }

        public List<TeamListViewItemModel> MemberList { get; set; }

        public string OutputFolder { get; set; }

        public bool ZipFiles { get; set; }

        public bool SuspendUser { get; set; }

        public bool DeleteUser { get; set; }

        public bool KeepAccount { get; set; }

        public DumpUserContentModel() {
            UserAccessToken = ApplicationResource.DefaultAccessToken;
            MemberList = new List<TeamListViewItemModel>();
        }

        public void Initialize() {
            OutputFolder = Directory.GetCurrentDirectory();
        }

        public void CleanUp() {
        }
    }
}