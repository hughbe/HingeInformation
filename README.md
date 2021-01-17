# HingeInformation

C# library to interact with data exported from [Hinge](http://hinge.co/) 😉.

## Installation Instructions
- Install via [NuGet](https://www.nuget.org/packages/HingeInformation/1.0.0)

## Example Usage

- Follow the instructions [here](https://hingeapp.zendesk.com/hc/en-us/articles/360011235813-How-do-I-request-a-copy-of-my-personal-data-) to request a copy of your personal data and extract your personal data to a folder of your choosing.

- To interact with your data, create an instance of `HingeInformation`, passing the path of the folder containing your extracted personal data.

- Sample code:

```cs
var information = new HingeInformation("<path-to-hinge-export-folder>");
// User
Console.WriteLine("-- User --");
HingeUser user = information.User;
Console.WriteLine($"Email: {user.Identity.Email}");

// Prompts
Console.WriteLine("-- Prompts --");
HingePrompt[] prompts = information.Prompts.ToArray();
Console.WriteLine($"Count: {prompts.Length}");
foreach (HingePrompt prompt in prompts)
{
    Console.WriteLine($"Id: {prompt.Id}");
    Console.WriteLine($"Prompt: {prompt.Prompt}");
    Console.WriteLine($"Answer: {prompt.Answer}");
    Console.WriteLine();
}

// Media
Console.WriteLine("-- Media --");
HingeMedia[] mediaList = information.Media.ToArray();
Console.WriteLine($"Count: {mediaList.Length}");
foreach (HingeMedia media in mediaList)
{
    Console.WriteLine($"Type: {media.Type}");
    Console.WriteLine($"Prompt: {media.Url}");
    if (media.Prompt == null)
    {
        Console.WriteLine($"Prompt: null");
    }
    else
    {
        Console.WriteLine($"Prompt: {media.Prompt}");
    }
    if (media.Caption == null)
    {
        Console.WriteLine($"Caption: null");
    }
    else
    {
        Console.WriteLine($"Caption: {media.Caption}");
    }
    if (media.Location == null)
    {
        Console.WriteLine($"Location: null");
    }
    else
    {
        Console.WriteLine($"Location: {media.Location}");
    }
    Console.WriteLine($"FromSocialMedia: {media.FromSocialMedia}");
    Console.WriteLine();
}

// Subscriptions
Console.WriteLine("-- Subscriptions --");
HingeSubscription[] subscriptions = information.Subscriptions.ToArray();
Console.WriteLine($"Count: {subscriptions.Length}");
foreach (HingeSubscription subscription in subscriptions)
{
    Console.WriteLine();
}

// Matches
Console.WriteLine("-- Matches --");
HingeMatch[] matches = information.Matches.ToArray();
Console.WriteLine($"Count: {matches.Length}");
foreach (HingeMatch match in matches)
{
    if (match.Block != null)
    {
        foreach (HingeBlock block in match.Block)
        {
            Console.WriteLine($"Type: {block.BlockType}");
            Console.WriteLine($"Timestamp: {block.Timestamp}");
            Console.WriteLine($"Type: {block.Type}");
        }
    }

    if (match.Chats != null)
    {
        foreach (HingeChat chat in match.Chats)
        {
            Console.WriteLine($"Body: {chat.Body}");
            Console.WriteLine($"Timestamp: {chat.Timestamp}");
            Console.WriteLine($"Type: {chat.Type}");
        }
    }

    if (match.Match != null)
    {
        foreach (HingeMatchMatch matchMatch in match.Match)
        {
            Console.WriteLine($"Timestamp: {matchMatch.Timestamp}");
            Console.WriteLine($"Type: {matchMatch.Type}");
        }
    }

    if (match.Like != null)
    {
        foreach (HingeLike like in match.Like)
        {
            Console.WriteLine($"Timestamp: {like.Timestamp}");
            if (like.Comment == null)
            {
                Console.WriteLine($"Comment: null");
            }
            else
            {
                Console.WriteLine($"Comment: {like.Comment}");
            }
            Console.WriteLine($"Type: {like.Type}");
        }
    }

    if (match.WeMet != null)
    {
        foreach (HingeWeMet weMet in match.WeMet)
        {
            Console.WriteLine($"Timestamp: {weMet.Timestamp}");
            Console.WriteLine($"DidMeetSubject: {weMet.DidMeetSubject}");
            Console.WriteLine($"WasMyType: {weMet.WasMyType}");
            Console.WriteLine($"Type: {weMet.Type}");
        }
    }
}
}
```