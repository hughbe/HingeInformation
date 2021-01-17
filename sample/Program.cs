using System;
using System.Linq;

namespace HingeInformation.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var information = new HingeInformation("/Users/hugh/Documents/GitHub/HingeInformation/export");
            //var information = new HingeInformation("<path-to-hinge>");
            Console.WriteLine("-- User --");
            HingeUser user = information.User;
            Console.WriteLine($"Email: {user.Identity.Email}");

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

            Console.WriteLine("-- Subscriptions --");
            HingeSubscription[] subscriptions = information.Subscriptions.ToArray();
            Console.WriteLine($"Count: {subscriptions.Length}");
            foreach (HingeSubscription subscription in subscriptions)
            {
                Console.WriteLine();
            }

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
    }
}
