using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;

namespace osu_trainer
{
    #region Generated JSON Classes
    public class Author
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }

    }

    public class Uploader
    {
        public string login { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool site_admin { get; set; }

    }

    public class Asset
    {
        public string url { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string name { get; set; }
        public object label { get; set; }
        public Uploader uploader { get; set; }
        public string content_type { get; set; }
        public string state { get; set; }
        public int size { get; set; }
        public int download_count { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public string browser_download_url { get; set; }

    }

    public class Release
    {
        public string url { get; set; }
        public string assets_url { get; set; }
        public string upload_url { get; set; }
        public string html_url { get; set; }
        public int id { get; set; }
        public string node_id { get; set; }
        public string tag_name { get; set; }
        public string target_commitish { get; set; }
        public string name { get; set; }
        public bool draft { get; set; }
        public Author author { get; set; }
        public bool prerelease { get; set; }
        public DateTime created_at { get; set; }
        public DateTime published_at { get; set; }
        public List<Asset> assets { get; set; }
        public string tarball_url { get; set; }
        public string zipball_url { get; set; }
        public string body { get; set; }

    }
    #endregion

    public class Updater
    {
        static readonly string CURRENT_RELEASE_TAG = "1.4"; // Jun: REMEMBER TO CHANGE THIS every time you make a new release.
        public static async void CheckForUpdates()
        {
            if (Properties.Settings.Default.DoNotCheckForUpdates)
                return;

            var client = new HttpClient();
            client.BaseAddress = new Uri(@"https://api.github.com/");
            client.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
            client.DefaultRequestHeaders.Add("User-Agent", "Osu-Trainer");

            Release latestRelease = null;
            try
            {
                var response = await client.GetAsync("/repos/FunOrange/osu-trainer/releases/latest");
                if (response.IsSuccessStatusCode)
                {
                    string responseJson = await response.Content.ReadAsStringAsync();
                    latestRelease = JsonConvert.DeserializeObject<Release>(responseJson);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Update check failed. You have version {CURRENT_RELEASE_TAG}. Check for updates here: https://github.com/FunOrange/osu-trainer/releases/latest {Environment.NewLine}e.Message", "Error");
            }

            if (latestRelease.tag_name != CURRENT_RELEASE_TAG)
            {
                var updaterForm = new UpdaterForm(latestRelease.body);
                if (updaterForm.DoNotCheckForUpdates)
                {
                    Properties.Settings.Default.DoNotCheckForUpdates = true;
                    Properties.Settings.Default.Save();
                }
                if (updaterForm.ShowDialog() == DialogResult.OK)
                {
                    Process.Start(latestRelease.assets[0].browser_download_url);
                    Application.Exit();
                }
            }
        }
    }
}
