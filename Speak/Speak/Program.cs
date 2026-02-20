using ISpeakTest;



   
       List<ISpeak> speakers = new List<ISpeak>();  

ISpeak speaker = new Dog();
            speaker.Speak();
speakers.Add(speaker);

            speaker = new Cow();
            speaker.Speak();
speakers.Add(speaker);

            speaker = new Philosoper();
            speaker.Speak();
( (Philosoper)speaker).Think();

speakers.Add(speaker);

foreach (ISpeak s in speakers)
{
    s.Speak();
}



//Woof
//Muuh!
//Hello World.
//I think, there for I am.
//Woof
//Muuh!
//Hello World.