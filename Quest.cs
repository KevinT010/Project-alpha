public class Quest
{

    public int qID;
    public string qName;
    public string qDescription;
    public string qLine;
    public bool qStarted;
    public bool qCompleted;


    public Quest(int qid, string qname, string qDescription, string qLine, string qAccept, string qDeny, string qAcceptDeny)
    {
        this.qID = qid;
        this.qName = qname;
        this.qDescription = qDescription;
        this.qLine = qLine;
        this.qStarted = false;
        this.qCurrent = 0;
        this.qCompleted = false;
        this.qDenied = false;
    }

    public void qPrompt()
    {
        while (! qStarted && ! qDenied)
                {
                    Console.WriteLine("Will you accept the quest?");
                    if (Console.ReadLine().toUpper() == "Y")
                    {
                            Console.WriteLine(qAccept);
                            qStarted = true;
                            qCurrent = qID;

                    }
                    else if (Console.ReadLine().ToUpper() == "N")
                    {
                            Console.WriteLine(qDeny);
                            qDenied = true;
                    }
                }
    }

    public void ActivateQuest()
    {
        if (! qStarted)
        {
            if(! qDenied)
            {
                Console.WriteLine(qLine);
                Console.WriteLine(&"'{qName}'   {qDescription}");
                qPrompt;
            }

            else if(qDenied)
            {
                Console.WriteLine(qAcceptDeny);
                Console.WriteLine(&"'{qName}'   {qDescription}");
                qDenied = false;
                qPrompt;
            }
        }
    }




}