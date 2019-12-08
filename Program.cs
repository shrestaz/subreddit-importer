using RedditSharp;
using System;
using System.Linq;

namespace reddit_importer
{
    class Program
    {
        static void Main(string[] args)
        {
            var importReddit = new Reddit();
            importReddit.LogIn("oldAccountWithSubs", "hunter2");
            var importAccount = importReddit.User;

            var exportReddit = new Reddit();
            exportReddit.LogIn("newAccountNoSubs", "*******");

            int totalSubscriptions = importAccount.SubscribedSubreddits.Count();
            int currentSubscription = 0;

            foreach (string subreddit in importAccount.SubscribedSubreddits.Select(s => s.Name))
            {
                currentSubscription++;
                exportReddit.GetSubreddit(subreddit).Subscribe();
                Console.WriteLine($"Subscribed {exportReddit.User} to {subreddit} ({currentSubscription} of {totalSubscriptions})");
            }
        }
    }
}
