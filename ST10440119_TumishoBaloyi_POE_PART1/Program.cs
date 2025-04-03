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

        Console.WriteLine("Welcome to cyber security awareness!!!");
        synth.Speak("Welcome, to cyber security awareness, my name is " + chatName);
        Console.WriteLine("Insert your username: ");
        synth.Speak("What is your name");
        userName = Console.ReadLine();
        Console.WriteLine("=========================================================================================================");

        synth.Speak(" Nice to meet you" + userName);
        Console.WriteLine(FiggleFonts.Standard.Render("     CyberSecurityAwareness"));
        Console.WriteLine("=========================================================================================================");
        Console.WriteLine(FiggleFonts.Standard.Render("     Welcome"));
        Console.WriteLine("(Type 'EXIT' if you wish to end the conversation.)");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine(chatName + ":");
        Console.WriteLine("What can I help you with today " + userName);
        synth.Speak("What can I help you with today" + userName);
        Console.WriteLine("");

        while (loop)
        {
            Console.WriteLine("");
            Console.WriteLine(userName + ":");
            user = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("");


            if (user == "How are you?" || user == "how are you" || user == "How are you doing")
            {
                Console.WriteLine(chatName + ":");
                Console.WriteLine("I am well, thanks for asking");
                synth.Speak("I am well, thanks for asking");

            }
            else if (user == "What's your purpose?" || user == "What's your purpose" || user == "What is your purpose?")
            {
                Console.WriteLine(chatName + ":");
                Console.WriteLine("My purpose is to provide you with more information regarding cyber awareness, I will provide you with information regarding the current topics available in cyber awareness");
                synth.Speak("My purpose is to provide you with more information regarding cyber awareness, I will provide you with information regarding the current topics available in cyber awareness");


            }
            else if (user == "What can I ask you about?" || user == "What can I ask you about?")
            {
                Console.WriteLine(chatName + ":");
                Console.WriteLine("You can ask about the topics regarding cyber awareness, the information we cover are from topics related to password safety, phishing, and safe browsing");
                synth.Speak("You can ask about the topics regarding cyber awareness, the information we cover are from topics related to Password Safety, Phishing, and Safe Browsing");

            }
            else if (user == "")
            {
                Console.WriteLine("May you repeat, I am not sure I got that");
                synth.Speak("May you repeat, I am not sure I got that.");

            }
            else if (user == "EXIT")
            {
                loop = false;
                Console.WriteLine(chatName + ":");
                Console.WriteLine("Have a good day " + userName + " it was nice chatting with you.");
            }
            else
            {
                Console.WriteLine("May you repeat that, I am not sure if I understood that.");
                synth.Speak("May you repeat that, I am not sure if I understood that.");
            }
        }

    }
}