using System;
using System.Collections.Generic;
using System.IO;

namespace HingeInformation
{
    public class HingeInformation
    {
        public HingeInformation(string folderPath)
        {
            FolderPath = folderPath;
        }

        private string FolderPath { get; }

        public IReadOnlyList<HingePrompt> Prompts => Utilities.Read<IReadOnlyList<HingePrompt>>(FolderPath, "prompts");

        public IReadOnlyList<HingeSubscription> Subscriptions => Utilities.Read<IReadOnlyList<HingeSubscription>>(FolderPath, "subscriptions");

        public HingeUser User => Utilities.Read<HingeUser>(FolderPath, "user");

        public IReadOnlyList<HingeMedia> Media => Utilities.Read<IReadOnlyList<HingeMedia>>(FolderPath, "media");

        public IReadOnlyList<HingeMatch> Matches => Utilities.Read<IReadOnlyList<HingeMatch>>(FolderPath, "matches");
    }
}
