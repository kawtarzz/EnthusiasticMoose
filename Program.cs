using System;
// declaring namespace

//calling our 'main function'
Main();
// 'declaring our main function'
void Main()
{
  void MooseSays(string message)
  {
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
  }
  MooseSays("H I, I'M  E N T H U S I A S T I C !");


  bool MooseAsks(string question)
  {
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
      Console.Write($"{question} (Y/N): ");
      answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  void CanadaQuestion()
  {
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
      MooseSays("Really? It seems very unlikely.");
    }
    else
    {
      MooseSays("I KNEW IT!!!");
    }
  }
  void EnthusiasticQuestion()
  {
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
      MooseSays("Yay!");
    }
    else
    {
      MooseSays("You should try it!");
    }
  }

  void LoveCSharpQuestion()
  {
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
      MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
      MooseSays("You will...oh, yes, you will...");
    }
  }

  void SecretQuestion()
  {
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
      MooseSays("My antlers are full of drugs LOL!!! Ok now you tell me one!!");
    }
    else
    {
      MooseSays("Oh, no...secrets are the best, I love to share them! Are you sure you don't want to know?");
    }
  }
  CanadaQuestion();
  EnthusiasticQuestion();
  LoveCSharpQuestion();
  SecretQuestion();
}