// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class OnlineSettingsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.OnlineSettings";

        /// <summary>
        /// "Online"
        /// </summary>
        public static LocalisableString OnlineSectionHeader => new TranslatableString(getKey(@"online_section_header"), @"Online");

        /// <summary>
        /// "Alerts and Privacy"
        /// </summary>
        public static LocalisableString AlertsAndPrivacyHeader => new TranslatableString(getKey(@"alerts_and_privacy_header"), @"Alerts and Privacy");

        /// <summary>
        /// "Show a notification when someone mentions your name"
        /// </summary>
        public static LocalisableString NotifyOnMentioned => new TranslatableString(getKey(@"notify_on_mentioned"), @"Show a notification when someone mentions your name");

        /// <summary>
        /// "Show a notification when you receive a private message"
        /// </summary>
        public static LocalisableString NotifyOnPrivateMessage => new TranslatableString(getKey(@"notify_on_private_message"), @"Show a notification when you receive a private message");

        /// <summary>
        /// "Integrations"
        /// </summary>
        public static LocalisableString IntegrationsHeader => new TranslatableString(getKey(@"integrations_header"), @"Integrations");

        /// <summary>
        /// "Discord Rich Presence"
        /// </summary>
        public static LocalisableString DiscordRichPresence => new TranslatableString(getKey(@"discord_rich_presence"), @"Discord Rich Presence");

        /// <summary>
        /// "Web"
        /// </summary>
        public static LocalisableString WebHeader => new TranslatableString(getKey(@"web_header"), @"Web");

        /// <summary>
        /// "Warn about opening external links"
        /// </summary>
        public static LocalisableString ExternalLinkWarning => new TranslatableString(getKey(@"external_link_warning"), @"Warn about opening external links");

        /// <summary>
        /// "Prefer downloads without video"
        /// </summary>
        public static LocalisableString PreferNoVideo => new TranslatableString(getKey(@"prefer_no_video"), @"Prefer downloads without video");

        /// <summary>
        /// "Automatically download beatmaps when spectating"
        /// </summary>
        public static LocalisableString AutomaticallyDownloadWhenSpectating => new TranslatableString(getKey(@"automatically_download_when_spectating"), @"Automatically download beatmaps when spectating");

        /// <summary>
        /// "Show explicit content in search results"
        /// </summary>
        public static LocalisableString ShowExplicitContent => new TranslatableString(getKey(@"show_explicit_content"), @"Show explicit content in search results");

        private static string getKey(string key) => $"{prefix}:{key}";
    }
}
