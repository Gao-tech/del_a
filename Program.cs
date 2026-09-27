List<int> priser= new List<int>();
List<string> varor=new List<string>();

bool kr = true;
int count =0;

while (kr)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara ");
    Console.WriteLine("3. visa varor ");
    Console.WriteLine("4. Avsluta");
    Console.Write("\nVälj: ");
    int val = Convert.ToInt16(Console.ReadLine());

    if(val == 4)
     {
        kr = false;
    }  else if(val == 1){
        Console.Write($" Skriva vara name : ");
        string? vara = Convert.ToString(Console.ReadLine()); 
        Console.Write($" pris av {vara} : ");
        int pris = Convert.ToInt32(Console.ReadLine());
        varor.Add(vara);
        priser.Add(pris);
        count++;
        Console.WriteLine("Tryck Enter för att fortsätta.");
        Console.ReadLine();

        
    } else if(val == 2)
    {
        if(varor.Count == 0)
        {
              Console.WriteLine("Det finns inga varor att ta bort.");
           
        }
        else
        { 
             Console.Write("Vilket vara vill du ta bort? ");
             string sokVara = Console.ReadLine();
            
            int index = varor.IndexOf(sokVara);

            if (index == -1){
                 Console.WriteLine("Varan finns inte i listan.");
                }
            else
            {
                varor.RemoveAt(index);
                 priser.RemoveAt(index);
            }
        }

        Console.WriteLine("Tryck Enter för att fortsätta.");
        Console.ReadLine();
    } else if(val == 3)
    {
       if(varor.Count ==0)
        {
             Console.WriteLine("Listan är tom.");
        } else {

         Console.WriteLine("\n************** All varor *****************");
         int totalSumma =0;

         for (int i = 0; i < varor.Count; i++){
          Console.WriteLine($"{i +1} {varor[i]} - {priser[i]} kr");
            totalSumma += priser[i];
        }
        Console.WriteLine($"Total summa: {totalSumma} kr");
        }
        Console.WriteLine("Tryck Enter för att fortsätta.");
        Console.ReadLine();
        
    } else
    {
        Console.WriteLine("Skriva du fel Välj. Välj mellen 1 och 4");
        Console.WriteLine("Tryck Enter för att fortsätta.");
        Console.ReadLine();
    }
}
