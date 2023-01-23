Console.Clear();

Console.WriteLine("Введите трехзначное число.\nВыход из программы командой Exit.");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("exit"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }