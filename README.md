## Import subreddit subscription from one account to another.
[Source: /u/Hammond-of-Texas](https://www.reddit.com/r/Enhancement/comments/6r2d3w/is_there_a_way_to_import_and_export_subreddits/)

## Requirements:
1. Git and [.NET Core](https://dotnet.microsoft.com/download)
2. Text editor
3. Username and password for both reddit accounts

## Steps to reprouce:
1. Clone the project.

`git clone https://github.com/shrestaz/subreddit-importer.git`

2. Open `Program.cs` with some text editor.

3. Update line 12 with account information you want to export subreddits from.

`importReddit.LogIn("oldAccountWithSubs", "hunter2");`

4. Update line 16 with the account information you want to import subreddits to.

`exportReddit.LogIn("newAccountNoSubs", "*******");`

5. Save.

6. From a terminal, navigate to the project folder and run.

`path/to/project/folder/subreddit-importer> dotnet run`

7. It will take some time, be patient. ⌚

8. Voilà. You're done. Remove the project from your machine.
