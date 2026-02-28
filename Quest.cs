public class Quest
{

    public int ID;
    public string Name;
    public string Description;
    public string Line;
    public string Accept;
    public string Deny;
    public string AcceptDeny;
    public bool Started;
    public bool Completed;
    public bool Denied;



/*
qLine is the sentence given to the player if they enter a location for the first time and a quest is available at said location
qAccept is the sentence given to the player if they immediately accept the quest.
qDeny is the sentence given to the player if they deny a quest. this sentence will be given every time the player denies said quest.
qAcceptDeny is the sentence given to the player if they previously denied the quest, but then accept it. this too will happen every time a player accepts a quest after denying it previously.
*/  
    public Quest(int ID, string Name, string Description, string Line, string Accept, string Deny, string AcceptDeny)
    {
        this.ID = ID;
        this.Name = Name;
        this.Description = Description;
        this.Line = Line;
        this.Accept = Accept;
        this.Deny = Deny;
        this.AcceptDeny = AcceptDeny;
        this.Started = false;
        this.Completed = false;
        this.Denied = false;
    }

    public void Prompt(Player player)
    {
        while (! Started && ! Denied)
        {
            Console.WriteLine("Will you accept the quest?");
            string playeranswer = Console.ReadLine().ToUpper();
            if (playeranswer == "Y")
            {
                    Console.WriteLine(Accept);
                    Started = true;
                    player.CurrentQuests.Add(Name);
            }

            else if (playeranswer == "N")
            {
                    Console.WriteLine(Deny);
                    Denied = true;
            }
        }
    }

    public void ActivateQuest(Player player)
    {
        if (! Started && ! Completed)
        {
            if(! Denied)
            {
                Console.WriteLine(Line);
                Console.WriteLine(Name + ": " + Description);
                Prompt(player);
            }

            else if(Denied)
            {
                Console.WriteLine(AcceptDeny);
                Console.WriteLine(Name + ": " + Description);
                Denied = false;
                Prompt(player);
            }
        }
    }

    public void CompleteQuest(Player player) 
    {
        Completed = true;
        player.CompletedQuests.Add(Name);
        Rewards.QuestReward(player, this.ID);
    }
}