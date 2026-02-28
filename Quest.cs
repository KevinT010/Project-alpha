public class Quest
{

    public int qID;
    public string qName;
    public string qDescription;
    public string qLine;
    public string qAccept;
    public string qDeny;
    public string qAcceptDeny;
    public bool qStarted;
    public bool qCompleted;
    public bool qDenied;



/*
qLine is the sentence given to the player if they enter a location for the first time and a quest is available at said location
qAccept is the sentence given to the player if they immediately accept the quest.
qDeny is the sentence given to the player if they deny a quest. this sentence will be given every time the player denies said quest.
qAcceptDeny is the sentence given to the player if they previously denied the quest, but then accept it. this too will happen every time a player accepts a quest after denying it previously.
*/  
    public Quest(int qID, string qName, string qDescription, string qLine, string qAccept, string qDeny, string qAcceptDeny)
    {
        this.qID = qID;
        this.qName = qName;
        this.qDescription = qDescription;
        this.qLine = qLine;
        this.qAccept = qAccept;
        this.qDeny = qDeny;
        this.qAcceptDeny = qAcceptDeny;
        this.qStarted = false;
        this.qCompleted = false;
        this.qDenied = false;
    }

    public void qPrompt(Player player)
    {
        while (! qStarted && ! qDenied)
        {
            Console.WriteLine("Will you accept the quest?");
            string playeranswer = Console.ReadLine().ToUpper();
            if (playeranswer == "Y")
            {
                    Console.WriteLine(qAccept);
                    qStarted = true;
                    player.CurrentQuests.Add(qName);
            }

            else if (playeranswer == "N")
            {
                    Console.WriteLine(qDeny);
                    qDenied = true;
            }
        }
    }

    public void ActivateQuest(Player player)
    {
        if (! qStarted && ! qCompleted)
        {
            if(! qDenied)
            {
                Console.WriteLine(qLine);
                Console.WriteLine(qName + ": " + qDescription);
                qPrompt(player);
            }

            else if(qDenied)
            {
                Console.WriteLine(qAcceptDeny);
                Console.WriteLine(qName + ": " + qDescription);
                qDenied = false;
                qPrompt(player);
            }
        }
    }

    public void CompleteQuest(Player player) //Waarschijnlijk nog niet goed
    {
        qCompleted = true;
        player.CompletedQuests.Add(qName);
        Console.WriteLine($"You have completed the quest {qName}!");
        Console.WriteLine("Here's your reward: ");
    }
}