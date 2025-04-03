using System;
using System.Speech.Synthesis;
using Figgle;

namespace chatBot;

class voiceChat
{
    static void Main(String[] args)
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        synth.Volume = 100;
        synth.Rate = 0;

        Boolean loop = true; 
        String user;
        String chatName = "Hermit";
        String userName;

        

        Console.WriteLine("===============================================================================================================");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(FiggleFonts.Standard.Render("     CyberSecurityAwareness"));
        Console.ResetColor();
        Console.WriteLine("===============================================================================================================");
        synth.Speak("Welcome, to cyber security awareness, my name is " + chatName);
        Console.WriteLine("Insert your username ");
        synth.Speak("What is your name");
        Console.WriteLine("Username: ");  
        userName = Console.ReadLine();

        synth.Speak(" Nice to meet you" + userName);
        Console.ForegroundColor= ConsoleColor.Red;
        Console.WriteLine(FiggleFonts.Standard.Render("     Welcome  " + userName));
        Console.WriteLine("(Type 'EXIT' if you wish to end the conversation.)");
        Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine(chatName + ":");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("What can I help you with today " + userName);
        Console.ResetColor();
        synth.Speak("What can I help you with today" + userName);
        Console.WriteLine("");

        while (loop)
        {
            Console.WriteLine("");
            Console.WriteLine(userName + ":");
            Console.ForegroundColor = ConsoleColor.Cyan;
            user = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");


            if (user == "How are you?" || user == "how are you" || user == "How are you doing")
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I am well, thanks for asking, is there something I can help you with regarding cyber security" + userName + "?");
                Console.ResetColor();
                synth.Speak("I am well, thanks for asking, is there something I can help you with regarding cyber security " + userName + "?");

            }
            else if (user == "What's your purpose?" || user == "What's your purpose" || user == "What is your purpose?")
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("My purpose is to provide you with more information regarding cyber awareness.\nI will provide you with information regarding the current topics I have available in cyber awareness");
                Console.ResetColor();
                synth.Speak("My purpose is to provide you with more information regarding cyber awareness, I will provide you with information regarding the current topics I have available in cyber awareness");


            }
            else if (user == "What can I ask you about?" || user == "What can I ask you about?")
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You can ask about the topics regarding cyber awareness, the information I cover are from topics related to: \n\n.Password safety \n.Phishing \n.Safe browsing \n\nWould you like to know more about one of these topics " + userName + "?");
                Console.ResetColor();
                synth.Speak("You can ask about the topics regarding cyber awareness, the information I cover are from topics related to Password Safety, Phishing, and Safe Browsing. Would you like to know more about one these topics " + userName + "");

            }
            else if(user.Contains("Phishing") || user.Contains("phishing"))
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I see you are talking about phishing " + userName + ". Phishing is a cyber crime which aims to steal the user's personal and financial information \nby utilizing false emails, false text messages and false phone calls. \nTips to protect yourself from this crime are as follows: \n\n.Do not share personal information(full names, surnames, ID) \n.Avoid entering unknown links from unknown users \n.Recognize the signs of phishing attacks(Sudden payment requests, unusual links etc.)");
                Console.WriteLine("");
                Console.WriteLine("Is there any other topic you would like to know about between: \n\n.Password Safety \n.Safe Browsing");
                Console.ResetColor();
                synth.Speak("I see you are talking about phishing " + userName + ". Phishing is a cyber crime which aims to steal the user's personal and financial information by utilizing false emails, false text messages and false phone calls. Tips to protect yourself from this crime are as follows. Do not share personal information such as your full names, surnames, and ID .Avoid entering unknown links from unknown users. Recognize the signs of phishing attacks such as Sudden payment requests, and unusual links as an example");
                synth.Speak("Is there any other topic you would like to know about between Password Safety, and Safe Browsing?");
                Console.WriteLine("");
            }
            else if(user.Contains("Password safety") || user.Contains("password safety") || user.Contains("Password Safety"))
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I see you are talking about Password Safety " + userName + ". Some tips regarding passsword safety are as follows: \n\n.Ensure your passoword is complex with multiple characters and numbers \n.Do not share your password with anyone regardless if they are close \n.Do not use the same password for each account \n.Reset your password once in a while \n.Make sure no one sees your password");
                Console.WriteLine("");
                Console.WriteLine("Is there any other topic you would like to know about between: \n\n.Phishing \n.Safe Browsing");
                Console.ResetColor();
                synth.Speak("I see you are talking about Password Safety " + userName + ". Some tips regarding password safety are as follows, Ensure your password is complex with multiple characters and numbers. Do not Share your password with anyone regardless if they are close to you. Do not use the same password for each account. Reset your password once in a while. Make sure no one sees your passwword.");
                synth.Speak("Is there any other topic you would like to know about between Phishing and Safe Browsing?");
                Console.WriteLine("");
            }
            else if(user.Contains("Safe Browsing") || user.Contains("safe browsing") || user.Contains("Safe browsing"))
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I see you talking about Safe Browsing " + userName + ". Some tips regarding safe browsing are as follows: \n\n.Utilize a safe browser \n.Avoid clicking on ads \n.Avoid clicking on notification pop ups \n.Install a trusted anti-virus software \n.Dont visit websites that don't have an HTTPS");
                Console.WriteLine("");
                Console.WriteLine("Is there any other topic you would like to know about between: \n\n.Phishing \n.Password Safety");
                Console.ResetColor();
                synth.Speak("I see you are talking about Safe Browsing " + userName + ". Some tips regarding safe browsing are as follows. Utilize a safe browser. Avoid clicking on ads. Avoid clicking on notification pop ups. Install a trusted anti virus software and Dont visit websites that do not contain an HTTPS");
                synth.Speak("Is there any other topic you would like to know about between Phishing and Password Safety?");
                Console.WriteLine("");
            }
            else if (user == "")
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You seem to have left an empty space, would you like to know about Phishing, Safe Browsing, or Password Safety?");
                Console.ResetColor();
                synth.Speak("You seem to have left an empty space, would you like to know about Phishing, Safe Browsing, or Password Safety?");

            }
            else if (user == "EXIT")
            {
                loop = false;
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Have a good day " + userName + " it was nice chatting with you.");
                Console.ResetColor();
                synth.Speak("Have a good day " + userName + ", it was nice chatting with you.");
            }
            else
            {
                Console.WriteLine(chatName + ":");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I didn't quite get that. Could you rephrase?");
                Console.ResetColor();
                synth.Speak("I didn't quite get that. Could you rephrase?");
            }
        }

    }
}